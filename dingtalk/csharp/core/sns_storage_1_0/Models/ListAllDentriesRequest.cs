// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalksns_storage_1_0.Models
{
    public class ListAllDentriesRequest : TeaModel {
        /// <summary>
        /// 可选参数
        /// </summary>
        [NameInMap("option")]
        [Validation(Required=false)]
        public ListAllDentriesRequestOption Option { get; set; }
        public class ListAllDentriesRequestOption : TeaModel {
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
            /// 目前仅支持按修改时间排序,
            /// 如果是升序排序, 分页拉取过程中, 如果文件发生变化, 可能拉取到重复数据
            /// 如果是降序排序, 分页拉取过程中, 如果文件发生变化, 可能会丢失数据
            /// 枚举值:
            /// 	ASC: 升序
            /// 	DESC: 降序
            /// 默认值:
            /// 	ASC
            /// </summary>
            [NameInMap("order")]
            [Validation(Required=false)]
            public string Order { get; set; }

            /// <summary>
            /// 是否获取文件缩略图临时链接
            /// 注: 按需获取, 会影响接口耗时
            /// 默认值:
            /// 	false
            /// </summary>
            [NameInMap("withThumbnail")]
            [Validation(Required=false)]
            public bool? WithThumbnail { get; set; }

        }

        /// <summary>
        /// 用户id
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
