// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class QuerySchemaByProcessCodeResponseBody : TeaModel {
        /// <summary>
        /// 返回结果详情。
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public QuerySchemaByProcessCodeResponseBodyResult Result { get; set; }
        public class QuerySchemaByProcessCodeResponseBodyResult : TeaModel {
            /// <summary>
            /// 表单类型。
            /// </summary>
            [NameInMap("appType")]
            [Validation(Required=false)]
            public int? AppType { get; set; }

            /// <summary>
            /// 表单应用 uuid 或者 corpId。
            /// </summary>
            [NameInMap("appUuid")]
            [Validation(Required=false)]
            public string AppUuid { get; set; }

            /// <summary>
            /// 代表表单业务含义的类型。
            /// </summary>
            [NameInMap("bizType")]
            [Validation(Required=false)]
            public string BizType { get; set; }

            /// <summary>
            /// 创建人 userId。
            /// </summary>
            [NameInMap("creatorUserId")]
            [Validation(Required=false)]
            public string CreatorUserId { get; set; }

            /// <summary>
            /// 业务自定义设置数据。
            /// </summary>
            [NameInMap("customSetting")]
            [Validation(Required=false)]
            public string CustomSetting { get; set; }

            /// <summary>
            /// 引擎类型，表单：0，页面：1
            /// </summary>
            [NameInMap("engineType")]
            [Validation(Required=false)]
            public int? EngineType { get; set; }

            /// <summary>
            /// 表单的唯一码。
            /// </summary>
            [NameInMap("formCode")]
            [Validation(Required=false)]
            public string FormCode { get; set; }

            /// <summary>
            /// 表单 uuid。
            /// </summary>
            [NameInMap("formUuid")]
            [Validation(Required=false)]
            public string FormUuid { get; set; }

            /// <summary>
            /// 创建时间的时间戳。
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// 修改时间的时间戳。
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// 图标。
            /// </summary>
            [NameInMap("icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            /// <summary>
            /// 排序 id。
            /// </summary>
            [NameInMap("listOrder")]
            [Validation(Required=false)]
            public int? ListOrder { get; set; }

            /// <summary>
            /// 说明文案。
            /// </summary>
            [NameInMap("memo")]
            [Validation(Required=false)]
            public string Memo { get; set; }

            /// <summary>
            /// 表单名称。
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 数据归属者的 id 类型。企业(orgId), 群(cid), 人(uid)。
            /// </summary>
            [NameInMap("ownerIdType")]
            [Validation(Required=false)]
            public string OwnerIdType { get; set; }

            /// <summary>
            /// 目标类型: inner, outer, customer。
            /// </summary>
            [NameInMap("procType")]
            [Validation(Required=false)]
            public string ProcType { get; set; }

            /// <summary>
            /// 表单 schema 详情。
            /// </summary>
            [NameInMap("schemaContent")]
            [Validation(Required=false)]
            public QuerySchemaByProcessCodeResponseBodyResultSchemaContent SchemaContent { get; set; }
            public class QuerySchemaByProcessCodeResponseBodyResultSchemaContent : TeaModel {
                /// <summary>
                /// 图标
                /// </summary>
                [NameInMap("icon")]
                [Validation(Required=false)]
                public string Icon { get; set; }

                /// <summary>
                /// 控件列表
                /// </summary>
                [NameInMap("items")]
                [Validation(Required=false)]
                public List<QuerySchemaByProcessCodeResponseBodyResultSchemaContentItems> Items { get; set; }
                public class QuerySchemaByProcessCodeResponseBodyResultSchemaContentItems : TeaModel {
                    /// <summary>
                    /// 子控件列表
                    /// </summary>
                    [NameInMap("children")]
                    [Validation(Required=false)]
                    public List<QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsChildren> Children { get; set; }
                    public class QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsChildren : TeaModel {
                        /// <summary>
                        /// 控件类型
                        /// </summary>
                        [NameInMap("componentName")]
                        [Validation(Required=false)]
                        public string ComponentName { get; set; }

                        /// <summary>
                        /// 子控件属性
                        /// </summary>
                        [NameInMap("props")]
                        [Validation(Required=false)]
                        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsChildrenProps Props { get; set; }
                        public class QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsChildrenProps : TeaModel {
                            /// <summary>
                            /// 控件业务别名
                            /// </summary>
                            [NameInMap("bizAlias")]
                            [Validation(Required=false)]
                            public string BizAlias { get; set; }

                            /// <summary>
                            /// 控件id
                            /// </summary>
                            [NameInMap("id")]
                            [Validation(Required=false)]
                            public string Id { get; set; }

                            /// <summary>
                            /// 控件名称
                            /// </summary>
                            [NameInMap("label")]
                            [Validation(Required=false)]
                            public string Label { get; set; }

                            /// <summary>
                            /// 是否必填
                            /// </summary>
                            [NameInMap("required")]
                            [Validation(Required=false)]
                            public bool? Required { get; set; }

                        }

                    }

                    /// <summary>
                    /// 控件类型，取值：
                    /// </summary>
                    [NameInMap("componentName")]
                    [Validation(Required=false)]
                    public string ComponentName { get; set; }

                    /// <summary>
                    /// 控件属性。
                    /// </summary>
                    [NameInMap("props")]
                    [Validation(Required=false)]
                    public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps Props { get; set; }
                    public class QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps : TeaModel {
                        /// <summary>
                        /// 加班套件4.0新增 加班明细名称。
                        /// </summary>
                        [NameInMap("actionName")]
                        [Validation(Required=false)]
                        public string ActionName { get; set; }

                        /// <summary>
                        /// textnote的样式，top|middle|bottom。
                        /// </summary>
                        [NameInMap("align")]
                        [Validation(Required=false)]
                        public string Align { get; set; }

                        /// <summary>
                        /// ISV 微应用 appId，用于ISV身份权限识别，ISV可获得相应数据。
                        /// </summary>
                        [NameInMap("appId")]
                        [Validation(Required=false)]
                        public long? AppId { get; set; }

                        /// <summary>
                        /// 套件是否开启异步获取分条件规则，true：开启；false：不开启。
                        /// </summary>
                        [NameInMap("asyncCondition")]
                        [Validation(Required=false)]
                        public bool? AsyncCondition { get; set; }

                        /// <summary>
                        /// 请假、出差、外出、加班类型标签。
                        /// </summary>
                        [NameInMap("attendTypeLabel")]
                        [Validation(Required=false)]
                        public string AttendTypeLabel { get; set; }

                        /// <summary>
                        /// 表单关联控件列表。
                        /// </summary>
                        [NameInMap("behaviorLinkage")]
                        [Validation(Required=false)]
                        public List<QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsBehaviorLinkage> BehaviorLinkage { get; set; }
                        public class QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsBehaviorLinkage : TeaModel {
                            /// <summary>
                            /// 关联控件列表。
                            /// </summary>
                            [NameInMap("targets")]
                            [Validation(Required=false)]
                            public List<QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsBehaviorLinkageTargets> Targets { get; set; }
                            public class QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsBehaviorLinkageTargets : TeaModel {
                                /// <summary>
                                /// 行为。
                                /// </summary>
                                [NameInMap("behavior")]
                                [Validation(Required=false)]
                                public string Behavior { get; set; }

                                /// <summary>
                                /// 字段 id。
                                /// </summary>
                                [NameInMap("fieldId")]
                                [Validation(Required=false)]
                                public string FieldId { get; set; }

                            }

                            /// <summary>
                            /// 控件值。
                            /// </summary>
                            [NameInMap("value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// 控件业务自定义别名。
                        /// </summary>
                        [NameInMap("bizAlias")]
                        [Validation(Required=false)]
                        public string BizAlias { get; set; }

                        /// <summary>
                        /// 业务套件类型。
                        /// </summary>
                        [NameInMap("bizType")]
                        [Validation(Required=false)]
                        public string BizType { get; set; }

                        /// <summary>
                        /// 套件内子组件可见性。
                        /// </summary>
                        [NameInMap("childFieldVisible")]
                        [Validation(Required=false)]
                        public bool? ChildFieldVisible { get; set; }

                        /// <summary>
                        /// 内部联系人choice，1表示多选，0表示单选。
                        /// </summary>
                        [NameInMap("choice")]
                        [Validation(Required=false)]
                        public int? Choice { get; set; }

                        /// <summary>
                        /// common field的commonBizType。
                        /// </summary>
                        [NameInMap("commonBizType")]
                        [Validation(Required=false)]
                        public string CommonBizType { get; set; }

                        /// <summary>
                        /// 是否可编辑。
                        /// </summary>
                        [NameInMap("disabled")]
                        [Validation(Required=false)]
                        public bool? Disabled { get; set; }

                        /// <summary>
                        /// 是否自动计算时长。
                        /// </summary>
                        [NameInMap("duration")]
                        [Validation(Required=false)]
                        public bool? Duration { get; set; }

                        /// <summary>
                        /// 兼容字段。
                        /// </summary>
                        [NameInMap("durationLabel")]
                        [Validation(Required=false)]
                        public string DurationLabel { get; set; }

                        /// <summary>
                        /// e签宝专用标识。
                        /// </summary>
                        [NameInMap("eSign")]
                        [Validation(Required=false)]
                        public bool? ESign { get; set; }

                        /// <summary>
                        /// 套件值是否打平
                        /// </summary>
                        [NameInMap("extract")]
                        [Validation(Required=false)]
                        public bool? Extract { get; set; }

                        /// <summary>
                        /// 关联表单中的fields存储
                        /// </summary>
                        [NameInMap("fieldsInfo")]
                        [Validation(Required=false)]
                        public string FieldsInfo { get; set; }

                        /// <summary>
                        /// 时间格式(DDDateField和DDDateRangeField)。
                        /// </summary>
                        [NameInMap("format")]
                        [Validation(Required=false)]
                        public string Format { get; set; }

                        /// <summary>
                        /// 公式。
                        /// </summary>
                        [NameInMap("formula")]
                        [Validation(Required=false)]
                        public string Formula { get; set; }

                        /// <summary>
                        /// 加班套件4.0新增 加班明细是否隐藏。
                        /// </summary>
                        [NameInMap("hidden")]
                        [Validation(Required=false)]
                        public bool? Hidden { get; set; }

                        /// <summary>
                        /// textnote在详情页是否隐藏，true隐藏， false不隐藏
                        /// </summary>
                        [NameInMap("hiddenInApprovalDetail")]
                        [Validation(Required=false)]
                        public bool? HiddenInApprovalDetail { get; set; }

                        /// <summary>
                        /// 加班套件4.0新增 加班明细是否隐藏标签。
                        /// </summary>
                        [NameInMap("hideLabel")]
                        [Validation(Required=false)]
                        public bool? HideLabel { get; set; }

                        /// <summary>
                        /// 兼容出勤套件类型。
                        /// </summary>
                        [NameInMap("holidayOptions")]
                        [Validation(Required=false)]
                        public List<Dictionary<string, string>> HolidayOptions { get; set; }

                        /// <summary>
                        /// 控件 id。
                        /// </summary>
                        [NameInMap("id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// 控件名称。
                        /// </summary>
                        [NameInMap("label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        /// <summary>
                        /// label是否可修改 true：不可修改。
                        /// </summary>
                        [NameInMap("labelEditableFreeze")]
                        [Validation(Required=false)]
                        public bool? LabelEditableFreeze { get; set; }

                        /// <summary>
                        /// 说明文案的链接地址。
                        /// </summary>
                        [NameInMap("link")]
                        [Validation(Required=false)]
                        public string Link { get; set; }

                        /// <summary>
                        /// 加班套件4.0新增 加班明细描述。
                        /// </summary>
                        [NameInMap("mainTitle")]
                        [Validation(Required=false)]
                        public string MainTitle { get; set; }

                        /// <summary>
                        /// 是否参与打印(1表示不打印, 0表示打印)。
                        /// </summary>
                        [NameInMap("notPrint")]
                        [Validation(Required=false)]
                        public string NotPrint { get; set; }

                        /// <summary>
                        /// 是否需要大写 默认是需要; 1:不需要大写, 空或者0:需要大写。
                        /// </summary>
                        [NameInMap("notUpper")]
                        [Validation(Required=false)]
                        public string NotUpper { get; set; }

                        /// <summary>
                        /// 选项内容列表，提供给业务方更多的选择器操作。
                        /// </summary>
                        [NameInMap("objOptions")]
                        [Validation(Required=false)]
                        public List<QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsObjOptions> ObjOptions { get; set; }
                        public class QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsObjOptions : TeaModel {
                            [NameInMap("value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// 单选框选项列表。
                        /// </summary>
                        [NameInMap("options")]
                        [Validation(Required=false)]
                        public List<string> Options { get; set; }

                        /// <summary>
                        /// 是否有支付属性。
                        /// </summary>
                        [NameInMap("payEnable")]
                        [Validation(Required=false)]
                        public bool? PayEnable { get; set; }

                        /// <summary>
                        /// 占位符。
                        /// </summary>
                        [NameInMap("placeholder")]
                        [Validation(Required=false)]
                        public string Placeholder { get; set; }

                        /// <summary>
                        /// 同步到考勤, 表示是否设置为员工状态。
                        /// </summary>
                        [NameInMap("push")]
                        [Validation(Required=false)]
                        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsPush Push { get; set; }
                        public class QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsPush : TeaModel {
                            /// <summary>
                            /// 考勤类型(1表示请假, 2表示出差, 3表示加班, 4表示外出)
                            /// </summary>
                            [NameInMap("attendanceRule")]
                            [Validation(Required=false)]
                            public int? AttendanceRule { get; set; }

                            /// <summary>
                            /// 开启状态(1表示开启, 0表示关闭)
                            /// </summary>
                            [NameInMap("pushSwitch")]
                            [Validation(Required=false)]
                            public int? PushSwitch { get; set; }

                            /// <summary>
                            /// 状态显示名称
                            /// </summary>
                            [NameInMap("pushTag")]
                            [Validation(Required=false)]
                            public string PushTag { get; set; }

                        }

                        /// <summary>
                        /// 推送到考勤, 子类型(DDSelectField)。
                        /// </summary>
                        [NameInMap("pushToAttendance")]
                        [Validation(Required=false)]
                        public bool? PushToAttendance { get; set; }

                        /// <summary>
                        /// 是否推送管理日历(DDDateRangeField, 1表示推送, 0表示不推送, 该属性为兼容保留)。
                        /// </summary>
                        [NameInMap("pushToCalendar")]
                        [Validation(Required=false)]
                        public int? PushToCalendar { get; set; }

                        /// <summary>
                        /// 是否必填。
                        /// </summary>
                        [NameInMap("required")]
                        [Validation(Required=false)]
                        public bool? Required { get; set; }

                        /// <summary>
                        /// 必填是否可修改 true：不可修改。
                        /// </summary>
                        [NameInMap("requiredEditableFreeze")]
                        [Validation(Required=false)]
                        public bool? RequiredEditableFreeze { get; set; }

                        /// <summary>
                        /// 兼容出勤套件类型。
                        /// </summary>
                        [NameInMap("showAttendOptions")]
                        [Validation(Required=false)]
                        public bool? ShowAttendOptions { get; set; }

                        /// <summary>
                        /// 是否开启员工状态。
                        /// </summary>
                        [NameInMap("staffStatusEnabled")]
                        [Validation(Required=false)]
                        public bool? StaffStatusEnabled { get; set; }

                        /// <summary>
                        /// 需要计算总和的明细组件
                        /// </summary>
                        [NameInMap("statField")]
                        [Validation(Required=false)]
                        public List<QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsStatField> StatField { get; set; }
                        public class QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsStatField : TeaModel {
                            /// <summary>
                            /// id 值。
                            /// </summary>
                            [NameInMap("id")]
                            [Validation(Required=false)]
                            public string Id { get; set; }

                            /// <summary>
                            /// 名称。
                            /// </summary>
                            [NameInMap("label")]
                            [Validation(Required=false)]
                            public string Label { get; set; }

                            /// <summary>
                            /// 单位。
                            /// </summary>
                            [NameInMap("unit")]
                            [Validation(Required=false)]
                            public string Unit { get; set; }

                            /// <summary>
                            /// 大写。
                            /// </summary>
                            [NameInMap("upper")]
                            [Validation(Required=false)]
                            public bool? Upper { get; set; }

                        }

                        /// <summary>
                        /// 数字组件/日期区间组件单位属性。
                        /// </summary>
                        [NameInMap("unit")]
                        [Validation(Required=false)]
                        public string Unit { get; set; }

                        /// <summary>
                        /// 是否使用考勤日历。
                        /// </summary>
                        [NameInMap("useCalendar")]
                        [Validation(Required=false)]
                        public bool? UseCalendar { get; set; }

                        /// <summary>
                        /// 明细打印排版方式 false：横向 true：纵向。
                        /// </summary>
                        [NameInMap("verticalPrint")]
                        [Validation(Required=false)]
                        public bool? VerticalPrint { get; set; }

                    }

                }

                /// <summary>
                /// 表单名称。
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// 状态, PUBLISHED(启用), INVALID(停用), SAVED(草稿)
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// 可见范围类型。
            /// </summary>
            [NameInMap("visibleRange")]
            [Validation(Required=false)]
            public string VisibleRange { get; set; }

        }

    }

}
