// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdiot_1_0.models;

import com.aliyun.tea.*;

public class DeviceConferenceResponseBody extends TeaModel {
    @NameInMap("conferenceId")
    public String conferenceId;

    public static DeviceConferenceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeviceConferenceResponseBody self = new DeviceConferenceResponseBody();
        return TeaModel.build(map, self);
    }

    public DeviceConferenceResponseBody setConferenceId(String conferenceId) {
        this.conferenceId = conferenceId;
        return this;
    }
    public String getConferenceId() {
        return this.conferenceId;
    }

}
