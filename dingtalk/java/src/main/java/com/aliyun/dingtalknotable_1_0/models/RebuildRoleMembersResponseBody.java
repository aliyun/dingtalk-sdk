// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class RebuildRoleMembersResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static RebuildRoleMembersResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RebuildRoleMembersResponseBody self = new RebuildRoleMembersResponseBody();
        return TeaModel.build(map, self);
    }

    public RebuildRoleMembersResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
