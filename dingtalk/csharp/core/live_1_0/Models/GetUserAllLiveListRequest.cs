// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklive_1_0.Models
{
    public class GetUserAllLiveListRequest : TeaModel {
        /// <summary>
        /// 直播状态列表
        /// </summary>
        [NameInMap("statuses")]
        [Validation(Required=false)]
        public List<long?> Statuses { get; set; }

        /// <summary>
        /// 第几页，从1开始
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

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
