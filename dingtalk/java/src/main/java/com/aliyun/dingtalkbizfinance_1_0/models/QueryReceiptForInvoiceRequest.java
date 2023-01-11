// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryReceiptForInvoiceRequest extends TeaModel {
    /**
     * <p>发票状态筛选列表 applied 已生成、unapplied 未生成 、 ignore 已忽略</p>
     */
    @NameInMap("applyStatusList")
    public java.util.List<String> applyStatusList;

    @NameInMap("endTime")
    public Long endTime;

    /**
     * <p>分页参数，从1 开始</p>
     */
    @NameInMap("pageNumber")
    public Long pageNumber;

    /**
     * <p>分页参数，每页查询个数</p>
     */
    @NameInMap("pageSize")
    public Long pageSize;

    /**
     * <p>单据状态筛选条件列表，审批中、已通过 RUNNGIN、COMPLETED</p>
     */
    @NameInMap("receiptStatusList")
    public java.util.List<String> receiptStatusList;

    /**
     * <p>开始时间</p>
     */
    @NameInMap("startTime")
    public Long startTime;

    /**
     * <p>单据标题</p>
     */
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
