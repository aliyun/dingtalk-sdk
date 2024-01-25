// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class UpdateRelationMetaFieldResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateRelationMetaFieldResponseBody body;

    public static UpdateRelationMetaFieldResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateRelationMetaFieldResponse self = new UpdateRelationMetaFieldResponse();
        return TeaModel.build(map, self);
    }

    public UpdateRelationMetaFieldResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateRelationMetaFieldResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateRelationMetaFieldResponse setBody(UpdateRelationMetaFieldResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateRelationMetaFieldResponseBody getBody() {
        return this.body;
    }

}
