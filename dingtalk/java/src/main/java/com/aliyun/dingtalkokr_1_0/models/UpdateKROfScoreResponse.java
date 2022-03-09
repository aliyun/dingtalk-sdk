// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class UpdateKROfScoreResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateKROfScoreResponseBody body;

    public static UpdateKROfScoreResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateKROfScoreResponse self = new UpdateKROfScoreResponse();
        return TeaModel.build(map, self);
    }

    public UpdateKROfScoreResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateKROfScoreResponse setBody(UpdateKROfScoreResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateKROfScoreResponseBody getBody() {
        return this.body;
    }

}
