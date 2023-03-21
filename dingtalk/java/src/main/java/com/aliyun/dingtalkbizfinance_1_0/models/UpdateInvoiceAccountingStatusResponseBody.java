// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class UpdateInvoiceAccountingStatusResponseBody extends TeaModel {
    /**
     * <p>返回结果</p>
     */
    @NameInMap("failInvoices")
    public java.util.List<UpdateInvoiceAccountingStatusResponseBodyFailInvoices> failInvoices;

    public static UpdateInvoiceAccountingStatusResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateInvoiceAccountingStatusResponseBody self = new UpdateInvoiceAccountingStatusResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateInvoiceAccountingStatusResponseBody setFailInvoices(java.util.List<UpdateInvoiceAccountingStatusResponseBodyFailInvoices> failInvoices) {
        this.failInvoices = failInvoices;
        return this;
    }
    public java.util.List<UpdateInvoiceAccountingStatusResponseBodyFailInvoices> getFailInvoices() {
        return this.failInvoices;
    }

    public static class UpdateInvoiceAccountingStatusResponseBodyFailInvoices extends TeaModel {
        /**
         * <p>发票代码</p>
         */
        @NameInMap("invoiceCode")
        public String invoiceCode;

        /**
         * <p>发票号码</p>
         */
        @NameInMap("invoiceNo")
        public String invoiceNo;

        public static UpdateInvoiceAccountingStatusResponseBodyFailInvoices build(java.util.Map<String, ?> map) throws Exception {
            UpdateInvoiceAccountingStatusResponseBodyFailInvoices self = new UpdateInvoiceAccountingStatusResponseBodyFailInvoices();
            return TeaModel.build(map, self);
        }

        public UpdateInvoiceAccountingStatusResponseBodyFailInvoices setInvoiceCode(String invoiceCode) {
            this.invoiceCode = invoiceCode;
            return this;
        }
        public String getInvoiceCode() {
            return this.invoiceCode;
        }

        public UpdateInvoiceAccountingStatusResponseBodyFailInvoices setInvoiceNo(String invoiceNo) {
            this.invoiceNo = invoiceNo;
            return this;
        }
        public String getInvoiceNo() {
            return this.invoiceNo;
        }

    }

}
