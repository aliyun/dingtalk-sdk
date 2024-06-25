// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class UploadInvoiceByAuthRequest extends TeaModel {
    @NameInMap("extension")
    public UploadInvoiceByAuthRequestExtension extension;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("invoices")
    public java.util.List<UploadInvoiceByAuthRequestInvoices> invoices;

    public static UploadInvoiceByAuthRequest build(java.util.Map<String, ?> map) throws Exception {
        UploadInvoiceByAuthRequest self = new UploadInvoiceByAuthRequest();
        return TeaModel.build(map, self);
    }

    public UploadInvoiceByAuthRequest setExtension(UploadInvoiceByAuthRequestExtension extension) {
        this.extension = extension;
        return this;
    }
    public UploadInvoiceByAuthRequestExtension getExtension() {
        return this.extension;
    }

    public UploadInvoiceByAuthRequest setInvoices(java.util.List<UploadInvoiceByAuthRequestInvoices> invoices) {
        this.invoices = invoices;
        return this;
    }
    public java.util.List<UploadInvoiceByAuthRequestInvoices> getInvoices() {
        return this.invoices;
    }

    public static class UploadInvoiceByAuthRequestExtension extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>TRIP</p>
         */
        @NameInMap("bizCode")
        public String bizCode;

        /**
         * <strong>example:</strong>
         * <p>111924191922</p>
         */
        @NameInMap("orderNo")
        public String orderNo;

        /**
         * <strong>example:</strong>
         * <p>HOTEL</p>
         */
        @NameInMap("orderType")
        public String orderType;

        public static UploadInvoiceByAuthRequestExtension build(java.util.Map<String, ?> map) throws Exception {
            UploadInvoiceByAuthRequestExtension self = new UploadInvoiceByAuthRequestExtension();
            return TeaModel.build(map, self);
        }

        public UploadInvoiceByAuthRequestExtension setBizCode(String bizCode) {
            this.bizCode = bizCode;
            return this;
        }
        public String getBizCode() {
            return this.bizCode;
        }

        public UploadInvoiceByAuthRequestExtension setOrderNo(String orderNo) {
            this.orderNo = orderNo;
            return this;
        }
        public String getOrderNo() {
            return this.orderNo;
        }

        public UploadInvoiceByAuthRequestExtension setOrderType(String orderType) {
            this.orderType = orderType;
            return this;
        }
        public String getOrderType() {
            return this.orderType;
        }

    }

    public static class UploadInvoiceByAuthRequestInvoices extends TeaModel {
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

        public static UploadInvoiceByAuthRequestInvoices build(java.util.Map<String, ?> map) throws Exception {
            UploadInvoiceByAuthRequestInvoices self = new UploadInvoiceByAuthRequestInvoices();
            return TeaModel.build(map, self);
        }

        public UploadInvoiceByAuthRequestInvoices setInvoiceAmount(String invoiceAmount) {
            this.invoiceAmount = invoiceAmount;
            return this;
        }
        public String getInvoiceAmount() {
            return this.invoiceAmount;
        }

        public UploadInvoiceByAuthRequestInvoices setInvoiceCode(String invoiceCode) {
            this.invoiceCode = invoiceCode;
            return this;
        }
        public String getInvoiceCode() {
            return this.invoiceCode;
        }

        public UploadInvoiceByAuthRequestInvoices setInvoiceDate(String invoiceDate) {
            this.invoiceDate = invoiceDate;
            return this;
        }
        public String getInvoiceDate() {
            return this.invoiceDate;
        }

        public UploadInvoiceByAuthRequestInvoices setInvoiceNo(String invoiceNo) {
            this.invoiceNo = invoiceNo;
            return this;
        }
        public String getInvoiceNo() {
            return this.invoiceNo;
        }

        public UploadInvoiceByAuthRequestInvoices setInvoiceType(String invoiceType) {
            this.invoiceType = invoiceType;
            return this;
        }
        public String getInvoiceType() {
            return this.invoiceType;
        }

        public UploadInvoiceByAuthRequestInvoices setLogoUrl(String logoUrl) {
            this.logoUrl = logoUrl;
            return this;
        }
        public String getLogoUrl() {
            return this.logoUrl;
        }

        public UploadInvoiceByAuthRequestInvoices setPayeeName(String payeeName) {
            this.payeeName = payeeName;
            return this;
        }
        public String getPayeeName() {
            return this.payeeName;
        }

        public UploadInvoiceByAuthRequestInvoices setPayeeTaxNo(String payeeTaxNo) {
            this.payeeTaxNo = payeeTaxNo;
            return this;
        }
        public String getPayeeTaxNo() {
            return this.payeeTaxNo;
        }

        public UploadInvoiceByAuthRequestInvoices setPayerName(String payerName) {
            this.payerName = payerName;
            return this;
        }
        public String getPayerName() {
            return this.payerName;
        }

        public UploadInvoiceByAuthRequestInvoices setPayerTaxNo(String payerTaxNo) {
            this.payerTaxNo = payerTaxNo;
            return this;
        }
        public String getPayerTaxNo() {
            return this.payerTaxNo;
        }

        public UploadInvoiceByAuthRequestInvoices setPdfUrl(String pdfUrl) {
            this.pdfUrl = pdfUrl;
            return this;
        }
        public String getPdfUrl() {
            return this.pdfUrl;
        }

        public UploadInvoiceByAuthRequestInvoices setTaxAmount(String taxAmount) {
            this.taxAmount = taxAmount;
            return this;
        }
        public String getTaxAmount() {
            return this.taxAmount;
        }

        public UploadInvoiceByAuthRequestInvoices setVerifyCode(String verifyCode) {
            this.verifyCode = verifyCode;
            return this;
        }
        public String getVerifyCode() {
            return this.verifyCode;
        }

        public UploadInvoiceByAuthRequestInvoices setWithoutTaxAmount(String withoutTaxAmount) {
            this.withoutTaxAmount = withoutTaxAmount;
            return this;
        }
        public String getWithoutTaxAmount() {
            return this.withoutTaxAmount;
        }

    }

}
