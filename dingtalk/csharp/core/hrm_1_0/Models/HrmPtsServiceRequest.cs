// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class HrmPtsServiceRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dev  or online</para>
        /// </summary>
        [NameInMap("env")]
        [Validation(Required=false)]
        public string Env { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>GET/POST</para>
        /// </summary>
        [NameInMap("method")]
        [Validation(Required=false)]
        public string Method { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abd123213</para>
        /// </summary>
        [NameInMap("outerId")]
        [Validation(Required=false)]
        public string OuterId { get; set; }

        [NameInMap("params")]
        [Validation(Required=false)]
        public object Params { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/user/role/get</para>
        /// </summary>
        [NameInMap("path")]
        [Validation(Required=false)]
        public string Path { get; set; }

    }

}
