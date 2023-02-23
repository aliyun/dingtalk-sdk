// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class UpdateGroupNameResponseBody extends TeaModel {
    /**
     * <p>新群名称</p>
     */
    @NameInMap("newGroupName")
    public String newGroupName;

    public static UpdateGroupNameResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateGroupNameResponseBody self = new UpdateGroupNameResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateGroupNameResponseBody setNewGroupName(String newGroupName) {
        this.newGroupName = newGroupName;
        return this;
    }
    public String getNewGroupName() {
        return this.newGroupName;
    }

}
