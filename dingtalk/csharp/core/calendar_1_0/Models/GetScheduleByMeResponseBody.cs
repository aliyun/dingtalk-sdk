// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcalendar_1_0.Models
{
    public class GetScheduleByMeResponseBody : TeaModel {
        [NameInMap("scheduleInformation")]
        [Validation(Required=false)]
        public List<GetScheduleByMeResponseBodyScheduleInformation> ScheduleInformation { get; set; }
        public class GetScheduleByMeResponseBodyScheduleInformation : TeaModel {
            [NameInMap("error")]
            [Validation(Required=false)]
            public string Error { get; set; }

            [NameInMap("scheduleItems")]
            [Validation(Required=false)]
            public List<GetScheduleByMeResponseBodyScheduleInformationScheduleItems> ScheduleItems { get; set; }
            public class GetScheduleByMeResponseBodyScheduleInformationScheduleItems : TeaModel {
                [NameInMap("end")]
                [Validation(Required=false)]
                public GetScheduleByMeResponseBodyScheduleInformationScheduleItemsEnd End { get; set; }
                public class GetScheduleByMeResponseBodyScheduleInformationScheduleItemsEnd : TeaModel {
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
                public GetScheduleByMeResponseBodyScheduleInformationScheduleItemsStart Start { get; set; }
                public class GetScheduleByMeResponseBodyScheduleInformationScheduleItemsStart : TeaModel {
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
