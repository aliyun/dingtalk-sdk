// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class QuerySmartDeviceAiSceneByIdResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QuerySmartDeviceAiSceneByIdResponseBody body;

    public static QuerySmartDeviceAiSceneByIdResponse build(java.util.Map<String, ?> map) throws Exception {
        QuerySmartDeviceAiSceneByIdResponse self = new QuerySmartDeviceAiSceneByIdResponse();
        return TeaModel.build(map, self);
    }

    public QuerySmartDeviceAiSceneByIdResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QuerySmartDeviceAiSceneByIdResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QuerySmartDeviceAiSceneByIdResponse setBody(QuerySmartDeviceAiSceneByIdResponseBody body) {
        this.body = body;
        return this;
    }
    public QuerySmartDeviceAiSceneByIdResponseBody getBody() {
        return this.body;
    }

}
