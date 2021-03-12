// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class GetUserHolidaysRequest : TeaModel {
        /// <summary>
        /// 员工列表
        /// </summary>
        [NameInMap("userIds")]
        [Validation(Required=false)]
        public List<string> UserIds { get; set; }

        /// <summary>
        /// 开始日期
        /// </summary>
        [NameInMap("workDateFrom")]
        [Validation(Required=false)]
        public long? WorkDateFrom { get; set; }

        /// <summary>
        /// 结束日期
        /// </summary>
        [NameInMap("workDateTo")]
        [Validation(Required=false)]
        public long? WorkDateTo { get; set; }

    }

}
