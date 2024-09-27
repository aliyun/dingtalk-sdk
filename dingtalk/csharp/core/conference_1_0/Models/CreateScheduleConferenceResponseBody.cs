// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconference_1_0.Models
{
    public class CreateScheduleConferenceResponseBody : TeaModel {
        [NameInMap("phones")]
        [Validation(Required=false)]
        public List<string> Phones { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>838 722 xxxxx</para>
        /// </summary>
        [NameInMap("roomCode")]
        [Validation(Required=false)]
        public string RoomCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2a489c68-xxxx-xxxx-xxxx-xxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("scheduleConferenceId")]
        [Validation(Required=false)]
        public string ScheduleConferenceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://meeting.dingtalk.com/j/Bsbp3ixxxxxUyJJ9">https://meeting.dingtalk.com/j/Bsbp3ixxxxxUyJJ9</a></para>
        /// </summary>
        [NameInMap("url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
