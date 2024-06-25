// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class EduFindUserRolesByUserIdRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>666666</p>
     */
    @NameInMap("classId")
    public Long classId;

    /**
     * <strong>example:</strong>
     * <p>ding123456</p>
     */
    @NameInMap("corpId")
    public String corpId;

    @NameInMap("hasOrgRole")
    public Boolean hasOrgRole;

    /**
     * <strong>example:</strong>
     * <p>123456</p>
     */
    @NameInMap("userId")
    public String userId;

    public static EduFindUserRolesByUserIdRequest build(java.util.Map<String, ?> map) throws Exception {
        EduFindUserRolesByUserIdRequest self = new EduFindUserRolesByUserIdRequest();
        return TeaModel.build(map, self);
    }

    public EduFindUserRolesByUserIdRequest setClassId(Long classId) {
        this.classId = classId;
        return this;
    }
    public Long getClassId() {
        return this.classId;
    }

    public EduFindUserRolesByUserIdRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public EduFindUserRolesByUserIdRequest setHasOrgRole(Boolean hasOrgRole) {
        this.hasOrgRole = hasOrgRole;
        return this;
    }
    public Boolean getHasOrgRole() {
        return this.hasOrgRole;
    }

    public EduFindUserRolesByUserIdRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
