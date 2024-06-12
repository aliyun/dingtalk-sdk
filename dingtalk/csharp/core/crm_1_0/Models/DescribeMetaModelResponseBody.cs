// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class DescribeMetaModelResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("metaModelDTOList")]
        [Validation(Required=false)]
        public List<DescribeMetaModelResponseBodyMetaModelDTOList> MetaModelDTOList { get; set; }
        public class DescribeMetaModelResponseBodyMetaModelDTOList : TeaModel {
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
            public List<DescribeMetaModelResponseBodyMetaModelDTOListItems> Items { get; set; }
            public class DescribeMetaModelResponseBodyMetaModelDTOListItems : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("children")]
                [Validation(Required=false)]
                public List<DescribeMetaModelResponseBodyMetaModelDTOListItemsChildren> Children { get; set; }
                public class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildren : TeaModel {
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
                    public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenProps Props { get; set; }
                    public class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenProps : TeaModel {
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
                        public List<DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsAvailableTemplates> AvailableTemplates { get; set; }
                        public class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsAvailableTemplates : TeaModel {
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
                        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsDataSource DataSource { get; set; }
                        public class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsDataSource : TeaModel {
                            /// <summary>
                            /// This parameter is required.
                            /// </summary>
                            [NameInMap("params")]
                            [Validation(Required=false)]
                            public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsDataSourceParams Params { get; set; }
                            public class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsDataSourceParams : TeaModel {
                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("filters")]
                                [Validation(Required=false)]
                                public List<DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsDataSourceParamsFilters> Filters { get; set; }
                                public class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsDataSourceParamsFilters : TeaModel {
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
                            public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsDataSourceTarget Target { get; set; }
                            public class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsDataSourceTarget : TeaModel {
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
                        public List<DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFields> Fields { get; set; }
                        public class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFields : TeaModel {
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
                            public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelateProps RelateProps { get; set; }
                            public class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelateProps : TeaModel {
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
                                public List<DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelatePropsOptions> Options { get; set; }
                                public class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelatePropsOptions : TeaModel {
                                    /// <summary>
                                    /// This parameter is required.
                                    /// </summary>
                                    [NameInMap("extension")]
                                    [Validation(Required=false)]
                                    public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelatePropsOptionsExtension Extension { get; set; }
                                    public class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelatePropsOptionsExtension : TeaModel {
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
                                public List<DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelatePropsStatField> StatField { get; set; }
                                public class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelatePropsStatField : TeaModel {
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
                        public List<DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsOptions> Options { get; set; }
                        public class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsOptions : TeaModel {
                            /// <summary>
                            /// This parameter is required.
                            /// </summary>
                            [NameInMap("extension")]
                            [Validation(Required=false)]
                            public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsOptionsExtension Extension { get; set; }
                            public class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsOptionsExtension : TeaModel {
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
                        public List<DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSource> RelateSource { get; set; }
                        public class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSource : TeaModel {
                            /// <summary>
                            /// This parameter is required.
                            /// </summary>
                            [NameInMap("bizType")]
                            [Validation(Required=false)]
                            public string BizType { get; set; }

                            [NameInMap("dataSource")]
                            [Validation(Required=false)]
                            public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceDataSource DataSource { get; set; }
                            public class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceDataSource : TeaModel {
                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("params")]
                                [Validation(Required=false)]
                                public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceDataSourceParams Params { get; set; }
                                public class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceDataSourceParams : TeaModel {
                                    /// <summary>
                                    /// This parameter is required.
                                    /// </summary>
                                    [NameInMap("filters")]
                                    [Validation(Required=false)]
                                    public List<DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceDataSourceParamsFilters> Filters { get; set; }
                                    public class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceDataSourceParamsFilters : TeaModel {
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
                                public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceDataSourceTarget Target { get; set; }
                                public class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceDataSourceTarget : TeaModel {
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
                            public List<DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFields> Fields { get; set; }
                            public class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFields : TeaModel {
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
                                public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFieldsRelateProps RelateProps { get; set; }
                                public class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFieldsRelateProps : TeaModel {
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
                                    public List<DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsOptions> Options { get; set; }
                                    public class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsOptions : TeaModel {
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
                                    public List<DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsStatField> StatField { get; set; }
                                    public class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsStatField : TeaModel {
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
                        public List<DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRule> Rule { get; set; }
                        public class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRule : TeaModel {
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
                        public List<DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsStatField> StatField { get; set; }
                        public class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsStatField : TeaModel {
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
                public DescribeMetaModelResponseBodyMetaModelDTOListItemsProps Props { get; set; }
                public class DescribeMetaModelResponseBodyMetaModelDTOListItemsProps : TeaModel {
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
                    public List<DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsAvailableTemplates> AvailableTemplates { get; set; }
                    public class DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsAvailableTemplates : TeaModel {
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
                    public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsDataSource DataSource { get; set; }
                    public class DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsDataSource : TeaModel {
                        /// <summary>
                        /// This parameter is required.
                        /// </summary>
                        [NameInMap("params")]
                        [Validation(Required=false)]
                        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsDataSourceParams Params { get; set; }
                        public class DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsDataSourceParams : TeaModel {
                            /// <summary>
                            /// This parameter is required.
                            /// </summary>
                            [NameInMap("filters")]
                            [Validation(Required=false)]
                            public List<DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsDataSourceParamsFilters> Filters { get; set; }
                            public class DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsDataSourceParamsFilters : TeaModel {
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
                        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsDataSourceTarget Target { get; set; }
                        public class DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsDataSourceTarget : TeaModel {
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
                    public List<DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFields> Fields { get; set; }
                    public class DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFields : TeaModel {
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
                        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelateProps RelateProps { get; set; }
                        public class DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelateProps : TeaModel {
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
                            public List<DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelatePropsOptions> Options { get; set; }
                            public class DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelatePropsOptions : TeaModel {
                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("extension")]
                                [Validation(Required=false)]
                                public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelatePropsOptionsExtension Extension { get; set; }
                                public class DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelatePropsOptionsExtension : TeaModel {
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
                            public List<DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelatePropsStatField> StatField { get; set; }
                            public class DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelatePropsStatField : TeaModel {
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
                    public List<DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsOptions> Options { get; set; }
                    public class DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsOptions : TeaModel {
                        /// <summary>
                        /// This parameter is required.
                        /// </summary>
                        [NameInMap("extension")]
                        [Validation(Required=false)]
                        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsOptionsExtension Extension { get; set; }
                        public class DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsOptionsExtension : TeaModel {
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
                    public List<DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSource> RelateSource { get; set; }
                    public class DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSource : TeaModel {
                        /// <summary>
                        /// This parameter is required.
                        /// </summary>
                        [NameInMap("bizType")]
                        [Validation(Required=false)]
                        public string BizType { get; set; }

                        [NameInMap("dataSource")]
                        [Validation(Required=false)]
                        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceDataSource DataSource { get; set; }
                        public class DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceDataSource : TeaModel {
                            /// <summary>
                            /// This parameter is required.
                            /// </summary>
                            [NameInMap("params")]
                            [Validation(Required=false)]
                            public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceDataSourceParams Params { get; set; }
                            public class DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceDataSourceParams : TeaModel {
                                /// <summary>
                                /// This parameter is required.
                                /// </summary>
                                [NameInMap("filters")]
                                [Validation(Required=false)]
                                public List<DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceDataSourceParamsFilters> Filters { get; set; }
                                public class DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceDataSourceParamsFilters : TeaModel {
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
                            public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceDataSourceTarget Target { get; set; }
                            public class DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceDataSourceTarget : TeaModel {
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
                        public List<DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFields> Fields { get; set; }
                        public class DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFields : TeaModel {
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
                            public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelateProps RelateProps { get; set; }
                            public class DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelateProps : TeaModel {
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
                                public List<DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelatePropsOptions> Options { get; set; }
                                public class DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelatePropsOptions : TeaModel {
                                    /// <summary>
                                    /// This parameter is required.
                                    /// </summary>
                                    [NameInMap("extension")]
                                    [Validation(Required=false)]
                                    public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelatePropsOptionsExtension Extension { get; set; }
                                    public class DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelatePropsOptionsExtension : TeaModel {
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
                                public List<DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelatePropsStatField> StatField { get; set; }
                                public class DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelatePropsStatField : TeaModel {
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
                    public List<DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRule> Rule { get; set; }
                    public class DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRule : TeaModel {
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
                    public List<DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsStatField> StatField { get; set; }
                    public class DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsStatField : TeaModel {
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
