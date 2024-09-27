// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcredit_1_0.Models
{
    public class QueryScoreRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MD5</para>
        /// </summary>
        [NameInMap("encryption")]
        [Validation(Required=false)]
        public string Encryption { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>a0fbf479272cd38c220fbf726678d8d6</para>
        /// </summary>
        [NameInMap("fullName")]
        [Validation(Required=false)]
        public string FullName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>b04a604cf00e64136b386e83444245c3</para>
        /// </summary>
        [NameInMap("idCardCode")]
        [Validation(Required=false)]
        public string IdCardCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e10adc3949ba59abbe56e057f20f883e</para>
        /// </summary>
        [NameInMap("mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>aca03c931768ea4b0244531aca9a19ee</para>
        /// </summary>
        [NameInMap("orgName")]
        [Validation(Required=false)]
        public string OrgName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>a57d7bf49b6e44180b21b1fea80eec0a</para>
        /// </summary>
        [NameInMap("uniScCode")]
        [Validation(Required=false)]
        public string UniScCode { get; set; }

    }

}
