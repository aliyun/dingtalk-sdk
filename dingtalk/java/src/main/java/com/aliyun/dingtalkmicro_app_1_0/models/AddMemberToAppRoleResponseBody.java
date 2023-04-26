// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class AddMemberToAppRoleResponseBody extends TeaModel {
    @NameInMap("latestScopeVersion")
    public Long latestScopeVersion;

    public static AddMemberToAppRoleResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddMemberToAppRoleResponseBody self = new AddMemberToAppRoleResponseBody();
        return TeaModel.build(map, self);
    }

    public AddMemberToAppRoleResponseBody setLatestScopeVersion(Long latestScopeVersion) {
        this.latestScopeVersion = latestScopeVersion;
        return this;
    }
    public Long getLatestScopeVersion() {
        return this.latestScopeVersion;
    }

}
