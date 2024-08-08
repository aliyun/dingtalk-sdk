// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class GetRelatedViewTabDataResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetRelatedViewTabDataResponseBody body;

    public static GetRelatedViewTabDataResponse build(java.util.Map<String, ?> map) throws Exception {
        GetRelatedViewTabDataResponse self = new GetRelatedViewTabDataResponse();
        return TeaModel.build(map, self);
    }

    public GetRelatedViewTabDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetRelatedViewTabDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetRelatedViewTabDataResponse setBody(GetRelatedViewTabDataResponseBody body) {
        this.body = body;
        return this;
    }
    public GetRelatedViewTabDataResponseBody getBody() {
        return this.body;
    }

}
