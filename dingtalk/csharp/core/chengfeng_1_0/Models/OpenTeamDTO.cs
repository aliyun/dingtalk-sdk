// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkchengfeng_1_0.Models
{
    public class OpenTeamDTO : TeaModel {
        /// <summary>
        /// 部门id
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// 部门名称
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 钉钉对应部门编号
        /// </summary>
        [NameInMap("openId")]
        [Validation(Required=false)]
        public string OpenId { get; set; }

    }

}
