// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class GetResidentUserInfoRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("subCorpId")
    public String subCorpId;

    public static GetResidentUserInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        GetResidentUserInfoRequest self = new GetResidentUserInfoRequest();
        return TeaModel.build(map, self);
    }

    public GetResidentUserInfoRequest setSubCorpId(String subCorpId) {
        this.subCorpId = subCorpId;
        return this;
    }
    public String getSubCorpId() {
        return this.subCorpId;
    }

}
