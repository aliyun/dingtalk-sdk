// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class GetAccountMappingRequest extends TeaModel {
    @NameInMap("domain")
    public String domain;

    @NameInMap("userId")
    public String userId;

    public static GetAccountMappingRequest build(java.util.Map<String, ?> map) throws Exception {
        GetAccountMappingRequest self = new GetAccountMappingRequest();
        return TeaModel.build(map, self);
    }

    public GetAccountMappingRequest setDomain(String domain) {
        this.domain = domain;
        return this;
    }
    public String getDomain() {
        return this.domain;
    }

    public GetAccountMappingRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
