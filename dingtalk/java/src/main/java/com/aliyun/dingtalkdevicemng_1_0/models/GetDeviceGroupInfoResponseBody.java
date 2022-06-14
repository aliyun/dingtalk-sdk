// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class GetDeviceGroupInfoResponseBody extends TeaModel {
    @NameInMap("result")
    public GetDeviceGroupInfoResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static GetDeviceGroupInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetDeviceGroupInfoResponseBody self = new GetDeviceGroupInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetDeviceGroupInfoResponseBody setResult(GetDeviceGroupInfoResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetDeviceGroupInfoResponseBodyResult getResult() {
        return this.result;
    }

    public GetDeviceGroupInfoResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class GetDeviceGroupInfoResponseBodyResultDevices extends TeaModel {
        @NameInMap("deviceCode")
        public String deviceCode;

        @NameInMap("deviceName")
        public String deviceName;

        @NameInMap("deviceUuid")
        public String deviceUuid;

        @NameInMap("uuid")
        public String uuid;

        public static GetDeviceGroupInfoResponseBodyResultDevices build(java.util.Map<String, ?> map) throws Exception {
            GetDeviceGroupInfoResponseBodyResultDevices self = new GetDeviceGroupInfoResponseBodyResultDevices();
            return TeaModel.build(map, self);
        }

        public GetDeviceGroupInfoResponseBodyResultDevices setDeviceCode(String deviceCode) {
            this.deviceCode = deviceCode;
            return this;
        }
        public String getDeviceCode() {
            return this.deviceCode;
        }

        public GetDeviceGroupInfoResponseBodyResultDevices setDeviceName(String deviceName) {
            this.deviceName = deviceName;
            return this;
        }
        public String getDeviceName() {
            return this.deviceName;
        }

        public GetDeviceGroupInfoResponseBodyResultDevices setDeviceUuid(String deviceUuid) {
            this.deviceUuid = deviceUuid;
            return this;
        }
        public String getDeviceUuid() {
            return this.deviceUuid;
        }

        public GetDeviceGroupInfoResponseBodyResultDevices setUuid(String uuid) {
            this.uuid = uuid;
            return this;
        }
        public String getUuid() {
            return this.uuid;
        }

    }

    public static class GetDeviceGroupInfoResponseBodyResult extends TeaModel {
        @NameInMap("devices")
        public java.util.List<GetDeviceGroupInfoResponseBodyResultDevices> devices;

        @NameInMap("ownerUser")
        public String ownerUser;

        @NameInMap("subAdminUsers")
        public java.util.List<String> subAdminUsers;

        @NameInMap("title")
        public String title;

        @NameInMap("users")
        public java.util.Map<String, String> users;

        public static GetDeviceGroupInfoResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetDeviceGroupInfoResponseBodyResult self = new GetDeviceGroupInfoResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetDeviceGroupInfoResponseBodyResult setDevices(java.util.List<GetDeviceGroupInfoResponseBodyResultDevices> devices) {
            this.devices = devices;
            return this;
        }
        public java.util.List<GetDeviceGroupInfoResponseBodyResultDevices> getDevices() {
            return this.devices;
        }

        public GetDeviceGroupInfoResponseBodyResult setOwnerUser(String ownerUser) {
            this.ownerUser = ownerUser;
            return this;
        }
        public String getOwnerUser() {
            return this.ownerUser;
        }

        public GetDeviceGroupInfoResponseBodyResult setSubAdminUsers(java.util.List<String> subAdminUsers) {
            this.subAdminUsers = subAdminUsers;
            return this;
        }
        public java.util.List<String> getSubAdminUsers() {
            return this.subAdminUsers;
        }

        public GetDeviceGroupInfoResponseBodyResult setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public GetDeviceGroupInfoResponseBodyResult setUsers(java.util.Map<String, String> users) {
            this.users = users;
            return this;
        }
        public java.util.Map<String, String> getUsers() {
            return this.users;
        }

    }

}
