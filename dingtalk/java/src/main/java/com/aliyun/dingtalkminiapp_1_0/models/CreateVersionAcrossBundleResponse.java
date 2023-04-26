// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminiapp_1_0.models;

import com.aliyun.tea.*;

public class CreateVersionAcrossBundleResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public CreateVersionAcrossBundleResponseBody body;

    public static CreateVersionAcrossBundleResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateVersionAcrossBundleResponse self = new CreateVersionAcrossBundleResponse();
        return TeaModel.build(map, self);
    }

    public CreateVersionAcrossBundleResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateVersionAcrossBundleResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateVersionAcrossBundleResponse setBody(CreateVersionAcrossBundleResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateVersionAcrossBundleResponseBody getBody() {
        return this.body;
    }

}
