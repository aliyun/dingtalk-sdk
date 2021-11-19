// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class CreateGroupSetRequest : TeaModel {
        /// <summary>
        /// dingIsvOrgId
        /// </summary>
        [NameInMap("dingIsvOrgId")]
        [Validation(Required=false)]
        public long? DingIsvOrgId { get; set; }

        /// <summary>
        /// dingOrgId
        /// </summary>
        [NameInMap("dingOrgId")]
        [Validation(Required=false)]
        public long? DingOrgId { get; set; }

        /// <summary>
        /// dingSuiteKey
        /// </summary>
        [NameInMap("dingSuiteKey")]
        [Validation(Required=false)]
        public string DingSuiteKey { get; set; }

        /// <summary>
        /// dingTokenGrantType
        /// </summary>
        [NameInMap("dingTokenGrantType")]
        [Validation(Required=false)]
        public long? DingTokenGrantType { get; set; }

        /// <summary>
        /// groupSetName
        /// </summary>
        [NameInMap("groupSetName")]
        [Validation(Required=false)]
        public string GroupSetName { get; set; }

        [NameInMap("groupTemplateId")]
        [Validation(Required=false)]
        public string GroupTemplateId { get; set; }

        /// <summary>
        /// openTeamId
        /// </summary>
        [NameInMap("openTeamId")]
        [Validation(Required=false)]
        public string OpenTeamId { get; set; }

    }

}
