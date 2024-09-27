// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class HrmProcessTerminationAndHandoverRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>user123</para>
        /// </summary>
        [NameInMap("aflowHandOverUserId")]
        [Validation(Required=false)]
        public string AflowHandOverUserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>user123</para>
        /// </summary>
        [NameInMap("dingPanHandoverUserId")]
        [Validation(Required=false)]
        public string DingPanHandoverUserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>user123</para>
        /// </summary>
        [NameInMap("directSubordinatesHandoverUserId")]
        [Validation(Required=false)]
        public string DirectSubordinatesHandoverUserId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aefadfadaewedad</para>
        /// </summary>
        [NameInMap("dismissionMemo")]
        [Validation(Required=false)]
        public string DismissionMemo { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("dismissionReason")]
        [Validation(Required=false)]
        public int? DismissionReason { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>user123</para>
        /// </summary>
        [NameInMap("docNoteHandoverUserId")]
        [Validation(Required=false)]
        public string DocNoteHandoverUserId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1704074400000</para>
        /// </summary>
        [NameInMap("lastWorkDate")]
        [Validation(Required=false)]
        public long? LastWorkDate { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>经理</para>
        /// </summary>
        [NameInMap("optUserId")]
        [Validation(Required=false)]
        public string OptUserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>user123</para>
        /// </summary>
        [NameInMap("permissionHandoverUserId")]
        [Validation(Required=false)]
        public string PermissionHandoverUserId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2332</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
