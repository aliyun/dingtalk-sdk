// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class CreateShortcutResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateShortcutResponseBody body;

    public static CreateShortcutResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateShortcutResponse self = new CreateShortcutResponse();
        return TeaModel.build(map, self);
    }

    public CreateShortcutResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateShortcutResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateShortcutResponse setBody(CreateShortcutResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateShortcutResponseBody getBody() {
        return this.body;
    }

}
