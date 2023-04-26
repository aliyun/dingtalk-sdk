/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class ResultDurationSettingsValue : TeaModel {
        [NameInMap("calcType")]
        [Validation(Required=false)]
        public int? CalcType { get; set; }

        [NameInMap("durationType")]
        [Validation(Required=false)]
        public int? DurationType { get; set; }

        [NameInMap("overtimeRedress")]
        [Validation(Required=false)]
        public bool? OvertimeRedress { get; set; }

        [NameInMap("settings")]
        [Validation(Required=false)]
        public Dictionary<string, object> Settings { get; set; }

        [NameInMap("overtimeRedressBy")]
        [Validation(Required=false)]
        public string OvertimeRedressBy { get; set; }

        [NameInMap("vacationRate")]
        [Validation(Required=false)]
        public float? VacationRate { get; set; }

        [NameInMap("skipTime")]
        [Validation(Required=false)]
        public string SkipTime { get; set; }

        [NameInMap("skipTimeByFrames")]
        [Validation(Required=false)]
        public List<ResultDurationSettingsValueSkipTimeByFrames> SkipTimeByFrames { get; set; }
        public class ResultDurationSettingsValueSkipTimeByFrames : TeaModel {
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("endTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("valid")]
            [Validation(Required=false)]
            public bool? Valid { get; set; }

        }

        [NameInMap("skipTimeByDurations")]
        [Validation(Required=false)]
        public List<ResultDurationSettingsValueSkipTimeByDurations> SkipTimeByDurations { get; set; }
        public class ResultDurationSettingsValueSkipTimeByDurations : TeaModel {
            [NameInMap("duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            [NameInMap("minus")]
            [Validation(Required=false)]
            public long? Minus { get; set; }

        }

        [NameInMap("holidayPlanOvertimeRedress")]
        [Validation(Required=false)]
        public bool? HolidayPlanOvertimeRedress { get; set; }

        [NameInMap("holidayPlanOvertimeRedressBy")]
        [Validation(Required=false)]
        public string HolidayPlanOvertimeRedressBy { get; set; }

        [NameInMap("holidayPlanVacationRate")]
        [Validation(Required=false)]
        public float? HolidayPlanVacationRate { get; set; }

    }

}
