// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyUpdateMemberRequest extends TeaModel {
    @NameInMap("isCopyDept")
    public Boolean isCopyDept;

    @NameInMap("memberTitle")
    public String memberTitle;

    @NameInMap("memberWorkNumber")
    public String memberWorkNumber;

    @NameInMap("mobile")
    public String mobile;

    @NameInMap("newDeptId")
    public Long newDeptId;

    @NameInMap("oldDeptId")
    public Long oldDeptId;

    @NameInMap("roleIdList")
    public java.util.List<String> roleIdList;

    @NameInMap("unionId")
    public String unionId;

    @NameInMap("userId")
    public String userId;

    public static SupplyUpdateMemberRequest build(java.util.Map<String, ?> map) throws Exception {
        SupplyUpdateMemberRequest self = new SupplyUpdateMemberRequest();
        return TeaModel.build(map, self);
    }

    public SupplyUpdateMemberRequest setIsCopyDept(Boolean isCopyDept) {
        this.isCopyDept = isCopyDept;
        return this;
    }
    public Boolean getIsCopyDept() {
        return this.isCopyDept;
    }

    public SupplyUpdateMemberRequest setMemberTitle(String memberTitle) {
        this.memberTitle = memberTitle;
        return this;
    }
    public String getMemberTitle() {
        return this.memberTitle;
    }

    public SupplyUpdateMemberRequest setMemberWorkNumber(String memberWorkNumber) {
        this.memberWorkNumber = memberWorkNumber;
        return this;
    }
    public String getMemberWorkNumber() {
        return this.memberWorkNumber;
    }

    public SupplyUpdateMemberRequest setMobile(String mobile) {
        this.mobile = mobile;
        return this;
    }
    public String getMobile() {
        return this.mobile;
    }

    public SupplyUpdateMemberRequest setNewDeptId(Long newDeptId) {
        this.newDeptId = newDeptId;
        return this;
    }
    public Long getNewDeptId() {
        return this.newDeptId;
    }

    public SupplyUpdateMemberRequest setOldDeptId(Long oldDeptId) {
        this.oldDeptId = oldDeptId;
        return this;
    }
    public Long getOldDeptId() {
        return this.oldDeptId;
    }

    public SupplyUpdateMemberRequest setRoleIdList(java.util.List<String> roleIdList) {
        this.roleIdList = roleIdList;
        return this;
    }
    public java.util.List<String> getRoleIdList() {
        return this.roleIdList;
    }

    public SupplyUpdateMemberRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public SupplyUpdateMemberRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
