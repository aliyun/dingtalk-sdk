// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalitrip_1_0.models;

import com.aliyun.tea.*;

public class AddCityCarApplyResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AddCityCarApplyResponseBody body;

    public static AddCityCarApplyResponse build(java.util.Map<String, ?> map) throws Exception {
        AddCityCarApplyResponse self = new AddCityCarApplyResponse();
        return TeaModel.build(map, self);
    }

    public AddCityCarApplyResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AddCityCarApplyResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AddCityCarApplyResponse setBody(AddCityCarApplyResponseBody body) {
        this.body = body;
        return this;
    }
    public AddCityCarApplyResponseBody getBody() {
        return this.body;
    }

}
