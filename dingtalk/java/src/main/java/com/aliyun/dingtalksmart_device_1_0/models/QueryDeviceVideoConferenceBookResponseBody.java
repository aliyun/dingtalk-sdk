// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksmart_device_1_0.models;

import com.aliyun.tea.*;

public class QueryDeviceVideoConferenceBookResponseBody extends TeaModel {
    // 入会口令
    @NameInMap("code")
    public String code;

    // 会议id
    @NameInMap("conferenceId")
    public String conferenceId;

    public static QueryDeviceVideoConferenceBookResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryDeviceVideoConferenceBookResponseBody self = new QueryDeviceVideoConferenceBookResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryDeviceVideoConferenceBookResponseBody setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

    public QueryDeviceVideoConferenceBookResponseBody setConferenceId(String conferenceId) {
        this.conferenceId = conferenceId;
        return this;
    }
    public String getConferenceId() {
        return this.conferenceId;
    }

}
