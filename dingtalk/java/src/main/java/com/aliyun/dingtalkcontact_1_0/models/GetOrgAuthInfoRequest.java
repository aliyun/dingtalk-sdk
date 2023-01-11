// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class GetOrgAuthInfoRequest extends TeaModel {
    /**
     * <p>需要获取的企业认证信息的企业corpId</p>
     */
    @NameInMap("targetCorpId")
    public String targetCorpId;

    public static GetOrgAuthInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        GetOrgAuthInfoRequest self = new GetOrgAuthInfoRequest();
        return TeaModel.build(map, self);
    }

    public GetOrgAuthInfoRequest setTargetCorpId(String targetCorpId) {
        this.targetCorpId = targetCorpId;
        return this;
    }
    public String getTargetCorpId() {
        return this.targetCorpId;
    }

}
