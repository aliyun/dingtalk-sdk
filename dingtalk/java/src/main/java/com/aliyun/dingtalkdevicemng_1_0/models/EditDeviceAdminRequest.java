// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class EditDeviceAdminRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>xxxxxx</p>
     */
    @NameInMap("deviceCode")
    public String deviceCode;

    /**
     * <strong>example:</strong>
     * <p>xxxxx</p>
     */
    @NameInMap("roleUuid")
    public String roleUuid;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userIds")
    public java.util.List<String> userIds;

    /**
     * <strong>example:</strong>
     * <p>xxxxxx</p>
     */
    @NameInMap("uuid")
    public String uuid;

    public static EditDeviceAdminRequest build(java.util.Map<String, ?> map) throws Exception {
        EditDeviceAdminRequest self = new EditDeviceAdminRequest();
        return TeaModel.build(map, self);
    }

    public EditDeviceAdminRequest setDeviceCode(String deviceCode) {
        this.deviceCode = deviceCode;
        return this;
    }
    public String getDeviceCode() {
        return this.deviceCode;
    }

    public EditDeviceAdminRequest setRoleUuid(String roleUuid) {
        this.roleUuid = roleUuid;
        return this;
    }
    public String getRoleUuid() {
        return this.roleUuid;
    }

    public EditDeviceAdminRequest setUserIds(java.util.List<String> userIds) {
        this.userIds = userIds;
        return this;
    }
    public java.util.List<String> getUserIds() {
        return this.userIds;
    }

    public EditDeviceAdminRequest setUuid(String uuid) {
        this.uuid = uuid;
        return this;
    }
    public String getUuid() {
        return this.uuid;
    }

}
