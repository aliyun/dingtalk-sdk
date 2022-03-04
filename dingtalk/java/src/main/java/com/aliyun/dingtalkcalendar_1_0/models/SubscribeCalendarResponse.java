// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class SubscribeCalendarResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    public static SubscribeCalendarResponse build(java.util.Map<String, ?> map) throws Exception {
        SubscribeCalendarResponse self = new SubscribeCalendarResponse();
        return TeaModel.build(map, self);
    }

    public SubscribeCalendarResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

}
