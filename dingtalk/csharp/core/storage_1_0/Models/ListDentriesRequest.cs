// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class ListDentriesRequest : TeaModel {
        /// <summary>
        /// 分页大小
        /// 默认值:
        /// 	50
        /// 最大值:
        /// 	50
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// 分页游标, 首次拉取不用传
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 排序规则, 升降或降序
        /// 枚举值:
        /// 	ASC: 升序
        /// 	DESC: 降序
        /// 默认值:
        /// 	DESC
        /// </summary>
        [NameInMap("order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// 排序字段
        /// 枚举值:
        /// 	NAME: 名称
        /// 	SIZE: 大小
        /// 	MODIFIED_TIME: 最后修改时间
        /// 	CREATE_TIME: 创建时间
        /// 默认值:
        /// 	MODIFIED_TIME
        /// </summary>
        [NameInMap("orderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// 父目录id, 根目录id值为0
        /// </summary>
        [NameInMap("parentId")]
        [Validation(Required=false)]
        public string ParentId { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
