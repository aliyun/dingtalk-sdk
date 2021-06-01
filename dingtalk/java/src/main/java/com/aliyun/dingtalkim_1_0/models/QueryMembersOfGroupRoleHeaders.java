// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryMembersOfGroupRoleHeaders extends TeaModel {
    @NameInMap("commonHeaders")
    public java.util.Map<String, String> commonHeaders;

    @NameInMap("x-acs-dingtalk-access-token")
    public String xAcsDingtalkAccessToken;

    public static QueryMembersOfGroupRoleHeaders build(java.util.Map<String, ?> map) throws Exception {
        QueryMembersOfGroupRoleHeaders self = new QueryMembersOfGroupRoleHeaders();
        return TeaModel.build(map, self);
    }

    public QueryMembersOfGroupRoleHeaders setCommonHeaders(java.util.Map<String, String> commonHeaders) {
        this.commonHeaders = commonHeaders;
        return this;
    }
    public java.util.Map<String, String> getCommonHeaders() {
        return this.commonHeaders;
    }

    public QueryMembersOfGroupRoleHeaders setXAcsDingtalkAccessToken(String xAcsDingtalkAccessToken) {
        this.xAcsDingtalkAccessToken = xAcsDingtalkAccessToken;
        return this;
    }
    public String getXAcsDingtalkAccessToken() {
        return this.xAcsDingtalkAccessToken;
    }

}
