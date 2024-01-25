// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class GetIndustryTypeResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetIndustryTypeResponseBody body;

    public static GetIndustryTypeResponse build(java.util.Map<String, ?> map) throws Exception {
        GetIndustryTypeResponse self = new GetIndustryTypeResponse();
        return TeaModel.build(map, self);
    }

    public GetIndustryTypeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetIndustryTypeResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetIndustryTypeResponse setBody(GetIndustryTypeResponseBody body) {
        this.body = body;
        return this;
    }
    public GetIndustryTypeResponseBody getBody() {
        return this.body;
    }

}
