// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class UpdateReceiptVoucherStatusRequest extends TeaModel {
    // 账期
    @NameInMap("accountPeriod")
    public String accountPeriod;

    // 操作类型 add 添加凭证关系、delete 删除凭证关系
    @NameInMap("actionType")
    public String actionType;

    // 操作人工号
    @NameInMap("operatorId")
    public String operatorId;

    // 审批单据ID
    @NameInMap("receiptId")
    public String receiptId;

    // 凭证CODE
    @NameInMap("voucherCode")
    public String voucherCode;

    // 凭证ID
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
