// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class CreateRelationMetaResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CreateRelationMetaResponseBody body;

    public static CreateRelationMetaResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateRelationMetaResponse self = new CreateRelationMetaResponse();
        return TeaModel.build(map, self);
    }

    public CreateRelationMetaResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateRelationMetaResponse setBody(CreateRelationMetaResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateRelationMetaResponseBody getBody() {
        return this.body;
    }

}
