// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeListStudentInfoRequest extends TeaModel {
    @NameInMap("deptId")
    public Long deptId;

    @NameInMap("dingStudentStatus")
    public String dingStudentStatus;

    @NameInMap("pageNumber")
    public Long pageNumber;

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
