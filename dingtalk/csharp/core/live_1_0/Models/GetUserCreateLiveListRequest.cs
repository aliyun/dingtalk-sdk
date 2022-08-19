// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklive_1_0.Models
{
    public class GetUserCreateLiveListRequest : TeaModel {
        /// <summary>
        /// post请求体, 开放平台建议以对象形式存储
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public GetUserCreateLiveListRequestBody Body { get; set; }
        public class GetUserCreateLiveListRequestBody : TeaModel {
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }
            [NameInMap("statuses")]
            [Validation(Required=false)]
            public List<long?> Statuses { get; set; }
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }
        };

        /// <summary>
        /// 分页游标 第一次可不填， 后面填回包的值
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 单次拉去上限，默认40个
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// 用户uid
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
