// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class ListSubCorpsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListSubCorpsResponseBody body;

    public static ListSubCorpsResponse build(java.util.Map<String, ?> map) throws Exception {
        ListSubCorpsResponse self = new ListSubCorpsResponse();
        return TeaModel.build(map, self);
    }

    public ListSubCorpsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListSubCorpsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListSubCorpsResponse setBody(ListSubCorpsResponseBody body) {
        this.body = body;
        return this;
    }
    public ListSubCorpsResponseBody getBody() {
        return this.body;
    }

}
