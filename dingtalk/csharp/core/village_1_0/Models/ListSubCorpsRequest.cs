// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkvillage_1_0.Models
{
    public class ListSubCorpsRequest : TeaModel {
        /// <summary>
        /// 下级指定组织层级列表，组织层级为county,town,community,residential，依次为区/县、乡/镇/街道、社区/村、小区，如果查多个用 '|' 分隔
        /// </summary>
        [NameInMap("types")]
        [Validation(Required=false)]
        public string Types { get; set; }

        /// <summary>
        /// 下属组织的组织ID，比如下属镇、村的corpId
        /// </summary>
        [NameInMap("subCorpId")]
        [Validation(Required=false)]
        public string SubCorpId { get; set; }

        /// <summary>
        /// 是否查询直接下级
        /// </summary>
        [NameInMap("isOnlyDirect")]
        [Validation(Required=false)]
        public bool? IsOnlyDirect { get; set; }

    }

}
