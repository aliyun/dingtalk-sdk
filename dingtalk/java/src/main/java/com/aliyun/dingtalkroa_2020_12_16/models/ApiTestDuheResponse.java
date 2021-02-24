// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkroa_2020_12_16.models;

import com.aliyun.tea.*;

public class ApiTestDuheResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ApiTestDuheResponseBody body;

    public static ApiTestDuheResponse build(java.util.Map<String, ?> map) throws Exception {
        ApiTestDuheResponse self = new ApiTestDuheResponse();
        return TeaModel.build(map, self);
    }

    public ApiTestDuheResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ApiTestDuheResponse setBody(ApiTestDuheResponseBody body) {
        this.body = body;
        return this;
    }
    public ApiTestDuheResponseBody getBody() {
        return this.body;
    }

}
