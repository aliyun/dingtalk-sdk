// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class BatchUpdateFormDataByInstanceIdRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>APP_XCE0EVXS6DYG3YDYC5RD</para>
        /// </summary>
        [NameInMap("appType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("asynchronousExecution")]
        [Validation(Required=false)]
        public bool? AsynchronousExecution { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FINST-J8766S91O2UYN87ZX3XOF1MY8MBA2912BSV0L24</para>
        /// </summary>
        [NameInMap("formInstanceIdList")]
        [Validation(Required=false)]
        public List<string> FormInstanceIdList { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FORM-GX866MC1NC1VOFF6WVQW33FD16E23L3CPMKVKA</para>
        /// </summary>
        [NameInMap("formUuid")]
        [Validation(Required=false)]
        public string FormUuid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ignoreEmpty")]
        [Validation(Required=false)]
        public bool? IgnoreEmpty { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("noExecuteExpression")]
        [Validation(Required=false)]
        public bool? NoExecuteExpression { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>09866181UTZVVD4R3DC955FNKIM52HVPU5WWK7</para>
        /// </summary>
        [NameInMap("systemToken")]
        [Validation(Required=false)]
        public string SystemToken { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;countrySelectField_l0c1cwiu&quot;:[{&quot;value&quot;:&quot;US&quot;}],&quot;addressField_l0c1cwiy&quot;:{&quot;address&quot;:&quot;111&quot;,&quot;regionIds&quot;:[460000,469027,469023401],&quot;regionText&quot;:[{&quot;en_US&quot;:&quot;hai+nan+sheng&quot;,&quot;zh_CN&quot;:&quot;海南省&quot;},{&quot;en_US&quot;:&quot;cheng+mai+xian&quot;,&quot;zh_CN&quot;:&quot;澄迈县&quot;},{&quot;en_US&quot;:&quot;guo+ying+hong+gang+nong+chang&quot;,&quot;zh_CN&quot;:&quot;国营红岗农场&quot;}]}}</para>
        /// </summary>
        [NameInMap("updateFormDataJson")]
        [Validation(Required=false)]
        public string UpdateFormDataJson { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("useLatestFormSchemaVersion")]
        [Validation(Required=false)]
        public bool? UseLatestFormSchemaVersion { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ding173982232112232</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
