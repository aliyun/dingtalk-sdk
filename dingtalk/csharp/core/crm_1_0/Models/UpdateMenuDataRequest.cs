// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class UpdateMenuDataRequest : TeaModel {
        [NameInMap("attr")]
        [Validation(Required=false)]
        public Dictionary<string, object> Attr { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>89ez9DwVWQVgkhwndJNt1ZY</para>
        /// </summary>
        [NameInMap("bizTraceId")]
        [Validation(Required=false)]
        public string BizTraceId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sale</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public string Module { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("navData")]
        [Validation(Required=false)]
        public UpdateMenuDataRequestNavData NavData { get; set; }
        public class UpdateMenuDataRequestNavData : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("displayStatus")]
            [Validation(Required=false)]
            public string DisplayStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>icon-biaodan_baogao</para>
            /// </summary>
            [NameInMap("icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>#CCEEFF</para>
            /// </summary>
            [NameInMap("iconBgColor")]
            [Validation(Required=false)]
            public string IconBgColor { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>#007FFF</para>
            /// </summary>
            [NameInMap("iconColor")]
            [Validation(Required=false)]
            public string IconColor { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>same_page</para>
            /// </summary>
            [NameInMap("integrationProtocol")]
            [Validation(Required=false)]
            public string IntegrationProtocol { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>库存账单</para>
            /// </summary>
            [NameInMap("mobileNavName")]
            [Validation(Required=false)]
            public string MobileNavName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://tj-ali-crm-test.tangees.com/tungee/crm/mobile/?corpid=dinge18b222ec5637b04ffe93478753d9884#/form/PROC-ECC13160-7AFF-4D5B-8E73-E5B98BB9A59B?%E5%BA%93%E5%AD%98%E6%B5%81%E6%B0%B4&psi_stock_flow&fromPage=home">https://tj-ali-crm-test.tangees.com/tungee/crm/mobile/?corpid=dinge18b222ec5637b04ffe93478753d9884#/form/PROC-ECC13160-7AFF-4D5B-8E73-E5B98BB9A59B?库存流水&amp;psi_stock_flow&amp;fromPage=home</a></para>
            /// </summary>
            [NameInMap("mobileUrl")]
            [Validation(Required=false)]
            public string MobileUrl { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lowcode_customize_form</para>
            /// </summary>
            [NameInMap("navCode")]
            [Validation(Required=false)]
            public string NavCode { get; set; }

            [NameInMap("navExtInfo")]
            [Validation(Required=false)]
            public UpdateMenuDataRequestNavDataNavExtInfo NavExtInfo { get; set; }
            public class UpdateMenuDataRequestNavDataNavExtInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>oem</para>
                /// </summary>
                [NameInMap("productMode")]
                [Validation(Required=false)]
                public string ProductMode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>tj</para>
                /// </summary>
                [NameInMap("provider")]
                [Validation(Required=false)]
                public string Provider { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lowcode_customize_form:PROC-0279E824-ED47-4E75-86F2-11B665F3704D</para>
            /// </summary>
            [NameInMap("navId")]
            [Validation(Required=false)]
            public string NavId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>库存流水</para>
            /// </summary>
            [NameInMap("navName")]
            [Validation(Required=false)]
            public string NavName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PUBLISHED</para>
            /// </summary>
            [NameInMap("navStatus")]
            [Validation(Required=false)]
            public string NavStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>item</para>
            /// </summary>
            [NameInMap("navType")]
            [Validation(Required=false)]
            public string NavType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>crm_product</para>
            /// </summary>
            [NameInMap("parentNavId")]
            [Validation(Required=false)]
            public string ParentNavId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>tj</para>
            /// </summary>
            [NameInMap("provider")]
            [Validation(Required=false)]
            public string Provider { get; set; }

            [NameInMap("sortNum")]
            [Validation(Required=false)]
            public int? SortNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>/form/PROC-ECC13160-7AFF-4D5B-8E73-E5B98BB9A59B?bizType=psi_stock_flow&amp;formName=库存流水</para>
            /// </summary>
            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>add</para>
        /// </summary>
        [NameInMap("operateType")]
        [Validation(Required=false)]
        public string OperateType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16044739461008808646</para>
        /// </summary>
        [NameInMap("operatorUserId")]
        [Validation(Required=false)]
        public string OperatorUserId { get; set; }

    }

}
