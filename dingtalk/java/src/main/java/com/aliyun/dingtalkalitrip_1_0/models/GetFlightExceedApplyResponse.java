// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalitrip_1_0.models;

import com.aliyun.tea.*;

public class GetFlightExceedApplyResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetFlightExceedApplyResponseBody body;

    public static GetFlightExceedApplyResponse build(java.util.Map<String, ?> map) throws Exception {
        GetFlightExceedApplyResponse self = new GetFlightExceedApplyResponse();
        return TeaModel.build(map, self);
    }

    public GetFlightExceedApplyResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetFlightExceedApplyResponse setBody(GetFlightExceedApplyResponseBody body) {
        this.body = body;
        return this;
    }
    public GetFlightExceedApplyResponseBody getBody() {
        return this.body;
    }

}
