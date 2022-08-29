// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class HospitalDataCheckResponseBody extends TeaModel {
    // 所有状态的科室数量
    @NameInMap("allDeptCount")
    public Long allDeptCount;

    // 所有状态的科室人员数量
    @NameInMap("allDeptUserCount")
    public Long allDeptUserCount;

    // 所有状态的医疗组数量
    @NameInMap("allGroupCount")
    public Long allGroupCount;

    // 所有状态的医疗组人员数量
    @NameInMap("allGroupUserCount")
    public Long allGroupUserCount;

    // 正常状态的科室数量
    @NameInMap("deptCount")
    public Long deptCount;

    // 正常状态的科室人员数量
    @NameInMap("deptUserCount")
    public Long deptUserCount;

    // 正常状态的医疗组数量
    @NameInMap("groupCount")
    public Long groupCount;

    // 正常状态的医疗组人员数量
    @NameInMap("groupUserCount")
    public Long groupUserCount;

    // 数据是否一致
    @NameInMap("match")
    public Boolean match;

    public static HospitalDataCheckResponseBody build(java.util.Map<String, ?> map) throws Exception {
        HospitalDataCheckResponseBody self = new HospitalDataCheckResponseBody();
        return TeaModel.build(map, self);
    }

    public HospitalDataCheckResponseBody setAllDeptCount(Long allDeptCount) {
        this.allDeptCount = allDeptCount;
        return this;
    }
    public Long getAllDeptCount() {
        return this.allDeptCount;
    }

    public HospitalDataCheckResponseBody setAllDeptUserCount(Long allDeptUserCount) {
        this.allDeptUserCount = allDeptUserCount;
        return this;
    }
    public Long getAllDeptUserCount() {
        return this.allDeptUserCount;
    }

    public HospitalDataCheckResponseBody setAllGroupCount(Long allGroupCount) {
        this.allGroupCount = allGroupCount;
        return this;
    }
    public Long getAllGroupCount() {
        return this.allGroupCount;
    }

    public HospitalDataCheckResponseBody setAllGroupUserCount(Long allGroupUserCount) {
        this.allGroupUserCount = allGroupUserCount;
        return this;
    }
    public Long getAllGroupUserCount() {
        return this.allGroupUserCount;
    }

    public HospitalDataCheckResponseBody setDeptCount(Long deptCount) {
        this.deptCount = deptCount;
        return this;
    }
    public Long getDeptCount() {
        return this.deptCount;
    }

    public HospitalDataCheckResponseBody setDeptUserCount(Long deptUserCount) {
        this.deptUserCount = deptUserCount;
        return this;
    }
    public Long getDeptUserCount() {
        return this.deptUserCount;
    }

    public HospitalDataCheckResponseBody setGroupCount(Long groupCount) {
        this.groupCount = groupCount;
        return this;
    }
    public Long getGroupCount() {
        return this.groupCount;
    }

    public HospitalDataCheckResponseBody setGroupUserCount(Long groupUserCount) {
        this.groupUserCount = groupUserCount;
        return this;
    }
    public Long getGroupUserCount() {
        return this.groupUserCount;
    }

    public HospitalDataCheckResponseBody setMatch(Boolean match) {
        this.match = match;
        return this;
    }
    public Boolean getMatch() {
        return this.match;
    }

}
