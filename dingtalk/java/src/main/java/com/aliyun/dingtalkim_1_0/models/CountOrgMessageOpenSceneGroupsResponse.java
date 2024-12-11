// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class CountOrgMessageOpenSceneGroupsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CountOrgMessageOpenSceneGroupsResponseBody body;

    public static CountOrgMessageOpenSceneGroupsResponse build(java.util.Map<String, ?> map) throws Exception {
        CountOrgMessageOpenSceneGroupsResponse self = new CountOrgMessageOpenSceneGroupsResponse();
        return TeaModel.build(map, self);
    }

    public CountOrgMessageOpenSceneGroupsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CountOrgMessageOpenSceneGroupsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CountOrgMessageOpenSceneGroupsResponse setBody(CountOrgMessageOpenSceneGroupsResponseBody body) {
        this.body = body;
        return this;
    }
    public CountOrgMessageOpenSceneGroupsResponseBody getBody() {
        return this.body;
    }

}
