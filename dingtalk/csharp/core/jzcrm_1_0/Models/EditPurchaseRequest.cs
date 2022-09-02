// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkjzcrm_1_0.Models
{
    public class EditPurchaseRequest : TeaModel {
        /// <summary>
        /// 编辑数据
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public EditPurchaseRequestData Data { get; set; }
        public class EditPurchaseRequestData : TeaModel {
            /// <summary>
            /// 附加费用金额
            /// </summary>
            [NameInMap("cg_fjmoney")]
            [Validation(Required=false)]
            public string CgFjmoney { get; set; }

            /// <summary>
            /// 附加费用分类
            /// </summary>
            [NameInMap("cg_fjmoneylx")]
            [Validation(Required=false)]
            public string CgFjmoneylx { get; set; }

            /// <summary>
            /// 优惠抹零金额
            /// </summary>
            [NameInMap("cg_kjmoney")]
            [Validation(Required=false)]
            public string CgKjmoney { get; set; }

            /// <summary>
            /// 优惠折扣率
            /// </summary>
            [NameInMap("cg_moneyzhekou")]
            [Validation(Required=false)]
            public string CgMoneyzhekou { get; set; }

            /// <summary>
            /// 执行状态
            /// </summary>
            [NameInMap("cg_zxstate")]
            [Validation(Required=false)]
            public string CgZxstate { get; set; }

            /// <summary>
            /// 采购日期
            /// </summary>
            [NameInMap("cgdate")]
            [Validation(Required=false)]
            public string Cgdate { get; set; }

            /// <summary>
            /// 采购主题
            /// </summary>
            [NameInMap("cgname")]
            [Validation(Required=false)]
            public string Cgname { get; set; }

            /// <summary>
            /// 采购单号
            /// </summary>
            [NameInMap("cgno")]
            [Validation(Required=false)]
            public string Cgno { get; set; }

            /// <summary>
            /// 采购摘要
            /// </summary>
            [NameInMap("cgremark")]
            [Validation(Required=false)]
            public string Cgremark { get; set; }

            /// <summary>
            /// 采购分类
            /// </summary>
            [NameInMap("cgtype")]
            [Validation(Required=false)]
            public string Cgtype { get; set; }

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
            /// 我方代表
            /// </summary>
            [NameInMap("empid")]
            [Validation(Required=false)]
            public string Empid { get; set; }

            /// <summary>
            /// 供应商联系人
            /// </summary>
            [NameInMap("gys_lxrid")]
            [Validation(Required=false)]
            public string GysLxrid { get; set; }

            /// <summary>
            /// 联系方式
            /// </summary>
            [NameInMap("gys_lxrinfo")]
            [Validation(Required=false)]
            public string GysLxrinfo { get; set; }

            /// <summary>
            /// 供应商
            /// </summary>
            [NameInMap("gysid")]
            [Validation(Required=false)]
            public string Gysid { get; set; }

            /// <summary>
            /// 供应商代表
            /// </summary>
            [NameInMap("gysjingban")]
            [Validation(Required=false)]
            public string Gysjingban { get; set; }

            /// <summary>
            /// 关联订单
            /// </summary>
            [NameInMap("order_htid")]
            [Validation(Required=false)]
            public string OrderHtid { get; set; }

            /// <summary>
            /// 关联订单客户
            /// </summary>
            [NameInMap("order_khid")]
            [Validation(Required=false)]
            public string OrderKhid { get; set; }

            /// <summary>
            /// 采购金额
            /// </summary>
            [NameInMap("summoney")]
            [Validation(Required=false)]
            public string Summoney { get; set; }

        }

        /// <summary>
        /// 数据类型，固定填写153
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
