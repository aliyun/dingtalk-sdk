// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class HospitalDataCheckRequest extends TeaModel {
    /**
     * <p>所有状态的科室数量</p>
     */
    @NameInMap("allDeptCount")
    public Long allDeptCount;

    /**
     * <p>正常状态的科室人员数量</p>
     */
    @NameInMap("allDeptUserCount")
    public Long allDeptUserCount;

    /**
     * <p>所有状态的医疗组数量</p>
     */
    @NameInMap("allGroupCount")
    public Long allGroupCount;

    /**
     * <p>所有状态的医疗组人员数量</p>
     */
    @NameInMap("allGroupUserCount")
    public Long allGroupUserCount;

    /**
     * <p>状态为0的科室数量</p>
     */
    @NameInMap("deptCount")
    public Long deptCount;

    /**
     * <p>正常状态的科室人员数量</p>
     */
    @NameInMap("deptUserCount")
    public Long deptUserCount;

    /**
     * <p>正常状态的医疗组数量</p>
     */
    @NameInMap("groupCount")
    public Long groupCount;

    /**
     * <p>正常状态的医疗组人员数量</p>
     */
    @NameInMap("groupUserCount")
    public Long groupUserCount;

    public static HospitalDataCheckRequest build(java.util.Map<String, ?> map) throws Exception {
        HospitalDataCheckRequest self = new HospitalDataCheckRequest();
        return TeaModel.build(map, self);
    }

    public HospitalDataCheckRequest setAllDeptCount(Long allDeptCount) {
        this.allDeptCount = allDeptCount;
        return this;
    }
    public Long getAllDeptCount() {
        return this.allDeptCount;
    }

    public HospitalDataCheckRequest setAllDeptUserCount(Long allDeptUserCount) {
        this.allDeptUserCount = allDeptUserCount;
        return this;
    }
    public Long getAllDeptUserCount() {
        return this.allDeptUserCount;
    }

    public HospitalDataCheckRequest setAllGroupCount(Long allGroupCount) {
        this.allGroupCount = allGroupCount;
        return this;
    }
    public Long getAllGroupCount() {
        return this.allGroupCount;
    }

    public HospitalDataCheckRequest setAllGroupUserCount(Long allGroupUserCount) {
        this.allGroupUserCount = allGroupUserCount;
        return this;
    }
    public Long getAllGroupUserCount() {
        return this.allGroupUserCount;
    }

    public HospitalDataCheckRequest setDeptCount(Long deptCount) {
        this.deptCount = deptCount;
        return this;
    }
    public Long getDeptCount() {
        return this.deptCount;
    }

    public HospitalDataCheckRequest setDeptUserCount(Long deptUserCount) {
        this.deptUserCount = deptUserCount;
        return this;
    }
    public Long getDeptUserCount() {
        return this.deptUserCount;
    }

    public HospitalDataCheckRequest setGroupCount(Long groupCount) {
        this.groupCount = groupCount;
        return this;
    }
    public Long getGroupCount() {
        return this.groupCount;
    }

    public HospitalDataCheckRequest setGroupUserCount(Long groupUserCount) {
        this.groupUserCount = groupUserCount;
        return this;
    }
    public Long getGroupUserCount() {
        return this.groupUserCount;
    }

}
