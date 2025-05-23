// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_2_0.Models
{
    public class GetSupplierResponseBody : TeaModel {
        [NameInMap("accountantBookIdList")]
        [Validation(Required=false)]
        public List<string> AccountantBookIdList { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUP_XXX</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1634786828686</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        [NameInMap("customFormDataList")]
        [Validation(Required=false)]
        public List<GetSupplierResponseBodyCustomFormDataList> CustomFormDataList { get; set; }
        public class GetSupplierResponseBodyCustomFormDataList : TeaModel {
            [NameInMap("bizAlias")]
            [Validation(Required=false)]
            public string BizAlias { get; set; }

            [NameInMap("componentType")]
            [Validation(Required=false)]
            public string ComponentType { get; set; }

            [NameInMap("extValue")]
            [Validation(Required=false)]
            public string ExtValue { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>原材料供应商</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>XX公司</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>valid</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("userDefineCode")]
        [Validation(Required=false)]
        public string UserDefineCode { get; set; }

    }

}
