// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class RegisterAndActivateDeviceResponseBody extends TeaModel {
    // Id of the request
    @NameInMap("success")
    public Boolean success;

    @NameInMap("result")
    public RegisterAndActivateDeviceResponseBodyResult result;

    public static RegisterAndActivateDeviceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RegisterAndActivateDeviceResponseBody self = new RegisterAndActivateDeviceResponseBody();
        return TeaModel.build(map, self);
    }

    public RegisterAndActivateDeviceResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public RegisterAndActivateDeviceResponseBody setResult(RegisterAndActivateDeviceResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public RegisterAndActivateDeviceResponseBodyResult getResult() {
        return this.result;
    }

    public static class RegisterAndActivateDeviceResponseBodyResult extends TeaModel {
        @NameInMap("deviceCode")
        public String deviceCode;

        @NameInMap("deviceUuid")
        public String deviceUuid;

        @NameInMap("deviceName")
        public String deviceName;

        @NameInMap("introduction")
        public String introduction;

        @NameInMap("typeUuid")
        public String typeUuid;

        @NameInMap("corpId")
        public String corpId;

        @NameInMap("roleUuid")
        public String roleUuid;

        @NameInMap("deviceDetailUrl")
        public String deviceDetailUrl;

        @NameInMap("userIds")
        public java.util.List<String> userIds;

        public static RegisterAndActivateDeviceResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            RegisterAndActivateDeviceResponseBodyResult self = new RegisterAndActivateDeviceResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public RegisterAndActivateDeviceResponseBodyResult setDeviceCode(String deviceCode) {
            this.deviceCode = deviceCode;
            return this;
        }
        public String getDeviceCode() {
            return this.deviceCode;
        }

        public RegisterAndActivateDeviceResponseBodyResult setDeviceUuid(String deviceUuid) {
            this.deviceUuid = deviceUuid;
            return this;
        }
        public String getDeviceUuid() {
            return this.deviceUuid;
        }

        public RegisterAndActivateDeviceResponseBodyResult setDeviceName(String deviceName) {
            this.deviceName = deviceName;
            return this;
        }
        public String getDeviceName() {
            return this.deviceName;
        }

        public RegisterAndActivateDeviceResponseBodyResult setIntroduction(String introduction) {
            this.introduction = introduction;
            return this;
        }
        public String getIntroduction() {
            return this.introduction;
        }

        public RegisterAndActivateDeviceResponseBodyResult setTypeUuid(String typeUuid) {
            this.typeUuid = typeUuid;
            return this;
        }
        public String getTypeUuid() {
            return this.typeUuid;
        }

        public RegisterAndActivateDeviceResponseBodyResult setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public RegisterAndActivateDeviceResponseBodyResult setRoleUuid(String roleUuid) {
            this.roleUuid = roleUuid;
            return this;
        }
        public String getRoleUuid() {
            return this.roleUuid;
        }

        public RegisterAndActivateDeviceResponseBodyResult setDeviceDetailUrl(String deviceDetailUrl) {
            this.deviceDetailUrl = deviceDetailUrl;
            return this;
        }
        public String getDeviceDetailUrl() {
            return this.deviceDetailUrl;
        }

        public RegisterAndActivateDeviceResponseBodyResult setUserIds(java.util.List<String> userIds) {
            this.userIds = userIds;
            return this;
        }
        public java.util.List<String> getUserIds() {
            return this.userIds;
        }

    }

}
