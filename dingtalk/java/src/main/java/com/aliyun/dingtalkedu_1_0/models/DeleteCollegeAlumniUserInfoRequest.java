// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class DeleteCollegeAlumniUserInfoRequest extends TeaModel {
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

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userIds")
    public java.util.List<String> userIds;

    public static DeleteCollegeAlumniUserInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteCollegeAlumniUserInfoRequest self = new DeleteCollegeAlumniUserInfoRequest();
        return TeaModel.build(map, self);
    }

    public DeleteCollegeAlumniUserInfoRequest setDeptId(Long deptId) {
        this.deptId = deptId;
        return this;
    }
    public Long getDeptId() {
        return this.deptId;
    }

    public DeleteCollegeAlumniUserInfoRequest setOperator(String operator) {
        this.operator = operator;
        return this;
    }
    public String getOperator() {
        return this.operator;
    }

    public DeleteCollegeAlumniUserInfoRequest setUserIds(java.util.List<String> userIds) {
        this.userIds = userIds;
        return this;
    }
    public java.util.List<String> getUserIds() {
        return this.userIds;
    }

}
