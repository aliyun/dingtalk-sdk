// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_2_0.Models
{
    public class RestartInstanceRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>APP_XCEXXX</para>
        /// </summary>
        [NameInMap("appType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>node_xxx</para>
        /// </summary>
        [NameInMap("currentActivityId")]
        [Validation(Required=false)]
        public string CurrentActivityId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>vpc（国内、默认）/ sgp_vpc（海外）</para>
        /// </summary>
        [NameInMap("envProfile")]
        [Validation(Required=false)]
        public string EnvProfile { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FORM-XXX</para>
        /// </summary>
        [NameInMap("formUuid")]
        [Validation(Required=false)]
        public string FormUuid { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("procInstanceId")]
        [Validation(Required=false)]
        public string ProcInstanceId { get; set; }

        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>098661XXX</para>
        /// </summary>
        [NameInMap("systemToken")]
        [Validation(Required=false)]
        public string SystemToken { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sid-restartevent</para>
        /// </summary>
        [NameInMap("targetActivityId")]
        [Validation(Required=false)]
        public string TargetActivityId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123XXX</para>
        /// </summary>
        [NameInMap("taskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>173XXX</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
