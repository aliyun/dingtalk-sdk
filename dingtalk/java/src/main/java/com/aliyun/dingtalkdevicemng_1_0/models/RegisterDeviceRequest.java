// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class RegisterDeviceRequest extends TeaModel {
    // 协助者userId列表
    @NameInMap("collaborators")
    public String collaborators;

    // 部门id
    @NameInMap("departmentId")
    public Long departmentId;

    // 设备描述
    @NameInMap("description")
    public String description;

    // 设备标识
    @NameInMap("deviceKey")
    public String deviceKey;

    // 设备名称
    @NameInMap("deviceName")
    public String deviceName;

    // 管理员userId列表
    @NameInMap("managers")
    public String managers;

    // 创建者userId
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

    public static class BatchRegisterDeviceRequestDeviceList extends TeaModel {
        // 协助者userId列表
        @NameInMap("collaborators")
        public String collaborators;

        // 部门id
        @NameInMap("departmentId")
        public Long departmentId;

        // 设备描述
        @NameInMap("description")
        public String description;

        // 设备标识
        @NameInMap("deviceKey")
        public String deviceKey;

        // 设备名称
        @NameInMap("deviceName")
        public String deviceName;

        // 管理员userId列表
        @NameInMap("managers")
        public String managers;

        public static BatchRegisterDeviceRequestDeviceList build(java.util.Map<String, ?> map) throws Exception {
            BatchRegisterDeviceRequestDeviceList self = new BatchRegisterDeviceRequestDeviceList();
            return TeaModel.build(map, self);
        }

        public BatchRegisterDeviceRequestDeviceList setCollaborators(String collaborators) {
            this.collaborators = collaborators;
            return this;
        }
        public String getCollaborators() {
            return this.collaborators;
        }

        public BatchRegisterDeviceRequestDeviceList setDepartmentId(Long departmentId) {
            this.departmentId = departmentId;
            return this;
        }
        public Long getDepartmentId() {
            return this.departmentId;
        }

        public BatchRegisterDeviceRequestDeviceList setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public BatchRegisterDeviceRequestDeviceList setDeviceKey(String deviceKey) {
            this.deviceKey = deviceKey;
            return this;
        }
        public String getDeviceKey() {
            return this.deviceKey;
        }

        public BatchRegisterDeviceRequestDeviceList setDeviceName(String deviceName) {
            this.deviceName = deviceName;
            return this;
        }
        public String getDeviceName() {
            return this.deviceName;
        }

        public BatchRegisterDeviceRequestDeviceList setManagers(String managers) {
            this.managers = managers;
            return this;
        }
        public String getManagers() {
            return this.managers;
        }

    }

}
