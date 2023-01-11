// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class EditDeviceAdminRequest extends TeaModel {
    /**
     * <p>需要处理的设备编号。客户侧生成的设备标识，能够唯一标识一个设备，该字段与uuid字段需要二选一，并且不能都填充。</p>
     */
    @NameInMap("deviceCode")
    public String deviceCode;

    /**
     * <p>角色唯一标识</p>
     */
    @NameInMap("roleUuid")
    public String roleUuid;

    /**
     * <p>需要编辑的角色唯一标识，非必填，不传默认为管理员。</p>
     */
    @NameInMap("userIds")
    public java.util.List<String> userIds;

    /**
     * <p>设备唯一标识，钉钉侧生成的设备标识，能够唯一标识一个设备，该字段与deviceCode字段需要二选一，并且不能都填充。</p>
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
