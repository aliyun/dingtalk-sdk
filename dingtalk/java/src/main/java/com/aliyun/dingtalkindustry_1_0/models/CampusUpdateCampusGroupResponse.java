// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CampusUpdateCampusGroupResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CampusUpdateCampusGroupResponseBody body;

    public static CampusUpdateCampusGroupResponse build(java.util.Map<String, ?> map) throws Exception {
        CampusUpdateCampusGroupResponse self = new CampusUpdateCampusGroupResponse();
        return TeaModel.build(map, self);
    }

    public CampusUpdateCampusGroupResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CampusUpdateCampusGroupResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CampusUpdateCampusGroupResponse setBody(CampusUpdateCampusGroupResponseBody body) {
        this.body = body;
        return this;
    }
    public CampusUpdateCampusGroupResponseBody getBody() {
        return this.body;
    }

}
