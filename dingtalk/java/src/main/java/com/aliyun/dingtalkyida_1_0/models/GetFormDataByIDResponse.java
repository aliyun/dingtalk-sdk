// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetFormDataByIDResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetFormDataByIDResponseBody body;

    public static GetFormDataByIDResponse build(java.util.Map<String, ?> map) throws Exception {
        GetFormDataByIDResponse self = new GetFormDataByIDResponse();
        return TeaModel.build(map, self);
    }

    public GetFormDataByIDResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetFormDataByIDResponse setBody(GetFormDataByIDResponseBody body) {
        this.body = body;
        return this;
    }
    public GetFormDataByIDResponseBody getBody() {
        return this.body;
    }

}
