// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class AddRelationMetaFieldResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AddRelationMetaFieldResponseBody body;

    public static AddRelationMetaFieldResponse build(java.util.Map<String, ?> map) throws Exception {
        AddRelationMetaFieldResponse self = new AddRelationMetaFieldResponse();
        return TeaModel.build(map, self);
    }

    public AddRelationMetaFieldResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AddRelationMetaFieldResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AddRelationMetaFieldResponse setBody(AddRelationMetaFieldResponseBody body) {
        this.body = body;
        return this;
    }
    public AddRelationMetaFieldResponseBody getBody() {
        return this.body;
    }

}
