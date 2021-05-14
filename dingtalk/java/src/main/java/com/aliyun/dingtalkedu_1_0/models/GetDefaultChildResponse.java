// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class GetDefaultChildResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetDefaultChildResponseBody body;

    public static GetDefaultChildResponse build(java.util.Map<String, ?> map) throws Exception {
        GetDefaultChildResponse self = new GetDefaultChildResponse();
        return TeaModel.build(map, self);
    }

    public GetDefaultChildResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetDefaultChildResponse setBody(GetDefaultChildResponseBody body) {
        this.body = body;
        return this;
    }
    public GetDefaultChildResponseBody getBody() {
        return this.body;
    }

}
