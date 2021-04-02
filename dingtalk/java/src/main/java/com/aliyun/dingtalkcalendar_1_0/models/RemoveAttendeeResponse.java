// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class RemoveAttendeeResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    public static RemoveAttendeeResponse build(java.util.Map<String, ?> map) throws Exception {
        RemoveAttendeeResponse self = new RemoveAttendeeResponse();
        return TeaModel.build(map, self);
    }

    public RemoveAttendeeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

}
