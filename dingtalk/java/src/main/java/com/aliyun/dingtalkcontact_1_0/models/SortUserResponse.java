// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class SortUserResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public SortUserResponseBody body;

    public static SortUserResponse build(java.util.Map<String, ?> map) throws Exception {
        SortUserResponse self = new SortUserResponse();
        return TeaModel.build(map, self);
    }

    public SortUserResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SortUserResponse setBody(SortUserResponseBody body) {
        this.body = body;
        return this;
    }
    public SortUserResponseBody getBody() {
        return this.body;
    }

}
