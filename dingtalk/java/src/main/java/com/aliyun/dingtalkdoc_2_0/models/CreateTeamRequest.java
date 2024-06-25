// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class CreateTeamRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p><a href="https://img.alicdn.com/imgextra/i1/O1***.png">https://img.alicdn.com/imgextra/i1/O1***.png</a></p>
     */
    @NameInMap("cover")
    public String cover;

    /**
     * <strong>example:</strong>
     * <p>这是小组的介绍</p>
     */
    @NameInMap("description")
    public String description;

    /**
     * <strong>example:</strong>
     * <p><a href="https://img.alicdn.com/imgextra/i1/O1***.png">https://img.alicdn.com/imgextra/i1/O1***.png</a></p>
     */
    @NameInMap("icon")
    public String icon;

    @NameInMap("members")
    public java.util.List<CreateTeamRequestMembers> members;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>测试小组名称</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>YEp3JcM******UIbhwiE</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("teamType")
    public Integer teamType;

    public static CreateTeamRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateTeamRequest self = new CreateTeamRequest();
        return TeaModel.build(map, self);
    }

    public CreateTeamRequest setCover(String cover) {
        this.cover = cover;
        return this;
    }
    public String getCover() {
        return this.cover;
    }

    public CreateTeamRequest setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public CreateTeamRequest setIcon(String icon) {
        this.icon = icon;
        return this;
    }
    public String getIcon() {
        return this.icon;
    }

    public CreateTeamRequest setMembers(java.util.List<CreateTeamRequestMembers> members) {
        this.members = members;
        return this;
    }
    public java.util.List<CreateTeamRequestMembers> getMembers() {
        return this.members;
    }

    public CreateTeamRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public CreateTeamRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public CreateTeamRequest setTeamType(Integer teamType) {
        this.teamType = teamType;
        return this;
    }
    public Integer getTeamType() {
        return this.teamType;
    }

    public static class CreateTeamRequestMembers extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>YEp3JcM******UIbhwiE</p>
         */
        @NameInMap("memberId")
        public String memberId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>2</p>
         */
        @NameInMap("memberType")
        public Integer memberType;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>2</p>
         */
        @NameInMap("roleCode")
        public String roleCode;

        public static CreateTeamRequestMembers build(java.util.Map<String, ?> map) throws Exception {
            CreateTeamRequestMembers self = new CreateTeamRequestMembers();
            return TeaModel.build(map, self);
        }

        public CreateTeamRequestMembers setMemberId(String memberId) {
            this.memberId = memberId;
            return this;
        }
        public String getMemberId() {
            return this.memberId;
        }

        public CreateTeamRequestMembers setMemberType(Integer memberType) {
            this.memberType = memberType;
            return this;
        }
        public Integer getMemberType() {
            return this.memberType;
        }

        public CreateTeamRequestMembers setRoleCode(String roleCode) {
            this.roleCode = roleCode;
            return this;
        }
        public String getRoleCode() {
            return this.roleCode;
        }

    }

}
