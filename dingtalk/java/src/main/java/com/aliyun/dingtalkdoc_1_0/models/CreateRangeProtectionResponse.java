// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class CreateRangeProtectionResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public CreateRangeProtectionResponseBody body;

    public static CreateRangeProtectionResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateRangeProtectionResponse self = new CreateRangeProtectionResponse();
        return TeaModel.build(map, self);
    }

    public CreateRangeProtectionResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateRangeProtectionResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateRangeProtectionResponse setBody(CreateRangeProtectionResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateRangeProtectionResponseBody getBody() {
        return this.body;
    }

}
