// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class NotifyPayCodeRefundResultRequest extends TeaModel {
    // 企业id
    @NameInMap("corpId")
    public String corpId;

    // 退款时间
    @NameInMap("gmtRefund")
    public String gmtRefund;

    // 支付渠道信息
    @NameInMap("payChannelDetailList")
    public java.util.List<NotifyPayCodeRefundResultRequestPayChannelDetailList> payChannelDetailList;

    // 支付时使用的付款码
    @NameInMap("payCode")
    public String payCode;

    // 退款金额
    @NameInMap("refundAmount")
    public String refundAmount;

    // 本次退款订单号
    @NameInMap("refundOrderNo")
    public String refundOrderNo;

    // 退款的优惠金额
    @NameInMap("refundPromotionAmount")
    public String refundPromotionAmount;

    // 备注
    @NameInMap("remark")
    public String remark;

    // 交易订单号
    @NameInMap("tradeNo")
    public String tradeNo;

    // 用户id
    @NameInMap("userId")
    public String userId;

    public static NotifyPayCodeRefundResultRequest build(java.util.Map<String, ?> map) throws Exception {
        NotifyPayCodeRefundResultRequest self = new NotifyPayCodeRefundResultRequest();
        return TeaModel.build(map, self);
    }

    public NotifyPayCodeRefundResultRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public NotifyPayCodeRefundResultRequest setGmtRefund(String gmtRefund) {
        this.gmtRefund = gmtRefund;
        return this;
    }
    public String getGmtRefund() {
        return this.gmtRefund;
    }

    public NotifyPayCodeRefundResultRequest setPayChannelDetailList(java.util.List<NotifyPayCodeRefundResultRequestPayChannelDetailList> payChannelDetailList) {
        this.payChannelDetailList = payChannelDetailList;
        return this;
    }
    public java.util.List<NotifyPayCodeRefundResultRequestPayChannelDetailList> getPayChannelDetailList() {
        return this.payChannelDetailList;
    }

    public NotifyPayCodeRefundResultRequest setPayCode(String payCode) {
        this.payCode = payCode;
        return this;
    }
    public String getPayCode() {
        return this.payCode;
    }

    public NotifyPayCodeRefundResultRequest setRefundAmount(String refundAmount) {
        this.refundAmount = refundAmount;
        return this;
    }
    public String getRefundAmount() {
        return this.refundAmount;
    }

    public NotifyPayCodeRefundResultRequest setRefundOrderNo(String refundOrderNo) {
        this.refundOrderNo = refundOrderNo;
        return this;
    }
    public String getRefundOrderNo() {
        return this.refundOrderNo;
    }

    public NotifyPayCodeRefundResultRequest setRefundPromotionAmount(String refundPromotionAmount) {
        this.refundPromotionAmount = refundPromotionAmount;
        return this;
    }
    public String getRefundPromotionAmount() {
        return this.refundPromotionAmount;
    }

    public NotifyPayCodeRefundResultRequest setRemark(String remark) {
        this.remark = remark;
        return this;
    }
    public String getRemark() {
        return this.remark;
    }

    public NotifyPayCodeRefundResultRequest setTradeNo(String tradeNo) {
        this.tradeNo = tradeNo;
        return this;
    }
    public String getTradeNo() {
        return this.tradeNo;
    }

    public NotifyPayCodeRefundResultRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public static class NotifyPayCodeRefundResultRequestPayChannelDetailListFundToolDetailList extends TeaModel {
        // 金额
        @NameInMap("amount")
        public String amount;

        // 扩展信息
        @NameInMap("extInfo")
        public String extInfo;

        // 资金工具名称
        @NameInMap("fundToolName")
        public String fundToolName;

        // 创建时间
        @NameInMap("gmtCreate")
        public String gmtCreate;

        // 完成时间
        @NameInMap("gmtFinish")
        public String gmtFinish;

        // 是否是优惠工具
        @NameInMap("promotionFundTool")
        public Boolean promotionFundTool;

        public static NotifyPayCodeRefundResultRequestPayChannelDetailListFundToolDetailList build(java.util.Map<String, ?> map) throws Exception {
            NotifyPayCodeRefundResultRequestPayChannelDetailListFundToolDetailList self = new NotifyPayCodeRefundResultRequestPayChannelDetailListFundToolDetailList();
            return TeaModel.build(map, self);
        }

        public NotifyPayCodeRefundResultRequestPayChannelDetailListFundToolDetailList setAmount(String amount) {
            this.amount = amount;
            return this;
        }
        public String getAmount() {
            return this.amount;
        }

        public NotifyPayCodeRefundResultRequestPayChannelDetailListFundToolDetailList setExtInfo(String extInfo) {
            this.extInfo = extInfo;
            return this;
        }
        public String getExtInfo() {
            return this.extInfo;
        }

        public NotifyPayCodeRefundResultRequestPayChannelDetailListFundToolDetailList setFundToolName(String fundToolName) {
            this.fundToolName = fundToolName;
            return this;
        }
        public String getFundToolName() {
            return this.fundToolName;
        }

        public NotifyPayCodeRefundResultRequestPayChannelDetailListFundToolDetailList setGmtCreate(String gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public String getGmtCreate() {
            return this.gmtCreate;
        }

        public NotifyPayCodeRefundResultRequestPayChannelDetailListFundToolDetailList setGmtFinish(String gmtFinish) {
            this.gmtFinish = gmtFinish;
            return this;
        }
        public String getGmtFinish() {
            return this.gmtFinish;
        }

        public NotifyPayCodeRefundResultRequestPayChannelDetailListFundToolDetailList setPromotionFundTool(Boolean promotionFundTool) {
            this.promotionFundTool = promotionFundTool;
            return this;
        }
        public Boolean getPromotionFundTool() {
            return this.promotionFundTool;
        }

    }

    public static class NotifyPayCodeRefundResultRequestPayChannelDetailList extends TeaModel {
        // 金额
        @NameInMap("amount")
        public String amount;

        // 支付资金列表
        @NameInMap("fundToolDetailList")
        public java.util.List<NotifyPayCodeRefundResultRequestPayChannelDetailListFundToolDetailList> fundToolDetailList;

        // 支付渠道名称
        @NameInMap("payChannelName")
        public String payChannelName;

        // 支付渠道号
        @NameInMap("payChannelOrderNo")
        public String payChannelOrderNo;

        // 支付渠道退款号
        @NameInMap("payChannelRefundOrderNo")
        public String payChannelRefundOrderNo;

        // 支付渠道类型
        @NameInMap("payChannelType")
        public String payChannelType;

        // 优惠金额
        @NameInMap("promotionAmount")
        public String promotionAmount;

        public static NotifyPayCodeRefundResultRequestPayChannelDetailList build(java.util.Map<String, ?> map) throws Exception {
            NotifyPayCodeRefundResultRequestPayChannelDetailList self = new NotifyPayCodeRefundResultRequestPayChannelDetailList();
            return TeaModel.build(map, self);
        }

        public NotifyPayCodeRefundResultRequestPayChannelDetailList setAmount(String amount) {
            this.amount = amount;
            return this;
        }
        public String getAmount() {
            return this.amount;
        }

        public NotifyPayCodeRefundResultRequestPayChannelDetailList setFundToolDetailList(java.util.List<NotifyPayCodeRefundResultRequestPayChannelDetailListFundToolDetailList> fundToolDetailList) {
            this.fundToolDetailList = fundToolDetailList;
            return this;
        }
        public java.util.List<NotifyPayCodeRefundResultRequestPayChannelDetailListFundToolDetailList> getFundToolDetailList() {
            return this.fundToolDetailList;
        }

        public NotifyPayCodeRefundResultRequestPayChannelDetailList setPayChannelName(String payChannelName) {
            this.payChannelName = payChannelName;
            return this;
        }
        public String getPayChannelName() {
            return this.payChannelName;
        }

        public NotifyPayCodeRefundResultRequestPayChannelDetailList setPayChannelOrderNo(String payChannelOrderNo) {
            this.payChannelOrderNo = payChannelOrderNo;
            return this;
        }
        public String getPayChannelOrderNo() {
            return this.payChannelOrderNo;
        }

        public NotifyPayCodeRefundResultRequestPayChannelDetailList setPayChannelRefundOrderNo(String payChannelRefundOrderNo) {
            this.payChannelRefundOrderNo = payChannelRefundOrderNo;
            return this;
        }
        public String getPayChannelRefundOrderNo() {
            return this.payChannelRefundOrderNo;
        }

        public NotifyPayCodeRefundResultRequestPayChannelDetailList setPayChannelType(String payChannelType) {
            this.payChannelType = payChannelType;
            return this;
        }
        public String getPayChannelType() {
            return this.payChannelType;
        }

        public NotifyPayCodeRefundResultRequestPayChannelDetailList setPromotionAmount(String promotionAmount) {
            this.promotionAmount = promotionAmount;
            return this;
        }
        public String getPromotionAmount() {
            return this.promotionAmount;
        }

    }

}
