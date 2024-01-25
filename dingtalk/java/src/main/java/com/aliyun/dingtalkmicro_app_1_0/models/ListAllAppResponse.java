// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class ListAllAppResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListAllAppResponseBody body;

    public static ListAllAppResponse build(java.util.Map<String, ?> map) throws Exception {
        ListAllAppResponse self = new ListAllAppResponse();
        return TeaModel.build(map, self);
    }

    public ListAllAppResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListAllAppResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListAllAppResponse setBody(ListAllAppResponseBody body) {
        this.body = body;
        return this;
    }
    public ListAllAppResponseBody getBody() {
        return this.body;
    }

}
