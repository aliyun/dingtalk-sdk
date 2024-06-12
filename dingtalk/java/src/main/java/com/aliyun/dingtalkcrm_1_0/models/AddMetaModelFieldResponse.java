// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class AddMetaModelFieldResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AddMetaModelFieldResponseBody body;

    public static AddMetaModelFieldResponse build(java.util.Map<String, ?> map) throws Exception {
        AddMetaModelFieldResponse self = new AddMetaModelFieldResponse();
        return TeaModel.build(map, self);
    }

    public AddMetaModelFieldResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AddMetaModelFieldResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AddMetaModelFieldResponse setBody(AddMetaModelFieldResponseBody body) {
        this.body = body;
        return this;
    }
    public AddMetaModelFieldResponseBody getBody() {
        return this.body;
    }

}
