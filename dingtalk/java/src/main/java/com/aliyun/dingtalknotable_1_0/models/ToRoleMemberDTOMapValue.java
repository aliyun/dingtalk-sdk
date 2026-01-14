// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class ToRoleMemberDTOMapValue extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("memberId")
    public String memberId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("memberType")
    public String memberType;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("memberIdBelongOrgId")
    public Long memberIdBelongOrgId;

    @NameInMap("avatar")
    public String avatar;

    @NameInMap("name")
    public String name;

    public static ToRoleMemberDTOMapValue build(java.util.Map<String, ?> map) throws Exception {
        ToRoleMemberDTOMapValue self = new ToRoleMemberDTOMapValue();
        return TeaModel.build(map, self);
    }

    public ToRoleMemberDTOMapValue setMemberId(String memberId) {
        this.memberId = memberId;
        return this;
    }
    public String getMemberId() {
        return this.memberId;
    }

    public ToRoleMemberDTOMapValue setMemberType(String memberType) {
        this.memberType = memberType;
        return this;
    }
    public String getMemberType() {
        return this.memberType;
    }

    public ToRoleMemberDTOMapValue setMemberIdBelongOrgId(Long memberIdBelongOrgId) {
        this.memberIdBelongOrgId = memberIdBelongOrgId;
        return this;
    }
    public Long getMemberIdBelongOrgId() {
        return this.memberIdBelongOrgId;
    }

    public ToRoleMemberDTOMapValue setAvatar(String avatar) {
        this.avatar = avatar;
        return this;
    }
    public String getAvatar() {
        return this.avatar;
    }

    public ToRoleMemberDTOMapValue setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

}
