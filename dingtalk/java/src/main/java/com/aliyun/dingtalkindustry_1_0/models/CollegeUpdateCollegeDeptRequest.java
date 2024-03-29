// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeUpdateCollegeDeptRequest extends TeaModel {
    @NameInMap("deptId")
    public Long deptId;

    @NameInMap("deptName")
    public String deptName;

    @NameInMap("sortFactor")
    public Long sortFactor;

    @NameInMap("superId")
    public Long superId;

    public static CollegeUpdateCollegeDeptRequest build(java.util.Map<String, ?> map) throws Exception {
        CollegeUpdateCollegeDeptRequest self = new CollegeUpdateCollegeDeptRequest();
        return TeaModel.build(map, self);
    }

    public CollegeUpdateCollegeDeptRequest setDeptId(Long deptId) {
        this.deptId = deptId;
        return this;
    }
    public Long getDeptId() {
        return this.deptId;
    }

    public CollegeUpdateCollegeDeptRequest setDeptName(String deptName) {
        this.deptName = deptName;
        return this;
    }
    public String getDeptName() {
        return this.deptName;
    }

    public CollegeUpdateCollegeDeptRequest setSortFactor(Long sortFactor) {
        this.sortFactor = sortFactor;
        return this;
    }
    public Long getSortFactor() {
        return this.sortFactor;
    }

    public CollegeUpdateCollegeDeptRequest setSuperId(Long superId) {
        this.superId = superId;
        return this;
    }
    public Long getSuperId() {
        return this.superId;
    }

}
