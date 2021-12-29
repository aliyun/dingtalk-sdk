// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class RegisterAndActivateDeviceRequest extends TeaModel {
    @NameInMap("deviceCode")
    public String deviceCode;

    @NameInMap("deviceName")
    public String deviceName;

    @NameInMap("introduction")
    public String introduction;

    @NameInMap("typeUuid")
    public String typeUuid;

    @NameInMap("dingCorpId")
    public String dingCorpId;

    @NameInMap("userIds")
    public java.util.List<String> userIds;

    @NameInMap("roleUuid")
    public String roleUuid;

    @NameInMap("deviceDetailUrl")
    public String deviceDetailUrl;

    @NameInMap("deviceCallbackUrl")
    public String deviceCallbackUrl;

    public static RegisterAndActivateDeviceRequest build(java.util.Map<String, ?> map) throws Exception {
        RegisterAndActivateDeviceRequest self = new RegisterAndActivateDeviceRequest();
        return TeaModel.build(map, self);
    }

    public RegisterAndActivateDeviceRequest setDeviceCode(String deviceCode) {
        this.deviceCode = deviceCode;
        return this;
    }
    public String getDeviceCode() {
        return this.deviceCode;
    }

    public RegisterAndActivateDeviceRequest setDeviceName(String deviceName) {
        this.deviceName = deviceName;
        return this;
    }
    public String getDeviceName() {
        return this.deviceName;
    }

    public RegisterAndActivateDeviceRequest setIntroduction(String introduction) {
        this.introduction = introduction;
        return this;
    }
    public String getIntroduction() {
        return this.introduction;
    }

    public RegisterAndActivateDeviceRequest setTypeUuid(String typeUuid) {
        this.typeUuid = typeUuid;
        return this;
    }
    public String getTypeUuid() {
        return this.typeUuid;
    }

    public RegisterAndActivateDeviceRequest setDingCorpId(String dingCorpId) {
        this.dingCorpId = dingCorpId;
        return this;
    }
    public String getDingCorpId() {
        return this.dingCorpId;
    }

    public RegisterAndActivateDeviceRequest setUserIds(java.util.List<String> userIds) {
        this.userIds = userIds;
        return this;
    }
    public java.util.List<String> getUserIds() {
        return this.userIds;
    }

    public RegisterAndActivateDeviceRequest setRoleUuid(String roleUuid) {
        this.roleUuid = roleUuid;
        return this;
    }
    public String getRoleUuid() {
        return this.roleUuid;
    }

    public RegisterAndActivateDeviceRequest setDeviceDetailUrl(String deviceDetailUrl) {
        this.deviceDetailUrl = deviceDetailUrl;
        return this;
    }
    public String getDeviceDetailUrl() {
        return this.deviceDetailUrl;
    }

    public RegisterAndActivateDeviceRequest setDeviceCallbackUrl(String deviceCallbackUrl) {
        this.deviceCallbackUrl = deviceCallbackUrl;
        return this;
    }
    public String getDeviceCallbackUrl() {
        return this.deviceCallbackUrl;
    }

}
