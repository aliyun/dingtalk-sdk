// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class MoveOutTempStorageResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public MoveOutTempStorageResponseBody body;

    public static MoveOutTempStorageResponse build(java.util.Map<String, ?> map) throws Exception {
        MoveOutTempStorageResponse self = new MoveOutTempStorageResponse();
        return TeaModel.build(map, self);
    }

    public MoveOutTempStorageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public MoveOutTempStorageResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public MoveOutTempStorageResponse setBody(MoveOutTempStorageResponseBody body) {
        this.body = body;
        return this;
    }
    public MoveOutTempStorageResponseBody getBody() {
        return this.body;
    }

}
