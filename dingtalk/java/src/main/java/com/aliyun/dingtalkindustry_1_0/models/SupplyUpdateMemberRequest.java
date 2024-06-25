// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyUpdateMemberRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("isCopyDept")
    public Boolean isCopyDept;

    /**
     * <strong>example:</strong>
     * <p>财务</p>
     */
    @NameInMap("memberTitle")
    public String memberTitle;

    /**
     * <strong>example:</strong>
     * <p>121212</p>
     */
    @NameInMap("memberWorkNumber")
    public String memberWorkNumber;

    /**
     * <strong>example:</strong>
     * <p>13914772100</p>
     */
    @NameInMap("mobile")
    public String mobile;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>11</p>
     */
    @NameInMap("newDeptId")
    public Long newDeptId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>111</p>
     */
    @NameInMap("oldDeptId")
    public Long oldDeptId;

    @NameInMap("roleIdList")
    public java.util.List<String> roleIdList;

    /**
     * <strong>example:</strong>
     * <p>111</p>
     */
    @NameInMap("unionId")
    public String unionId;

    /**
     * <strong>example:</strong>
     * <p>1212</p>
     */
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
