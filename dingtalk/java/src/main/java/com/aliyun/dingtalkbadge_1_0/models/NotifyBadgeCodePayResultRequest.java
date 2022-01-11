// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbadge_1_0.models;

import com.aliyun.tea.*;

public class NotifyBadgeCodePayResultRequest extends TeaModel {
    // 订单金额
    @NameInMap("amount")
    public String amount;

    // 收费金额
    @NameInMap("chargeAmount")
    public String chargeAmount;

    // 企业id
    @NameInMap("corpId")
    public String corpId;

    // 扩展信息
    @NameInMap("extInfo")
    public String extInfo;

    // 交易开始时间
    @NameInMap("gmtTradeCreate")
    public String gmtTradeCreate;

    // 交易结束时间
    @NameInMap("gmtTradeFinish")
    public String gmtTradeFinish;

    // merchantName
    @NameInMap("merchantName")
    public String merchantName;

    // 支付渠道明细信息
    @NameInMap("payChannelDetailList")
    public java.util.List<NotifyBadgeCodePayResultRequestPayChannelDetailList> payChannelDetailList;

    // 付款码值
    @NameInMap("payCode")
    public String payCode;

    // 订单优惠金额
    @NameInMap("promotionAmount")
    public String promotionAmount;

    // 备注
    @NameInMap("remark")
    public String remark;

    // 订单标题
    @NameInMap("title")
    public String title;

    // 支付失败错误码
    @NameInMap("tradeErrorCode")
    public String tradeErrorCode;

    // 支付失败信息
    @NameInMap("tradeErrorMsg")
    public String tradeErrorMsg;

    // 交易号
    @NameInMap("tradeNo")
    public String tradeNo;

    // 交易状态
    @NameInMap("tradeStatus")
    public String tradeStatus;

    // 用户id
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
        // 1.00
        @NameInMap("amount")
        public String amount;

        // 扩展信息
        @NameInMap("extInfo")
        public String extInfo;

        // 资金渠道名称
        @NameInMap("fundToolName")
        public String fundToolName;

        // 开始时间
        @NameInMap("gmtCreate")
        public String gmtCreate;

        // 结束时间
        @NameInMap("gmtFinish")
        public String gmtFinish;

        // 是否是优惠工具
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
        // 支付金额
        @NameInMap("amount")
        public String amount;

        // 资金工具明细
        @NameInMap("fundToolDetailList")
        public java.util.List<NotifyBadgeCodePayResultRequestPayChannelDetailListFundToolDetailList> fundToolDetailList;

        // 开始时间
        @NameInMap("gmtCreate")
        public String gmtCreate;

        // 结束时间
        @NameInMap("gmtFinish")
        public String gmtFinish;

        // 支付渠道名称
        @NameInMap("payChannelName")
        public String payChannelName;

        // 支付渠道单号
        @NameInMap("payChannelOrderNo")
        public String payChannelOrderNo;

        // 支付渠道类型
        @NameInMap("payChannelType")
        public String payChannelType;

        // 优惠金额
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
