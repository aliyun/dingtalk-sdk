// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class UpdateInvoiceVerifyStatusRequest extends TeaModel {
    // 待更新
    @NameInMap("invoiceKeyVOList")
    public java.util.List<UpdateInvoiceVerifyStatusRequestInvoiceKeyVOList> invoiceKeyVOList;

    // 认证状态
    @NameInMap("verifyStatus")
    public String verifyStatus;

    public static UpdateInvoiceVerifyStatusRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateInvoiceVerifyStatusRequest self = new UpdateInvoiceVerifyStatusRequest();
        return TeaModel.build(map, self);
    }

    public UpdateInvoiceVerifyStatusRequest setInvoiceKeyVOList(java.util.List<UpdateInvoiceVerifyStatusRequestInvoiceKeyVOList> invoiceKeyVOList) {
        this.invoiceKeyVOList = invoiceKeyVOList;
        return this;
    }
    public java.util.List<UpdateInvoiceVerifyStatusRequestInvoiceKeyVOList> getInvoiceKeyVOList() {
        return this.invoiceKeyVOList;
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