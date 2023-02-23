// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class ChangeGroupOwnerResponseBody extends TeaModel {
    /**
     * <p>群主在业务系统内的唯一标识</p>
     */
    @NameInMap("newGroupOwnerId")
    public String newGroupOwnerId;

    /**
     * <p>群主类型<2.钉内用户类型 3.钉外用户类型></p>
     */
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
