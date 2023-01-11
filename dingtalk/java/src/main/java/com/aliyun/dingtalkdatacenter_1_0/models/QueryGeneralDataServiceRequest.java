// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryGeneralDataServiceRequest extends TeaModel {
    /**
     * <p>部门ID</p>
     */
    @NameInMap("deptId")
    public String deptId;

    /**
     * <p>结束日期</p>
     */
    @NameInMap("endDate")
    public String endDate;

    /**
     * <p>分页页码</p>
     */
    @NameInMap("pageNumber")
    public Long pageNumber;

    /**
     * <p>每页大小</p>
     */
    @NameInMap("pageSize")
    public Long pageSize;

    /**
     * <p>服务编码</p>
     */
    @NameInMap("serviceId")
    public String serviceId;

    /**
     * <p>statDate</p>
     */
    @NameInMap("startDate")
    public String startDate;

    /**
     * <p>员工ID</p>
     */
    @NameInMap("userId")
    public String userId;

    public static QueryGeneralDataServiceRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryGeneralDataServiceRequest self = new QueryGeneralDataServiceRequest();
        return TeaModel.build(map, self);
    }

    public QueryGeneralDataServiceRequest setDeptId(String deptId) {
        this.deptId = deptId;
        return this;
    }
    public String getDeptId() {
        return this.deptId;
    }

    public QueryGeneralDataServiceRequest setEndDate(String endDate) {
        this.endDate = endDate;
        return this;
    }
    public String getEndDate() {
        return this.endDate;
    }

    public QueryGeneralDataServiceRequest setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public QueryGeneralDataServiceRequest setPageSize(Long pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Long getPageSize() {
        return this.pageSize;
    }

    public QueryGeneralDataServiceRequest setServiceId(String serviceId) {
        this.serviceId = serviceId;
        return this;
    }
    public String getServiceId() {
        return this.serviceId;
    }

    public QueryGeneralDataServiceRequest setStartDate(String startDate) {
        this.startDate = startDate;
        return this;
    }
    public String getStartDate() {
        return this.startDate;
    }

    public QueryGeneralDataServiceRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
