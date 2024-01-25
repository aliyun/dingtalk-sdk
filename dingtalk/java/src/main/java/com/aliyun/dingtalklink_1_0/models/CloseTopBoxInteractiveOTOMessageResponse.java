// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklink_1_0.models;

import com.aliyun.tea.*;

public class CloseTopBoxInteractiveOTOMessageResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CloseTopBoxInteractiveOTOMessageResponseBody body;

    public static CloseTopBoxInteractiveOTOMessageResponse build(java.util.Map<String, ?> map) throws Exception {
        CloseTopBoxInteractiveOTOMessageResponse self = new CloseTopBoxInteractiveOTOMessageResponse();
        return TeaModel.build(map, self);
    }

    public CloseTopBoxInteractiveOTOMessageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CloseTopBoxInteractiveOTOMessageResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CloseTopBoxInteractiveOTOMessageResponse setBody(CloseTopBoxInteractiveOTOMessageResponseBody body) {
        this.body = body;
        return this;
    }
    public CloseTopBoxInteractiveOTOMessageResponseBody getBody() {
        return this.body;
    }

}
