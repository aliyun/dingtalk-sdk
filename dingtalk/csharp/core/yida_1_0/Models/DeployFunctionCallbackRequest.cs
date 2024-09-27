// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class DeployFunctionCallbackRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>202201061234</para>
        /// </summary>
        [NameInMap("appId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>abc.com</para>
        /// </summary>
        [NameInMap("customDomain")]
        [Validation(Required=false)]
        public string CustomDomain { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>RELEASE</para>
        /// </summary>
        [NameInMap("deployStage")]
        [Validation(Required=false)]
        public string DeployStage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>assdfasdfWwd12212</para>
        /// </summary>
        [NameInMap("gateWayAppKey")]
        [Validation(Required=false)]
        public string GateWayAppKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>fasdfsfasdf1212Sff</para>
        /// </summary>
        [NameInMap("gateWayAppSecret")]
        [Validation(Required=false)]
        public string GateWayAppSecret { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1111shanghai-aliyunapi.com</para>
        /// </summary>
        [NameInMap("gateWayDomain")]
        [Validation(Required=false)]
        public string GateWayDomain { get; set; }

    }

}
