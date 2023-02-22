// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class SearchTaskflowStatusRequest : TeaModel {
        /// <summary>
        /// 每页返回最大数量。默认10，最大300。
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// 分页标，从上一次请求结果中获取。
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 模糊查询工作流状态名字。
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// 工作流ID集合，多个以逗号隔开。
        /// </summary>
        [NameInMap("tfIds")]
        [Validation(Required=false)]
        public string TfIds { get; set; }

        /// <summary>
        /// 工作流状态ID集合，多个以逗号隔开。
        /// </summary>
        [NameInMap("tfsIds")]
        [Validation(Required=false)]
        public string TfsIds { get; set; }

    }

}
