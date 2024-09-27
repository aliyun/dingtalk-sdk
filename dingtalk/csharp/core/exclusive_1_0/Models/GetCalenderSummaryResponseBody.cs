// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetCalenderSummaryResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("calendarCreateUserCnt")]
        [Validation(Required=false)]
        public string CalendarCreateUserCnt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("recvCalendarUserCnt1d")]
        [Validation(Required=false)]
        public string RecvCalendarUserCnt1d { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("useCalendarUserCnt1d")]
        [Validation(Required=false)]
        public string UseCalendarUserCnt1d { get; set; }

    }

}
