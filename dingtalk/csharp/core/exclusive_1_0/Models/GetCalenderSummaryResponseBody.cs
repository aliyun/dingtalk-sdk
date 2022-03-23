// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetCalenderSummaryResponseBody : TeaModel {
        /// <summary>
        /// 最近1天创建日程人数
        /// </summary>
        [NameInMap("calendarCreateUserCnt")]
        [Validation(Required=false)]
        public string CalendarCreateUserCnt { get; set; }

        /// <summary>
        /// 最近1天接收日程人数
        /// </summary>
        [NameInMap("recvCalendarUserCnt1d")]
        [Validation(Required=false)]
        public string RecvCalendarUserCnt1d { get; set; }

        /// <summary>
        /// 最近1天使用日程人数
        /// </summary>
        [NameInMap("useCalendarUserCnt1d")]
        [Validation(Required=false)]
        public string UseCalendarUserCnt1d { get; set; }

    }

}
