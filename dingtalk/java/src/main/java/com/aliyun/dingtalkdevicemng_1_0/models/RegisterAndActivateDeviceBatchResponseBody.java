// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class RegisterAndActivateDeviceBatchResponseBody extends TeaModel {
    @NameInMap("failItems")
    public java.util.List<RegisterAndActivateDeviceBatchResponseBodyFailItems> failItems;

    @NameInMap("success")
    public Boolean success;

    @NameInMap("successItems")
    public java.util.List<RegisterAndActivateDeviceBatchResponseBodySuccessItems> successItems;

    public static RegisterAndActivateDeviceBatchResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RegisterAndActivateDeviceBatchResponseBody self = new RegisterAndActivateDeviceBatchResponseBody();
        return TeaModel.build(map, self);
    }

    public RegisterAndActivateDeviceBatchResponseBody setFailItems(java.util.List<RegisterAndActivateDeviceBatchResponseBodyFailItems> failItems) {
        this.failItems = failItems;
        return this;
    }
    public java.util.List<RegisterAndActivateDeviceBatchResponseBodyFailItems> getFailItems() {
        return this.failItems;
    }

    public RegisterAndActivateDeviceBatchResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public RegisterAndActivateDeviceBatchResponseBody setSuccessItems(java.util.List<RegisterAndActivateDeviceBatchResponseBodySuccessItems> successItems) {
        this.successItems = successItems;
        return this;
    }
    public java.util.List<RegisterAndActivateDeviceBatchResponseBodySuccessItems> getSuccessItems() {
        return this.successItems;
    }

    public static class RegisterAndActivateDeviceBatchResponseBodyFailItemsResult extends TeaModel {
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

        @NameInMap("icon")
        public String icon;

        @NameInMap("introduction")
        public String introduction;

        @NameInMap("roleUuid")
        public String roleUuid;

        @NameInMap("status")
        public Long status;

        @NameInMap("typeUuid")
        public String typeUuid;

        @NameInMap("userIds")
        public java.util.List<String> userIds;

        @NameInMap("uuid")
        public String uuid;

        public static RegisterAndActivateDeviceBatchResponseBodyFailItemsResult build(java.util.Map<String, ?> map) throws Exception {
            RegisterAndActivateDeviceBatchResponseBodyFailItemsResult self = new RegisterAndActivateDeviceBatchResponseBodyFailItemsResult();
            return TeaModel.build(map, self);
        }

        public RegisterAndActivateDeviceBatchResponseBodyFailItemsResult setDeviceCallbackUrl(String deviceCallbackUrl) {
            this.deviceCallbackUrl = deviceCallbackUrl;
            return this;
        }
        public String getDeviceCallbackUrl() {
            return this.deviceCallbackUrl;
        }

        public RegisterAndActivateDeviceBatchResponseBodyFailItemsResult setDeviceCategory(Integer deviceCategory) {
            this.deviceCategory = deviceCategory;
            return this;
        }
        public Integer getDeviceCategory() {
            return this.deviceCategory;
        }

        public RegisterAndActivateDeviceBatchResponseBodyFailItemsResult setDeviceCode(String deviceCode) {
            this.deviceCode = deviceCode;
            return this;
        }
        public String getDeviceCode() {
            return this.deviceCode;
        }

        public RegisterAndActivateDeviceBatchResponseBodyFailItemsResult setDeviceDetailUrl(String deviceDetailUrl) {
            this.deviceDetailUrl = deviceDetailUrl;
            return this;
        }
        public String getDeviceDetailUrl() {
            return this.deviceDetailUrl;
        }

        public RegisterAndActivateDeviceBatchResponseBodyFailItemsResult setDeviceName(String deviceName) {
            this.deviceName = deviceName;
            return this;
        }
        public String getDeviceName() {
            return this.deviceName;
        }

        public RegisterAndActivateDeviceBatchResponseBodyFailItemsResult setGroupUuid(String groupUuid) {
            this.groupUuid = groupUuid;
            return this;
        }
        public String getGroupUuid() {
            return this.groupUuid;
        }

        public RegisterAndActivateDeviceBatchResponseBodyFailItemsResult setIcon(String icon) {
            this.icon = icon;
            return this;
        }
        public String getIcon() {
            return this.icon;
        }

        public RegisterAndActivateDeviceBatchResponseBodyFailItemsResult setIntroduction(String introduction) {
            this.introduction = introduction;
            return this;
        }
        public String getIntroduction() {
            return this.introduction;
        }

        public RegisterAndActivateDeviceBatchResponseBodyFailItemsResult setRoleUuid(String roleUuid) {
            this.roleUuid = roleUuid;
            return this;
        }
        public String getRoleUuid() {
            return this.roleUuid;
        }

        public RegisterAndActivateDeviceBatchResponseBodyFailItemsResult setStatus(Long status) {
            this.status = status;
            return this;
        }
        public Long getStatus() {
            return this.status;
        }

        public RegisterAndActivateDeviceBatchResponseBodyFailItemsResult setTypeUuid(String typeUuid) {
            this.typeUuid = typeUuid;
            return this;
        }
        public String getTypeUuid() {
            return this.typeUuid;
        }

        public RegisterAndActivateDeviceBatchResponseBodyFailItemsResult setUserIds(java.util.List<String> userIds) {
            this.userIds = userIds;
            return this;
        }
        public java.util.List<String> getUserIds() {
            return this.userIds;
        }

        public RegisterAndActivateDeviceBatchResponseBodyFailItemsResult setUuid(String uuid) {
            this.uuid = uuid;
            return this;
        }
        public String getUuid() {
            return this.uuid;
        }

    }

    public static class RegisterAndActivateDeviceBatchResponseBodyFailItems extends TeaModel {
        @NameInMap("errorCode")
        public String errorCode;

        @NameInMap("errorMsg")
        public String errorMsg;

        @NameInMap("result")
        public RegisterAndActivateDeviceBatchResponseBodyFailItemsResult result;

        @NameInMap("success")
        public Boolean success;

        public static RegisterAndActivateDeviceBatchResponseBodyFailItems build(java.util.Map<String, ?> map) throws Exception {
            RegisterAndActivateDeviceBatchResponseBodyFailItems self = new RegisterAndActivateDeviceBatchResponseBodyFailItems();
            return TeaModel.build(map, self);
        }

        public RegisterAndActivateDeviceBatchResponseBodyFailItems setErrorCode(String errorCode) {
            this.errorCode = errorCode;
            return this;
        }
        public String getErrorCode() {
            return this.errorCode;
        }

        public RegisterAndActivateDeviceBatchResponseBodyFailItems setErrorMsg(String errorMsg) {
            this.errorMsg = errorMsg;
            return this;
        }
        public String getErrorMsg() {
            return this.errorMsg;
        }

        public RegisterAndActivateDeviceBatchResponseBodyFailItems setResult(RegisterAndActivateDeviceBatchResponseBodyFailItemsResult result) {
            this.result = result;
            return this;
        }
        public RegisterAndActivateDeviceBatchResponseBodyFailItemsResult getResult() {
            return this.result;
        }

        public RegisterAndActivateDeviceBatchResponseBodyFailItems setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

    }

    public static class RegisterAndActivateDeviceBatchResponseBodySuccessItemsResult extends TeaModel {
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

        @NameInMap("icon")
        public String icon;

        @NameInMap("introduction")
        public String introduction;

        @NameInMap("roleUuid")
        public String roleUuid;

        @NameInMap("status")
        public Long status;

        @NameInMap("typeUuid")
        public String typeUuid;

        @NameInMap("userIds")
        public java.util.List<String> userIds;

        @NameInMap("uuid")
        public String uuid;

        public static RegisterAndActivateDeviceBatchResponseBodySuccessItemsResult build(java.util.Map<String, ?> map) throws Exception {
            RegisterAndActivateDeviceBatchResponseBodySuccessItemsResult self = new RegisterAndActivateDeviceBatchResponseBodySuccessItemsResult();
            return TeaModel.build(map, self);
        }

        public RegisterAndActivateDeviceBatchResponseBodySuccessItemsResult setDeviceCallbackUrl(String deviceCallbackUrl) {
            this.deviceCallbackUrl = deviceCallbackUrl;
            return this;
        }
        public String getDeviceCallbackUrl() {
            return this.deviceCallbackUrl;
        }

        public RegisterAndActivateDeviceBatchResponseBodySuccessItemsResult setDeviceCategory(Integer deviceCategory) {
            this.deviceCategory = deviceCategory;
            return this;
        }
        public Integer getDeviceCategory() {
            return this.deviceCategory;
        }

        public RegisterAndActivateDeviceBatchResponseBodySuccessItemsResult setDeviceCode(String deviceCode) {
            this.deviceCode = deviceCode;
            return this;
        }
        public String getDeviceCode() {
            return this.deviceCode;
        }

        public RegisterAndActivateDeviceBatchResponseBodySuccessItemsResult setDeviceDetailUrl(String deviceDetailUrl) {
            this.deviceDetailUrl = deviceDetailUrl;
            return this;
        }
        public String getDeviceDetailUrl() {
            return this.deviceDetailUrl;
        }

        public RegisterAndActivateDeviceBatchResponseBodySuccessItemsResult setDeviceName(String deviceName) {
            this.deviceName = deviceName;
            return this;
        }
        public String getDeviceName() {
            return this.deviceName;
        }

        public RegisterAndActivateDeviceBatchResponseBodySuccessItemsResult setGroupUuid(String groupUuid) {
            this.groupUuid = groupUuid;
            return this;
        }
        public String getGroupUuid() {
            return this.groupUuid;
        }

        public RegisterAndActivateDeviceBatchResponseBodySuccessItemsResult setIcon(String icon) {
            this.icon = icon;
            return this;
        }
        public String getIcon() {
            return this.icon;
        }

        public RegisterAndActivateDeviceBatchResponseBodySuccessItemsResult setIntroduction(String introduction) {
            this.introduction = introduction;
            return this;
        }
        public String getIntroduction() {
            return this.introduction;
        }

        public RegisterAndActivateDeviceBatchResponseBodySuccessItemsResult setRoleUuid(String roleUuid) {
            this.roleUuid = roleUuid;
            return this;
        }
        public String getRoleUuid() {
            return this.roleUuid;
        }

        public RegisterAndActivateDeviceBatchResponseBodySuccessItemsResult setStatus(Long status) {
            this.status = status;
            return this;
        }
        public Long getStatus() {
            return this.status;
        }

        public RegisterAndActivateDeviceBatchResponseBodySuccessItemsResult setTypeUuid(String typeUuid) {
            this.typeUuid = typeUuid;
            return this;
        }
        public String getTypeUuid() {
            return this.typeUuid;
        }

        public RegisterAndActivateDeviceBatchResponseBodySuccessItemsResult setUserIds(java.util.List<String> userIds) {
            this.userIds = userIds;
            return this;
        }
        public java.util.List<String> getUserIds() {
            return this.userIds;
        }

        public RegisterAndActivateDeviceBatchResponseBodySuccessItemsResult setUuid(String uuid) {
            this.uuid = uuid;
            return this;
        }
        public String getUuid() {
            return this.uuid;
        }

    }

    public static class RegisterAndActivateDeviceBatchResponseBodySuccessItems extends TeaModel {
        @NameInMap("errorCode")
        public String errorCode;

        @NameInMap("errorMsg")
        public String errorMsg;

        @NameInMap("result")
        public RegisterAndActivateDeviceBatchResponseBodySuccessItemsResult result;

        @NameInMap("success")
        public Boolean success;

        public static RegisterAndActivateDeviceBatchResponseBodySuccessItems build(java.util.Map<String, ?> map) throws Exception {
            RegisterAndActivateDeviceBatchResponseBodySuccessItems self = new RegisterAndActivateDeviceBatchResponseBodySuccessItems();
            return TeaModel.build(map, self);
        }

        public RegisterAndActivateDeviceBatchResponseBodySuccessItems setErrorCode(String errorCode) {
            this.errorCode = errorCode;
            return this;
        }
        public String getErrorCode() {
            return this.errorCode;
        }

        public RegisterAndActivateDeviceBatchResponseBodySuccessItems setErrorMsg(String errorMsg) {
            this.errorMsg = errorMsg;
            return this;
        }
        public String getErrorMsg() {
            return this.errorMsg;
        }

        public RegisterAndActivateDeviceBatchResponseBodySuccessItems setResult(RegisterAndActivateDeviceBatchResponseBodySuccessItemsResult result) {
            this.result = result;
            return this;
        }
        public RegisterAndActivateDeviceBatchResponseBodySuccessItemsResult getResult() {
            return this.result;
        }

        public RegisterAndActivateDeviceBatchResponseBodySuccessItems setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

    }

}
