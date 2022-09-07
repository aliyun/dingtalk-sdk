// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class ListProcessInstanceIdsRequest : TeaModel {
        /// <summary>
        /// 审批实例结束时间，Unix时间戳，单位毫秒。  例如：获取审批单发起时间在2020.4.10-2020.4.14之间审批单，该值传2020.4.14 23:59:59对应的时间戳1586879999000。
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// 分页参数，每页大小，最多传20。
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// 分页查询的游标，最开始传0，后续传返回参数中的nextToken值。
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

        /// <summary>
        /// 审批流的唯一码。
        /// 
        /// processCode在审批模板编辑页面的URL中获取。
        /// </summary>
        [NameInMap("processCode")]
        [Validation(Required=false)]
        public string ProcessCode { get; set; }

        /// <summary>
        /// 审批实例开始时间。Unix时间戳，单位毫秒。
        /// 
        /// 例如：获取审批单发起时间在2020.4.10-2020.4.14之间审批单，该值传2020.4.10 00:00:00对应的时间戳1586448000000。
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// 发起userid列表，最大列表长度为10。
        /// </summary>
        [NameInMap("userIds")]
        [Validation(Required=false)]
        public List<string> UserIds { get; set; }

    }

}
