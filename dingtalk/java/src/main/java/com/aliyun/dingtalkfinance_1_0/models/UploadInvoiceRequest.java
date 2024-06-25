// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class UploadInvoiceRequest extends TeaModel {
    @NameInMap("extension")
    public UploadInvoiceRequestExtension extension;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("invoices")
    public java.util.List<UploadInvoiceRequestInvoices> invoices;

    @NameInMap("userIdentity")
    public UploadInvoiceRequestUserIdentity userIdentity;

    public static UploadInvoiceRequest build(java.util.Map<String, ?> map) throws Exception {
        UploadInvoiceRequest self = new UploadInvoiceRequest();
        return TeaModel.build(map, self);
    }

    public UploadInvoiceRequest setExtension(UploadInvoiceRequestExtension extension) {
        this.extension = extension;
        return this;
    }
    public UploadInvoiceRequestExtension getExtension() {
        return this.extension;
    }

    public UploadInvoiceRequest setInvoices(java.util.List<UploadInvoiceRequestInvoices> invoices) {
        this.invoices = invoices;
        return this;
    }
    public java.util.List<UploadInvoiceRequestInvoices> getInvoices() {
        return this.invoices;
    }

    public UploadInvoiceRequest setUserIdentity(UploadInvoiceRequestUserIdentity userIdentity) {
        this.userIdentity = userIdentity;
        return this;
    }
    public UploadInvoiceRequestUserIdentity getUserIdentity() {
        return this.userIdentity;
    }

    public static class UploadInvoiceRequestExtension extends TeaModel {
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
        @Deprecated
        public String orderNo;

        @NameInMap("orderNoList")
        public java.util.List<String> orderNoList;

        /**
         * <strong>example:</strong>
         * <p>HOTEL</p>
         */
        @NameInMap("orderType")
        public String orderType;

        public static UploadInvoiceRequestExtension build(java.util.Map<String, ?> map) throws Exception {
            UploadInvoiceRequestExtension self = new UploadInvoiceRequestExtension();
            return TeaModel.build(map, self);
        }

        public UploadInvoiceRequestExtension setBizCode(String bizCode) {
            this.bizCode = bizCode;
            return this;
        }
        public String getBizCode() {
            return this.bizCode;
        }

        public UploadInvoiceRequestExtension setOrderNo(String orderNo) {
            this.orderNo = orderNo;
            return this;
        }
        public String getOrderNo() {
            return this.orderNo;
        }

        public UploadInvoiceRequestExtension setOrderNoList(java.util.List<String> orderNoList) {
            this.orderNoList = orderNoList;
            return this;
        }
        public java.util.List<String> getOrderNoList() {
            return this.orderNoList;
        }

        public UploadInvoiceRequestExtension setOrderType(String orderType) {
            this.orderType = orderType;
            return this;
        }
        public String getOrderType() {
            return this.orderType;
        }

    }

    public static class UploadInvoiceRequestInvoices extends TeaModel {
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
         * <strong>example:</strong>
         * <p>99.50</p>
         */
        @NameInMap("withoutTaxAmount")
        public String withoutTaxAmount;

        public static UploadInvoiceRequestInvoices build(java.util.Map<String, ?> map) throws Exception {
            UploadInvoiceRequestInvoices self = new UploadInvoiceRequestInvoices();
            return TeaModel.build(map, self);
        }

        public UploadInvoiceRequestInvoices setInvoiceAmount(String invoiceAmount) {
            this.invoiceAmount = invoiceAmount;
            return this;
        }
        public String getInvoiceAmount() {
            return this.invoiceAmount;
        }

        public UploadInvoiceRequestInvoices setInvoiceCode(String invoiceCode) {
            this.invoiceCode = invoiceCode;
            return this;
        }
        public String getInvoiceCode() {
            return this.invoiceCode;
        }

        public UploadInvoiceRequestInvoices setInvoiceDate(String invoiceDate) {
            this.invoiceDate = invoiceDate;
            return this;
        }
        public String getInvoiceDate() {
            return this.invoiceDate;
        }

        public UploadInvoiceRequestInvoices setInvoiceNo(String invoiceNo) {
            this.invoiceNo = invoiceNo;
            return this;
        }
        public String getInvoiceNo() {
            return this.invoiceNo;
        }

        public UploadInvoiceRequestInvoices setInvoiceType(String invoiceType) {
            this.invoiceType = invoiceType;
            return this;
        }
        public String getInvoiceType() {
            return this.invoiceType;
        }

        public UploadInvoiceRequestInvoices setLogoUrl(String logoUrl) {
            this.logoUrl = logoUrl;
            return this;
        }
        public String getLogoUrl() {
            return this.logoUrl;
        }

        public UploadInvoiceRequestInvoices setPayeeName(String payeeName) {
            this.payeeName = payeeName;
            return this;
        }
        public String getPayeeName() {
            return this.payeeName;
        }

        public UploadInvoiceRequestInvoices setPayeeTaxNo(String payeeTaxNo) {
            this.payeeTaxNo = payeeTaxNo;
            return this;
        }
        public String getPayeeTaxNo() {
            return this.payeeTaxNo;
        }

        public UploadInvoiceRequestInvoices setPayerName(String payerName) {
            this.payerName = payerName;
            return this;
        }
        public String getPayerName() {
            return this.payerName;
        }

        public UploadInvoiceRequestInvoices setPayerTaxNo(String payerTaxNo) {
            this.payerTaxNo = payerTaxNo;
            return this;
        }
        public String getPayerTaxNo() {
            return this.payerTaxNo;
        }

        public UploadInvoiceRequestInvoices setPdfUrl(String pdfUrl) {
            this.pdfUrl = pdfUrl;
            return this;
        }
        public String getPdfUrl() {
            return this.pdfUrl;
        }

        public UploadInvoiceRequestInvoices setTaxAmount(String taxAmount) {
            this.taxAmount = taxAmount;
            return this;
        }
        public String getTaxAmount() {
            return this.taxAmount;
        }

        public UploadInvoiceRequestInvoices setVerifyCode(String verifyCode) {
            this.verifyCode = verifyCode;
            return this;
        }
        public String getVerifyCode() {
            return this.verifyCode;
        }

        public UploadInvoiceRequestInvoices setWithoutTaxAmount(String withoutTaxAmount) {
            this.withoutTaxAmount = withoutTaxAmount;
            return this;
        }
        public String getWithoutTaxAmount() {
            return this.withoutTaxAmount;
        }

    }

    public static class UploadInvoiceRequestUserIdentity extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>95188</p>
         */
        @NameInMap("mobile")
        public String mobile;

        /**
         * <strong>example:</strong>
         * <p>86</p>
         */
        @NameInMap("mobileStateCode")
        public String mobileStateCode;

        /**
         * <strong>example:</strong>
         * <p>dinng1123434</p>
         */
        @NameInMap("targetCorpId")
        public String targetCorpId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>STAFF_ID</p>
         */
        @NameInMap("type")
        public String type;

        /**
         * <strong>example:</strong>
         * <p>akdfwiiw</p>
         */
        @NameInMap("unionId")
        public String unionId;

        /**
         * <strong>example:</strong>
         * <p>02734930</p>
         */
        @NameInMap("userId")
        public String userId;

        public static UploadInvoiceRequestUserIdentity build(java.util.Map<String, ?> map) throws Exception {
            UploadInvoiceRequestUserIdentity self = new UploadInvoiceRequestUserIdentity();
            return TeaModel.build(map, self);
        }

        public UploadInvoiceRequestUserIdentity setMobile(String mobile) {
            this.mobile = mobile;
            return this;
        }
        public String getMobile() {
            return this.mobile;
        }

        public UploadInvoiceRequestUserIdentity setMobileStateCode(String mobileStateCode) {
            this.mobileStateCode = mobileStateCode;
            return this;
        }
        public String getMobileStateCode() {
            return this.mobileStateCode;
        }

        public UploadInvoiceRequestUserIdentity setTargetCorpId(String targetCorpId) {
            this.targetCorpId = targetCorpId;
            return this;
        }
        public String getTargetCorpId() {
            return this.targetCorpId;
        }

        public UploadInvoiceRequestUserIdentity setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public UploadInvoiceRequestUserIdentity setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

        public UploadInvoiceRequestUserIdentity setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
