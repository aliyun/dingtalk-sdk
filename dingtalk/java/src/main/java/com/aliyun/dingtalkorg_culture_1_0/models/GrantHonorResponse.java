// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkorg_culture_1_0.models;

import com.aliyun.tea.*;

public class GrantHonorResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GrantHonorResponseBody body;

    public static GrantHonorResponse build(java.util.Map<String, ?> map) throws Exception {
        GrantHonorResponse self = new GrantHonorResponse();
        return TeaModel.build(map, self);
    }

    public GrantHonorResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GrantHonorResponse setBody(GrantHonorResponseBody body) {
        this.body = body;
        return this;
    }
    public GrantHonorResponseBody getBody() {
        return this.body;
    }

}
