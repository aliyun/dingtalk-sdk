// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateSectionConfigResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateSectionConfigResponseBody body;

    public static CreateSectionConfigResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateSectionConfigResponse self = new CreateSectionConfigResponse();
        return TeaModel.build(map, self);
    }

    public CreateSectionConfigResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateSectionConfigResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateSectionConfigResponse setBody(CreateSectionConfigResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateSectionConfigResponseBody getBody() {
        return this.body;
    }

}
