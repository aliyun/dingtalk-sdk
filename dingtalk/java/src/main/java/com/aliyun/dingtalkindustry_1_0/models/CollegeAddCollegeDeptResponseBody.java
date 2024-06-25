// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeAddCollegeDeptResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>123123</p>
     */
    @NameInMap("deptId")
    public Long deptId;

    public static CollegeAddCollegeDeptResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CollegeAddCollegeDeptResponseBody self = new CollegeAddCollegeDeptResponseBody();
        return TeaModel.build(map, self);
    }

    public CollegeAddCollegeDeptResponseBody setDeptId(Long deptId) {
        this.deptId = deptId;
        return this;
    }
    public Long getDeptId() {
        return this.deptId;
    }

}
