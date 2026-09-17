// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class QueryReceiptsByPageRequest extends TeaModel {
    @NameInMap("endTime")
    public Long endTime;

    @NameInMap("modelIds")
    public java.util.List<String> modelIds;

    @NameInMap("pageIndex")
    public Long pageIndex;

    @NameInMap("pageSize")
    public Long pageSize;

    @NameInMap("startTime")
    public Long startTime;

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

    public QueryReceiptsByPageRequest setModelIds(java.util.List<String> modelIds) {
        this.modelIds = modelIds;
        return this;
    }
    public java.util.List<String> getModelIds() {
        return this.modelIds;
    }

    public QueryReceiptsByPageRequest setPageIndex(Long pageIndex) {
        this.pageIndex = pageIndex;
        return this;
    }
    public Long getPageIndex() {
        return this.pageIndex;
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
