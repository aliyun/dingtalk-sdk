// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class SpaceOpenVO : TeaModel {
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
        public SpaceOpenVOOwner Owner { get; set; }
        public class SpaceOpenVOOwner : TeaModel {
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
        public SpaceOpenVOVisitorInfo VisitorInfo { get; set; }
        public class SpaceOpenVOVisitorInfo : TeaModel {
            [NameInMap("dentryActions")]
            [Validation(Required=false)]
            public List<string> DentryActions { get; set; }
            [NameInMap("spaceActions")]
            [Validation(Required=false)]
            public List<string> SpaceActions { get; set; }
        };

    }

}
