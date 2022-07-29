// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class SpaceVO : TeaModel {
        /// <summary>
        /// 封面
        /// </summary>
        [NameInMap("cover")]
        [Validation(Required=false)]
        public string Cover { get; set; }

        /// <summary>
        /// 访问者对当前知识库的权限等信息
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// 知识库图标
        /// </summary>
        [NameInMap("iconVO")]
        [Validation(Required=false)]
        public SpaceVOIconVO IconVO { get; set; }
        public class SpaceVOIconVO : TeaModel {
            [NameInMap("icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }
        };

        /// <summary>
        /// 知识库id。
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// 知识库名称。
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 知识库所有者。
        /// </summary>
        [NameInMap("owner")]
        [Validation(Required=false)]
        public SpaceVOOwner Owner { get; set; }
        public class SpaceVOOwner : TeaModel {
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }
        };

        /// <summary>
        /// 知识库访问url。
        /// </summary>
        [NameInMap("url")]
        [Validation(Required=false)]
        public string Url { get; set; }

        /// <summary>
        /// 访问者对当前知识库的权限等信息。
        /// </summary>
        [NameInMap("visitorInfo")]
        [Validation(Required=false)]
        public SpaceVOVisitorInfo VisitorInfo { get; set; }
        public class SpaceVOVisitorInfo : TeaModel {
            [NameInMap("dentryActions")]
            [Validation(Required=false)]
            public List<string> DentryActions { get; set; }
            [NameInMap("roleCode")]
            [Validation(Required=false)]
            public string RoleCode { get; set; }
            [NameInMap("spaceActions")]
            [Validation(Required=false)]
            public List<string> SpaceActions { get; set; }
        };

    }

}
