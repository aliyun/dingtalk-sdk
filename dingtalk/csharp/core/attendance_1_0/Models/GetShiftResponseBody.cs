// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class GetShiftResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetShiftResponseBodyResult Result { get; set; }
        public class GetShiftResponseBodyResult : TeaModel {
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            [NameInMap("sections")]
            [Validation(Required=false)]
            public List<GetShiftResponseBodyResultSections> Sections { get; set; }
            public class GetShiftResponseBodyResultSections : TeaModel {
                [NameInMap("punches")]
                [Validation(Required=false)]
                public List<GetShiftResponseBodyResultSectionsPunches> Punches { get; set; }
                public class GetShiftResponseBodyResultSectionsPunches : TeaModel {
                    [NameInMap("absenteeismLateMinutes")]
                    [Validation(Required=false)]
                    public long? AbsenteeismLateMinutes { get; set; }

                    [NameInMap("across")]
                    [Validation(Required=false)]
                    public long? Across { get; set; }

                    [NameInMap("beginMin")]
                    [Validation(Required=false)]
                    public long? BeginMin { get; set; }

                    [NameInMap("checkTime")]
                    [Validation(Required=false)]
                    public string CheckTime { get; set; }

                    [NameInMap("checkType")]
                    [Validation(Required=false)]
                    public string CheckType { get; set; }

                    [NameInMap("end_min")]
                    [Validation(Required=false)]
                    public long? EndMin { get; set; }

                    [NameInMap("freeCheck")]
                    [Validation(Required=false)]
                    public bool? FreeCheck { get; set; }

                    [NameInMap("lateBackSetting")]
                    [Validation(Required=false)]
                    public GetShiftResponseBodyResultSectionsPunchesLateBackSetting LateBackSetting { get; set; }
                    public class GetShiftResponseBodyResultSectionsPunchesLateBackSetting : TeaModel {
                        [NameInMap("lateBackPairs")]
                        [Validation(Required=false)]
                        public List<GetShiftResponseBodyResultSectionsPunchesLateBackSettingLateBackPairs> LateBackPairs { get; set; }
                        public class GetShiftResponseBodyResultSectionsPunchesLateBackSettingLateBackPairs : TeaModel {
                            [NameInMap("extra")]
                            [Validation(Required=false)]
                            public long? Extra { get; set; }

                            [NameInMap("late")]
                            [Validation(Required=false)]
                            public long? Late { get; set; }

                        }

                    }

                    [NameInMap("permitMinutes")]
                    [Validation(Required=false)]
                    public long? PermitMinutes { get; set; }

                    [NameInMap("puncheId")]
                    [Validation(Required=false)]
                    public long? PuncheId { get; set; }

                    [NameInMap("seriousLateMinutes")]
                    [Validation(Required=false)]
                    public long? SeriousLateMinutes { get; set; }

                }

                [NameInMap("rests")]
                [Validation(Required=false)]
                public List<GetShiftResponseBodyResultSectionsRests> Rests { get; set; }
                public class GetShiftResponseBodyResultSectionsRests : TeaModel {
                    [NameInMap("across")]
                    [Validation(Required=false)]
                    public long? Across { get; set; }

                    [NameInMap("checkTime")]
                    [Validation(Required=false)]
                    public string CheckTime { get; set; }

                    [NameInMap("check_type")]
                    [Validation(Required=false)]
                    public string CheckType { get; set; }

                    [NameInMap("restId")]
                    [Validation(Required=false)]
                    public long? RestId { get; set; }

                }

                [NameInMap("sectionId")]
                [Validation(Required=false)]
                public long? SectionId { get; set; }

            }

            [NameInMap("shiftGroupId")]
            [Validation(Required=false)]
            public long? ShiftGroupId { get; set; }

            [NameInMap("shiftGroupName")]
            [Validation(Required=false)]
            public string ShiftGroupName { get; set; }

            [NameInMap("shiftSetting")]
            [Validation(Required=false)]
            public GetShiftResponseBodyResultShiftSetting ShiftSetting { get; set; }
            public class GetShiftResponseBodyResultShiftSetting : TeaModel {
                [NameInMap("attendDays")]
                [Validation(Required=false)]
                public string AttendDays { get; set; }

                [NameInMap("corpId")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                [NameInMap("gmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("gmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                [NameInMap("shiftId")]
                [Validation(Required=false)]
                public long? ShiftId { get; set; }

                [NameInMap("shiftSettingId")]
                [Validation(Required=false)]
                public long? ShiftSettingId { get; set; }

                [NameInMap("workTimeMinutes")]
                [Validation(Required=false)]
                public long? WorkTimeMinutes { get; set; }

            }

        }

    }

}
