// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkreport_1_0.models;

import com.aliyun.tea.*;

public class UserMapValue extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>user123</p>
     */
    @NameInMap("userId")
    public String userId;

    /**
     * <strong>example:</strong>
     * <p>张三</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <strong>example:</strong>
     * <p>xxx</p>
     */
    @NameInMap("deptId")
    public String deptId;

    public static UserMapValue build(java.util.Map<String, ?> map) throws Exception {
        UserMapValue self = new UserMapValue();
        return TeaModel.build(map, self);
    }

    public UserMapValue setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public UserMapValue setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public UserMapValue setDeptId(String deptId) {
        this.deptId = deptId;
        return this;
    }
    public String getDeptId() {
        return this.deptId;
    }

}
