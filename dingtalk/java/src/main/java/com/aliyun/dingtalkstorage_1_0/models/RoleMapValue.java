// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class RoleMapValue extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>MANAGER</p>
     */
    @NameInMap("id")
    public String id;

    /**
     * <strong>example:</strong>
     * <p>MANAGER</p>
     */
    @NameInMap("name")
    public String name;

    public static RoleMapValue build(java.util.Map<String, ?> map) throws Exception {
        RoleMapValue self = new RoleMapValue();
        return TeaModel.build(map, self);
    }

    public RoleMapValue setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

    public RoleMapValue setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

}
