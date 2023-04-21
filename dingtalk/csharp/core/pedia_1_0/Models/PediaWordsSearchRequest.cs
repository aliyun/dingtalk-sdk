// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkpedia_1_0.Models
{
    public class PediaWordsSearchRequest : TeaModel {
        /// <summary>
        /// 当前查询的页数，当超过总数后返回数据为空
        /// 
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// 当前每页需要展示的数量，最大20
        /// 
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// 当前搜索列表的状态0代表审核通过，1代表创建待审核，2代表更新待审核列表
        /// 默认是0，代表获取所有审核完成的词条
        /// 
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// 通过开放平台获取的员工编号userId
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// 搜索关键词
        /// 
        /// </summary>
        [NameInMap("wordName")]
        [Validation(Required=false)]
        public string WordName { get; set; }

    }

}
