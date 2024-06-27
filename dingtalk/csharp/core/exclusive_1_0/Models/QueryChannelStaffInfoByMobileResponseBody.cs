// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class QueryChannelStaffInfoByMobileResponseBody : TeaModel {
        [NameInMap("empInfo")]
        [Validation(Required=false)]
        public QueryChannelStaffInfoByMobileResponseBodyEmpInfo EmpInfo { get; set; }
        public class QueryChannelStaffInfoByMobileResponseBodyEmpInfo : TeaModel {
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("exclusiveAccountEmpInfoList")]
        [Validation(Required=false)]
        public List<QueryChannelStaffInfoByMobileResponseBodyExclusiveAccountEmpInfoList> ExclusiveAccountEmpInfoList { get; set; }
        public class QueryChannelStaffInfoByMobileResponseBodyExclusiveAccountEmpInfoList : TeaModel {
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
