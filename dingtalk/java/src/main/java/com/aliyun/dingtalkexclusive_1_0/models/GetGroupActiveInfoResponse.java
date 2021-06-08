// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetGroupActiveInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetGroupActiveInfoResponseBody body;

    public static GetGroupActiveInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        GetGroupActiveInfoResponse self = new GetGroupActiveInfoResponse();
        return TeaModel.build(map, self);
    }

    public GetGroupActiveInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetGroupActiveInfoResponse setBody(GetGroupActiveInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public GetGroupActiveInfoResponseBody getBody() {
        return this.body;
    }

}
