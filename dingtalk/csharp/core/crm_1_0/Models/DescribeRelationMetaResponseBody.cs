// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class DescribeRelationMetaResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("relationMetaDTOList")]
        [Validation(Required=false)]
        public List<DescribeRelationMetaResponseBodyRelationMetaDTOList> RelationMetaDTOList { get; set; }
        public class DescribeRelationMetaResponseBodyRelationMetaDTOList : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("creatorUserId")]
            [Validation(Required=false)]
            public string CreatorUserId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>企业客户表</para>
            /// </summary>
            [NameInMap("desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItems> Items { get; set; }
            public class DescribeRelationMetaResponseBodyRelationMetaDTOListItems : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("children")]
                [Validation(Required=false)]
                public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildren> Children { get; set; }
                public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildren : TeaModel {
                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("componentName")]
                    [Validation(Required=false)]
                    public string ComponentName { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("props")]
                    [Validation(Required=false)]
                    public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps Props { get; set; }
                    public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps : TeaModel {
                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("actionName")]
                        [Validation(Required=false)]
                        public string ActionName { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("align")]
                        [Validation(Required=false)]
                        public string Align { get; set; }

                        [NameInMap("availableTemplates")]
                        [Validation(Required=false)]
                        public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsAvailableTemplates> AvailableTemplates { get; set; }
                        public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsAvailableTemplates : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>审批模板id</para>
                            /// </summary>
                            [NameInMap("id")]
                            [Validation(Required=false)]
                            public string Id { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>审批模板名称</para>
                            /// </summary>
                            [NameInMap("name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                        }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("bizAlias")]
                        [Validation(Required=false)]
                        public string BizAlias { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("choice")]
                        [Validation(Required=false)]
                        public long? Choice { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("content")]
                        [Validation(Required=false)]
                        public string Content { get; set; }

                        [NameInMap("dataSource")]
                        [Validation(Required=false)]
                        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSource DataSource { get; set; }
                        public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSource : TeaModel {
                            /// <summary>
                            /// <para>This parameter is required.</para>
                            /// </summary>
                            [NameInMap("params")]
                            [Validation(Required=false)]
                            public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceParams Params { get; set; }
                            public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceParams : TeaModel {
                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// </summary>
                                [NameInMap("filters")]
                                [Validation(Required=false)]
                                public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceParamsFilters> Filters { get; set; }
                                public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceParamsFilters : TeaModel {
                                    /// <summary>
                                    /// <para>This parameter is required.</para>
                                    /// </summary>
                                    [NameInMap("fieldId")]
                                    [Validation(Required=false)]
                                    public string FieldId { get; set; }

                                    /// <summary>
                                    /// <para>This parameter is required.</para>
                                    /// </summary>
                                    [NameInMap("filterType")]
                                    [Validation(Required=false)]
                                    public string FilterType { get; set; }

                                    /// <summary>
                                    /// <para>This parameter is required.</para>
                                    /// </summary>
                                    [NameInMap("value")]
                                    [Validation(Required=false)]
                                    public string Value { get; set; }

                                    /// <summary>
                                    /// <para>This parameter is required.</para>
                                    /// </summary>
                                    [NameInMap("valueType")]
                                    [Validation(Required=false)]
                                    public string ValueType { get; set; }

                                }

                            }

                            /// <summary>
                            /// <para>This parameter is required.</para>
                            /// </summary>
                            [NameInMap("target")]
                            [Validation(Required=false)]
                            public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceTarget Target { get; set; }
                            public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceTarget : TeaModel {
                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// </summary>
                                [NameInMap("appType")]
                                [Validation(Required=false)]
                                public long? AppType { get; set; }

                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// </summary>
                                [NameInMap("appUuid")]
                                [Validation(Required=false)]
                                public string AppUuid { get; set; }

                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// </summary>
                                [NameInMap("bizType")]
                                [Validation(Required=false)]
                                public string BizType { get; set; }

                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// </summary>
                                [NameInMap("formCode")]
                                [Validation(Required=false)]
                                public string FormCode { get; set; }

                            }

                            /// <summary>
                            /// <para>This parameter is required.</para>
                            /// </summary>
                            [NameInMap("type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                        }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>标签字段 颜色属性，格式：#0089FF</para>
                        /// </summary>
                        [NameInMap("defaultColor")]
                        [Validation(Required=false)]
                        public string DefaultColor { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("disabled")]
                        [Validation(Required=false)]
                        public bool? Disabled { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("duration")]
                        [Validation(Required=false)]
                        public bool? Duration { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("durationLabel")]
                        [Validation(Required=false)]
                        public string DurationLabel { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("fieldId")]
                        [Validation(Required=false)]
                        public string FieldId { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("fields")]
                        [Validation(Required=false)]
                        public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFields> Fields { get; set; }
                        public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFields : TeaModel {
                            /// <summary>
                            /// <para>This parameter is required.</para>
                            /// </summary>
                            [NameInMap("componentName")]
                            [Validation(Required=false)]
                            public string ComponentName { get; set; }

                            /// <summary>
                            /// <para>This parameter is required.</para>
                            /// </summary>
                            [NameInMap("relateProps")]
                            [Validation(Required=false)]
                            public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps RelateProps { get; set; }
                            public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps : TeaModel {
                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// </summary>
                                [NameInMap("align")]
                                [Validation(Required=false)]
                                public string Align { get; set; }

                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// </summary>
                                [NameInMap("bizAlias")]
                                [Validation(Required=false)]
                                public string BizAlias { get; set; }

                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// </summary>
                                [NameInMap("choice")]
                                [Validation(Required=false)]
                                public long? Choice { get; set; }

                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// </summary>
                                [NameInMap("content")]
                                [Validation(Required=false)]
                                public string Content { get; set; }

                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// </summary>
                                [NameInMap("disabled")]
                                [Validation(Required=false)]
                                public bool? Disabled { get; set; }

                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// </summary>
                                [NameInMap("duration")]
                                [Validation(Required=false)]
                                public bool? Duration { get; set; }

                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// </summary>
                                [NameInMap("durationLabel")]
                                [Validation(Required=false)]
                                public string DurationLabel { get; set; }

                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// </summary>
                                [NameInMap("fieldId")]
                                [Validation(Required=false)]
                                public string FieldId { get; set; }

                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// </summary>
                                [NameInMap("format")]
                                [Validation(Required=false)]
                                public string Format { get; set; }

                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// </summary>
                                [NameInMap("formula")]
                                [Validation(Required=false)]
                                public string Formula { get; set; }

                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// </summary>
                                [NameInMap("invisible")]
                                [Validation(Required=false)]
                                public bool? Invisible { get; set; }

                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// </summary>
                                [NameInMap("label")]
                                [Validation(Required=false)]
                                public string Label { get; set; }

                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// </summary>
                                [NameInMap("labelEditableFreeze")]
                                [Validation(Required=false)]
                                public bool? LabelEditableFreeze { get; set; }

                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// </summary>
                                [NameInMap("limit")]
                                [Validation(Required=false)]
                                public long? Limit { get; set; }

                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// </summary>
                                [NameInMap("link")]
                                [Validation(Required=false)]
                                public string Link { get; set; }

                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// </summary>
                                [NameInMap("mode")]
                                [Validation(Required=false)]
                                public string Mode { get; set; }

                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// </summary>
                                [NameInMap("notUpper")]
                                [Validation(Required=false)]
                                public string NotUpper { get; set; }

                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// </summary>
                                [NameInMap("options")]
                                [Validation(Required=false)]
                                public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsOptions> Options { get; set; }
                                public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsOptions : TeaModel {
                                    /// <summary>
                                    /// <para>This parameter is required.</para>
                                    /// </summary>
                                    [NameInMap("extension")]
                                    [Validation(Required=false)]
                                    public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsOptionsExtension Extension { get; set; }
                                    public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsOptionsExtension : TeaModel {
                                        /// <summary>
                                        /// <para>This parameter is required.</para>
                                        /// </summary>
                                        [NameInMap("editFreeze")]
                                        [Validation(Required=false)]
                                        public bool? EditFreeze { get; set; }

                                    }

                                    /// <summary>
                                    /// <para>This parameter is required.</para>
                                    /// </summary>
                                    [NameInMap("key")]
                                    [Validation(Required=false)]
                                    public string Key { get; set; }

                                    /// <summary>
                                    /// <para>This parameter is required.</para>
                                    /// </summary>
                                    [NameInMap("value")]
                                    [Validation(Required=false)]
                                    public string Value { get; set; }

                                }

                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// </summary>
                                [NameInMap("payEnable")]
                                [Validation(Required=false)]
                                public bool? PayEnable { get; set; }

                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// </summary>
                                [NameInMap("placeholder")]
                                [Validation(Required=false)]
                                public string Placeholder { get; set; }

                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// </summary>
                                [NameInMap("ratio")]
                                [Validation(Required=false)]
                                public long? Ratio { get; set; }

                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// </summary>
                                [NameInMap("required")]
                                [Validation(Required=false)]
                                public bool? Required { get; set; }

                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// </summary>
                                [NameInMap("requiredEditableFreeze")]
                                [Validation(Required=false)]
                                public bool? RequiredEditableFreeze { get; set; }

                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// </summary>
                                [NameInMap("spread")]
                                [Validation(Required=false)]
                                public bool? Spread { get; set; }

                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// </summary>
                                [NameInMap("statField")]
                                [Validation(Required=false)]
                                public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsStatField> StatField { get; set; }
                                public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsStatField : TeaModel {
                                    /// <summary>
                                    /// <para>This parameter is required.</para>
                                    /// </summary>
                                    [NameInMap("fieldId")]
                                    [Validation(Required=false)]
                                    public string FieldId { get; set; }

                                    /// <summary>
                                    /// <para>This parameter is required.</para>
                                    /// </summary>
                                    [NameInMap("label")]
                                    [Validation(Required=false)]
                                    public string Label { get; set; }

                                    /// <summary>
                                    /// <para>This parameter is required.</para>
                                    /// </summary>
                                    [NameInMap("unit")]
                                    [Validation(Required=false)]
                                    public string Unit { get; set; }

                                    /// <summary>
                                    /// <para>This parameter is required.</para>
                                    /// </summary>
                                    [NameInMap("upper")]
                                    [Validation(Required=false)]
                                    public bool? Upper { get; set; }

                                }

                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// </summary>
                                [NameInMap("unit")]
                                [Validation(Required=false)]
                                public string Unit { get; set; }

                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// </summary>
                                [NameInMap("verticalPrint")]
                                [Validation(Required=false)]
                                public bool? VerticalPrint { get; set; }

                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// </summary>
                                [NameInMap("watermark")]
                                [Validation(Required=false)]
                                public bool? Watermark { get; set; }

                            }

                        }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("format")]
                        [Validation(Required=false)]
                        public string Format { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("formula")]
                        [Validation(Required=false)]
                        public string Formula { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("invisible")]
                        [Validation(Required=false)]
                        public bool? Invisible { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("labelEditableFreeze")]
                        [Validation(Required=false)]
                        public bool? LabelEditableFreeze { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("limit")]
                        [Validation(Required=false)]
                        public long? Limit { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("link")]
                        [Validation(Required=false)]
                        public string Link { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("mode")]
                        [Validation(Required=false)]
                        public string Mode { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true：支持多选，false：单选</para>
                        /// </summary>
                        [NameInMap("multiple")]
                        [Validation(Required=false)]
                        public bool? Multiple { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("notPrint")]
                        [Validation(Required=false)]
                        public string NotPrint { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("notUpper")]
                        [Validation(Required=false)]
                        public string NotUpper { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("options")]
                        [Validation(Required=false)]
                        public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsOptions> Options { get; set; }
                        public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsOptions : TeaModel {
                            /// <summary>
                            /// <para>This parameter is required.</para>
                            /// </summary>
                            [NameInMap("extension")]
                            [Validation(Required=false)]
                            public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsOptionsExtension Extension { get; set; }
                            public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsOptionsExtension : TeaModel {
                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// </summary>
                                [NameInMap("editFreeze")]
                                [Validation(Required=false)]
                                public bool? EditFreeze { get; set; }

                            }

                            /// <summary>
                            /// <para>This parameter is required.</para>
                            /// </summary>
                            [NameInMap("key")]
                            [Validation(Required=false)]
                            public string Key { get; set; }

                            /// <summary>
                            /// <para>This parameter is required.</para>
                            /// </summary>
                            [NameInMap("value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("payEnable")]
                        [Validation(Required=false)]
                        public bool? PayEnable { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("placeholder")]
                        [Validation(Required=false)]
                        public string Placeholder { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("quote")]
                        [Validation(Required=false)]
                        public long? Quote { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("ratio")]
                        [Validation(Required=false)]
                        public long? Ratio { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("relateSource")]
                        [Validation(Required=false)]
                        public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSource> RelateSource { get; set; }
                        public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSource : TeaModel {
                            /// <summary>
                            /// <para>This parameter is required.</para>
                            /// </summary>
                            [NameInMap("bizType")]
                            [Validation(Required=false)]
                            public string BizType { get; set; }

                            [NameInMap("dataSource")]
                            [Validation(Required=false)]
                            public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSource DataSource { get; set; }
                            public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSource : TeaModel {
                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// </summary>
                                [NameInMap("params")]
                                [Validation(Required=false)]
                                public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceParams Params { get; set; }
                                public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceParams : TeaModel {
                                    /// <summary>
                                    /// <para>This parameter is required.</para>
                                    /// </summary>
                                    [NameInMap("filters")]
                                    [Validation(Required=false)]
                                    public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceParamsFilters> Filters { get; set; }
                                    public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceParamsFilters : TeaModel {
                                        /// <summary>
                                        /// <para>This parameter is required.</para>
                                        /// </summary>
                                        [NameInMap("fieldId")]
                                        [Validation(Required=false)]
                                        public string FieldId { get; set; }

                                        /// <summary>
                                        /// <para>This parameter is required.</para>
                                        /// </summary>
                                        [NameInMap("filterType")]
                                        [Validation(Required=false)]
                                        public string FilterType { get; set; }

                                        /// <summary>
                                        /// <para>This parameter is required.</para>
                                        /// </summary>
                                        [NameInMap("value")]
                                        [Validation(Required=false)]
                                        public string Value { get; set; }

                                        /// <summary>
                                        /// <para>This parameter is required.</para>
                                        /// </summary>
                                        [NameInMap("valueType")]
                                        [Validation(Required=false)]
                                        public string ValueType { get; set; }

                                    }

                                }

                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// </summary>
                                [NameInMap("target")]
                                [Validation(Required=false)]
                                public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceTarget Target { get; set; }
                                public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceTarget : TeaModel {
                                    /// <summary>
                                    /// <para>This parameter is required.</para>
                                    /// </summary>
                                    [NameInMap("appType")]
                                    [Validation(Required=false)]
                                    public long? AppType { get; set; }

                                    /// <summary>
                                    /// <para>This parameter is required.</para>
                                    /// </summary>
                                    [NameInMap("appUuid")]
                                    [Validation(Required=false)]
                                    public string AppUuid { get; set; }

                                    /// <summary>
                                    /// <para>This parameter is required.</para>
                                    /// </summary>
                                    [NameInMap("bizType")]
                                    [Validation(Required=false)]
                                    public string BizType { get; set; }

                                    /// <summary>
                                    /// <para>This parameter is required.</para>
                                    /// </summary>
                                    [NameInMap("formCode")]
                                    [Validation(Required=false)]
                                    public string FormCode { get; set; }

                                }

                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// </summary>
                                [NameInMap("type")]
                                [Validation(Required=false)]
                                public string Type { get; set; }

                            }

                            /// <summary>
                            /// <para>This parameter is required.</para>
                            /// </summary>
                            [NameInMap("fields")]
                            [Validation(Required=false)]
                            public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFields> Fields { get; set; }
                            public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFields : TeaModel {
                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// </summary>
                                [NameInMap("componentName")]
                                [Validation(Required=false)]
                                public string ComponentName { get; set; }

                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// </summary>
                                [NameInMap("relateProps")]
                                [Validation(Required=false)]
                                public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelateProps RelateProps { get; set; }
                                public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelateProps : TeaModel {
                                    /// <summary>
                                    /// <para>This parameter is required.</para>
                                    /// </summary>
                                    [NameInMap("align")]
                                    [Validation(Required=false)]
                                    public string Align { get; set; }

                                    /// <summary>
                                    /// <para>This parameter is required.</para>
                                    /// </summary>
                                    [NameInMap("bizAlias")]
                                    [Validation(Required=false)]
                                    public string BizAlias { get; set; }

                                    /// <summary>
                                    /// <para>This parameter is required.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>1：多选，0：单选</para>
                                    /// </summary>
                                    [NameInMap("choice")]
                                    [Validation(Required=false)]
                                    public long? Choice { get; set; }

                                    /// <summary>
                                    /// <para>This parameter is required.</para>
                                    /// </summary>
                                    [NameInMap("content")]
                                    [Validation(Required=false)]
                                    public string Content { get; set; }

                                    /// <summary>
                                    /// <para>This parameter is required.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>true：可编辑</para>
                                    /// </summary>
                                    [NameInMap("disabled")]
                                    [Validation(Required=false)]
                                    public bool? Disabled { get; set; }

                                    /// <summary>
                                    /// <para>This parameter is required.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>true：自动</para>
                                    /// </summary>
                                    [NameInMap("duration")]
                                    [Validation(Required=false)]
                                    public string Duration { get; set; }

                                    /// <summary>
                                    /// <para>This parameter is required.</para>
                                    /// </summary>
                                    [NameInMap("fieldId")]
                                    [Validation(Required=false)]
                                    public string FieldId { get; set; }

                                    /// <summary>
                                    /// <para>This parameter is required.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>DDDateField和DDDateRangeField</para>
                                    /// </summary>
                                    [NameInMap("format")]
                                    [Validation(Required=false)]
                                    public string Format { get; set; }

                                    /// <summary>
                                    /// <para>This parameter is required.</para>
                                    /// </summary>
                                    [NameInMap("formula")]
                                    [Validation(Required=false)]
                                    public string Formula { get; set; }

                                    /// <summary>
                                    /// <para>This parameter is required.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>true：隐藏</para>
                                    /// </summary>
                                    [NameInMap("invisible")]
                                    [Validation(Required=false)]
                                    public bool? Invisible { get; set; }

                                    /// <summary>
                                    /// <para>This parameter is required.</para>
                                    /// </summary>
                                    [NameInMap("label")]
                                    [Validation(Required=false)]
                                    public string Label { get; set; }

                                    /// <summary>
                                    /// <para>This parameter is required.</para>
                                    /// </summary>
                                    [NameInMap("labelEditableFreeze")]
                                    [Validation(Required=false)]
                                    public bool? LabelEditableFreeze { get; set; }

                                    /// <summary>
                                    /// <para>This parameter is required.</para>
                                    /// </summary>
                                    [NameInMap("link")]
                                    [Validation(Required=false)]
                                    public string Link { get; set; }

                                    /// <summary>
                                    /// <para>This parameter is required.</para>
                                    /// </summary>
                                    [NameInMap("multi")]
                                    [Validation(Required=false)]
                                    public long? Multi { get; set; }

                                    /// <summary>
                                    /// <para>This parameter is required.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>1:不需要大写, 空或者0:需要大写</para>
                                    /// </summary>
                                    [NameInMap("notUpper")]
                                    [Validation(Required=false)]
                                    public string NotUpper { get; set; }

                                    /// <summary>
                                    /// <para>This parameter is required.</para>
                                    /// </summary>
                                    [NameInMap("options")]
                                    [Validation(Required=false)]
                                    public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsOptions> Options { get; set; }
                                    public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsOptions : TeaModel {
                                        /// <summary>
                                        /// <para>This parameter is required.</para>
                                        /// </summary>
                                        [NameInMap("key")]
                                        [Validation(Required=false)]
                                        public string Key { get; set; }

                                        /// <summary>
                                        /// <para>This parameter is required.</para>
                                        /// </summary>
                                        [NameInMap("value")]
                                        [Validation(Required=false)]
                                        public string Value { get; set; }

                                    }

                                    /// <summary>
                                    /// <para>This parameter is required.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>true：是</para>
                                    /// </summary>
                                    [NameInMap("payEnable")]
                                    [Validation(Required=false)]
                                    public bool? PayEnable { get; set; }

                                    /// <summary>
                                    /// <para>This parameter is required.</para>
                                    /// </summary>
                                    [NameInMap("placeholder")]
                                    [Validation(Required=false)]
                                    public string Placeholder { get; set; }

                                    /// <summary>
                                    /// <para>This parameter is required.</para>
                                    /// </summary>
                                    [NameInMap("quote")]
                                    [Validation(Required=false)]
                                    public long? Quote { get; set; }

                                    /// <summary>
                                    /// <para>This parameter is required.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>true：必填</para>
                                    /// </summary>
                                    [NameInMap("required")]
                                    [Validation(Required=false)]
                                    public bool? Required { get; set; }

                                    /// <summary>
                                    /// <para>This parameter is required.</para>
                                    /// </summary>
                                    [NameInMap("requiredEditableFreeze")]
                                    [Validation(Required=false)]
                                    public bool? RequiredEditableFreeze { get; set; }

                                    /// <summary>
                                    /// <para>This parameter is required.</para>
                                    /// </summary>
                                    [NameInMap("statField")]
                                    [Validation(Required=false)]
                                    public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsStatField> StatField { get; set; }
                                    public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsStatField : TeaModel {
                                        /// <summary>
                                        /// <para>This parameter is required.</para>
                                        /// </summary>
                                        [NameInMap("fieldId")]
                                        [Validation(Required=false)]
                                        public string FieldId { get; set; }

                                        /// <summary>
                                        /// <para>This parameter is required.</para>
                                        /// </summary>
                                        [NameInMap("label")]
                                        [Validation(Required=false)]
                                        public string Label { get; set; }

                                        /// <summary>
                                        /// <para>This parameter is required.</para>
                                        /// </summary>
                                        [NameInMap("unit")]
                                        [Validation(Required=false)]
                                        public string Unit { get; set; }

                                        /// <summary>
                                        /// <para>This parameter is required.</para>
                                        /// </summary>
                                        [NameInMap("upper")]
                                        [Validation(Required=false)]
                                        public bool? Upper { get; set; }

                                    }

                                    /// <summary>
                                    /// <para>This parameter is required.</para>
                                    /// </summary>
                                    [NameInMap("unit")]
                                    [Validation(Required=false)]
                                    public string Unit { get; set; }

                                    /// <summary>
                                    /// <para>This parameter is required.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>true：纵向，false：横向</para>
                                    /// </summary>
                                    [NameInMap("verticalPrint")]
                                    [Validation(Required=false)]
                                    public bool? VerticalPrint { get; set; }

                                }

                            }

                        }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("required")]
                        [Validation(Required=false)]
                        public bool? Required { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("requiredEditableFreeze")]
                        [Validation(Required=false)]
                        public bool? RequiredEditableFreeze { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("rule")]
                        [Validation(Required=false)]
                        public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRule> Rule { get; set; }
                        public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRule : TeaModel {
                            /// <summary>
                            /// <para>This parameter is required.</para>
                            /// </summary>
                            [NameInMap("type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                            /// <summary>
                            /// <para>This parameter is required.</para>
                            /// </summary>
                            [NameInMap("value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("sortable")]
                        [Validation(Required=false)]
                        public bool? Sortable { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("spread")]
                        [Validation(Required=false)]
                        public bool? Spread { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("statField")]
                        [Validation(Required=false)]
                        public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsStatField> StatField { get; set; }
                        public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsStatField : TeaModel {
                            /// <summary>
                            /// <para>This parameter is required.</para>
                            /// </summary>
                            [NameInMap("fieldId")]
                            [Validation(Required=false)]
                            public string FieldId { get; set; }

                            /// <summary>
                            /// <para>This parameter is required.</para>
                            /// </summary>
                            [NameInMap("label")]
                            [Validation(Required=false)]
                            public string Label { get; set; }

                            /// <summary>
                            /// <para>This parameter is required.</para>
                            /// </summary>
                            [NameInMap("unit")]
                            [Validation(Required=false)]
                            public string Unit { get; set; }

                            /// <summary>
                            /// <para>This parameter is required.</para>
                            /// </summary>
                            [NameInMap("upper")]
                            [Validation(Required=false)]
                            public bool? Upper { get; set; }

                        }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("tableViewMode")]
                        [Validation(Required=false)]
                        public string TableViewMode { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("unit")]
                        [Validation(Required=false)]
                        public string Unit { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("verticalPrint")]
                        [Validation(Required=false)]
                        public bool? VerticalPrint { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("watermark")]
                        [Validation(Required=false)]
                        public bool? Watermark { get; set; }

                    }

                }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("componentName")]
                [Validation(Required=false)]
                public string ComponentName { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("props")]
                [Validation(Required=false)]
                public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps Props { get; set; }
                public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps : TeaModel {
                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>明细动作名称</para>
                    /// </summary>
                    [NameInMap("actionName")]
                    [Validation(Required=false)]
                    public string ActionName { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>top|middle|bottom</para>
                    /// </summary>
                    [NameInMap("align")]
                    [Validation(Required=false)]
                    public string Align { get; set; }

                    [NameInMap("availableTemplates")]
                    [Validation(Required=false)]
                    public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsAvailableTemplates> AvailableTemplates { get; set; }
                    public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsAvailableTemplates : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>审批模板id</para>
                        /// </summary>
                        [NameInMap("id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>审批模板名称</para>
                        /// </summary>
                        [NameInMap("name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                    [NameInMap("behaviorLinkage")]
                    [Validation(Required=false)]
                    public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsBehaviorLinkage> BehaviorLinkage { get; set; }
                    public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsBehaviorLinkage : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>option_0</para>
                        /// </summary>
                        [NameInMap("optionKey")]
                        [Validation(Required=false)]
                        public string OptionKey { get; set; }

                        [NameInMap("targets")]
                        [Validation(Required=false)]
                        public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsBehaviorLinkageTargets> Targets { get; set; }
                        public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsBehaviorLinkageTargets : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>NORMAL</para>
                            /// </summary>
                            [NameInMap("behavior")]
                            [Validation(Required=false)]
                            public string Behavior { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>TextField_1LTIYOR4XIF40</para>
                            /// </summary>
                            [NameInMap("fieldId")]
                            [Validation(Required=false)]
                            public string FieldId { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("bizAlias")]
                    [Validation(Required=false)]
                    public string BizAlias { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1：多选，0：单选</para>
                    /// </summary>
                    [NameInMap("choice")]
                    [Validation(Required=false)]
                    public long? Choice { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    [NameInMap("dataSource")]
                    [Validation(Required=false)]
                    public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSource DataSource { get; set; }
                    public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSource : TeaModel {
                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("params")]
                        [Validation(Required=false)]
                        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceParams Params { get; set; }
                        public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceParams : TeaModel {
                            /// <summary>
                            /// <para>This parameter is required.</para>
                            /// </summary>
                            [NameInMap("filters")]
                            [Validation(Required=false)]
                            public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceParamsFilters> Filters { get; set; }
                            public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceParamsFilters : TeaModel {
                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// </summary>
                                [NameInMap("fieldId")]
                                [Validation(Required=false)]
                                public string FieldId { get; set; }

                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// </summary>
                                [NameInMap("filterType")]
                                [Validation(Required=false)]
                                public string FilterType { get; set; }

                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// </summary>
                                [NameInMap("value")]
                                [Validation(Required=false)]
                                public string Value { get; set; }

                                /// <summary>
                                /// <para>This parameter is required.</para>
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
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>0：流程表单，1：纯表单</para>
                            /// </summary>
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

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>标签字段 颜色属性，格式：#0089FF</para>
                    /// </summary>
                    [NameInMap("defaultColor")]
                    [Validation(Required=false)]
                    public string DefaultColor { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true：可编辑</para>
                    /// </summary>
                    [NameInMap("disabled")]
                    [Validation(Required=false)]
                    public bool? Disabled { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true：自动</para>
                    /// </summary>
                    [NameInMap("duration")]
                    [Validation(Required=false)]
                    public bool? Duration { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>日期区间控件，自动计算时长的标题</para>
                    /// </summary>
                    [NameInMap("durationLabel")]
                    [Validation(Required=false)]
                    public string DurationLabel { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("fieldId")]
                    [Validation(Required=false)]
                    public string FieldId { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("fields")]
                    [Validation(Required=false)]
                    public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFields> Fields { get; set; }
                    public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFields : TeaModel {
                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("componentName")]
                        [Validation(Required=false)]
                        public string ComponentName { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("relateProps")]
                        [Validation(Required=false)]
                        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps RelateProps { get; set; }
                        public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps : TeaModel {
                            /// <summary>
                            /// <para>This parameter is required.</para>
                            /// </summary>
                            [NameInMap("align")]
                            [Validation(Required=false)]
                            public string Align { get; set; }

                            /// <summary>
                            /// <para>This parameter is required.</para>
                            /// </summary>
                            [NameInMap("bizAlias")]
                            [Validation(Required=false)]
                            public string BizAlias { get; set; }

                            /// <summary>
                            /// <para>This parameter is required.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1：多选，0：单选</para>
                            /// </summary>
                            [NameInMap("choice")]
                            [Validation(Required=false)]
                            public long? Choice { get; set; }

                            /// <summary>
                            /// <para>This parameter is required.</para>
                            /// </summary>
                            [NameInMap("content")]
                            [Validation(Required=false)]
                            public string Content { get; set; }

                            /// <summary>
                            /// <para>This parameter is required.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>true：可编辑</para>
                            /// </summary>
                            [NameInMap("disabled")]
                            [Validation(Required=false)]
                            public bool? Disabled { get; set; }

                            /// <summary>
                            /// <para>This parameter is required.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>true：自动</para>
                            /// </summary>
                            [NameInMap("duration")]
                            [Validation(Required=false)]
                            public string Duration { get; set; }

                            /// <summary>
                            /// <para>This parameter is required.</para>
                            /// </summary>
                            [NameInMap("durationLabel")]
                            [Validation(Required=false)]
                            public string DurationLabel { get; set; }

                            /// <summary>
                            /// <para>This parameter is required.</para>
                            /// </summary>
                            [NameInMap("fieldId")]
                            [Validation(Required=false)]
                            public string FieldId { get; set; }

                            /// <summary>
                            /// <para>This parameter is required.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>DDDateField和DDDateRangeField</para>
                            /// </summary>
                            [NameInMap("format")]
                            [Validation(Required=false)]
                            public string Format { get; set; }

                            /// <summary>
                            /// <para>This parameter is required.</para>
                            /// </summary>
                            [NameInMap("formula")]
                            [Validation(Required=false)]
                            public string Formula { get; set; }

                            /// <summary>
                            /// <para>This parameter is required.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>true：隐藏</para>
                            /// </summary>
                            [NameInMap("invisible")]
                            [Validation(Required=false)]
                            public bool? Invisible { get; set; }

                            /// <summary>
                            /// <para>This parameter is required.</para>
                            /// </summary>
                            [NameInMap("label")]
                            [Validation(Required=false)]
                            public string Label { get; set; }

                            /// <summary>
                            /// <para>This parameter is required.</para>
                            /// </summary>
                            [NameInMap("labelEditableFreeze")]
                            [Validation(Required=false)]
                            public bool? LabelEditableFreeze { get; set; }

                            /// <summary>
                            /// <para>This parameter is required.</para>
                            /// </summary>
                            [NameInMap("limit")]
                            [Validation(Required=false)]
                            public long? Limit { get; set; }

                            /// <summary>
                            /// <para>This parameter is required.</para>
                            /// </summary>
                            [NameInMap("link")]
                            [Validation(Required=false)]
                            public string Link { get; set; }

                            /// <summary>
                            /// <para>This parameter is required.</para>
                            /// </summary>
                            [NameInMap("mode")]
                            [Validation(Required=false)]
                            public string Mode { get; set; }

                            /// <summary>
                            /// <para>This parameter is required.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1:不需要大写, 空或者0:需要大写</para>
                            /// </summary>
                            [NameInMap("notUpper")]
                            [Validation(Required=false)]
                            public string NotUpper { get; set; }

                            /// <summary>
                            /// <para>This parameter is required.</para>
                            /// </summary>
                            [NameInMap("options")]
                            [Validation(Required=false)]
                            public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsOptions> Options { get; set; }
                            public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsOptions : TeaModel {
                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// </summary>
                                [NameInMap("extension")]
                                [Validation(Required=false)]
                                public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsOptionsExtension Extension { get; set; }
                                public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsOptionsExtension : TeaModel {
                                    /// <summary>
                                    /// <para>This parameter is required.</para>
                                    /// </summary>
                                    [NameInMap("editFreeze")]
                                    [Validation(Required=false)]
                                    public bool? EditFreeze { get; set; }

                                }

                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// </summary>
                                [NameInMap("key")]
                                [Validation(Required=false)]
                                public string Key { get; set; }

                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// </summary>
                                [NameInMap("value")]
                                [Validation(Required=false)]
                                public string Value { get; set; }

                            }

                            /// <summary>
                            /// <para>This parameter is required.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>true：是</para>
                            /// </summary>
                            [NameInMap("payEnable")]
                            [Validation(Required=false)]
                            public bool? PayEnable { get; set; }

                            /// <summary>
                            /// <para>This parameter is required.</para>
                            /// </summary>
                            [NameInMap("placeholder")]
                            [Validation(Required=false)]
                            public string Placeholder { get; set; }

                            /// <summary>
                            /// <para>This parameter is required.</para>
                            /// </summary>
                            [NameInMap("ratio")]
                            [Validation(Required=false)]
                            public long? Ratio { get; set; }

                            /// <summary>
                            /// <para>This parameter is required.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>true：必填</para>
                            /// </summary>
                            [NameInMap("required")]
                            [Validation(Required=false)]
                            public bool? Required { get; set; }

                            /// <summary>
                            /// <para>This parameter is required.</para>
                            /// </summary>
                            [NameInMap("requiredEditableFreeze")]
                            [Validation(Required=false)]
                            public bool? RequiredEditableFreeze { get; set; }

                            /// <summary>
                            /// <para>This parameter is required.</para>
                            /// </summary>
                            [NameInMap("spread")]
                            [Validation(Required=false)]
                            public bool? Spread { get; set; }

                            /// <summary>
                            /// <para>This parameter is required.</para>
                            /// </summary>
                            [NameInMap("statField")]
                            [Validation(Required=false)]
                            public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsStatField> StatField { get; set; }
                            public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsStatField : TeaModel {
                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// </summary>
                                [NameInMap("fieldId")]
                                [Validation(Required=false)]
                                public string FieldId { get; set; }

                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// </summary>
                                [NameInMap("label")]
                                [Validation(Required=false)]
                                public string Label { get; set; }

                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// </summary>
                                [NameInMap("unit")]
                                [Validation(Required=false)]
                                public string Unit { get; set; }

                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// </summary>
                                [NameInMap("upper")]
                                [Validation(Required=false)]
                                public bool? Upper { get; set; }

                            }

                            /// <summary>
                            /// <para>This parameter is required.</para>
                            /// </summary>
                            [NameInMap("unit")]
                            [Validation(Required=false)]
                            public string Unit { get; set; }

                            /// <summary>
                            /// <para>This parameter is required.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>true：纵向，false：横向</para>
                            /// </summary>
                            [NameInMap("verticalPrint")]
                            [Validation(Required=false)]
                            public bool? VerticalPrint { get; set; }

                            /// <summary>
                            /// <para>This parameter is required.</para>
                            /// </summary>
                            [NameInMap("watermark")]
                            [Validation(Required=false)]
                            public bool? Watermark { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>DDDateField和DDDateRangeField</para>
                    /// </summary>
                    [NameInMap("format")]
                    [Validation(Required=false)]
                    public string Format { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("formula")]
                    [Validation(Required=false)]
                    public string Formula { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true：隐藏</para>
                    /// </summary>
                    [NameInMap("invisible")]
                    [Validation(Required=false)]
                    public bool? Invisible { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true：不可修改</para>
                    /// </summary>
                    [NameInMap("labelEditableFreeze")]
                    [Validation(Required=false)]
                    public bool? LabelEditableFreeze { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>评分组件限制</para>
                    /// </summary>
                    [NameInMap("limit")]
                    [Validation(Required=false)]
                    public long? Limit { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("link")]
                    [Validation(Required=false)]
                    public string Link { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>电话控件模式 phone：仅手机，phone_tel： 手机和固话，tel：仅固话</para>
                    /// </summary>
                    [NameInMap("mode")]
                    [Validation(Required=false)]
                    public string Mode { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("multi")]
                    [Validation(Required=false)]
                    public long? Multi { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true：支持多选，false：单选</para>
                    /// </summary>
                    [NameInMap("multiple")]
                    [Validation(Required=false)]
                    public bool? Multiple { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("needDetail")]
                    [Validation(Required=false)]
                    public string NeedDetail { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1：不打印，0：打印</para>
                    /// </summary>
                    [NameInMap("notPrint")]
                    [Validation(Required=false)]
                    public string NotPrint { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1:不需要大写, 空或者0:需要大写</para>
                    /// </summary>
                    [NameInMap("notUpper")]
                    [Validation(Required=false)]
                    public string NotUpper { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("options")]
                    [Validation(Required=false)]
                    public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsOptions> Options { get; set; }
                    public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsOptions : TeaModel {
                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("extension")]
                        [Validation(Required=false)]
                        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsOptionsExtension Extension { get; set; }
                        public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsOptionsExtension : TeaModel {
                            /// <summary>
                            /// <para>This parameter is required.</para>
                            /// </summary>
                            [NameInMap("editFreeze")]
                            [Validation(Required=false)]
                            public bool? EditFreeze { get; set; }

                        }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("warn")]
                        [Validation(Required=false)]
                        public bool? Warn { get; set; }

                    }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true：是</para>
                    /// </summary>
                    [NameInMap("payEnable")]
                    [Validation(Required=false)]
                    public bool? PayEnable { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("placeholder")]
                    [Validation(Required=false)]
                    public string Placeholder { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>关联表单 1：引用，0：拷贝</para>
                    /// </summary>
                    [NameInMap("quote")]
                    [Validation(Required=false)]
                    public long? Quote { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>文本控件、选项控件等限制文本字数ratio</para>
                    /// </summary>
                    [NameInMap("ratio")]
                    [Validation(Required=false)]
                    public long? Ratio { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("relateSource")]
                    [Validation(Required=false)]
                    public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSource> RelateSource { get; set; }
                    public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSource : TeaModel {
                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("bizType")]
                        [Validation(Required=false)]
                        public string BizType { get; set; }

                        [NameInMap("dataSource")]
                        [Validation(Required=false)]
                        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSource DataSource { get; set; }
                        public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSource : TeaModel {
                            /// <summary>
                            /// <para>This parameter is required.</para>
                            /// </summary>
                            [NameInMap("params")]
                            [Validation(Required=false)]
                            public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceParams Params { get; set; }
                            public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceParams : TeaModel {
                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// </summary>
                                [NameInMap("filters")]
                                [Validation(Required=false)]
                                public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceParamsFilters> Filters { get; set; }
                                public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceParamsFilters : TeaModel {
                                    /// <summary>
                                    /// <para>This parameter is required.</para>
                                    /// </summary>
                                    [NameInMap("fieldId")]
                                    [Validation(Required=false)]
                                    public string FieldId { get; set; }

                                    /// <summary>
                                    /// <para>This parameter is required.</para>
                                    /// </summary>
                                    [NameInMap("filterType")]
                                    [Validation(Required=false)]
                                    public string FilterType { get; set; }

                                    /// <summary>
                                    /// <para>This parameter is required.</para>
                                    /// </summary>
                                    [NameInMap("value")]
                                    [Validation(Required=false)]
                                    public string Value { get; set; }

                                    /// <summary>
                                    /// <para>This parameter is required.</para>
                                    /// </summary>
                                    [NameInMap("valueType")]
                                    [Validation(Required=false)]
                                    public string ValueType { get; set; }

                                }

                            }

                            /// <summary>
                            /// <para>This parameter is required.</para>
                            /// </summary>
                            [NameInMap("target")]
                            [Validation(Required=false)]
                            public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceTarget Target { get; set; }
                            public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceTarget : TeaModel {
                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// </summary>
                                [NameInMap("appType")]
                                [Validation(Required=false)]
                                public long? AppType { get; set; }

                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// </summary>
                                [NameInMap("appUuid")]
                                [Validation(Required=false)]
                                public string AppUuid { get; set; }

                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// </summary>
                                [NameInMap("bizType")]
                                [Validation(Required=false)]
                                public string BizType { get; set; }

                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// </summary>
                                [NameInMap("formCode")]
                                [Validation(Required=false)]
                                public string FormCode { get; set; }

                            }

                            /// <summary>
                            /// <para>This parameter is required.</para>
                            /// </summary>
                            [NameInMap("type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                        }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("fields")]
                        [Validation(Required=false)]
                        public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFields> Fields { get; set; }
                        public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFields : TeaModel {
                            /// <summary>
                            /// <para>This parameter is required.</para>
                            /// </summary>
                            [NameInMap("componentName")]
                            [Validation(Required=false)]
                            public string ComponentName { get; set; }

                            /// <summary>
                            /// <para>This parameter is required.</para>
                            /// </summary>
                            [NameInMap("relateProps")]
                            [Validation(Required=false)]
                            public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelateProps RelateProps { get; set; }
                            public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelateProps : TeaModel {
                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// </summary>
                                [NameInMap("align")]
                                [Validation(Required=false)]
                                public string Align { get; set; }

                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// </summary>
                                [NameInMap("bizAlias")]
                                [Validation(Required=false)]
                                public string BizAlias { get; set; }

                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>1：多选，0：单选</para>
                                /// </summary>
                                [NameInMap("choice")]
                                [Validation(Required=false)]
                                public long? Choice { get; set; }

                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// </summary>
                                [NameInMap("content")]
                                [Validation(Required=false)]
                                public string Content { get; set; }

                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>true：可编辑</para>
                                /// </summary>
                                [NameInMap("disabled")]
                                [Validation(Required=false)]
                                public bool? Disabled { get; set; }

                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>true：自动</para>
                                /// </summary>
                                [NameInMap("duration")]
                                [Validation(Required=false)]
                                public string Duration { get; set; }

                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// </summary>
                                [NameInMap("fieldId")]
                                [Validation(Required=false)]
                                public string FieldId { get; set; }

                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>DDDateField和DDDateRangeField</para>
                                /// </summary>
                                [NameInMap("format")]
                                [Validation(Required=false)]
                                public string Format { get; set; }

                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// </summary>
                                [NameInMap("formula")]
                                [Validation(Required=false)]
                                public string Formula { get; set; }

                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>true：隐藏</para>
                                /// </summary>
                                [NameInMap("invisible")]
                                [Validation(Required=false)]
                                public bool? Invisible { get; set; }

                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// </summary>
                                [NameInMap("label")]
                                [Validation(Required=false)]
                                public string Label { get; set; }

                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// </summary>
                                [NameInMap("labelEditableFreeze")]
                                [Validation(Required=false)]
                                public bool? LabelEditableFreeze { get; set; }

                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// </summary>
                                [NameInMap("link")]
                                [Validation(Required=false)]
                                public string Link { get; set; }

                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// </summary>
                                [NameInMap("multi")]
                                [Validation(Required=false)]
                                public long? Multi { get; set; }

                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>1:不需要大写, 空或者0:需要大写</para>
                                /// </summary>
                                [NameInMap("notUpper")]
                                [Validation(Required=false)]
                                public string NotUpper { get; set; }

                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// </summary>
                                [NameInMap("options")]
                                [Validation(Required=false)]
                                public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsOptions> Options { get; set; }
                                public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsOptions : TeaModel {
                                    /// <summary>
                                    /// <para>This parameter is required.</para>
                                    /// </summary>
                                    [NameInMap("extension")]
                                    [Validation(Required=false)]
                                    public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsOptionsExtension Extension { get; set; }
                                    public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsOptionsExtension : TeaModel {
                                        /// <summary>
                                        /// <para>This parameter is required.</para>
                                        /// </summary>
                                        [NameInMap("editFreeze")]
                                        [Validation(Required=false)]
                                        public bool? EditFreeze { get; set; }

                                    }

                                    /// <summary>
                                    /// <para>This parameter is required.</para>
                                    /// </summary>
                                    [NameInMap("key")]
                                    [Validation(Required=false)]
                                    public string Key { get; set; }

                                    /// <summary>
                                    /// <para>This parameter is required.</para>
                                    /// </summary>
                                    [NameInMap("value")]
                                    [Validation(Required=false)]
                                    public string Value { get; set; }

                                }

                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>true：是</para>
                                /// </summary>
                                [NameInMap("payEnable")]
                                [Validation(Required=false)]
                                public bool? PayEnable { get; set; }

                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// </summary>
                                [NameInMap("placeholder")]
                                [Validation(Required=false)]
                                public string Placeholder { get; set; }

                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// </summary>
                                [NameInMap("quote")]
                                [Validation(Required=false)]
                                public long? Quote { get; set; }

                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>true：必填</para>
                                /// </summary>
                                [NameInMap("required")]
                                [Validation(Required=false)]
                                public bool? Required { get; set; }

                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// </summary>
                                [NameInMap("requiredEditableFreeze")]
                                [Validation(Required=false)]
                                public bool? RequiredEditableFreeze { get; set; }

                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// </summary>
                                [NameInMap("statField")]
                                [Validation(Required=false)]
                                public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsStatField> StatField { get; set; }
                                public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsStatField : TeaModel {
                                    /// <summary>
                                    /// <para>This parameter is required.</para>
                                    /// </summary>
                                    [NameInMap("fieldId")]
                                    [Validation(Required=false)]
                                    public string FieldId { get; set; }

                                    /// <summary>
                                    /// <para>This parameter is required.</para>
                                    /// </summary>
                                    [NameInMap("label")]
                                    [Validation(Required=false)]
                                    public string Label { get; set; }

                                    /// <summary>
                                    /// <para>This parameter is required.</para>
                                    /// </summary>
                                    [NameInMap("unit")]
                                    [Validation(Required=false)]
                                    public string Unit { get; set; }

                                    /// <summary>
                                    /// <para>This parameter is required.</para>
                                    /// </summary>
                                    [NameInMap("upper")]
                                    [Validation(Required=false)]
                                    public bool? Upper { get; set; }

                                }

                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// </summary>
                                [NameInMap("unit")]
                                [Validation(Required=false)]
                                public string Unit { get; set; }

                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>true：纵向，false：横向</para>
                                /// </summary>
                                [NameInMap("verticalPrint")]
                                [Validation(Required=false)]
                                public bool? VerticalPrint { get; set; }

                            }

                        }

                    }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true：必填</para>
                    /// </summary>
                    [NameInMap("required")]
                    [Validation(Required=false)]
                    public bool? Required { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true：不可修改</para>
                    /// </summary>
                    [NameInMap("requiredEditableFreeze")]
                    [Validation(Required=false)]
                    public bool? RequiredEditableFreeze { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("rule")]
                    [Validation(Required=false)]
                    public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRule> Rule { get; set; }
                    public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRule : TeaModel {
                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("sortable")]
                    [Validation(Required=false)]
                    public bool? Sortable { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>选项控件spread</para>
                    /// </summary>
                    [NameInMap("spread")]
                    [Validation(Required=false)]
                    public bool? Spread { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("statField")]
                    [Validation(Required=false)]
                    public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsStatField> StatField { get; set; }
                    public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsStatField : TeaModel {
                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("fieldId")]
                        [Validation(Required=false)]
                        public string FieldId { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("unit")]
                        [Validation(Required=false)]
                        public string Unit { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("upper")]
                        [Validation(Required=false)]
                        public bool? Upper { get; set; }

                    }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>明细填写方式 table：表格，list：列表</para>
                    /// </summary>
                    [NameInMap("tableViewMode")]
                    [Validation(Required=false)]
                    public string TableViewMode { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true：纵向，false：横向</para>
                    /// </summary>
                    [NameInMap("verticalPrint")]
                    [Validation(Required=false)]
                    public bool? VerticalPrint { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>是否水印照片 true：是，false：否</para>
                    /// </summary>
                    [NameInMap("watermark")]
                    [Validation(Required=false)]
                    public bool? Watermark { get; set; }

                }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>企业客户</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("relationMetaCode")]
            [Validation(Required=false)]
            public string RelationMetaCode { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("relationMetaStatus")]
            [Validation(Required=false)]
            public string RelationMetaStatus { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>crm_customer</para>
            /// </summary>
            [NameInMap("relationType")]
            [Validation(Required=false)]
            public string RelationType { get; set; }

        }

    }

}
