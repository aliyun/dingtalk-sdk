// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class UpdateVoiceMsgCtrlStatusResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateVoiceMsgCtrlStatusResponseBody body;

    public static UpdateVoiceMsgCtrlStatusResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateVoiceMsgCtrlStatusResponse self = new UpdateVoiceMsgCtrlStatusResponse();
        return TeaModel.build(map, self);
    }

    public UpdateVoiceMsgCtrlStatusResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateVoiceMsgCtrlStatusResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateVoiceMsgCtrlStatusResponse setBody(UpdateVoiceMsgCtrlStatusResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateVoiceMsgCtrlStatusResponseBody getBody() {
        return this.body;
    }

}
