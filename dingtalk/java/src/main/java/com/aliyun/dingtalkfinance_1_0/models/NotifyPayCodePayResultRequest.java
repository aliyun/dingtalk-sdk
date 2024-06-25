// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class NotifyPayCodePayResultRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1234.56</p>
     */
    @NameInMap("amount")
    public String amount;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1.00, 没有传0.00</p>
     */
    @NameInMap("chargeAmount")
    public String chargeAmount;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>ding1234</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <strong>example:</strong>
     * <p>{ &quot;akey&quot;: &quot;avalue“}</p>
     */
    @NameInMap("extInfo")
    public String extInfo;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>2021-01-01 11:11:11</p>
     */
    @NameInMap("gmtTradeCreate")
    public String gmtTradeCreate;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>2021-01-01 11:11:11</p>
     */
    @NameInMap("gmtTradeFinish")
    public String gmtTradeFinish;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>XX公司食堂</p>
     */
    @NameInMap("merchantName")
    public String merchantName;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("payChannelDetailList")
    public java.util.List<NotifyPayCodePayResultRequestPayChannelDetailList> payChannelDetailList;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>261234567890</p>
     */
    @NameInMap("payCode")
    public String payCode;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1.23，没有传0.00</p>
     */
    @NameInMap("promotionAmount")
    public String promotionAmount;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>备注</p>
     */
    @NameInMap("remark")
    public String remark;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>晚餐100.0元</p>
     */
    @NameInMap("title")
    public String title;

    /**
     * <strong>example:</strong>
     * <p>BALANCE_NOT_ENOUGH</p>
     */
    @NameInMap("tradeErrorCode")
    public String tradeErrorCode;

    /**
     * <strong>example:</strong>
     * <p>余额不足，请充值</p>
     */
    @NameInMap("tradeErrorMsg")
    public String tradeErrorMsg;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>202101012345678</p>
     */
    @NameInMap("tradeNo")
    public String tradeNo;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>SUCCESS/FAIL</p>
     */
    @NameInMap("tradeStatus")
    public String tradeStatus;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>userId1234</p>
     */
    @NameInMap("userId")
    public String userId;

    public static NotifyPayCodePayResultRequest build(java.util.Map<String, ?> map) throws Exception {
        NotifyPayCodePayResultRequest self = new NotifyPayCodePayResultRequest();
        return TeaModel.build(map, self);
    }

    public NotifyPayCodePayResultRequest setAmount(String amount) {
        this.amount = amount;
        return this;
    }
    public String getAmount() {
        return this.amount;
    }

    public NotifyPayCodePayResultRequest setChargeAmount(String chargeAmount) {
        this.chargeAmount = chargeAmount;
        return this;
    }
    public String getChargeAmount() {
        return this.chargeAmount;
    }

    public NotifyPayCodePayResultRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public NotifyPayCodePayResultRequest setExtInfo(String extInfo) {
        this.extInfo = extInfo;
        return this;
    }
    public String getExtInfo() {
        return this.extInfo;
    }

    public NotifyPayCodePayResultRequest setGmtTradeCreate(String gmtTradeCreate) {
        this.gmtTradeCreate = gmtTradeCreate;
        return this;
    }
    public String getGmtTradeCreate() {
        return this.gmtTradeCreate;
    }

    public NotifyPayCodePayResultRequest setGmtTradeFinish(String gmtTradeFinish) {
        this.gmtTradeFinish = gmtTradeFinish;
        return this;
    }
    public String getGmtTradeFinish() {
        return this.gmtTradeFinish;
    }

    public NotifyPayCodePayResultRequest setMerchantName(String merchantName) {
        this.merchantName = merchantName;
        return this;
    }
    public String getMerchantName() {
        return this.merchantName;
    }

    public NotifyPayCodePayResultRequest setPayChannelDetailList(java.util.List<NotifyPayCodePayResultRequestPayChannelDetailList> payChannelDetailList) {
        this.payChannelDetailList = payChannelDetailList;
        return this;
    }
    public java.util.List<NotifyPayCodePayResultRequestPayChannelDetailList> getPayChannelDetailList() {
        return this.payChannelDetailList;
    }

    public NotifyPayCodePayResultRequest setPayCode(String payCode) {
        this.payCode = payCode;
        return this;
    }
    public String getPayCode() {
        return this.payCode;
    }

    public NotifyPayCodePayResultRequest setPromotionAmount(String promotionAmount) {
        this.promotionAmount = promotionAmount;
        return this;
    }
    public String getPromotionAmount() {
        return this.promotionAmount;
    }

    public NotifyPayCodePayResultRequest setRemark(String remark) {
        this.remark = remark;
        return this;
    }
    public String getRemark() {
        return this.remark;
    }

    public NotifyPayCodePayResultRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public NotifyPayCodePayResultRequest setTradeErrorCode(String tradeErrorCode) {
        this.tradeErrorCode = tradeErrorCode;
        return this;
    }
    public String getTradeErrorCode() {
        return this.tradeErrorCode;
    }

    public NotifyPayCodePayResultRequest setTradeErrorMsg(String tradeErrorMsg) {
        this.tradeErrorMsg = tradeErrorMsg;
        return this;
    }
    public String getTradeErrorMsg() {
        return this.tradeErrorMsg;
    }

    public NotifyPayCodePayResultRequest setTradeNo(String tradeNo) {
        this.tradeNo = tradeNo;
        return this;
    }
    public String getTradeNo() {
        return this.tradeNo;
    }

    public NotifyPayCodePayResultRequest setTradeStatus(String tradeStatus) {
        this.tradeStatus = tradeStatus;
        return this;
    }
    public String getTradeStatus() {
        return this.tradeStatus;
    }

    public NotifyPayCodePayResultRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public static class NotifyPayCodePayResultRequestPayChannelDetailListFundToolDetailList extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>金额</p>
         */
        @NameInMap("amount")
        public String amount;

        /**
         * <strong>example:</strong>
         * <p>{&quot;key&quot;:&quot;value&quot;}</p>
         */
        @NameInMap("extInfo")
        public String extInfo;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>优惠券</p>
         */
        @NameInMap("fundToolName")
        public String fundToolName;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>2021-01-01</p>
         */
        @NameInMap("gmtCreate")
        public String gmtCreate;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>2021-01-01 11:11:11</p>
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

        public static NotifyPayCodePayResultRequestPayChannelDetailListFundToolDetailList build(java.util.Map<String, ?> map) throws Exception {
            NotifyPayCodePayResultRequestPayChannelDetailListFundToolDetailList self = new NotifyPayCodePayResultRequestPayChannelDetailListFundToolDetailList();
            return TeaModel.build(map, self);
        }

        public NotifyPayCodePayResultRequestPayChannelDetailListFundToolDetailList setAmount(String amount) {
            this.amount = amount;
            return this;
        }
        public String getAmount() {
            return this.amount;
        }

        public NotifyPayCodePayResultRequestPayChannelDetailListFundToolDetailList setExtInfo(String extInfo) {
            this.extInfo = extInfo;
            return this;
        }
        public String getExtInfo() {
            return this.extInfo;
        }

        public NotifyPayCodePayResultRequestPayChannelDetailListFundToolDetailList setFundToolName(String fundToolName) {
            this.fundToolName = fundToolName;
            return this;
        }
        public String getFundToolName() {
            return this.fundToolName;
        }

        public NotifyPayCodePayResultRequestPayChannelDetailListFundToolDetailList setGmtCreate(String gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public String getGmtCreate() {
            return this.gmtCreate;
        }

        public NotifyPayCodePayResultRequestPayChannelDetailListFundToolDetailList setGmtFinish(String gmtFinish) {
            this.gmtFinish = gmtFinish;
            return this;
        }
        public String getGmtFinish() {
            return this.gmtFinish;
        }

        public NotifyPayCodePayResultRequestPayChannelDetailListFundToolDetailList setPromotionFundTool(Boolean promotionFundTool) {
            this.promotionFundTool = promotionFundTool;
            return this;
        }
        public Boolean getPromotionFundTool() {
            return this.promotionFundTool;
        }

    }

    public static class NotifyPayCodePayResultRequestPayChannelDetailList extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1.23</p>
         */
        @NameInMap("amount")
        public String amount;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("fundToolDetailList")
        public java.util.List<NotifyPayCodePayResultRequestPayChannelDetailListFundToolDetailList> fundToolDetailList;

        /**
         * <strong>example:</strong>
         * <p>2021-01-01 11:11:11</p>
         */
        @NameInMap("gmtCreate")
        public String gmtCreate;

        /**
         * <strong>example:</strong>
         * <p>2021-01-01 11:11:11</p>
         */
        @NameInMap("gmtFinish")
        public String gmtFinish;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>卡余额</p>
         */
        @NameInMap("payChannelName")
        public String payChannelName;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>20211234</p>
         */
        @NameInMap("payChannelOrderNo")
        public String payChannelOrderNo;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>ALIPAY|BALANCE</p>
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

        public static NotifyPayCodePayResultRequestPayChannelDetailList build(java.util.Map<String, ?> map) throws Exception {
            NotifyPayCodePayResultRequestPayChannelDetailList self = new NotifyPayCodePayResultRequestPayChannelDetailList();
            return TeaModel.build(map, self);
        }

        public NotifyPayCodePayResultRequestPayChannelDetailList setAmount(String amount) {
            this.amount = amount;
            return this;
        }
        public String getAmount() {
            return this.amount;
        }

        public NotifyPayCodePayResultRequestPayChannelDetailList setFundToolDetailList(java.util.List<NotifyPayCodePayResultRequestPayChannelDetailListFundToolDetailList> fundToolDetailList) {
            this.fundToolDetailList = fundToolDetailList;
            return this;
        }
        public java.util.List<NotifyPayCodePayResultRequestPayChannelDetailListFundToolDetailList> getFundToolDetailList() {
            return this.fundToolDetailList;
        }

        public NotifyPayCodePayResultRequestPayChannelDetailList setGmtCreate(String gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public String getGmtCreate() {
            return this.gmtCreate;
        }

        public NotifyPayCodePayResultRequestPayChannelDetailList setGmtFinish(String gmtFinish) {
            this.gmtFinish = gmtFinish;
            return this;
        }
        public String getGmtFinish() {
            return this.gmtFinish;
        }

        public NotifyPayCodePayResultRequestPayChannelDetailList setPayChannelName(String payChannelName) {
            this.payChannelName = payChannelName;
            return this;
        }
        public String getPayChannelName() {
            return this.payChannelName;
        }

        public NotifyPayCodePayResultRequestPayChannelDetailList setPayChannelOrderNo(String payChannelOrderNo) {
            this.payChannelOrderNo = payChannelOrderNo;
            return this;
        }
        public String getPayChannelOrderNo() {
            return this.payChannelOrderNo;
        }

        public NotifyPayCodePayResultRequestPayChannelDetailList setPayChannelType(String payChannelType) {
            this.payChannelType = payChannelType;
            return this;
        }
        public String getPayChannelType() {
            return this.payChannelType;
        }

        public NotifyPayCodePayResultRequestPayChannelDetailList setPromotionAmount(String promotionAmount) {
            this.promotionAmount = promotionAmount;
            return this;
        }
        public String getPromotionAmount() {
            return this.promotionAmount;
        }

    }

}
