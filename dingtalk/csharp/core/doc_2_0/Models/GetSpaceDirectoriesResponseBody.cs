// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class GetSpaceDirectoriesResponseBody : TeaModel {
        /// <summary>
        /// 子节点列表。
        /// </summary>
        [NameInMap("children")]
        [Validation(Required=false)]
        public List<DentryOpenVO> Children { get; set; }

        /// <summary>
        /// 是否还有后续可查询子节点。
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// 分页token。
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
