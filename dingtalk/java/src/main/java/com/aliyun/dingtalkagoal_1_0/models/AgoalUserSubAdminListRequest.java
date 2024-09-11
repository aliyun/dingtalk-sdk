// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class AgoalUserSubAdminListRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>ACCOUNT</p>
     */
    @NameInMap("funcPermissionGroup")
    public String funcPermissionGroup;

    public static AgoalUserSubAdminListRequest build(java.util.Map<String, ?> map) throws Exception {
        AgoalUserSubAdminListRequest self = new AgoalUserSubAdminListRequest();
        return TeaModel.build(map, self);
    }

    public AgoalUserSubAdminListRequest setFuncPermissionGroup(String funcPermissionGroup) {
        this.funcPermissionGroup = funcPermissionGroup;
        return this;
    }
    public String getFuncPermissionGroup() {
        return this.funcPermissionGroup;
    }

}
