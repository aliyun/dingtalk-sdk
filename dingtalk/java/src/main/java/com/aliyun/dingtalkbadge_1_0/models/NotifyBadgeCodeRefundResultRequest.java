// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbadge_1_0.models;

import com.aliyun.tea.*;

public class NotifyBadgeCodeRefundResultRequest extends TeaModel {
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
    public java.util.List<NotifyBadgeCodeRefundResultRequestPayChannelDetailList> payChannelDetailList;

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

    public static NotifyBadgeCodeRefundResultRequest build(java.util.Map<String, ?> map) throws Exception {
        NotifyBadgeCodeRefundResultRequest self = new NotifyBadgeCodeRefundResultRequest();
        return TeaModel.build(map, self);
    }

    public NotifyBadgeCodeRefundResultRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public NotifyBadgeCodeRefundResultRequest setGmtRefund(String gmtRefund) {
        this.gmtRefund = gmtRefund;
        return this;
    }
    public String getGmtRefund() {
        return this.gmtRefund;
    }

    public NotifyBadgeCodeRefundResultRequest setPayChannelDetailList(java.util.List<NotifyBadgeCodeRefundResultRequestPayChannelDetailList> payChannelDetailList) {
        this.payChannelDetailList = payChannelDetailList;
        return this;
    }
    public java.util.List<NotifyBadgeCodeRefundResultRequestPayChannelDetailList> getPayChannelDetailList() {
        return this.payChannelDetailList;
    }

    public NotifyBadgeCodeRefundResultRequest setPayCode(String payCode) {
        this.payCode = payCode;
        return this;
    }
    public String getPayCode() {
        return this.payCode;
    }

    public NotifyBadgeCodeRefundResultRequest setRefundAmount(String refundAmount) {
        this.refundAmount = refundAmount;
        return this;
    }
    public String getRefundAmount() {
        return this.refundAmount;
    }

    public NotifyBadgeCodeRefundResultRequest setRefundOrderNo(String refundOrderNo) {
        this.refundOrderNo = refundOrderNo;
        return this;
    }
    public String getRefundOrderNo() {
        return this.refundOrderNo;
    }

    public NotifyBadgeCodeRefundResultRequest setRefundPromotionAmount(String refundPromotionAmount) {
        this.refundPromotionAmount = refundPromotionAmount;
        return this;
    }
    public String getRefundPromotionAmount() {
        return this.refundPromotionAmount;
    }

    public NotifyBadgeCodeRefundResultRequest setRemark(String remark) {
        this.remark = remark;
        return this;
    }
    public String getRemark() {
        return this.remark;
    }

    public NotifyBadgeCodeRefundResultRequest setTradeNo(String tradeNo) {
        this.tradeNo = tradeNo;
        return this;
    }
    public String getTradeNo() {
        return this.tradeNo;
    }

    public NotifyBadgeCodeRefundResultRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public static class NotifyBadgeCodeRefundResultRequestPayChannelDetailListFundToolDetailList extends TeaModel {
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

        public static NotifyBadgeCodeRefundResultRequestPayChannelDetailListFundToolDetailList build(java.util.Map<String, ?> map) throws Exception {
            NotifyBadgeCodeRefundResultRequestPayChannelDetailListFundToolDetailList self = new NotifyBadgeCodeRefundResultRequestPayChannelDetailListFundToolDetailList();
            return TeaModel.build(map, self);
        }

        public NotifyBadgeCodeRefundResultRequestPayChannelDetailListFundToolDetailList setAmount(String amount) {
            this.amount = amount;
            return this;
        }
        public String getAmount() {
            return this.amount;
        }

        public NotifyBadgeCodeRefundResultRequestPayChannelDetailListFundToolDetailList setExtInfo(String extInfo) {
            this.extInfo = extInfo;
            return this;
        }
        public String getExtInfo() {
            return this.extInfo;
        }

        public NotifyBadgeCodeRefundResultRequestPayChannelDetailListFundToolDetailList setFundToolName(String fundToolName) {
            this.fundToolName = fundToolName;
            return this;
        }
        public String getFundToolName() {
            return this.fundToolName;
        }

        public NotifyBadgeCodeRefundResultRequestPayChannelDetailListFundToolDetailList setGmtCreate(String gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public String getGmtCreate() {
            return this.gmtCreate;
        }

        public NotifyBadgeCodeRefundResultRequestPayChannelDetailListFundToolDetailList setGmtFinish(String gmtFinish) {
            this.gmtFinish = gmtFinish;
            return this;
        }
        public String getGmtFinish() {
            return this.gmtFinish;
        }

        public NotifyBadgeCodeRefundResultRequestPayChannelDetailListFundToolDetailList setPromotionFundTool(Boolean promotionFundTool) {
            this.promotionFundTool = promotionFundTool;
            return this;
        }
        public Boolean getPromotionFundTool() {
            return this.promotionFundTool;
        }

    }

    public static class NotifyBadgeCodeRefundResultRequestPayChannelDetailList extends TeaModel {
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
        public java.util.List<NotifyBadgeCodeRefundResultRequestPayChannelDetailListFundToolDetailList> fundToolDetailList;

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

        public static NotifyBadgeCodeRefundResultRequestPayChannelDetailList build(java.util.Map<String, ?> map) throws Exception {
            NotifyBadgeCodeRefundResultRequestPayChannelDetailList self = new NotifyBadgeCodeRefundResultRequestPayChannelDetailList();
            return TeaModel.build(map, self);
        }

        public NotifyBadgeCodeRefundResultRequestPayChannelDetailList setAmount(String amount) {
            this.amount = amount;
            return this;
        }
        public String getAmount() {
            return this.amount;
        }

        public NotifyBadgeCodeRefundResultRequestPayChannelDetailList setFundToolDetailList(java.util.List<NotifyBadgeCodeRefundResultRequestPayChannelDetailListFundToolDetailList> fundToolDetailList) {
            this.fundToolDetailList = fundToolDetailList;
            return this;
        }
        public java.util.List<NotifyBadgeCodeRefundResultRequestPayChannelDetailListFundToolDetailList> getFundToolDetailList() {
            return this.fundToolDetailList;
        }

        public NotifyBadgeCodeRefundResultRequestPayChannelDetailList setPayChannelName(String payChannelName) {
            this.payChannelName = payChannelName;
            return this;
        }
        public String getPayChannelName() {
            return this.payChannelName;
        }

        public NotifyBadgeCodeRefundResultRequestPayChannelDetailList setPayChannelOrderNo(String payChannelOrderNo) {
            this.payChannelOrderNo = payChannelOrderNo;
            return this;
        }
        public String getPayChannelOrderNo() {
            return this.payChannelOrderNo;
        }

        public NotifyBadgeCodeRefundResultRequestPayChannelDetailList setPayChannelRefundOrderNo(String payChannelRefundOrderNo) {
            this.payChannelRefundOrderNo = payChannelRefundOrderNo;
            return this;
        }
        public String getPayChannelRefundOrderNo() {
            return this.payChannelRefundOrderNo;
        }

        public NotifyBadgeCodeRefundResultRequestPayChannelDetailList setPayChannelType(String payChannelType) {
            this.payChannelType = payChannelType;
            return this;
        }
        public String getPayChannelType() {
            return this.payChannelType;
        }

        public NotifyBadgeCodeRefundResultRequestPayChannelDetailList setPromotionAmount(String promotionAmount) {
            this.promotionAmount = promotionAmount;
            return this;
        }
        public String getPromotionAmount() {
            return this.promotionAmount;
        }

    }

}
