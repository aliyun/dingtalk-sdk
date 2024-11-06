// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class PremiumGetFormSchemaResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public PremiumGetFormSchemaResponseBodyResult Result { get; set; }
        public class PremiumGetFormSchemaResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("appType")]
            [Validation(Required=false)]
            public int? AppType { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>26652461xxxx5992</para>
            /// </summary>
            [NameInMap("creatorUserId")]
            [Validation(Required=false)]
            public string CreatorUserId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PROC-17428B8C-6C60-470E-xxxx-64F1037AE067</para>
            /// </summary>
            [NameInMap("formCode")]
            [Validation(Required=false)]
            public string FormCode { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-01T10:49Z</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-01T10:49Z</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxx</para>
            /// </summary>
            [NameInMap("memo")]
            [Validation(Required=false)]
            public string Memo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例模板</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("schemaContent")]
            [Validation(Required=false)]
            public PremiumGetFormSchemaResponseBodyResultSchemaContent SchemaContent { get; set; }
            public class PremiumGetFormSchemaResponseBodyResultSchemaContent : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>common</para>
                /// </summary>
                [NameInMap("icon")]
                [Validation(Required=false)]
                public string Icon { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("items")]
                [Validation(Required=false)]
                public List<PremiumGetFormSchemaResponseBodyResultSchemaContentItems> Items { get; set; }
                public class PremiumGetFormSchemaResponseBodyResultSchemaContentItems : TeaModel {
                    [NameInMap("children")]
                    [Validation(Required=false)]
                    public List<PremiumGetFormSchemaResponseBodyResultSchemaContentItemsChildren> Children { get; set; }
                    public class PremiumGetFormSchemaResponseBodyResultSchemaContentItemsChildren : TeaModel {
                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TextField</para>
                        /// </summary>
                        [NameInMap("componentName")]
                        [Validation(Required=false)]
                        public string ComponentName { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("props")]
                        [Validation(Required=false)]
                        public PremiumGetFormSchemaResponseBodyResultSchemaContentItemsChildrenProps Props { get; set; }
                        public class PremiumGetFormSchemaResponseBodyResultSchemaContentItemsChildrenProps : TeaModel {
                            [NameInMap("bizAlias")]
                            [Validation(Required=false)]
                            public string BizAlias { get; set; }

                            /// <summary>
                            /// <para>This parameter is required.</para>
                            /// </summary>
                            [NameInMap("id")]
                            [Validation(Required=false)]
                            public string Id { get; set; }

                            [NameInMap("label")]
                            [Validation(Required=false)]
                            public string Label { get; set; }

                            [NameInMap("options")]
                            [Validation(Required=false)]
                            public List<string> Options { get; set; }

                            [NameInMap("required")]
                            [Validation(Required=false)]
                            public bool? Required { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TextField</para>
                    /// </summary>
                    [NameInMap("componentName")]
                    [Validation(Required=false)]
                    public string ComponentName { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("props")]
                    [Validation(Required=false)]
                    public PremiumGetFormSchemaResponseBodyResultSchemaContentItemsProps Props { get; set; }
                    public class PremiumGetFormSchemaResponseBodyResultSchemaContentItemsProps : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>添加</para>
                        /// </summary>
                        [NameInMap("actionName")]
                        [Validation(Required=false)]
                        public string ActionName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>top</para>
                        /// </summary>
                        [NameInMap("align")]
                        [Validation(Required=false)]
                        public string Align { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1234567</para>
                        /// </summary>
                        [NameInMap("appId")]
                        [Validation(Required=false)]
                        public long? AppId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("asyncCondition")]
                        [Validation(Required=false)]
                        public bool? AsyncCondition { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>请假</para>
                        /// </summary>
                        [NameInMap("attendTypeLabel")]
                        [Validation(Required=false)]
                        public string AttendTypeLabel { get; set; }

                        [NameInMap("behaviorLinkage")]
                        [Validation(Required=false)]
                        public List<PremiumGetFormSchemaResponseBodyResultSchemaContentItemsPropsBehaviorLinkage> BehaviorLinkage { get; set; }
                        public class PremiumGetFormSchemaResponseBodyResultSchemaContentItemsPropsBehaviorLinkage : TeaModel {
                            [NameInMap("targets")]
                            [Validation(Required=false)]
                            public List<PremiumGetFormSchemaResponseBodyResultSchemaContentItemsPropsBehaviorLinkageTargets> Targets { get; set; }
                            public class PremiumGetFormSchemaResponseBodyResultSchemaContentItemsPropsBehaviorLinkageTargets : TeaModel {
                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>xxxx</para>
                                /// </summary>
                                [NameInMap("behavior")]
                                [Validation(Required=false)]
                                public string Behavior { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>TextField-K2AD4O5B</para>
                                /// </summary>
                                [NameInMap("fieldId")]
                                [Validation(Required=false)]
                                public string FieldId { get; set; }

                            }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>xxxx</para>
                            /// </summary>
                            [NameInMap("value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>我的单行输入框</para>
                        /// </summary>
                        [NameInMap("bizAlias")]
                        [Validation(Required=false)]
                        public string BizAlias { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>hrm.xxxx</para>
                        /// </summary>
                        [NameInMap("bizType")]
                        [Validation(Required=false)]
                        public string BizType { get; set; }

                        [NameInMap("childFieldVisible")]
                        [Validation(Required=false)]
                        public Dictionary<string, bool?> ChildFieldVisible { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("choice")]
                        [Validation(Required=false)]
                        public int? Choice { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>xxxx</para>
                        /// </summary>
                        [NameInMap("commonBizType")]
                        [Validation(Required=false)]
                        public string CommonBizType { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("disabled")]
                        [Validation(Required=false)]
                        public bool? Disabled { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("duration")]
                        [Validation(Required=false)]
                        public bool? Duration { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>xxxx</para>
                        /// </summary>
                        [NameInMap("durationLabel")]
                        [Validation(Required=false)]
                        public string DurationLabel { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("eSign")]
                        [Validation(Required=false)]
                        public bool? ESign { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("extract")]
                        [Validation(Required=false)]
                        public bool? Extract { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>xxxx</para>
                        /// </summary>
                        [NameInMap("fieldsInfo")]
                        [Validation(Required=false)]
                        public string FieldsInfo { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>yyyy-MM-dd</para>
                        /// </summary>
                        [NameInMap("format")]
                        [Validation(Required=false)]
                        public string Format { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>xxxx</para>
                        /// </summary>
                        [NameInMap("formula")]
                        [Validation(Required=false)]
                        public string Formula { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("hidden")]
                        [Validation(Required=false)]
                        public bool? Hidden { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("hiddenInApprovalDetail")]
                        [Validation(Required=false)]
                        public bool? HiddenInApprovalDetail { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("hideLabel")]
                        [Validation(Required=false)]
                        public bool? HideLabel { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>&quot;[{&quot;name&quot;:&quot;\open&quot;}]&quot;</para>
                        /// </summary>
                        [NameInMap("holidayOptions")]
                        [Validation(Required=false)]
                        public List<Dictionary<string, string>> HolidayOptions { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TextField-K2AD4O5B</para>
                        /// </summary>
                        [NameInMap("id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>单行输入框</para>
                        /// </summary>
                        [NameInMap("label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("labelEditableFreeze")]
                        [Validation(Required=false)]
                        public bool? LabelEditableFreeze { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>xxxx</para>
                        /// </summary>
                        [NameInMap("link")]
                        [Validation(Required=false)]
                        public string Link { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>xxxx</para>
                        /// </summary>
                        [NameInMap("mainTitle")]
                        [Validation(Required=false)]
                        public string MainTitle { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("notPrint")]
                        [Validation(Required=false)]
                        public string NotPrint { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("notUpper")]
                        [Validation(Required=false)]
                        public string NotUpper { get; set; }

                        [NameInMap("objOptions")]
                        [Validation(Required=false)]
                        public List<PremiumGetFormSchemaResponseBodyResultSchemaContentItemsPropsObjOptions> ObjOptions { get; set; }
                        public class PremiumGetFormSchemaResponseBodyResultSchemaContentItemsPropsObjOptions : TeaModel {
                            [NameInMap("value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        [NameInMap("options")]
                        [Validation(Required=false)]
                        public List<string> Options { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("payEnable")]
                        [Validation(Required=false)]
                        public bool? PayEnable { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>请输入文字</para>
                        /// </summary>
                        [NameInMap("placeholder")]
                        [Validation(Required=false)]
                        public string Placeholder { get; set; }

                        [NameInMap("push")]
                        [Validation(Required=false)]
                        public PremiumGetFormSchemaResponseBodyResultSchemaContentItemsPropsPush Push { get; set; }
                        public class PremiumGetFormSchemaResponseBodyResultSchemaContentItemsPropsPush : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>1</para>
                            /// </summary>
                            [NameInMap("attendanceRule")]
                            [Validation(Required=false)]
                            public int? AttendanceRule { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>1</para>
                            /// </summary>
                            [NameInMap("pushSwitch")]
                            [Validation(Required=false)]
                            public int? PushSwitch { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>xxxx</para>
                            /// </summary>
                            [NameInMap("pushTag")]
                            [Validation(Required=false)]
                            public string PushTag { get; set; }

                        }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("pushToAttendance")]
                        [Validation(Required=false)]
                        public bool? PushToAttendance { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("pushToCalendar")]
                        [Validation(Required=false)]
                        public int? PushToCalendar { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("required")]
                        [Validation(Required=false)]
                        public bool? Required { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("requiredEditableFreeze")]
                        [Validation(Required=false)]
                        public bool? RequiredEditableFreeze { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("showAttendOptions")]
                        [Validation(Required=false)]
                        public bool? ShowAttendOptions { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("staffStatusEnabled")]
                        [Validation(Required=false)]
                        public bool? StaffStatusEnabled { get; set; }

                        [NameInMap("statField")]
                        [Validation(Required=false)]
                        public List<PremiumGetFormSchemaResponseBodyResultSchemaContentItemsPropsStatField> StatField { get; set; }
                        public class PremiumGetFormSchemaResponseBodyResultSchemaContentItemsPropsStatField : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>TextField-K2AD4O5B</para>
                            /// </summary>
                            [NameInMap("id")]
                            [Validation(Required=false)]
                            public string Id { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>单行输入框</para>
                            /// </summary>
                            [NameInMap("label")]
                            [Validation(Required=false)]
                            public string Label { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>xxxx</para>
                            /// </summary>
                            [NameInMap("unit")]
                            [Validation(Required=false)]
                            public string Unit { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>true</para>
                            /// </summary>
                            [NameInMap("upper")]
                            [Validation(Required=false)]
                            public bool? Upper { get; set; }

                        }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>list</para>
                        /// </summary>
                        [NameInMap("tableViewMode")]
                        [Validation(Required=false)]
                        public string TableViewMode { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>天</para>
                        /// </summary>
                        [NameInMap("unit")]
                        [Validation(Required=false)]
                        public string Unit { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("useCalendar")]
                        [Validation(Required=false)]
                        public bool? UseCalendar { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("verticalPrint")]
                        [Validation(Required=false)]
                        public bool? VerticalPrint { get; set; }

                    }

                }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例模板</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PUBLISHED</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
