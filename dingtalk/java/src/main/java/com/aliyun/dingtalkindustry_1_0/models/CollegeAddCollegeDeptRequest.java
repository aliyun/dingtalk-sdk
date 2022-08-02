// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeAddCollegeDeptRequest extends TeaModel {
    // 部门名称
    @NameInMap("deptName")
    public String deptName;

    // 部门类型
    @NameInMap("deptType")
    public String deptType;

    // 排序因子
    @NameInMap("sortFactor")
    public Long sortFactor;

    // 父部门id
    @NameInMap("superId")
    public Long superId;

    public static CollegeAddCollegeDeptRequest build(java.util.Map<String, ?> map) throws Exception {
        CollegeAddCollegeDeptRequest self = new CollegeAddCollegeDeptRequest();
        return TeaModel.build(map, self);
    }

    public CollegeAddCollegeDeptRequest setDeptName(String deptName) {
        this.deptName = deptName;
        return this;
    }
    public String getDeptName() {
        return this.deptName;
    }

    public CollegeAddCollegeDeptRequest setDeptType(String deptType) {
        this.deptType = deptType;
        return this;
    }
    public String getDeptType() {
        return this.deptType;
    }

    public CollegeAddCollegeDeptRequest setSortFactor(Long sortFactor) {
        this.sortFactor = sortFactor;
        return this;
    }
    public Long getSortFactor() {
        return this.sortFactor;
    }

    public CollegeAddCollegeDeptRequest setSuperId(Long superId) {
        this.superId = superId;
        return this;
    }
    public Long getSuperId() {
        return this.superId;
    }

}
