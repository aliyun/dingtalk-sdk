// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class GetOrganizatioTaskByIdsRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>62a010c153c2ef5244xxxx, 62a010c153c2ef524xxxxxx</para>
        /// </summary>
        [NameInMap("taskIds")]
        [Validation(Required=false)]
        public string TaskIds { get; set; }

    }

}
