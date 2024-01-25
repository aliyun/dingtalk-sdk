// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyun_shu_1_0.models;

import com.aliyun.tea.*;

public class SaveOpenExternalLogResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SaveOpenExternalLogResponseBody body;

    public static SaveOpenExternalLogResponse build(java.util.Map<String, ?> map) throws Exception {
        SaveOpenExternalLogResponse self = new SaveOpenExternalLogResponse();
        return TeaModel.build(map, self);
    }

    public SaveOpenExternalLogResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SaveOpenExternalLogResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SaveOpenExternalLogResponse setBody(SaveOpenExternalLogResponseBody body) {
        this.body = body;
        return this;
    }
    public SaveOpenExternalLogResponseBody getBody() {
        return this.body;
    }

}
