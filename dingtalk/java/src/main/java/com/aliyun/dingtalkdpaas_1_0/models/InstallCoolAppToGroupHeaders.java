// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdpaas_1_0.models;

import com.aliyun.tea.*;

public class InstallCoolAppToGroupHeaders extends TeaModel {
    @NameInMap("commonHeaders")
    public java.util.Map<String, String> commonHeaders;

    @NameInMap("x-acs-dingtalk-access-token")
    public String xAcsDingtalkAccessToken;

    public static InstallCoolAppToGroupHeaders build(java.util.Map<String, ?> map) throws Exception {
        InstallCoolAppToGroupHeaders self = new InstallCoolAppToGroupHeaders();
        return TeaModel.build(map, self);
    }

    public InstallCoolAppToGroupHeaders setCommonHeaders(java.util.Map<String, String> commonHeaders) {
        this.commonHeaders = commonHeaders;
        return this;
    }
    public java.util.Map<String, String> getCommonHeaders() {
        return this.commonHeaders;
    }

    public InstallCoolAppToGroupHeaders setXAcsDingtalkAccessToken(String xAcsDingtalkAccessToken) {
        this.xAcsDingtalkAccessToken = xAcsDingtalkAccessToken;
        return this;
    }
    public String getXAcsDingtalkAccessToken() {
        return this.xAcsDingtalkAccessToken;
    }

}
