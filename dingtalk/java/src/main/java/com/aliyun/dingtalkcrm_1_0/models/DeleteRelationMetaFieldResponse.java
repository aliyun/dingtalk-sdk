// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class DeleteRelationMetaFieldResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public DeleteRelationMetaFieldResponseBody body;

    public static DeleteRelationMetaFieldResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteRelationMetaFieldResponse self = new DeleteRelationMetaFieldResponse();
        return TeaModel.build(map, self);
    }

    public DeleteRelationMetaFieldResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteRelationMetaFieldResponse setBody(DeleteRelationMetaFieldResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteRelationMetaFieldResponseBody getBody() {
        return this.body;
    }

}
