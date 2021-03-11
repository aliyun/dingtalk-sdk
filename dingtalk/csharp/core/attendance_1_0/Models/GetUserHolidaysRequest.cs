// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class GetUserHolidaysRequest : TeaModel {
        /// <summary>
        /// 查询对象
        /// </summary>
        [NameInMap("topHolidayQueryParam")]
        [Validation(Required=false)]
        public GetUserHolidaysRequestTopHolidayQueryParam TopHolidayQueryParam { get; set; }
        public class GetUserHolidaysRequestTopHolidayQueryParam : TeaModel {
            [NameInMap("userIds")]
            [Validation(Required=false)]
            public List<string> UserIds { get; set; }
            [NameInMap("workDateFrom")]
            [Validation(Required=false)]
            public long? WorkDateFrom { get; set; }
            [NameInMap("workDateTo")]
            [Validation(Required=false)]
            public long? WorkDateTo { get; set; }
        };

    }

}
