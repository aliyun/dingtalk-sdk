// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeUpdateCollegeDeptRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1111</p>
     */
    @NameInMap("deptId")
    public Long deptId;

    @NameInMap("deptName")
    public String deptName;

    /**
     * <strong>example:</strong>
     * <p>10</p>
     */
    @NameInMap("sortFactor")
    public Long sortFactor;

    /**
     * <strong>example:</strong>
     * <p>22222</p>
     */
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
