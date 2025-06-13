// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkmeter_1_0.Models
{
    public class GetResourceUseInfoRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("benefitCodeList")]
        [Validation(Required=false)]
        public List<string> BenefitCodeList { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("period")]
        [Validation(Required=false)]
        public string Period { get; set; }

    }

}
