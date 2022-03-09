// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class UpdateKROfContentResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateKROfContentResponseBody body;

    public static UpdateKROfContentResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateKROfContentResponse self = new UpdateKROfContentResponse();
        return TeaModel.build(map, self);
    }

    public UpdateKROfContentResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateKROfContentResponse setBody(UpdateKROfContentResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateKROfContentResponseBody getBody() {
        return this.body;
    }

}
