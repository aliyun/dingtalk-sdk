// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkats_1_0.Models
{
    public class GetJobAuthResponseBody : TeaModel {
        /// <summary>
        /// 职位ID
        /// </summary>
        [NameInMap("jobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// 职位负责人
        /// </summary>
        [NameInMap("jobOwners")]
        [Validation(Required=false)]
        public List<GetJobAuthResponseBodyJobOwners> JobOwners { get; set; }
        public class GetJobAuthResponseBodyJobOwners : TeaModel {
            /// <summary>
            /// 员工姓名
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 员工标识
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
