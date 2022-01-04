// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class CreatWithholdingOrderAndPayRequest extends TeaModel {
    // 主机构编号
    @NameInMap("instId")
    public String instId;

    // 子机构编号
    @NameInMap("subInstId")
    public String subInstId;

    // 付款人staffId
    @NameInMap("payerUserId")
    public String payerUserId;

    // 支付渠道
    @NameInMap("payChannel")
    public String payChannel;

    // 扣款金额
    @NameInMap("amount")
    public String amount;

    // 外部订单号
    @NameInMap("outTradeNo")
    public String outTradeNo;

    // 代扣标题
    @NameInMap("title")
    public String title;

    // 代扣备注
    @NameInMap("remark")
    public String remark;

    // 代扣过期时间
    @NameInMap("timeOutExpress")
    public String timeOutExpress;

    // 其他资金渠道付款明细
    @NameInMap("otherPayChannelDetailInfoList")
    public java.util.List<CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoList> otherPayChannelDetailInfoList;

    // 组织id
    @NameInMap("dingOrgId")
    public Long dingOrgId;

    // isv组织id
    @NameInMap("dingIsvOrgId")
    public Long dingIsvOrgId;

    // 应用id
    @NameInMap("dingClientId")
    public String dingClientId;

    // 应用类型
    @NameInMap("dingTokenGrantType")
    public Long dingTokenGrantType;

    public static CreatWithholdingOrderAndPayRequest build(java.util.Map<String, ?> map) throws Exception {
        CreatWithholdingOrderAndPayRequest self = new CreatWithholdingOrderAndPayRequest();
        return TeaModel.build(map, self);
    }

    public CreatWithholdingOrderAndPayRequest setInstId(String instId) {
        this.instId = instId;
        return this;
    }
    public String getInstId() {
        return this.instId;
    }

    public CreatWithholdingOrderAndPayRequest setSubInstId(String subInstId) {
        this.subInstId = subInstId;
        return this;
    }
    public String getSubInstId() {
        return this.subInstId;
    }

    public CreatWithholdingOrderAndPayRequest setPayerUserId(String payerUserId) {
        this.payerUserId = payerUserId;
        return this;
    }
    public String getPayerUserId() {
        return this.payerUserId;
    }

    public CreatWithholdingOrderAndPayRequest setPayChannel(String payChannel) {
        this.payChannel = payChannel;
        return this;
    }
    public String getPayChannel() {
        return this.payChannel;
    }

    public CreatWithholdingOrderAndPayRequest setAmount(String amount) {
        this.amount = amount;
        return this;
    }
    public String getAmount() {
        return this.amount;
    }

    public CreatWithholdingOrderAndPayRequest setOutTradeNo(String outTradeNo) {
        this.outTradeNo = outTradeNo;
        return this;
    }
    public String getOutTradeNo() {
        return this.outTradeNo;
    }

    public CreatWithholdingOrderAndPayRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public CreatWithholdingOrderAndPayRequest setRemark(String remark) {
        this.remark = remark;
        return this;
    }
    public String getRemark() {
        return this.remark;
    }

    public CreatWithholdingOrderAndPayRequest setTimeOutExpress(String timeOutExpress) {
        this.timeOutExpress = timeOutExpress;
        return this;
    }
    public String getTimeOutExpress() {
        return this.timeOutExpress;
    }

    public CreatWithholdingOrderAndPayRequest setOtherPayChannelDetailInfoList(java.util.List<CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoList> otherPayChannelDetailInfoList) {
        this.otherPayChannelDetailInfoList = otherPayChannelDetailInfoList;
        return this;
    }
    public java.util.List<CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoList> getOtherPayChannelDetailInfoList() {
        return this.otherPayChannelDetailInfoList;
    }

    public CreatWithholdingOrderAndPayRequest setDingOrgId(Long dingOrgId) {
        this.dingOrgId = dingOrgId;
        return this;
    }
    public Long getDingOrgId() {
        return this.dingOrgId;
    }

    public CreatWithholdingOrderAndPayRequest setDingIsvOrgId(Long dingIsvOrgId) {
        this.dingIsvOrgId = dingIsvOrgId;
        return this;
    }
    public Long getDingIsvOrgId() {
        return this.dingIsvOrgId;
    }

    public CreatWithholdingOrderAndPayRequest setDingClientId(String dingClientId) {
        this.dingClientId = dingClientId;
        return this;
    }
    public String getDingClientId() {
        return this.dingClientId;
    }

    public CreatWithholdingOrderAndPayRequest setDingTokenGrantType(Long dingTokenGrantType) {
        this.dingTokenGrantType = dingTokenGrantType;
        return this;
    }
    public Long getDingTokenGrantType() {
        return this.dingTokenGrantType;
    }

    public static class CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoListFundToolDetailInfoList extends TeaModel {
        // 资金工具名称
        @NameInMap("fundToolName")
        public String fundToolName;

        // 金额
        @NameInMap("amount")
        public String amount;

        // 资金明细创建时间
        @NameInMap("gmtCreate")
        public String gmtCreate;

        // 资金明细完成时间
        @NameInMap("gmtFinish")
        public String gmtFinish;

        // 是否是优惠工具
        @NameInMap("promotionFundTool")
        public Boolean promotionFundTool;

        // 扩展信息
        @NameInMap("extInfo")
        public String extInfo;

        public static CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoListFundToolDetailInfoList build(java.util.Map<String, ?> map) throws Exception {
            CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoListFundToolDetailInfoList self = new CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoListFundToolDetailInfoList();
            return TeaModel.build(map, self);
        }

        public CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoListFundToolDetailInfoList setFundToolName(String fundToolName) {
            this.fundToolName = fundToolName;
            return this;
        }
        public String getFundToolName() {
            return this.fundToolName;
        }

        public CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoListFundToolDetailInfoList setAmount(String amount) {
            this.amount = amount;
            return this;
        }
        public String getAmount() {
            return this.amount;
        }

        public CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoListFundToolDetailInfoList setGmtCreate(String gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public String getGmtCreate() {
            return this.gmtCreate;
        }

        public CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoListFundToolDetailInfoList setGmtFinish(String gmtFinish) {
            this.gmtFinish = gmtFinish;
            return this;
        }
        public String getGmtFinish() {
            return this.gmtFinish;
        }

        public CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoListFundToolDetailInfoList setPromotionFundTool(Boolean promotionFundTool) {
            this.promotionFundTool = promotionFundTool;
            return this;
        }
        public Boolean getPromotionFundTool() {
            return this.promotionFundTool;
        }

        public CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoListFundToolDetailInfoList setExtInfo(String extInfo) {
            this.extInfo = extInfo;
            return this;
        }
        public String getExtInfo() {
            return this.extInfo;
        }

    }

    public static class CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoList extends TeaModel {
        // 渠道名称
        @NameInMap("payChannelName")
        public String payChannelName;

        // 渠道类型
        @NameInMap("payChannelType")
        public String payChannelType;

        // 渠道金额
        @NameInMap("amount")
        public String amount;

        // 支付渠道单号
        @NameInMap("payChannelOrderNo")
        public String payChannelOrderNo;

        // 总优惠金额
        @NameInMap("promotionAmount")
        public String promotionAmount;

        // 资金明细列表
        @NameInMap("fundToolDetailInfoList")
        public java.util.List<CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoListFundToolDetailInfoList> fundToolDetailInfoList;

        public static CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoList build(java.util.Map<String, ?> map) throws Exception {
            CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoList self = new CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoList();
            return TeaModel.build(map, self);
        }

        public CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoList setPayChannelName(String payChannelName) {
            this.payChannelName = payChannelName;
            return this;
        }
        public String getPayChannelName() {
            return this.payChannelName;
        }

        public CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoList setPayChannelType(String payChannelType) {
            this.payChannelType = payChannelType;
            return this;
        }
        public String getPayChannelType() {
            return this.payChannelType;
        }

        public CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoList setAmount(String amount) {
            this.amount = amount;
            return this;
        }
        public String getAmount() {
            return this.amount;
        }

        public CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoList setPayChannelOrderNo(String payChannelOrderNo) {
            this.payChannelOrderNo = payChannelOrderNo;
            return this;
        }
        public String getPayChannelOrderNo() {
            return this.payChannelOrderNo;
        }

        public CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoList setPromotionAmount(String promotionAmount) {
            this.promotionAmount = promotionAmount;
            return this;
        }
        public String getPromotionAmount() {
            return this.promotionAmount;
        }

        public CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoList setFundToolDetailInfoList(java.util.List<CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoListFundToolDetailInfoList> fundToolDetailInfoList) {
            this.fundToolDetailInfoList = fundToolDetailInfoList;
            return this;
        }
        public java.util.List<CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoListFundToolDetailInfoList> getFundToolDetailInfoList() {
            return this.fundToolDetailInfoList;
        }

    }

}
