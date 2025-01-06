// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class BatchQueryOrgInvoiceUrlResponseBody extends TeaModel {
    @NameInMap("failInvoiceList")
    public java.util.List<BatchQueryOrgInvoiceUrlResponseBodyFailInvoiceList> failInvoiceList;

    @NameInMap("orgInvoiceUrlList")
    public java.util.List<BatchQueryOrgInvoiceUrlResponseBodyOrgInvoiceUrlList> orgInvoiceUrlList;

    public static BatchQueryOrgInvoiceUrlResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BatchQueryOrgInvoiceUrlResponseBody self = new BatchQueryOrgInvoiceUrlResponseBody();
        return TeaModel.build(map, self);
    }

    public BatchQueryOrgInvoiceUrlResponseBody setFailInvoiceList(java.util.List<BatchQueryOrgInvoiceUrlResponseBodyFailInvoiceList> failInvoiceList) {
        this.failInvoiceList = failInvoiceList;
        return this;
    }
    public java.util.List<BatchQueryOrgInvoiceUrlResponseBodyFailInvoiceList> getFailInvoiceList() {
        return this.failInvoiceList;
    }

    public BatchQueryOrgInvoiceUrlResponseBody setOrgInvoiceUrlList(java.util.List<BatchQueryOrgInvoiceUrlResponseBodyOrgInvoiceUrlList> orgInvoiceUrlList) {
        this.orgInvoiceUrlList = orgInvoiceUrlList;
        return this;
    }
    public java.util.List<BatchQueryOrgInvoiceUrlResponseBodyOrgInvoiceUrlList> getOrgInvoiceUrlList() {
        return this.orgInvoiceUrlList;
    }

    public static class BatchQueryOrgInvoiceUrlResponseBodyFailInvoiceList extends TeaModel {
        @NameInMap("errorMsg")
        public String errorMsg;

        @NameInMap("invoiceCode")
        public String invoiceCode;

        @NameInMap("invoiceNo")
        public String invoiceNo;

        public static BatchQueryOrgInvoiceUrlResponseBodyFailInvoiceList build(java.util.Map<String, ?> map) throws Exception {
            BatchQueryOrgInvoiceUrlResponseBodyFailInvoiceList self = new BatchQueryOrgInvoiceUrlResponseBodyFailInvoiceList();
            return TeaModel.build(map, self);
        }

        public BatchQueryOrgInvoiceUrlResponseBodyFailInvoiceList setErrorMsg(String errorMsg) {
            this.errorMsg = errorMsg;
            return this;
        }
        public String getErrorMsg() {
            return this.errorMsg;
        }

        public BatchQueryOrgInvoiceUrlResponseBodyFailInvoiceList setInvoiceCode(String invoiceCode) {
            this.invoiceCode = invoiceCode;
            return this;
        }
        public String getInvoiceCode() {
            return this.invoiceCode;
        }

        public BatchQueryOrgInvoiceUrlResponseBodyFailInvoiceList setInvoiceNo(String invoiceNo) {
            this.invoiceNo = invoiceNo;
            return this;
        }
        public String getInvoiceNo() {
            return this.invoiceNo;
        }

    }

    public static class BatchQueryOrgInvoiceUrlResponseBodyOrgInvoiceUrlList extends TeaModel {
        @NameInMap("invoiceCode")
        public String invoiceCode;

        @NameInMap("invoiceNo")
        public String invoiceNo;

        @NameInMap("ofdUrl")
        public String ofdUrl;

        @NameInMap("originFileType")
        public String originFileType;

        @NameInMap("originFileUrl")
        public String originFileUrl;

        @NameInMap("pdfUrl")
        public String pdfUrl;

        @NameInMap("xmlUrl")
        public String xmlUrl;

        public static BatchQueryOrgInvoiceUrlResponseBodyOrgInvoiceUrlList build(java.util.Map<String, ?> map) throws Exception {
            BatchQueryOrgInvoiceUrlResponseBodyOrgInvoiceUrlList self = new BatchQueryOrgInvoiceUrlResponseBodyOrgInvoiceUrlList();
            return TeaModel.build(map, self);
        }

        public BatchQueryOrgInvoiceUrlResponseBodyOrgInvoiceUrlList setInvoiceCode(String invoiceCode) {
            this.invoiceCode = invoiceCode;
            return this;
        }
        public String getInvoiceCode() {
            return this.invoiceCode;
        }

        public BatchQueryOrgInvoiceUrlResponseBodyOrgInvoiceUrlList setInvoiceNo(String invoiceNo) {
            this.invoiceNo = invoiceNo;
            return this;
        }
        public String getInvoiceNo() {
            return this.invoiceNo;
        }

        public BatchQueryOrgInvoiceUrlResponseBodyOrgInvoiceUrlList setOfdUrl(String ofdUrl) {
            this.ofdUrl = ofdUrl;
            return this;
        }
        public String getOfdUrl() {
            return this.ofdUrl;
        }

        public BatchQueryOrgInvoiceUrlResponseBodyOrgInvoiceUrlList setOriginFileType(String originFileType) {
            this.originFileType = originFileType;
            return this;
        }
        public String getOriginFileType() {
            return this.originFileType;
        }

        public BatchQueryOrgInvoiceUrlResponseBodyOrgInvoiceUrlList setOriginFileUrl(String originFileUrl) {
            this.originFileUrl = originFileUrl;
            return this;
        }
        public String getOriginFileUrl() {
            return this.originFileUrl;
        }

        public BatchQueryOrgInvoiceUrlResponseBodyOrgInvoiceUrlList setPdfUrl(String pdfUrl) {
            this.pdfUrl = pdfUrl;
            return this;
        }
        public String getPdfUrl() {
            return this.pdfUrl;
        }

        public BatchQueryOrgInvoiceUrlResponseBodyOrgInvoiceUrlList setXmlUrl(String xmlUrl) {
            this.xmlUrl = xmlUrl;
            return this;
        }
        public String getXmlUrl() {
            return this.xmlUrl;
        }

    }

}
