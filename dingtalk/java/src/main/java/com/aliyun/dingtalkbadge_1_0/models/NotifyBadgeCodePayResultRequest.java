// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbadge_1_0.models;

import com.aliyun.tea.*;

public class NotifyBadgeCodePayResultRequest extends TeaModel {
    /**
     * <p>订单金额</p>
     */
    @NameInMap("amount")
    public String amount;

    /**
     * <p>收费金额</p>
     */
    @NameInMap("chargeAmount")
    public String chargeAmount;

    /**
     * <p>企业id</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <p>扩展信息</p>
     */
    @NameInMap("extInfo")
    public String extInfo;

    /**
     * <p>交易开始时间</p>
     */
    @NameInMap("gmtTradeCreate")
    public String gmtTradeCreate;

    /**
     * <p>交易结束时间</p>
     */
    @NameInMap("gmtTradeFinish")
    public String gmtTradeFinish;

    /**
     * <p>merchantName</p>
     */
    @NameInMap("merchantName")
    public String merchantName;

    /**
     * <p>支付渠道明细信息</p>
     */
    @NameInMap("payChannelDetailList")
    public java.util.List<NotifyBadgeCodePayResultRequestPayChannelDetailList> payChannelDetailList;

    /**
     * <p>付款码值</p>
     */
    @NameInMap("payCode")
    public String payCode;

    /**
     * <p>订单优惠金额</p>
     */
    @NameInMap("promotionAmount")
    public String promotionAmount;

    /**
     * <p>备注</p>
     */
    @NameInMap("remark")
    public String remark;

    /**
     * <p>订单标题</p>
     */
    @NameInMap("title")
    public String title;

    /**
     * <p>支付失败错误码</p>
     */
    @NameInMap("tradeErrorCode")
    public String tradeErrorCode;

    /**
     * <p>支付失败信息</p>
     */
    @NameInMap("tradeErrorMsg")
    public String tradeErrorMsg;

    /**
     * <p>交易号</p>
     */
    @NameInMap("tradeNo")
    public String tradeNo;

    /**
     * <p>交易状态</p>
     */
    @NameInMap("tradeStatus")
    public String tradeStatus;

    /**
     * <p>用户id</p>
     */
    @NameInMap("userId")
    public String userId;

    public static NotifyBadgeCodePayResultRequest build(java.util.Map<String, ?> map) throws Exception {
        NotifyBadgeCodePayResultRequest self = new NotifyBadgeCodePayResultRequest();
        return TeaModel.build(map, self);
    }

    public NotifyBadgeCodePayResultRequest setAmount(String amount) {
        this.amount = amount;
        return this;
    }
    public String getAmount() {
        return this.amount;
    }

    public NotifyBadgeCodePayResultRequest setChargeAmount(String chargeAmount) {
        this.chargeAmount = chargeAmount;
        return this;
    }
    public String getChargeAmount() {
        return this.chargeAmount;
    }

    public NotifyBadgeCodePayResultRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public NotifyBadgeCodePayResultRequest setExtInfo(String extInfo) {
        this.extInfo = extInfo;
        return this;
    }
    public String getExtInfo() {
        return this.extInfo;
    }

    public NotifyBadgeCodePayResultRequest setGmtTradeCreate(String gmtTradeCreate) {
        this.gmtTradeCreate = gmtTradeCreate;
        return this;
    }
    public String getGmtTradeCreate() {
        return this.gmtTradeCreate;
    }

    public NotifyBadgeCodePayResultRequest setGmtTradeFinish(String gmtTradeFinish) {
        this.gmtTradeFinish = gmtTradeFinish;
        return this;
    }
    public String getGmtTradeFinish() {
        return this.gmtTradeFinish;
    }

    public NotifyBadgeCodePayResultRequest setMerchantName(String merchantName) {
        this.merchantName = merchantName;
        return this;
    }
    public String getMerchantName() {
        return this.merchantName;
    }

