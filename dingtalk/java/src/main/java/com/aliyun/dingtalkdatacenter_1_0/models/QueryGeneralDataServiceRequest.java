// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryGeneralDataServiceRequest extends TeaModel {
    // 部门ID
    @NameInMap("deptId")
    public String deptId;

    // 结束日期
    @NameInMap("endDate")
    public String endDate;

    // 分页页码
    @NameInMap("pageNumber")
    public Long pageNumber;

    // 每页大小
    @NameInMap("pageSize")
    public Long pageSize;

    // 服务编码
    @NameInMap("serviceId")
    public String serviceId;

    // statDate
    @NameInMap("startDate")
    public String startDate;

    // 员工ID
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
