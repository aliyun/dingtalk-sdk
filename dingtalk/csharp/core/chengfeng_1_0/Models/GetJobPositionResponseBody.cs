// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkchengfeng_1_0.Models
{
    public class GetJobPositionResponseBody : TeaModel {
        /// <summary>
        /// 职位详情
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public GetJobPositionResponseBodyContent Content { get; set; }
        public class GetJobPositionResponseBodyContent : TeaModel {
            /// <summary>
            /// 职责描述
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// 创建时间
            /// </summary>
            [NameInMap("establishDate")]
            [Validation(Required=false)]
            public string EstablishDate { get; set; }

            /// <summary>
            /// 职位编码
            /// </summary>
            [NameInMap("jobCode")]
            [Validation(Required=false)]
            public string JobCode { get; set; }

            /// <summary>
            /// 任职要求
            /// </summary>
            [NameInMap("jobRequirements")]
            [Validation(Required=false)]
            public string JobRequirements { get; set; }

            /// <summary>
            /// 职位名称
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 生效时间
            /// </summary>
            [NameInMap("startDate")]
            [Validation(Required=false)]
            public string StartDate { get; set; }

            /// <summary>
            /// 失效时间
            /// </summary>
            [NameInMap("stopDate")]
            [Validation(Required=false)]
            public string StopDate { get; set; }

        }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