    public NotifyBadgeCodePayResultRequest setPayChannelDetailList(java.util.List<NotifyBadgeCodePayResultRequestPayChannelDetailList> payChannelDetailList) {
        this.payChannelDetailList = payChannelDetailList;
        return this;
    }
    public java.util.List<NotifyBadgeCodePayResultRequestPayChannelDetailList> getPayChannelDetailList() {
        return this.payChannelDetailList;
    }

    public NotifyBadgeCodePayResultRequest setPayCode(String payCode) {
        this.payCode = payCode;
        return this;
    }
    public String getPayCode() {
        return this.payCode;
    }

    public NotifyBadgeCodePayResultRequest setPromotionAmount(String promotionAmount) {
        this.promotionAmount = promotionAmount;
        return this;
    }
    public String getPromotionAmount() {
        return this.promotionAmount;
    }

    public NotifyBadgeCodePayResultRequest setRemark(String remark) {
        this.remark = remark;
        return this;
    }
    public String getRemark() {
        return this.remark;
    }

    public NotifyBadgeCodePayResultRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public NotifyBadgeCodePayResultRequest setTradeErrorCode(String tradeErrorCode) {
        this.tradeErrorCode = tradeErrorCode;
        return this;
    }
    public String getTradeErrorCode() {
        return this.tradeErrorCode;
    }

    public NotifyBadgeCodePayResultRequest setTradeErrorMsg(String tradeErrorMsg) {
        this.tradeErrorMsg = tradeErrorMsg;
        return this;
    }
    public String getTradeErrorMsg() {
        return this.tradeErrorMsg;
    }

    public NotifyBadgeCodePayResultRequest setTradeNo(String tradeNo) {
        this.tradeNo = tradeNo;
        return this;
    }
    public String getTradeNo() {
        return this.tradeNo;
    }

    public NotifyBadgeCodePayResultRequest setTradeStatus(String tradeStatus) {
        this.tradeStatus = tradeStatus;
        return this;
    }
    public String getTradeStatus() {
        return this.tradeStatus;
    }

    public NotifyBadgeCodePayResultRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public static class NotifyBadgeCodePayResultRequestPayChannelDetailListFundToolDetailList extends TeaModel {
        /**
         * <p>1.00</p>
         */
        @NameInMap("amount")
        public String amount;

        /**
         * <p>扩展信息</p>
         */
        @NameInMap("extInfo")
        public String extInfo;

        /**
         * <p>资金渠道名称</p>
         */
        @NameInMap("fundToolName")
        public String fundToolName;

        /**
         * <p>开始时间</p>
         */
        @NameInMap("gmtCreate")
        public String gmtCreate;

        /**
         * <p>结束时间</p>
         */
        @NameInMap("gmtFinish")
        public String gmtFinish;

        /**
         * <p>是否是优惠工具</p>
         */
        @NameInMap("promotionFundTool")
        public Boolean promotionFundTool;

        public static NotifyBadgeCodePayResultRequestPayChannelDetailListFundToolDetailList build(java.util.Map<String, ?> map) throws Exception {
            NotifyBadgeCodePayResultRequestPayChannelDetailListFundToolDetailList self = new NotifyBadgeCodePayResultRequestPayChannelDetailListFundToolDetailList();
            return TeaModel.build(map, self);
        }

        public NotifyBadgeCodePayResultRequestPayChannelDetailListFundToolDetailList setAmount(String amount) {
            this.amount = amount;
            return this;
        }
        public String getAmount() {
            return this.amount;
        }

        public NotifyBadgeCodePayResultRequestPayChannelDetailListFundToolDetailList setExtInfo(String extInfo) {
            this.extInfo = extInfo;
            return this;
        }
        public String getExtInfo() {
            return this.extInfo;
        }

        public NotifyBadgeCodePayResultRequestPayChannelDetailListFundToolDetailList setFundToolName(String fundToolName) {
            this.fundToolName = fundToolName;
            return this;
        }
        public String getFundToolName() {
            return this.fundToolName;
        }

        public NotifyBadgeCodePayResultRequestPayChannelDetailListFundToolDetailList setGmtCreate(String gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public String getGmtCreate() {
            return this.gmtCreate;
        }

        public NotifyBadgeCodePayResultRequestPayChannelDetailListFundToolDetailList setGmtFinish(String gmtFinish) {
            this.gmtFinish = gmtFinish;
            return this;
        }
        public String getGmtFinish() {
            return this.gmtFinish;
        }

        public NotifyBadgeCodePayResultRequestPayChannelDetailListFundToolDetailList setPromotionFundTool(Boolean promotionFundTool) {
            this.promotionFundTool = promotionFundTool;
            return this;
        }
        public Boolean getPromotionFundTool() {
            return this.promotionFundTool;
        }

    }

    public static class NotifyBadgeCodePayResultRequestPayChannelDetailList extends TeaModel {
        /**
         * <p>支付金额</p>
         */
        @NameInMap("amount")
        public String amount;

        /**
         * <p>资金工具明细</p>
         */
        @NameInMap("fundToolDetailList")
        public java.util.List<NotifyBadgeCodePayResultRequestPayChannelDetailListFundToolDetailList> fundToolDetailList;

        /**
         * <p>开始时间</p>
         */
        @NameInMap("gmtCreate")
        public String gmtCreate;

        /**
         * <p>结束时间</p>
         */
        @NameInMap("gmtFinish")
        public String gmtFinish;

        /**
         * <p>支付渠道名称</p>
         */
        @NameInMap("payChannelName")
        public String payChannelName;

        /**
         * <p>支付渠道单号</p>
         */
        @NameInMap("payChannelOrderNo")
        public String payChannelOrderNo;

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

        public static NotifyBadgeCodePayResultRequestPayChannelDetailList build(java.util.Map<String, ?> map) throws Exception {
            NotifyBadgeCodePayResultRequestPayChannelDetailList self = new NotifyBadgeCodePayResultRequestPayChannelDetailList();
            return TeaModel.build(map, self);
        }

        public NotifyBadgeCodePayResultRequestPayChannelDetailList setAmount(String amount) {
            this.amount = amount;
            return this;
        }
        public String getAmount() {
            return this.amount;
        }

        public NotifyBadgeCodePayResultRequestPayChannelDetailList setFundToolDetailList(java.util.List<NotifyBadgeCodePayResultRequestPayChannelDetailListFundToolDetailList> fundToolDetailList) {
            this.fundToolDetailList = fundToolDetailList;
            return this;
        }
        public java.util.List<NotifyBadgeCodePayResultRequestPayChannelDetailListFundToolDetailList> getFundToolDetailList() {
            return this.fundToolDetailList;
        }

        public NotifyBadgeCodePayResultRequestPayChannelDetailList setGmtCreate(String gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public String getGmtCreate() {
            return this.gmtCreate;
        }

        public NotifyBadgeCodePayResultRequestPayChannelDetailList setGmtFinish(String gmtFinish) {
            this.gmtFinish = gmtFinish;
            return this;
        }
        public String getGmtFinish() {
            return this.gmtFinish;
        }

        public NotifyBadgeCodePayResultRequestPayChannelDetailList setPayChannelName(String payChannelName) {
            this.payChannelName = payChannelName;
            return this;
        }
        public String getPayChannelName() {
            return this.payChannelName;
        }

        public NotifyBadgeCodePayResultRequestPayChannelDetailList setPayChannelOrderNo(String payChannelOrderNo) {
            this.payChannelOrderNo = payChannelOrderNo;
            return this;
        }
        public String getPayChannelOrderNo() {
            return this.payChannelOrderNo;
        }

        public NotifyBadgeCodePayResultRequestPayChannelDetailList setPayChannelType(String payChannelType) {
            this.payChannelType = payChannelType;
            return this;
        }
        public String getPayChannelType() {
            return this.payChannelType;
        }

        public NotifyBadgeCodePayResultRequestPayChannelDetailList setPromotionAmount(String promotionAmount) {
            this.promotionAmount = promotionAmount;
            return this;
        }
        public String getPromotionAmount() {
            return this.promotionAmount;
        }

    }

}
