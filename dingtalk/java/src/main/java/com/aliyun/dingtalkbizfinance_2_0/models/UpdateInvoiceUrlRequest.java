// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class UpdateInvoiceUrlRequest extends TeaModel {
    @NameInMap("body")
    public UpdateInvoiceUrlRequestBody body;

    public static UpdateInvoiceUrlRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateInvoiceUrlRequest self = new UpdateInvoiceUrlRequest();
        return TeaModel.build(map, self);
    }

    public UpdateInvoiceUrlRequest setBody(UpdateInvoiceUrlRequestBody body) {
        this.body = body;
        return this;
    }
    public UpdateInvoiceUrlRequestBody getBody() {
        return this.body;
    }

    public static class UpdateInvoiceUrlRequestBodyUrlList extends TeaModel {
        @NameInMap("invoiceCode")
        public String invoiceCode;

        @NameInMap("invoiceNo")
        public String invoiceNo;

        @NameInMap("ofdUrl")
        public String ofdUrl;

        @NameInMap("pdfUrl")
        public String pdfUrl;

        @NameInMap("xmlUrl")
        public String xmlUrl;

        public static UpdateInvoiceUrlRequestBodyUrlList build(java.util.Map<String, ?> map) throws Exception {
            UpdateInvoiceUrlRequestBodyUrlList self = new UpdateInvoiceUrlRequestBodyUrlList();
            return TeaModel.build(map, self);
        }

        public UpdateInvoiceUrlRequestBodyUrlList setInvoiceCode(String invoiceCode) {
            this.invoiceCode = invoiceCode;
            return this;
        }
        public String getInvoiceCode() {
            return this.invoiceCode;
        }

        public UpdateInvoiceUrlRequestBodyUrlList setInvoiceNo(String invoiceNo) {
            this.invoiceNo = invoiceNo;
            return this;
        }
        public String getInvoiceNo() {
            return this.invoiceNo;
        }

        public UpdateInvoiceUrlRequestBodyUrlList setOfdUrl(String ofdUrl) {
            this.ofdUrl = ofdUrl;
            return this;
        }
        public String getOfdUrl() {
            return this.ofdUrl;
        }

        public UpdateInvoiceUrlRequestBodyUrlList setPdfUrl(String pdfUrl) {
            this.pdfUrl = pdfUrl;
            return this;
        }
        public String getPdfUrl() {
            return this.pdfUrl;
        }

        public UpdateInvoiceUrlRequestBodyUrlList setXmlUrl(String xmlUrl) {
            this.xmlUrl = xmlUrl;
            return this;
        }
        public String getXmlUrl() {
            return this.xmlUrl;
        }

    }

    public static class UpdateInvoiceUrlRequestBody extends TeaModel {
        @NameInMap("companyCode")
        public String companyCode;

        @NameInMap("operator")
        public String operator;

        @NameInMap("urlList")
        public java.util.List<UpdateInvoiceUrlRequestBodyUrlList> urlList;

        public static UpdateInvoiceUrlRequestBody build(java.util.Map<String, ?> map) throws Exception {
            UpdateInvoiceUrlRequestBody self = new UpdateInvoiceUrlRequestBody();
            return TeaModel.build(map, self);
        }

        public UpdateInvoiceUrlRequestBody setCompanyCode(String companyCode) {
            this.companyCode = companyCode;
            return this;
        }
        public String getCompanyCode() {
            return this.companyCode;
        }

        public UpdateInvoiceUrlRequestBody setOperator(String operator) {
            this.operator = operator;
            return this;
        }
        public String getOperator() {
            return this.operator;
        }

        public UpdateInvoiceUrlRequestBody setUrlList(java.util.List<UpdateInvoiceUrlRequestBodyUrlList> urlList) {
            this.urlList = urlList;
            return this;
        }
        public java.util.List<UpdateInvoiceUrlRequestBodyUrlList> getUrlList() {
            return this.urlList;
        }

    }

}
