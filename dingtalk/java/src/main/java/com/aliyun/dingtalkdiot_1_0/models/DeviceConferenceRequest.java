// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdiot_1_0.models;

import com.aliyun.tea.*;

public class DeviceConferenceRequest extends TeaModel {
    // 会议主题，最多不能超20个中文。
    @NameInMap("confTitle")
    public String confTitle;

    // 钉钉会议ID，加入已存在的会议必填。
    @NameInMap("conferenceId")
    public String conferenceId;

    // 钉钉会议密码，加入已存在的会议必填。
    @NameInMap("conferencePassword")
    public String conferencePassword;

    // 需要邀请的设备ID，最多5个。
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
