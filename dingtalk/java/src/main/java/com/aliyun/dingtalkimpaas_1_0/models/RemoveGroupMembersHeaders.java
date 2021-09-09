// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkimpaas_1_0.models;

import com.aliyun.tea.*;

public class RemoveGroupMembersHeaders extends TeaModel {
    @NameInMap("commonHeaders")
    public java.util.Map<String, String> commonHeaders;

    @NameInMap("operatingSource")
    public String operatingSource;

    @NameInMap("x-acs-dingtalk-access-token")
    public String xAcsDingtalkAccessToken;

    public static RemoveGroupMembersHeaders build(java.util.Map<String, ?> map) throws Exception {
        RemoveGroupMembersHeaders self = new RemoveGroupMembersHeaders();
        return TeaModel.build(map, self);
    }

    public RemoveGroupMembersHeaders setCommonHeaders(java.util.Map<String, String> commonHeaders) {
        this.commonHeaders = commonHeaders;
        return this;
    }
    public java.util.Map<String, String> getCommonHeaders() {
        return this.commonHeaders;
    }

    public RemoveGroupMembersHeaders setOperatingSource(String operatingSource) {
        this.operatingSource = operatingSource;
        return this;
    }
    public String getOperatingSource() {
        return this.operatingSource;
    }

    public RemoveGroupMembersHeaders setXAcsDingtalkAccessToken(String xAcsDingtalkAccessToken) {
        this.xAcsDingtalkAccessToken = xAcsDingtalkAccessToken;
        return this;
    }
    public String getXAcsDingtalkAccessToken() {
        return this.xAcsDingtalkAccessToken;
    }

}
