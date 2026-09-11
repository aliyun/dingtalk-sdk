// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class QueryReceiptsByPageShrinkRequest extends TeaModel {
    @NameInMap("endTime")
    public Long endTime;

    @NameInMap("modelIds")
    public String modelIdsShrink;

    @NameInMap("pageNumber")
    public Long pageNumber;

    @NameInMap("pageSize")
    public Long pageSize;

    @NameInMap("startTime")
    public Long startTime;

    @NameInMap("timeFilterField")
    public String timeFilterField;

    public static QueryReceiptsByPageShrinkRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryReceiptsByPageShrinkRequest self = new QueryReceiptsByPageShrinkRequest();
        return TeaModel.build(map, self);
    }

    public QueryReceiptsByPageShrinkRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public QueryReceiptsByPageShrinkRequest setModelIdsShrink(String modelIdsShrink) {
        this.modelIdsShrink = modelIdsShrink;
        return this;
    }
    public String getModelIdsShrink() {
        return this.modelIdsShrink;
    }

    public QueryReceiptsByPageShrinkRequest setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public QueryReceiptsByPageShrinkRequest setPageSize(Long pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Long getPageSize() {
        return this.pageSize;
    }

    public QueryReceiptsByPageShrinkRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public QueryReceiptsByPageShrinkRequest setTimeFilterField(String timeFilterField) {
        this.timeFilterField = timeFilterField;
        return this;
    }
    public String getTimeFilterField() {
        return this.timeFilterField;
    }

}
