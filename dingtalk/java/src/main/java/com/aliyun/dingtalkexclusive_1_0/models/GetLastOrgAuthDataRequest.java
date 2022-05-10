// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetLastOrgAuthDataRequest extends TeaModel {
    // 企业的corpId
    @NameInMap("targetCorpId")
    public String targetCorpId;

    public static GetLastOrgAuthDataRequest build(java.util.Map<String, ?> map) throws Exception {
        GetLastOrgAuthDataRequest self = new GetLastOrgAuthDataRequest();
        return TeaModel.build(map, self);
    }

    public GetLastOrgAuthDataRequest setTargetCorpId(String targetCorpId) {
        this.targetCorpId = targetCorpId;
        return this;
    }
    public String getTargetCorpId() {
        return this.targetCorpId;
    }

}
