// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryWithholdingOrderResponseBody extends TeaModel {
    // 主机构编号
    @NameInMap("instId")
    public String instId;

    // 子机构编号
    @NameInMap("subInstId")
    public String subInstId;

    // 付款人staffId
    @NameInMap("payerStaffId")
    public String payerStaffId;

    // 支付渠道
    @NameInMap("payChannel")
    public String payChannel;

    // 代扣金额（元）
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

    // 状态
    @NameInMap("status")
    public String status;

    // 钉钉订单号
    @NameInMap("orderNo")
    public String orderNo;

    // 付款完成日期
    @NameInMap("gmtPay")
    public String gmtPay;

    // 支付渠道支付账号（脱敏后返回）
    @NameInMap("payChannelAccountNo")
    public String payChannelAccountNo;

    // 订单创建日期
    @NameInMap("gmtCreate")
    public String gmtCreate;

    public static QueryWithholdingOrderResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryWithholdingOrderResponseBody self = new QueryWithholdingOrderResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryWithholdingOrderResponseBody setInstId(String instId) {
        this.instId = instId;
        return this;
    }
    public String getInstId() {
        return this.instId;
    }

    public QueryWithholdingOrderResponseBody setSubInstId(String subInstId) {
        this.subInstId = subInstId;
        return this;
    }
    public String getSubInstId() {
        return this.subInstId;
    }

    public QueryWithholdingOrderResponseBody setPayerStaffId(String payerStaffId) {
        this.payerStaffId = payerStaffId;
        return this;
    }
    public String getPayerStaffId() {
        return this.payerStaffId;
    }

    public QueryWithholdingOrderResponseBody setPayChannel(String payChannel) {
        this.payChannel = payChannel;
        return this;
    }
    public String getPayChannel() {
        return this.payChannel;
    }

    public QueryWithholdingOrderResponseBody setAmount(String amount) {
        this.amount = amount;
        return this;
    }
    public String getAmount() {
        return this.amount;
    }

    public QueryWithholdingOrderResponseBody setOutTradeNo(String outTradeNo) {
        this.outTradeNo = outTradeNo;
        return this;
    }
    public String getOutTradeNo() {
        return this.outTradeNo;
    }

    public QueryWithholdingOrderResponseBody setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public QueryWithholdingOrderResponseBody setRemark(String remark) {
        this.remark = remark;
        return this;
    }
    public String getRemark() {
        return this.remark;
    }

    public QueryWithholdingOrderResponseBody setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

    public QueryWithholdingOrderResponseBody setOrderNo(String orderNo) {
        this.orderNo = orderNo;
        return this;
    }
    public String getOrderNo() {
        return this.orderNo;
    }

    public QueryWithholdingOrderResponseBody setGmtPay(String gmtPay) {
        this.gmtPay = gmtPay;
        return this;
    }
    public String getGmtPay() {
        return this.gmtPay;
    }

    public QueryWithholdingOrderResponseBody setPayChannelAccountNo(String payChannelAccountNo) {
        this.payChannelAccountNo = payChannelAccountNo;
        return this;
    }
    public String getPayChannelAccountNo() {
        return this.payChannelAccountNo;
    }

    public QueryWithholdingOrderResponseBody setGmtCreate(String gmtCreate) {
        this.gmtCreate = gmtCreate;
        return this;
    }
    public String getGmtCreate() {
        return this.gmtCreate;
    }

}
