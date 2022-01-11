// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class StopStreamOutResponseBody extends TeaModel {
    // 会议密码
    @NameInMap("cause")
    public String cause;

    // conferenceId
    @NameInMap("code")
    public String code;

    public static StopStreamOutResponseBody build(java.util.Map<String, ?> map) throws Exception {
        StopStreamOutResponseBody self = new StopStreamOutResponseBody();
        return TeaModel.build(map, self);
    }

    public StopStreamOutResponseBody setCause(String cause) {
        this.cause = cause;
        return this;
    }
    public String getCause() {
        return this.cause;
    }

    public StopStreamOutResponseBody setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

}
