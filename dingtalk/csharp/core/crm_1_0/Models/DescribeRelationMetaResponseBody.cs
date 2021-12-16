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
            /// <summary>
            /// 关系类型
            /// </summary>
            [NameInMap("relationType")]
            [Validation(Required=false)]
            public string RelationType { get; set; }

            /// <summary>
            /// 模型结构名称
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 模型结构描述
            /// </summary>
            [NameInMap("desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

            /// <summary>
            /// 模型结构字段集合
            /// </summary>
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItems> Items { get; set; }
            public class DescribeRelationMetaResponseBodyRelationMetaDTOListItems : TeaModel {
                /// <summary>
                /// 子字段列表
                /// </summary>
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
                        [NameInMap("fieldId")]
                        [Validation(Required=false)]
                        public string FieldId { get; set; }
                        [NameInMap("label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }
                        [NameInMap("labelEditableFreeze")]
                        [Validation(Required=false)]
                        public bool? LabelEditableFreeze { get; set; }
                        [NameInMap("required")]
                        [Validation(Required=false)]
                        public bool? Required { get; set; }
                        [NameInMap("requiredEditableFreeze")]
                        [Validation(Required=false)]
                        public bool? RequiredEditableFreeze { get; set; }
                        [NameInMap("notPrint")]
                        [Validation(Required=false)]
                        public string NotPrint { get; set; }
                        [NameInMap("content")]
                        [Validation(Required=false)]
                        public string Content { get; set; }
                        [NameInMap("format")]
                        [Validation(Required=false)]
                        public string Format { get; set; }
                        [NameInMap("options")]
                        [Validation(Required=false)]
                        public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsOptions> Options { get; set; }
                        public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsOptions : TeaModel {
                            public string Key { get; set; }
                            public string Value { get; set; }
                        }
                        [NameInMap("notUpper")]
                        [Validation(Required=false)]
                        public string NotUpper { get; set; }
                        [NameInMap("unit")]
                        [Validation(Required=false)]
                        public string Unit { get; set; }
                        [NameInMap("placeholder")]
                        [Validation(Required=false)]
                        public string Placeholder { get; set; }
                        [NameInMap("bizAlias")]
                        [Validation(Required=false)]
                        public string BizAlias { get; set; }
                        [NameInMap("duration")]
                        [Validation(Required=false)]
                        public bool? Duration { get; set; }
                        [NameInMap("choice")]
                        [Validation(Required=false)]
                        public long? Choice { get; set; }
                        [NameInMap("disabled")]
                        [Validation(Required=false)]
                        public bool? Disabled { get; set; }
                        [NameInMap("align")]
                        [Validation(Required=false)]
                        public string Align { get; set; }
                        [NameInMap("fields")]
                        [Validation(Required=false)]
                        public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFields> Fields { get; set; }
                        public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFields : TeaModel {
                            public string ComponentName { get; set; }
                            public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps RelateProps { get; set; }
                            public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps : TeaModel {
                                [NameInMap("fieldId")]
                                [Validation(Required=false)]
                                public string FieldId { get; set; }

                                [NameInMap("label")]
                                [Validation(Required=false)]
                                public string Label { get; set; }

                                [NameInMap("required")]
                                [Validation(Required=false)]
                                public bool? Required { get; set; }

                                [NameInMap("content")]
                                [Validation(Required=false)]
                                public string Content { get; set; }

                                [NameInMap("format")]
                                [Validation(Required=false)]
                                public string Format { get; set; }

                                [NameInMap("options")]
                                [Validation(Required=false)]
                                public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsOptions> Options { get; set; }
                                public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsOptions : TeaModel {
                                    [NameInMap("key")]
                                    [Validation(Required=false)]
                                    public string Key { get; set; }

                                    [NameInMap("value")]
                                    [Validation(Required=false)]
                                    public string Value { get; set; }

                                }

                                [NameInMap("notUpper")]
                                [Validation(Required=false)]
                                public string NotUpper { get; set; }

                                [NameInMap("unit")]
                                [Validation(Required=false)]
                                public string Unit { get; set; }

                                [NameInMap("placeholder")]
                                [Validation(Required=false)]
                                public string Placeholder { get; set; }

                                [NameInMap("bizAlias")]
                                [Validation(Required=false)]
                                public string BizAlias { get; set; }

                                [NameInMap("duration")]
                                [Validation(Required=false)]
                                public bool? Duration { get; set; }

                                [NameInMap("choice")]
                                [Validation(Required=false)]
                                public long? Choice { get; set; }

                                [NameInMap("disabled")]
                                [Validation(Required=false)]
                                public bool? Disabled { get; set; }

                                [NameInMap("align")]
                                [Validation(Required=false)]
                                public string Align { get; set; }

                                [NameInMap("invisible")]
                                [Validation(Required=false)]
                                public bool? Invisible { get; set; }

                                [NameInMap("payEnable")]
                                [Validation(Required=false)]
                                public bool? PayEnable { get; set; }

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

                                    [NameInMap("upper")]
                                    [Validation(Required=false)]
                                    public bool? Upper { get; set; }

                                    [NameInMap("unit")]
                                    [Validation(Required=false)]
                                    public string Unit { get; set; }

                                }

                                [NameInMap("link")]
                                [Validation(Required=false)]
                                public string Link { get; set; }

                                [NameInMap("verticalPrint")]
                                [Validation(Required=false)]
                                public bool? VerticalPrint { get; set; }

                                [NameInMap("formula")]
                                [Validation(Required=false)]
                                public string Formula { get; set; }

                            }
                        }
                        [NameInMap("dataSource")]
                        [Validation(Required=false)]
                        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSource DataSource { get; set; }
                        public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSource : TeaModel {
                            [NameInMap("type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                            [NameInMap("target")]
                            [Validation(Required=false)]
                            public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceTarget Target { get; set; }
                            public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceTarget : TeaModel {
                                [NameInMap("appUuid")]
                                [Validation(Required=false)]
                                public string AppUuid { get; set; }
                                [NameInMap("appType")]
                                [Validation(Required=false)]
                                public long? AppType { get; set; }
                                [NameInMap("bizType")]
                                [Validation(Required=false)]
                                public string BizType { get; set; }
                                [NameInMap("formCode")]
                                [Validation(Required=false)]
                                public string FormCode { get; set; }
                            };

                        }
                        [NameInMap("invisible")]
                        [Validation(Required=false)]
                        public bool? Invisible { get; set; }
                        [NameInMap("payEnable")]
                        [Validation(Required=false)]
                        public bool? PayEnable { get; set; }
                        [NameInMap("statField")]
                        [Validation(Required=false)]
                        public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsStatField> StatField { get; set; }
                        public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsStatField : TeaModel {
                            public string FieldId { get; set; }
                            public string Label { get; set; }
                            public bool? Upper { get; set; }
                            public string Unit { get; set; }
                        }
                        [NameInMap("link")]
                        [Validation(Required=false)]
                        public string Link { get; set; }
                        [NameInMap("verticalPrint")]
                        [Validation(Required=false)]
                        public bool? VerticalPrint { get; set; }
                        [NameInMap("formula")]
                        [Validation(Required=false)]
                        public string Formula { get; set; }
                    };

                }

                /// <summary>
                /// 字段类型
                /// </summary>
                [NameInMap("componentName")]
                [Validation(Required=false)]
                public string ComponentName { get; set; }

                /// <summary>
                /// 字段属性
                /// </summary>
                [NameInMap("props")]
                [Validation(Required=false)]
                public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps> Props { get; set; }
                public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps : TeaModel {
                    /// <summary>
                    /// 字段id
                    /// </summary>
                    [NameInMap("fieldId")]
                    [Validation(Required=false)]
                    public string FieldId { get; set; }

                    /// <summary>
                    /// 字段标题
                    /// </summary>
                    [NameInMap("label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// 字段标题是否可修改
                    /// </summary>
                    [NameInMap("labelEditableFreeze")]
                    [Validation(Required=false)]
                    public bool? LabelEditableFreeze { get; set; }

                    /// <summary>
                    /// 字段是否必填
                    /// </summary>
                    [NameInMap("required")]
                    [Validation(Required=false)]
                    public bool? Required { get; set; }

                    /// <summary>
                    /// 字段必填是否修改
                    /// </summary>
                    [NameInMap("requiredEditableFreeze")]
                    [Validation(Required=false)]
                    public bool? RequiredEditableFreeze { get; set; }

                    /// <summary>
                    /// 是否参与打印
                    /// </summary>
                    [NameInMap("notPrint")]
                    [Validation(Required=false)]
                    public string NotPrint { get; set; }

                    /// <summary>
                    /// 说明文字内容
                    /// </summary>
                    [NameInMap("content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// 时间格式
                    /// </summary>
                    [NameInMap("format")]
                    [Validation(Required=false)]
                    public string Format { get; set; }

                    /// <summary>
                    /// 选项内容列表
                    /// </summary>
                    [NameInMap("options")]
                    [Validation(Required=false)]
                    public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsOptions> Options { get; set; }
                    public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsOptions : TeaModel {
                        /// <summary>
                        /// 选项数据主键
                        /// </summary>
                        [NameInMap("key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// 选项显示内容
                        /// </summary>
                        [NameInMap("value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// 是否需要大写 默认是需要
                    /// </summary>
                    [NameInMap("notUpper")]
                    [Validation(Required=false)]
                    public string NotUpper { get; set; }

                    /// <summary>
                    /// 数字组件/日期区间组件单位属性
                    /// </summary>
                    [NameInMap("unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// 界面空值提示占位符 前后端统一用placeholder
                    /// </summary>
                    [NameInMap("placeholder")]
                    [Validation(Required=false)]
                    public string Placeholder { get; set; }

                    /// <summary>
                    /// 字段别名
                    /// </summary>
                    [NameInMap("bizAlias")]
                    [Validation(Required=false)]
                    public string BizAlias { get; set; }

                    /// <summary>
                    /// 是否自动计算时长
                    /// </summary>
                    [NameInMap("duration")]
                    [Validation(Required=false)]
                    public bool? Duration { get; set; }

                    /// <summary>
                    /// 内部联系人choice
                    /// </summary>
                    [NameInMap("choice")]
                    [Validation(Required=false)]
                    public long? Choice { get; set; }

                    /// <summary>
                    /// 是否可编辑
                    /// </summary>
                    [NameInMap("disabled")]
                    [Validation(Required=false)]
                    public bool? Disabled { get; set; }

                    /// <summary>
                    /// textnote的样式
                    /// </summary>
                    [NameInMap("align")]
                    [Validation(Required=false)]
                    public string Align { get; set; }

                    /// <summary>
                    /// 关联表单的关联控件显示
                    /// </summary>
                    [NameInMap("fields")]
                    [Validation(Required=false)]
                    public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFields> Fields { get; set; }
                    public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFields : TeaModel {
                        /// <summary>
                        /// 字段类型
                        /// </summary>
                        [NameInMap("componentName")]
                        [Validation(Required=false)]
                        public string ComponentName { get; set; }

                        /// <summary>
                        /// 字段属性
                        /// </summary>
                        [NameInMap("relateProps")]
                        [Validation(Required=false)]
                        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps RelateProps { get; set; }
                        public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps : TeaModel {
                            [NameInMap("fieldId")]
                            [Validation(Required=false)]
                            public string FieldId { get; set; }
                            [NameInMap("label")]
                            [Validation(Required=false)]
                            public string Label { get; set; }
                            [NameInMap("required")]
                            [Validation(Required=false)]
                            public bool? Required { get; set; }
                            [NameInMap("content")]
                            [Validation(Required=false)]
                            public string Content { get; set; }
                            [NameInMap("format")]
                            [Validation(Required=false)]
                            public string Format { get; set; }
                            [NameInMap("options")]
                            [Validation(Required=false)]
                            public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsOptions> Options { get; set; }
                            public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsOptions : TeaModel {
                                public string Key { get; set; }
                                public string Value { get; set; }
                            }
                            [NameInMap("notUpper")]
                            [Validation(Required=false)]
                            public string NotUpper { get; set; }
                            [NameInMap("unit")]
                            [Validation(Required=false)]
                            public string Unit { get; set; }
                            [NameInMap("placeholder")]
                            [Validation(Required=false)]
                            public string Placeholder { get; set; }
                            [NameInMap("bizAlias")]
                            [Validation(Required=false)]
                            public string BizAlias { get; set; }
                            [NameInMap("duration")]
                            [Validation(Required=false)]
                            public string Duration { get; set; }
                            [NameInMap("choice")]
                            [Validation(Required=false)]
                            public long? Choice { get; set; }
                            [NameInMap("disabled")]
                            [Validation(Required=false)]
                            public bool? Disabled { get; set; }
                            [NameInMap("align")]
                            [Validation(Required=false)]
                            public string Align { get; set; }
                            [NameInMap("invisible")]
                            [Validation(Required=false)]
                            public bool? Invisible { get; set; }
                            [NameInMap("payEnable")]
                            [Validation(Required=false)]
                            public bool? PayEnable { get; set; }
                            [NameInMap("statField")]
                            [Validation(Required=false)]
                            public List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsStatField> StatField { get; set; }
                            public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsStatField : TeaModel {
                                public string FieldId { get; set; }
                                public string Label { get; set; }
                                public bool? Upper { get; set; }
                                public string Unit { get; set; }
                            }
                            [NameInMap("link")]
                            [Validation(Required=false)]
                            public string Link { get; set; }
                            [NameInMap("verticalPrint")]
                            [Validation(Required=false)]
                            public bool? VerticalPrint { get; set; }
                            [NameInMap("formula")]
                            [Validation(Required=false)]
                            public string Formula { get; set; }
                        };

                    }

                    /// <summary>
                    /// 关联表单的数据源配置
                    /// </summary>
                    [NameInMap("dataSource")]
                    [Validation(Required=false)]
                    public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSource DataSource { get; set; }
                    public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSource : TeaModel {
                        [NameInMap("type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }
                        [NameInMap("target")]
                        [Validation(Required=false)]
                        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceTarget Target { get; set; }
                        public class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceTarget : TeaModel {
                            /// <summary>
                            /// 应用搭建id
                            /// </summary>
                            [NameInMap("appUuid")]
                            [Validation(Required=false)]
                            public string AppUuid { get; set; }

                            /// <summary>
                            /// 应用类型
                            /// </summary>
                            [NameInMap("appType")]
                            [Validation(Required=false)]
                            public long? AppType { get; set; }

                            /// <summary>
                            /// 表单业务标识
                            /// </summary>
                            [NameInMap("bizType")]
                            [Validation(Required=false)]
                            public string BizType { get; set; }

                            /// <summary>
                            /// 被关联表单的formCode
                            /// </summary>
                            [NameInMap("formCode")]
                            [Validation(Required=false)]
                            public string FormCode { get; set; }

                        }
                    };

                    /// <summary>
                    /// 隐藏字段
                    /// </summary>
                    [NameInMap("invisible")]
                    [Validation(Required=false)]
                    public bool? Invisible { get; set; }

                    /// <summary>
                    /// 是否有支付属性
                    /// </summary>
                    [NameInMap("payEnable")]
                    [Validation(Required=false)]
                    public bool? PayEnable { get; set; }

                    /// <summary>
                    /// 需要计算总和的明细组件
                    /// </summary>
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

                        [NameInMap("upper")]
                        [Validation(Required=false)]
                        public bool? Upper { get; set; }

                        [NameInMap("unit")]
                        [Validation(Required=false)]
                        public string Unit { get; set; }

                    }

                    /// <summary>
                    /// 说明文案的链接地址
                    /// </summary>
                    [NameInMap("link")]
                    [Validation(Required=false)]
                    public string Link { get; set; }

                    /// <summary>
                    /// 明细打印排版方式
                    /// </summary>
                    [NameInMap("verticalPrint")]
                    [Validation(Required=false)]
                    public bool? VerticalPrint { get; set; }

                    /// <summary>
                    /// 公式
                    /// </summary>
                    [NameInMap("formula")]
                    [Validation(Required=false)]
                    public string Formula { get; set; }

                }

            }

        }

    }

}
