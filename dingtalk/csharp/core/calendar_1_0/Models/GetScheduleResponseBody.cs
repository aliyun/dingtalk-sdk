// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcalendar_1_0.Models
{
    public class GetScheduleResponseBody : TeaModel {
        [NameInMap("scheduleInformation")]
        [Validation(Required=false)]
        public List<GetScheduleResponseBodyScheduleInformation> ScheduleInformation { get; set; }
        public class GetScheduleResponseBodyScheduleInformation : TeaModel {
            [NameInMap("error")]
            [Validation(Required=false)]
            public string Error { get; set; }

            [NameInMap("scheduleItems")]
            [Validation(Required=false)]
            public List<GetScheduleResponseBodyScheduleInformationScheduleItems> ScheduleItems { get; set; }
            public class GetScheduleResponseBodyScheduleInformationScheduleItems : TeaModel {
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

                }

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

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>BUSY</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
