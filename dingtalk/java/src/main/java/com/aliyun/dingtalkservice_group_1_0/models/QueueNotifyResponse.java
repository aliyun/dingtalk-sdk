// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class QueueNotifyResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public QueueNotifyResponseBody body;

    public static QueueNotifyResponse build(java.util.Map<String, ?> map) throws Exception {
        QueueNotifyResponse self = new QueueNotifyResponse();
        return TeaModel.build(map, self);
    }

    public QueueNotifyResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueueNotifyResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueueNotifyResponse setBody(QueueNotifyResponseBody body) {
        this.body = body;
        return this;
    }
    public QueueNotifyResponseBody getBody() {
        return this.body;
    }

}
