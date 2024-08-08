// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class ShiftAddRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("sections")]
        [Validation(Required=false)]
        public List<ShiftAddRequestSections> Sections { get; set; }
        public class ShiftAddRequestSections : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("times")]
            [Validation(Required=false)]
            public List<ShiftAddRequestSectionsTimes> Times { get; set; }
            public class ShiftAddRequestSectionsTimes : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("across")]
                [Validation(Required=false)]
                public int? Across { get; set; }

                [NameInMap("beginMin")]
                [Validation(Required=false)]
                public int? BeginMin { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("checkTime")]
                [Validation(Required=false)]
                public long? CheckTime { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("checkType")]
                [Validation(Required=false)]
                public string CheckType { get; set; }

                [NameInMap("endMin")]
                [Validation(Required=false)]
                public int? EndMin { get; set; }

                [NameInMap("flexMinutes")]
                [Validation(Required=false)]
                public List<int?> FlexMinutes { get; set; }

                [NameInMap("freeCheck")]
                [Validation(Required=false)]
                public bool? FreeCheck { get; set; }

            }

        }

        [NameInMap("serviceId")]
        [Validation(Required=false)]
        public long? ServiceId { get; set; }

        [NameInMap("setting")]
        [Validation(Required=false)]
        public ShiftAddRequestSetting Setting { get; set; }
        public class ShiftAddRequestSetting : TeaModel {
            [NameInMap("absenteeismLateMinutes")]
            [Validation(Required=false)]
            public int? AbsenteeismLateMinutes { get; set; }

            [NameInMap("attendDays")]
            [Validation(Required=false)]
            public double? AttendDays { get; set; }

            [NameInMap("demandWorkTimeMinutes")]
            [Validation(Required=false)]
            public int? DemandWorkTimeMinutes { get; set; }

            [NameInMap("enableOutsideLateBack")]
            [Validation(Required=false)]
            public bool? EnableOutsideLateBack { get; set; }

            [NameInMap("extras")]
            [Validation(Required=false)]
            public Dictionary<string, object> Extras { get; set; }

            [NameInMap("isFlexible")]
            [Validation(Required=false)]
            public bool? IsFlexible { get; set; }

            [NameInMap("lateBackSetting")]
            [Validation(Required=false)]
            public ShiftAddRequestSettingLateBackSetting LateBackSetting { get; set; }
            public class ShiftAddRequestSettingLateBackSetting : TeaModel {
                [NameInMap("enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                [NameInMap("sections")]
                [Validation(Required=false)]
                public List<ShiftAddRequestSettingLateBackSettingSections> Sections { get; set; }
                public class ShiftAddRequestSettingLateBackSettingSections : TeaModel {
                    [NameInMap("extra")]
                    [Validation(Required=false)]
                    public int? Extra { get; set; }

                    [NameInMap("late")]
                    [Validation(Required=false)]
                    public int? Late { get; set; }

                }

            }

            [NameInMap("seriousLateMinutes")]
            [Validation(Required=false)]
            public int? SeriousLateMinutes { get; set; }

            [NameInMap("tags")]
            [Validation(Required=false)]
            public string Tags { get; set; }

            [NameInMap("topRestTimeList")]
            [Validation(Required=false)]
            public List<ShiftAddRequestSettingTopRestTimeList> TopRestTimeList { get; set; }
            public class ShiftAddRequestSettingTopRestTimeList : TeaModel {
                [NameInMap("across")]
                [Validation(Required=false)]
                public int? Across { get; set; }

                [NameInMap("checkTime")]
                [Validation(Required=false)]
                public long? CheckTime { get; set; }

                [NameInMap("checkType")]
                [Validation(Required=false)]
                public string CheckType { get; set; }

            }

        }

        [NameInMap("shiftId")]
        [Validation(Required=false)]
        public long? ShiftId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
