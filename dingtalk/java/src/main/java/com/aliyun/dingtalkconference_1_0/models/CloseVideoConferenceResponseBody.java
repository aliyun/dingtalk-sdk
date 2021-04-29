// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class CloseVideoConferenceResponseBody extends TeaModel {
    @NameInMap("code")
    public Long code;

    @NameInMap("cause")
    public String cause;

    public static CloseVideoConferenceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CloseVideoConferenceResponseBody self = new CloseVideoConferenceResponseBody();
        return TeaModel.build(map, self);
    }

    public CloseVideoConferenceResponseBody setCode(Long code) {
        this.code = code;
        return this;
    }
    public Long getCode() {
        return this.code;
    }

    public CloseVideoConferenceResponseBody setCause(String cause) {
        this.cause = cause;
        return this;
    }
    public String getCause() {
        return this.cause;
    }

}
