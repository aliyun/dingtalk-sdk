// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GroupQueryByOpenIdResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GroupQueryByOpenIdResponseBody body;

    public static GroupQueryByOpenIdResponse build(java.util.Map<String, ?> map) throws Exception {
        GroupQueryByOpenIdResponse self = new GroupQueryByOpenIdResponse();
        return TeaModel.build(map, self);
    }

    public GroupQueryByOpenIdResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GroupQueryByOpenIdResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GroupQueryByOpenIdResponse setBody(GroupQueryByOpenIdResponseBody body) {
        this.body = body;
        return this;
    }
    public GroupQueryByOpenIdResponseBody getBody() {
        return this.body;
    }

}
