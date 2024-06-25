// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class ApplyBatchPayRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>2021070712440326300185114</p>
     */
    @NameInMap("accountId")
    public String accountId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>20210909153300000002734753314700</p>
     */
    @NameInMap("orderNo")
    public String orderNo;

    /**
     * <strong>example:</strong>
     * <p>map</p>
     */
    @NameInMap("passBackParams")
    public java.util.Map<String, ?> passBackParams;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>PC</p>
     */
    @NameInMap("payTerminal")
    public String payTerminal;

    /**
     * <strong>example:</strong>
     * <p><a href="http://xx">http://xx</a></p>
     */
    @NameInMap("returnUrl")
    public String returnUrl;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>8754214873</p>
     */
    @NameInMap("staffId")
    public String staffId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>10.00</p>
     */
    @NameInMap("transAmount")
    public String transAmount;

    /**
     * <strong>example:</strong>
     * <p>yyyy-MM-dd HH:mm:ss</p>
     */
    @NameInMap("transExpireTime")
    public String transExpireTime;

    public static ApplyBatchPayRequest build(java.util.Map<String, ?> map) throws Exception {
        ApplyBatchPayRequest self = new ApplyBatchPayRequest();
        return TeaModel.build(map, self);
    }

    public ApplyBatchPayRequest setAccountId(String accountId) {
        this.accountId = accountId;
        return this;
    }
    public String getAccountId() {
        return this.accountId;
    }

    public ApplyBatchPayRequest setOrderNo(String orderNo) {
        this.orderNo = orderNo;
        return this;
    }
    public String getOrderNo() {
        return this.orderNo;
    }

    public ApplyBatchPayRequest setPassBackParams(java.util.Map<String, ?> passBackParams) {
        this.passBackParams = passBackParams;
        return this;
    }
    public java.util.Map<String, ?> getPassBackParams() {
        return this.passBackParams;
    }

    public ApplyBatchPayRequest setPayTerminal(String payTerminal) {
        this.payTerminal = payTerminal;
        return this;
    }
    public String getPayTerminal() {
        return this.payTerminal;
    }

    public ApplyBatchPayRequest setReturnUrl(String returnUrl) {
        this.returnUrl = returnUrl;
        return this;
    }
    public String getReturnUrl() {
        return this.returnUrl;
    }

    public ApplyBatchPayRequest setStaffId(String staffId) {
        this.staffId = staffId;
        return this;
    }
    public String getStaffId() {
        return this.staffId;
    }

    public ApplyBatchPayRequest setTransAmount(String transAmount) {
        this.transAmount = transAmount;
        return this;
    }
    public String getTransAmount() {
        return this.transAmount;
    }

    public ApplyBatchPayRequest setTransExpireTime(String transExpireTime) {
        this.transExpireTime = transExpireTime;
        return this;
    }
    public String getTransExpireTime() {
        return this.transExpireTime;
    }

}
