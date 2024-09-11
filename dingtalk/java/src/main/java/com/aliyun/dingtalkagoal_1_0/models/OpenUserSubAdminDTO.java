// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class OpenUserSubAdminDTO extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("deptIds")
    public java.util.List<String> deptIds;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>dingxxxxe3d8c283bb4aa39a90f97fcb1e09</p>
     */
    @NameInMap("dingCorpId")
    public String dingCorpId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>211042291978xxxx</p>
     */
    @NameInMap("dingUserId")
    public String dingUserId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("permissionGroupCodes")
    public java.util.List<String> permissionGroupCodes;

    public static OpenUserSubAdminDTO build(java.util.Map<String, ?> map) throws Exception {
        OpenUserSubAdminDTO self = new OpenUserSubAdminDTO();
        return TeaModel.build(map, self);
    }

    public OpenUserSubAdminDTO setDeptIds(java.util.List<String> deptIds) {
        this.deptIds = deptIds;
        return this;
    }
    public java.util.List<String> getDeptIds() {
        return this.deptIds;
    }

    public OpenUserSubAdminDTO setDingCorpId(String dingCorpId) {
        this.dingCorpId = dingCorpId;
        return this;
    }
    public String getDingCorpId() {
        return this.dingCorpId;
    }

    public OpenUserSubAdminDTO setDingUserId(String dingUserId) {
        this.dingUserId = dingUserId;
        return this;
    }
    public String getDingUserId() {
        return this.dingUserId;
    }

    public OpenUserSubAdminDTO setPermissionGroupCodes(java.util.List<String> permissionGroupCodes) {
        this.permissionGroupCodes = permissionGroupCodes;
        return this;
    }
    public java.util.List<String> getPermissionGroupCodes() {
        return this.permissionGroupCodes;
    }

}
