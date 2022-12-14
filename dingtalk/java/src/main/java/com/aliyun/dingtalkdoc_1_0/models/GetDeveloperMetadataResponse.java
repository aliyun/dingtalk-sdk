// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class GetDeveloperMetadataResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetDeveloperMetadataResponseBody body;

    public static GetDeveloperMetadataResponse build(java.util.Map<String, ?> map) throws Exception {
        GetDeveloperMetadataResponse self = new GetDeveloperMetadataResponse();
        return TeaModel.build(map, self);
    }

    public GetDeveloperMetadataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetDeveloperMetadataResponse setBody(GetDeveloperMetadataResponseBody body) {
        this.body = body;
        return this;
    }
    public GetDeveloperMetadataResponseBody getBody() {
        return this.body;
    }

}
