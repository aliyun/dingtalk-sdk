// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class UpdateReceiptVoucherStatusRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>abc</p>
     */
    @NameInMap("accountPeriod")
    public String accountPeriod;

    /**
     * <strong>example:</strong>
     * <p>add</p>
     */
    @NameInMap("actionType")
    public String actionType;

    /**
     * <strong>example:</strong>
     * <p>0021241</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    /**
     * <strong>example:</strong>
     * <p>abc</p>
     */
    @NameInMap("receiptId")
    public String receiptId;

    /**
     * <strong>example:</strong>
     * <p>abc</p>
     */
    @NameInMap("voucherCode")
    public String voucherCode;

    /**
     * <strong>example:</strong>
     * <p>abc</p>
     */
    @NameInMap("voucherId")
    public String voucherId;

    /**
     * <strong>example:</strong>
     * <p>记-001</p>
     */
    @NameInMap("voucherNo")
    public String voucherNo;

    public static UpdateReceiptVoucherStatusRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateReceiptVoucherStatusRequest self = new UpdateReceiptVoucherStatusRequest();
        return TeaModel.build(map, self);
    }

    public UpdateReceiptVoucherStatusRequest setAccountPeriod(String accountPeriod) {
        this.accountPeriod = accountPeriod;
        return this;
    }
    public String getAccountPeriod() {
        return this.accountPeriod;
    }

    public UpdateReceiptVoucherStatusRequest setActionType(String actionType) {
        this.actionType = actionType;
        return this;
    }
    public String getActionType() {
        return this.actionType;
    }

    public UpdateReceiptVoucherStatusRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public UpdateReceiptVoucherStatusRequest setReceiptId(String receiptId) {
        this.receiptId = receiptId;
        return this;
    }
    public String getReceiptId() {
        return this.receiptId;
    }

    public UpdateReceiptVoucherStatusRequest setVoucherCode(String voucherCode) {
        this.voucherCode = voucherCode;
        return this;
    }
    public String getVoucherCode() {
        return this.voucherCode;
    }

    public UpdateReceiptVoucherStatusRequest setVoucherId(String voucherId) {
        this.voucherId = voucherId;
        return this;
    }
    public String getVoucherId() {
        return this.voucherId;
    }

    public UpdateReceiptVoucherStatusRequest setVoucherNo(String voucherNo) {
        this.voucherNo = voucherNo;
        return this;
    }
    public String getVoucherNo() {
        return this.voucherNo;
    }

}
