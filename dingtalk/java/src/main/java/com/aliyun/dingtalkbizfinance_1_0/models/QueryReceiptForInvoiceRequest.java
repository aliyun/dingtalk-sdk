// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryReceiptForInvoiceRequest extends TeaModel {
    @NameInMap("applyStatusList")
    public java.util.List<String> applyStatusList;

    @NameInMap("bizStatusList")
    public java.util.List<String> bizStatusList;

    @NameInMap("endTime")
    public Long endTime;

    @NameInMap("pageNumber")
    public Long pageNumber;

    @NameInMap("pageSize")
    public Long pageSize;

    @NameInMap("receiptStatusList")
    public java.util.List<String> receiptStatusList;

    @NameInMap("startTime")
    public Long startTime;

    @NameInMap("title")
    public String title;

    public static QueryReceiptForInvoiceRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryReceiptForInvoiceRequest self = new QueryReceiptForInvoiceRequest();
        return TeaModel.build(map, self);
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
