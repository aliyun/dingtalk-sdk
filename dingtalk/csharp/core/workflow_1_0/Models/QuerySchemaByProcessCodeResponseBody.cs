// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class QuerySchemaByProcessCodeResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public QuerySchemaByProcessCodeResponseBodyResult Result { get; set; }
        public class QuerySchemaByProcessCodeResponseBodyResult : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("appType")]
            [Validation(Required=false)]
            public int? AppType { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("appUuid")]
            [Validation(Required=false)]
            public string AppUuid { get; set; }

            [NameInMap("bizType")]
            [Validation(Required=false)]
            public string BizType { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("creatorUserId")]
            [Validation(Required=false)]
            public string CreatorUserId { get; set; }

            [NameInMap("customSetting")]
            [Validation(Required=false)]
            public string CustomSetting { get; set; }

            [NameInMap("engineType")]
            [Validation(Required=false)]
            public int? EngineType { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("formCode")]
            [Validation(Required=false)]
            public string FormCode { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("formUuid")]
            [Validation(Required=false)]
            public string FormUuid { get; set; }

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

            [NameInMap("icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            [NameInMap("listOrder")]
            [Validation(Required=false)]
            public int? ListOrder { get; set; }

            [NameInMap("memo")]
            [Validation(Required=false)]
            public string Memo { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("ownerIdType")]
            [Validation(Required=false)]
            public string OwnerIdType { get; set; }

            [NameInMap("procType")]
            [Validation(Required=false)]
            public string ProcType { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("schemaContent")]
            [Validation(Required=false)]
            public QuerySchemaByProcessCodeResponseBodyResultSchemaContent SchemaContent { get; set; }
            public class QuerySchemaByProcessCodeResponseBodyResultSchemaContent : TeaModel {
                [NameInMap("icon")]
                [Validation(Required=false)]
                public string Icon { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("items")]
                [Validation(Required=false)]
                public List<QuerySchemaByProcessCodeResponseBodyResultSchemaContentItems> Items { get; set; }
                public class QuerySchemaByProcessCodeResponseBodyResultSchemaContentItems : TeaModel {
                    [NameInMap("children")]
                    [Validation(Required=false)]
                    public List<QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsChildren> Children { get; set; }
                    public class QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsChildren : TeaModel {
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
                        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsChildrenProps Props { get; set; }
                        public class QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsChildrenProps : TeaModel {
                            [NameInMap("bizAlias")]
                            [Validation(Required=false)]
                            public string BizAlias { get; set; }

                            /// <summary>
                            /// This parameter is required.
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
                    public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps Props { get; set; }
                    public class QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps : TeaModel {
                        [NameInMap("actionName")]
                        [Validation(Required=false)]
                        public string ActionName { get; set; }

                        [NameInMap("align")]
                        [Validation(Required=false)]
                        public string Align { get; set; }

                        [NameInMap("appId")]
                        [Validation(Required=false)]
                        public long? AppId { get; set; }

                        [NameInMap("asyncCondition")]
                        [Validation(Required=false)]
                        public bool? AsyncCondition { get; set; }

                        [NameInMap("attendTypeLabel")]
                        [Validation(Required=false)]
                        public string AttendTypeLabel { get; set; }

                        [NameInMap("behaviorLinkage")]
                        [Validation(Required=false)]
                        public List<QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsBehaviorLinkage> BehaviorLinkage { get; set; }
                        public class QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsBehaviorLinkage : TeaModel {
                            [NameInMap("targets")]
                            [Validation(Required=false)]
                            public List<QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsBehaviorLinkageTargets> Targets { get; set; }
                            public class QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsBehaviorLinkageTargets : TeaModel {
                                [NameInMap("behavior")]
                                [Validation(Required=false)]
                                public string Behavior { get; set; }

                                [NameInMap("fieldId")]
                                [Validation(Required=false)]
                                public string FieldId { get; set; }

                            }

                            [NameInMap("value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        [NameInMap("bizAlias")]
                        [Validation(Required=false)]
                        public string BizAlias { get; set; }

                        [NameInMap("bizType")]
                        [Validation(Required=false)]
                        public string BizType { get; set; }

                        [NameInMap("childFieldVisible")]
                        [Validation(Required=false)]
                        public Dictionary<string, bool?> ChildFieldVisible { get; set; }

                        [NameInMap("choice")]
                        [Validation(Required=false)]
                        public int? Choice { get; set; }

                        [NameInMap("commonBizType")]
                        [Validation(Required=false)]
                        public string CommonBizType { get; set; }

                        [NameInMap("disabled")]
                        [Validation(Required=false)]
                        public bool? Disabled { get; set; }

                        [NameInMap("duration")]
                        [Validation(Required=false)]
                        public bool? Duration { get; set; }

                        [NameInMap("durationLabel")]
                        [Validation(Required=false)]
                        public string DurationLabel { get; set; }

                        [NameInMap("eSign")]
                        [Validation(Required=false)]
                        public bool? ESign { get; set; }

                        [NameInMap("extract")]
                        [Validation(Required=false)]
                        public bool? Extract { get; set; }

                        [NameInMap("fieldsInfo")]
                        [Validation(Required=false)]
                        public string FieldsInfo { get; set; }

                        [NameInMap("format")]
                        [Validation(Required=false)]
                        public string Format { get; set; }

                        [NameInMap("formula")]
                        [Validation(Required=false)]
                        public string Formula { get; set; }

                        [NameInMap("hidden")]
                        [Validation(Required=false)]
                        public bool? Hidden { get; set; }

                        [NameInMap("hiddenInApprovalDetail")]
                        [Validation(Required=false)]
                        public bool? HiddenInApprovalDetail { get; set; }

                        [NameInMap("hideLabel")]
                        [Validation(Required=false)]
                        public bool? HideLabel { get; set; }

                        [NameInMap("holidayOptions")]
                        [Validation(Required=false)]
                        public List<Dictionary<string, string>> HolidayOptions { get; set; }

                        /// <summary>
                        /// This parameter is required.
                        /// </summary>
                        [NameInMap("id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// This parameter is required.
                        /// </summary>
                        [NameInMap("label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        [NameInMap("labelEditableFreeze")]
                        [Validation(Required=false)]
                        public bool? LabelEditableFreeze { get; set; }

                        [NameInMap("link")]
                        [Validation(Required=false)]
                        public string Link { get; set; }

                        [NameInMap("mainTitle")]
                        [Validation(Required=false)]
                        public string MainTitle { get; set; }

                        [NameInMap("notPrint")]
                        [Validation(Required=false)]
                        public string NotPrint { get; set; }

                        [NameInMap("notUpper")]
                        [Validation(Required=false)]
                        public string NotUpper { get; set; }

                        [NameInMap("objOptions")]
                        [Validation(Required=false)]
                        public List<QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsObjOptions> ObjOptions { get; set; }
                        public class QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsObjOptions : TeaModel {
                            [NameInMap("value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        [NameInMap("options")]
                        [Validation(Required=false)]
                        public List<string> Options { get; set; }

                        [NameInMap("payEnable")]
                        [Validation(Required=false)]
                        public bool? PayEnable { get; set; }

                        [NameInMap("placeholder")]
                        [Validation(Required=false)]
                        public string Placeholder { get; set; }

                        [NameInMap("push")]
                        [Validation(Required=false)]
                        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsPush Push { get; set; }
                        public class QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsPush : TeaModel {
                            [NameInMap("attendanceRule")]
                            [Validation(Required=false)]
                            public int? AttendanceRule { get; set; }

                            [NameInMap("pushSwitch")]
                            [Validation(Required=false)]
                            public int? PushSwitch { get; set; }

                            [NameInMap("pushTag")]
                            [Validation(Required=false)]
                            public string PushTag { get; set; }

                        }

                        [NameInMap("pushToAttendance")]
                        [Validation(Required=false)]
                        public bool? PushToAttendance { get; set; }

                        [NameInMap("pushToCalendar")]
                        [Validation(Required=false)]
                        public int? PushToCalendar { get; set; }

                        [NameInMap("required")]
                        [Validation(Required=false)]
                        public bool? Required { get; set; }

                        [NameInMap("requiredEditableFreeze")]
                        [Validation(Required=false)]
                        public bool? RequiredEditableFreeze { get; set; }

                        [NameInMap("showAttendOptions")]
                        [Validation(Required=false)]
                        public bool? ShowAttendOptions { get; set; }

                        [NameInMap("staffStatusEnabled")]
                        [Validation(Required=false)]
                        public bool? StaffStatusEnabled { get; set; }

                        [NameInMap("statField")]
                        [Validation(Required=false)]
                        public List<QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsStatField> StatField { get; set; }
                        public class QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsStatField : TeaModel {
                            [NameInMap("id")]
                            [Validation(Required=false)]
                            public string Id { get; set; }

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

                        [NameInMap("useCalendar")]
                        [Validation(Required=false)]
                        public bool? UseCalendar { get; set; }

                        [NameInMap("verticalPrint")]
                        [Validation(Required=false)]
                        public bool? VerticalPrint { get; set; }

                    }

                }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("visibleRange")]
            [Validation(Required=false)]
            public string VisibleRange { get; set; }

        }

    }

}
