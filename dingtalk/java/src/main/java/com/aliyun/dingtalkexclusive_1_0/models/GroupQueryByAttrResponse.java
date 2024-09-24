// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GroupQueryByAttrResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GroupQueryByAttrResponseBody body;

    public static GroupQueryByAttrResponse build(java.util.Map<String, ?> map) throws Exception {
        GroupQueryByAttrResponse self = new GroupQueryByAttrResponse();
        return TeaModel.build(map, self);
    }

    public GroupQueryByAttrResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GroupQueryByAttrResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GroupQueryByAttrResponse setBody(GroupQueryByAttrResponseBody body) {
        this.body = body;
        return this;
    }
    public GroupQueryByAttrResponseBody getBody() {
        return this.body;
    }

}
