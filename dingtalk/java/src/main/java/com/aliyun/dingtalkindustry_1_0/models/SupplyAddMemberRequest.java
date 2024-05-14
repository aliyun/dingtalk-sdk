// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyAddMemberRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("isPartnerManager")
    public Boolean isPartnerManager;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("memberMobile")
    public String memberMobile;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("memberName")
    public String memberName;

    @NameInMap("memberTitle")
    public String memberTitle;

    @NameInMap("memberWorkNumber")
    public String memberWorkNumber;

    /**
     * <p>This parameter is required.</p>
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

    public SupplyAddMemberRequest setMemberTitle(String memberTitle) {
        this.memberTitle = memberTitle;
        return this;
    }
    public String getMemberTitle() {
        return this.memberTitle;
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
