// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class LoadBizObjectsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public LoadBizObjectsResponseBody body;

    public static LoadBizObjectsResponse build(java.util.Map<String, ?> map) throws Exception {
        LoadBizObjectsResponse self = new LoadBizObjectsResponse();
        return TeaModel.build(map, self);
    }

    public LoadBizObjectsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public LoadBizObjectsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public LoadBizObjectsResponse setBody(LoadBizObjectsResponseBody body) {
        this.body = body;
        return this;
    }
    public LoadBizObjectsResponseBody getBody() {
        return this.body;
    }

}
