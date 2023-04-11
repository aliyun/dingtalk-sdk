// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyAddMemberRequest extends TeaModel {
    /**
     * <p>是否为伙伴负责人</p>
     */
    @NameInMap("isPartnerManager")
    public Boolean isPartnerManager;

    /**
     * <p>成员手机号</p>
     */
    @NameInMap("memberMobile")
    public String memberMobile;

    /**
     * <p>成员名字</p>
     */
    @NameInMap("memberName")
    public String memberName;

    /**
     * <p>成员编码/工号</p>
     */
    @NameInMap("memberWorkNumber")
    public String memberWorkNumber;

    /**
     * <p>所属伙伴/子部门</p>
     */
    @NameInMap("supplyDeptId")
    public Long supplyDeptId;

    public static SupplyAddMemberRequest build(java.util.Map<String, ?> map) throws Exception {
        SupplyAddMemberRequest self = new SupplyAddMemberRequest();
        return TeaModel.build(map, self);
    }

    public SupplyAddMemberRequest setIsPartnerManager(Boolean isPartnerManager) {
        this.isPartnerManager = isPartnerManager;
        return this;
    }
    public Boolean getIsPartnerManager() {
        return this.isPartnerManager;
    }

    public SupplyAddMemberRequest setMemberMobile(String memberMobile) {
        this.memberMobile = memberMobile;
        return this;
    }
    public String getMemberMobile() {
        return this.memberMobile;
    }

    public SupplyAddMemberRequest setMemberName(String memberName) {
        this.memberName = memberName;
        return this;
    }
    public String getMemberName() {
        return this.memberName;
    }

    public SupplyAddMemberRequest setMemberWorkNumber(String memberWorkNumber) {
        this.memberWorkNumber = memberWorkNumber;
        return this;
    }
    public String getMemberWorkNumber() {
        return this.memberWorkNumber;
    }

    public SupplyAddMemberRequest setSupplyDeptId(Long supplyDeptId) {
        this.supplyDeptId = supplyDeptId;
        return this;
    }
    public Long getSupplyDeptId() {
        return this.supplyDeptId;
    }

}
