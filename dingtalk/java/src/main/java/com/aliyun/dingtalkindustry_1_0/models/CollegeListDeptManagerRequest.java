// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeListDeptManagerRequest extends TeaModel {
    // 部门id
    @NameInMap("deptId")
    public Long deptId;

    // 页码
    @NameInMap("pageNumber")
    public Long pageNumber;

    // 单页的条目数
    @NameInMap("pageSize")
    public Long pageSize;

    public static CollegeListDeptManagerRequest build(java.util.Map<String, ?> map) throws Exception {
        CollegeListDeptManagerRequest self = new CollegeListDeptManagerRequest();
        return TeaModel.build(map, self);
    }

    public CollegeListDeptManagerRequest setDeptId(Long deptId) {
        this.deptId = deptId;
        return this;
    }
    public Long getDeptId() {
        return this.deptId;
    }

    public CollegeListDeptManagerRequest setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public CollegeListDeptManagerRequest setPageSize(Long pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Long getPageSize() {
        return this.pageSize;
    }

}
