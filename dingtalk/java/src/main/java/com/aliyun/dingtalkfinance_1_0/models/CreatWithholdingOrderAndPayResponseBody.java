// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class CreatWithholdingOrderAndPayResponseBody extends TeaModel {
    /**
     * <p>代扣金额（元）</p>
     */
    @NameInMap("amount")
    public String amount;

    /**
     * <p>付款完成日期</p>
     */
    @NameInMap("gmtPay")
    public String gmtPay;

    /**
     * <p>主机构编号</p>
     */
    @NameInMap("instId")
    public String instId;

    /**
     * <p>钉钉订单号</p>
     */
    @NameInMap("orderNo")
    public String orderNo;

    /**
     * <p>外部订单号</p>
     */
    @NameInMap("outTradeNo")
    public String outTradeNo;

    /**
     * <p>支付渠道</p>
     */
    @NameInMap("payChannel")
    public String payChannel;

    /**
     * <p>支付渠道支付账号（脱敏后返回）</p>
     */
    @NameInMap("payChannelAccountNo")
    public String payChannelAccountNo;

    /**
     * <p>付款人staffId</p>
     */
    @NameInMap("payerStaffId")
    public String payerStaffId;

    /**
     * <p>代扣备注</p>
     */
    @NameInMap("remark")
    public String remark;

    /**
     * <p>状态</p>
     */
    @NameInMap("status")
    public String status;

    /**
     * <p>子机构编号</p>
     */
    @NameInMap("subInstId")
    public String subInstId;

    /**
     * <p>代扣标题</p>
     */
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
