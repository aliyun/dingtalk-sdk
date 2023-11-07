// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryReceiptForInvoiceRequest extends TeaModel {
    @NameInMap("accountantBookId")
    public String accountantBookId;

    @NameInMap("applyStatusList")
    public java.util.List<String> applyStatusList;

    @NameInMap("bizStatusList")
    public java.util.List<String> bizStatusList;

    @NameInMap("companyCode")
    public String companyCode;

    @NameInMap("endTime")
    public Long endTime;

    @NameInMap("pageNumber")
    public Long pageNumber;

    @NameInMap("pageSize")
    public Long pageSize;

    @NameInMap("receiptStatusList")
    public java.util.List<String> receiptStatusList;

    @NameInMap("searchParams")
    public java.util.Map<String, String> searchParams;

    @NameInMap("startTime")
    public Long startTime;

    @NameInMap("title")
    public String title;

    public static QueryReceiptForInvoiceRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryReceiptForInvoiceRequest self = new QueryReceiptForInvoiceRequest();
        return TeaModel.build(map, self);
    }

    public QueryReceiptForInvoiceRequest setAccountantBookId(String accountantBookId) {
        this.accountantBookId = accountantBookId;
        return this;
    }
    public String getAccountantBookId() {
        return this.accountantBookId;
    }

    public QueryReceiptForInvoiceRequest setApplyStatusList(java.util.List<String> applyStatusList) {
        this.applyStatusList = applyStatusList;
        return this;
    }
    public java.util.List<String> getApplyStatusList() {
        return this.applyStatusList;
    }

    public QueryReceiptForInvoiceRequest setBizStatusList(java.util.List<String> bizStatusList) {
        this.bizStatusList = bizStatusList;
        return this;
    }
    public java.util.List<String> getBizStatusList() {
        return this.bizStatusList;
    }

    public QueryReceiptForInvoiceRequest setCompanyCode(String companyCode) {
        this.companyCode = companyCode;
        return this;
    }
    public String getCompanyCode() {
        return this.companyCode;
    }

    public QueryReceiptForInvoiceRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public QueryReceiptForInvoiceRequest setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public QueryReceiptForInvoiceRequest setPageSize(Long pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Long getPageSize() {
        return this.pageSize;
    }

    public QueryReceiptForInvoiceRequest setReceiptStatusList(java.util.List<String> receiptStatusList) {
        this.receiptStatusList = receiptStatusList;
        return this;
    }
    public java.util.List<String> getReceiptStatusList() {
        return this.receiptStatusList;
    }

    public QueryReceiptForInvoiceRequest setSearchParams(java.util.Map<String, String> searchParams) {
        this.searchParams = searchParams;
        return this;
    }
    public java.util.Map<String, String> getSearchParams() {
        return this.searchParams;
    }

    public QueryReceiptForInvoiceRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public QueryReceiptForInvoiceRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

}
