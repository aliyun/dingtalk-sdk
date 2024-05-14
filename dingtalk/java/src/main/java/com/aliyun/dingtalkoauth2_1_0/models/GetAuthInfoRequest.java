// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkoauth2_1_0.models;

import com.aliyun.tea.*;

public class GetAuthInfoRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("authCorpId")
    public String authCorpId;

    public static GetAuthInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        GetAuthInfoRequest self = new GetAuthInfoRequest();
        return TeaModel.build(map, self);
    }

    public GetAuthInfoRequest setAuthCorpId(String authCorpId) {
        this.authCorpId = authCorpId;
        return this;
    }
    public String getAuthCorpId() {
        return this.authCorpId;
    }

}
