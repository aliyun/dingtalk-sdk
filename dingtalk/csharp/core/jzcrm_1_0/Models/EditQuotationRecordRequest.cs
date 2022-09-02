// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkjzcrm_1_0.Models
{
    public class EditQuotationRecordRequest : TeaModel {
        /// <summary>
        /// 编辑数据
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public EditQuotationRecordRequestData Data { get; set; }
        public class EditQuotationRecordRequestData : TeaModel {
            /// <summary>
            /// 报价人
            /// </summary>
            [NameInMap("bj_bjren")]
            [Validation(Required=false)]
            public string BjBjren { get; set; }

            /// <summary>
            /// 包装运输
            /// </summary>
            [NameInMap("bj_bzremark")]
            [Validation(Required=false)]
            public string BjBzremark { get; set; }

            /// <summary>
            /// 对应客户
            /// </summary>
            [NameInMap("bj_customerid")]
            [Validation(Required=false)]
            public string BjCustomerid { get; set; }

            /// <summary>
            /// 报价日期
            /// </summary>
            [NameInMap("bj_date")]
            [Validation(Required=false)]
            public string BjDate { get; set; }

            /// <summary>
            /// 附加费用金额
            /// </summary>
            [NameInMap("bj_fjmoney")]
            [Validation(Required=false)]
            public string BjFjmoney { get; set; }

            /// <summary>
            /// 附加费用分类
            /// </summary>
            [NameInMap("bj_fjmoneylx")]
            [Validation(Required=false)]
            public string BjFjmoneylx { get; set; }

            /// <summary>
            /// 付款说明
            /// </summary>
            [NameInMap("bj_fkremark")]
            [Validation(Required=false)]
            public string BjFkremark { get; set; }

            /// <summary>
            /// 交付说明
            /// </summary>
            [NameInMap("bj_jfremark")]
            [Validation(Required=false)]
            public string BjJfremark { get; set; }

            /// <summary>
            /// 接收人
            /// </summary>
            [NameInMap("bj_jshren")]
            [Validation(Required=false)]
            public string BjJshren { get; set; }

            /// <summary>
            /// 优惠抹零金额
            /// </summary>
            [NameInMap("bj_kjmoney")]
            [Validation(Required=false)]
            public string BjKjmoney { get; set; }

            /// <summary>
            /// 联系方式
            /// </summary>
            [NameInMap("bj_lianxi")]
            [Validation(Required=false)]
            public string BjLianxi { get; set; }

            /// <summary>
            /// 优惠折扣率
            /// </summary>
            [NameInMap("bj_moneyzhekou")]
            [Validation(Required=false)]
            public string BjMoneyzhekou { get; set; }

            /// <summary>
            /// 报价单号
            /// </summary>
            [NameInMap("bj_number")]
            [Validation(Required=false)]
            public string BjNumber { get; set; }

            /// <summary>
            /// 报价(总)
            /// </summary>
            [NameInMap("bj_price")]
            [Validation(Required=false)]
            public string BjPrice { get; set; }

            /// <summary>
            /// 备注
            /// </summary>
            [NameInMap("bj_remark")]
            [Validation(Required=false)]
            public string BjRemark { get; set; }

            /// <summary>
            /// 转成订单
            /// </summary>
            [NameInMap("bj_state")]
            [Validation(Required=false)]
            public string BjState { get; set; }

            /// <summary>
            /// 主题
            /// </summary>
            [NameInMap("bj_title")]
            [Validation(Required=false)]
            public string BjTitle { get; set; }

            /// <summary>
            /// 对应机会
            /// </summary>
            [NameInMap("bj_xshid")]
            [Validation(Required=false)]
            public string BjXshid { get; set; }

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

        }

        /// <summary>
        /// 数据类型，固定填写161
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
