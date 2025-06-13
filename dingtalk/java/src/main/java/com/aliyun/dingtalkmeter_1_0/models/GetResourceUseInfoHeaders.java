// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmeter_1_0.models;

import com.aliyun.tea.*;

public class GetResourceUseInfoHeaders extends TeaModel {
    @NameInMap("commonHeaders")
    public java.util.Map<String, String> commonHeaders;

    @NameInMap("x-acs-dingtalk-access-token")
    public String xAcsDingtalkAccessToken;

    public static GetResourceUseInfoHeaders build(java.util.Map<String, ?> map) throws Exception {
        GetResourceUseInfoHeaders self = new GetResourceUseInfoHeaders();
        return TeaModel.build(map, self);
    }

    public GetResourceUseInfoHeaders setCommonHeaders(java.util.Map<String, String> commonHeaders) {
        this.commonHeaders = commonHeaders;
        return this;
    }
    public java.util.Map<String, String> getCommonHeaders() {
        return this.commonHeaders;
    }

    public GetResourceUseInfoHeaders setXAcsDingtalkAccessToken(String xAcsDingtalkAccessToken) {
        this.xAcsDingtalkAccessToken = xAcsDingtalkAccessToken;
        return this;
    }
    public String getXAcsDingtalkAccessToken() {
        return this.xAcsDingtalkAccessToken;
    }

}
