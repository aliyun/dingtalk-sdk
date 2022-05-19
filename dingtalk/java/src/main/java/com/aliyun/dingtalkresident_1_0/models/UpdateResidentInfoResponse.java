// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class UpdateResidentInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateResidentInfoResponseBody body;

    public static UpdateResidentInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateResidentInfoResponse self = new UpdateResidentInfoResponse();
        return TeaModel.build(map, self);
    }

    public UpdateResidentInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateResidentInfoResponse setBody(UpdateResidentInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateResidentInfoResponseBody getBody() {
        return this.body;
    }

}
