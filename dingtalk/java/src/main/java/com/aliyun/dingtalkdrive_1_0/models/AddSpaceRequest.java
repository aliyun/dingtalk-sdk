// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class AddSpaceRequest extends TeaModel {
    /**
     * <p>空间名称</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>用户id</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static AddSpaceRequest build(java.util.Map<String, ?> map) throws Exception {
        AddSpaceRequest self = new AddSpaceRequest();
        return TeaModel.build(map, self);
    }

    public AddSpaceRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public AddSpaceRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
