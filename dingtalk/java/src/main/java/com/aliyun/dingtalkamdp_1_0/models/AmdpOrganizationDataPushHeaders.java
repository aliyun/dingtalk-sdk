// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkamdp_1_0.models;

import com.aliyun.tea.*;

public class AmdpOrganizationDataPushHeaders extends TeaModel {
    @NameInMap("commonHeaders")
    public java.util.Map<String, String> commonHeaders;

    @NameInMap("x-acs-dingtalk-access-token")
    public String xAcsDingtalkAccessToken;

    public static AmdpOrganizationDataPushHeaders build(java.util.Map<String, ?> map) throws Exception {
        AmdpOrganizationDataPushHeaders self = new AmdpOrganizationDataPushHeaders();
        return TeaModel.build(map, self);
    }

    public AmdpOrganizationDataPushHeaders setCommonHeaders(java.util.Map<String, String> commonHeaders) {
        this.commonHeaders = commonHeaders;
        return this;
    }
    public java.util.Map<String, String> getCommonHeaders() {
        return this.commonHeaders;
    }

    public AmdpOrganizationDataPushHeaders setXAcsDingtalkAccessToken(String xAcsDingtalkAccessToken) {
        this.xAcsDingtalkAccessToken = xAcsDingtalkAccessToken;
        return this;
    }
    public String getXAcsDingtalkAccessToken() {
        return this.xAcsDingtalkAccessToken;
    }

}
