// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class CreatWithholdingOrderAndPayResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>10.01</p>
     */
    @NameInMap("amount")
    public String amount;

    /**
     * <strong>example:</strong>
     * <p>2021-11-15 10:10:10</p>
     */
    @NameInMap("gmtPay")
    public String gmtPay;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>202111010001</p>
     */
    @NameInMap("instId")
    public String instId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>202121241343151</p>
     */
    @NameInMap("orderNo")
    public String orderNo;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>202111020001</p>
     */
    @NameInMap("outTradeNo")
    public String outTradeNo;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>ALIPAY</p>
     */
    @NameInMap("payChannel")
    public String payChannel;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>13****09</p>
     */
    @NameInMap("payChannelAccountNo")
    public String payChannelAccountNo;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>123124</p>
     */
    @NameInMap("payerStaffId")
    public String payerStaffId;

    /**
     * <strong>example:</strong>
     * <p>备注</p>
     */
    @NameInMap("remark")
    public String remark;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>SUCCESS</p>
     */
    @NameInMap("status")
    public String status;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1001</p>
     */
    @NameInMap("subInstId")
    public String subInstId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>餐费</p>
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
