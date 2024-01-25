// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class IndustryManufactureMesSubCooperationTeamResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public IndustryManufactureMesSubCooperationTeamResponseBody body;

    public static IndustryManufactureMesSubCooperationTeamResponse build(java.util.Map<String, ?> map) throws Exception {
        IndustryManufactureMesSubCooperationTeamResponse self = new IndustryManufactureMesSubCooperationTeamResponse();
        return TeaModel.build(map, self);
    }

    public IndustryManufactureMesSubCooperationTeamResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public IndustryManufactureMesSubCooperationTeamResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public IndustryManufactureMesSubCooperationTeamResponse setBody(IndustryManufactureMesSubCooperationTeamResponseBody body) {
        this.body = body;
        return this;
    }
    public IndustryManufactureMesSubCooperationTeamResponseBody getBody() {
        return this.body;
    }

}
