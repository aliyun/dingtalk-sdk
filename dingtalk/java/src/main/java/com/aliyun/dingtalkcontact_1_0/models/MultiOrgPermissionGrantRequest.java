// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class MultiOrgPermissionGrantRequest extends TeaModel {
    // 授权加入的组织corpId
    @NameInMap("joinCorpId")
    public String joinCorpId;

    public static MultiOrgPermissionGrantRequest build(java.util.Map<String, ?> map) throws Exception {
        MultiOrgPermissionGrantRequest self = new MultiOrgPermissionGrantRequest();
        return TeaModel.build(map, self);
    }

    public MultiOrgPermissionGrantRequest setJoinCorpId(String joinCorpId) {
        this.joinCorpId = joinCorpId;
        return this;
    }
    public String getJoinCorpId() {
        return this.joinCorpId;
    }

}
