// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdiot_1_0.models;

import com.aliyun.tea.*;

public class DeviceConferenceRequest extends TeaModel {
    @NameInMap("confTitle")
    public String confTitle;

    @NameInMap("conferenceId")
    public String conferenceId;

    @NameInMap("conferencePassword")
    public String conferencePassword;

    @NameInMap("deviceIds")
    public java.util.List<String> deviceIds;

    public static DeviceConferenceRequest build(java.util.Map<String, ?> map) throws Exception {
        DeviceConferenceRequest self = new DeviceConferenceRequest();
        return TeaModel.build(map, self);
    }

    public DeviceConferenceRequest setConfTitle(String confTitle) {
        this.confTitle = confTitle;
        return this;
    }
    public String getConfTitle() {
        return this.confTitle;
    }

    public DeviceConferenceRequest setConferenceId(String conferenceId) {
        this.conferenceId = conferenceId;
        return this;
    }
    public String getConferenceId() {
        return this.conferenceId;
    }

    public DeviceConferenceRequest setConferencePassword(String conferencePassword) {
        this.conferencePassword = conferencePassword;
        return this;
    }
    public String getConferencePassword() {
        return this.conferencePassword;
    }

    public DeviceConferenceRequest setDeviceIds(java.util.List<String> deviceIds) {
        this.deviceIds = deviceIds;
        return this;
    }
    public java.util.List<String> getDeviceIds() {
        return this.deviceIds;
    }

}
