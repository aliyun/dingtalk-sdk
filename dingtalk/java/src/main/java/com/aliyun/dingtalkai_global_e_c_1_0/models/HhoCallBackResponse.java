// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_global_e_c_1_0.models;

import com.aliyun.tea.*;

public class HhoCallBackResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public HhoCallBackResponseBody body;

    public static HhoCallBackResponse build(java.util.Map<String, ?> map) throws Exception {
        HhoCallBackResponse self = new HhoCallBackResponse();
        return TeaModel.build(map, self);
    }

    public HhoCallBackResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HhoCallBackResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public HhoCallBackResponse setBody(HhoCallBackResponseBody body) {
        this.body = body;
        return this;
    }
    public HhoCallBackResponseBody getBody() {
        return this.body;
    }

}
