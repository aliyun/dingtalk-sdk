// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class NotifyPayCodeRefundResultRequest extends TeaModel {
    /**
     * <p>企业id</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <p>退款时间</p>
     */
    @NameInMap("gmtRefund")
    public String gmtRefund;

    /**
     * <p>支付渠道信息</p>
     */
    @NameInMap("payChannelDetailList")
    public java.util.List<NotifyPayCodeRefundResultRequestPayChannelDetailList> payChannelDetailList;

    /**
     * <p>支付时使用的付款码</p>
     */
    @NameInMap("payCode")
    public String payCode;

    /**
     * <p>退款金额</p>
     */
    @NameInMap("refundAmount")
    public String refundAmount;

    /**
     * <p>本次退款订单号</p>
     */
    @NameInMap("refundOrderNo")
    public String refundOrderNo;

    /**
     * <p>退款的优惠金额</p>
     */
    @NameInMap("refundPromotionAmount")
    public String refundPromotionAmount;

    /**
     * <p>备注</p>
     */
    @NameInMap("remark")
    public String remark;

    /**
     * <p>交易订单号</p>
     */
    @NameInMap("tradeNo")
    public String tradeNo;

    /**
     * <p>用户id</p>
     */
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
        /**
         * <p>金额</p>
         */
        @NameInMap("amount")
        public String amount;

        /**
         * <p>扩展信息</p>
         */
        @NameInMap("extInfo")
        public String extInfo;

        /**
         * <p>资金工具名称</p>
         */
        @NameInMap("fundToolName")
        public String fundToolName;

        /**
         * <p>创建时间</p>
         */
        @NameInMap("gmtCreate")
        public String gmtCreate;

        /**
         * <p>完成时间</p>
         */
        @NameInMap("gmtFinish")
        public String gmtFinish;

        /**
         * <p>是否是优惠工具</p>
         */
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
        /**
         * <p>金额</p>
         */
        @NameInMap("amount")
        public String amount;

        /**
         * <p>支付资金列表</p>
         */
        @NameInMap("fundToolDetailList")
        public java.util.List<NotifyPayCodeRefundResultRequestPayChannelDetailListFundToolDetailList> fundToolDetailList;

        /**
         * <p>支付渠道名称</p>
         */
        @NameInMap("payChannelName")
        public String payChannelName;

        /**
         * <p>支付渠道号</p>
         */
        @NameInMap("payChannelOrderNo")
        public String payChannelOrderNo;

        /**
         * <p>支付渠道退款号</p>
         */
        @NameInMap("payChannelRefundOrderNo")
        public String payChannelRefundOrderNo;

        /**
         * <p>支付渠道类型</p>
         */
        @NameInMap("payChannelType")
        public String payChannelType;

        /**
         * <p>优惠金额</p>
         */
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
