// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyDeleteMemberRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("deptId")
    public Long deptId;

    @NameInMap("mobile")
    public String mobile;

    @NameInMap("unionId")
    public String unionId;

    @NameInMap("userId")
    public String userId;

    public static SupplyDeleteMemberRequest build(java.util.Map<String, ?> map) throws Exception {
        SupplyDeleteMemberRequest self = new SupplyDeleteMemberRequest();
        return TeaModel.build(map, self);
    }

    public SupplyDeleteMemberRequest setDeptId(Long deptId) {
        this.deptId = deptId;
        return this;
    }
    public Long getDeptId() {
        return this.deptId;
    }

    public SupplyDeleteMemberRequest setMobile(String mobile) {
        this.mobile = mobile;
        return this;
    }
    public String getMobile() {
        return this.mobile;
    }

    public SupplyDeleteMemberRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public SupplyDeleteMemberRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
