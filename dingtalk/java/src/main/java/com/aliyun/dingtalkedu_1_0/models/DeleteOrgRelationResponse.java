// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class DeleteOrgRelationResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public DeleteOrgRelationResponseBody body;

    public static DeleteOrgRelationResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteOrgRelationResponse self = new DeleteOrgRelationResponse();
        return TeaModel.build(map, self);
    }

    public DeleteOrgRelationResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteOrgRelationResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeleteOrgRelationResponse setBody(DeleteOrgRelationResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteOrgRelationResponseBody getBody() {
        return this.body;
    }

}
