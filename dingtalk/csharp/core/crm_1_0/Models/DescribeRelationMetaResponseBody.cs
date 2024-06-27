// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class DescribeRelationMetaResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("relationMetaDTOList")]
        [Validation(Required=false)]
        public List<DescribeRelationMetaResponseBodyRelationMetaDTOList> RelationMetaDTOList { get; set; }
        public class DescribeRelationMetaResponseBodyRelationMetaDTOList : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("creatorUserId")]
            [Validation(Required=false)]
            public string CreatorUserId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItems> Items { get; set; }
            public class DescribeRelationMetaResponseBodyRelationMetaDTOListItems : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("children")]
                [Validation(Required=false)]
                public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildren> Children { get; set; }
                public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildren : TeaModel {
                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("componentName")]
                    [Validation(Required=false)]
                    public string ComponentName { get; set; }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("props")]
                    [Validation(Required=false)]
                    public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps Props { get; set; }
                    public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps : TeaModel {
                        /// <summary>
                        /// This parameter is required.
                        /// </summary>
                        [NameInMap("actionName")]
                        [Validation(Required=false)]
                        public string ActionName { get; set; }

                        /// <summary>
                        /// This parameter is required.
                        /// </summary>
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

                        /// <summary>
                        /// This parameter is required.
                        /// </summary>
                        [NameInMap("bizAlias")]
                        [Validation(Required=false)]
                        public string BizAlias { get; set; }

                        /// <summary>
                        /// This parameter is required.
                        /// </summary>
                        [NameInMap("choice")]
                        [Validation(Required=false)]
                        public long? Choice { get; set; }

                        /// <summary>
                        /// This parameter is required.
                        /// </summary>
                        [NameInMap("content")]
                        [Validation(Required=false)]
                        public string Content { get; set; }

                        [NameInMap("dataSource")]
                        [Validation(Required=false)]
                        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSource DataSource { get; set; }
                        public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSource : TeaModel {
                            /// <summary>
                            /// This parameter is required.
                            /// </summary>
                            [NameInMap("params")]
                            [Validation(Required=false)]
                            public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceParams Params { get; set; }
                            public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceParams : TeaModel {
                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("filters")]
                                [Validation(Required=false)]
                                public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceParamsFilters> Filters { get; set; }
                                public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceParamsFilters : TeaModel {
                                    /// <summary>
                                    /// This parameter is required.
                                    /// </summary>
                                    [NameInMap("fieldId")]
                                    [Validation(Required=false)]
                                    public string FieldId { get; set; }

                                    /// <summary>
                                    /// This parameter is required.
                                    /// </summary>
                                    [NameInMap("filterType")]
                                    [Validation(Required=false)]
                                    public string FilterType { get; set; }

                                    /// <summary>
                                    /// This parameter is required.
                                    /// </summary>
                                    [NameInMap("value")]
                                    [Validation(Required=false)]
                                    public string Value { get; set; }

                                    /// <summary>
                                    /// This parameter is required.
                                    /// </summary>
                                    [NameInMap("valueType")]
                                    [Validation(Required=false)]
                                    public string ValueType { get; set; }

                                }

                            }

                            /// <summary>
                            /// This parameter is required.
                            /// </summary>
                            [NameInMap("target")]
                            [Validation(Required=false)]
                            public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceTarget Target { get; set; }
                            public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceTarget : TeaModel {
                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("appType")]
                                [Validation(Required=false)]
                                public long? AppType { get; set; }

                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("appUuid")]
                                [Validation(Required=false)]
                                public string AppUuid { get; set; }

                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("bizType")]
                                [Validation(Required=false)]
                                public string BizType { get; set; }

                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("formCode")]
                                [Validation(Required=false)]
                                public string FormCode { get; set; }

                            }

                            /// <summary>
                            /// This parameter is required.
                            /// </summary>
                            [NameInMap("type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                        }

                        [NameInMap("defaultColor")]
                        [Validation(Required=false)]
                        public string DefaultColor { get; set; }

                        /// <summary>
                        /// This parameter is required.
                        /// </summary>
                        [NameInMap("disabled")]
                        [Validation(Required=false)]
                        public bool? Disabled { get; set; }

                        /// <summary>
                        /// This parameter is required.
                        /// </summary>
                        [NameInMap("duration")]
                        [Validation(Required=false)]
                        public bool? Duration { get; set; }

                        /// <summary>
                        /// This parameter is required.
                        /// </summary>
                        [NameInMap("durationLabel")]
                        [Validation(Required=false)]
                        public string DurationLabel { get; set; }

                        /// <summary>
                        /// This parameter is required.
                        /// </summary>
                        [NameInMap("fieldId")]
                        [Validation(Required=false)]
                        public string FieldId { get; set; }

                        /// <summary>
                        /// This parameter is required.
                        /// </summary>
                        [NameInMap("fields")]
                        [Validation(Required=false)]
                        public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFields> Fields { get; set; }
                        public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFields : TeaModel {
                            /// <summary>
                            /// This parameter is required.
                            /// </summary>
                            [NameInMap("componentName")]
                            [Validation(Required=false)]
                            public string ComponentName { get; set; }

                            /// <summary>
                            /// This parameter is required.
                            /// </summary>
                            [NameInMap("relateProps")]
                            [Validation(Required=false)]
                            public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps RelateProps { get; set; }
                            public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps : TeaModel {
                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("align")]
                                [Validation(Required=false)]
                                public string Align { get; set; }

                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("bizAlias")]
                                [Validation(Required=false)]
                                public string BizAlias { get; set; }

                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("choice")]
                                [Validation(Required=false)]
                                public long? Choice { get; set; }

                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("content")]
                                [Validation(Required=false)]
                                public string Content { get; set; }

                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("disabled")]
                                [Validation(Required=false)]
                                public bool? Disabled { get; set; }

                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("duration")]
                                [Validation(Required=false)]
                                public bool? Duration { get; set; }

                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("durationLabel")]
                                [Validation(Required=false)]
                                public string DurationLabel { get; set; }

                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("fieldId")]
                                [Validation(Required=false)]
                                public string FieldId { get; set; }

                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("format")]
                                [Validation(Required=false)]
                                public string Format { get; set; }

                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("formula")]
                                [Validation(Required=false)]
                                public string Formula { get; set; }

                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("invisible")]
                                [Validation(Required=false)]
                                public bool? Invisible { get; set; }

                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("label")]
                                [Validation(Required=false)]
                                public string Label { get; set; }

                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("labelEditableFreeze")]
                                [Validation(Required=false)]
                                public bool? LabelEditableFreeze { get; set; }

                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("limit")]
                                [Validation(Required=false)]
                                public long? Limit { get; set; }

                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("link")]
                                [Validation(Required=false)]
                                public string Link { get; set; }

                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("mode")]
                                [Validation(Required=false)]
                                public string Mode { get; set; }

                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("notUpper")]
                                [Validation(Required=false)]
                                public string NotUpper { get; set; }

                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("options")]
                                [Validation(Required=false)]
                                public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsOptions> Options { get; set; }
                                public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsOptions : TeaModel {
                                    /// <summary>
                                    /// This parameter is required.
                                    /// </summary>
                                    [NameInMap("extension")]
                                    [Validation(Required=false)]
                                    public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsOptionsExtension Extension { get; set; }
                                    public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsOptionsExtension : TeaModel {
                                        /// <summary>
                                        /// This parameter is required.
                                        /// </summary>
                                        [NameInMap("editFreeze")]
                                        [Validation(Required=false)]
                                        public bool? EditFreeze { get; set; }

                                    }

                                    /// <summary>
                                    /// This parameter is required.
                                    /// </summary>
                                    [NameInMap("key")]
                                    [Validation(Required=false)]
                                    public string Key { get; set; }

                                    /// <summary>
                                    /// This parameter is required.
                                    /// </summary>
                                    [NameInMap("value")]
                                    [Validation(Required=false)]
                                    public string Value { get; set; }

                                }

                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("payEnable")]
                                [Validation(Required=false)]
                                public bool? PayEnable { get; set; }

                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("placeholder")]
                                [Validation(Required=false)]
                                public string Placeholder { get; set; }

                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("ratio")]
                                [Validation(Required=false)]
                                public long? Ratio { get; set; }

                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("required")]
                                [Validation(Required=false)]
                                public bool? Required { get; set; }

                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("requiredEditableFreeze")]
                                [Validation(Required=false)]
                                public bool? RequiredEditableFreeze { get; set; }

                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("spread")]
                                [Validation(Required=false)]
                                public bool? Spread { get; set; }

                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("statField")]
                                [Validation(Required=false)]
                                public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsStatField> StatField { get; set; }
                                public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsStatField : TeaModel {
                                    /// <summary>
                                    /// This parameter is required.
                                    /// </summary>
                                    [NameInMap("fieldId")]
                                    [Validation(Required=false)]
                                    public string FieldId { get; set; }

                                    /// <summary>
                                    /// This parameter is required.
                                    /// </summary>
                                    [NameInMap("label")]
                                    [Validation(Required=false)]
                                    public string Label { get; set; }

                                    /// <summary>
                                    /// This parameter is required.
                                    /// </summary>
                                    [NameInMap("unit")]
                                    [Validation(Required=false)]
                                    public string Unit { get; set; }

                                    /// <summary>
                                    /// This parameter is required.
                                    /// </summary>
                                    [NameInMap("upper")]
                                    [Validation(Required=false)]
                                    public bool? Upper { get; set; }

                                }

                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("unit")]
                                [Validation(Required=false)]
                                public string Unit { get; set; }

                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("verticalPrint")]
                                [Validation(Required=false)]
                                public bool? VerticalPrint { get; set; }

                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("watermark")]
                                [Validation(Required=false)]
                                public bool? Watermark { get; set; }

                            }

                        }

                        /// <summary>
                        /// This parameter is required.
                        /// </summary>
                        [NameInMap("format")]
                        [Validation(Required=false)]
                        public string Format { get; set; }

                        /// <summary>
                        /// This parameter is required.
                        /// </summary>
                        [NameInMap("formula")]
                        [Validation(Required=false)]
                        public string Formula { get; set; }

                        /// <summary>
                        /// This parameter is required.
                        /// </summary>
                        [NameInMap("invisible")]
                        [Validation(Required=false)]
                        public bool? Invisible { get; set; }

                        /// <summary>
                        /// This parameter is required.
                        /// </summary>
                        [NameInMap("label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        /// <summary>
                        /// This parameter is required.
                        /// </summary>
                        [NameInMap("labelEditableFreeze")]
                        [Validation(Required=false)]
                        public bool? LabelEditableFreeze { get; set; }

                        /// <summary>
                        /// This parameter is required.
                        /// </summary>
                        [NameInMap("limit")]
                        [Validation(Required=false)]
                        public long? Limit { get; set; }

                        /// <summary>
                        /// This parameter is required.
                        /// </summary>
                        [NameInMap("link")]
                        [Validation(Required=false)]
                        public string Link { get; set; }

                        /// <summary>
                        /// This parameter is required.
                        /// </summary>
                        [NameInMap("mode")]
                        [Validation(Required=false)]
                        public string Mode { get; set; }

                        /// <summary>
                        /// This parameter is required.
                        /// </summary>
                        [NameInMap("multiple")]
                        [Validation(Required=false)]
                        public bool? Multiple { get; set; }

                        /// <summary>
                        /// This parameter is required.
                        /// </summary>
                        [NameInMap("notPrint")]
                        [Validation(Required=false)]
                        public string NotPrint { get; set; }

                        /// <summary>
                        /// This parameter is required.
                        /// </summary>
                        [NameInMap("notUpper")]
                        [Validation(Required=false)]
                        public string NotUpper { get; set; }

                        /// <summary>
                        /// This parameter is required.
                        /// </summary>
                        [NameInMap("options")]
                        [Validation(Required=false)]
                        public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsOptions> Options { get; set; }
                        public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsOptions : TeaModel {
                            /// <summary>
                            /// This parameter is required.
                            /// </summary>
                            [NameInMap("extension")]
                            [Validation(Required=false)]
                            public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsOptionsExtension Extension { get; set; }
                            public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsOptionsExtension : TeaModel {
                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("editFreeze")]
                                [Validation(Required=false)]
                                public bool? EditFreeze { get; set; }

                            }

                            /// <summary>
                            /// This parameter is required.
                            /// </summary>
                            [NameInMap("key")]
                            [Validation(Required=false)]
                            public string Key { get; set; }

                            /// <summary>
                            /// This parameter is required.
                            /// </summary>
                            [NameInMap("value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// This parameter is required.
                        /// </summary>
                        [NameInMap("payEnable")]
                        [Validation(Required=false)]
                        public bool? PayEnable { get; set; }

                        /// <summary>
                        /// This parameter is required.
                        /// </summary>
                        [NameInMap("placeholder")]
                        [Validation(Required=false)]
                        public string Placeholder { get; set; }

                        /// <summary>
                        /// This parameter is required.
                        /// </summary>
                        [NameInMap("quote")]
                        [Validation(Required=false)]
                        public long? Quote { get; set; }

                        /// <summary>
                        /// This parameter is required.
                        /// </summary>
                        [NameInMap("ratio")]
                        [Validation(Required=false)]
                        public long? Ratio { get; set; }

                        /// <summary>
                        /// This parameter is required.
                        /// </summary>
                        [NameInMap("relateSource")]
                        [Validation(Required=false)]
                        public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSource> RelateSource { get; set; }
                        public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSource : TeaModel {
                            /// <summary>
                            /// This parameter is required.
                            /// </summary>
                            [NameInMap("bizType")]
                            [Validation(Required=false)]
                            public string BizType { get; set; }

                            [NameInMap("dataSource")]
                            [Validation(Required=false)]
                            public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSource DataSource { get; set; }
                            public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSource : TeaModel {
                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("params")]
                                [Validation(Required=false)]
                                public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceParams Params { get; set; }
                                public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceParams : TeaModel {
                                    /// <summary>
                                    /// This parameter is required.
                                    /// </summary>
                                    [NameInMap("filters")]
                                    [Validation(Required=false)]
                                    public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceParamsFilters> Filters { get; set; }
                                    public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceParamsFilters : TeaModel {
                                        /// <summary>
                                        /// This parameter is required.
                                        /// </summary>
                                        [NameInMap("fieldId")]
                                        [Validation(Required=false)]
                                        public string FieldId { get; set; }

                                        /// <summary>
                                        /// This parameter is required.
                                        /// </summary>
                                        [NameInMap("filterType")]
                                        [Validation(Required=false)]
                                        public string FilterType { get; set; }

                                        /// <summary>
                                        /// This parameter is required.
                                        /// </summary>
                                        [NameInMap("value")]
                                        [Validation(Required=false)]
                                        public string Value { get; set; }

                                        /// <summary>
                                        /// This parameter is required.
                                        /// </summary>
                                        [NameInMap("valueType")]
                                        [Validation(Required=false)]
                                        public string ValueType { get; set; }

                                    }

                                }

                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("target")]
                                [Validation(Required=false)]
                                public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceTarget Target { get; set; }
                                public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceTarget : TeaModel {
                                    /// <summary>
                                    /// This parameter is required.
                                    /// </summary>
                                    [NameInMap("appType")]
                                    [Validation(Required=false)]
                                    public long? AppType { get; set; }

                                    /// <summary>
                                    /// This parameter is required.
                                    /// </summary>
                                    [NameInMap("appUuid")]
                                    [Validation(Required=false)]
                                    public string AppUuid { get; set; }

                                    /// <summary>
                                    /// This parameter is required.
                                    /// </summary>
                                    [NameInMap("bizType")]
                                    [Validation(Required=false)]
                                    public string BizType { get; set; }

                                    /// <summary>
                                    /// This parameter is required.
                                    /// </summary>
                                    [NameInMap("formCode")]
                                    [Validation(Required=false)]
                                    public string FormCode { get; set; }

                                }

                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("type")]
                                [Validation(Required=false)]
                                public string Type { get; set; }

                            }

                            /// <summary>
                            /// This parameter is required.
                            /// </summary>
                            [NameInMap("fields")]
                            [Validation(Required=false)]
                            public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFields> Fields { get; set; }
                            public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFields : TeaModel {
                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("componentName")]
                                [Validation(Required=false)]
                                public string ComponentName { get; set; }

                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("relateProps")]
                                [Validation(Required=false)]
                                public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelateProps RelateProps { get; set; }
                                public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelateProps : TeaModel {
                                    /// <summary>
                                    /// This parameter is required.
                                    /// </summary>
                                    [NameInMap("align")]
                                    [Validation(Required=false)]
                                    public string Align { get; set; }

                                    /// <summary>
                                    /// This parameter is required.
                                    /// </summary>
                                    [NameInMap("bizAlias")]
                                    [Validation(Required=false)]
                                    public string BizAlias { get; set; }

                                    /// <summary>
                                    /// This parameter is required.
                                    /// </summary>
                                    [NameInMap("choice")]
                                    [Validation(Required=false)]
                                    public long? Choice { get; set; }

                                    /// <summary>
                                    /// This parameter is required.
                                    /// </summary>
                                    [NameInMap("content")]
                                    [Validation(Required=false)]
                                    public string Content { get; set; }

                                    /// <summary>
                                    /// This parameter is required.
                                    /// </summary>
                                    [NameInMap("disabled")]
                                    [Validation(Required=false)]
                                    public bool? Disabled { get; set; }

                                    /// <summary>
                                    /// This parameter is required.
                                    /// </summary>
                                    [NameInMap("duration")]
                                    [Validation(Required=false)]
                                    public string Duration { get; set; }

                                    /// <summary>
                                    /// This parameter is required.
                                    /// </summary>
                                    [NameInMap("fieldId")]
                                    [Validation(Required=false)]
                                    public string FieldId { get; set; }

                                    /// <summary>
                                    /// This parameter is required.
                                    /// </summary>
                                    [NameInMap("format")]
                                    [Validation(Required=false)]
                                    public string Format { get; set; }

                                    /// <summary>
                                    /// This parameter is required.
                                    /// </summary>
                                    [NameInMap("formula")]
                                    [Validation(Required=false)]
                                    public string Formula { get; set; }

                                    /// <summary>
                                    /// This parameter is required.
                                    /// </summary>
                                    [NameInMap("invisible")]
                                    [Validation(Required=false)]
                                    public bool? Invisible { get; set; }

                                    /// <summary>
                                    /// This parameter is required.
                                    /// </summary>
                                    [NameInMap("label")]
                                    [Validation(Required=false)]
                                    public string Label { get; set; }

                                    /// <summary>
                                    /// This parameter is required.
                                    /// </summary>
                                    [NameInMap("labelEditableFreeze")]
                                    [Validation(Required=false)]
                                    public bool? LabelEditableFreeze { get; set; }

                                    /// <summary>
                                    /// This parameter is required.
                                    /// </summary>
                                    [NameInMap("link")]
                                    [Validation(Required=false)]
                                    public string Link { get; set; }

                                    /// <summary>
                                    /// This parameter is required.
                                    /// </summary>
                                    [NameInMap("multi")]
                                    [Validation(Required=false)]
                                    public long? Multi { get; set; }

                                    /// <summary>
                                    /// This parameter is required.
                                    /// </summary>
                                    [NameInMap("notUpper")]
                                    [Validation(Required=false)]
                                    public string NotUpper { get; set; }

                                    /// <summary>
                                    /// This parameter is required.
                                    /// </summary>
                                    [NameInMap("options")]
                                    [Validation(Required=false)]
                                    public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsOptions> Options { get; set; }
                                    public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsOptions : TeaModel {
                                        /// <summary>
                                        /// This parameter is required.
                                        /// </summary>
                                        [NameInMap("key")]
                                        [Validation(Required=false)]
                                        public string Key { get; set; }

                                        /// <summary>
                                        /// This parameter is required.
                                        /// </summary>
                                        [NameInMap("value")]
                                        [Validation(Required=false)]
                                        public string Value { get; set; }

                                    }

                                    /// <summary>
                                    /// This parameter is required.
                                    /// </summary>
                                    [NameInMap("payEnable")]
                                    [Validation(Required=false)]
                                    public bool? PayEnable { get; set; }

                                    /// <summary>
                                    /// This parameter is required.
                                    /// </summary>
                                    [NameInMap("placeholder")]
                                    [Validation(Required=false)]
                                    public string Placeholder { get; set; }

                                    /// <summary>
                                    /// This parameter is required.
                                    /// </summary>
                                    [NameInMap("quote")]
                                    [Validation(Required=false)]
                                    public long? Quote { get; set; }

                                    /// <summary>
                                    /// This parameter is required.
                                    /// </summary>
                                    [NameInMap("required")]
                                    [Validation(Required=false)]
                                    public bool? Required { get; set; }

                                    /// <summary>
                                    /// This parameter is required.
                                    /// </summary>
                                    [NameInMap("requiredEditableFreeze")]
                                    [Validation(Required=false)]
                                    public bool? RequiredEditableFreeze { get; set; }

                                    /// <summary>
                                    /// This parameter is required.
                                    /// </summary>
                                    [NameInMap("statField")]
                                    [Validation(Required=false)]
                                    public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsStatField> StatField { get; set; }
                                    public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsStatField : TeaModel {
                                        /// <summary>
                                        /// This parameter is required.
                                        /// </summary>
                                        [NameInMap("fieldId")]
                                        [Validation(Required=false)]
                                        public string FieldId { get; set; }

                                        /// <summary>
                                        /// This parameter is required.
                                        /// </summary>
                                        [NameInMap("label")]
                                        [Validation(Required=false)]
                                        public string Label { get; set; }

                                        /// <summary>
                                        /// This parameter is required.
                                        /// </summary>
                                        [NameInMap("unit")]
                                        [Validation(Required=false)]
                                        public string Unit { get; set; }

                                        /// <summary>
                                        /// This parameter is required.
                                        /// </summary>
                                        [NameInMap("upper")]
                                        [Validation(Required=false)]
                                        public bool? Upper { get; set; }

                                    }

                                    /// <summary>
                                    /// This parameter is required.
                                    /// </summary>
                                    [NameInMap("unit")]
                                    [Validation(Required=false)]
                                    public string Unit { get; set; }

                                    /// <summary>
                                    /// This parameter is required.
                                    /// </summary>
                                    [NameInMap("verticalPrint")]
                                    [Validation(Required=false)]
                                    public bool? VerticalPrint { get; set; }

                                }

                            }

                        }

                        /// <summary>
                        /// This parameter is required.
                        /// </summary>
                        [NameInMap("required")]
                        [Validation(Required=false)]
                        public bool? Required { get; set; }

                        /// <summary>
                        /// This parameter is required.
                        /// </summary>
                        [NameInMap("requiredEditableFreeze")]
                        [Validation(Required=false)]
                        public bool? RequiredEditableFreeze { get; set; }

                        /// <summary>
                        /// This parameter is required.
                        /// </summary>
                        [NameInMap("rule")]
                        [Validation(Required=false)]
                        public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRule> Rule { get; set; }
                        public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRule : TeaModel {
                            /// <summary>
                            /// This parameter is required.
                            /// </summary>
                            [NameInMap("type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                            /// <summary>
                            /// This parameter is required.
                            /// </summary>
                            [NameInMap("value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// This parameter is required.
                        /// </summary>
                        [NameInMap("sortable")]
                        [Validation(Required=false)]
                        public bool? Sortable { get; set; }

                        /// <summary>
                        /// This parameter is required.
                        /// </summary>
                        [NameInMap("spread")]
                        [Validation(Required=false)]
                        public bool? Spread { get; set; }

                        /// <summary>
                        /// This parameter is required.
                        /// </summary>
                        [NameInMap("statField")]
                        [Validation(Required=false)]
                        public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsStatField> StatField { get; set; }
                        public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsStatField : TeaModel {
                            /// <summary>
                            /// This parameter is required.
                            /// </summary>
                            [NameInMap("fieldId")]
                            [Validation(Required=false)]
                            public string FieldId { get; set; }

                            /// <summary>
                            /// This parameter is required.
                            /// </summary>
                            [NameInMap("label")]
                            [Validation(Required=false)]
                            public string Label { get; set; }

                            /// <summary>
                            /// This parameter is required.
                            /// </summary>
                            [NameInMap("unit")]
                            [Validation(Required=false)]
                            public string Unit { get; set; }

                            /// <summary>
                            /// This parameter is required.
                            /// </summary>
                            [NameInMap("upper")]
                            [Validation(Required=false)]
                            public bool? Upper { get; set; }

                        }

                        /// <summary>
                        /// This parameter is required.
                        /// </summary>
                        [NameInMap("tableViewMode")]
                        [Validation(Required=false)]
                        public string TableViewMode { get; set; }

                        /// <summary>
                        /// This parameter is required.
                        /// </summary>
                        [NameInMap("unit")]
                        [Validation(Required=false)]
                        public string Unit { get; set; }

                        /// <summary>
                        /// This parameter is required.
                        /// </summary>
                        [NameInMap("verticalPrint")]
                        [Validation(Required=false)]
                        public bool? VerticalPrint { get; set; }

                        /// <summary>
                        /// This parameter is required.
                        /// </summary>
                        [NameInMap("watermark")]
                        [Validation(Required=false)]
                        public bool? Watermark { get; set; }

                    }

                }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("componentName")]
                [Validation(Required=false)]
                public string ComponentName { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("props")]
                [Validation(Required=false)]
                public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps Props { get; set; }
                public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps : TeaModel {
                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("actionName")]
                    [Validation(Required=false)]
                    public string ActionName { get; set; }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
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

                    [NameInMap("behaviorLinkage")]
                    [Validation(Required=false)]
                    public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsBehaviorLinkage> BehaviorLinkage { get; set; }
                    public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsBehaviorLinkage : TeaModel {
                        [NameInMap("optionKey")]
                        [Validation(Required=false)]
                        public string OptionKey { get; set; }

                        [NameInMap("targets")]
                        [Validation(Required=false)]
                        public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsBehaviorLinkageTargets> Targets { get; set; }
                        public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsBehaviorLinkageTargets : TeaModel {
                            [NameInMap("behavior")]
                            [Validation(Required=false)]
                            public string Behavior { get; set; }

                            [NameInMap("fieldId")]
                            [Validation(Required=false)]
                            public string FieldId { get; set; }

                        }

                    }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("bizAlias")]
                    [Validation(Required=false)]
                    public string BizAlias { get; set; }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("choice")]
                    [Validation(Required=false)]
                    public long? Choice { get; set; }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    [NameInMap("dataSource")]
                    [Validation(Required=false)]
                    public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSource DataSource { get; set; }
                    public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSource : TeaModel {
                        /// <summary>
                        /// This parameter is required.
                        /// </summary>
                        [NameInMap("params")]
                        [Validation(Required=false)]
                        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceParams Params { get; set; }
                        public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceParams : TeaModel {
                            /// <summary>
                            /// This parameter is required.
                            /// </summary>
                            [NameInMap("filters")]
                            [Validation(Required=false)]
                            public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceParamsFilters> Filters { get; set; }
                            public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceParamsFilters : TeaModel {
                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("fieldId")]
                                [Validation(Required=false)]
                                public string FieldId { get; set; }

                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("filterType")]
                                [Validation(Required=false)]
                                public string FilterType { get; set; }

                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("value")]
                                [Validation(Required=false)]
                                public string Value { get; set; }

                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
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

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("disabled")]
                    [Validation(Required=false)]
                    public bool? Disabled { get; set; }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("duration")]
                    [Validation(Required=false)]
                    public bool? Duration { get; set; }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("durationLabel")]
                    [Validation(Required=false)]
                    public string DurationLabel { get; set; }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("fieldId")]
                    [Validation(Required=false)]
                    public string FieldId { get; set; }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("fields")]
                    [Validation(Required=false)]
                    public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFields> Fields { get; set; }
                    public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFields : TeaModel {
                        /// <summary>
                        /// This parameter is required.
                        /// </summary>
                        [NameInMap("componentName")]
                        [Validation(Required=false)]
                        public string ComponentName { get; set; }

                        /// <summary>
                        /// This parameter is required.
                        /// </summary>
                        [NameInMap("relateProps")]
                        [Validation(Required=false)]
                        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps RelateProps { get; set; }
                        public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps : TeaModel {
                            /// <summary>
                            /// This parameter is required.
                            /// </summary>
                            [NameInMap("align")]
                            [Validation(Required=false)]
                            public string Align { get; set; }

                            /// <summary>
                            /// This parameter is required.
                            /// </summary>
                            [NameInMap("bizAlias")]
                            [Validation(Required=false)]
                            public string BizAlias { get; set; }

                            /// <summary>
                            /// This parameter is required.
                            /// </summary>
                            [NameInMap("choice")]
                            [Validation(Required=false)]
                            public long? Choice { get; set; }

                            /// <summary>
                            /// This parameter is required.
                            /// </summary>
                            [NameInMap("content")]
                            [Validation(Required=false)]
                            public string Content { get; set; }

                            /// <summary>
                            /// This parameter is required.
                            /// </summary>
                            [NameInMap("disabled")]
                            [Validation(Required=false)]
                            public bool? Disabled { get; set; }

                            /// <summary>
                            /// This parameter is required.
                            /// </summary>
                            [NameInMap("duration")]
                            [Validation(Required=false)]
                            public string Duration { get; set; }

                            /// <summary>
                            /// This parameter is required.
                            /// </summary>
                            [NameInMap("durationLabel")]
                            [Validation(Required=false)]
                            public string DurationLabel { get; set; }

                            /// <summary>
                            /// This parameter is required.
                            /// </summary>
                            [NameInMap("fieldId")]
                            [Validation(Required=false)]
                            public string FieldId { get; set; }

                            /// <summary>
                            /// This parameter is required.
                            /// </summary>
                            [NameInMap("format")]
                            [Validation(Required=false)]
                            public string Format { get; set; }

                            /// <summary>
                            /// This parameter is required.
                            /// </summary>
                            [NameInMap("formula")]
                            [Validation(Required=false)]
                            public string Formula { get; set; }

                            /// <summary>
                            /// This parameter is required.
                            /// </summary>
                            [NameInMap("invisible")]
                            [Validation(Required=false)]
                            public bool? Invisible { get; set; }

                            /// <summary>
                            /// This parameter is required.
                            /// </summary>
                            [NameInMap("label")]
                            [Validation(Required=false)]
                            public string Label { get; set; }

                            /// <summary>
                            /// This parameter is required.
                            /// </summary>
                            [NameInMap("labelEditableFreeze")]
                            [Validation(Required=false)]
                            public bool? LabelEditableFreeze { get; set; }

                            /// <summary>
                            /// This parameter is required.
                            /// </summary>
                            [NameInMap("limit")]
                            [Validation(Required=false)]
                            public long? Limit { get; set; }

                            /// <summary>
                            /// This parameter is required.
                            /// </summary>
                            [NameInMap("link")]
                            [Validation(Required=false)]
                            public string Link { get; set; }

                            /// <summary>
                            /// This parameter is required.
                            /// </summary>
                            [NameInMap("mode")]
                            [Validation(Required=false)]
                            public string Mode { get; set; }

                            /// <summary>
                            /// This parameter is required.
                            /// </summary>
                            [NameInMap("notUpper")]
                            [Validation(Required=false)]
                            public string NotUpper { get; set; }

                            /// <summary>
                            /// This parameter is required.
                            /// </summary>
                            [NameInMap("options")]
                            [Validation(Required=false)]
                            public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsOptions> Options { get; set; }
                            public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsOptions : TeaModel {
                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("extension")]
                                [Validation(Required=false)]
                                public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsOptionsExtension Extension { get; set; }
                                public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsOptionsExtension : TeaModel {
                                    /// <summary>
                                    /// This parameter is required.
                                    /// </summary>
                                    [NameInMap("editFreeze")]
                                    [Validation(Required=false)]
                                    public bool? EditFreeze { get; set; }

                                }

                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("key")]
                                [Validation(Required=false)]
                                public string Key { get; set; }

                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("value")]
                                [Validation(Required=false)]
                                public string Value { get; set; }

                            }

                            /// <summary>
                            /// This parameter is required.
                            /// </summary>
                            [NameInMap("payEnable")]
                            [Validation(Required=false)]
                            public bool? PayEnable { get; set; }

                            /// <summary>
                            /// This parameter is required.
                            /// </summary>
                            [NameInMap("placeholder")]
                            [Validation(Required=false)]
                            public string Placeholder { get; set; }

                            /// <summary>
                            /// This parameter is required.
                            /// </summary>
                            [NameInMap("ratio")]
                            [Validation(Required=false)]
                            public long? Ratio { get; set; }

                            /// <summary>
                            /// This parameter is required.
                            /// </summary>
                            [NameInMap("required")]
                            [Validation(Required=false)]
                            public bool? Required { get; set; }

                            /// <summary>
                            /// This parameter is required.
                            /// </summary>
                            [NameInMap("requiredEditableFreeze")]
                            [Validation(Required=false)]
                            public bool? RequiredEditableFreeze { get; set; }

                            /// <summary>
                            /// This parameter is required.
                            /// </summary>
                            [NameInMap("spread")]
                            [Validation(Required=false)]
                            public bool? Spread { get; set; }

                            /// <summary>
                            /// This parameter is required.
                            /// </summary>
                            [NameInMap("statField")]
                            [Validation(Required=false)]
                            public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsStatField> StatField { get; set; }
                            public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsStatField : TeaModel {
                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("fieldId")]
                                [Validation(Required=false)]
                                public string FieldId { get; set; }

                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("label")]
                                [Validation(Required=false)]
                                public string Label { get; set; }

                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("unit")]
                                [Validation(Required=false)]
                                public string Unit { get; set; }

                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("upper")]
                                [Validation(Required=false)]
                                public bool? Upper { get; set; }

                            }

                            /// <summary>
                            /// This parameter is required.
                            /// </summary>
                            [NameInMap("unit")]
                            [Validation(Required=false)]
                            public string Unit { get; set; }

                            /// <summary>
                            /// This parameter is required.
                            /// </summary>
                            [NameInMap("verticalPrint")]
                            [Validation(Required=false)]
                            public bool? VerticalPrint { get; set; }

                            /// <summary>
                            /// This parameter is required.
                            /// </summary>
                            [NameInMap("watermark")]
                            [Validation(Required=false)]
                            public bool? Watermark { get; set; }

                        }

                    }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("format")]
                    [Validation(Required=false)]
                    public string Format { get; set; }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("formula")]
                    [Validation(Required=false)]
                    public string Formula { get; set; }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("invisible")]
                    [Validation(Required=false)]
                    public bool? Invisible { get; set; }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("labelEditableFreeze")]
                    [Validation(Required=false)]
                    public bool? LabelEditableFreeze { get; set; }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("limit")]
                    [Validation(Required=false)]
                    public long? Limit { get; set; }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("link")]
                    [Validation(Required=false)]
                    public string Link { get; set; }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("mode")]
                    [Validation(Required=false)]
                    public string Mode { get; set; }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("multi")]
                    [Validation(Required=false)]
                    public long? Multi { get; set; }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("multiple")]
                    [Validation(Required=false)]
                    public bool? Multiple { get; set; }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("needDetail")]
                    [Validation(Required=false)]
                    public string NeedDetail { get; set; }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("notPrint")]
                    [Validation(Required=false)]
                    public string NotPrint { get; set; }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("notUpper")]
                    [Validation(Required=false)]
                    public string NotUpper { get; set; }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("options")]
                    [Validation(Required=false)]
                    public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsOptions> Options { get; set; }
                    public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsOptions : TeaModel {
                        /// <summary>
                        /// This parameter is required.
                        /// </summary>
                        [NameInMap("extension")]
                        [Validation(Required=false)]
                        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsOptionsExtension Extension { get; set; }
                        public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsOptionsExtension : TeaModel {
                            /// <summary>
                            /// This parameter is required.
                            /// </summary>
                            [NameInMap("editFreeze")]
                            [Validation(Required=false)]
                            public bool? EditFreeze { get; set; }

                        }

                        /// <summary>
                        /// This parameter is required.
                        /// </summary>
                        [NameInMap("key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// This parameter is required.
                        /// </summary>
                        [NameInMap("value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                        /// <summary>
                        /// This parameter is required.
                        /// </summary>
                        [NameInMap("warn")]
                        [Validation(Required=false)]
                        public bool? Warn { get; set; }

                    }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("payEnable")]
                    [Validation(Required=false)]
                    public bool? PayEnable { get; set; }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("placeholder")]
                    [Validation(Required=false)]
                    public string Placeholder { get; set; }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("quote")]
                    [Validation(Required=false)]
                    public long? Quote { get; set; }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("ratio")]
                    [Validation(Required=false)]
                    public long? Ratio { get; set; }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("relateSource")]
                    [Validation(Required=false)]
                    public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSource> RelateSource { get; set; }
                    public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSource : TeaModel {
                        /// <summary>
                        /// This parameter is required.
                        /// </summary>
                        [NameInMap("bizType")]
                        [Validation(Required=false)]
                        public string BizType { get; set; }

                        [NameInMap("dataSource")]
                        [Validation(Required=false)]
                        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSource DataSource { get; set; }
                        public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSource : TeaModel {
                            /// <summary>
                            /// This parameter is required.
                            /// </summary>
                            [NameInMap("params")]
                            [Validation(Required=false)]
                            public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceParams Params { get; set; }
                            public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceParams : TeaModel {
                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("filters")]
                                [Validation(Required=false)]
                                public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceParamsFilters> Filters { get; set; }
                                public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceParamsFilters : TeaModel {
                                    /// <summary>
                                    /// This parameter is required.
                                    /// </summary>
                                    [NameInMap("fieldId")]
                                    [Validation(Required=false)]
                                    public string FieldId { get; set; }

                                    /// <summary>
                                    /// This parameter is required.
                                    /// </summary>
                                    [NameInMap("filterType")]
                                    [Validation(Required=false)]
                                    public string FilterType { get; set; }

                                    /// <summary>
                                    /// This parameter is required.
                                    /// </summary>
                                    [NameInMap("value")]
                                    [Validation(Required=false)]
                                    public string Value { get; set; }

                                    /// <summary>
                                    /// This parameter is required.
                                    /// </summary>
                                    [NameInMap("valueType")]
                                    [Validation(Required=false)]
                                    public string ValueType { get; set; }

                                }

                            }

                            /// <summary>
                            /// This parameter is required.
                            /// </summary>
                            [NameInMap("target")]
                            [Validation(Required=false)]
                            public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceTarget Target { get; set; }
                            public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceTarget : TeaModel {
                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("appType")]
                                [Validation(Required=false)]
                                public long? AppType { get; set; }

                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("appUuid")]
                                [Validation(Required=false)]
                                public string AppUuid { get; set; }

                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("bizType")]
                                [Validation(Required=false)]
                                public string BizType { get; set; }

                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("formCode")]
                                [Validation(Required=false)]
                                public string FormCode { get; set; }

                            }

                            /// <summary>
                            /// This parameter is required.
                            /// </summary>
                            [NameInMap("type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                        }

                        /// <summary>
                        /// This parameter is required.
                        /// </summary>
                        [NameInMap("fields")]
                        [Validation(Required=false)]
                        public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFields> Fields { get; set; }
                        public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFields : TeaModel {
                            /// <summary>
                            /// This parameter is required.
                            /// </summary>
                            [NameInMap("componentName")]
                            [Validation(Required=false)]
                            public string ComponentName { get; set; }

                            /// <summary>
                            /// This parameter is required.
                            /// </summary>
                            [NameInMap("relateProps")]
                            [Validation(Required=false)]
                            public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelateProps RelateProps { get; set; }
                            public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelateProps : TeaModel {
                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("align")]
                                [Validation(Required=false)]
                                public string Align { get; set; }

                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("bizAlias")]
                                [Validation(Required=false)]
                                public string BizAlias { get; set; }

                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("choice")]
                                [Validation(Required=false)]
                                public long? Choice { get; set; }

                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("content")]
                                [Validation(Required=false)]
                                public string Content { get; set; }

                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("disabled")]
                                [Validation(Required=false)]
                                public bool? Disabled { get; set; }

                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("duration")]
                                [Validation(Required=false)]
                                public string Duration { get; set; }

                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("fieldId")]
                                [Validation(Required=false)]
                                public string FieldId { get; set; }

                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("format")]
                                [Validation(Required=false)]
                                public string Format { get; set; }

                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("formula")]
                                [Validation(Required=false)]
                                public string Formula { get; set; }

                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("invisible")]
                                [Validation(Required=false)]
                                public bool? Invisible { get; set; }

                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("label")]
                                [Validation(Required=false)]
                                public string Label { get; set; }

                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("labelEditableFreeze")]
                                [Validation(Required=false)]
                                public bool? LabelEditableFreeze { get; set; }

                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("link")]
                                [Validation(Required=false)]
                                public string Link { get; set; }

                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("multi")]
                                [Validation(Required=false)]
                                public long? Multi { get; set; }

                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("notUpper")]
                                [Validation(Required=false)]
                                public string NotUpper { get; set; }

                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("options")]
                                [Validation(Required=false)]
                                public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsOptions> Options { get; set; }
                                public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsOptions : TeaModel {
                                    /// <summary>
                                    /// This parameter is required.
                                    /// </summary>
                                    [NameInMap("extension")]
                                    [Validation(Required=false)]
                                    public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsOptionsExtension Extension { get; set; }
                                    public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsOptionsExtension : TeaModel {
                                        /// <summary>
                                        /// This parameter is required.
                                        /// </summary>
                                        [NameInMap("editFreeze")]
                                        [Validation(Required=false)]
                                        public bool? EditFreeze { get; set; }

                                    }

                                    /// <summary>
                                    /// This parameter is required.
                                    /// </summary>
                                    [NameInMap("key")]
                                    [Validation(Required=false)]
                                    public string Key { get; set; }

                                    /// <summary>
                                    /// This parameter is required.
                                    /// </summary>
                                    [NameInMap("value")]
                                    [Validation(Required=false)]
                                    public string Value { get; set; }

                                }

                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("payEnable")]
                                [Validation(Required=false)]
                                public bool? PayEnable { get; set; }

                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("placeholder")]
                                [Validation(Required=false)]
                                public string Placeholder { get; set; }

                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("quote")]
                                [Validation(Required=false)]
                                public long? Quote { get; set; }

                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("required")]
                                [Validation(Required=false)]
                                public bool? Required { get; set; }

                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("requiredEditableFreeze")]
                                [Validation(Required=false)]
                                public bool? RequiredEditableFreeze { get; set; }

                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("statField")]
                                [Validation(Required=false)]
                                public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsStatField> StatField { get; set; }
                                public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsStatField : TeaModel {
                                    /// <summary>
                                    /// This parameter is required.
                                    /// </summary>
                                    [NameInMap("fieldId")]
                                    [Validation(Required=false)]
                                    public string FieldId { get; set; }

                                    /// <summary>
                                    /// This parameter is required.
                                    /// </summary>
                                    [NameInMap("label")]
                                    [Validation(Required=false)]
                                    public string Label { get; set; }

                                    /// <summary>
                                    /// This parameter is required.
                                    /// </summary>
                                    [NameInMap("unit")]
                                    [Validation(Required=false)]
                                    public string Unit { get; set; }

                                    /// <summary>
                                    /// This parameter is required.
                                    /// </summary>
                                    [NameInMap("upper")]
                                    [Validation(Required=false)]
                                    public bool? Upper { get; set; }

                                }

                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("unit")]
                                [Validation(Required=false)]
                                public string Unit { get; set; }

                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("verticalPrint")]
                                [Validation(Required=false)]
                                public bool? VerticalPrint { get; set; }

                            }

                        }

                    }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("required")]
                    [Validation(Required=false)]
                    public bool? Required { get; set; }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("requiredEditableFreeze")]
                    [Validation(Required=false)]
                    public bool? RequiredEditableFreeze { get; set; }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("rule")]
                    [Validation(Required=false)]
                    public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRule> Rule { get; set; }
                    public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRule : TeaModel {
                        /// <summary>
                        /// This parameter is required.
                        /// </summary>
                        [NameInMap("type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        /// <summary>
                        /// This parameter is required.
                        /// </summary>
                        [NameInMap("value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("sortable")]
                    [Validation(Required=false)]
                    public bool? Sortable { get; set; }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("spread")]
                    [Validation(Required=false)]
                    public bool? Spread { get; set; }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("statField")]
                    [Validation(Required=false)]
                    public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsStatField> StatField { get; set; }
                    public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsStatField : TeaModel {
                        /// <summary>
                        /// This parameter is required.
                        /// </summary>
                        [NameInMap("fieldId")]
                        [Validation(Required=false)]
                        public string FieldId { get; set; }

                        /// <summary>
                        /// This parameter is required.
                        /// </summary>
                        [NameInMap("label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        /// <summary>
                        /// This parameter is required.
                        /// </summary>
                        [NameInMap("unit")]
                        [Validation(Required=false)]
                        public string Unit { get; set; }

                        /// <summary>
                        /// This parameter is required.
                        /// </summary>
                        [NameInMap("upper")]
                        [Validation(Required=false)]
                        public bool? Upper { get; set; }

                    }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("tableViewMode")]
                    [Validation(Required=false)]
                    public string TableViewMode { get; set; }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("verticalPrint")]
                    [Validation(Required=false)]
                    public bool? VerticalPrint { get; set; }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("watermark")]
                    [Validation(Required=false)]
                    public bool? Watermark { get; set; }

                }

            }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("relationMetaCode")]
            [Validation(Required=false)]
            public string RelationMetaCode { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("relationMetaStatus")]
            [Validation(Required=false)]
            public string RelationMetaStatus { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("relationType")]
            [Validation(Required=false)]
            public string RelationType { get; set; }

        }

    }

}
