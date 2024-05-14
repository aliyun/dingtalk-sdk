// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class MultiOrgPermissionGrantRequest extends TeaModel {
    @NameInMap("grantDeptIdList")
    public java.util.List<Long> grantDeptIdList;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("joinCorpId")
    public String joinCorpId;

    public static MultiOrgPermissionGrantRequest build(java.util.Map<String, ?> map) throws Exception {
        MultiOrgPermissionGrantRequest self = new MultiOrgPermissionGrantRequest();
        return TeaModel.build(map, self);
    }

    public MultiOrgPermissionGrantRequest setGrantDeptIdList(java.util.List<Long> grantDeptIdList) {
        this.grantDeptIdList = grantDeptIdList;
        return this;
    }
    public java.util.List<Long> getGrantDeptIdList() {
        return this.grantDeptIdList;
    }

    public MultiOrgPermissionGrantRequest setJoinCorpId(String joinCorpId) {
        this.joinCorpId = joinCorpId;
        return this;
    }
    public String getJoinCorpId() {
        return this.joinCorpId;
    }

}
