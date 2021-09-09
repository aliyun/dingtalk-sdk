// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class ListReceiversResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ListReceiversResponseBody body;

    public static ListReceiversResponse build(java.util.Map<String, ?> map) throws Exception {
        ListReceiversResponse self = new ListReceiversResponse();
        return TeaModel.build(map, self);
    }

    public ListReceiversResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListReceiversResponse setBody(ListReceiversResponseBody body) {
        this.body = body;
        return this;
    }
    public ListReceiversResponseBody getBody() {
        return this.body;
    }

}
