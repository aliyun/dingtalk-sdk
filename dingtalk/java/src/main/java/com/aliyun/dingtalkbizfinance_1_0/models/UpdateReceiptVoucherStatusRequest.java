// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class UpdateReceiptVoucherStatusRequest extends TeaModel {
    /**
     * <p>账期</p>
     */
    @NameInMap("accountPeriod")
    public String accountPeriod;

    /**
     * <p>操作类型 add 添加凭证关系、delete 删除凭证关系</p>
     */
    @NameInMap("actionType")
    public String actionType;

    /**
     * <p>操作人工号</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    /**
     * <p>审批单据ID</p>
     */
    @NameInMap("receiptId")
    public String receiptId;

    /**
     * <p>凭证CODE</p>
     */
    @NameInMap("voucherCode")
    public String voucherCode;

    /**
     * <p>凭证ID</p>
     */
    @NameInMap("voucherId")
    public String voucherId;

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

}
