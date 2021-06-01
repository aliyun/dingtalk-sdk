// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class UpdateTheGroupRolesOfGroupMemberResponseBody extends TeaModel {
    // result
    @NameInMap("success")
    public Boolean success;

    public static UpdateTheGroupRolesOfGroupMemberResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateTheGroupRolesOfGroupMemberResponseBody self = new UpdateTheGroupRolesOfGroupMemberResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateTheGroupRolesOfGroupMemberResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
