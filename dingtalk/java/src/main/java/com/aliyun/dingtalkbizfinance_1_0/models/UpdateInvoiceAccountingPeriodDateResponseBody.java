// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class UpdateInvoiceAccountingPeriodDateResponseBody extends TeaModel {
    /**
     * <p>返回结果</p>
     */
    @NameInMap("failInvoices")
    public java.util.List<UpdateInvoiceAccountingPeriodDateResponseBodyFailInvoices> failInvoices;

    public static UpdateInvoiceAccountingPeriodDateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateInvoiceAccountingPeriodDateResponseBody self = new UpdateInvoiceAccountingPeriodDateResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateInvoiceAccountingPeriodDateResponseBody setFailInvoices(java.util.List<UpdateInvoiceAccountingPeriodDateResponseBodyFailInvoices> failInvoices) {
        this.failInvoices = failInvoices;
        return this;
    }
    public java.util.List<UpdateInvoiceAccountingPeriodDateResponseBodyFailInvoices> getFailInvoices() {
        return this.failInvoices;
    }

    public static class UpdateInvoiceAccountingPeriodDateResponseBodyFailInvoices extends TeaModel {
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

        public static UpdateInvoiceAccountingPeriodDateResponseBodyFailInvoices build(java.util.Map<String, ?> map) throws Exception {
            UpdateInvoiceAccountingPeriodDateResponseBodyFailInvoices self = new UpdateInvoiceAccountingPeriodDateResponseBodyFailInvoices();
            return TeaModel.build(map, self);
        }

        public UpdateInvoiceAccountingPeriodDateResponseBodyFailInvoices setInvoiceCode(String invoiceCode) {
            this.invoiceCode = invoiceCode;
            return this;
        }
        public String getInvoiceCode() {
            return this.invoiceCode;
        }

        public UpdateInvoiceAccountingPeriodDateResponseBodyFailInvoices setInvoiceNo(String invoiceNo) {
            this.invoiceNo = invoiceNo;
            return this;
        }
        public String getInvoiceNo() {
            return this.invoiceNo;
        }

    }

}
