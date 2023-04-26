// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class RegisterAndActivateDeviceBatchRequest extends TeaModel {
    @NameInMap("registerAndActivateVOS")
    public java.util.List<RegisterAndActivateDeviceBatchRequestRegisterAndActivateVOS> registerAndActivateVOS;

    public static RegisterAndActivateDeviceBatchRequest build(java.util.Map<String, ?> map) throws Exception {
        RegisterAndActivateDeviceBatchRequest self = new RegisterAndActivateDeviceBatchRequest();
        return TeaModel.build(map, self);
    }

    public RegisterAndActivateDeviceBatchRequest setRegisterAndActivateVOS(java.util.List<RegisterAndActivateDeviceBatchRequestRegisterAndActivateVOS> registerAndActivateVOS) {
        this.registerAndActivateVOS = registerAndActivateVOS;
        return this;
    }
    public java.util.List<RegisterAndActivateDeviceBatchRequestRegisterAndActivateVOS> getRegisterAndActivateVOS() {
        return this.registerAndActivateVOS;
    }

    public static class RegisterAndActivateDeviceBatchRequestRegisterAndActivateVOS extends TeaModel {
        @NameInMap("deviceCallbackUrl")
        public String deviceCallbackUrl;

        @NameInMap("deviceCategory")
        public Integer deviceCategory;

        @NameInMap("deviceCode")
        public String deviceCode;

        @NameInMap("deviceDetailUrl")
        public String deviceDetailUrl;

        @NameInMap("deviceName")
        public String deviceName;

        @NameInMap("groupUuid")
        public String groupUuid;

        @NameInMap("introduction")
        public String introduction;

        @NameInMap("roleUuid")
        public String roleUuid;

        @NameInMap("typeUuid")
        public String typeUuid;

        @NameInMap("userIds")
        public java.util.List<String> userIds;

        public static RegisterAndActivateDeviceBatchRequestRegisterAndActivateVOS build(java.util.Map<String, ?> map) throws Exception {
            RegisterAndActivateDeviceBatchRequestRegisterAndActivateVOS self = new RegisterAndActivateDeviceBatchRequestRegisterAndActivateVOS();
            return TeaModel.build(map, self);
        }

        public RegisterAndActivateDeviceBatchRequestRegisterAndActivateVOS setDeviceCallbackUrl(String deviceCallbackUrl) {
            this.deviceCallbackUrl = deviceCallbackUrl;
            return this;
        }
        public String getDeviceCallbackUrl() {
            return this.deviceCallbackUrl;
        }

        public RegisterAndActivateDeviceBatchRequestRegisterAndActivateVOS setDeviceCategory(Integer deviceCategory) {
            this.deviceCategory = deviceCategory;
            return this;
        }
        public Integer getDeviceCategory() {
            return this.deviceCategory;
        }

        public RegisterAndActivateDeviceBatchRequestRegisterAndActivateVOS setDeviceCode(String deviceCode) {
            this.deviceCode = deviceCode;
            return this;
        }
        public String getDeviceCode() {
            return this.deviceCode;
        }

        public RegisterAndActivateDeviceBatchRequestRegisterAndActivateVOS setDeviceDetailUrl(String deviceDetailUrl) {
            this.deviceDetailUrl = deviceDetailUrl;
            return this;
        }
        public String getDeviceDetailUrl() {
            return this.deviceDetailUrl;
        }

        public RegisterAndActivateDeviceBatchRequestRegisterAndActivateVOS setDeviceName(String deviceName) {
            this.deviceName = deviceName;
            return this;
        }
        public String getDeviceName() {
            return this.deviceName;
        }

        public RegisterAndActivateDeviceBatchRequestRegisterAndActivateVOS setGroupUuid(String groupUuid) {
            this.groupUuid = groupUuid;
            return this;
        }
        public String getGroupUuid() {
            return this.groupUuid;
        }

        public RegisterAndActivateDeviceBatchRequestRegisterAndActivateVOS setIntroduction(String introduction) {
            this.introduction = introduction;
            return this;
        }
        public String getIntroduction() {
            return this.introduction;
        }

        public RegisterAndActivateDeviceBatchRequestRegisterAndActivateVOS setRoleUuid(String roleUuid) {
            this.roleUuid = roleUuid;
            return this;
        }
        public String getRoleUuid() {
            return this.roleUuid;
        }

        public RegisterAndActivateDeviceBatchRequestRegisterAndActivateVOS setTypeUuid(String typeUuid) {
            this.typeUuid = typeUuid;
            return this;
        }
        public String getTypeUuid() {
            return this.typeUuid;
        }

        public RegisterAndActivateDeviceBatchRequestRegisterAndActivateVOS setUserIds(java.util.List<String> userIds) {
            this.userIds = userIds;
            return this;
        }
        public java.util.List<String> getUserIds() {
            return this.userIds;
        }

    }

}
