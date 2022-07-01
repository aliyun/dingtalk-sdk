// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktranscribe_1_0.models;

import com.aliyun.tea.*;

public class UpdatePermissionForUsersHeaders extends TeaModel {
    @NameInMap("commonHeaders")
    public java.util.Map<String, String> commonHeaders;

    @NameInMap("x-acs-dingtalk-access-token")
    public String xAcsDingtalkAccessToken;

    public static UpdatePermissionForUsersHeaders build(java.util.Map<String, ?> map) throws Exception {
        UpdatePermissionForUsersHeaders self = new UpdatePermissionForUsersHeaders();
        return TeaModel.build(map, self);
    }

    public UpdatePermissionForUsersHeaders setCommonHeaders(java.util.Map<String, String> commonHeaders) {
        this.commonHeaders = commonHeaders;
        return this;
    }
    public java.util.Map<String, String> getCommonHeaders() {
        return this.commonHeaders;
    }

    public UpdatePermissionForUsersHeaders setXAcsDingtalkAccessToken(String xAcsDingtalkAccessToken) {
        this.xAcsDingtalkAccessToken = xAcsDingtalkAccessToken;
        return this;
    }
    public String getXAcsDingtalkAccessToken() {
        return this.xAcsDingtalkAccessToken;
    }

}
