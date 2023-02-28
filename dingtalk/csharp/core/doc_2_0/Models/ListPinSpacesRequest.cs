// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class ListPinSpacesRequest : TeaModel {
        /// <summary>
        /// 可选参数
        /// </summary>
        [NameInMap("option")]
        [Validation(Required=false)]
        public ListPinSpacesRequestOption Option { get; set; }
        public class ListPinSpacesRequestOption : TeaModel {
            /// <summary>
            /// 分页大小
            /// 默认值:
            /// 	20
            /// 最大值:
            /// 	20
            /// </summary>
            [NameInMap("maxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// 分页游标
            /// </summary>
            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// 是否获取知识库创建者信息
            /// 默认值:
            /// 	false
            /// </summary>
            [NameInMap("withSpaceCreatorInfo")]
            [Validation(Required=false)]
            public bool? WithSpaceCreatorInfo { get; set; }

            /// <summary>
            /// 是否获取知识库修改者信息
            /// 默认值:
            /// 	false
            /// </summary>
            [NameInMap("withSpaceModifierInfo")]
            [Validation(Required=false)]
            public bool? WithSpaceModifierInfo { get; set; }

            /// <summary>
            /// 是否获取知识库权限
            /// 默认值:
            /// 	false
            /// </summary>
            [NameInMap("withSpacePermissionRole")]
            [Validation(Required=false)]
            public bool? WithSpacePermissionRole { get; set; }

            /// <summary>
            /// 是否获取小组信息
            /// 默认值:
            /// 	false
            /// </summary>
            [NameInMap("withTeamDetail")]
            [Validation(Required=false)]
            public bool? WithTeamDetail { get; set; }

        }

        /// <summary>
        /// 操作人id
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

    }

}
