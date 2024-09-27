// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyun_shu_1_0.Models
{
    public class SaveOpenExternalLogRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dingf8d907412a586</para>
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yunshu</para>
        /// </summary>
        [NameInMap("logSource")]
        [Validation(Required=false)]
        public string LogSource { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>terminalInfo</para>
        /// </summary>
        [NameInMap("logType")]
        [Validation(Required=false)]
        public string LogType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;date&quot;:&quot;2023-05-10&quot;,&quot;macAddress&quot;:&quot;34-2E-B7-AF-EA-JF&quot;,&quot;devSn&quot;:&quot;68D1F0-B76A-5CC9-BCFC-BD7548BA&quot;,&quot;staffId&quot;:&quot;05166141678164&quot;}]</para>
        /// </summary>
        [NameInMap("openExt")]
        [Validation(Required=false)]
        public string OpenExt { get; set; }

    }

}
