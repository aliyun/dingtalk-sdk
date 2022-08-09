// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeListUncheckedStudentRequest extends TeaModel {
    // 部门id
    @NameInMap("deptId")
    public Long deptId;

    // 页码
    @NameInMap("pageNumber")
    public Long pageNumber;

    // 分页条目数
    @NameInMap("pageSize")
    public Long pageSize;

    public static CollegeListUncheckedStudentRequest build(java.util.Map<String, ?> map) throws Exception {
        CollegeListUncheckedStudentRequest self = new CollegeListUncheckedStudentRequest();
        return TeaModel.build(map, self);
    }

    public CollegeListUncheckedStudentRequest setDeptId(Long deptId) {
        this.deptId = deptId;
        return this;
    }
    public Long getDeptId() {
        return this.deptId;
    }

    public CollegeListUncheckedStudentRequest setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public CollegeListUncheckedStudentRequest setPageSize(Long pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Long getPageSize() {
        return this.pageSize;
    }

}
