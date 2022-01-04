// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class GetRunningTaskListRequest : TeaModel {
        /// <summary>
        /// appType
        /// </summary>
        [NameInMap("appType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        /// <summary>
        /// 流程实例id列表, 逗号分隔
        /// </summary>
        [NameInMap("processInstanceIdList")]
        [Validation(Required=false)]
        public string ProcessInstanceIdList { get; set; }

        /// <summary>
        /// systemToken
        /// </summary>
        [NameInMap("systemToken")]
        [Validation(Required=false)]
        public string SystemToken { get; set; }

        /// <summary>
        /// 用户所属的企业id
        /// </summary>
        [NameInMap("userCorpId")]
        [Validation(Required=false)]
        public string UserCorpId { get; set; }

        /// <summary>
        /// userId
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
