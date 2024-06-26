// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class UpdateInvoiceAccountingPeriodDateRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>COM_DEFAULT</p>
     */
    @NameInMap("companyCode")
    public String companyCode;

    @NameInMap("invoiceFinanceInfoVOList")
    public java.util.List<UpdateInvoiceAccountingPeriodDateRequestInvoiceFinanceInfoVOList> invoiceFinanceInfoVOList;

    /**
     * <strong>example:</strong>
     * <p>1234567</p>
     */
    @NameInMap("operator")
    public String operator;

    public static UpdateInvoiceAccountingPeriodDateRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateInvoiceAccountingPeriodDateRequest self = new UpdateInvoiceAccountingPeriodDateRequest();
        return TeaModel.build(map, self);
    }

    public UpdateInvoiceAccountingPeriodDateRequest setCompanyCode(String companyCode) {
        this.companyCode = companyCode;
        return this;
    }
    public String getCompanyCode() {
        return this.companyCode;
    }

    public UpdateInvoiceAccountingPeriodDateRequest setInvoiceFinanceInfoVOList(java.util.List<UpdateInvoiceAccountingPeriodDateRequestInvoiceFinanceInfoVOList> invoiceFinanceInfoVOList) {
        this.invoiceFinanceInfoVOList = invoiceFinanceInfoVOList;
        return this;
    }
    public java.util.List<UpdateInvoiceAccountingPeriodDateRequestInvoiceFinanceInfoVOList> getInvoiceFinanceInfoVOList() {
        return this.invoiceFinanceInfoVOList;
    }

    public UpdateInvoiceAccountingPeriodDateRequest setOperator(String operator) {
        this.operator = operator;
        return this;
    }
    public String getOperator() {
        return this.operator;
    }

    public static class UpdateInvoiceAccountingPeriodDateRequestInvoiceFinanceInfoVOList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>2022-02-03</p>
         */
        @NameInMap("accountingPeriodData")
        public String accountingPeriodData;

        /**
         * <strong>example:</strong>
         * <p>2202020</p>
         */
        @NameInMap("invoiceCode")
        public String invoiceCode;

        /**
         * <strong>example:</strong>
         * <p>220200200</p>
         */
        @NameInMap("invoiceNo")
        public String invoiceNo;

        /**
         * <strong>example:</strong>
         * <p>VAT_DIGITAL_NORMAL</p>
         */
        @NameInMap("invoiceType")
        public String invoiceType;

        public static UpdateInvoiceAccountingPeriodDateRequestInvoiceFinanceInfoVOList build(java.util.Map<String, ?> map) throws Exception {
            UpdateInvoiceAccountingPeriodDateRequestInvoiceFinanceInfoVOList self = new UpdateInvoiceAccountingPeriodDateRequestInvoiceFinanceInfoVOList();
            return TeaModel.build(map, self);
        }

        public UpdateInvoiceAccountingPeriodDateRequestInvoiceFinanceInfoVOList setAccountingPeriodData(String accountingPeriodData) {
            this.accountingPeriodData = accountingPeriodData;
            return this;
        }
        public String getAccountingPeriodData() {
            return this.accountingPeriodData;
        }

        public UpdateInvoiceAccountingPeriodDateRequestInvoiceFinanceInfoVOList setInvoiceCode(String invoiceCode) {
            this.invoiceCode = invoiceCode;
            return this;
        }
        public String getInvoiceCode() {
            return this.invoiceCode;
        }

        public UpdateInvoiceAccountingPeriodDateRequestInvoiceFinanceInfoVOList setInvoiceNo(String invoiceNo) {
            this.invoiceNo = invoiceNo;
            return this;
        }
        public String getInvoiceNo() {
            return this.invoiceNo;
        }

        public UpdateInvoiceAccountingPeriodDateRequestInvoiceFinanceInfoVOList setInvoiceType(String invoiceType) {
            this.invoiceType = invoiceType;
            return this;
        }
        public String getInvoiceType() {
            return this.invoiceType;
        }

    }

}
