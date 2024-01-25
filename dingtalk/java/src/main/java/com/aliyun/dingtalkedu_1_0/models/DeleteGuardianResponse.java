// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class DeleteGuardianResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DeleteGuardianResponseBody body;

    public static DeleteGuardianResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteGuardianResponse self = new DeleteGuardianResponse();
        return TeaModel.build(map, self);
    }

    public DeleteGuardianResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteGuardianResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeleteGuardianResponse setBody(DeleteGuardianResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteGuardianResponseBody getBody() {
        return this.body;
    }

}
