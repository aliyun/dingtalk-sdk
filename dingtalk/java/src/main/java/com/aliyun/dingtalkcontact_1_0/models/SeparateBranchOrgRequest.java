// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class SeparateBranchOrgRequest extends TeaModel {
    @NameInMap("attachDeptId")
    public Long attachDeptId;

    public static SeparateBranchOrgRequest build(java.util.Map<String, ?> map) throws Exception {
        SeparateBranchOrgRequest self = new SeparateBranchOrgRequest();
        return TeaModel.build(map, self);
    }

    public SeparateBranchOrgRequest setAttachDeptId(Long attachDeptId) {
        this.attachDeptId = attachDeptId;
        return this;
    }
    public Long getAttachDeptId() {
        return this.attachDeptId;
    }

}
