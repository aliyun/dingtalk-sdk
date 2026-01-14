// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class ListAppByClientIdResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListAppByClientIdResponseBody body;

    public static ListAppByClientIdResponse build(java.util.Map<String, ?> map) throws Exception {
        ListAppByClientIdResponse self = new ListAppByClientIdResponse();
        return TeaModel.build(map, self);
    }

    public ListAppByClientIdResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListAppByClientIdResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListAppByClientIdResponse setBody(ListAppByClientIdResponseBody body) {
        this.body = body;
        return this;
    }
    public ListAppByClientIdResponseBody getBody() {
        return this.body;
    }

}
