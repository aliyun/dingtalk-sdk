// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class CheckVoucherStatusRequest extends TeaModel {
    @NameInMap("companyCode")
    public String companyCode;

    @NameInMap("endTime")
    public Long endTime;

    @NameInMap("financeType")
    public String financeType;

    @NameInMap("invoiceCode")
    public String invoiceCode;

    @NameInMap("invoiceNo")
    public String invoiceNo;

    @NameInMap("pageNumber")
    public Long pageNumber;

    @NameInMap("pageSize")
    public Long pageSize;

    @NameInMap("startTime")
    public Long startTime;

    @NameInMap("taxNo")
    public String taxNo;

    @NameInMap("verifyStatus")
    public String verifyStatus;

    public static CheckVoucherStatusRequest build(java.util.Map<String, ?> map) throws Exception {
        CheckVoucherStatusRequest self = new CheckVoucherStatusRequest();
        return TeaModel.build(map, self);
    }

    public CheckVoucherStatusRequest setCompanyCode(String companyCode) {
        this.companyCode = companyCode;
        return this;
    }
    public String getCompanyCode() {
        return this.companyCode;
    }

    public CheckVoucherStatusRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public CheckVoucherStatusRequest setFinanceType(String financeType) {
        this.financeType = financeType;
        return this;
    }
    public String getFinanceType() {
        return this.financeType;
    }

    public CheckVoucherStatusRequest setInvoiceCode(String invoiceCode) {
        this.invoiceCode = invoiceCode;
        return this;
    }
    public String getInvoiceCode() {
        return this.invoiceCode;
    }

    public CheckVoucherStatusRequest setInvoiceNo(String invoiceNo) {
        this.invoiceNo = invoiceNo;
        return this;
    }
    public String getInvoiceNo() {
        return this.invoiceNo;
    }

    public CheckVoucherStatusRequest setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public CheckVoucherStatusRequest setPageSize(Long pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Long getPageSize() {
        return this.pageSize;
    }

    public CheckVoucherStatusRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public CheckVoucherStatusRequest setTaxNo(String taxNo) {
        this.taxNo = taxNo;
        return this;
    }
    public String getTaxNo() {
        return this.taxNo;
    }

    public CheckVoucherStatusRequest setVerifyStatus(String verifyStatus) {
        this.verifyStatus = verifyStatus;
        return this;
    }
    public String getVerifyStatus() {
        return this.verifyStatus;
    }

}
