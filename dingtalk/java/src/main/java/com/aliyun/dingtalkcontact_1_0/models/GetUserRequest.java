// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class GetUserRequest extends TeaModel {
    @NameInMap("dingUid")
    public Long dingUid;

    @NameInMap("dingOpenAppId")
    public String dingOpenAppId;

    @NameInMap("dingOpenAppOrgId")
    public Long dingOpenAppOrgId;

    @NameInMap("dingTokenUserInfoFieldScopes")
    public String dingTokenUserInfoFieldScopes;

    public static GetUserRequest build(java.util.Map<String, ?> map) throws Exception {
        GetUserRequest self = new GetUserRequest();
        return TeaModel.build(map, self);
    }

    public GetUserRequest setDingUid(Long dingUid) {
        this.dingUid = dingUid;
        return this;
    }
    public Long getDingUid() {
        return this.dingUid;
    }

    public GetUserRequest setDingOpenAppId(String dingOpenAppId) {
        this.dingOpenAppId = dingOpenAppId;
        return this;
    }
    public String getDingOpenAppId() {
        return this.dingOpenAppId;
    }

    public GetUserRequest setDingOpenAppOrgId(Long dingOpenAppOrgId) {
        this.dingOpenAppOrgId = dingOpenAppOrgId;
        return this;
    }
    public Long getDingOpenAppOrgId() {
        return this.dingOpenAppOrgId;
    }

    public GetUserRequest setDingTokenUserInfoFieldScopes(String dingTokenUserInfoFieldScopes) {
        this.dingTokenUserInfoFieldScopes = dingTokenUserInfoFieldScopes;
        return this;
    }
    public String getDingTokenUserInfoFieldScopes() {
        return this.dingTokenUserInfoFieldScopes;
    }

}
