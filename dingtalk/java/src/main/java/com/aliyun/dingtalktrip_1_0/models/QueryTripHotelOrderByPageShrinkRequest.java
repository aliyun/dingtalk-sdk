// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrip_1_0.models;

import com.aliyun.tea.*;

public class QueryTripHotelOrderByPageShrinkRequest extends TeaModel {
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

    public static QueryTripHotelOrderByPageShrinkRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryTripHotelOrderByPageShrinkRequest self = new QueryTripHotelOrderByPageShrinkRequest();
        return TeaModel.build(map, self);
    }

    public QueryTripHotelOrderByPageShrinkRequest setEndTime(String endTime) {
        this.endTime = endTime;
        return this;
    }
    public String getEndTime() {
        return this.endTime;
    }

    public QueryTripHotelOrderByPageShrinkRequest setOrderStatusShrink(String orderStatusShrink) {
        this.orderStatusShrink = orderStatusShrink;
        return this;
    }
    public String getOrderStatusShrink() {
        return this.orderStatusShrink;
    }

    public QueryTripHotelOrderByPageShrinkRequest setPageIndex(Integer pageIndex) {
        this.pageIndex = pageIndex;
        return this;
    }
    public Integer getPageIndex() {
        return this.pageIndex;
    }

    public QueryTripHotelOrderByPageShrinkRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public QueryTripHotelOrderByPageShrinkRequest setStartTime(String startTime) {
        this.startTime = startTime;
        return this;
    }
    public String getStartTime() {
        return this.startTime;
    }

}
