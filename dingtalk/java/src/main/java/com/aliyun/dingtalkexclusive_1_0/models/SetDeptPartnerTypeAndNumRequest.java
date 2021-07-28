// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class SetDeptPartnerTypeAndNumRequest extends TeaModel {
    // 部门id
    @NameInMap("deptId")
    public String deptId;

    // 伙伴编码
    @NameInMap("partnerNum")
    public String partnerNum;

    // 伙伴类型id列表
    @NameInMap("labelIds")
    public java.util.List<String> labelIds;

    public static SetDeptPartnerTypeAndNumRequest build(java.util.Map<String, ?> map) throws Exception {
        SetDeptPartnerTypeAndNumRequest self = new SetDeptPartnerTypeAndNumRequest();
        return TeaModel.build(map, self);
    }

    public SetDeptPartnerTypeAndNumRequest setDeptId(String deptId) {
        this.deptId = deptId;
        return this;
    }
    public String getDeptId() {
        return this.deptId;
    }

    public SetDeptPartnerTypeAndNumRequest setPartnerNum(String partnerNum) {
        this.partnerNum = partnerNum;
        return this;
    }
    public String getPartnerNum() {
        return this.partnerNum;
    }

    public SetDeptPartnerTypeAndNumRequest setLabelIds(java.util.List<String> labelIds) {
        this.labelIds = labelIds;
        return this;
    }
    public java.util.List<String> getLabelIds() {
        return this.labelIds;
    }

}
