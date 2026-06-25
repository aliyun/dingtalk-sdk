// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmcp_1_0.models;

import com.aliyun.tea.*;

public class GetSkillDetailHeaders extends TeaModel {
    @NameInMap("commonHeaders")
    public java.util.Map<String, String> commonHeaders;

    @NameInMap("x-acs-dingtalk-access-token")
    public String xAcsDingtalkAccessToken;

    public static GetSkillDetailHeaders build(java.util.Map<String, ?> map) throws Exception {
        GetSkillDetailHeaders self = new GetSkillDetailHeaders();
        return TeaModel.build(map, self);
    }

    public GetSkillDetailHeaders setCommonHeaders(java.util.Map<String, String> commonHeaders) {
        this.commonHeaders = commonHeaders;
        return this;
    }
    public java.util.Map<String, String> getCommonHeaders() {
        return this.commonHeaders;
    }

    public GetSkillDetailHeaders setXAcsDingtalkAccessToken(String xAcsDingtalkAccessToken) {
        this.xAcsDingtalkAccessToken = xAcsDingtalkAccessToken;
        return this;
    }
    public String getXAcsDingtalkAccessToken() {
        return this.xAcsDingtalkAccessToken;
    }

}
