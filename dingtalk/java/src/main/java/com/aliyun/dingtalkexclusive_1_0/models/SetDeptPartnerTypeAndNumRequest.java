// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class SetDeptPartnerTypeAndNumRequest extends TeaModel {
    /**
     * <p>部门id</p>
     */
    @NameInMap("deptId")
    public String deptId;

    /**
     * <p>伙伴类型id列表</p>
     */
    @NameInMap("labelIds")
    public java.util.List<String> labelIds;

    /**
     * <p>伙伴编码</p>
     */
    @NameInMap("partnerNum")
    public String partnerNum;

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

    public SetDeptPartnerTypeAndNumRequest setLabelIds(java.util.List<String> labelIds) {
        this.labelIds = labelIds;
        return this;
    }
    public java.util.List<String> getLabelIds() {
        return this.labelIds;
    }

    public SetDeptPartnerTypeAndNumRequest setPartnerNum(String partnerNum) {
        this.partnerNum = partnerNum;
        return this;
    }
    public String getPartnerNum() {
        return this.partnerNum;
    }

}
