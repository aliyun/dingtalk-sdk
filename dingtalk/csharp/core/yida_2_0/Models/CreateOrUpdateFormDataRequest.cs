// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_2_0.Models
{
    public class CreateOrUpdateFormDataRequest : TeaModel {
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;countrySelectField_l0c1cwiu&quot;:[{&quot;value&quot;:&quot;US&quot;}]}</para>
        /// </summary>
        [NameInMap("formDataJson")]
        [Validation(Required=false)]
        public string FormDataJson { get; set; }

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
        /// <para>false</para>
        /// </summary>
        [NameInMap("noExecuteExpression")]
        [Validation(Required=false)]
        public bool? NoExecuteExpression { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;key&quot;:&quot;currentNodeName&quot;,&quot;value&quot;:&quot;当前审批节点名称&quot;,&quot;type&quot;:&quot;TEXT&quot;,&quot;operator&quot;:&quot;like&quot;,&quot;componentName&quot;:&quot;TextField&quot;}]。详情参考 <a href="https://www.yuque.com/yida/support/agb8im#F4S8e">https://www.yuque.com/yida/support/agb8im#F4S8e</a></para>
        /// </summary>
        [NameInMap("searchCondition")]
        [Validation(Required=false)]
        public string SearchCondition { get; set; }

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
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("useAlias")]
        [Validation(Required=false)]
        public bool? UseAlias { get; set; }

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
