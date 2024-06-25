// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class UpdateInvoiceAccountingStatusRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>COM_DEFAULT</p>
     */
    @NameInMap("companyCode")
    public String companyCode;

    @NameInMap("invoiceFinanceInfoVOList")
    public java.util.List<UpdateInvoiceAccountingStatusRequestInvoiceFinanceInfoVOList> invoiceFinanceInfoVOList;

    /**
     * <strong>example:</strong>
     * <p>1234567</p>
     */
    @NameInMap("operator")
    public String operator;

    public static UpdateInvoiceAccountingStatusRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateInvoiceAccountingStatusRequest self = new UpdateInvoiceAccountingStatusRequest();
        return TeaModel.build(map, self);
    }

    public UpdateInvoiceAccountingStatusRequest setCompanyCode(String companyCode) {
        this.companyCode = companyCode;
        return this;
    }
    public String getCompanyCode() {
        return this.companyCode;
    }

    public UpdateInvoiceAccountingStatusRequest setInvoiceFinanceInfoVOList(java.util.List<UpdateInvoiceAccountingStatusRequestInvoiceFinanceInfoVOList> invoiceFinanceInfoVOList) {
        this.invoiceFinanceInfoVOList = invoiceFinanceInfoVOList;
        return this;
    }
    public java.util.List<UpdateInvoiceAccountingStatusRequestInvoiceFinanceInfoVOList> getInvoiceFinanceInfoVOList() {
        return this.invoiceFinanceInfoVOList;
    }

    public UpdateInvoiceAccountingStatusRequest setOperator(String operator) {
        this.operator = operator;
        return this;
    }
    public String getOperator() {
        return this.operator;
    }

    public static class UpdateInvoiceAccountingStatusRequestInvoiceFinanceInfoVOList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>in_account</p>
         */
        @NameInMap("accountingStatus")
        public String accountingStatus;

        /**
         * <strong>example:</strong>
         * <p>2022002022</p>
         */
        @NameInMap("invoiceCode")
        public String invoiceCode;

        /**
         * <strong>example:</strong>
         * <p>20022</p>
         */
        @NameInMap("invoiceNo")
        public String invoiceNo;

        /**
         * <strong>example:</strong>
         * <p>VAT_DIGITAL_NORMAL</p>
         */
        @NameInMap("invoiceType")
        public String invoiceType;

        public static UpdateInvoiceAccountingStatusRequestInvoiceFinanceInfoVOList build(java.util.Map<String, ?> map) throws Exception {
            UpdateInvoiceAccountingStatusRequestInvoiceFinanceInfoVOList self = new UpdateInvoiceAccountingStatusRequestInvoiceFinanceInfoVOList();
            return TeaModel.build(map, self);
        }

        public UpdateInvoiceAccountingStatusRequestInvoiceFinanceInfoVOList setAccountingStatus(String accountingStatus) {
            this.accountingStatus = accountingStatus;
            return this;
        }
        public String getAccountingStatus() {
            return this.accountingStatus;
        }

        public UpdateInvoiceAccountingStatusRequestInvoiceFinanceInfoVOList setInvoiceCode(String invoiceCode) {
            this.invoiceCode = invoiceCode;
            return this;
        }
        public String getInvoiceCode() {
            return this.invoiceCode;
        }

        public UpdateInvoiceAccountingStatusRequestInvoiceFinanceInfoVOList setInvoiceNo(String invoiceNo) {
            this.invoiceNo = invoiceNo;
            return this;
        }
        public String getInvoiceNo() {
            return this.invoiceNo;
        }

        public UpdateInvoiceAccountingStatusRequestInvoiceFinanceInfoVOList setInvoiceType(String invoiceType) {
            this.invoiceType = invoiceType;
            return this;
        }
        public String getInvoiceType() {
            return this.invoiceType;
        }

    }

}
