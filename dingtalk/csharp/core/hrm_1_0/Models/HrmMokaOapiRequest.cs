// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class HrmMokaOapiRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/user/role/get</para>
        /// </summary>
        [NameInMap("apiCode")]
        [Validation(Required=false)]
        public string ApiCode { get; set; }

        [NameInMap("params")]
        [Validation(Required=false)]
        public object Params { get; set; }

    }

}
