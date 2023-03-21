// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_2_0.models;

import com.aliyun.tea.*;

public class GetRelationUkSettingHeaders extends TeaModel {
    @NameInMap("commonHeaders")
    public java.util.Map<String, String> commonHeaders;

    @NameInMap("x-acs-dingtalk-access-token")
    public String xAcsDingtalkAccessToken;

    public static GetRelationUkSettingHeaders build(java.util.Map<String, ?> map) throws Exception {
        GetRelationUkSettingHeaders self = new GetRelationUkSettingHeaders();
        return TeaModel.build(map, self);
    }

    public GetRelationUkSettingHeaders setCommonHeaders(java.util.Map<String, String> commonHeaders) {
        this.commonHeaders = commonHeaders;
        return this;
    }
    public java.util.Map<String, String> getCommonHeaders() {
        return this.commonHeaders;
    }

    public GetRelationUkSettingHeaders setXAcsDingtalkAccessToken(String xAcsDingtalkAccessToken) {
        this.xAcsDingtalkAccessToken = xAcsDingtalkAccessToken;
        return this;
    }
    public String getXAcsDingtalkAccessToken() {
        return this.xAcsDingtalkAccessToken;
    }

}
