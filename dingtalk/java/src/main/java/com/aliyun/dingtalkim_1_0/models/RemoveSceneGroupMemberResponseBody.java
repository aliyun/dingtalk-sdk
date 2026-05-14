// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class RemoveSceneGroupMemberResponseBody extends TeaModel {
    /**
     * <p>是否成功</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static RemoveSceneGroupMemberResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RemoveSceneGroupMemberResponseBody self = new RemoveSceneGroupMemberResponseBody();
        return TeaModel.build(map, self);
    }

    public RemoveSceneGroupMemberResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
