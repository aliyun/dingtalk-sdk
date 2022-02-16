// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class CreateAcquireRefundOrderRequest extends TeaModel {
    // 主机构编号
    @NameInMap("instId")
    public String instId;

    // 操作人userId
    @NameInMap("operatorUserId")
    public String operatorUserId;

    // 原支付单外部流水号
    @NameInMap("originOutTradeNo")
    public String originOutTradeNo;

    // 其他资金渠道退款明细
    @NameInMap("otherPayChannelDetailInfoList")
    public java.util.List<CreateAcquireRefundOrderRequestOtherPayChannelDetailInfoList> otherPayChannelDetailInfoList;

    // 外部退款订单号
    @NameInMap("outRefundNo")
    public String outRefundNo;

    // 退款金额，支持部分退款
    @NameInMap("refundAmount")
    public String refundAmount;

    // 退款备注
    @NameInMap("remark")
    public String remark;

    // 子机构编号
    @NameInMap("subInstId")
    public String subInstId;

    // 代扣标题
    @NameInMap("title")
    public String title;

    public static CreateAcquireRefundOrderRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateAcquireRefundOrderRequest self = new CreateAcquireRefundOrderRequest();
        return TeaModel.build(map, self);
    }

    public CreateAcquireRefundOrderRequest setInstId(String instId) {
        this.instId = instId;
        return this;
    }
    public String getInstId() {
        return this.instId;
    }

    public CreateAcquireRefundOrderRequest setOperatorUserId(String operatorUserId) {
        this.operatorUserId = operatorUserId;
        return this;
    }
    public String getOperatorUserId() {
        return this.operatorUserId;
    }

    public CreateAcquireRefundOrderRequest setOriginOutTradeNo(String originOutTradeNo) {
        this.originOutTradeNo = originOutTradeNo;
        return this;
    }
    public String getOriginOutTradeNo() {
        return this.originOutTradeNo;
    }

    public CreateAcquireRefundOrderRequest setOtherPayChannelDetailInfoList(java.util.List<CreateAcquireRefundOrderRequestOtherPayChannelDetailInfoList> otherPayChannelDetailInfoList) {
        this.otherPayChannelDetailInfoList = otherPayChannelDetailInfoList;
        return this;
    }
    public java.util.List<CreateAcquireRefundOrderRequestOtherPayChannelDetailInfoList> getOtherPayChannelDetailInfoList() {
        return this.otherPayChannelDetailInfoList;
    }

    public CreateAcquireRefundOrderRequest setOutRefundNo(String outRefundNo) {
        this.outRefundNo = outRefundNo;
        return this;
    }
    public String getOutRefundNo() {
        return this.outRefundNo;
    }

    public CreateAcquireRefundOrderRequest setRefundAmount(String refundAmount) {
        this.refundAmount = refundAmount;
        return this;
    }
    public String getRefundAmount() {
        return this.refundAmount;
    }

    public CreateAcquireRefundOrderRequest setRemark(String remark) {
        this.remark = remark;
        return this;
    }
    public String getRemark() {
        return this.remark;
    }

    public CreateAcquireRefundOrderRequest setSubInstId(String subInstId) {
        this.subInstId = subInstId;
        return this;
    }
    public String getSubInstId() {
        return this.subInstId;
    }

    public CreateAcquireRefundOrderRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public static class CreateAcquireRefundOrderRequestOtherPayChannelDetailInfoListFundToolDetailInfoList extends TeaModel {
        // 金额
        @NameInMap("amount")
        public String amount;

        // 扩展信息
        @NameInMap("extInfo")
        public String extInfo;

        // 资金工具名称
        @NameInMap("fundToolName")
        public String fundToolName;

        // 资金明细创建时间
        @NameInMap("gmtCreate")
        public String gmtCreate;

        // 资金明细完成时间
        @NameInMap("gmtFinish")
        public String gmtFinish;

        // 是否是优惠工具
        @NameInMap("promotionFundTool")
        public Boolean promotionFundTool;

        public static CreateAcquireRefundOrderRequestOtherPayChannelDetailInfoListFundToolDetailInfoList build(java.util.Map<String, ?> map) throws Exception {
            CreateAcquireRefundOrderRequestOtherPayChannelDetailInfoListFundToolDetailInfoList self = new CreateAcquireRefundOrderRequestOtherPayChannelDetailInfoListFundToolDetailInfoList();
            return TeaModel.build(map, self);
        }

        public CreateAcquireRefundOrderRequestOtherPayChannelDetailInfoListFundToolDetailInfoList setAmount(String amount) {
            this.amount = amount;
            return this;
        }
        public String getAmount() {
            return this.amount;
        }

        public CreateAcquireRefundOrderRequestOtherPayChannelDetailInfoListFundToolDetailInfoList setExtInfo(String extInfo) {
            this.extInfo = extInfo;
            return this;
        }
        public String getExtInfo() {
            return this.extInfo;
        }

        public CreateAcquireRefundOrderRequestOtherPayChannelDetailInfoListFundToolDetailInfoList setFundToolName(String fundToolName) {
            this.fundToolName = fundToolName;
            return this;
        }
        public String getFundToolName() {
            return this.fundToolName;
        }

        public CreateAcquireRefundOrderRequestOtherPayChannelDetailInfoListFundToolDetailInfoList setGmtCreate(String gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public String getGmtCreate() {
            return this.gmtCreate;
        }

        public CreateAcquireRefundOrderRequestOtherPayChannelDetailInfoListFundToolDetailInfoList setGmtFinish(String gmtFinish) {
            this.gmtFinish = gmtFinish;
            return this;
        }
        public String getGmtFinish() {
            return this.gmtFinish;
        }

        public CreateAcquireRefundOrderRequestOtherPayChannelDetailInfoListFundToolDetailInfoList setPromotionFundTool(Boolean promotionFundTool) {
            this.promotionFundTool = promotionFundTool;
            return this;
        }
        public Boolean getPromotionFundTool() {
            return this.promotionFundTool;
        }

    }

    public static class CreateAcquireRefundOrderRequestOtherPayChannelDetailInfoList extends TeaModel {
        // 渠道金额
        @NameInMap("amount")
        public String amount;

        // 资金明细列表
        @NameInMap("fundToolDetailInfoList")
        public java.util.List<CreateAcquireRefundOrderRequestOtherPayChannelDetailInfoListFundToolDetailInfoList> fundToolDetailInfoList;

        // 渠道名称
        @NameInMap("payChannelName")
        public String payChannelName;

        // 支付渠道单号
        @NameInMap("payChannelOrderNo")
        public String payChannelOrderNo;

        // 渠道类型
        @NameInMap("payChannelType")
        public String payChannelType;

        // 总优惠金额
        @NameInMap("promotionAmount")
        public String promotionAmount;

        public static CreateAcquireRefundOrderRequestOtherPayChannelDetailInfoList build(java.util.Map<String, ?> map) throws Exception {
            CreateAcquireRefundOrderRequestOtherPayChannelDetailInfoList self = new CreateAcquireRefundOrderRequestOtherPayChannelDetailInfoList();
            return TeaModel.build(map, self);
        }

        public CreateAcquireRefundOrderRequestOtherPayChannelDetailInfoList setAmount(String amount) {
            this.amount = amount;
            return this;
        }
        public String getAmount() {
            return this.amount;
        }

        public CreateAcquireRefundOrderRequestOtherPayChannelDetailInfoList setFundToolDetailInfoList(java.util.List<CreateAcquireRefundOrderRequestOtherPayChannelDetailInfoListFundToolDetailInfoList> fundToolDetailInfoList) {
            this.fundToolDetailInfoList = fundToolDetailInfoList;
            return this;
        }
        public java.util.List<CreateAcquireRefundOrderRequestOtherPayChannelDetailInfoListFundToolDetailInfoList> getFundToolDetailInfoList() {
            return this.fundToolDetailInfoList;
        }

        public CreateAcquireRefundOrderRequestOtherPayChannelDetailInfoList setPayChannelName(String payChannelName) {
            this.payChannelName = payChannelName;
            return this;
        }
        public String getPayChannelName() {
            return this.payChannelName;
        }

        public CreateAcquireRefundOrderRequestOtherPayChannelDetailInfoList setPayChannelOrderNo(String payChannelOrderNo) {
            this.payChannelOrderNo = payChannelOrderNo;
            return this;
        }
        public String getPayChannelOrderNo() {
            return this.payChannelOrderNo;
        }

        public CreateAcquireRefundOrderRequestOtherPayChannelDetailInfoList setPayChannelType(String payChannelType) {
            this.payChannelType = payChannelType;
            return this;
        }
        public String getPayChannelType() {
            return this.payChannelType;
        }

        public CreateAcquireRefundOrderRequestOtherPayChannelDetailInfoList setPromotionAmount(String promotionAmount) {
            this.promotionAmount = promotionAmount;
            return this;
        }
        public String getPromotionAmount() {
            return this.promotionAmount;
        }

    }

}
