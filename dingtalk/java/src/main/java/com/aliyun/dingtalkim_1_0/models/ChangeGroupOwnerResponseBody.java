// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class ChangeGroupOwnerResponseBody extends TeaModel {
    // Id of the request
    @NameInMap("newGroupOwnerId")
    public String newGroupOwnerId;

    @NameInMap("newGroupOwnerType")
    public Integer newGroupOwnerType;

    public static ChangeGroupOwnerResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ChangeGroupOwnerResponseBody self = new ChangeGroupOwnerResponseBody();
        return TeaModel.build(map, self);
    }

    public ChangeGroupOwnerResponseBody setNewGroupOwnerId(String newGroupOwnerId) {
        this.newGroupOwnerId = newGroupOwnerId;
        return this;
    }
    public String getNewGroupOwnerId() {
        return this.newGroupOwnerId;
    }

    public ChangeGroupOwnerResponseBody setNewGroupOwnerType(Integer newGroupOwnerType) {
        this.newGroupOwnerType = newGroupOwnerType;
        return this;
    }
    public Integer getNewGroupOwnerType() {
        return this.newGroupOwnerType;
    }

}
