// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class AddShareCidListResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AddShareCidListResponseBody body;

    public static AddShareCidListResponse build(java.util.Map<String, ?> map) throws Exception {
        AddShareCidListResponse self = new AddShareCidListResponse();
        return TeaModel.build(map, self);
    }

    public AddShareCidListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AddShareCidListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AddShareCidListResponse setBody(AddShareCidListResponseBody body) {
        this.body = body;
        return this;
    }
    public AddShareCidListResponseBody getBody() {
        return this.body;
    }

}
