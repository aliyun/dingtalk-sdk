// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryTotalDataCountServiceRequest extends TeaModel {
    @NameInMap("deptIds")
    public java.util.List<String> deptIds;

    /**
     * <strong>example:</strong>
     * <p>20240611</p>
     */
    @NameInMap("endDate")
    public String endDate;

    @NameInMap("pageNumber")
    public Long pageNumber;

    @NameInMap("pageSize")
    public Long pageSize;

    /**
     * <strong>example:</strong>
     * <p>API-xxxx</p>
     */
    @NameInMap("serviceId")
    public String serviceId;

    /**
     * <strong>example:</strong>
     * <p>20240611</p>
     */
    @NameInMap("startDate")
    public String startDate;

    /**
     * <strong>example:</strong>
     * <p>222</p>
     */
    @NameInMap("userId")
    public String userId;

    @NameInMap("userIds")
    public java.util.List<String> userIds;

    public static QueryTotalDataCountServiceRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryTotalDataCountServiceRequest self = new QueryTotalDataCountServiceRequest();
        return TeaModel.build(map, self);
    }

    public QueryTotalDataCountServiceRequest setDeptIds(java.util.List<String> deptIds) {
        this.deptIds = deptIds;
        return this;
    }
    public java.util.List<String> getDeptIds() {
        return this.deptIds;
    }

    public QueryTotalDataCountServiceRequest setEndDate(String endDate) {
        this.endDate = endDate;
        return this;
    }
    public String getEndDate() {
        return this.endDate;
    }

    public QueryTotalDataCountServiceRequest setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public QueryTotalDataCountServiceRequest setPageSize(Long pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Long getPageSize() {
        return this.pageSize;
    }

    public QueryTotalDataCountServiceRequest setServiceId(String serviceId) {
        this.serviceId = serviceId;
        return this;
    }
    public String getServiceId() {
        return this.serviceId;
    }

    public QueryTotalDataCountServiceRequest setStartDate(String startDate) {
        this.startDate = startDate;
        return this;
    }
    public String getStartDate() {
        return this.startDate;
    }

    public QueryTotalDataCountServiceRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public QueryTotalDataCountServiceRequest setUserIds(java.util.List<String> userIds) {
        this.userIds = userIds;
        return this;
    }
    public java.util.List<String> getUserIds() {
        return this.userIds;
    }

}
