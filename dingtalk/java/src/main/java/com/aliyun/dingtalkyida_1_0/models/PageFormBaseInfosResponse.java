// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class PageFormBaseInfosResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public PageFormBaseInfosResponseBody body;

    public static PageFormBaseInfosResponse build(java.util.Map<String, ?> map) throws Exception {
        PageFormBaseInfosResponse self = new PageFormBaseInfosResponse();
        return TeaModel.build(map, self);
    }

    public PageFormBaseInfosResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PageFormBaseInfosResponse setBody(PageFormBaseInfosResponseBody body) {
        this.body = body;
        return this;
    }
    public PageFormBaseInfosResponseBody getBody() {
        return this.body;
    }

}
