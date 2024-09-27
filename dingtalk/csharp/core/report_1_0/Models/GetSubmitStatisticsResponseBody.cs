// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkreport_1_0.Models
{
    public class GetSubmitStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("shouldRemindTimes")]
        [Validation(Required=false)]
        public int? ShouldRemindTimes { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>日报</para>
        /// </summary>
        [NameInMap("templateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        [NameInMap("userDeptMap")]
        [Validation(Required=false)]
        public Dictionary<string, string> UserDeptMap { get; set; }

        [NameInMap("userIdCountMap")]
        [Validation(Required=false)]
        public Dictionary<string, long?> UserIdCountMap { get; set; }

        [NameInMap("userIdStatusMap")]
        [Validation(Required=false)]
        public Dictionary<string, Dictionary<string, object>> UserIdStatusMap { get; set; }

        [NameInMap("userIds")]
        [Validation(Required=false)]
        public List<string> UserIds { get; set; }

        [NameInMap("userMap")]
        [Validation(Required=false)]
        public Dictionary<string, UserMapValue> UserMap { get; set; }

    }

}
