// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class RebuildRoleScopeForAppRoleResponseBody extends TeaModel {
    // 角色范围最新版本号
    @NameInMap("latestScopeVersion")
    public Long latestScopeVersion;

    public static RebuildRoleScopeForAppRoleResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RebuildRoleScopeForAppRoleResponseBody self = new RebuildRoleScopeForAppRoleResponseBody();
        return TeaModel.build(map, self);
    }

    public RebuildRoleScopeForAppRoleResponseBody setLatestScopeVersion(Long latestScopeVersion) {
        this.latestScopeVersion = latestScopeVersion;
        return this;
    }
    public Long getLatestScopeVersion() {
        return this.latestScopeVersion;
    }

}
