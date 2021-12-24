// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class FormCreateRequest : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 表单模板描述
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("dingCorpId")]
        [Validation(Required=false)]
        public string DingCorpId { get; set; }

        [NameInMap("dingIsvOrgId")]
        [Validation(Required=false)]
        public long? DingIsvOrgId { get; set; }

        [NameInMap("dingOrgId")]
        [Validation(Required=false)]
        public long? DingOrgId { get; set; }

        [NameInMap("dingSuiteKey")]
        [Validation(Required=false)]
        public string DingSuiteKey { get; set; }

        [NameInMap("dingTokenGrantType")]
        [Validation(Required=false)]
        public long? DingTokenGrantType { get; set; }

        /// <summary>
        /// 表单控件列表
        /// </summary>
        [NameInMap("formComponents")]
        [Validation(Required=false)]
        public List<FormCreateRequestFormComponents> FormComponents { get; set; }
        public class FormCreateRequestFormComponents : TeaModel {
            /// <summary>
            /// 控件类型
            /// </summary>
            [NameInMap("componentType")]
            [Validation(Required=false)]
            public string ComponentType { get; set; }

            /// <summary>
            /// 控件属性
            /// </summary>
            [NameInMap("props")]
            [Validation(Required=false)]
            public FormCreateRequestFormComponentsProps Props { get; set; }
            public class FormCreateRequestFormComponentsProps : TeaModel {
                [NameInMap("componentId")]
                [Validation(Required=false)]
                public string ComponentId { get; set; }
                [NameInMap("label")]
                [Validation(Required=false)]
                public string Label { get; set; }
                [NameInMap("asyncCondition")]
                [Validation(Required=false)]
                public bool? AsyncCondition { get; set; }
                [NameInMap("required")]
                [Validation(Required=false)]
                public bool? Required { get; set; }
                [NameInMap("content")]
                [Validation(Required=false)]
                public string Content { get; set; }
                [NameInMap("format")]
                [Validation(Required=false)]
                public string Format { get; set; }
                [NameInMap("upper")]
                [Validation(Required=false)]
                public string Upper { get; set; }
                [NameInMap("unit")]
                [Validation(Required=false)]
                public string Unit { get; set; }
                [NameInMap("placeholder")]
                [Validation(Required=false)]
                public string Placeholder { get; set; }
                [NameInMap("bizAlias")]
                [Validation(Required=false)]
                public string BizAlias { get; set; }
                [NameInMap("bizType")]
                [Validation(Required=false)]
                public string BizType { get; set; }
                [NameInMap("duration")]
                [Validation(Required=false)]
                public bool? Duration { get; set; }
                [NameInMap("choice")]
                [Validation(Required=false)]
                public string Choice { get; set; }
                [NameInMap("disabled")]
                [Validation(Required=false)]
                public bool? Disabled { get; set; }
                [NameInMap("align")]
                [Validation(Required=false)]
                public string Align { get; set; }
                [NameInMap("invisible")]
                [Validation(Required=false)]
                public bool? Invisible { get; set; }
                [NameInMap("link")]
                [Validation(Required=false)]
                public string Link { get; set; }
                [NameInMap("verticalPrint")]
                [Validation(Required=false)]
                public bool? VerticalPrint { get; set; }
                [NameInMap("formula")]
                [Validation(Required=false)]
                public string Formula { get; set; }
                [NameInMap("commonBizType")]
                [Validation(Required=false)]
                public string CommonBizType { get; set; }
                [NameInMap("options")]
                [Validation(Required=false)]
                public List<FormCreateRequestFormComponentsPropsOptions> Options { get; set; }
                public class FormCreateRequestFormComponentsPropsOptions : TeaModel {
                    public string Value { get; set; }
                    public string Key { get; set; }
                }
                [NameInMap("print")]
                [Validation(Required=false)]
                public string Print { get; set; }
                [NameInMap("statField")]
                [Validation(Required=false)]
                public List<FormCreateRequestFormComponentsPropsStatField> StatField { get; set; }
                public class FormCreateRequestFormComponentsPropsStatField : TeaModel {
                    public string ComponentId { get; set; }
                    public string Label { get; set; }
                    public bool? Upper { get; set; }
                    public string PayEnable { get; set; }
                }
                [NameInMap("dataSource")]
                [Validation(Required=false)]
                public FormCreateRequestFormComponentsPropsDataSource DataSource { get; set; }
                public class FormCreateRequestFormComponentsPropsDataSource : TeaModel {
                    /// <summary>
                    /// 关联类型，form关联表单
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// 关联表单信息
                    /// </summary>
                    [NameInMap("target")]
                    [Validation(Required=false)]
                    public FormCreateRequestFormComponentsPropsDataSourceTarget Target { get; set; }
                    public class FormCreateRequestFormComponentsPropsDataSourceTarget : TeaModel {
                        [NameInMap("appUuid")]
                        [Validation(Required=false)]
                        public string AppUuid { get; set; }
                        [NameInMap("appType")]
                        [Validation(Required=false)]
                        public int? AppType { get; set; }
                        [NameInMap("bizType")]
                        [Validation(Required=false)]
                        public string BizType { get; set; }
                        [NameInMap("formCode")]
                        [Validation(Required=false)]
                        public string FormCode { get; set; }
                    };

                }
                [NameInMap("fields")]
                [Validation(Required=false)]
                public List<FormCreateRequestFormComponentsPropsFields> Fields { get; set; }
                public class FormCreateRequestFormComponentsPropsFields : TeaModel {
                    public string ComponentType { get; set; }
                    public FormCreateRequestFormComponentsPropsFieldsProps Props { get; set; }
                    public class FormCreateRequestFormComponentsPropsFieldsProps : TeaModel {
                        /// <summary>
                        /// 表单中控件的唯一id
                        /// </summary>
                        [NameInMap("componentId")]
                        [Validation(Required=false)]
                        public string ComponentId { get; set; }

                        /// <summary>
                        /// 控件标题
                        /// </summary>
                        [NameInMap("label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        /// <summary>
                        /// label是否禁用修改
                        /// </summary>
                        [NameInMap("labelEditableFreeze")]
                        [Validation(Required=false)]
                        public bool? LabelEditableFreeze { get; set; }

                        /// <summary>
                        /// 必填
                        /// </summary>
                        [NameInMap("required")]
                        [Validation(Required=false)]
                        public bool? Required { get; set; }

                        /// <summary>
                        /// 必填是否可修改
                        /// </summary>
                        [NameInMap("requiredEditableFreeze")]
                        [Validation(Required=false)]
                        public bool? RequiredEditableFreeze { get; set; }

                        /// <summary>
                        /// 是否可打印
                        /// </summary>
                        [NameInMap("print")]
                        [Validation(Required=false)]
                        public string Print { get; set; }

                        /// <summary>
                        /// 说明文字控件内容
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
                        /// 选项内容
                        /// </summary>
                        [NameInMap("options")]
                        [Validation(Required=false)]
                        public List<FormCreateRequestFormComponentsPropsFieldsPropsOptions> Options { get; set; }
                        public class FormCreateRequestFormComponentsPropsFieldsPropsOptions : TeaModel {
                            /// <summary>
                            /// 每一个选项的唯一键
                            /// </summary>
                            [NameInMap("key")]
                            [Validation(Required=false)]
                            public string Key { get; set; }

                            /// <summary>
                            /// 每一个选项的值
                            /// </summary>
                            [NameInMap("value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// 是否需要大写，1需要大写，0不需要
                        /// </summary>
                        [NameInMap("upper")]
                        [Validation(Required=false)]
                        public string Upper { get; set; }

                        /// <summary>
                        /// 时间单位（天、小时）
                        /// </summary>
                        [NameInMap("unit")]
                        [Validation(Required=false)]
                        public string Unit { get; set; }

                        /// <summary>
                        /// 输入提示
                        /// </summary>
                        [NameInMap("placeholder")]
                        [Validation(Required=false)]
                        public string Placeholder { get; set; }

                        /// <summary>
                        /// 业务别名
                        /// </summary>
                        [NameInMap("bizAlias")]
                        [Validation(Required=false)]
                        public string BizAlias { get; set; }

                        /// <summary>
                        /// 套件的业务标识
                        /// </summary>
                        [NameInMap("bizType")]
                        [Validation(Required=false)]
                        public string BizType { get; set; }

                        /// <summary>
                        /// 是否自动计算时长
                        /// </summary>
                        [NameInMap("duration")]
                        [Validation(Required=false)]
                        public bool? Duration { get; set; }

                        /// <summary>
                        /// 联系人控件是否支持多选，1多选，0单选
                        /// </summary>
                        [NameInMap("choice")]
                        [Validation(Required=false)]
                        public string Choice { get; set; }

                        /// <summary>
                        /// 是否不可编辑
                        /// </summary>
                        [NameInMap("disabled")]
                        [Validation(Required=false)]
                        public bool? Disabled { get; set; }

                        /// <summary>
                        /// 文字提示控件显示方式（top|middle|bottom）
                        /// </summary>
                        [NameInMap("align")]
                        [Validation(Required=false)]
                        public string Align { get; set; }

                    }
                }
                [NameInMap("addressModel")]
                [Validation(Required=false)]
                public string AddressModel { get; set; }
                [NameInMap("multiple")]
                [Validation(Required=false)]
                public bool? Multiple { get; set; }
                [NameInMap("limit")]
                [Validation(Required=false)]
                public int? Limit { get; set; }
                [NameInMap("availableTemplates")]
                [Validation(Required=false)]
                public List<FormCreateRequestFormComponentsPropsAvailableTemplates> AvailableTemplates { get; set; }
                public class FormCreateRequestFormComponentsPropsAvailableTemplates : TeaModel {
                    public string Name { get; set; }
                    public string ProcessCode { get; set; }
                }
                [NameInMap("tableViewMode")]
                [Validation(Required=false)]
                public string TableViewMode { get; set; }
            };

            /// <summary>
            /// 子控件列表
            /// </summary>
            [NameInMap("children")]
            [Validation(Required=false)]
            public List<FormCreateRequestFormComponentsChildren> Children { get; set; }
            public class FormCreateRequestFormComponentsChildren : TeaModel {
                /// <summary>
                /// 控件类型
                /// </summary>
                [NameInMap("componentType")]
                [Validation(Required=false)]
                public string ComponentType { get; set; }

                /// <summary>
                /// 控件属性
                /// </summary>
                [NameInMap("props")]
                [Validation(Required=false)]
                public FormCreateRequestFormComponentsChildrenProps Props { get; set; }
                public class FormCreateRequestFormComponentsChildrenProps : TeaModel {
                    [NameInMap("componentId")]
                    [Validation(Required=false)]
                    public string ComponentId { get; set; }
                    [NameInMap("label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }
                    [NameInMap("asyncCondition")]
                    [Validation(Required=false)]
                    public bool? AsyncCondition { get; set; }
                    [NameInMap("required")]
                    [Validation(Required=false)]
                    public bool? Required { get; set; }
                    [NameInMap("content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }
                    [NameInMap("format")]
                    [Validation(Required=false)]
                    public string Format { get; set; }
                    [NameInMap("upper")]
                    [Validation(Required=false)]
                    public string Upper { get; set; }
                    [NameInMap("unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }
                    [NameInMap("placeholder")]
                    [Validation(Required=false)]
                    public string Placeholder { get; set; }
                    [NameInMap("bizAlias")]
                    [Validation(Required=false)]
                    public string BizAlias { get; set; }
                    [NameInMap("bizType")]
                    [Validation(Required=false)]
                    public string BizType { get; set; }
                    [NameInMap("duration")]
                    [Validation(Required=false)]
                    public bool? Duration { get; set; }
                    [NameInMap("choice")]
                    [Validation(Required=false)]
                    public string Choice { get; set; }
                    [NameInMap("disabled")]
                    [Validation(Required=false)]
                    public bool? Disabled { get; set; }
                    [NameInMap("align")]
                    [Validation(Required=false)]
                    public string Align { get; set; }
                    [NameInMap("invisible")]
                    [Validation(Required=false)]
                    public bool? Invisible { get; set; }
                    [NameInMap("link")]
                    [Validation(Required=false)]
                    public string Link { get; set; }
                    [NameInMap("verticalPrint")]
                    [Validation(Required=false)]
                    public bool? VerticalPrint { get; set; }
                    [NameInMap("formula")]
                    [Validation(Required=false)]
                    public string Formula { get; set; }
                    [NameInMap("commonBizType")]
                    [Validation(Required=false)]
                    public string CommonBizType { get; set; }
                    [NameInMap("options")]
                    [Validation(Required=false)]
                    public List<FormCreateRequestFormComponentsChildrenPropsOptions> Options { get; set; }
                    public class FormCreateRequestFormComponentsChildrenPropsOptions : TeaModel {
                        public string Value { get; set; }
                        public string Key { get; set; }
                    }
                    [NameInMap("print")]
                    [Validation(Required=false)]
                    public string Print { get; set; }
                    [NameInMap("statField")]
                    [Validation(Required=false)]
                    public List<FormCreateRequestFormComponentsChildrenPropsStatField> StatField { get; set; }
                    public class FormCreateRequestFormComponentsChildrenPropsStatField : TeaModel {
                        public string ComponentId { get; set; }
                        public string Label { get; set; }
                        public bool? Upper { get; set; }
                        public string PayEnable { get; set; }
                    }
                    [NameInMap("dataSource")]
                    [Validation(Required=false)]
                    public FormCreateRequestFormComponentsChildrenPropsDataSource DataSource { get; set; }
                    public class FormCreateRequestFormComponentsChildrenPropsDataSource : TeaModel {
                        [NameInMap("type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        [NameInMap("target")]
                        [Validation(Required=false)]
                        public FormCreateRequestFormComponentsChildrenPropsDataSourceTarget Target { get; set; }
                        public class FormCreateRequestFormComponentsChildrenPropsDataSourceTarget : TeaModel {
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
                    [NameInMap("fields")]
                    [Validation(Required=false)]
                    public List<FormCreateRequestFormComponentsChildrenPropsFields> Fields { get; set; }
                    public class FormCreateRequestFormComponentsChildrenPropsFields : TeaModel {
                        public string ComponentType { get; set; }
                        public FormCreateRequestFormComponentsChildrenPropsFieldsProps Props { get; set; }
                        public class FormCreateRequestFormComponentsChildrenPropsFieldsProps : TeaModel {
                            /// <summary>
                            /// 表单中控件的唯一id
                            /// </summary>
                            [NameInMap("componentId")]
                            [Validation(Required=false)]
                            public string ComponentId { get; set; }

                            /// <summary>
                            /// 控件标题
                            /// </summary>
                            [NameInMap("label")]
                            [Validation(Required=false)]
                            public string Label { get; set; }

                            /// <summary>
                            /// label是否禁用修改
                            /// </summary>
                            [NameInMap("labelEditableFreeze")]
                            [Validation(Required=false)]
                            public bool? LabelEditableFreeze { get; set; }

                            /// <summary>
                            /// 必填
                            /// </summary>
                            [NameInMap("required")]
                            [Validation(Required=false)]
                            public bool? Required { get; set; }

                            /// <summary>
                            /// 必填是否可修改
                            /// </summary>
                            [NameInMap("requiredEditableFreeze")]
                            [Validation(Required=false)]
                            public bool? RequiredEditableFreeze { get; set; }

                            [NameInMap("print")]
                            [Validation(Required=false)]
                            public string Print { get; set; }

                            /// <summary>
                            /// 说明文字控件内容
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
                            /// 选项内容
                            /// </summary>
                            [NameInMap("options")]
                            [Validation(Required=false)]
                            public List<FormCreateRequestFormComponentsChildrenPropsFieldsPropsOptions> Options { get; set; }
                            public class FormCreateRequestFormComponentsChildrenPropsFieldsPropsOptions : TeaModel {
                                /// <summary>
                                /// 每一个选项的唯一键
                                /// </summary>
                                [NameInMap("key")]
                                [Validation(Required=false)]
                                public string Key { get; set; }

                                /// <summary>
                                /// 每一个选项的值
                                /// </summary>
                                [NameInMap("value")]
                                [Validation(Required=false)]
                                public string Value { get; set; }

                            }

                            /// <summary>
                            /// 是否需要大写，1不需要大写，其他需要大写
                            /// </summary>
                            [NameInMap("notUpper")]
                            [Validation(Required=false)]
                            public string NotUpper { get; set; }

                            /// <summary>
                            /// 时间单位（天、小时）
                            /// </summary>
                            [NameInMap("unit")]
                            [Validation(Required=false)]
                            public string Unit { get; set; }

                            /// <summary>
                            /// 输入提示
                            /// </summary>
                            [NameInMap("placeholder")]
                            [Validation(Required=false)]
                            public string Placeholder { get; set; }

                            /// <summary>
                            /// 业务别名
                            /// </summary>
                            [NameInMap("bizAlias")]
                            [Validation(Required=false)]
                            public string BizAlias { get; set; }

                            /// <summary>
                            /// 套件的业务标识
                            /// </summary>
                            [NameInMap("bizType")]
                            [Validation(Required=false)]
                            public string BizType { get; set; }

                            /// <summary>
                            /// 是否自动计算时长
                            /// </summary>
                            [NameInMap("duration")]
                            [Validation(Required=false)]
                            public bool? Duration { get; set; }

                            /// <summary>
                            /// 联系人控件是否支持多选，1多选，0单选
                            /// </summary>
                            [NameInMap("choice")]
                            [Validation(Required=false)]
                            public string Choice { get; set; }

                            /// <summary>
                            /// 是否不可编辑
                            /// </summary>
                            [NameInMap("disabled")]
                            [Validation(Required=false)]
                            public bool? Disabled { get; set; }

                            /// <summary>
                            /// 文字提示控件显示方式（top|middle|bottom）
                            /// </summary>
                            [NameInMap("align")]
                            [Validation(Required=false)]
                            public string Align { get; set; }

                        }
                    }
                    [NameInMap("addressModel")]
                    [Validation(Required=false)]
                    public string AddressModel { get; set; }
                    [NameInMap("multiple")]
                    [Validation(Required=false)]
                    public bool? Multiple { get; set; }
                    [NameInMap("limit")]
                    [Validation(Required=false)]
                    public int? Limit { get; set; }
                    [NameInMap("availableTemplates")]
                    [Validation(Required=false)]
                    public List<FormCreateRequestFormComponentsChildrenPropsAvailableTemplates> AvailableTemplates { get; set; }
                    public class FormCreateRequestFormComponentsChildrenPropsAvailableTemplates : TeaModel {
                        public string Name { get; set; }
                        public string ProcessCode { get; set; }
                    }
                    [NameInMap("tableViewMode")]
                    [Validation(Required=false)]
                    public string TableViewMode { get; set; }
                };

                /// <summary>
                /// 子控件列表
                /// </summary>
                [NameInMap("children")]
                [Validation(Required=false)]
                public List<FormCreateRequestFormComponentsChildrenChildren> Children { get; set; }
                public class FormCreateRequestFormComponentsChildrenChildren : TeaModel {
                    [NameInMap("componentType")]
                    [Validation(Required=false)]
                    public string ComponentType { get; set; }

                    [NameInMap("props")]
                    [Validation(Required=false)]
                    public FormCreateRequestFormComponentsChildrenChildrenProps Props { get; set; }
                    public class FormCreateRequestFormComponentsChildrenChildrenProps : TeaModel {
                        [NameInMap("componentId")]
                        [Validation(Required=false)]
                        public string ComponentId { get; set; }
                        [NameInMap("label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }
                        [NameInMap("asyncCondition")]
                        [Validation(Required=false)]
                        public bool? AsyncCondition { get; set; }
                        [NameInMap("required")]
                        [Validation(Required=false)]
                        public bool? Required { get; set; }
                        [NameInMap("content")]
                        [Validation(Required=false)]
                        public string Content { get; set; }
                        [NameInMap("format")]
                        [Validation(Required=false)]
                        public string Format { get; set; }
                        [NameInMap("upper")]
                        [Validation(Required=false)]
                        public string Upper { get; set; }
                        [NameInMap("unit")]
                        [Validation(Required=false)]
                        public string Unit { get; set; }
                        [NameInMap("placeholder")]
                        [Validation(Required=false)]
                        public string Placeholder { get; set; }
                        [NameInMap("bizAlias")]
                        [Validation(Required=false)]
                        public string BizAlias { get; set; }
                        [NameInMap("bizType")]
                        [Validation(Required=false)]
                        public string BizType { get; set; }
                        [NameInMap("duration")]
                        [Validation(Required=false)]
                        public bool? Duration { get; set; }
                        [NameInMap("choice")]
                        [Validation(Required=false)]
                        public string Choice { get; set; }
                        [NameInMap("disabled")]
                        [Validation(Required=false)]
                        public bool? Disabled { get; set; }
                        [NameInMap("align")]
                        [Validation(Required=false)]
                        public string Align { get; set; }
                        [NameInMap("invisible")]
                        [Validation(Required=false)]
                        public bool? Invisible { get; set; }
                        [NameInMap("link")]
                        [Validation(Required=false)]
                        public string Link { get; set; }
                        [NameInMap("verticalPrint")]
                        [Validation(Required=false)]
                        public bool? VerticalPrint { get; set; }
                        [NameInMap("formula")]
                        [Validation(Required=false)]
                        public string Formula { get; set; }
                        [NameInMap("commonBizType")]
                        [Validation(Required=false)]
                        public string CommonBizType { get; set; }
                        [NameInMap("options")]
                        [Validation(Required=false)]
                        public List<FormCreateRequestFormComponentsChildrenChildrenPropsOptions> Options { get; set; }
                        public class FormCreateRequestFormComponentsChildrenChildrenPropsOptions : TeaModel {
                            public string Value { get; set; }
                            public string Key { get; set; }
                        }
                        [NameInMap("print")]
                        [Validation(Required=false)]
                        public string Print { get; set; }
                        [NameInMap("statField")]
                        [Validation(Required=false)]
                        public List<FormCreateRequestFormComponentsChildrenChildrenPropsStatField> StatField { get; set; }
                        public class FormCreateRequestFormComponentsChildrenChildrenPropsStatField : TeaModel {
                            public string ComponentId { get; set; }
                            public string Label { get; set; }
                            public bool? Upper { get; set; }
                            public string PayEnable { get; set; }
                        }
                        [NameInMap("dataSource")]
                        [Validation(Required=false)]
                        public FormCreateRequestFormComponentsChildrenChildrenPropsDataSource DataSource { get; set; }
                        public class FormCreateRequestFormComponentsChildrenChildrenPropsDataSource : TeaModel {
                            [NameInMap("type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                            [NameInMap("target")]
                            [Validation(Required=false)]
                            public FormCreateRequestFormComponentsChildrenChildrenPropsDataSourceTarget Target { get; set; }
                            public class FormCreateRequestFormComponentsChildrenChildrenPropsDataSourceTarget : TeaModel {
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
                        [NameInMap("fields")]
                        [Validation(Required=false)]
                        public List<FormCreateRequestFormComponentsChildrenChildrenPropsFields> Fields { get; set; }
                        public class FormCreateRequestFormComponentsChildrenChildrenPropsFields : TeaModel {
                            public string ComponentType { get; set; }
                            public FormCreateRequestFormComponentsChildrenChildrenPropsFieldsProps Props { get; set; }
                            public class FormCreateRequestFormComponentsChildrenChildrenPropsFieldsProps : TeaModel {
                                /// <summary>
                                /// 表单中控件的唯一id
                                /// </summary>
                                [NameInMap("componentId")]
                                [Validation(Required=false)]
                                public string ComponentId { get; set; }

                                /// <summary>
                                /// 控件标题
                                /// </summary>
                                [NameInMap("label")]
                                [Validation(Required=false)]
                                public string Label { get; set; }

                                /// <summary>
                                /// 必填
                                /// </summary>
                                [NameInMap("required")]
                                [Validation(Required=false)]
                                public bool? Required { get; set; }

                                /// <summary>
                                /// 字段是否可被打印，1表示打印, 0表示打印，默认打印
                                /// </summary>
                                [NameInMap("print")]
                                [Validation(Required=false)]
                                public string Print { get; set; }

                                /// <summary>
                                /// 说明文字控件内容
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
                                /// 选项内容
                                /// </summary>
                                [NameInMap("options")]
                                [Validation(Required=false)]
                                public List<FormCreateRequestFormComponentsChildrenChildrenPropsFieldsPropsOptions> Options { get; set; }
                                public class FormCreateRequestFormComponentsChildrenChildrenPropsFieldsPropsOptions : TeaModel {
                                    /// <summary>
                                    /// 每一个选项的唯一键
                                    /// </summary>
                                    [NameInMap("key")]
                                    [Validation(Required=false)]
                                    public string Key { get; set; }

                                    /// <summary>
                                    /// 每一个选项的值
                                    /// </summary>
                                    [NameInMap("value")]
                                    [Validation(Required=false)]
                                    public string Value { get; set; }

                                }

                                /// <summary>
                                /// 是否需要大写，1需要大写，0不需要，默认1
                                /// </summary>
                                [NameInMap("upper")]
                                [Validation(Required=false)]
                                public string Upper { get; set; }

                                /// <summary>
                                /// 时间单位（天、小时）
                                /// </summary>
                                [NameInMap("unit")]
                                [Validation(Required=false)]
                                public string Unit { get; set; }

                                /// <summary>
                                /// 输入提示
                                /// </summary>
                                [NameInMap("placeholder")]
                                [Validation(Required=false)]
                                public string Placeholder { get; set; }

                                /// <summary>
                                /// 业务别名
                                /// </summary>
                                [NameInMap("bizAlias")]
                                [Validation(Required=false)]
                                public string BizAlias { get; set; }

                                /// <summary>
                                /// 套件的业务标识
                                /// </summary>
                                [NameInMap("bizType")]
                                [Validation(Required=false)]
                                public string BizType { get; set; }

                                /// <summary>
                                /// 是否自动计算时长
                                /// </summary>
                                [NameInMap("duration")]
                                [Validation(Required=false)]
                                public bool? Duration { get; set; }

                                /// <summary>
                                /// 联系人控件是否支持多选，1多选，0单选
                                /// </summary>
                                [NameInMap("choice")]
                                [Validation(Required=false)]
                                public string Choice { get; set; }

                                /// <summary>
                                /// 是否不可编辑
                                /// </summary>
                                [NameInMap("disabled")]
                                [Validation(Required=false)]
                                public bool? Disabled { get; set; }

                                /// <summary>
                                /// 文字提示控件显示方式（top|middle|bottom）
                                /// </summary>
                                [NameInMap("align")]
                                [Validation(Required=false)]
                                public string Align { get; set; }

                            }
                        }
                    };

                }

            }

        }

        /// <summary>
        /// 表单模板名称
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("processCode")]
        [Validation(Required=false)]
        public string ProcessCode { get; set; }

    }

}
