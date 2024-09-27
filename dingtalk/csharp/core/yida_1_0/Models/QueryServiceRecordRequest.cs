// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class QueryServiceRecordRequest : TeaModel {
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
        /// <para>FORM-GX866MC1NC1VOFF6WVQW33FD16E23L3CPMKVKA</para>
        /// </summary>
        [NameInMap("formUuid")]
        [Validation(Required=false)]
        public string FormUuid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>HTTP</para>
        /// </summary>
        [NameInMap("hookType")]
        [Validation(Required=false)]
        public string HookType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>INVOKE-E7766VC1KJ4ZVFCR346USCT2ORYI2UVRBHA1L0</para>
        /// </summary>
        [NameInMap("hookUuid")]
        [Validation(Required=false)]
        public string HookUuid { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FINST-NJS33HHSLFNH533HHOFN</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2022-03-28</para>
        /// </summary>
        [NameInMap("invokeAfterDateGMT")]
        [Validation(Required=false)]
        public string InvokeAfterDateGMT { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2022-03-29</para>
        /// </summary>
        [NameInMap("invokeBeforeDateGMT")]
        [Validation(Required=false)]
        public string InvokeBeforeDateGMT { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>可选值：SUCCESS、FAIL、FINAL_SUCCESS、ERROR</para>
        /// </summary>
        [NameInMap("invokeStatus")]
        [Validation(Required=false)]
        public string InvokeStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://www.aliwork.com/query/">www.aliwork.com/query/</a></para>
        /// </summary>
        [NameInMap("requestUrl")]
        [Validation(Required=false)]
        public string RequestUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>INVOKE-E7766VC1KJ4ZVFCR346USCT2ORYI2UVRBHA1LI</para>
        /// </summary>
        [NameInMap("sourceUuid")]
        [Validation(Required=false)]
        public string SourceUuid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

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
        /// <para>ding173982232112232</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
