// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetCalenderSummaryResponseBody : TeaModel {
        [NameInMap("calendarCreateUserCnt")]
        [Validation(Required=false)]
        public string CalendarCreateUserCnt { get; set; }

        [NameInMap("recvCalendarUserCnt1d")]
        [Validation(Required=false)]
        public string RecvCalendarUserCnt1d { get; set; }

        [NameInMap("useCalendarUserCnt1d")]
        [Validation(Required=false)]
        public string UseCalendarUserCnt1d { get; set; }

    }

}
