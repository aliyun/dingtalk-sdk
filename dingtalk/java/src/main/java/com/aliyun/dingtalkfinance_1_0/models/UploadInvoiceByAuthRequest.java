// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class UploadInvoiceByAuthRequest extends TeaModel {
    @NameInMap("extension")
    public UploadInvoiceByAuthRequestExtension extension;

    // 上传发票列表
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
        @NameInMap("bizCode")
        public String bizCode;

        @NameInMap("orderNo")
        public String orderNo;

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
        // 发票总金额
        @NameInMap("invoiceAmount")
        public String invoiceAmount;

        // 发票代码
        @NameInMap("invoiceCode")
        public String invoiceCode;

        // 开票时间
        @NameInMap("invoiceDate")
        public String invoiceDate;

        // 发票号码
        @NameInMap("invoiceNo")
        public String invoiceNo;

        // 发票类型
        @NameInMap("invoiceType")
        public String invoiceType;

        // 发票logo地址
        @NameInMap("logoUrl")
        public String logoUrl;

        // 收款方名称
        @NameInMap("payeeName")
        public String payeeName;

        // 收款方税号
        @NameInMap("payeeTaxNo")
        public String payeeTaxNo;

        // 付款方名称
        @NameInMap("payerName")
        public String payerName;

        // 付款方税号
        @NameInMap("payerTaxNo")
        public String payerTaxNo;

        // 发票pdf原件下载链接
        @NameInMap("pdfUrl")
        public String pdfUrl;

        // 税金额
        @NameInMap("taxAmount")
        public String taxAmount;

        // 发票校验码
        @NameInMap("verifyCode")
        public String verifyCode;

        // 不含税金额
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
