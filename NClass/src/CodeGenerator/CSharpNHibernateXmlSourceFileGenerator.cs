﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using NClass.Core;
using NClass.CSharp;
using System.Xml;

using System.Linq;

namespace NClass.CodeGenerator
{
    internal sealed class CSharpNHibernateXmlSourceFileGenerator 
        : SourceFileGenerator
    {
        List<string> entities;
        List<string> properties;

		/// <exception cref="NullReferenceException">
		/// <paramref name="type"/> is null.
		/// </exception>
        public CSharpNHibernateXmlSourceFileGenerator
            (TypeBase type, string rootNamespace, Model model)
			: base(type, rootNamespace, model)
		{}

        protected override string Extension
        {
            get { return ".hbm.xml"; }
        }

        protected override void WriteFileContent()
        {
            entities = new List<string>();
            foreach (IEntity entity in Model.Entities)
            {
                entities.Add(entity.Name);
            }

            ClassType _class = (ClassType)Type;

            properties = new List<string>();
            foreach (Operation operation in _class.Operations)
            {
                if (operation is Property)
                    properties.Add(operation.Name);
            }

            bool useLazyLoading = Settings.Default.UseLazyLoading;
            bool delByUnderscore = Settings.Default.UseLowercaseAndUnderscoredWordsInDb;
            string idGeneratorType = EnumExtensions.GetDescription(Settings.Default.IdGeneratorType);

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.NewLineOnAttributes = true;
            settings.Encoding = System.Text.Encoding.Unicode;

            using (XmlWriter xml = XmlWriter.Create(CodeBuilder, settings))
            {
                xml.WriteStartDocument();
                xml.WriteComment(
                    string.Format(
                    " This code was generated by {0} ", 
                    GetVersionString()
                    ));
                xml.WriteStartElement("hibernate-mapping", "urn:nhibernate-mapping-2.2");
                xml.WriteAttributeString("assembly", ProjectName);
                xml.WriteAttributeString("namespace", RootNamespace);
                xml.WriteStartElement("class");
                xml.WriteAttributeString("name", _class.Name);
                xml.WriteAttributeString("table", 
                    string.Format("`{0}`",
                    PrefixedText(
                    delByUnderscore 
                    ? LowercaseAndUnderscoredWord(_class.Name) 
                    : _class.Name
                    )));
                xml.WriteAttributeString("lazy", 
                    useLazyLoading 
                    ? "true" 
                    : "false");

                List<Property> compositeId = new List<Property>();
                
                int index = 0;

                if (entities.Contains(_class.Operations.ToList()[0].Type))
                {
                    for (; index <= (_class.Operations.Count() - 1); index++)
                    {
                        if (_class.Operations.ToList()[index] is Property)
                        {
                            Property property = (Property)_class.Operations.ToList()[index];

                            if (entities.Contains(property.Type))
                            {
                                compositeId.Add(property);
                            }
                            else
                            {
                                break;
                            }
                        }
                    }                
                }

                if(compositeId.Count > 1)
                {
                    xml.WriteStartElement("composite-id");
                    foreach (var id in compositeId)
                    {
                        xml.WriteStartElement("key-many-to-one");
                        xml.WriteAttributeString("name", id.Name);
                        xml.WriteAttributeString("column",
                            string.Format("`{0}`",
                            delByUnderscore
                            ? LowercaseAndUnderscoredWord(id.Name)
                            : id.Name));
                        xml.WriteAttributeString("class", id.Type);
                        xml.WriteEndElement();
                    }
                    xml.WriteEndElement();
                }
                else
                {
                    index = 0;
                }

                for (; index <= (_class.Operations.Count() - 1); index++)
                {
                    if (_class.Operations.ToList()[index] is Property)
                    {
                        Property property = (Property)_class.Operations.ToList()[index];

                        if (property.Name == properties[0])
                        {
                            xml.WriteStartElement("id");
                            xml.WriteAttributeString("name", property.Name);
                            xml.WriteAttributeString("column",
                                string.Format("`{0}`",
                                delByUnderscore
                                ? LowercaseAndUnderscoredWord(property.Name)
                                : property.Name));
                            xml.WriteAttributeString("type", property.Type);
                            xml.WriteAttributeString("generator", idGeneratorType);
                            xml.WriteEndElement();
                        }
                        else if (entities.Contains(property.Type))
                        {
                            xml.WriteStartElement("many-to-one");
                            xml.WriteAttributeString("name", property.Name);
                            xml.WriteAttributeString("class", property.Type);
                            xml.WriteAttributeString("column",
                                string.Format("`{0}`",
                                delByUnderscore
                                ? LowercaseAndUnderscoredWord(property.Name)
                                : property.Name));
                            xml.WriteAttributeString("not-null", "true");
                            xml.WriteEndElement();
                        }
                        else
                        {
                            xml.WriteStartElement("property");
                            xml.WriteAttributeString("name", property.Name);
                            xml.WriteAttributeString("column",
                                string.Format("`{0}`",
                                delByUnderscore
                                ? LowercaseAndUnderscoredWord(property.Name)
                                : property.Name));
                            xml.WriteAttributeString("type", property.Type);
                            xml.WriteAttributeString("not-null", "true");
                            xml.WriteEndElement();
                        }
                    }
                }

                xml.WriteEndElement();
                xml.WriteEndElement();
                xml.WriteEndDocument();
            }
        }
    }
}