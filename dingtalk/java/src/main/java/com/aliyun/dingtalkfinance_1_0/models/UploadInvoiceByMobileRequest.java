// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class UploadInvoiceByMobileRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("invoices")
    public java.util.List<UploadInvoiceByMobileRequestInvoices> invoices;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>13600000000</p>
     */
    @NameInMap("mobile")
    public String mobile;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>86</p>
     */
    @NameInMap("mobileStateCode")
    public String mobileStateCode;

    public static UploadInvoiceByMobileRequest build(java.util.Map<String, ?> map) throws Exception {
        UploadInvoiceByMobileRequest self = new UploadInvoiceByMobileRequest();
        return TeaModel.build(map, self);
    }

    public UploadInvoiceByMobileRequest setInvoices(java.util.List<UploadInvoiceByMobileRequestInvoices> invoices) {
        this.invoices = invoices;
        return this;
    }
    public java.util.List<UploadInvoiceByMobileRequestInvoices> getInvoices() {
        return this.invoices;
    }

    public UploadInvoiceByMobileRequest setMobile(String mobile) {
        this.mobile = mobile;
        return this;
    }
    public String getMobile() {
        return this.mobile;
    }

    public UploadInvoiceByMobileRequest setMobileStateCode(String mobileStateCode) {
        this.mobileStateCode = mobileStateCode;
        return this;
    }
    public String getMobileStateCode() {
        return this.mobileStateCode;
    }

    public static class UploadInvoiceByMobileRequestInvoices extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>100.00</p>
         */
        @NameInMap("invoiceAmount")
        public String invoiceAmount;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>033002000712</p>
         */
        @NameInMap("invoiceCode")
        public String invoiceCode;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>2022-02-21</p>
         */
        @NameInMap("invoiceDate")
        public String invoiceDate;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>20532643</p>
         */
        @NameInMap("invoiceNo")
        public String invoiceNo;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("invoiceType")
        public String invoiceType;

        @NameInMap("logoUrl")
        public String logoUrl;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>小钉科技有限公司</p>
         */
        @NameInMap("payeeName")
        public String payeeName;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>91330100MA28XNB274</p>
         */
        @NameInMap("payeeTaxNo")
        public String payeeTaxNo;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>小钉科技有限公司</p>
         */
        @NameInMap("payerName")
        public String payerName;

        /**
         * <strong>example:</strong>
         * <p>91330100MA28XNB274</p>
         */
        @NameInMap("payerTaxNo")
        public String payerTaxNo;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("pdfUrl")
        public String pdfUrl;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>0.50</p>
         */
        @NameInMap("taxAmount")
        public String taxAmount;

        /**
         * <strong>example:</strong>
         * <p>增值税普通发票必填，示例：52501101414266612380</p>
         */
        @NameInMap("verifyCode")
        public String verifyCode;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>99.50</p>
         */
        @NameInMap("withoutTaxAmount")
        public String withoutTaxAmount;

        public static UploadInvoiceByMobileRequestInvoices build(java.util.Map<String, ?> map) throws Exception {
            UploadInvoiceByMobileRequestInvoices self = new UploadInvoiceByMobileRequestInvoices();
            return TeaModel.build(map, self);
        }

        public UploadInvoiceByMobileRequestInvoices setInvoiceAmount(String invoiceAmount) {
            this.invoiceAmount = invoiceAmount;
            return this;
        }
        public String getInvoiceAmount() {
            return this.invoiceAmount;
        }

        public UploadInvoiceByMobileRequestInvoices setInvoiceCode(String invoiceCode) {
            this.invoiceCode = invoiceCode;
            return this;
        }
        public String getInvoiceCode() {
            return this.invoiceCode;
        }

        public UploadInvoiceByMobileRequestInvoices setInvoiceDate(String invoiceDate) {
            this.invoiceDate = invoiceDate;
            return this;
        }
        public String getInvoiceDate() {
            return this.invoiceDate;
        }

        public UploadInvoiceByMobileRequestInvoices setInvoiceNo(String invoiceNo) {
            this.invoiceNo = invoiceNo;
            return this;
        }
        public String getInvoiceNo() {
            return this.invoiceNo;
        }

        public UploadInvoiceByMobileRequestInvoices setInvoiceType(String invoiceType) {
            this.invoiceType = invoiceType;
            return this;
        }
        public String getInvoiceType() {
            return this.invoiceType;
        }

        public UploadInvoiceByMobileRequestInvoices setLogoUrl(String logoUrl) {
            this.logoUrl = logoUrl;
            return this;
        }
        public String getLogoUrl() {
            return this.logoUrl;
        }

        public UploadInvoiceByMobileRequestInvoices setPayeeName(String payeeName) {
            this.payeeName = payeeName;
            return this;
        }
        public String getPayeeName() {
            return this.payeeName;
        }

        public UploadInvoiceByMobileRequestInvoices setPayeeTaxNo(String payeeTaxNo) {
            this.payeeTaxNo = payeeTaxNo;
            return this;
        }
        public String getPayeeTaxNo() {
            return this.payeeTaxNo;
        }

        public UploadInvoiceByMobileRequestInvoices setPayerName(String payerName) {
            this.payerName = payerName;
            return this;
        }
        public String getPayerName() {
            return this.payerName;
        }

        public UploadInvoiceByMobileRequestInvoices setPayerTaxNo(String payerTaxNo) {
            this.payerTaxNo = payerTaxNo;
            return this;
        }
        public String getPayerTaxNo() {
            return this.payerTaxNo;
        }

        public UploadInvoiceByMobileRequestInvoices setPdfUrl(String pdfUrl) {
            this.pdfUrl = pdfUrl;
            return this;
        }
        public String getPdfUrl() {
            return this.pdfUrl;
        }

        public UploadInvoiceByMobileRequestInvoices setTaxAmount(String taxAmount) {
            this.taxAmount = taxAmount;
            return this;
        }
        public String getTaxAmount() {
            return this.taxAmount;
        }

        public UploadInvoiceByMobileRequestInvoices setVerifyCode(String verifyCode) {
            this.verifyCode = verifyCode;
            return this;
        }
        public String getVerifyCode() {
            return this.verifyCode;
        }

        public UploadInvoiceByMobileRequestInvoices setWithoutTaxAmount(String withoutTaxAmount) {
            this.withoutTaxAmount = withoutTaxAmount;
            return this;
        }
        public String getWithoutTaxAmount() {
            return this.withoutTaxAmount;
        }

    }

}
