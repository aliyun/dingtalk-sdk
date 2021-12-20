// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class GetIndustryTypeResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public GetIndustryTypeResponse setBody(GetIndustryTypeResponseBody body) {
        this.body = body;
        return this;
    }
    public GetIndustryTypeResponseBody getBody() {
        return this.body;
    }

}
