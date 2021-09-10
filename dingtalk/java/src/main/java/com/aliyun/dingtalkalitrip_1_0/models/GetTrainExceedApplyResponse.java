// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalitrip_1_0.models;

import com.aliyun.tea.*;

public class GetTrainExceedApplyResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetTrainExceedApplyResponseBody body;

    public static GetTrainExceedApplyResponse build(java.util.Map<String, ?> map) throws Exception {
        GetTrainExceedApplyResponse self = new GetTrainExceedApplyResponse();
        return TeaModel.build(map, self);
    }

    public GetTrainExceedApplyResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetTrainExceedApplyResponse setBody(GetTrainExceedApplyResponseBody body) {
        this.body = body;
        return this;
    }
    public GetTrainExceedApplyResponseBody getBody() {
        return this.body;
    }

}
