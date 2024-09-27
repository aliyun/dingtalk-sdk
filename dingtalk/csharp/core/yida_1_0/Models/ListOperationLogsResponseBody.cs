// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class ListOperationLogsResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;FINST-GW866DA1NHFZIPNE03UTM88NOAGQ27Q9VUP1L0&quot;:[{&quot;currentText&quot;:null,&quot;componentType&quot;:null,&quot;gmtModified&quot;:&quot;2022-04-08 11:15:34&quot;,&quot;preText&quot;:null,&quot;operationType&quot;:&quot;CREATE&quot;,&quot;componentName&quot;:&quot;&quot;,&quot;operator&quot;:{&quot;userInfo&quot;:null,&quot;tbWang&quot;:null,&quot;depDesc&quot;:null,&quot;displayName&quot;:&quot;娄修俊&quot;,&quot;mastedataDeptments&quot;:null,&quot;orderNum&quot;:null,&quot;displayEnName&quot;:null,&quot;userId&quot;:null,&quot;personalPhoto&quot;:null,&quot;status&quot;:null},&quot;fieldId&quot;:null}]}</para>
        /// </summary>
        [NameInMap("operationLogMap")]
        [Validation(Required=false)]
        public Dictionary<string, object> OperationLogMap { get; set; }

    }

}
