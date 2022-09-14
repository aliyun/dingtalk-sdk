// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class CreateTeamRequest extends TeaModel {
    // 小组封面。
    @NameInMap("cover")
    public String cover;

    // 小组介绍。
    @NameInMap("description")
    public String description;

    // 小组图标。
    @NameInMap("icon")
    public String icon;

    // 小组成员列表。
    @NameInMap("members")
    public java.util.List<CreateTeamRequestMembers> members;

    // 小组名称。
    @NameInMap("name")
    public String name;

    // 操作人unionId。
    @NameInMap("operatorId")
    public String operatorId;

    // 小组类型。
    // 0-默认；
    // 1-部门；
    // 2-项目组；
    // 3-兴趣小组。
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
        // 成员unionId。
        @NameInMap("memberId")
        public String memberId;

        // 成员类型。
        // 1-群；2-用户；3-组织；4-部门；5-虚拟组织；6-通讯录角色组。
        @NameInMap("memberType")
        public Integer memberType;

        // 成员角色。
        // 0-无权限；1-只读；2-只读/下载；3-编辑；4-管理员；5-所有者。
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
