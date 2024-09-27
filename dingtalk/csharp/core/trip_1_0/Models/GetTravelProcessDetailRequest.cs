// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktrip_1_0.Models
{
    public class GetTravelProcessDetailRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>dingLamaXHExxxxxx</para>
        /// </summary>
        [NameInMap("processCorpId")]
        [Validation(Required=false)]
        public string ProcessCorpId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1fbmtOweRdqLamaXHExxxxxx</para>
        /// </summary>
        [NameInMap("processInstanceId")]
        [Validation(Required=false)]
        public string ProcessInstanceId { get; set; }

    }

}
