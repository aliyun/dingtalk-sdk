// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class ListFormRemarksResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;FINST-GW866DA1NHFZIPNE03UTM88NOAGQ27Q9VUP1L0&quot;:[{&quot;creator&quot;:&quot;manager9358&quot;,&quot;replyUserId&quot;:null,&quot;images&quot;:&quot;[]&quot;,&quot;formInstId&quot;:&quot;FINST-GW866DA1NHFZIPNE03UTM88NOAGQ27Q9VUP1L0&quot;,&quot;replyId&quot;:null,&quot;files&quot;:&quot;[]&quot;,&quot;id&quot;:3261500001,&quot;gmtCreate&quot;:1649387753000,&quot;class&quot;:&quot;com.alibaba.work.tianshu.api.model.form.RemarkVO&quot;,&quot;atUserId&quot;:null,&quot;content&quot;:&quot;评论1&quot;}],&quot;FINST-96766PB1LBZYTVGI52J857AFKWWR3MX3CS41LXM6&quot;:[{&quot;creator&quot;:&quot;manager9358&quot;,&quot;replyUserId&quot;:null,&quot;images&quot;:&quot;[]&quot;,&quot;formInstId&quot;:&quot;FINST-96766PB1LBZYTVGI52J857AFKWWR3MX3CS41LXM6&quot;,&quot;replyId&quot;:null,&quot;files&quot;:&quot;[]&quot;,&quot;id&quot;:3261500003,&quot;gmtCreate&quot;:1649387988000,&quot;class&quot;:&quot;com.alibaba.work.tianshu.api.model.form.RemarkVO&quot;,&quot;atUserId&quot;:null,&quot;content&quot;:&quot;评论4&quot;}]}</para>
        /// </summary>
        [NameInMap("formRemarkVoMap")]
        [Validation(Required=false)]
        public Dictionary<string, object> FormRemarkVoMap { get; set; }

    }

}
