// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class ListPunchScheduleByConditionWithPagingRequest : TeaModel {
        /// <summary>
        /// 业务实例id，在该接口中表示打卡机实例id
        /// </summary>
        [NameInMap("bizInstanceId")]
        [Validation(Required=false)]
        public string BizInstanceId { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// 游标位置
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

        /// <summary>
        /// 查询日期结束时间（yyyy-MM-dd)
        /// </summary>
        [NameInMap("scheduleDateEnd")]
        [Validation(Required=false)]
        public string ScheduleDateEnd { get; set; }

        /// <summary>
        /// 查询日期开始时间（yyyy-MM-dd)）
        /// </summary>
        [NameInMap("scheduleDateStart")]
        [Validation(Required=false)]
        public string ScheduleDateStart { get; set; }

        /// <summary>
        /// 用户id列表
        /// </summary>
        [NameInMap("userIdList")]
        [Validation(Required=false)]
        public List<string> UserIdList { get; set; }

    }

}
