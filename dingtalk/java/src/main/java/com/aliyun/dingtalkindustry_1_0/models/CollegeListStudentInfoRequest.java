// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeListStudentInfoRequest extends TeaModel {
    /**
     * <p>部门id</p>
     */
    @NameInMap("deptId")
    public Long deptId;

    /**
     * <p>人员状态</p>
     */
    @NameInMap("dingStudentStatus")
    public String dingStudentStatus;

    /**
     * <p>当前页数</p>
     */
    @NameInMap("pageNumber")
    public Long pageNumber;

    /**
     * <p>单页的条目数</p>
     */
    @NameInMap("pageSize")
    public Long pageSize;

    public static CollegeListStudentInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        CollegeListStudentInfoRequest self = new CollegeListStudentInfoRequest();
        return TeaModel.build(map, self);
    }

    public CollegeListStudentInfoRequest setDeptId(Long deptId) {
        this.deptId = deptId;
        return this;
    }
    public Long getDeptId() {
        return this.deptId;
    }

    public CollegeListStudentInfoRequest setDingStudentStatus(String dingStudentStatus) {
        this.dingStudentStatus = dingStudentStatus;
        return this;
    }
    public String getDingStudentStatus() {
        return this.dingStudentStatus;
    }

    public CollegeListStudentInfoRequest setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public CollegeListStudentInfoRequest setPageSize(Long pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Long getPageSize() {
        return this.pageSize;
    }

}
