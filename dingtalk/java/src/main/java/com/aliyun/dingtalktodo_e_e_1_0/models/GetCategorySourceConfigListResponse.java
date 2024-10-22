// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_e_e_1_0.models;

import com.aliyun.tea.*;

public class GetCategorySourceConfigListResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetCategorySourceConfigListResponseBody body;

    public static GetCategorySourceConfigListResponse build(java.util.Map<String, ?> map) throws Exception {
        GetCategorySourceConfigListResponse self = new GetCategorySourceConfigListResponse();
        return TeaModel.build(map, self);
    }

    public GetCategorySourceConfigListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetCategorySourceConfigListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetCategorySourceConfigListResponse setBody(GetCategorySourceConfigListResponseBody body) {
        this.body = body;
        return this;
    }
    public GetCategorySourceConfigListResponseBody getBody() {
        return this.body;
    }

}
