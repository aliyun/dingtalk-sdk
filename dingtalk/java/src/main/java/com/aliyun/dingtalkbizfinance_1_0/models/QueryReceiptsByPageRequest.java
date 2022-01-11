// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryReceiptsByPageRequest extends TeaModel {
    // 检索结束时间，默认当前时间，离开始时间最长不超过180天
    @NameInMap("endTime")
    public Long endTime;

    // 数据模型id
    @NameInMap("modelId")
    public String modelId;

    // 分页，从1开始
    @NameInMap("pageNumber")
    public Long pageNumber;

    // 分页大小，默认10，最大100
    @NameInMap("pageSize")
    public Long pageSize;

    // 检索开始时间
    @NameInMap("startTime")
    public Long startTime;

    // 检索排序时间类型：创建时间(gmt_create)，更新时间(gmt_modified)
    @NameInMap("timeFilterField")
    public String timeFilterField;

    public static QueryReceiptsByPageRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryReceiptsByPageRequest self = new QueryReceiptsByPageRequest();
        return TeaModel.build(map, self);
    }

    public QueryReceiptsByPageRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public QueryReceiptsByPageRequest setModelId(String modelId) {
        this.modelId = modelId;
        return this;
    }
    public String getModelId() {
        return this.modelId;
    }

    public QueryReceiptsByPageRequest setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public QueryReceiptsByPageRequest setPageSize(Long pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Long getPageSize() {
        return this.pageSize;
    }

    public QueryReceiptsByPageRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public QueryReceiptsByPageRequest setTimeFilterField(String timeFilterField) {
        this.timeFilterField = timeFilterField;
        return this;
    }
    public String getTimeFilterField() {
        return this.timeFilterField;
    }

}
