// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkh3yun_1_0.Models
{
    public class LoadBizObjectResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{                 &quot;ObjectId&quot;: &quot;f2eef8c4-0455-4e3e-bb15-258fb409e077&quot;,                 &quot;Name&quot;: &quot;0000007&quot;,                 &quot;CreatedBy&quot;: &quot;张三&quot;,                 &quot;OwnerId&quot;: &quot;张三&quot;,                 &quot;OwnerDeptId&quot;: &quot;深圳<b>公司&quot;,                 &quot;CreatedTime&quot;: &quot;2021/11/15 17:41:11&quot;,                 &quot;ModifiedBy&quot;: &quot;&quot;,                 &quot;ModifiedTime&quot;: &quot;2021/11/15 17:41:11&quot;,                 &quot;WorkflowInstanceId&quot;: &quot;&quot;,                 &quot;Status&quot;: 1,                 &quot;F0000010&quot;: &quot;0000007&quot;,                 &quot;F0000011&quot;: &quot;王五&quot;,                 &quot;F0000012&quot;: &quot;D1级客户&quot;,                 &quot;F0000013&quot;: &quot;7000&quot;,                 &quot;F0000023&quot;: null,                 &quot;F0000024&quot;: null,                 &quot;D000183Fcd15f3a51e624bbc9945392d190b6aa8&quot;: [                     {                         &quot;ObjectId&quot;: &quot;836314cf-e25f-448b-ac79-9a0f58154299&quot;,                         &quot;Name&quot;: null,                         &quot;ParentObjectId&quot;: &quot;f2eef8c4-0455-4e3e-bb15-258fb409e077&quot;,                         &quot;F0000014&quot;: &quot;里斯&quot;,                         &quot;F0000015&quot;: &quot;156</b>******&quot;,                         &quot;F0000016&quot;: &quot;技术部&quot;,                         &quot;F0000017&quot;: &quot;经理&quot;,                         &quot;F0000018&quot;: &quot;男&quot;,                         &quot;F0000019&quot;: &quot;<a href="mailto:lgbxunmi@dd.com">lgbxunmi@dd.com</a>&quot;,                         &quot;F0000020&quot;: true,                         &quot;F0000021&quot;: &quot;无&quot;                     }                 ],                 &quot;F0000022&quot;: null,                 &quot;CreatedByObject&quot;: {                     &quot;ObjectId&quot;: &quot;aea4d7a7-d162-4c77-9c44-7bd9cb8316a5&quot;,                     &quot;Name&quot;: &quot;张三&quot;                 },                 &quot;OwnerIdObject&quot;: {                     &quot;ObjectId&quot;: &quot;aea4d7a7-d162-4c77-9c44-7bd9cb8316a5&quot;,                     &quot;Name&quot;: &quot;张三&quot;                 },                 &quot;OwnerDeptIdObject&quot;: {                     &quot;ObjectId&quot;: &quot;18f923a7-5a5e-426d-94ae-a55ad1a4b240&quot;,                     &quot;Name&quot;: &quot;深圳**公司&quot;                 }             }</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public Dictionary<string, object> Data { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
