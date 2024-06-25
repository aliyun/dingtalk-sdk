// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class DeleteCollegeAlumniDeptRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("deptId")
    public Long deptId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("operator")
    public String operator;

    public static DeleteCollegeAlumniDeptRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteCollegeAlumniDeptRequest self = new DeleteCollegeAlumniDeptRequest();
        return TeaModel.build(map, self);
    }

    public DeleteCollegeAlumniDeptRequest setDeptId(Long deptId) {
        this.deptId = deptId;
        return this;
    }
    public Long getDeptId() {
        return this.deptId;
    }

    public DeleteCollegeAlumniDeptRequest setOperator(String operator) {
        this.operator = operator;
        return this;
    }
    public String getOperator() {
        return this.operator;
    }

}
