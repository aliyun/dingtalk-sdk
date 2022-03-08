// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class BatchGetGroupSetConfigRequest : TeaModel {
        /// <summary>
        /// 配置项key列表
        /// </summary>
        [NameInMap("configKeys")]
        [Validation(Required=false)]
        public List<string> ConfigKeys { get; set; }

        /// <summary>
        /// 开放群组id
        /// </summary>
        [NameInMap("openGroupSetId")]
        [Validation(Required=false)]
        public string OpenGroupSetId { get; set; }

        /// <summary>
        /// 开放团队id
        /// </summary>
        [NameInMap("openTeamId")]
        [Validation(Required=false)]
        public string OpenTeamId { get; set; }

    }

}
