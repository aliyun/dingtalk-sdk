// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcalendar_1_0.Models
{
    public class GetScheduleResponseBody : TeaModel {
        /// <summary>
        /// 闲忙信息
        /// </summary>
        [NameInMap("scheduleInformation")]
        [Validation(Required=false)]
        public List<GetScheduleResponseBodyScheduleInformation> ScheduleInformation { get; set; }
        public class GetScheduleResponseBodyScheduleInformation : TeaModel {
            /// <summary>
            /// 用户userId
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// 异常描述
            /// </summary>
            [NameInMap("error")]
            [Validation(Required=false)]
            public string Error { get; set; }

            [NameInMap("scheduleItems")]
            [Validation(Required=false)]
            public List<GetScheduleResponseBodyScheduleInformationScheduleItems> ScheduleItems { get; set; }
            public class GetScheduleResponseBodyScheduleInformationScheduleItems : TeaModel {
                /// <summary>
                /// 状态: - BUSY：繁忙, - TENTATIVE：暂定繁忙
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// 开始时间，表示一个日期，或者一个带时区的时间戳
                /// </summary>
                [NameInMap("start")]
                [Validation(Required=false)]
                public GetScheduleResponseBodyScheduleInformationScheduleItemsStart Start { get; set; }
                public class GetScheduleResponseBodyScheduleInformationScheduleItemsStart : TeaModel {
                    [NameInMap("date")]
                    [Validation(Required=false)]
                    public string Date { get; set; }
                    [NameInMap("dateTime")]
                    [Validation(Required=false)]
                    public string DateTime { get; set; }
                    [NameInMap("timeZone")]
                    [Validation(Required=false)]
                    public string TimeZone { get; set; }
                };

                /// <summary>
                /// 结束时间，表示一个日期，或者一个带时区的时间戳
                /// </summary>
                [NameInMap("end")]
                [Validation(Required=false)]
                public GetScheduleResponseBodyScheduleInformationScheduleItemsEnd End { get; set; }
                public class GetScheduleResponseBodyScheduleInformationScheduleItemsEnd : TeaModel {
                    [NameInMap("date")]
                    [Validation(Required=false)]
                    public string Date { get; set; }
                    [NameInMap("dateTime")]
                    [Validation(Required=false)]
                    public string DateTime { get; set; }
                    [NameInMap("timeZone")]
                    [Validation(Required=false)]
                    public string TimeZone { get; set; }
                };

            }

        }

    }

}
