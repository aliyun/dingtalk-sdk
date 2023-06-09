// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class EsignSyncEventResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public EsignSyncEventResponseBody body;

    public static EsignSyncEventResponse build(java.util.Map<String, ?> map) throws Exception {
        EsignSyncEventResponse self = new EsignSyncEventResponse();
        return TeaModel.build(map, self);
    }

    public EsignSyncEventResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public EsignSyncEventResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public EsignSyncEventResponse setBody(EsignSyncEventResponseBody body) {
        this.body = body;
        return this;
    }
    public EsignSyncEventResponseBody getBody() {
        return this.body;
    }

}
