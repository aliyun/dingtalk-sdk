// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class UpdateInvoiceVoucherStatusRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>123</p>
     */
    @NameInMap("accountantBookId")
    public String accountantBookId;

    /**
     * <strong>example:</strong>
     * <p>ADD/DELETE</p>
     */
    @NameInMap("actionType")
    public String actionType;

    /**
     * <strong>example:</strong>
     * <p>abc</p>
     */
    @NameInMap("invoiceCode")
    public String invoiceCode;

    /**
     * <strong>example:</strong>
     * <p>abc</p>
     */
    @NameInMap("invoiceNo")
    public String invoiceNo;

    /**
     * <strong>example:</strong>
     * <p>11011023488</p>
     */
    @NameInMap("operator")
    public String operator;

    /**
     * <strong>example:</strong>
     * <p>abc</p>
     */
    @NameInMap("voucherId")
    public String voucherId;

    public static UpdateInvoiceVoucherStatusRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateInvoiceVoucherStatusRequest self = new UpdateInvoiceVoucherStatusRequest();
        return TeaModel.build(map, self);
    }

    public UpdateInvoiceVoucherStatusRequest setAccountantBookId(String accountantBookId) {
        this.accountantBookId = accountantBookId;
        return this;
    }
    public String getAccountantBookId() {
        return this.accountantBookId;
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
