// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkwiki_2_0.models;

import com.aliyun.tea.*;

public class AddTeamHeaders extends TeaModel {
    @NameInMap("commonHeaders")
    public java.util.Map<String, String> commonHeaders;

    @NameInMap("x-acs-dingtalk-access-token")
    public String xAcsDingtalkAccessToken;

    public static AddTeamHeaders build(java.util.Map<String, ?> map) throws Exception {
        AddTeamHeaders self = new AddTeamHeaders();
        return TeaModel.build(map, self);
    }

    public AddTeamHeaders setCommonHeaders(java.util.Map<String, String> commonHeaders) {
        this.commonHeaders = commonHeaders;
        return this;
    }
    public java.util.Map<String, String> getCommonHeaders() {
        return this.commonHeaders;
    }

    public AddTeamHeaders setXAcsDingtalkAccessToken(String xAcsDingtalkAccessToken) {
        this.xAcsDingtalkAccessToken = xAcsDingtalkAccessToken;
        return this;
    }
    public String getXAcsDingtalkAccessToken() {
        return this.xAcsDingtalkAccessToken;
    }

}
