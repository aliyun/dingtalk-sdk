// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryReceiptForInvoiceRequest extends TeaModel {
    // 结束时间
    @NameInMap("endTime")
    public Long endTime;

    // 发票筛选条件
    @NameInMap("invoiceFilter")
    public QueryReceiptForInvoiceRequestInvoiceFilter invoiceFilter;

    // 分页参数，从1 开始
    @NameInMap("pageNumber")
    public Long pageNumber;

    // 分页参数，每页查询个数
    @NameInMap("pageSize")
    public Long pageSize;

    // 单据状态，审批中 RUNNING，已完成 COMPLETED
    @NameInMap("receiptStatus")
    public String receiptStatus;

    // 开始时间
    @NameInMap("startTime")
    public Long startTime;

    // 单据标题
    @NameInMap("title")
    public String title;

    public static QueryReceiptForInvoiceRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryReceiptForInvoiceRequest self = new QueryReceiptForInvoiceRequest();
        return TeaModel.build(map, self);
    }

    public QueryReceiptForInvoiceRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public QueryReceiptForInvoiceRequest setInvoiceFilter(QueryReceiptForInvoiceRequestInvoiceFilter invoiceFilter) {
        this.invoiceFilter = invoiceFilter;
        return this;
    }
    public QueryReceiptForInvoiceRequestInvoiceFilter getInvoiceFilter() {
        return this.invoiceFilter;
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

    public QueryReceiptForInvoiceRequest setReceiptStatus(String receiptStatus) {
        this.receiptStatus = receiptStatus;
        return this;
    }
    public String getReceiptStatus() {
        return this.receiptStatus;
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

    public static class QueryReceiptForInvoiceRequestInvoiceFilter extends TeaModel {
        // 发票类型 进项、销项
        @NameInMap("financeType")
        public String financeType;

        // 发票状态列表
        @NameInMap("relationStatus")
        public java.util.List<String> relationStatus;

        public static QueryReceiptForInvoiceRequestInvoiceFilter build(java.util.Map<String, ?> map) throws Exception {
            QueryReceiptForInvoiceRequestInvoiceFilter self = new QueryReceiptForInvoiceRequestInvoiceFilter();
            return TeaModel.build(map, self);
        }

        public QueryReceiptForInvoiceRequestInvoiceFilter setFinanceType(String financeType) {
            this.financeType = financeType;
            return this;
        }
        public String getFinanceType() {
            return this.financeType;
        }

        public QueryReceiptForInvoiceRequestInvoiceFilter setRelationStatus(java.util.List<String> relationStatus) {
            this.relationStatus = relationStatus;
            return this;
        }
        public java.util.List<String> getRelationStatus() {
            return this.relationStatus;
        }

    }

}
