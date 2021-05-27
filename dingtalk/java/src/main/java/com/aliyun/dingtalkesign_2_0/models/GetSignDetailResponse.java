// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_2_0.models;

import com.aliyun.tea.*;

public class GetSignDetailResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetSignDetailResponseBody body;

    public static GetSignDetailResponse build(java.util.Map<String, ?> map) throws Exception {
        GetSignDetailResponse self = new GetSignDetailResponse();
        return TeaModel.build(map, self);
    }

    public GetSignDetailResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetSignDetailResponse setBody(GetSignDetailResponseBody body) {
        this.body = body;
        return this;
    }
    public GetSignDetailResponseBody getBody() {
        return this.body;
    }

}
