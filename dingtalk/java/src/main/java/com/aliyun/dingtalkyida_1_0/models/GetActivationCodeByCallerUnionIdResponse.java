// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetActivationCodeByCallerUnionIdResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetActivationCodeByCallerUnionIdResponseBody body;

    public static GetActivationCodeByCallerUnionIdResponse build(java.util.Map<String, ?> map) throws Exception {
        GetActivationCodeByCallerUnionIdResponse self = new GetActivationCodeByCallerUnionIdResponse();
        return TeaModel.build(map, self);
    }

    public GetActivationCodeByCallerUnionIdResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetActivationCodeByCallerUnionIdResponse setBody(GetActivationCodeByCallerUnionIdResponseBody body) {
        this.body = body;
        return this;
    }
    public GetActivationCodeByCallerUnionIdResponseBody getBody() {
        return this.body;
    }

}
