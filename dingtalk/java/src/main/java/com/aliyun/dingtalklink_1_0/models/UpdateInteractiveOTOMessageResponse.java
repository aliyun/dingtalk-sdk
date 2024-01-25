// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklink_1_0.models;

import com.aliyun.tea.*;

public class UpdateInteractiveOTOMessageResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateInteractiveOTOMessageResponseBody body;

    public static UpdateInteractiveOTOMessageResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateInteractiveOTOMessageResponse self = new UpdateInteractiveOTOMessageResponse();
        return TeaModel.build(map, self);
    }

    public UpdateInteractiveOTOMessageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateInteractiveOTOMessageResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateInteractiveOTOMessageResponse setBody(UpdateInteractiveOTOMessageResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateInteractiveOTOMessageResponseBody getBody() {
        return this.body;
    }

}
