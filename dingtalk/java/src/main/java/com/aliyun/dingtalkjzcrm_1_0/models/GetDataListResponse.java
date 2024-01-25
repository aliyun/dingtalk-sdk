// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkjzcrm_1_0.models;

import com.aliyun.tea.*;

public class GetDataListResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetDataListResponseBody body;

    public static GetDataListResponse build(java.util.Map<String, ?> map) throws Exception {
        GetDataListResponse self = new GetDataListResponse();
        return TeaModel.build(map, self);
    }

    public GetDataListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetDataListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetDataListResponse setBody(GetDataListResponseBody body) {
        this.body = body;
        return this;
    }
    public GetDataListResponseBody getBody() {
        return this.body;
    }

}
