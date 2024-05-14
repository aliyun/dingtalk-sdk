// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class GetUserHolidaysRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("userIds")]
        [Validation(Required=false)]
        public List<string> UserIds { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("workDateFrom")]
        [Validation(Required=false)]
        public long? WorkDateFrom { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("workDateTo")]
        [Validation(Required=false)]
        public long? WorkDateTo { get; set; }

    }

}
