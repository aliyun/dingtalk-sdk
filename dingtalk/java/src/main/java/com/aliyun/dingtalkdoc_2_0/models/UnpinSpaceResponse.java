// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class UnpinSpaceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UnpinSpaceResponseBody body;

    public static UnpinSpaceResponse build(java.util.Map<String, ?> map) throws Exception {
        UnpinSpaceResponse self = new UnpinSpaceResponse();
        return TeaModel.build(map, self);
    }

    public UnpinSpaceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UnpinSpaceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UnpinSpaceResponse setBody(UnpinSpaceResponseBody body) {
        this.body = body;
        return this;
    }
    public UnpinSpaceResponseBody getBody() {
        return this.body;
    }

}
