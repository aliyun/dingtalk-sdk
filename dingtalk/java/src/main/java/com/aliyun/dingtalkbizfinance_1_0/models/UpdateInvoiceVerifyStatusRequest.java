// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class UpdateInvoiceVerifyStatusRequest extends TeaModel {
    // 抵扣状态
    // 
    @NameInMap("deductStatus")
    public String deductStatus;

    // 待更新
    @NameInMap("invoiceKeyVOList")
    public java.util.List<UpdateInvoiceVerifyStatusRequestInvoiceKeyVOList> invoiceKeyVOList;

    // 操作员
    @NameInMap("operator")
    public String operator;

    // 认证状态
    @NameInMap("verifyStatus")
    public String verifyStatus;

    public static UpdateInvoiceVerifyStatusRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateInvoiceVerifyStatusRequest self = new UpdateInvoiceVerifyStatusRequest();
        return TeaModel.build(map, self);
    }

    public UpdateInvoiceVerifyStatusRequest setDeductStatus(String deductStatus) {
        this.deductStatus = deductStatus;
        return this;
    }
    public String getDeductStatus() {
        return this.deductStatus;
    }

    public UpdateInvoiceVerifyStatusRequest setInvoiceKeyVOList(java.util.List<UpdateInvoiceVerifyStatusRequestInvoiceKeyVOList> invoiceKeyVOList) {
        this.invoiceKeyVOList = invoiceKeyVOList;
        return this;
    }
    public java.util.List<UpdateInvoiceVerifyStatusRequestInvoiceKeyVOList> getInvoiceKeyVOList() {
        return this.invoiceKeyVOList;
    }

    public UpdateInvoiceVerifyStatusRequest setOperator(String operator) {
        this.operator = operator;
        return this;
    }
    public String getOperator() {
        return this.operator;
    }

    public UpdateInvoiceVerifyStatusRequest setVerifyStatus(String verifyStatus) {
        this.verifyStatus = verifyStatus;
        return this;
    }
    public String getVerifyStatus() {
        return this.verifyStatus;
    }

    public static class UpdateInvoiceVerifyStatusRequestInvoiceKeyVOList extends TeaModel {
        // 发票编码
        @NameInMap("invoiceCode")
        public String invoiceCode;

        // 发票号码
        @NameInMap("invoiceNo")
        public String invoiceNo;

        public static UpdateInvoiceVerifyStatusRequestInvoiceKeyVOList build(java.util.Map<String, ?> map) throws Exception {
            UpdateInvoiceVerifyStatusRequestInvoiceKeyVOList self = new UpdateInvoiceVerifyStatusRequestInvoiceKeyVOList();
            return TeaModel.build(map, self);
        }

        public UpdateInvoiceVerifyStatusRequestInvoiceKeyVOList setInvoiceCode(String invoiceCode) {
            this.invoiceCode = invoiceCode;
            return this;
        }
        public String getInvoiceCode() {
            return this.invoiceCode;
        }

        public UpdateInvoiceVerifyStatusRequestInvoiceKeyVOList setInvoiceNo(String invoiceNo) {
            this.invoiceNo = invoiceNo;
            return this;
        }
        public String getInvoiceNo() {
            return this.invoiceNo;
        }

    }

}
