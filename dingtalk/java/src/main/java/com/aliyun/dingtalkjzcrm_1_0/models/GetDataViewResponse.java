// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkjzcrm_1_0.models;

import com.aliyun.tea.*;

public class GetDataViewResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetDataViewResponseBody body;

    public static GetDataViewResponse build(java.util.Map<String, ?> map) throws Exception {
        GetDataViewResponse self = new GetDataViewResponse();
        return TeaModel.build(map, self);
    }

    public GetDataViewResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetDataViewResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetDataViewResponse setBody(GetDataViewResponseBody body) {
        this.body = body;
        return this;
    }
    public GetDataViewResponseBody getBody() {
        return this.body;
    }

}
