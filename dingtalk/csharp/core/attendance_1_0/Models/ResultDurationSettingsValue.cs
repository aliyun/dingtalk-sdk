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

        /// <summary>
        /// 加班时长计为调休或加班费开关
        /// </summary>
        [NameInMap("overtimeRedress")]
        [Validation(Required=false)]
        public bool? OvertimeRedress { get; set; }

        /// <summary>
        /// 加班开始时间 或 最小加班时间
        /// </summary>
        [NameInMap("settings")]
        [Validation(Required=false)]
        public Dictionary<string, object> Settings { get; set; }

        /// <summary>
        /// 加班时长计为方式
        /// </summary>
        [NameInMap("overtimeRedressBy")]
        [Validation(Required=false)]
        public string OvertimeRedressBy { get; set; }

        /// <summary>
        /// 调休时长计算
        /// </summary>
        [NameInMap("vacationRate")]
        [Validation(Required=false)]
        public float? VacationRate { get; set; }

        /// <summary>
        /// 扣除休息时间
        /// </summary>
        [NameInMap("skipTime")]
        [Validation(Required=false)]
        public string SkipTime { get; set; }

        /// <summary>
        /// 休息时段
        /// </summary>
        [NameInMap("skipTimeByFrames")]
        [Validation(Required=false)]
        public List<ResultDurationSettingsValueSkipTimeByFrames> SkipTimeByFrames { get; set; }
        public class ResultDurationSettingsValueSkipTimeByFrames : TeaModel {
            /// <summary>
            /// 开始时间，格式为"HH:mm"
            /// </summary>
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// 结束时间，格式为"HH:mm"
            /// </summary>
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// 是否生效
            /// </summary>
            [NameInMap("valid")]
            [Validation(Required=false)]
            public bool? Valid { get; set; }

        }

        /// <summary>
        /// 加班时长
        /// </summary>
        [NameInMap("skipTimeByDurations")]
        [Validation(Required=false)]
        public List<ResultDurationSettingsValueSkipTimeByDurations> SkipTimeByDurations { get; set; }
        public class ResultDurationSettingsValueSkipTimeByDurations : TeaModel {
            /// <summary>
            /// 每天加班满 x小时，单位 秒
            /// </summary>
            [NameInMap("duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// 扣除 x小时，单位 秒
            /// </summary>
            [NameInMap("minus")]
            [Validation(Required=false)]
            public long? Minus { get; set; }

        }

        /// <summary>
        /// 休息日或节假日排班加班时长计为调休或加班费开关
        /// </summary>
        [NameInMap("holidayPlanOvertimeRedress")]
        [Validation(Required=false)]
        public bool? HolidayPlanOvertimeRedress { get; set; }

        /// <summary>
        /// 休息日或节假日排班加班时长计为方式
        /// </summary>
        [NameInMap("holidayPlanOvertimeRedressBy")]
        [Validation(Required=false)]
        public string HolidayPlanOvertimeRedressBy { get; set; }

        /// <summary>
        /// 休息日或节假日排班调休时长计算
        /// </summary>
        [NameInMap("holidayPlanVacationRate")]
        [Validation(Required=false)]
        public float? HolidayPlanVacationRate { get; set; }

    }

}
