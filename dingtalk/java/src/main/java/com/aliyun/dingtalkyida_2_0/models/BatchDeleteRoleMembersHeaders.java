// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_2_0.models;

import com.aliyun.tea.*;

public class BatchDeleteRoleMembersHeaders extends TeaModel {
    @NameInMap("commonHeaders")
    public java.util.Map<String, String> commonHeaders;

    @NameInMap("x-acs-dingtalk-access-token")
    public String xAcsDingtalkAccessToken;

    public static BatchDeleteRoleMembersHeaders build(java.util.Map<String, ?> map) throws Exception {
        BatchDeleteRoleMembersHeaders self = new BatchDeleteRoleMembersHeaders();
        return TeaModel.build(map, self);
    }

    public BatchDeleteRoleMembersHeaders setCommonHeaders(java.util.Map<String, String> commonHeaders) {
        this.commonHeaders = commonHeaders;
        return this;
    }
    public java.util.Map<String, String> getCommonHeaders() {
        return this.commonHeaders;
    }

    public BatchDeleteRoleMembersHeaders setXAcsDingtalkAccessToken(String xAcsDingtalkAccessToken) {
        this.xAcsDingtalkAccessToken = xAcsDingtalkAccessToken;
        return this;
    }
    public String getXAcsDingtalkAccessToken() {
        return this.xAcsDingtalkAccessToken;
    }

}
