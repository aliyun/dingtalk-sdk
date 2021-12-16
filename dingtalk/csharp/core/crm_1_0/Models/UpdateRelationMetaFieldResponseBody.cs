// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class UpdateRelationMetaFieldResponseBody : TeaModel {
        [NameInMap("relationMetaDTO")]
        [Validation(Required=false)]
        public UpdateRelationMetaFieldResponseBodyRelationMetaDTO RelationMetaDTO { get; set; }
        public class UpdateRelationMetaFieldResponseBodyRelationMetaDTO : TeaModel {
            [NameInMap("desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<UpdateRelationMetaFieldResponseBodyRelationMetaDTOItems> Items { get; set; }
            public class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItems : TeaModel {
                public List<UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildren> Children { get; set; }
                public class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildren : TeaModel {
                    public string ComponentName { get; set; }
                    public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps Props { get; set; }
                    public class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps : TeaModel {
                        [NameInMap("align")]
                        [Validation(Required=false)]
                        public string Align { get; set; }

                        [NameInMap("bizAlias")]
                        [Validation(Required=false)]
                        public string BizAlias { get; set; }

                        [NameInMap("choice")]
                        [Validation(Required=false)]
                        public long? Choice { get; set; }

                        [NameInMap("content")]
                        [Validation(Required=false)]
                        public string Content { get; set; }

                        [NameInMap("dataSource")]
                        [Validation(Required=false)]
                        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsDataSource DataSource { get; set; }
                        public class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsDataSource : TeaModel {
                            [NameInMap("target")]
                            [Validation(Required=false)]
                            public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsDataSourceTarget Target { get; set; }
                            public class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsDataSourceTarget : TeaModel {
                                [NameInMap("appType")]
                                [Validation(Required=false)]
                                public long? AppType { get; set; }

                                [NameInMap("appUuid")]
                                [Validation(Required=false)]
                                public string AppUuid { get; set; }

                                [NameInMap("bizType")]
                                [Validation(Required=false)]
                                public string BizType { get; set; }

                                [NameInMap("formCode")]
                                [Validation(Required=false)]
                                public string FormCode { get; set; }

                            }
                            [NameInMap("type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }
                        };

                        [NameInMap("disabled")]
                        [Validation(Required=false)]
                        public bool? Disabled { get; set; }

                        [NameInMap("duration")]
                        [Validation(Required=false)]
                        public bool? Duration { get; set; }

                        [NameInMap("fields")]
                        [Validation(Required=false)]
                        public List<UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFields> Fields { get; set; }
                        public class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFields : TeaModel {
                            [NameInMap("componentName")]
                            [Validation(Required=false)]
                            public string ComponentName { get; set; }

                            [NameInMap("relateProps")]
                            [Validation(Required=false)]
                            public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps RelateProps { get; set; }
                            public class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps : TeaModel {
                                [NameInMap("align")]
                                [Validation(Required=false)]
                                public string Align { get; set; }
                                [NameInMap("bizAlias")]
                                [Validation(Required=false)]
                                public string BizAlias { get; set; }
                                [NameInMap("choice")]
                                [Validation(Required=false)]
                                public long? Choice { get; set; }
                                [NameInMap("content")]
                                [Validation(Required=false)]
                                public string Content { get; set; }
                                [NameInMap("disabled")]
                                [Validation(Required=false)]
                                public bool? Disabled { get; set; }
                                [NameInMap("duration")]
                                [Validation(Required=false)]
                                public bool? Duration { get; set; }
                                [NameInMap("format")]
                                [Validation(Required=false)]
                                public string Format { get; set; }
                                [NameInMap("formula")]
                                [Validation(Required=false)]
                                public string Formula { get; set; }
                                [NameInMap("fieldId")]
                                [Validation(Required=false)]
                                public string FieldId { get; set; }
                                [NameInMap("invisible")]
                                [Validation(Required=false)]
                                public bool? Invisible { get; set; }
                                [NameInMap("label")]
                                [Validation(Required=false)]
                                public string Label { get; set; }
                                [NameInMap("link")]
                                [Validation(Required=false)]
                                public string Link { get; set; }
                                [NameInMap("notUpper")]
                                [Validation(Required=false)]
                                public string NotUpper { get; set; }
                                [NameInMap("options")]
                                [Validation(Required=false)]
                                public List<UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelatePropsOptions> Options { get; set; }
                                public class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelatePropsOptions : TeaModel {
                                    public string Key { get; set; }
                                    public string Value { get; set; }
                                }
                                [NameInMap("payEnable")]
                                [Validation(Required=false)]
                                public bool? PayEnable { get; set; }
                                [NameInMap("placeholder")]
                                [Validation(Required=false)]
                                public string Placeholder { get; set; }
                                [NameInMap("required")]
                                [Validation(Required=false)]
                                public bool? Required { get; set; }
                                [NameInMap("statField")]
                                [Validation(Required=false)]
                                public List<UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelatePropsStatField> StatField { get; set; }
                                public class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelatePropsStatField : TeaModel {
                                    public string FieldId { get; set; }
                                    public string Label { get; set; }
                                    public string Unit { get; set; }
                                    public bool? Upper { get; set; }
                                }
                                [NameInMap("unit")]
                                [Validation(Required=false)]
                                public string Unit { get; set; }
                                [NameInMap("verticalPrint")]
                                [Validation(Required=false)]
                                public bool? VerticalPrint { get; set; }
                            };

                        }

                        [NameInMap("format")]
                        [Validation(Required=false)]
                        public string Format { get; set; }

                        [NameInMap("formula")]
                        [Validation(Required=false)]
                        public string Formula { get; set; }

                        [NameInMap("fieldId")]
                        [Validation(Required=false)]
                        public string FieldId { get; set; }

                        [NameInMap("invisible")]
                        [Validation(Required=false)]
                        public bool? Invisible { get; set; }

                        [NameInMap("label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        [NameInMap("labelEditableFreeze")]
                        [Validation(Required=false)]
                        public bool? LabelEditableFreeze { get; set; }

                        [NameInMap("link")]
                        [Validation(Required=false)]
                        public string Link { get; set; }

                        [NameInMap("notPrint")]
                        [Validation(Required=false)]
                        public string NotPrint { get; set; }

                        [NameInMap("notUpper")]
                        [Validation(Required=false)]
                        public string NotUpper { get; set; }

                        [NameInMap("options")]
                        [Validation(Required=false)]
                        public List<UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsOptions> Options { get; set; }
                        public class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsOptions : TeaModel {
                            [NameInMap("key")]
                            [Validation(Required=false)]
                            public string Key { get; set; }

                            [NameInMap("value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        [NameInMap("payEnable")]
                        [Validation(Required=false)]
                        public bool? PayEnable { get; set; }

                        [NameInMap("placeholder")]
                        [Validation(Required=false)]
                        public string Placeholder { get; set; }

                        [NameInMap("required")]
                        [Validation(Required=false)]
                        public bool? Required { get; set; }

                        [NameInMap("requiredEditableFreeze")]
                        [Validation(Required=false)]
                        public bool? RequiredEditableFreeze { get; set; }

                        [NameInMap("statField")]
                        [Validation(Required=false)]
                        public List<UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsStatField> StatField { get; set; }
                        public class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsStatField : TeaModel {
                            [NameInMap("fieldId")]
                            [Validation(Required=false)]
                            public string FieldId { get; set; }

                            [NameInMap("label")]
                            [Validation(Required=false)]
                            public string Label { get; set; }

                            [NameInMap("unit")]
                            [Validation(Required=false)]
                            public string Unit { get; set; }

                            [NameInMap("upper")]
                            [Validation(Required=false)]
                            public bool? Upper { get; set; }

                        }

                        [NameInMap("unit")]
                        [Validation(Required=false)]
                        public string Unit { get; set; }

                        [NameInMap("verticalPrint")]
                        [Validation(Required=false)]
                        public bool? VerticalPrint { get; set; }

                    }
                }
                public string ComponentName { get; set; }
                public List<UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps> Props { get; set; }
                public class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps : TeaModel {
                    public string Align { get; set; }
                    public string BizAlias { get; set; }
                    public long? Choice { get; set; }
                    public string Content { get; set; }
                    public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsDataSource DataSource { get; set; }
                    public class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsDataSource : TeaModel {
                        [NameInMap("target")]
                        [Validation(Required=false)]
                        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsDataSourceTarget Target { get; set; }
                        public class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsDataSourceTarget : TeaModel {
                            [NameInMap("appType")]
                            [Validation(Required=false)]
                            public long? AppType { get; set; }
                            [NameInMap("appUuid")]
                            [Validation(Required=false)]
                            public string AppUuid { get; set; }
                            [NameInMap("bizType")]
                            [Validation(Required=false)]
                            public string BizType { get; set; }
                            [NameInMap("formCode")]
                            [Validation(Required=false)]
                            public string FormCode { get; set; }
                        };

                        [NameInMap("type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }
                    public bool? Disabled { get; set; }
                    public bool? Duration { get; set; }
                    public List<UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFields> Fields { get; set; }
                    public class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFields : TeaModel {
                        public string ComponentName { get; set; }
                        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps RelateProps { get; set; }
                        public class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps : TeaModel {
                            [NameInMap("align")]
                            [Validation(Required=false)]
                            public string Align { get; set; }

                            [NameInMap("bizAlias")]
                            [Validation(Required=false)]
                            public string BizAlias { get; set; }

                            [NameInMap("choice")]
                            [Validation(Required=false)]
                            public long? Choice { get; set; }

                            [NameInMap("content")]
                            [Validation(Required=false)]
                            public string Content { get; set; }

                            [NameInMap("disabled")]
                            [Validation(Required=false)]
                            public bool? Disabled { get; set; }

                            [NameInMap("duration")]
                            [Validation(Required=false)]
                            public string Duration { get; set; }

                            [NameInMap("format")]
                            [Validation(Required=false)]
                            public string Format { get; set; }

                            [NameInMap("formula")]
                            [Validation(Required=false)]
                            public string Formula { get; set; }

                            [NameInMap("fieldId")]
                            [Validation(Required=false)]
                            public string FieldId { get; set; }

                            [NameInMap("invisible")]
                            [Validation(Required=false)]
                            public bool? Invisible { get; set; }

                            [NameInMap("label")]
                            [Validation(Required=false)]
                            public string Label { get; set; }

                            [NameInMap("link")]
                            [Validation(Required=false)]
                            public string Link { get; set; }

                            [NameInMap("notUpper")]
                            [Validation(Required=false)]
                            public string NotUpper { get; set; }

                            [NameInMap("options")]
                            [Validation(Required=false)]
                            public List<UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelatePropsOptions> Options { get; set; }
                            public class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelatePropsOptions : TeaModel {
                                [NameInMap("key")]
                                [Validation(Required=false)]
                                public string Key { get; set; }

                                [NameInMap("value")]
                                [Validation(Required=false)]
                                public string Value { get; set; }

                            }

                            [NameInMap("payEnable")]
                            [Validation(Required=false)]
                            public bool? PayEnable { get; set; }

                            [NameInMap("placeholder")]
                            [Validation(Required=false)]
                            public string Placeholder { get; set; }

                            [NameInMap("required")]
                            [Validation(Required=false)]
                            public bool? Required { get; set; }

                            [NameInMap("statField")]
                            [Validation(Required=false)]
                            public List<UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelatePropsStatField> StatField { get; set; }
                            public class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelatePropsStatField : TeaModel {
                                [NameInMap("fieldId")]
                                [Validation(Required=false)]
                                public string FieldId { get; set; }

                                [NameInMap("label")]
                                [Validation(Required=false)]
                                public string Label { get; set; }

                                [NameInMap("unit")]
                                [Validation(Required=false)]
                                public string Unit { get; set; }

                                [NameInMap("upper")]
                                [Validation(Required=false)]
                                public bool? Upper { get; set; }

                            }

                            [NameInMap("unit")]
                            [Validation(Required=false)]
                            public string Unit { get; set; }

                            [NameInMap("verticalPrint")]
                            [Validation(Required=false)]
                            public bool? VerticalPrint { get; set; }

                        }
                    }
                    public string Format { get; set; }
                    public string Formula { get; set; }
                    public string FieldId { get; set; }
                    public bool? Invisible { get; set; }
                    public string Label { get; set; }
                    public bool? LabelEditableFreeze { get; set; }
                    public string Link { get; set; }
                    public string NotPrint { get; set; }
                    public string NotUpper { get; set; }
                    public List<UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsOptions> Options { get; set; }
                    public class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsOptions : TeaModel {
                        public string Key { get; set; }
                        public string Value { get; set; }
                    }
                    public bool? PayEnable { get; set; }
                    public string Placeholder { get; set; }
                    public bool? Required { get; set; }
                    public bool? RequiredEditableFreeze { get; set; }
                    public List<UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsStatField> StatField { get; set; }
                    public class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsStatField : TeaModel {
                        public string FieldId { get; set; }
                        public string Label { get; set; }
                        public string Unit { get; set; }
                        public bool? Upper { get; set; }
                    }
                    public string Unit { get; set; }
                    public bool? VerticalPrint { get; set; }
                }
            }
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("relationType")]
            [Validation(Required=false)]
            public string RelationType { get; set; }
        };

    }

}
