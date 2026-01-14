// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrip_1_0.models;

import com.aliyun.tea.*;

public class QueryTripFlightOrderByPageRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>2025-12-01</p>
     */
    @NameInMap("endTime")
    public String endTime;

    @NameInMap("orderStatus")
    public java.util.List<String> orderStatus;

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

    public static QueryTripFlightOrderByPageRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryTripFlightOrderByPageRequest self = new QueryTripFlightOrderByPageRequest();
        return TeaModel.build(map, self);
    }

    public QueryTripFlightOrderByPageRequest setEndTime(String endTime) {
        this.endTime = endTime;
        return this;
    }
    public String getEndTime() {
        return this.endTime;
    }

    public QueryTripFlightOrderByPageRequest setOrderStatus(java.util.List<String> orderStatus) {
        this.orderStatus = orderStatus;
        return this;
    }
    public java.util.List<String> getOrderStatus() {
        return this.orderStatus;
    }

    public QueryTripFlightOrderByPageRequest setPageIndex(Integer pageIndex) {
        this.pageIndex = pageIndex;
        return this;
    }
    public Integer getPageIndex() {
        return this.pageIndex;
    }

    public QueryTripFlightOrderByPageRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public QueryTripFlightOrderByPageRequest setStartTime(String startTime) {
        this.startTime = startTime;
        return this;
    }
    public String getStartTime() {
        return this.startTime;
    }

}
