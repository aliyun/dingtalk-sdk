// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class UpdateResideceGroupRequest extends TeaModel {
    // 组长userid
    @NameInMap("managerUserId")
    public String managerUserId;

    // 组名字
    @NameInMap("departmentName")
    public String departmentName;

    // 组id
    @NameInMap("departmentId")
    public Long departmentId;

    public static UpdateResideceGroupRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateResideceGroupRequest self = new UpdateResideceGroupRequest();
        return TeaModel.build(map, self);
    }

    public UpdateResideceGroupRequest setManagerUserId(String managerUserId) {
        this.managerUserId = managerUserId;
        return this;
    }
    public String getManagerUserId() {
        return this.managerUserId;
    }

    public UpdateResideceGroupRequest setDepartmentName(String departmentName) {
        this.departmentName = departmentName;
        return this;
    }
    public String getDepartmentName() {
        return this.departmentName;
    }

    public UpdateResideceGroupRequest setDepartmentId(Long departmentId) {
        this.departmentId = departmentId;
        return this;
    }
    public Long getDepartmentId() {
        return this.departmentId;
    }

}
