// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class DescribeRelationMetaResponseBody : TeaModel {
        [NameInMap("relationMetaDTOList")]
        [Validation(Required=false)]
        public List<DescribeRelationMetaResponseBodyRelationMetaDTOList> RelationMetaDTOList { get; set; }
        public class DescribeRelationMetaResponseBodyRelationMetaDTOList : TeaModel {
            [NameInMap("creatorUserId")]
            [Validation(Required=false)]
            public string CreatorUserId { get; set; }

            [NameInMap("desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("items")]
            [Validation(Required=false)]
            public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItems> Items { get; set; }
            public class DescribeRelationMetaResponseBodyRelationMetaDTOListItems : TeaModel {
                [NameInMap("children")]
                [Validation(Required=false)]
                public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildren> Children { get; set; }
                public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildren : TeaModel {
                    [NameInMap("componentName")]
                    [Validation(Required=false)]
                    public string ComponentName { get; set; }

                    [NameInMap("props")]
                    [Validation(Required=false)]
                    public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps Props { get; set; }
                    public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps : TeaModel {
                        [NameInMap("actionName")]
                        [Validation(Required=false)]
                        public string ActionName { get; set; }

                        [NameInMap("align")]
                        [Validation(Required=false)]
                        public string Align { get; set; }

                        [NameInMap("availableTemplates")]
                        [Validation(Required=false)]
                        public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsAvailableTemplates> AvailableTemplates { get; set; }
                        public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsAvailableTemplates : TeaModel {
                            [NameInMap("id")]
                            [Validation(Required=false)]
                            public string Id { get; set; }

                            [NameInMap("name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                        }

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
                        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSource DataSource { get; set; }
                        public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSource : TeaModel {
                            [NameInMap("params")]
                            [Validation(Required=false)]
                            public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceParams Params { get; set; }
                            public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceParams : TeaModel {
                                [NameInMap("filters")]
                                [Validation(Required=false)]
                                public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceParamsFilters> Filters { get; set; }
                                public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceParamsFilters : TeaModel {
                                    [NameInMap("fieldId")]
                                    [Validation(Required=false)]
                                    public string FieldId { get; set; }

                                    [NameInMap("filterType")]
                                    [Validation(Required=false)]
                                    public string FilterType { get; set; }

                                    [NameInMap("value")]
                                    [Validation(Required=false)]
                                    public string Value { get; set; }

                                    [NameInMap("valueType")]
                                    [Validation(Required=false)]
                                    public string ValueType { get; set; }

                                }

                            }

                            [NameInMap("target")]
                            [Validation(Required=false)]
                            public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceTarget Target { get; set; }
                            public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceTarget : TeaModel {
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

                        }

                        [NameInMap("defaultColor")]
                        [Validation(Required=false)]
                        public string DefaultColor { get; set; }

                        [NameInMap("disabled")]
                        [Validation(Required=false)]
                        public bool? Disabled { get; set; }

                        [NameInMap("duration")]
                        [Validation(Required=false)]
                        public bool? Duration { get; set; }

                        [NameInMap("durationLabel")]
                        [Validation(Required=false)]
                        public string DurationLabel { get; set; }

                        [NameInMap("fieldId")]
                        [Validation(Required=false)]
                        public string FieldId { get; set; }

                        [NameInMap("fields")]
                        [Validation(Required=false)]
                        public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFields> Fields { get; set; }
                        public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFields : TeaModel {
                            [NameInMap("componentName")]
                            [Validation(Required=false)]
                            public string ComponentName { get; set; }

                            [NameInMap("relateProps")]
                            [Validation(Required=false)]
                            public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps RelateProps { get; set; }
                            public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps : TeaModel {
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

                                [NameInMap("durationLabel")]
                                [Validation(Required=false)]
                                public string DurationLabel { get; set; }

                                [NameInMap("fieldId")]
                                [Validation(Required=false)]
                                public string FieldId { get; set; }

                                [NameInMap("format")]
                                [Validation(Required=false)]
                                public string Format { get; set; }

                                [NameInMap("formula")]
                                [Validation(Required=false)]
                                public string Formula { get; set; }

                                [NameInMap("invisible")]
                                [Validation(Required=false)]
                                public bool? Invisible { get; set; }

                                [NameInMap("label")]
                                [Validation(Required=false)]
                                public string Label { get; set; }

                                [NameInMap("labelEditableFreeze")]
                                [Validation(Required=false)]
                                public bool? LabelEditableFreeze { get; set; }

                                [NameInMap("limit")]
                                [Validation(Required=false)]
                                public long? Limit { get; set; }

                                [NameInMap("link")]
                                [Validation(Required=false)]
                                public string Link { get; set; }

                                [NameInMap("mode")]
                                [Validation(Required=false)]
                                public string Mode { get; set; }

                                [NameInMap("notUpper")]
                                [Validation(Required=false)]
                                public string NotUpper { get; set; }

                                [NameInMap("options")]
                                [Validation(Required=false)]
                                public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsOptions> Options { get; set; }
                                public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsOptions : TeaModel {
                                    [NameInMap("extension")]
                                    [Validation(Required=false)]
                                    public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsOptionsExtension Extension { get; set; }
                                    public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsOptionsExtension : TeaModel {
                                        [NameInMap("editFreeze")]
                                        [Validation(Required=false)]
                                        public bool? EditFreeze { get; set; }

                                    }

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

                                [NameInMap("ratio")]
                                [Validation(Required=false)]
                                public long? Ratio { get; set; }

                                [NameInMap("required")]
                                [Validation(Required=false)]
                                public bool? Required { get; set; }

                                [NameInMap("requiredEditableFreeze")]
                                [Validation(Required=false)]
                                public bool? RequiredEditableFreeze { get; set; }

                                [NameInMap("spread")]
                                [Validation(Required=false)]
                                public bool? Spread { get; set; }

                                [NameInMap("statField")]
                                [Validation(Required=false)]
                                public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsStatField> StatField { get; set; }
                                public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsStatField : TeaModel {
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

                                [NameInMap("watermark")]
                                [Validation(Required=false)]
                                public bool? Watermark { get; set; }

                            }

                        }

                        [NameInMap("format")]
                        [Validation(Required=false)]
                        public string Format { get; set; }

                        [NameInMap("formula")]
                        [Validation(Required=false)]
                        public string Formula { get; set; }

                        [NameInMap("invisible")]
                        [Validation(Required=false)]
                        public bool? Invisible { get; set; }

                        [NameInMap("label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        [NameInMap("labelEditableFreeze")]
                        [Validation(Required=false)]
                        public bool? LabelEditableFreeze { get; set; }

                        [NameInMap("limit")]
                        [Validation(Required=false)]
                        public long? Limit { get; set; }

                        [NameInMap("link")]
                        [Validation(Required=false)]
                        public string Link { get; set; }

                        [NameInMap("mode")]
                        [Validation(Required=false)]
                        public string Mode { get; set; }

                        [NameInMap("multiple")]
                        [Validation(Required=false)]
                        public bool? Multiple { get; set; }

                        [NameInMap("notPrint")]
                        [Validation(Required=false)]
                        public string NotPrint { get; set; }

                        [NameInMap("notUpper")]
                        [Validation(Required=false)]
                        public string NotUpper { get; set; }

                        [NameInMap("options")]
                        [Validation(Required=false)]
                        public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsOptions> Options { get; set; }
                        public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsOptions : TeaModel {
                            [NameInMap("extension")]
                            [Validation(Required=false)]
                            public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsOptionsExtension Extension { get; set; }
                            public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsOptionsExtension : TeaModel {
                                [NameInMap("editFreeze")]
                                [Validation(Required=false)]
                                public bool? EditFreeze { get; set; }

                            }

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

                        [NameInMap("quote")]
                        [Validation(Required=false)]
                        public long? Quote { get; set; }

                        [NameInMap("ratio")]
                        [Validation(Required=false)]
                        public long? Ratio { get; set; }

                        [NameInMap("relateSource")]
                        [Validation(Required=false)]
                        public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSource> RelateSource { get; set; }
                        public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSource : TeaModel {
                            [NameInMap("bizType")]
                            [Validation(Required=false)]
                            public string BizType { get; set; }

                            [NameInMap("dataSource")]
                            [Validation(Required=false)]
                            public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSource DataSource { get; set; }
                            public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSource : TeaModel {
                                [NameInMap("params")]
                                [Validation(Required=false)]
                                public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceParams Params { get; set; }
                                public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceParams : TeaModel {
                                    [NameInMap("filters")]
                                    [Validation(Required=false)]
                                    public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceParamsFilters> Filters { get; set; }
                                    public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceParamsFilters : TeaModel {
                                        [NameInMap("fieldId")]
                                        [Validation(Required=false)]
                                        public string FieldId { get; set; }

                                        [NameInMap("filterType")]
                                        [Validation(Required=false)]
                                        public string FilterType { get; set; }

                                        [NameInMap("value")]
                                        [Validation(Required=false)]
                                        public string Value { get; set; }

                                        [NameInMap("valueType")]
                                        [Validation(Required=false)]
                                        public string ValueType { get; set; }

                                    }

                                }

                                [NameInMap("target")]
                                [Validation(Required=false)]
                                public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceTarget Target { get; set; }
                                public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceTarget : TeaModel {
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

                            }

                            [NameInMap("fields")]
                            [Validation(Required=false)]
                            public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFields> Fields { get; set; }
                            public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFields : TeaModel {
                                [NameInMap("componentName")]
                                [Validation(Required=false)]
                                public string ComponentName { get; set; }

                                [NameInMap("relateProps")]
                                [Validation(Required=false)]
                                public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelateProps RelateProps { get; set; }
                                public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelateProps : TeaModel {
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

                                    [NameInMap("fieldId")]
                                    [Validation(Required=false)]
                                    public string FieldId { get; set; }

                                    [NameInMap("format")]
                                    [Validation(Required=false)]
                                    public string Format { get; set; }

                                    [NameInMap("formula")]
                                    [Validation(Required=false)]
                                    public string Formula { get; set; }

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

                                    [NameInMap("multi")]
                                    [Validation(Required=false)]
                                    public long? Multi { get; set; }

                                    [NameInMap("notUpper")]
                                    [Validation(Required=false)]
                                    public string NotUpper { get; set; }

                                    [NameInMap("options")]
                                    [Validation(Required=false)]
                                    public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsOptions> Options { get; set; }
                                    public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsOptions : TeaModel {
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

                                    [NameInMap("quote")]
                                    [Validation(Required=false)]
                                    public long? Quote { get; set; }

                                    [NameInMap("required")]
                                    [Validation(Required=false)]
                                    public bool? Required { get; set; }

                                    [NameInMap("requiredEditableFreeze")]
                                    [Validation(Required=false)]
                                    public bool? RequiredEditableFreeze { get; set; }

                                    [NameInMap("statField")]
                                    [Validation(Required=false)]
                                    public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsStatField> StatField { get; set; }
                                    public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsStatField : TeaModel {
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

                        }

                        [NameInMap("required")]
                        [Validation(Required=false)]
                        public bool? Required { get; set; }

                        [NameInMap("requiredEditableFreeze")]
                        [Validation(Required=false)]
                        public bool? RequiredEditableFreeze { get; set; }

                        [NameInMap("rule")]
                        [Validation(Required=false)]
                        public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRule> Rule { get; set; }
                        public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRule : TeaModel {
                            [NameInMap("type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                            [NameInMap("value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        [NameInMap("sortable")]
                        [Validation(Required=false)]
                        public bool? Sortable { get; set; }

                        [NameInMap("spread")]
                        [Validation(Required=false)]
                        public bool? Spread { get; set; }

                        [NameInMap("statField")]
                        [Validation(Required=false)]
                        public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsStatField> StatField { get; set; }
                        public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsStatField : TeaModel {
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

                        [NameInMap("tableViewMode")]
                        [Validation(Required=false)]
                        public string TableViewMode { get; set; }

                        [NameInMap("unit")]
                        [Validation(Required=false)]
                        public string Unit { get; set; }

                        [NameInMap("verticalPrint")]
                        [Validation(Required=false)]
                        public bool? VerticalPrint { get; set; }

                        [NameInMap("watermark")]
                        [Validation(Required=false)]
                        public bool? Watermark { get; set; }

                    }

                }

                [NameInMap("componentName")]
                [Validation(Required=false)]
                public string ComponentName { get; set; }

                [NameInMap("props")]
                [Validation(Required=false)]
                public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps Props { get; set; }
                public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps : TeaModel {
                    [NameInMap("actionName")]
                    [Validation(Required=false)]
                    public string ActionName { get; set; }

                    [NameInMap("align")]
                    [Validation(Required=false)]
                    public string Align { get; set; }

                    [NameInMap("availableTemplates")]
                    [Validation(Required=false)]
                    public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsAvailableTemplates> AvailableTemplates { get; set; }
                    public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsAvailableTemplates : TeaModel {
                        [NameInMap("id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        [NameInMap("name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

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
                    public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSource DataSource { get; set; }
                    public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSource : TeaModel {
                        [NameInMap("params")]
                        [Validation(Required=false)]
                        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceParams Params { get; set; }
                        public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceParams : TeaModel {
                            [NameInMap("filters")]
                            [Validation(Required=false)]
                            public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceParamsFilters> Filters { get; set; }
                            public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceParamsFilters : TeaModel {
                                [NameInMap("fieldId")]
                                [Validation(Required=false)]
                                public string FieldId { get; set; }

                                [NameInMap("filterType")]
                                [Validation(Required=false)]
                                public string FilterType { get; set; }

                                [NameInMap("value")]
                                [Validation(Required=false)]
                                public string Value { get; set; }

                                [NameInMap("valueType")]
                                [Validation(Required=false)]
                                public string ValueType { get; set; }

                            }

                        }

                        [NameInMap("target")]
                        [Validation(Required=false)]
                        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceTarget Target { get; set; }
                        public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceTarget : TeaModel {
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

                    }

                    [NameInMap("defaultColor")]
                    [Validation(Required=false)]
                    public string DefaultColor { get; set; }

                    [NameInMap("disabled")]
                    [Validation(Required=false)]
                    public bool? Disabled { get; set; }

                    [NameInMap("duration")]
                    [Validation(Required=false)]
                    public bool? Duration { get; set; }

                    [NameInMap("durationLabel")]
                    [Validation(Required=false)]
                    public string DurationLabel { get; set; }

                    [NameInMap("fieldId")]
                    [Validation(Required=false)]
                    public string FieldId { get; set; }

                    [NameInMap("fields")]
                    [Validation(Required=false)]
                    public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFields> Fields { get; set; }
                    public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFields : TeaModel {
                        [NameInMap("componentName")]
                        [Validation(Required=false)]
                        public string ComponentName { get; set; }

                        [NameInMap("relateProps")]
                        [Validation(Required=false)]
                        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps RelateProps { get; set; }
                        public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps : TeaModel {
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

                            [NameInMap("durationLabel")]
                            [Validation(Required=false)]
                            public string DurationLabel { get; set; }

                            [NameInMap("fieldId")]
                            [Validation(Required=false)]
                            public string FieldId { get; set; }

                            [NameInMap("format")]
                            [Validation(Required=false)]
                            public string Format { get; set; }

                            [NameInMap("formula")]
                            [Validation(Required=false)]
                            public string Formula { get; set; }

                            [NameInMap("invisible")]
                            [Validation(Required=false)]
                            public bool? Invisible { get; set; }

                            [NameInMap("label")]
                            [Validation(Required=false)]
                            public string Label { get; set; }

                            [NameInMap("labelEditableFreeze")]
                            [Validation(Required=false)]
                            public bool? LabelEditableFreeze { get; set; }

                            [NameInMap("limit")]
                            [Validation(Required=false)]
                            public long? Limit { get; set; }

                            [NameInMap("link")]
                            [Validation(Required=false)]
                            public string Link { get; set; }

                            [NameInMap("mode")]
                            [Validation(Required=false)]
                            public string Mode { get; set; }

                            [NameInMap("notUpper")]
                            [Validation(Required=false)]
                            public string NotUpper { get; set; }

                            [NameInMap("options")]
                            [Validation(Required=false)]
                            public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsOptions> Options { get; set; }
                            public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsOptions : TeaModel {
                                [NameInMap("extension")]
                                [Validation(Required=false)]
                                public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsOptionsExtension Extension { get; set; }
                                public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsOptionsExtension : TeaModel {
                                    [NameInMap("editFreeze")]
                                    [Validation(Required=false)]
                                    public bool? EditFreeze { get; set; }

                                }

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

                            [NameInMap("ratio")]
                            [Validation(Required=false)]
                            public long? Ratio { get; set; }

                            [NameInMap("required")]
                            [Validation(Required=false)]
                            public bool? Required { get; set; }

                            [NameInMap("requiredEditableFreeze")]
                            [Validation(Required=false)]
                            public bool? RequiredEditableFreeze { get; set; }

                            [NameInMap("spread")]
                            [Validation(Required=false)]
                            public bool? Spread { get; set; }

                            [NameInMap("statField")]
                            [Validation(Required=false)]
                            public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsStatField> StatField { get; set; }
                            public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsStatField : TeaModel {
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

                            [NameInMap("watermark")]
                            [Validation(Required=false)]
                            public bool? Watermark { get; set; }

                        }

                    }

                    [NameInMap("format")]
                    [Validation(Required=false)]
                    public string Format { get; set; }

                    [NameInMap("formula")]
                    [Validation(Required=false)]
                    public string Formula { get; set; }

                    [NameInMap("invisible")]
                    [Validation(Required=false)]
                    public bool? Invisible { get; set; }

                    [NameInMap("label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    [NameInMap("labelEditableFreeze")]
                    [Validation(Required=false)]
                    public bool? LabelEditableFreeze { get; set; }

                    [NameInMap("limit")]
                    [Validation(Required=false)]
                    public long? Limit { get; set; }

                    [NameInMap("link")]
                    [Validation(Required=false)]
                    public string Link { get; set; }

                    [NameInMap("mode")]
                    [Validation(Required=false)]
                    public string Mode { get; set; }

                    [NameInMap("multi")]
                    [Validation(Required=false)]
                    public long? Multi { get; set; }

                    [NameInMap("multiple")]
                    [Validation(Required=false)]
                    public bool? Multiple { get; set; }

                    [NameInMap("needDetail")]
                    [Validation(Required=false)]
                    public string NeedDetail { get; set; }

                    [NameInMap("notPrint")]
                    [Validation(Required=false)]
                    public string NotPrint { get; set; }

                    [NameInMap("notUpper")]
                    [Validation(Required=false)]
                    public string NotUpper { get; set; }

                    [NameInMap("options")]
                    [Validation(Required=false)]
                    public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsOptions> Options { get; set; }
                    public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsOptions : TeaModel {
                        [NameInMap("extension")]
                        [Validation(Required=false)]
                        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsOptionsExtension Extension { get; set; }
                        public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsOptionsExtension : TeaModel {
                            [NameInMap("editFreeze")]
                            [Validation(Required=false)]
                            public bool? EditFreeze { get; set; }

                        }

                        [NameInMap("key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                        [NameInMap("warn")]
                        [Validation(Required=false)]
                        public bool? Warn { get; set; }

                    }

                    [NameInMap("payEnable")]
                    [Validation(Required=false)]
                    public bool? PayEnable { get; set; }

                    [NameInMap("placeholder")]
                    [Validation(Required=false)]
                    public string Placeholder { get; set; }

                    [NameInMap("quote")]
                    [Validation(Required=false)]
                    public long? Quote { get; set; }

                    [NameInMap("ratio")]
                    [Validation(Required=false)]
                    public long? Ratio { get; set; }

                    [NameInMap("relateSource")]
                    [Validation(Required=false)]
                    public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSource> RelateSource { get; set; }
                    public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSource : TeaModel {
                        [NameInMap("bizType")]
                        [Validation(Required=false)]
                        public string BizType { get; set; }

                        [NameInMap("dataSource")]
                        [Validation(Required=false)]
                        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSource DataSource { get; set; }
                        public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSource : TeaModel {
                            [NameInMap("params")]
                            [Validation(Required=false)]
                            public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceParams Params { get; set; }
                            public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceParams : TeaModel {
                                [NameInMap("filters")]
                                [Validation(Required=false)]
                                public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceParamsFilters> Filters { get; set; }
                                public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceParamsFilters : TeaModel {
                                    [NameInMap("fieldId")]
                                    [Validation(Required=false)]
                                    public string FieldId { get; set; }

                                    [NameInMap("filterType")]
                                    [Validation(Required=false)]
                                    public string FilterType { get; set; }

                                    [NameInMap("value")]
                                    [Validation(Required=false)]
                                    public string Value { get; set; }

                                    [NameInMap("valueType")]
                                    [Validation(Required=false)]
                                    public string ValueType { get; set; }

                                }

                            }

                            [NameInMap("target")]
                            [Validation(Required=false)]
                            public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceTarget Target { get; set; }
                            public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceTarget : TeaModel {
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

                        }

                        [NameInMap("fields")]
                        [Validation(Required=false)]
                        public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFields> Fields { get; set; }
                        public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFields : TeaModel {
                            [NameInMap("componentName")]
                            [Validation(Required=false)]
                            public string ComponentName { get; set; }

                            [NameInMap("relateProps")]
                            [Validation(Required=false)]
                            public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelateProps RelateProps { get; set; }
                            public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelateProps : TeaModel {
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

                                [NameInMap("fieldId")]
                                [Validation(Required=false)]
                                public string FieldId { get; set; }

                                [NameInMap("format")]
                                [Validation(Required=false)]
                                public string Format { get; set; }

                                [NameInMap("formula")]
                                [Validation(Required=false)]
                                public string Formula { get; set; }

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

                                [NameInMap("multi")]
                                [Validation(Required=false)]
                                public long? Multi { get; set; }

                                [NameInMap("notUpper")]
                                [Validation(Required=false)]
                                public string NotUpper { get; set; }

                                [NameInMap("options")]
                                [Validation(Required=false)]
                                public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsOptions> Options { get; set; }
                                public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsOptions : TeaModel {
                                    [NameInMap("extension")]
                                    [Validation(Required=false)]
                                    public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsOptionsExtension Extension { get; set; }
                                    public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsOptionsExtension : TeaModel {
                                        [NameInMap("editFreeze")]
                                        [Validation(Required=false)]
                                        public bool? EditFreeze { get; set; }

                                    }

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

                                [NameInMap("quote")]
                                [Validation(Required=false)]
                                public long? Quote { get; set; }

                                [NameInMap("required")]
                                [Validation(Required=false)]
                                public bool? Required { get; set; }

                                [NameInMap("requiredEditableFreeze")]
                                [Validation(Required=false)]
                                public bool? RequiredEditableFreeze { get; set; }

                                [NameInMap("statField")]
                                [Validation(Required=false)]
                                public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsStatField> StatField { get; set; }
                                public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsStatField : TeaModel {
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

                    }

                    [NameInMap("required")]
                    [Validation(Required=false)]
                    public bool? Required { get; set; }

                    [NameInMap("requiredEditableFreeze")]
                    [Validation(Required=false)]
                    public bool? RequiredEditableFreeze { get; set; }

                    [NameInMap("rule")]
                    [Validation(Required=false)]
                    public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRule> Rule { get; set; }
                    public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRule : TeaModel {
                        [NameInMap("type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        [NameInMap("value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    [NameInMap("sortable")]
                    [Validation(Required=false)]
                    public bool? Sortable { get; set; }

                    [NameInMap("spread")]
                    [Validation(Required=false)]
                    public bool? Spread { get; set; }

                    [NameInMap("statField")]
                    [Validation(Required=false)]
                    public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsStatField> StatField { get; set; }
                    public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsStatField : TeaModel {
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

                    [NameInMap("tableViewMode")]
                    [Validation(Required=false)]
                    public string TableViewMode { get; set; }

                    [NameInMap("unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    [NameInMap("verticalPrint")]
                    [Validation(Required=false)]
                    public bool? VerticalPrint { get; set; }

                    [NameInMap("watermark")]
                    [Validation(Required=false)]
                    public bool? Watermark { get; set; }

                }

            }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("relationMetaCode")]
            [Validation(Required=false)]
            public string RelationMetaCode { get; set; }

            [NameInMap("relationMetaStatus")]
            [Validation(Required=false)]
            public string RelationMetaStatus { get; set; }

            [NameInMap("relationType")]
            [Validation(Required=false)]
            public string RelationType { get; set; }

        }

    }

}
