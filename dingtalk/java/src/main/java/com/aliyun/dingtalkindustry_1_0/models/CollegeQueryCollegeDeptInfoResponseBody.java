// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeQueryCollegeDeptInfoResponseBody extends TeaModel {
    @NameInMap("deptId")
    public Long deptId;

    @NameInMap("deptName")
    public String deptName;

    @NameInMap("deptType")
    public String deptType;

    @NameInMap("sortFactor")
    public Long sortFactor;

    @NameInMap("superId")
    public Long superId;

    public static CollegeQueryCollegeDeptInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CollegeQueryCollegeDeptInfoResponseBody self = new CollegeQueryCollegeDeptInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public CollegeQueryCollegeDeptInfoResponseBody setDeptId(Long deptId) {
        this.deptId = deptId;
        return this;
    }
    public Long getDeptId() {
        return this.deptId;
    }

    public CollegeQueryCollegeDeptInfoResponseBody setDeptName(String deptName) {
        this.deptName = deptName;
        return this;
    }
    public String getDeptName() {
        return this.deptName;
    }

    public CollegeQueryCollegeDeptInfoResponseBody setDeptType(String deptType) {
        this.deptType = deptType;
        return this;
    }
    public String getDeptType() {
        return this.deptType;
    }

    public CollegeQueryCollegeDeptInfoResponseBody setSortFactor(Long sortFactor) {
        this.sortFactor = sortFactor;
        return this;
    }
    public Long getSortFactor() {
        return this.sortFactor;
    }

    public CollegeQueryCollegeDeptInfoResponseBody setSuperId(Long superId) {
        this.superId = superId;
        return this;
    }
    public Long getSuperId() {
        return this.superId;
    }

}
