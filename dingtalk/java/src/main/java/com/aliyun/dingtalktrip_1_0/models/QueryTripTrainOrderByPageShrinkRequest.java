// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrip_1_0.models;

import com.aliyun.tea.*;

public class QueryTripTrainOrderByPageShrinkRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>2025-12-01</p>
     */
    @NameInMap("endTime")
    public String endTime;

    @NameInMap("orderStatus")
    public String orderStatusShrink;

    @NameInMap("pageIndex")
    public Integer pageIndex;

    @NameInMap("pageSize")
    public Integer pageSize;

    /**
     * <strong>example:</strong>
     * <p>2025-11-11</p>
     */
    @NameInMap("startTime")
    public String startTime;

    public static QueryTripTrainOrderByPageShrinkRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryTripTrainOrderByPageShrinkRequest self = new QueryTripTrainOrderByPageShrinkRequest();
        return TeaModel.build(map, self);
    }

    public QueryTripTrainOrderByPageShrinkRequest setEndTime(String endTime) {
        this.endTime = endTime;
        return this;
    }
    public String getEndTime() {
        return this.endTime;
    }

    public QueryTripTrainOrderByPageShrinkRequest setOrderStatusShrink(String orderStatusShrink) {
        this.orderStatusShrink = orderStatusShrink;
        return this;
    }
    public String getOrderStatusShrink() {
        return this.orderStatusShrink;
    }

    public QueryTripTrainOrderByPageShrinkRequest setPageIndex(Integer pageIndex) {
        this.pageIndex = pageIndex;
        return this;
    }
    public Integer getPageIndex() {
        return this.pageIndex;
    }

    public QueryTripTrainOrderByPageShrinkRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public QueryTripTrainOrderByPageShrinkRequest setStartTime(String startTime) {
        this.startTime = startTime;
        return this;
    }
    public String getStartTime() {
        return this.startTime;
    }

}
