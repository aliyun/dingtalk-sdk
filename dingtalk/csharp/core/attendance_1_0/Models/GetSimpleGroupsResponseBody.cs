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
            [NameInMap("groups")]
            [Validation(Required=false)]
            public List<GetSimpleGroupsResponseBodyResultGroups> Groups { get; set; }
            public class GetSimpleGroupsResponseBodyResultGroups : TeaModel {
                [NameInMap("classesList")]
                [Validation(Required=false)]
                public List<string> ClassesList { get; set; }

                [NameInMap("defaultClassId")]
                [Validation(Required=false)]
                public long? DefaultClassId { get; set; }

                [NameInMap("deptIds")]
                [Validation(Required=false)]
                public List<long?> DeptIds { get; set; }

                [NameInMap("deptNameList")]
                [Validation(Required=false)]
                public List<string> DeptNameList { get; set; }

                [NameInMap("disableCheckWhenRest")]
                [Validation(Required=false)]
                public bool? DisableCheckWhenRest { get; set; }

                [NameInMap("disableCheckWithoutSchedule")]
                [Validation(Required=false)]
                public bool? DisableCheckWithoutSchedule { get; set; }

                [NameInMap("enableEmpSelectClass")]
                [Validation(Required=false)]
                public bool? EnableEmpSelectClass { get; set; }

                [NameInMap("freeCheckDayStartMinOffset")]
                [Validation(Required=false)]
                public int? FreeCheckDayStartMinOffset { get; set; }

                [NameInMap("freecheckWorkDays")]
                [Validation(Required=false)]
                public List<int?> FreecheckWorkDays { get; set; }

                [NameInMap("groupId")]
                [Validation(Required=false)]
                public long? GroupId { get; set; }

                [NameInMap("groupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                [NameInMap("isDefault")]
                [Validation(Required=false)]
                public bool? IsDefault { get; set; }

                [NameInMap("managerList")]
                [Validation(Required=false)]
                public List<string> ManagerList { get; set; }

                [NameInMap("memberCount")]
                [Validation(Required=false)]
                public int? MemberCount { get; set; }

                [NameInMap("ownerUserId")]
                [Validation(Required=false)]
                public string OwnerUserId { get; set; }

                [NameInMap("selectedClass")]
                [Validation(Required=false)]
                public List<GetSimpleGroupsResponseBodyResultGroupsSelectedClass> SelectedClass { get; set; }
                public class GetSimpleGroupsResponseBodyResultGroupsSelectedClass : TeaModel {
                    [NameInMap("classId")]
                    [Validation(Required=false)]
                    public long? ClassId { get; set; }

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
                            [NameInMap("across")]
                            [Validation(Required=false)]
                            public int? Across { get; set; }

                            [NameInMap("checkTime")]
                            [Validation(Required=false)]
                            public string CheckTime { get; set; }

                            [NameInMap("checkType")]
                            [Validation(Required=false)]
                            public string CheckType { get; set; }

                        }

                    }

                    [NameInMap("setting")]
                    [Validation(Required=false)]
                    public GetSimpleGroupsResponseBodyResultGroupsSelectedClassSetting Setting { get; set; }
                    public class GetSimpleGroupsResponseBodyResultGroupsSelectedClassSetting : TeaModel {
                        [NameInMap("absenteeismLateMinutes")]
                        [Validation(Required=false)]
                        public int? AbsenteeismLateMinutes { get; set; }

                        [NameInMap("classSettingId")]
                        [Validation(Required=false)]
                        public long? ClassSettingId { get; set; }

                        [NameInMap("isOffDutyFreeCheck")]
                        [Validation(Required=false)]
                        public string IsOffDutyFreeCheck { get; set; }

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
                                [NameInMap("across")]
                                [Validation(Required=false)]
                                public int? Across { get; set; }

                                [NameInMap("checkTime")]
                                [Validation(Required=false)]
                                public string CheckTime { get; set; }

                            }

                            [NameInMap("end")]
                            [Validation(Required=false)]
                            public GetSimpleGroupsResponseBodyResultGroupsSelectedClassSettingRestTimeListEnd End { get; set; }
                            public class GetSimpleGroupsResponseBodyResultGroupsSelectedClassSettingRestTimeListEnd : TeaModel {
                                [NameInMap("across")]
                                [Validation(Required=false)]
                                public int? Across { get; set; }

                                [NameInMap("checkTime")]
                                [Validation(Required=false)]
                                public string CheckTime { get; set; }

                            }

                        }

                        [NameInMap("seriousLateMinutes")]
                        [Validation(Required=false)]
                        public int? SeriousLateMinutes { get; set; }

                        [NameInMap("workTimeMinutes")]
                        [Validation(Required=false)]
                        public int? WorkTimeMinutes { get; set; }

                    }

                }

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

            [NameInMap("hasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

        }

    }

}
