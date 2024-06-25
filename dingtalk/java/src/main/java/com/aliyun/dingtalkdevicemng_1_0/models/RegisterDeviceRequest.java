// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class RegisterDeviceRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>manager1,1000,10001</p>
     */
    @NameInMap("collaborators")
    public String collaborators;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("departmentId")
    public Long departmentId;

    /**
     * <strong>example:</strong>
     * <p>生产组1号设备负责生产第一批产品</p>
     */
    @NameInMap("description")
    public String description;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>key_xxxxxxx</p>
     */
    @NameInMap("deviceKey")
    public String deviceKey;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>生产1组1号机</p>
     */
    @NameInMap("deviceName")
    public String deviceName;

    /**
     * <strong>example:</strong>
     * <p>manager1,manager2</p>
     */
    @NameInMap("managers")
    public String managers;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>manager10</p>
     */
    @NameInMap("userId")
    public String userId;

    public static RegisterDeviceRequest build(java.util.Map<String, ?> map) throws Exception {
        RegisterDeviceRequest self = new RegisterDeviceRequest();
        return TeaModel.build(map, self);
    }

    public RegisterDeviceRequest setCollaborators(String collaborators) {
        this.collaborators = collaborators;
        return this;
    }
    public String getCollaborators() {
        return this.collaborators;
    }

    public RegisterDeviceRequest setDepartmentId(Long departmentId) {
        this.departmentId = departmentId;
        return this;
    }
    public Long getDepartmentId() {
        return this.departmentId;
    }

    public RegisterDeviceRequest setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public RegisterDeviceRequest setDeviceKey(String deviceKey) {
        this.deviceKey = deviceKey;
        return this;
    }
    public String getDeviceKey() {
        return this.deviceKey;
    }

    public RegisterDeviceRequest setDeviceName(String deviceName) {
        this.deviceName = deviceName;
        return this;
    }
    public String getDeviceName() {
        return this.deviceName;
    }

    public RegisterDeviceRequest setManagers(String managers) {
        this.managers = managers;
        return this;
    }
    public String getManagers() {
        return this.managers;
    }

    public RegisterDeviceRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
