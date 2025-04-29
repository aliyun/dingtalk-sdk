// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class UpdateGuardianResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateGuardianResponseBody body;

    public static UpdateGuardianResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateGuardianResponse self = new UpdateGuardianResponse();
        return TeaModel.build(map, self);
    }

    public UpdateGuardianResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateGuardianResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateGuardianResponse setBody(UpdateGuardianResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateGuardianResponseBody getBody() {
        return this.body;
    }

}
