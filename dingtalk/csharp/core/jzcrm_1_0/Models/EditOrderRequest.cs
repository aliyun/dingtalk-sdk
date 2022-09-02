// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkjzcrm_1_0.Models
{
    public class EditOrderRequest : TeaModel {
        /// <summary>
        /// 编辑数据
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public EditOrderRequestData Data { get; set; }
        public class EditOrderRequestData : TeaModel {
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
            /// 收货地址
            /// </summary>
            [NameInMap("fahuoaddressid")]
            [Validation(Required=false)]
            public string Fahuoaddressid { get; set; }

            /// <summary>
            /// 开始日期
            /// </summary>
            [NameInMap("ht_begindate")]
            [Validation(Required=false)]
            public string HtBegindate { get; set; }

            /// <summary>
            /// 合同正文
            /// </summary>
            [NameInMap("ht_contract")]
            [Validation(Required=false)]
            public string HtContract { get; set; }

            /// <summary>
            /// 对应客户
            /// </summary>
            [NameInMap("ht_customerid")]
            [Validation(Required=false)]
            public string HtCustomerid { get; set; }

            /// <summary>
            /// 客户签约人
            /// </summary>
            [NameInMap("ht_cusub")]
            [Validation(Required=false)]
            public string HtCusub { get; set; }

            /// <summary>
            /// 签单日期
            /// </summary>
            [NameInMap("ht_date")]
            [Validation(Required=false)]
            public string HtDate { get; set; }

            /// <summary>
            /// 交付地点
            /// </summary>
            [NameInMap("ht_deliplace")]
            [Validation(Required=false)]
            public string HtDeliplace { get; set; }

            /// <summary>
            /// 最晚发货日
            /// </summary>
            [NameInMap("ht_enddate")]
            [Validation(Required=false)]
            public string HtEnddate { get; set; }

            /// <summary>
            /// 附加费用金额
            /// </summary>
            [NameInMap("ht_fjmoney")]
            [Validation(Required=false)]
            public string HtFjmoney { get; set; }

            /// <summary>
            /// 附加费用分类
            /// </summary>
            [NameInMap("ht_fjmoneylx")]
            [Validation(Required=false)]
            public string HtFjmoneylx { get; set; }

            /// <summary>
            /// 优惠抹零金额
            /// </summary>
            [NameInMap("ht_kjmoney")]
            [Validation(Required=false)]
            public string HtKjmoney { get; set; }

            /// <summary>
            /// 对应联系人
            /// </summary>
            [NameInMap("ht_lxrid")]
            [Validation(Required=false)]
            public string HtLxrid { get; set; }

            /// <summary>
            /// 联系方式
            /// </summary>
            [NameInMap("ht_lxrinfo")]
            [Validation(Required=false)]
            public string HtLxrinfo { get; set; }

            /// <summary>
            /// 优惠折扣率
            /// </summary>
            [NameInMap("ht_moneyzhekou")]
            [Validation(Required=false)]
            public string HtMoneyzhekou { get; set; }

            /// <summary>
            /// 合同单号
            /// </summary>
            [NameInMap("ht_number")]
            [Validation(Required=false)]
            public string HtNumber { get; set; }

            /// <summary>
            /// 单据类型（合同，合同订单，店面单）
            /// </summary>
            [NameInMap("ht_order")]
            [Validation(Required=false)]
            public string HtOrder { get; set; }

            /// <summary>
            /// 付款方式
            /// </summary>
            [NameInMap("ht_paymode")]
            [Validation(Required=false)]
            public string HtPaymode { get; set; }

            /// <summary>
            /// 所有者
            /// </summary>
            [NameInMap("ht_preside")]
            [Validation(Required=false)]
            public string HtPreside { get; set; }

            /// <summary>
            /// 备注
            /// </summary>
            [NameInMap("ht_remark")]
            [Validation(Required=false)]
            public string HtRemark { get; set; }

            /// <summary>
            /// 状态
            /// </summary>
            [NameInMap("ht_state")]
            [Validation(Required=false)]
            public string HtState { get; set; }

            /// <summary>
            /// 外币备注
            /// </summary>
            [NameInMap("ht_summemo")]
            [Validation(Required=false)]
            public string HtSummemo { get; set; }

            /// <summary>
            /// 总金额
            /// </summary>
            [NameInMap("ht_summoney")]
            [Validation(Required=false)]
            public string HtSummoney { get; set; }

            /// <summary>
            /// 主题
            /// </summary>
            [NameInMap("ht_title")]
            [Validation(Required=false)]
            public string HtTitle { get; set; }

            /// <summary>
            /// 分类
            /// </summary>
            [NameInMap("ht_type")]
            [Validation(Required=false)]
            public string HtType { get; set; }

            /// <summary>
            /// 我方签约人
            /// </summary>
            [NameInMap("ht_wesub")]
            [Validation(Required=false)]
            public string HtWesub { get; set; }

            /// <summary>
            /// 发货方式
            /// </summary>
            [NameInMap("ht_wuliutype")]
            [Validation(Required=false)]
            public string HtWuliutype { get; set; }

            /// <summary>
            /// 对应机会
            /// </summary>
            [NameInMap("ht_xshid")]
            [Validation(Required=false)]
            public string HtXshid { get; set; }

            /// <summary>
            /// 预计运费
            /// </summary>
            [NameInMap("ht_yunfeimoney")]
            [Validation(Required=false)]
            public string HtYunfeimoney { get; set; }

        }

        /// <summary>
        /// 数据类型，固定填写150
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
