// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CampusCreateCampusGroupResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CampusCreateCampusGroupResponseBody body;

    public static CampusCreateCampusGroupResponse build(java.util.Map<String, ?> map) throws Exception {
        CampusCreateCampusGroupResponse self = new CampusCreateCampusGroupResponse();
        return TeaModel.build(map, self);
    }

    public CampusCreateCampusGroupResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CampusCreateCampusGroupResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CampusCreateCampusGroupResponse setBody(CampusCreateCampusGroupResponseBody body) {
        this.body = body;
        return this;
    }
    public CampusCreateCampusGroupResponseBody getBody() {
        return this.body;
    }

}
