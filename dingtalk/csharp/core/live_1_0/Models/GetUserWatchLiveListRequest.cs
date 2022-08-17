// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklive_1_0.Models
{
    public class GetUserWatchLiveListRequest : TeaModel {
        /// <summary>
        /// 过滤类型，0：不过滤， 1：过滤已经看完的
        /// </summary>
        [NameInMap("filterType")]
        [Validation(Required=false)]
        public int? FilterType { get; set; }

        /// <summary>
        /// 单次拉去上限，默认40个
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// 分页游标 第一次可不填， 后面填回包的值
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 用户uid
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
