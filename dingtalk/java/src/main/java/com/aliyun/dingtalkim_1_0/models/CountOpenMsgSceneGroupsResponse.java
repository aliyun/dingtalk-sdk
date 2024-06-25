// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class CountOpenMsgSceneGroupsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CountOpenMsgSceneGroupsResponseBody body;

    public static CountOpenMsgSceneGroupsResponse build(java.util.Map<String, ?> map) throws Exception {
        CountOpenMsgSceneGroupsResponse self = new CountOpenMsgSceneGroupsResponse();
        return TeaModel.build(map, self);
    }

    public CountOpenMsgSceneGroupsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CountOpenMsgSceneGroupsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CountOpenMsgSceneGroupsResponse setBody(CountOpenMsgSceneGroupsResponseBody body) {
        this.body = body;
        return this;
    }
    public CountOpenMsgSceneGroupsResponseBody getBody() {
        return this.body;
    }

}
