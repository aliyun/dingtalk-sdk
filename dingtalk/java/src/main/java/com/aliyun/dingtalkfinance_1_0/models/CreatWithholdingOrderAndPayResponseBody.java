// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class CreatWithholdingOrderAndPayResponseBody extends TeaModel {
    // 代扣金额（元）
    @NameInMap("amount")
    public String amount;

    // 付款完成日期
    @NameInMap("gmtPay")
    public String gmtPay;

    // 主机构编号
    @NameInMap("instId")
    public String instId;

    // 钉钉订单号
    @NameInMap("orderNo")
    public String orderNo;

    // 外部订单号
    @NameInMap("outTradeNo")
    public String outTradeNo;

    // 支付渠道
    @NameInMap("payChannel")
    public String payChannel;

    // 支付渠道支付账号（脱敏后返回）
    @NameInMap("payChannelAccountNo")
    public String payChannelAccountNo;

    // 付款人staffId
    @NameInMap("payerStaffId")
    public String payerStaffId;

    // 代扣备注
    @NameInMap("remark")
    public String remark;

    // 状态
    @NameInMap("status")
    public String status;

    // 子机构编号
    @NameInMap("subInstId")
    public String subInstId;

    // 代扣标题
    @NameInMap("title")
    public String title;

    public static CreatWithholdingOrderAndPayResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreatWithholdingOrderAndPayResponseBody self = new CreatWithholdingOrderAndPayResponseBody();
        return TeaModel.build(map, self);
    }

    public CreatWithholdingOrderAndPayResponseBody setAmount(String amount) {
        this.amount = amount;
        return this;
    }
    public String getAmount() {
        return this.amount;
    }

    public CreatWithholdingOrderAndPayResponseBody setGmtPay(String gmtPay) {
        this.gmtPay = gmtPay;
        return this;
    }
    public String getGmtPay() {
        return this.gmtPay;
    }

    public CreatWithholdingOrderAndPayResponseBody setInstId(String instId) {
        this.instId = instId;
        return this;
    }
    public String getInstId() {
        return this.instId;
    }

    public CreatWithholdingOrderAndPayResponseBody setOrderNo(String orderNo) {
        this.orderNo = orderNo;
        return this;
    }
    public String getOrderNo() {
        return this.orderNo;
    }

    public CreatWithholdingOrderAndPayResponseBody setOutTradeNo(String outTradeNo) {
        this.outTradeNo = outTradeNo;
        return this;
    }
    public String getOutTradeNo() {
        return this.outTradeNo;
    }

    public CreatWithholdingOrderAndPayResponseBody setPayChannel(String payChannel) {
        this.payChannel = payChannel;
        return this;
    }
    public String getPayChannel() {
        return this.payChannel;
    }

    public CreatWithholdingOrderAndPayResponseBody setPayChannelAccountNo(String payChannelAccountNo) {
        this.payChannelAccountNo = payChannelAccountNo;
        return this;
    }
    public String getPayChannelAccountNo() {
        return this.payChannelAccountNo;
    }

    public CreatWithholdingOrderAndPayResponseBody setPayerStaffId(String payerStaffId) {
        this.payerStaffId = payerStaffId;
        return this;
    }
    public String getPayerStaffId() {
        return this.payerStaffId;
    }

    public CreatWithholdingOrderAndPayResponseBody setRemark(String remark) {
        this.remark = remark;
        return this;
    }
    public String getRemark() {
        return this.remark;
    }

    public CreatWithholdingOrderAndPayResponseBody setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

    public CreatWithholdingOrderAndPayResponseBody setSubInstId(String subInstId) {
        this.subInstId = subInstId;
        return this;
    }
    public String getSubInstId() {
        return this.subInstId;
    }

    public CreatWithholdingOrderAndPayResponseBody setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

}
