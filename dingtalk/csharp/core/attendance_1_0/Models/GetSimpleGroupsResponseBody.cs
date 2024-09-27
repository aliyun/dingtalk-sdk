// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class GetSimpleGroupsResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetSimpleGroupsResponseBodyResult Result { get; set; }
        public class GetSimpleGroupsResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>[]</para>
            /// </summary>
            [NameInMap("groups")]
            [Validation(Required=false)]
            public List<GetSimpleGroupsResponseBodyResultGroups> Groups { get; set; }
            public class GetSimpleGroupsResponseBodyResultGroups : TeaModel {
                [NameInMap("classesList")]
                [Validation(Required=false)]
                public List<string> ClassesList { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>111</para>
                /// </summary>
                [NameInMap("defaultClassId")]
                [Validation(Required=false)]
                public long? DefaultClassId { get; set; }

                [NameInMap("deptIds")]
                [Validation(Required=false)]
                public List<long?> DeptIds { get; set; }

                [NameInMap("deptNameList")]
                [Validation(Required=false)]
                public List<string> DeptNameList { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("disableCheckWhenRest")]
                [Validation(Required=false)]
                public bool? DisableCheckWhenRest { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("disableCheckWithoutSchedule")]
                [Validation(Required=false)]
                public bool? DisableCheckWithoutSchedule { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("enableEmpSelectClass")]
                [Validation(Required=false)]
                public bool? EnableEmpSelectClass { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>240</para>
                /// </summary>
                [NameInMap("freeCheckDayStartMinOffset")]
                [Validation(Required=false)]
                public int? FreeCheckDayStartMinOffset { get; set; }

                [NameInMap("freecheckWorkDays")]
                [Validation(Required=false)]
                public List<int?> FreecheckWorkDays { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>20015047</para>
                /// </summary>
                [NameInMap("groupId")]
                [Validation(Required=false)]
                public long? GroupId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>固定排班</para>
                /// </summary>
                [NameInMap("groupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("isDefault")]
                [Validation(Required=false)]
                public bool? IsDefault { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1,2</para>
                /// </summary>
                [NameInMap("managerList")]
                [Validation(Required=false)]
                public List<string> ManagerList { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("memberCount")]
                [Validation(Required=false)]
                public int? MemberCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("ownerUserId")]
                [Validation(Required=false)]
                public string OwnerUserId { get; set; }

                [NameInMap("selectedClass")]
                [Validation(Required=false)]
                public List<GetSimpleGroupsResponseBodyResultGroupsSelectedClass> SelectedClass { get; set; }
                public class GetSimpleGroupsResponseBodyResultGroupsSelectedClass : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>20008010</para>
                    /// </summary>
                    [NameInMap("classId")]
                    [Validation(Required=false)]
                    public long? ClassId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>早班</para>
                    /// </summary>
                    [NameInMap("className")]
                    [Validation(Required=false)]
                    public string ClassName { get; set; }

                    [NameInMap("sections")]
                    [Validation(Required=false)]
                    public List<GetSimpleGroupsResponseBodyResultGroupsSelectedClassSections> Sections { get; set; }
                    public class GetSimpleGroupsResponseBodyResultGroupsSelectedClassSections : TeaModel {
                        [NameInMap("times")]
                        [Validation(Required=false)]
                        public List<GetSimpleGroupsResponseBodyResultGroupsSelectedClassSectionsTimes> Times { get; set; }
                        public class GetSimpleGroupsResponseBodyResultGroupsSelectedClassSectionsTimes : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>0</para>
                            /// </summary>
                            [NameInMap("across")]
                            [Validation(Required=false)]
                            public int? Across { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>1970-01-01T09:00Z</para>
                            /// </summary>
                            [NameInMap("checkTime")]
                            [Validation(Required=false)]
                            public string CheckTime { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>OnDuty</para>
                            /// </summary>
                            [NameInMap("checkType")]
                            [Validation(Required=false)]
                            public string CheckType { get; set; }

                        }

                    }

                    [NameInMap("setting")]
                    [Validation(Required=false)]
                    public GetSimpleGroupsResponseBodyResultGroupsSelectedClassSetting Setting { get; set; }
                    public class GetSimpleGroupsResponseBodyResultGroupsSelectedClassSetting : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>30</para>
                        /// </summary>
                        [NameInMap("absenteeismLateMinutes")]
                        [Validation(Required=false)]
                        public int? AbsenteeismLateMinutes { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("classSettingId")]
                        [Validation(Required=false)]
                        public long? ClassSettingId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>Y</para>
                        /// </summary>
                        [NameInMap("isOffDutyFreeCheck")]
                        [Validation(Required=false)]
                        public string IsOffDutyFreeCheck { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("permitLateMinutes")]
                        [Validation(Required=false)]
                        public int? PermitLateMinutes { get; set; }

                        [NameInMap("restTimeList")]
                        [Validation(Required=false)]
                        public List<GetSimpleGroupsResponseBodyResultGroupsSelectedClassSettingRestTimeList> RestTimeList { get; set; }
                        public class GetSimpleGroupsResponseBodyResultGroupsSelectedClassSettingRestTimeList : TeaModel {
                            [NameInMap("begin")]
                            [Validation(Required=false)]
                            public GetSimpleGroupsResponseBodyResultGroupsSelectedClassSettingRestTimeListBegin Begin { get; set; }
                            public class GetSimpleGroupsResponseBodyResultGroupsSelectedClassSettingRestTimeListBegin : TeaModel {
                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>0</para>
                                /// </summary>
                                [NameInMap("across")]
                                [Validation(Required=false)]
                                public int? Across { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>1970-01-01T12:00Z</para>
                                /// </summary>
                                [NameInMap("checkTime")]
                                [Validation(Required=false)]
                                public string CheckTime { get; set; }

                            }

                            [NameInMap("end")]
                            [Validation(Required=false)]
                            public GetSimpleGroupsResponseBodyResultGroupsSelectedClassSettingRestTimeListEnd End { get; set; }
                            public class GetSimpleGroupsResponseBodyResultGroupsSelectedClassSettingRestTimeListEnd : TeaModel {
                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>0</para>
                                /// </summary>
                                [NameInMap("across")]
                                [Validation(Required=false)]
                                public int? Across { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>1970-01-01T13:00Z</para>
                                /// </summary>
                                [NameInMap("checkTime")]
                                [Validation(Required=false)]
                                public string CheckTime { get; set; }

                            }

                        }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>20</para>
                        /// </summary>
                        [NameInMap("seriousLateMinutes")]
                        [Validation(Required=false)]
                        public int? SeriousLateMinutes { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>-1</para>
                        /// </summary>
                        [NameInMap("workTimeMinutes")]
                        [Validation(Required=false)]
                        public int? WorkTimeMinutes { get; set; }

                    }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>FIXED</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("userIds")]
                [Validation(Required=false)]
                public List<string> UserIds { get; set; }

                [NameInMap("workDayList")]
                [Validation(Required=false)]
                public List<string> WorkDayList { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("hasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

        }

    }

}
