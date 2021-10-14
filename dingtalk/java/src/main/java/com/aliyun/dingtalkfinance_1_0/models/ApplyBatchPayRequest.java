// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class ApplyBatchPayRequest extends TeaModel {
    // 企业corpId
    @NameInMap("corpId")
    public String corpId;

    // 支付发起人staffId
    @NameInMap("staffId")
    public String staffId;

    // 支付账号唯一id
    @NameInMap("accountId")
    public String accountId;

    // 钉钉订单号(和商户批次号一一对应)
    @NameInMap("orderNo")
    public String orderNo;

    // 订单总金额（必填）, 单位为：元
    @NameInMap("transAmount")
    public String transAmount;

    // 回调url
    @NameInMap("returnUrl")
    public String returnUrl;

    // 公用回传参数，如果请求时传递了该参数，则异步通知商户时会回传该参数
    @NameInMap("passBackParams")
    public java.util.Map<String, ?> passBackParams;

    // 支付终端
    @NameInMap("payTerminal")
    public String payTerminal;

    // 转账过期时间
    @NameInMap("transExpireTime")
    public String transExpireTime;

    public static ApplyBatchPayRequest build(java.util.Map<String, ?> map) throws Exception {
        ApplyBatchPayRequest self = new ApplyBatchPayRequest();
        return TeaModel.build(map, self);
    }

    public ApplyBatchPayRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public ApplyBatchPayRequest setStaffId(String staffId) {
        this.staffId = staffId;
        return this;
    }
    public String getStaffId() {
        return this.staffId;
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

    public ApplyBatchPayRequest setTransAmount(String transAmount) {
        this.transAmount = transAmount;
        return this;
    }
    public String getTransAmount() {
        return this.transAmount;
    }

    public ApplyBatchPayRequest setReturnUrl(String returnUrl) {
        this.returnUrl = returnUrl;
        return this;
    }
    public String getReturnUrl() {
        return this.returnUrl;
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

    public ApplyBatchPayRequest setTransExpireTime(String transExpireTime) {
        this.transExpireTime = transExpireTime;
        return this;
    }
    public String getTransExpireTime() {
        return this.transExpireTime;
    }

}
