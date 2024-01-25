// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class ListSubSpaceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListSubSpaceResponseBody body;

    public static ListSubSpaceResponse build(java.util.Map<String, ?> map) throws Exception {
        ListSubSpaceResponse self = new ListSubSpaceResponse();
        return TeaModel.build(map, self);
    }

    public ListSubSpaceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListSubSpaceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListSubSpaceResponse setBody(ListSubSpaceResponseBody body) {
        this.body = body;
        return this;
    }
    public ListSubSpaceResponseBody getBody() {
        return this.body;
    }

}
