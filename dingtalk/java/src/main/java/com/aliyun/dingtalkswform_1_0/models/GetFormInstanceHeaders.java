// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkswform_1_0.models;

import com.aliyun.tea.*;

public class GetFormInstanceHeaders extends TeaModel {
    @NameInMap("commonHeaders")
    public java.util.Map<String, String> commonHeaders;

    @NameInMap("x-acs-dingtalk-access-token")
    public String xAcsDingtalkAccessToken;

    public static GetFormInstanceHeaders build(java.util.Map<String, ?> map) throws Exception {
        GetFormInstanceHeaders self = new GetFormInstanceHeaders();
        return TeaModel.build(map, self);
    }

    public GetFormInstanceHeaders setCommonHeaders(java.util.Map<String, String> commonHeaders) {
        this.commonHeaders = commonHeaders;
        return this;
    }
    public java.util.Map<String, String> getCommonHeaders() {
        return this.commonHeaders;
    }

    public GetFormInstanceHeaders setXAcsDingtalkAccessToken(String xAcsDingtalkAccessToken) {
        this.xAcsDingtalkAccessToken = xAcsDingtalkAccessToken;
        return this;
    }
    public String getXAcsDingtalkAccessToken() {
        return this.xAcsDingtalkAccessToken;
    }

}
