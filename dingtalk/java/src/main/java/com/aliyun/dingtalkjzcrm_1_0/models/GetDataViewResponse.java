// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkjzcrm_1_0.models;

import com.aliyun.tea.*;

public class GetDataViewResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public GetDataViewResponse setBody(GetDataViewResponseBody body) {
        this.body = body;
        return this;
    }
    public GetDataViewResponseBody getBody() {
        return this.body;
    }

}
