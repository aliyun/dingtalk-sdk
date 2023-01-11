// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class UpdateResideceGroupRequest extends TeaModel {
    /**
     * <p>组id</p>
     */
    @NameInMap("departmentId")
    public Long departmentId;

    /**
     * <p>组名字</p>
     */
    @NameInMap("departmentName")
    public String departmentName;

    /**
     * <p>组长userid</p>
     */
    @NameInMap("managerUserId")
    public String managerUserId;

    public static UpdateResideceGroupRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateResideceGroupRequest self = new UpdateResideceGroupRequest();
        return TeaModel.build(map, self);
    }

    public UpdateResideceGroupRequest setDepartmentId(Long departmentId) {
        this.departmentId = departmentId;
        return this;
    }
    public Long getDepartmentId() {
        return this.departmentId;
    }

    public UpdateResideceGroupRequest setDepartmentName(String departmentName) {
        this.departmentName = departmentName;
        return this;
    }
    public String getDepartmentName() {
        return this.departmentName;
    }

    public UpdateResideceGroupRequest setManagerUserId(String managerUserId) {
        this.managerUserId = managerUserId;
        return this;
    }
    public String getManagerUserId() {
        return this.managerUserId;
    }

}
