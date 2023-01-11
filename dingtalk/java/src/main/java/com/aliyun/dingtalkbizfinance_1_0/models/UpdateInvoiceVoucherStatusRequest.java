// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class UpdateInvoiceVoucherStatusRequest extends TeaModel {
    /**
     * <p>操作类型</p>
     */
    @NameInMap("actionType")
    public String actionType;

    /**
     * <p>发票编码</p>
     */
    @NameInMap("invoiceCode")
    public String invoiceCode;

    /**
     * <p>发票号码</p>
     */
    @NameInMap("invoiceNo")
    public String invoiceNo;

    /**
     * <p>操作员</p>
     */
    @NameInMap("operator")
    public String operator;

    /**
     * <p>凭证id</p>
     */
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
