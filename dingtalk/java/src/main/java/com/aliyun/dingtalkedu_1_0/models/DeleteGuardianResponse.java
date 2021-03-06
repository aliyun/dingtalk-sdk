// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class DeleteGuardianResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public DeleteGuardianResponse setBody(DeleteGuardianResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteGuardianResponseBody getBody() {
        return this.body;
    }

}
