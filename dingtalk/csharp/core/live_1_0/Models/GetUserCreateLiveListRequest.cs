// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklive_1_0.Models
{
    public class GetUserCreateLiveListRequest : TeaModel {
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
        /// post请求体, 开放平台建议以对象形式存储
        /// </summary>
        [NameInMap("statuses")]
        [Validation(Required=false)]
        public GetUserCreateLiveListRequestStatuses Statuses { get; set; }
        public class GetUserCreateLiveListRequestStatuses : TeaModel {
            [NameInMap("statuses")]
            [Validation(Required=false)]
            public List<long?> Statuses { get; set; }
        };

        /// <summary>
        /// 用户uid
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
