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
            /// <summary>
            /// 设置id
            /// </summary>
            [NameInMap("settingId")]
            [Validation(Required=false)]
            public long? SettingId { get; set; }

            /// <summary>
            /// 规则名称
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 是否默认
            /// </summary>
            [NameInMap("default")]
            [Validation(Required=false)]
            public bool? Default { get; set; }

            [NameInMap("durationSettings")]
            [Validation(Required=false)]
            public Dictionary<string, ResultDurationSettingsValue> DurationSettings { get; set; }

            [NameInMap("warningSettings")]
            [Validation(Required=false)]
            public List<GetOvertimeSettingResponseBodyResultWarningSettings> WarningSettings { get; set; }
            public class GetOvertimeSettingResponseBodyResultWarningSettings : TeaModel {
                /// <summary>
                /// 预警类型
                /// </summary>
                [NameInMap("time")]
                [Validation(Required=false)]
                public string Time { get; set; }

                /// <summary>
                /// 提醒阈值
                /// </summary>
                [NameInMap("threshold")]
                [Validation(Required=false)]
                public long? Threshold { get; set; }

                /// <summary>
                /// 风险预警 或 最大加班时间
                /// </summary>
                [NameInMap("action")]
                [Validation(Required=false)]
                public string Action { get; set; }

            }

            /// <summary>
            /// 加班时长单位
            /// </summary>
            [NameInMap("stepType")]
            [Validation(Required=false)]
            public int? StepType { get; set; }

            /// <summary>
            /// 加班时长是否取整 单位 小时
            /// </summary>
            [NameInMap("stepValue")]
            [Validation(Required=false)]
            public float? StepValue { get; set; }

            /// <summary>
            /// 日折算时长 单位：分钟
            /// </summary>
            [NameInMap("workMinutesPerDay")]
            [Validation(Required=false)]
            public int? WorkMinutesPerDay { get; set; }

            /// <summary>
            /// 时间分割规则
            /// </summary>
            [NameInMap("overtimeDivisions")]
            [Validation(Required=false)]
            public List<GetOvertimeSettingResponseBodyResultOvertimeDivisions> OvertimeDivisions { get; set; }
            public class GetOvertimeSettingResponseBodyResultOvertimeDivisions : TeaModel {
                /// <summary>
                /// 前一日类型
                /// </summary>
                [NameInMap("previousDayType")]
                [Validation(Required=false)]
                public string PreviousDayType { get; set; }

                /// <summary>
                /// 后一日类型
                /// </summary>
                [NameInMap("nextDayType")]
                [Validation(Required=false)]
                public string NextDayType { get; set; }

                /// <summary>
                /// 分割时间点
                /// </summary>
                [NameInMap("timeSplitPoint")]
                [Validation(Required=false)]
                public string TimeSplitPoint { get; set; }

            }

            /// <summary>
            /// 历史加班规则设置id
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

        }

    }

}
