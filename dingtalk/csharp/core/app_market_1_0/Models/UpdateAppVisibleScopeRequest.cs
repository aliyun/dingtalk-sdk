// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkapp_market_1_0.Models
{
    public class UpdateAppVisibleScopeRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("operatorUserId")]
        [Validation(Required=false)]
        public string OperatorUserId { get; set; }

        [NameInMap("visibleDeptIds")]
        [Validation(Required=false)]
        public List<long?> VisibleDeptIds { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("visibleScopeType")]
        [Validation(Required=false)]
        public string VisibleScopeType { get; set; }

        [NameInMap("visibleUserIds")]
        [Validation(Required=false)]
        public List<string> VisibleUserIds { get; set; }

    }

}
