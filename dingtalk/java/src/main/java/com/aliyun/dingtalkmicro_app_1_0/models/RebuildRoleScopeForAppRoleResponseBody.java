// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class RebuildRoleScopeForAppRoleResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>123</p>
     */
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
