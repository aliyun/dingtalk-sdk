// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class GetInnerAppResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetInnerAppResponseBody body;

    public static GetInnerAppResponse build(java.util.Map<String, ?> map) throws Exception {
        GetInnerAppResponse self = new GetInnerAppResponse();
        return TeaModel.build(map, self);
    }

    public GetInnerAppResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetInnerAppResponse setBody(GetInnerAppResponseBody body) {
        this.body = body;
        return this;
    }
    public GetInnerAppResponseBody getBody() {
        return this.body;
    }

}
