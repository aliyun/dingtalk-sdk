// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryGeneralDataServiceBatchRequest extends TeaModel {
    @NameInMap("deptIds")
    public java.util.List<String> deptIds;

    @NameInMap("endDate")
    public String endDate;

    @NameInMap("pageNumber")
    public Long pageNumber;

    @NameInMap("pageSize")
    public Long pageSize;

    @NameInMap("serviceId")
    public String serviceId;

    @NameInMap("startDate")
    public String startDate;

    @NameInMap("userId")
    public String userId;

    @NameInMap("userIds")
    public java.util.List<String> userIds;

    public static QueryGeneralDataServiceBatchRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryGeneralDataServiceBatchRequest self = new QueryGeneralDataServiceBatchRequest();
        return TeaModel.build(map, self);
    }

    public QueryGeneralDataServiceBatchRequest setDeptIds(java.util.List<String> deptIds) {
        this.deptIds = deptIds;
        return this;
    }
    public java.util.List<String> getDeptIds() {
        return this.deptIds;
    }

    public QueryGeneralDataServiceBatchRequest setEndDate(String endDate) {
        this.endDate = endDate;
        return this;
    }
    public String getEndDate() {
        return this.endDate;
    }

    public QueryGeneralDataServiceBatchRequest setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public QueryGeneralDataServiceBatchRequest setPageSize(Long pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Long getPageSize() {
        return this.pageSize;
    }

    public QueryGeneralDataServiceBatchRequest setServiceId(String serviceId) {
        this.serviceId = serviceId;
        return this;
    }
    public String getServiceId() {
        return this.serviceId;
    }

    public QueryGeneralDataServiceBatchRequest setStartDate(String startDate) {
        this.startDate = startDate;
        return this;
    }
    public String getStartDate() {
        return this.startDate;
    }

    public QueryGeneralDataServiceBatchRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public QueryGeneralDataServiceBatchRequest setUserIds(java.util.List<String> userIds) {
        this.userIds = userIds;
        return this;
    }
    public java.util.List<String> getUserIds() {
        return this.userIds;
    }

}
