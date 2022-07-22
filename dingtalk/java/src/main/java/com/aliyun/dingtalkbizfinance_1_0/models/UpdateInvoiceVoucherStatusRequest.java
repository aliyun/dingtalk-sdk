// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class UpdateInvoiceVoucherStatusRequest extends TeaModel {
    // 操作类型
    @NameInMap("actionType")
    public String actionType;

    // 发票编码
    @NameInMap("invoiceCode")
    public String invoiceCode;

    // 发票号码
    @NameInMap("invoiceNo")
    public String invoiceNo;

    // 操作员
    @NameInMap("operator")
    public String operator;

    // 凭证id
    @NameInMap("voucherId")
    public String voucherId;

    public static UpdateInvoiceVoucherStatusRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateInvoiceVoucherStatusRequest self = new UpdateInvoiceVoucherStatusRequest();
        return TeaModel.build(map, self);
    }

    public UpdateInvoiceVoucherStatusRequest setActionType(String actionType) {
        this.actionType = actionType;
        return this;
    }
    public String getActionType() {
        return this.actionType;
    }

    public UpdateInvoiceVoucherStatusRequest setInvoiceCode(String invoiceCode) {
        this.invoiceCode = invoiceCode;
        return this;
    }
    public String getInvoiceCode() {
        return this.invoiceCode;
    }

    public UpdateInvoiceVoucherStatusRequest setInvoiceNo(String invoiceNo) {
        this.invoiceNo = invoiceNo;
        return this;
    }
    public String getInvoiceNo() {
        return this.invoiceNo;
    }

    public UpdateInvoiceVoucherStatusRequest setOperator(String operator) {
        this.operator = operator;
        return this;
    }
    public String getOperator() {
        return this.operator;
    }

    public UpdateInvoiceVoucherStatusRequest setVoucherId(String voucherId) {
        this.voucherId = voucherId;
        return this;
    }
    public String getVoucherId() {
        return this.voucherId;
    }

}
