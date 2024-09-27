// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkats_1_0.Models
{
    public class UpdateApplicationRegFormResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>manager5875</para>
        /// </summary>
        [NameInMap("creatorUserId")]
        [Validation(Required=false)]
        public string CreatorUserId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>formXXX</para>
        /// </summary>
        [NameInMap("formId")]
        [Validation(Required=false)]
        public string FormId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1626775016427</para>
        /// </summary>
        [NameInMap("gmtCreateMillis")]
        [Validation(Required=false)]
        public long? GmtCreateMillis { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1626775016427</para>
        /// </summary>
        [NameInMap("gmtModifiedMillis")]
        [Validation(Required=false)]
        public long? GmtModifiedMillis { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>templateXXX</para>
        /// </summary>
        [NameInMap("templateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("templateVersion")]
        [Validation(Required=false)]
        public int? TemplateVersion { get; set; }

    }

}
