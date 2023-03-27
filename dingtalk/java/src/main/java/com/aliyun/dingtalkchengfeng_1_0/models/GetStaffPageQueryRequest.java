// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0.models;

import com.aliyun.tea.*;

public class GetStaffPageQueryRequest extends TeaModel {
    /**
     * <p>部门编码</p>
     */
    @NameInMap("deptCode")
    public String deptCode;

    /**
     * <p>员工名称,模糊查询</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>当前页码</p>
     */
    @NameInMap("pageNumber")
    public Integer pageNumber;

    /**
     * <p>分页条数</p>
     */
    @NameInMap("pageSize")
    public Integer pageSize;

    /**
     * <p>工号</p>
     */
    @NameInMap("workNo")
    public String workNo;

    public static GetStaffPageQueryRequest build(java.util.Map<String, ?> map) throws Exception {
        GetStaffPageQueryRequest self = new GetStaffPageQueryRequest();
        return TeaModel.build(map, self);
    }

    public GetStaffPageQueryRequest setDeptCode(String deptCode) {
        this.deptCode = deptCode;
        return this;
    }
    public String getDeptCode() {
        return this.deptCode;
    }

    public GetStaffPageQueryRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public GetStaffPageQueryRequest setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public GetStaffPageQueryRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public GetStaffPageQueryRequest setWorkNo(String workNo) {
        this.workNo = workNo;
        return this;
    }
    public String getWorkNo() {
        return this.workNo;
    }

}
