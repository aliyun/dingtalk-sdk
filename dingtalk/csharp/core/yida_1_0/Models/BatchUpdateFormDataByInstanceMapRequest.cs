// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class BatchUpdateFormDataByInstanceMapRequest : TeaModel {
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
        /// <para>{&quot;FINST-ANSFSNNDS2212NSKLKKSFD&quot;:&quot;{&quot;rateField_l0c1cwis&quot;:3,&quot;countrySelectField_l0c1cwiu&quot;:[{&quot;value&quot;:&quot;US&quot;}]}&quot;}</para>
        /// </summary>
        [NameInMap("updateFormDataJsonMap")]
        [Validation(Required=false)]
        public Dictionary<string, object> UpdateFormDataJsonMap { get; set; }

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
