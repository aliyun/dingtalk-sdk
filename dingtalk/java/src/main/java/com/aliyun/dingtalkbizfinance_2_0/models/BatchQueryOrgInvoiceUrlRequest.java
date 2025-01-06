// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class BatchQueryOrgInvoiceUrlRequest extends TeaModel {
    @NameInMap("companyCode")
    public String companyCode;

    @NameInMap("invoiceKeyVOList")
    public java.util.List<BatchQueryOrgInvoiceUrlRequestInvoiceKeyVOList> invoiceKeyVOList;

    @NameInMap("operator")
    public String operator;

    public static BatchQueryOrgInvoiceUrlRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchQueryOrgInvoiceUrlRequest self = new BatchQueryOrgInvoiceUrlRequest();
        return TeaModel.build(map, self);
    }

    public BatchQueryOrgInvoiceUrlRequest setCompanyCode(String companyCode) {
        this.companyCode = companyCode;
        return this;
    }
    public String getCompanyCode() {
        return this.companyCode;
    }

    public BatchQueryOrgInvoiceUrlRequest setInvoiceKeyVOList(java.util.List<BatchQueryOrgInvoiceUrlRequestInvoiceKeyVOList> invoiceKeyVOList) {
        this.invoiceKeyVOList = invoiceKeyVOList;
        return this;
    }
    public java.util.List<BatchQueryOrgInvoiceUrlRequestInvoiceKeyVOList> getInvoiceKeyVOList() {
        return this.invoiceKeyVOList;
    }

    public BatchQueryOrgInvoiceUrlRequest setOperator(String operator) {
        this.operator = operator;
        return this;
    }
    public String getOperator() {
        return this.operator;
    }

    public static class BatchQueryOrgInvoiceUrlRequestInvoiceKeyVOList extends TeaModel {
        @NameInMap("invoiceCode")
        public String invoiceCode;

        @NameInMap("invoiceNo")
        public String invoiceNo;

        public static BatchQueryOrgInvoiceUrlRequestInvoiceKeyVOList build(java.util.Map<String, ?> map) throws Exception {
            BatchQueryOrgInvoiceUrlRequestInvoiceKeyVOList self = new BatchQueryOrgInvoiceUrlRequestInvoiceKeyVOList();
            return TeaModel.build(map, self);
        }

        public BatchQueryOrgInvoiceUrlRequestInvoiceKeyVOList setInvoiceCode(String invoiceCode) {
            this.invoiceCode = invoiceCode;
            return this;
        }
        public String getInvoiceCode() {
            return this.invoiceCode;
        }

        public BatchQueryOrgInvoiceUrlRequestInvoiceKeyVOList setInvoiceNo(String invoiceNo) {
            this.invoiceNo = invoiceNo;
            return this;
        }
        public String getInvoiceNo() {
            return this.invoiceNo;
        }

    }

}
