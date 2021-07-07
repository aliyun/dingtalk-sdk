// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class QueryAllDoctorsResponseBody : TeaModel {
        /// <summary>
        /// 人员列表
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public List<QueryAllDoctorsResponseBodyContent> Content { get; set; }
        public class QueryAllDoctorsResponseBodyContent : TeaModel {
            /// <summary>
            /// 用户Id
            /// </summary>
            [NameInMap("uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

            /// <summary>
            /// 用户名称
            /// </summary>
            [NameInMap("userName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            /// <summary>
            /// 工号
            /// </summary>
            [NameInMap("jobNum")]
            [Validation(Required=false)]
            public string JobNum { get; set; }

        }

        /// <summary>
        /// 总页数
        /// </summary>
        [NameInMap("totalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

        /// <summary>
        /// 数据总量
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [NameInMap("currentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

    }

}
