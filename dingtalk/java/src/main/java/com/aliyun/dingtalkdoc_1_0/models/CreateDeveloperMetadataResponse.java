// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class CreateDeveloperMetadataResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CreateDeveloperMetadataResponseBody body;

    public static CreateDeveloperMetadataResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateDeveloperMetadataResponse self = new CreateDeveloperMetadataResponse();
        return TeaModel.build(map, self);
    }

    public CreateDeveloperMetadataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateDeveloperMetadataResponse setBody(CreateDeveloperMetadataResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateDeveloperMetadataResponseBody getBody() {
        return this.body;
    }

}
