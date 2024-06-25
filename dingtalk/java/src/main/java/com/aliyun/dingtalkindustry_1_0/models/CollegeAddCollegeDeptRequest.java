// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeAddCollegeDeptRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>三年二班</p>
     */
    @NameInMap("deptName")
    public String deptName;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>class</p>
     */
    @NameInMap("deptType")
    public String deptType;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>10</p>
     */
    @NameInMap("sortFactor")
    public Long sortFactor;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>22222</p>
     */
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
