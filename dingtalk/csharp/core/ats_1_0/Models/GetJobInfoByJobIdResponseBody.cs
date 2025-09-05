// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkats_1_0.Models
{
    public class GetJobInfoByJobIdResponseBody : TeaModel {
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        [NameInMap("headCount")]
        [Validation(Required=false)]
        public long? HeadCount { get; set; }

        [NameInMap("jobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        [NameInMap("jobOwners")]
        [Validation(Required=false)]
        public List<GetJobInfoByJobIdResponseBodyJobOwners> JobOwners { get; set; }
        public class GetJobInfoByJobIdResponseBodyJobOwners : TeaModel {
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("mainDeptId")]
        [Validation(Required=false)]
        public long? MainDeptId { get; set; }

        [NameInMap("mainDeptName")]
        [Validation(Required=false)]
        public string MainDeptName { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
