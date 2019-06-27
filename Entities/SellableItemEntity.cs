using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LX.Plugin.ImportSellableItems.Entities
{
    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public class Products
    {

        public ProductsProduct productField;

        public List<ProductsProduct> ProductList { get; set; }

        /// <remarks/>
        public ProductsProduct Product
        {
            get
            {
                return this.productField;
            }
            set
            {
                this.productField = value;
            }
        }
    }

    /// Product Node 
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class ProductsProduct
    {

        public string NameField;

        public ProductsProductProduct productField;

        public string idField;

        public string userTypeIDField;

        public bool selectedField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }

        /// <remarks/>
        public ProductsProductProduct Product
        {
            get
            {
                return this.productField;
            }
            set
            {
                this.productField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UserTypeID
        {
            get
            {
                return this.userTypeIDField;
            }
            set
            {
                this.userTypeIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Selected
        {
            get
            {
                return this.selectedField;
            }
            set
            {
                this.selectedField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class ProductsProductProduct
    {

        public string nameField;

        public ProductsProductProductValue[] valuesField;

        public ProductsProductProductProduct[] productField;

        public string idField;

        public string userTypeIDField;

        public bool selectedField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Value", IsNullable = false)]
        public ProductsProductProductValue[] Values
        {
            get
            {
                return this.valuesField;
            }
            set
            {
                this.valuesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Product")]
        public ProductsProductProductProduct[] Product
        {
            get
            {
                return this.productField;
            }
            set
            {
                this.productField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UserTypeID
        {
            get
            {
                return this.userTypeIDField;
            }
            set
            {
                this.userTypeIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Selected
        {
            get
            {
                return this.selectedField;
            }
            set
            {
                this.selectedField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class ProductsProductProductValue
    {

        public string attributeIDField;

        public string idField;

        public string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AttributeID
        {
            get
            {
                return this.attributeIDField;
            }
            set
            {
                this.attributeIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class ProductsProductProductProduct
    {

        public string nameField;

        public ProductsProductProductProductProduct[] productField;

        public string idField;

        public string userTypeIDField;

        public bool selectedField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Product")]
        public ProductsProductProductProductProduct[] Product
        {
            get
            {
                return this.productField;
            }
            set
            {
                this.productField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UserTypeID
        {
            get
            {
                return this.userTypeIDField;
            }
            set
            {
                this.userTypeIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Selected
        {
            get
            {
                return this.selectedField;
            }
            set
            {
                this.selectedField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class ProductsProductProductProductProduct
    {

        public string nameField;

        public ProductsProductProductProductProductValues valuesField;

        public ProductsProductProductProductProductProduct[] productField;

        public string idField;

        public string userTypeIDField;

        public bool selectedField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public ProductsProductProductProductProductValues Values
        {
            get
            {
                return this.valuesField;
            }
            set
            {
                this.valuesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Product")]
        public ProductsProductProductProductProductProduct[] Product
        {
            get
            {
                return this.productField;
            }
            set
            {
                this.productField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UserTypeID
        {
            get
            {
                return this.userTypeIDField;
            }
            set
            {
                this.userTypeIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Selected
        {
            get
            {
                return this.selectedField;
            }
            set
            {
                this.selectedField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class ProductsProductProductProductProductValues
    {

        public ProductsProductProductProductProductValuesValue valueField;

        /// <remarks/>
        public ProductsProductProductProductProductValuesValue Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class ProductsProductProductProductProductValuesValue
    {

        public string attributeIDField;

        public bool derivedField;

        public string derivedContextIDField;

        public string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AttributeID
        {
            get
            {
                return this.attributeIDField;
            }
            set
            {
                this.attributeIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Derived
        {
            get
            {
                return this.derivedField;
            }
            set
            {
                this.derivedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DerivedContextID
        {
            get
            {
                return this.derivedContextIDField;
            }
            set
            {
                this.derivedContextIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class ProductsProductProductProductProductProduct
    {

        public string nameField;

        public ProductsProductProductProductProductProductProduct[] productField;

        public string idField;

        public string userTypeIDField;

        public bool selectedField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Product")]
        public ProductsProductProductProductProductProductProduct[] Product
        {
            get
            {
                return this.productField;
            }
            set
            {
                this.productField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UserTypeID
        {
            get
            {
                return this.userTypeIDField;
            }
            set
            {
                this.userTypeIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Selected
        {
            get
            {
                return this.selectedField;
            }
            set
            {
                this.selectedField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class ProductsProductProductProductProductProductProduct
    {

        public string nameField;

        public ProductsProductProductProductProductProductProductClassificationReference classificationReferenceField;

        public ProductsProductProductProductProductProductProductEntityCrossReference[] entityCrossReferenceField;

        public ProductsProductProductProductProductProductProductValues valuesField;

        public ProductsProductProductProductProductProductProductProduct[] productField;

        public string idField;

        public string userTypeIDField;

        public bool selectedField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public ProductsProductProductProductProductProductProductClassificationReference ClassificationReference
        {
            get
            {
                return this.classificationReferenceField;
            }
            set
            {
                this.classificationReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EntityCrossReference")]
        public ProductsProductProductProductProductProductProductEntityCrossReference[] EntityCrossReference
        {
            get
            {
                return this.entityCrossReferenceField;
            }
            set
            {
                this.entityCrossReferenceField = value;
            }
        }

        /// <remarks/>
        public ProductsProductProductProductProductProductProductValues Values
        {
            get
            {
                return this.valuesField;
            }
            set
            {
                this.valuesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Product")]
        public ProductsProductProductProductProductProductProductProduct[] Product
        {
            get
            {
                return this.productField;
            }
            set
            {
                this.productField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UserTypeID
        {
            get
            {
                return this.userTypeIDField;
            }
            set
            {
                this.userTypeIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Selected
        {
            get
            {
                return this.selectedField;
            }
            set
            {
                this.selectedField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class ProductsProductProductProductProductProductProductClassificationReference
    {

        public string classificationIDField;

        public string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ClassificationID
        {
            get
            {
                return this.classificationIDField;
            }
            set
            {
                this.classificationIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class ProductsProductProductProductProductProductProductEntityCrossReference
    {

        public ProductsProductProductProductProductProductProductEntityCrossReferenceMetaData metaDataField;

        public string entityIDField;

        public string typeField;

        /// <remarks/>
        public ProductsProductProductProductProductProductProductEntityCrossReferenceMetaData MetaData
        {
            get
            {
                return this.metaDataField;
            }
            set
            {
                this.metaDataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EntityID
        {
            get
            {
                return this.entityIDField;
            }
            set
            {
                this.entityIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class ProductsProductProductProductProductProductProductEntityCrossReferenceMetaData
    {

        public ProductsProductProductProductProductProductProductEntityCrossReferenceMetaDataMultiValue multiValueField;

        public ProductsProductProductProductProductProductProductEntityCrossReferenceMetaDataValue valueField;

        /// <remarks/>
        public ProductsProductProductProductProductProductProductEntityCrossReferenceMetaDataMultiValue MultiValue
        {
            get
            {
                return this.multiValueField;
            }
            set
            {
                this.multiValueField = value;
            }
        }

        /// <remarks/>
        public ProductsProductProductProductProductProductProductEntityCrossReferenceMetaDataValue Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class ProductsProductProductProductProductProductProductEntityCrossReferenceMetaDataMultiValue
    {

        public ProductsProductProductProductProductProductProductEntityCrossReferenceMetaDataMultiValueValue valueField;

        public string attributeIDField;

        /// <remarks/>
        public ProductsProductProductProductProductProductProductEntityCrossReferenceMetaDataMultiValueValue Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AttributeID
        {
            get
            {
                return this.attributeIDField;
            }
            set
            {
                this.attributeIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class ProductsProductProductProductProductProductProductEntityCrossReferenceMetaDataMultiValueValue
    {

        public ushort idField;

        public string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class ProductsProductProductProductProductProductProductEntityCrossReferenceMetaDataValue
    {

        public string attributeIDField;

        public string idField;

        public string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AttributeID
        {
            get
            {
                return this.attributeIDField;
            }
            set
            {
                this.attributeIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class ProductsProductProductProductProductProductProductValues
    {

        public object[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MultiValue", typeof(ProductsProductProductProductProductProductProductValuesMultiValue))]
        [System.Xml.Serialization.XmlElementAttribute("Value", typeof(ProductsProductProductProductProductProductProductValuesValue))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class ProductsProductProductProductProductProductProductValuesMultiValue
    {

        public ProductsProductProductProductProductProductProductValuesMultiValueValue[] valueField;

        public string attributeIDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Value")]
        public ProductsProductProductProductProductProductProductValuesMultiValueValue[] Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AttributeID
        {
            get
            {
                return this.attributeIDField;
            }
            set
            {
                this.attributeIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class ProductsProductProductProductProductProductProductValuesMultiValueValue
    {

        public string unitIDField;

        public string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UnitID
        {
            get
            {
                return this.unitIDField;
            }
            set
            {
                this.unitIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class ProductsProductProductProductProductProductProductValuesValue
    {

        public string attributeIDField;

        public string idField;

        public string unitIDField;

        public bool derivedField;

        public bool derivedFieldSpecified;

        public string derivedContextIDField;

        public string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AttributeID
        {
            get
            {
                return this.attributeIDField;
            }
            set
            {
                this.attributeIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UnitID
        {
            get
            {
                return this.unitIDField;
            }
            set
            {
                this.unitIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Derived
        {
            get
            {
                return this.derivedField;
            }
            set
            {
                this.derivedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DerivedSpecified
        {
            get
            {
                return this.derivedFieldSpecified;
            }
            set
            {
                this.derivedFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DerivedContextID
        {
            get
            {
                return this.derivedContextIDField;
            }
            set
            {
                this.derivedContextIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class ProductsProductProductProductProductProductProductProduct
    {

        public string nameField;

        public ProductsProductProductProductProductProductProductProductClassificationReference[] classificationReferenceField;

        public ProductsProductProductProductProductProductProductProductProductCrossReference[] productCrossReferenceField;

        public ProductsProductProductProductProductProductProductProductEntityCrossReference[] entityCrossReferenceField;

        public ProductsProductProductProductProductProductProductProductValues valuesField;

        public ProductsProductProductProductProductProductProductProductProduct productField;

        public string idField;

        public string userTypeIDField;

        public bool referencedField;

        public bool referencedFieldSpecified;

        public bool selectedField;

        public bool selectedFieldSpecified;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ClassificationReference")]
        public ProductsProductProductProductProductProductProductProductClassificationReference[] ClassificationReference
        {
            get
            {
                return this.classificationReferenceField;
            }
            set
            {
                this.classificationReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProductCrossReference")]
        public ProductsProductProductProductProductProductProductProductProductCrossReference[] ProductCrossReference
        {
            get
            {
                return this.productCrossReferenceField;
            }
            set
            {
                this.productCrossReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EntityCrossReference")]
        public ProductsProductProductProductProductProductProductProductEntityCrossReference[] EntityCrossReference
        {
            get
            {
                return this.entityCrossReferenceField;
            }
            set
            {
                this.entityCrossReferenceField = value;
            }
        }

        /// <remarks/>
        public ProductsProductProductProductProductProductProductProductValues Values
        {
            get
            {
                return this.valuesField;
            }
            set
            {
                this.valuesField = value;
            }
        }

        /// <remarks/>
        public ProductsProductProductProductProductProductProductProductProduct Product
        {
            get
            {
                return this.productField;
            }
            set
            {
                this.productField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UserTypeID
        {
            get
            {
                return this.userTypeIDField;
            }
            set
            {
                this.userTypeIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Referenced
        {
            get
            {
                return this.referencedField;
            }
            set
            {
                this.referencedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReferencedSpecified
        {
            get
            {
                return this.referencedFieldSpecified;
            }
            set
            {
                this.referencedFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Selected
        {
            get
            {
                return this.selectedField;
            }
            set
            {
                this.selectedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SelectedSpecified
        {
            get
            {
                return this.selectedFieldSpecified;
            }
            set
            {
                this.selectedFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class ProductsProductProductProductProductProductProductProductClassificationReference
    {

        public string classificationIDField;

        public string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ClassificationID
        {
            get
            {
                return this.classificationIDField;
            }
            set
            {
                this.classificationIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class ProductsProductProductProductProductProductProductProductProductCrossReference
    {

        public string productIDField;

        public string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ProductID
        {
            get
            {
                return this.productIDField;
            }
            set
            {
                this.productIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class ProductsProductProductProductProductProductProductProductEntityCrossReference
    {

        public ProductsProductProductProductProductProductProductProductEntityCrossReferenceMetaData metaDataField;

        public string entityIDField;

        public string typeField;

        /// <remarks/>
        public ProductsProductProductProductProductProductProductProductEntityCrossReferenceMetaData MetaData
        {
            get
            {
                return this.metaDataField;
            }
            set
            {
                this.metaDataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EntityID
        {
            get
            {
                return this.entityIDField;
            }
            set
            {
                this.entityIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class ProductsProductProductProductProductProductProductProductEntityCrossReferenceMetaData
    {

        public ProductsProductProductProductProductProductProductProductEntityCrossReferenceMetaDataMultiValue multiValueField;

        public ProductsProductProductProductProductProductProductProductEntityCrossReferenceMetaDataValue[] valueField;

        /// <remarks/>
        public ProductsProductProductProductProductProductProductProductEntityCrossReferenceMetaDataMultiValue MultiValue
        {
            get
            {
                return this.multiValueField;
            }
            set
            {
                this.multiValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Value")]
        public ProductsProductProductProductProductProductProductProductEntityCrossReferenceMetaDataValue[] Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class ProductsProductProductProductProductProductProductProductEntityCrossReferenceMetaDataMultiValue
    {

        public ProductsProductProductProductProductProductProductProductEntityCrossReferenceMetaDataMultiValueValue valueField;

        public string attributeIDField;

        /// <remarks/>
        public ProductsProductProductProductProductProductProductProductEntityCrossReferenceMetaDataMultiValueValue Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AttributeID
        {
            get
            {
                return this.attributeIDField;
            }
            set
            {
                this.attributeIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class ProductsProductProductProductProductProductProductProductEntityCrossReferenceMetaDataMultiValueValue
    {

        public ushort idField;

        public string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class ProductsProductProductProductProductProductProductProductEntityCrossReferenceMetaDataValue
    {

        public string attributeIDField;

        public string idField;

        public string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AttributeID
        {
            get
            {
                return this.attributeIDField;
            }
            set
            {
                this.attributeIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class ProductsProductProductProductProductProductProductProductValues
    {

        public object[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MultiValue", typeof(ProductsProductProductProductProductProductProductProductValuesMultiValue))]
        [System.Xml.Serialization.XmlElementAttribute("Value", typeof(ProductsProductProductProductProductProductProductProductValuesValue))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class ProductsProductProductProductProductProductProductProductValuesMultiValue
    {

        public string[] valueField;

        public string attributeIDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Value")]
        public string[] Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AttributeID
        {
            get
            {
                return this.attributeIDField;
            }
            set
            {
                this.attributeIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class ProductsProductProductProductProductProductProductProductValuesValue
    {

        public string attributeIDField;

        public string idField;

        public string unitIDField;

        public bool derivedField;

        public bool derivedFieldSpecified;

        public string derivedContextIDField;

        public string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AttributeID
        {
            get
            {
                return this.attributeIDField;
            }
            set
            {
                this.attributeIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UnitID
        {
            get
            {
                return this.unitIDField;
            }
            set
            {
                this.unitIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Derived
        {
            get
            {
                return this.derivedField;
            }
            set
            {
                this.derivedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DerivedSpecified
        {
            get
            {
                return this.derivedFieldSpecified;
            }
            set
            {
                this.derivedFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DerivedContextID
        {
            get
            {
                return this.derivedContextIDField;
            }
            set
            {
                this.derivedContextIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class ProductsProductProductProductProductProductProductProductProduct
    {

        public string nameField;

        public ProductsProductProductProductProductProductProductProductProductClassificationReference classificationReferenceField;

        public ProductsProductProductProductProductProductProductProductProductEntityCrossReference[] entityCrossReferenceField;

        public ProductsProductProductProductProductProductProductProductProductValues valuesField;

        public string idField;

        public string userTypeIDField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public ProductsProductProductProductProductProductProductProductProductClassificationReference ClassificationReference
        {
            get
            {
                return this.classificationReferenceField;
            }
            set
            {
                this.classificationReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EntityCrossReference")]
        public ProductsProductProductProductProductProductProductProductProductEntityCrossReference[] EntityCrossReference
        {
            get
            {
                return this.entityCrossReferenceField;
            }
            set
            {
                this.entityCrossReferenceField = value;
            }
        }

        /// <remarks/>
        public ProductsProductProductProductProductProductProductProductProductValues Values
        {
            get
            {
                return this.valuesField;
            }
            set
            {
                this.valuesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UserTypeID
        {
            get
            {
                return this.userTypeIDField;
            }
            set
            {
                this.userTypeIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class ProductsProductProductProductProductProductProductProductProductClassificationReference
    {

        public string classificationIDField;

        public string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ClassificationID
        {
            get
            {
                return this.classificationIDField;
            }
            set
            {
                this.classificationIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class ProductsProductProductProductProductProductProductProductProductEntityCrossReference
    {

        public ProductsProductProductProductProductProductProductProductProductEntityCrossReferenceMetaData metaDataField;

        public string entityIDField;

        public string typeField;

        /// <remarks/>
        public ProductsProductProductProductProductProductProductProductProductEntityCrossReferenceMetaData MetaData
        {
            get
            {
                return this.metaDataField;
            }
            set
            {
                this.metaDataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EntityID
        {
            get
            {
                return this.entityIDField;
            }
            set
            {
                this.entityIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class ProductsProductProductProductProductProductProductProductProductEntityCrossReferenceMetaData
    {

        public ProductsProductProductProductProductProductProductProductProductEntityCrossReferenceMetaDataMultiValue multiValueField;

        public ProductsProductProductProductProductProductProductProductProductEntityCrossReferenceMetaDataValue[] valueField;

        /// <remarks/>
        public ProductsProductProductProductProductProductProductProductProductEntityCrossReferenceMetaDataMultiValue MultiValue
        {
            get
            {
                return this.multiValueField;
            }
            set
            {
                this.multiValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Value")]
        public ProductsProductProductProductProductProductProductProductProductEntityCrossReferenceMetaDataValue[] Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class ProductsProductProductProductProductProductProductProductProductEntityCrossReferenceMetaDataMultiValue
    {

        public ProductsProductProductProductProductProductProductProductProductEntityCrossReferenceMetaDataMultiValueValue valueField;

        public string attributeIDField;

        /// <remarks/>
        public ProductsProductProductProductProductProductProductProductProductEntityCrossReferenceMetaDataMultiValueValue Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AttributeID
        {
            get
            {
                return this.attributeIDField;
            }
            set
            {
                this.attributeIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class ProductsProductProductProductProductProductProductProductProductEntityCrossReferenceMetaDataMultiValueValue
    {

        public byte idField;

        public string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class ProductsProductProductProductProductProductProductProductProductEntityCrossReferenceMetaDataValue
    {

        public string attributeIDField;

        public string idField;

        public string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AttributeID
        {
            get
            {
                return this.attributeIDField;
            }
            set
            {
                this.attributeIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class ProductsProductProductProductProductProductProductProductProductValues
    {

        public object[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MultiValue", typeof(ProductsProductProductProductProductProductProductProductProductValuesMultiValue))]
        [System.Xml.Serialization.XmlElementAttribute("Value", typeof(ProductsProductProductProductProductProductProductProductProductValuesValue))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class ProductsProductProductProductProductProductProductProductProductValuesMultiValue
    {

        public string[] valueField;

        public string attributeIDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Value")]
        public string[] Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AttributeID
        {
            get
            {
                return this.attributeIDField;
            }
            set
            {
                this.attributeIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class ProductsProductProductProductProductProductProductProductProductValuesValue
    {

        public string attributeIDField;

        public string idField;

        public string unitIDField;

        public bool derivedField;

        public bool derivedFieldSpecified;

        public string derivedContextIDField;

        public string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AttributeID
        {
            get
            {
                return this.attributeIDField;
            }
            set
            {
                this.attributeIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UnitID
        {
            get
            {
                return this.unitIDField;
            }
            set
            {
                this.unitIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Derived
        {
            get
            {
                return this.derivedField;
            }
            set
            {
                this.derivedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DerivedSpecified
        {
            get
            {
                return this.derivedFieldSpecified;
            }
            set
            {
                this.derivedFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DerivedContextID
        {
            get
            {
                return this.derivedContextIDField;
            }
            set
            {
                this.derivedContextIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
}

