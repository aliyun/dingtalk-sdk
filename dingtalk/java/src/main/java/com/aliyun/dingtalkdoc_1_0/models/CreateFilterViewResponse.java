// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class CreateFilterViewResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateFilterViewResponseBody body;

    public static CreateFilterViewResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateFilterViewResponse self = new CreateFilterViewResponse();
        return TeaModel.build(map, self);
    }

    public CreateFilterViewResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateFilterViewResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateFilterViewResponse setBody(CreateFilterViewResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateFilterViewResponseBody getBody() {
        return this.body;
    }

}
