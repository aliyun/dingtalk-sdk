// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class ListUserVisibleBpmsProcessesRequest : TeaModel {
        /// <summary>
        /// 分页大小，最大可设置成100。
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// 分页游标，从0开始。根据返回结果里的nextToken是否为空来判断是否还有下一页，且再次调用时设置成nextToken的最新值。
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

        /// <summary>
        /// 要查询的员工的userid。不传表示查询企业下所有审批表单。
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
