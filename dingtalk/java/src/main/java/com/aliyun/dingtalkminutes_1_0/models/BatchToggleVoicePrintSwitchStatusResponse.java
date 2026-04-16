// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class BatchToggleVoicePrintSwitchStatusResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public BatchToggleVoicePrintSwitchStatusResponseBody body;

    public static BatchToggleVoicePrintSwitchStatusResponse build(java.util.Map<String, ?> map) throws Exception {
        BatchToggleVoicePrintSwitchStatusResponse self = new BatchToggleVoicePrintSwitchStatusResponse();
        return TeaModel.build(map, self);
    }

    public BatchToggleVoicePrintSwitchStatusResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BatchToggleVoicePrintSwitchStatusResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public BatchToggleVoicePrintSwitchStatusResponse setBody(BatchToggleVoicePrintSwitchStatusResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchToggleVoicePrintSwitchStatusResponseBody getBody() {
        return this.body;
    }

}
