// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class ListEventsInstancesResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ListEventsInstancesResponseBody body;

    public static ListEventsInstancesResponse build(java.util.Map<String, ?> map) throws Exception {
        ListEventsInstancesResponse self = new ListEventsInstancesResponse();
        return TeaModel.build(map, self);
    }

    public ListEventsInstancesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListEventsInstancesResponse setBody(ListEventsInstancesResponseBody body) {
        this.body = body;
        return this;
    }
    public ListEventsInstancesResponseBody getBody() {
        return this.body;
    }

}
