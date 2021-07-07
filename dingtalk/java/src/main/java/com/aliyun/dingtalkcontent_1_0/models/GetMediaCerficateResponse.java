// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontent_1_0.models;

import com.aliyun.tea.*;

public class GetMediaCerficateResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetMediaCerficateResponseBody body;

    public static GetMediaCerficateResponse build(java.util.Map<String, ?> map) throws Exception {
        GetMediaCerficateResponse self = new GetMediaCerficateResponse();
        return TeaModel.build(map, self);
    }

    public GetMediaCerficateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetMediaCerficateResponse setBody(GetMediaCerficateResponseBody body) {
        this.body = body;
        return this;
    }
    public GetMediaCerficateResponseBody getBody() {
        return this.body;
    }

}
