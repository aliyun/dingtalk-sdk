// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class BatchRegisterDeviceRequest extends TeaModel {
    @NameInMap("deviceList")
    public java.util.List<BatchRegisterDeviceRequestDeviceList> deviceList;

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

    public BatchRegisterDeviceRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public static class BatchRegisterDeviceRequestDeviceList extends TeaModel {
        @NameInMap("collaborators")
        public String collaborators;

        @NameInMap("departmentId")
        public Long departmentId;

        @NameInMap("description")
        public String description;

        @NameInMap("deviceKey")
        public String deviceKey;

        @NameInMap("deviceName")
        public String deviceName;

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
