// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class ListApplicationResponseBody : TeaModel {
        /// <summary>
        /// 数据
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListApplicationResponseBodyData> Data { get; set; }
        public class ListApplicationResponseBodyData : TeaModel {
            /// <summary>
            /// 宜搭应用配置
            /// </summary>
            [NameInMap("appConfig")]
            [Validation(Required=false)]
            public string AppConfig { get; set; }

            /// <summary>
            /// 宜搭应用编码
            /// </summary>
            [NameInMap("appType")]
            [Validation(Required=false)]
            public string AppType { get; set; }

            /// <summary>
            /// 应用状态
            /// </summary>
            [NameInMap("applicationStatus")]
            [Validation(Required=false)]
            public string ApplicationStatus { get; set; }

            /// <summary>
            /// 钉钉组织id
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// 创建者的userId
            /// </summary>
            [NameInMap("creatorUserId")]
            [Validation(Required=false)]
            public string CreatorUserId { get; set; }

            /// <summary>
            /// 描述信息
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// 宜搭图标编码
            /// </summary>
            [NameInMap("icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            /// <summary>
            /// 是否被删除了
            /// </summary>
            [NameInMap("inexistence")]
            [Validation(Required=false)]
            public string Inexistence { get; set; }

            /// <summary>
            /// 名称
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 子组织的钉钉CorpId
            /// </summary>
            [NameInMap("subCorpId")]
            [Validation(Required=false)]
            public string SubCorpId { get; set; }

        }

        /// <summary>
        /// 当前第几页
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// 总数量
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
