// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class GetOvertimeSettingResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetOvertimeSettingResponseBodyResult> Result { get; set; }
        public class GetOvertimeSettingResponseBodyResult : TeaModel {
            [NameInMap("default")]
            [Validation(Required=false)]
            public bool? Default { get; set; }

            [NameInMap("durationSettings")]
            [Validation(Required=false)]
            public Dictionary<string, ResultDurationSettingsValue> DurationSettings { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("overtimeDivisions")]
            [Validation(Required=false)]
            public List<GetOvertimeSettingResponseBodyResultOvertimeDivisions> OvertimeDivisions { get; set; }
            public class GetOvertimeSettingResponseBodyResultOvertimeDivisions : TeaModel {
                [NameInMap("nextDayType")]
                [Validation(Required=false)]
                public string NextDayType { get; set; }

                [NameInMap("previousDayType")]
                [Validation(Required=false)]
                public string PreviousDayType { get; set; }

                [NameInMap("timeSplitPoint")]
                [Validation(Required=false)]
                public string TimeSplitPoint { get; set; }

            }

            [NameInMap("settingId")]
            [Validation(Required=false)]
            public long? SettingId { get; set; }

            [NameInMap("stepType")]
            [Validation(Required=false)]
            public int? StepType { get; set; }

            [NameInMap("stepValue")]
            [Validation(Required=false)]
            public float? StepValue { get; set; }

            [NameInMap("warningSettings")]
            [Validation(Required=false)]
            public List<GetOvertimeSettingResponseBodyResultWarningSettings> WarningSettings { get; set; }
            public class GetOvertimeSettingResponseBodyResultWarningSettings : TeaModel {
                [NameInMap("action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                [NameInMap("threshold")]
                [Validation(Required=false)]
                public long? Threshold { get; set; }

                [NameInMap("time")]
                [Validation(Required=false)]
                public string Time { get; set; }

            }

            [NameInMap("workMinutesPerDay")]
            [Validation(Required=false)]
            public int? WorkMinutesPerDay { get; set; }

        }

    }

}
