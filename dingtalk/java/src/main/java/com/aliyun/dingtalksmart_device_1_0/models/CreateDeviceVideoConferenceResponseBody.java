// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksmart_device_1_0.models;

import com.aliyun.tea.*;

public class CreateDeviceVideoConferenceResponseBody extends TeaModel {
    @NameInMap("code")
    public String code;

    @NameInMap("conferenceId")
    public String conferenceId;

    public static CreateDeviceVideoConferenceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateDeviceVideoConferenceResponseBody self = new CreateDeviceVideoConferenceResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateDeviceVideoConferenceResponseBody setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

    public CreateDeviceVideoConferenceResponseBody setConferenceId(String conferenceId) {
        this.conferenceId = conferenceId;
        return this;
    }
    public String getConferenceId() {
        return this.conferenceId;
    }

}
