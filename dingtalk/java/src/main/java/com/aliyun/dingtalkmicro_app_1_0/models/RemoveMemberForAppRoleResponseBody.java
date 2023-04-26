// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class RemoveMemberForAppRoleResponseBody extends TeaModel {
    @NameInMap("latestScopeVersion")
    public Long latestScopeVersion;

    public static RemoveMemberForAppRoleResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RemoveMemberForAppRoleResponseBody self = new RemoveMemberForAppRoleResponseBody();
        return TeaModel.build(map, self);
    }

    public RemoveMemberForAppRoleResponseBody setLatestScopeVersion(Long latestScopeVersion) {
        this.latestScopeVersion = latestScopeVersion;
        return this;
    }
    public Long getLatestScopeVersion() {
        return this.latestScopeVersion;
    }

}
