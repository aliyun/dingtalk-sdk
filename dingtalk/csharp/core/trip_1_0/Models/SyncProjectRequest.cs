// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktrip_1_0.Models
{
    public class SyncProjectRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ding89233847892ndkas</para>
        /// </summary>
        [NameInMap("channelCorpId")]
        [Validation(Required=false)]
        public string ChannelCorpId { get; set; }

        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("costCenterId")]
        [Validation(Required=false)]
        public string CostCenterId { get; set; }

        [NameInMap("deleteFlag")]
        [Validation(Required=false)]
        public bool? DeleteFlag { get; set; }

        /// <summary>
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("extension")]
        [Validation(Required=false)]
        public string Extension { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-02-21 11:11:11</para>
        /// </summary>
        [NameInMap("gmtAction")]
        [Validation(Required=false)]
        public string GmtAction { get; set; }

        [NameInMap("invoiceId")]
        [Validation(Required=false)]
        public string InvoiceId { get; set; }

        [NameInMap("managerIds")]
        [Validation(Required=false)]
        public List<string> ManagerIds { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("projectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>默认项目</para>
        /// </summary>
        [NameInMap("projectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("scope")]
        [Validation(Required=false)]
        public int? Scope { get; set; }

        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        [NameInMap("thirdPartId")]
        [Validation(Required=false)]
        public string ThirdPartId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20881001829000</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
