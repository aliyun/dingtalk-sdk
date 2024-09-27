// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbadge_1_0.Models
{
    public class NotifyBadgeCodeVerifyResultRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>corpxxxx</para>
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>261234567890</para>
        /// </summary>
        [NameInMap("payCode")]
        [Validation(Required=false)]
        public string PayCode { get; set; }

        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>INTERNAL_STAFF</para>
        /// </summary>
        [NameInMap("userCorpRelationType")]
        [Validation(Required=false)]
        public string UserCorpRelationType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxxx</para>
        /// </summary>
        [NameInMap("userIdentity")]
        [Validation(Required=false)]
        public string UserIdentity { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>门禁验证</para>
        /// </summary>
        [NameInMap("verifyEvent")]
        [Validation(Required=false)]
        public string VerifyEvent { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1号食堂</para>
        /// </summary>
        [NameInMap("verifyLocation")]
        [Validation(Required=false)]
        public string VerifyLocation { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>202112120003232</para>
        /// </summary>
        [NameInMap("verifyNo")]
        [Validation(Required=false)]
        public string VerifyNo { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("verifyResult")]
        [Validation(Required=false)]
        public bool? VerifyResult { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-01 12:12:12</para>
        /// </summary>
        [NameInMap("verifyTime")]
        [Validation(Required=false)]
        public string VerifyTime { get; set; }

    }

}
