// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_search_ask_1_0.models;

import com.aliyun.tea.*;

public class FetchLoginStatusDevicesResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public FetchLoginStatusDevicesResponseBody body;

    public static FetchLoginStatusDevicesResponse build(java.util.Map<String, ?> map) throws Exception {
        FetchLoginStatusDevicesResponse self = new FetchLoginStatusDevicesResponse();
        return TeaModel.build(map, self);
    }

    public FetchLoginStatusDevicesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public FetchLoginStatusDevicesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public FetchLoginStatusDevicesResponse setBody(FetchLoginStatusDevicesResponseBody body) {
        this.body = body;
        return this;
    }
    public FetchLoginStatusDevicesResponseBody getBody() {
        return this.body;
    }

}
