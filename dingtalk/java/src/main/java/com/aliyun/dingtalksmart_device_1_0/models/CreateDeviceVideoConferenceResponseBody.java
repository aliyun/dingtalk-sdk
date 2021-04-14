// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksmart_device_1_0.models;

import com.aliyun.tea.*;

public class CreateDeviceVideoConferenceResponseBody extends TeaModel {
    // 会议id
    @NameInMap("conferenceId")
    public String conferenceId;

    // 入会口令
    @NameInMap("code")
    public String code;

    public static CreateDeviceVideoConferenceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateDeviceVideoConferenceResponseBody self = new CreateDeviceVideoConferenceResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateDeviceVideoConferenceResponseBody setConferenceId(String conferenceId) {
        this.conferenceId = conferenceId;
        return this;
    }
    public String getConferenceId() {
        return this.conferenceId;
    }

    public CreateDeviceVideoConferenceResponseBody setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

}
