// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkjzcrm_1_0.Models
{
    public class EditInvoiceRequest : TeaModel {
        /// <summary>
        /// 编辑数据
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public EditInvoiceRequestData Data { get; set; }
        public class EditInvoiceRequestData : TeaModel {
            /// <summary>
            /// 产品明细，json格式
            /// </summary>
            [NameInMap("child_mx")]
            [Validation(Required=false)]
            public string ChildMx { get; set; }

            /// <summary>
            /// 创建人
            /// </summary>
            [NameInMap("data_userid")]
            [Validation(Required=false)]
            public string DataUserid { get; set; }

            /// <summary>
            /// 地址
            /// </summary>
            [NameInMap("fh_address")]
            [Validation(Required=false)]
            public string FhAddress { get; set; }

            /// <summary>
            /// 对应客户
            /// </summary>
            [NameInMap("fh_customerid")]
            [Validation(Required=false)]
            public string FhCustomerid { get; set; }

            /// <summary>
            /// 发货日期
            /// </summary>
            [NameInMap("fh_date")]
            [Validation(Required=false)]
            public string FhDate { get; set; }

            /// <summary>
            /// Email
            /// </summary>
            [NameInMap("fh_email")]
            [Validation(Required=false)]
            public string FhEmail { get; set; }

            /// <summary>
            /// 手机
            /// </summary>
            [NameInMap("fh_handset")]
            [Validation(Required=false)]
            public string FhHandset { get; set; }

            /// <summary>
            /// 对应订单
            /// </summary>
            [NameInMap("fh_htorder")]
            [Validation(Required=false)]
            public string FhHtorder { get; set; }

            /// <summary>
            /// 打包件数
            /// </summary>
            [NameInMap("fh_jianshu")]
            [Validation(Required=false)]
            public string FhJianshu { get; set; }

            /// <summary>
            /// 重量(Kg)
            /// </summary>
            [NameInMap("fh_kg")]
            [Validation(Required=false)]
            public string FhKg { get; set; }

            /// <summary>
            /// 收货人
            /// </summary>
            [NameInMap("fh_linkman")]
            [Validation(Required=false)]
            public string FhLinkman { get; set; }

            /// <summary>
            /// 联系人
            /// </summary>
            [NameInMap("fh_lxrid")]
            [Validation(Required=false)]
            public string FhLxrid { get; set; }

            /// <summary>
            /// 发货方式
            /// </summary>
            [NameInMap("fh_mode")]
            [Validation(Required=false)]
            public string FhMode { get; set; }

            /// <summary>
            /// MSN
            /// </summary>
            [NameInMap("fh_msn")]
            [Validation(Required=false)]
            public string FhMsn { get; set; }

            /// <summary>
            /// 发货单号
            /// </summary>
            [NameInMap("fh_number")]
            [Validation(Required=false)]
            public string FhNumber { get; set; }

            /// <summary>
            /// 邮编
            /// </summary>
            [NameInMap("fh_post")]
            [Validation(Required=false)]
            public string FhPost { get; set; }

            /// <summary>
            /// 所有者
            /// </summary>
            [NameInMap("fh_preside")]
            [Validation(Required=false)]
            public string FhPreside { get; set; }

            /// <summary>
            /// 备注
            /// </summary>
            [NameInMap("fh_remark")]
            [Validation(Required=false)]
            public string FhRemark { get; set; }

            /// <summary>
            /// 发货人
            /// </summary>
            [NameInMap("fh_shipper")]
            [Validation(Required=false)]
            public string FhShipper { get; set; }

            /// <summary>
            /// 发货状态
            /// </summary>
            [NameInMap("fh_state")]
            [Validation(Required=false)]
            public string FhState { get; set; }

            /// <summary>
            /// 电话
            /// </summary>
            [NameInMap("fh_tel")]
            [Validation(Required=false)]
            public string FhTel { get; set; }

            /// <summary>
            /// 发货主题
            /// </summary>
            [NameInMap("fh_title")]
            [Validation(Required=false)]
            public string FhTitle { get; set; }

            /// <summary>
            /// 运费
            /// </summary>
            [NameInMap("fh_yunfei")]
            [Validation(Required=false)]
            public string FhYunfei { get; set; }

        }

        /// <summary>
        /// 数据类型，固定填写169
        /// </summary>
        [NameInMap("datatype")]
        [Validation(Required=false)]
        public long? Datatype { get; set; }

        /// <summary>
        /// 数据id，不填或者填0为新增数据
        /// </summary>
        [NameInMap("msgid")]
        [Validation(Required=false)]
        public long? Msgid { get; set; }

        /// <summary>
        /// 时间戳
        /// </summary>
        [NameInMap("stamp")]
        [Validation(Required=false)]
        public long? Stamp { get; set; }

    }

}
