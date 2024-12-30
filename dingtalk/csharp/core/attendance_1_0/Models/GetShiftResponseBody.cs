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
            /// <summary>
            /// <b>Example:</b>
            /// <para>dinge87f1xxxx</para>
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>678215070</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>B</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>user123</para>
            /// </summary>
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

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("across")]
                    [Validation(Required=false)]
                    public long? Across { get; set; }

                    [NameInMap("beginMin")]
                    [Validation(Required=false)]
                    public long? BeginMin { get; set; }

                    /// <summary>
                    /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1970-01-01 19:00:00</para>
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

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>-1</para>
                    /// </summary>
                    [NameInMap("endMin")]
                    [Validation(Required=false)]
                    public long? EndMin { get; set; }

                    [NameInMap("flexMinutes")]
                    [Validation(Required=false)]
                    public List<long?> FlexMinutes { get; set; }

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

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("permitMinutes")]
                    [Validation(Required=false)]
                    public long? PermitMinutes { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>33928201</para>
                    /// </summary>
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

                    /// <summary>
                    /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
                    /// </summary>
                    [NameInMap("checkTime")]
                    [Validation(Required=false)]
                    public string CheckTime { get; set; }

                    [NameInMap("checkType")]
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>考勤班</para>
            /// </summary>
            [NameInMap("shiftGroupName")]
            [Validation(Required=false)]
            public string ShiftGroupName { get; set; }

            [NameInMap("shiftSetting")]
            [Validation(Required=false)]
            public GetShiftResponseBodyResultShiftSetting ShiftSetting { get; set; }
            public class GetShiftResponseBodyResultShiftSetting : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("attendDays")]
                [Validation(Required=false)]
                public string AttendDays { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>dinge87f1xxxx</para>
                /// </summary>
                [NameInMap("corpId")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                /// <summary>
                /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-09-06 15:49:27</para>
                /// </summary>
                [NameInMap("gmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-09-06 15:49:27</para>
                /// </summary>
                [NameInMap("gmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>678215070</para>
                /// </summary>
                [NameInMap("shiftId")]
                [Validation(Required=false)]
                public long? ShiftId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>233840112</para>
                /// </summary>
                [NameInMap("shiftSettingId")]
                [Validation(Required=false)]
                public long? ShiftSettingId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>NORMAL</para>
                /// </summary>
                [NameInMap("shiftType")]
                [Validation(Required=false)]
                public string ShiftType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>600</para>
                /// </summary>
                [NameInMap("workTimeMinutes")]
                [Validation(Required=false)]
                public long? WorkTimeMinutes { get; set; }

            }

        }

    }

}
