// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class BatchRegisterDeviceRequest extends TeaModel {
    // 设备列表
    @NameInMap("deviceList")
    public java.util.List<BatchRegisterDeviceRequestDeviceList> deviceList;

    // 组织id
    @NameInMap("dingCorpId")
    public String dingCorpId;

    // 创建者userId
    @NameInMap("userId")
    public String userId;

    public static BatchRegisterDeviceRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchRegisterDeviceRequest self = new BatchRegisterDeviceRequest();
        return TeaModel.build(map, self);
    }

    public BatchRegisterDeviceRequest setDeviceList(java.util.List<BatchRegisterDeviceRequestDeviceList> deviceList) {
        this.deviceList = deviceList;
        return this;
    }
    public java.util.List<BatchRegisterDeviceRequestDeviceList> getDeviceList() {
        return this.deviceList;
    }

    public BatchRegisterDeviceRequest setDingCorpId(String dingCorpId) {
        this.dingCorpId = dingCorpId;
        return this;
    }
    public String getDingCorpId() {
        return this.dingCorpId;
    }

    public BatchRegisterDeviceRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public static class BatchRegisterDeviceRequestDeviceList extends TeaModel {
        // 设备标识
        @NameInMap("deviceKey")
        public String deviceKey;

        // 设备名称
        @NameInMap("deviceName")
        public String deviceName;

        // 部门id
        @NameInMap("departmentId")
        public Long departmentId;

        // 管理员userId列表
        @NameInMap("managers")
        public String managers;

        // 协助者userId列表
        @NameInMap("collaborators")
        public String collaborators;

        // 设备描述
        @NameInMap("description")
        public String description;

        public static BatchRegisterDeviceRequestDeviceList build(java.util.Map<String, ?> map) throws Exception {
            BatchRegisterDeviceRequestDeviceList self = new BatchRegisterDeviceRequestDeviceList();
            return TeaModel.build(map, self);
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

        public BatchRegisterDeviceRequestDeviceList setDepartmentId(Long departmentId) {
            this.departmentId = departmentId;
            return this;
        }
        public Long getDepartmentId() {
            return this.departmentId;
        }

        public BatchRegisterDeviceRequestDeviceList setManagers(String managers) {
            this.managers = managers;
            return this;
        }
        public String getManagers() {
            return this.managers;
        }

        public BatchRegisterDeviceRequestDeviceList setCollaborators(String collaborators) {
            this.collaborators = collaborators;
            return this;
        }
        public String getCollaborators() {
            return this.collaborators;
        }

        public BatchRegisterDeviceRequestDeviceList setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

    }

}
