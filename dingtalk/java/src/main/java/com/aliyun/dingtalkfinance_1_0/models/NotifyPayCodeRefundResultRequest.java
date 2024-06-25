// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class NotifyPayCodeRefundResultRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>ding1234</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>2021-11-11 11:11:11</p>
     */
    @NameInMap("gmtRefund")
    public String gmtRefund;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("payChannelDetailList")
    public java.util.List<NotifyPayCodeRefundResultRequestPayChannelDetailList> payChannelDetailList;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>payCode</p>
     */
    @NameInMap("payCode")
    public String payCode;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1.00</p>
     */
    @NameInMap("refundAmount")
    public String refundAmount;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>refundOrderNo</p>
     */
    @NameInMap("refundOrderNo")
    public String refundOrderNo;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>0.00</p>
     */
    @NameInMap("refundPromotionAmount")
    public String refundPromotionAmount;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>晚餐退款</p>
     */
    @NameInMap("remark")
    public String remark;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>tradeNo</p>
     */
    @NameInMap("tradeNo")
    public String tradeNo;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>userId</p>
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
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1.00</p>
         */
        @NameInMap("amount")
        public String amount;

        @NameInMap("extInfo")
        public String extInfo;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>余额</p>
         */
        @NameInMap("fundToolName")
        public String fundToolName;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>2021-05-31 11:11:11</p>
         */
        @NameInMap("gmtCreate")
        public String gmtCreate;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>2021-05-31 11:11:11</p>
         */
        @NameInMap("gmtFinish")
        public String gmtFinish;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>true</p>
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
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1.00</p>
         */
        @NameInMap("amount")
        public String amount;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("fundToolDetailList")
        public java.util.List<NotifyPayCodeRefundResultRequestPayChannelDetailListFundToolDetailList> fundToolDetailList;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>ALIPAY</p>
         */
        @NameInMap("payChannelName")
        public String payChannelName;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>20210531123456</p>
         */
        @NameInMap("payChannelOrderNo")
        public String payChannelOrderNo;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>2021053112345678</p>
         */
        @NameInMap("payChannelRefundOrderNo")
        public String payChannelRefundOrderNo;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>ALIPAY</p>
         */
        @NameInMap("payChannelType")
        public String payChannelType;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>0.00</p>
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
