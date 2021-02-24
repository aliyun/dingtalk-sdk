// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkroa_2020_12_16.models;

import com.aliyun.tea.*;

public class ApiTestDuheHeaders extends TeaModel {
    @NameInMap("commonHeaders")
    public java.util.Map<String, String> commonHeaders;

    @NameInMap("x-acs-dingtalk-access-token")
    public String xAcsDingtalkAccessToken;

    public static ApiTestDuheHeaders build(java.util.Map<String, ?> map) throws Exception {
        ApiTestDuheHeaders self = new ApiTestDuheHeaders();
        return TeaModel.build(map, self);
    }

    public ApiTestDuheHeaders setCommonHeaders(java.util.Map<String, String> commonHeaders) {
        this.commonHeaders = commonHeaders;
        return this;
    }
    public java.util.Map<String, String> getCommonHeaders() {
        return this.commonHeaders;
    }

    public ApiTestDuheHeaders setXAcsDingtalkAccessToken(String xAcsDingtalkAccessToken) {
        this.xAcsDingtalkAccessToken = xAcsDingtalkAccessToken;
        return this;
    }
    public String getXAcsDingtalkAccessToken() {
        return this.xAcsDingtalkAccessToken;
    }

}
