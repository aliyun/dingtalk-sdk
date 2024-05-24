// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class HrmAuthResourcesQueryResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public HrmAuthResourcesQueryResponseBody body;

    public static HrmAuthResourcesQueryResponse build(java.util.Map<String, ?> map) throws Exception {
        HrmAuthResourcesQueryResponse self = new HrmAuthResourcesQueryResponse();
        return TeaModel.build(map, self);
    }

    public HrmAuthResourcesQueryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HrmAuthResourcesQueryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public HrmAuthResourcesQueryResponse setBody(HrmAuthResourcesQueryResponseBody body) {
        this.body = body;
        return this;
    }
    public HrmAuthResourcesQueryResponseBody getBody() {
        return this.body;
    }

}
