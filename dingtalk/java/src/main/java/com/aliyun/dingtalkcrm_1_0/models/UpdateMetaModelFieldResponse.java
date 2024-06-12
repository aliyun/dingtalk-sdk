// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class UpdateMetaModelFieldResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateMetaModelFieldResponseBody body;

    public static UpdateMetaModelFieldResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateMetaModelFieldResponse self = new UpdateMetaModelFieldResponse();
        return TeaModel.build(map, self);
    }

    public UpdateMetaModelFieldResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateMetaModelFieldResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateMetaModelFieldResponse setBody(UpdateMetaModelFieldResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateMetaModelFieldResponseBody getBody() {
        return this.body;
    }

}
