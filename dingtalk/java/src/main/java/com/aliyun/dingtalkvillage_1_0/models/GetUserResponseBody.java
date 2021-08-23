// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class GetUserResponseBody extends TeaModel {
    // 用户id
    @NameInMap("userId")
    public String userId;

    // 员工在当前开发者企业账号范围内的唯一标识
    @NameInMap("unionId")
    public String unionId;

    // 姓名
    @NameInMap("name")
    public String name;

    // 头像
    @NameInMap("avatar")
    public String avatar;

    // 员工工号
    @NameInMap("jobNumber")
    public String jobNumber;

    // 职位
    @NameInMap("title")
    public String title;

    // 办公地点
    @NameInMap("workPlace")
    public String workPlace;

    // 备注
    @NameInMap("remark")
    public String remark;

    // 所属部门id列表
    @NameInMap("deptIdList")
    public java.util.List<Long> deptIdList;

    // 员工在对应的部门中的排序。
    @NameInMap("deptOrderSet")
    public java.util.List<GetUserResponseBodyDeptOrderSet> deptOrderSet;

    // 扩展属性，长度最大2000个字符。可以设置多种属性（手机上最多显示10个扩展属性，具体显示哪些属性，请到OA管理后台->设置->通讯录信息设置和OA管理后台->设置->手机端显示信息设置）。 该字段的值支持链接类型填写，同时链接支持变量通配符自动替换，目前支持通配符有：userid，corpid。示例： [工位地址](http://www.dingtalk.com?userid=#userid#&corpid=#corpid#)
    @NameInMap("extension")
    public String extension;

    // 入职时间，Unix时间戳，单位ms。
    @NameInMap("hiredDate")
    public Long hiredDate;

    // 是否激活
    @NameInMap("active")
    public Boolean active;

    // 是否实名认证
    @NameInMap("realAuthed")
    public Boolean realAuthed;

    // 是否高管
    @NameInMap("senior")
    public Boolean senior;

    // 是否管理员
    @NameInMap("admin")
    public Boolean admin;

    // 是否老板
    @NameInMap("boss")
    public Boolean boss;

    // 是否专属帐号
    @NameInMap("exclusiveAccount")
    public Boolean exclusiveAccount;

    // 专属帐号类型：{sso: 企业自定义idp;dingtalk: 钉钉idp}
    @NameInMap("exclusiveAccountType")
    public String exclusiveAccountType;

    // 员工在对应的部门中是否领导。
    @NameInMap("leaderInDept")
    public java.util.List<GetUserResponseBodyLeaderInDept> leaderInDept;

    // 角色列表
    @NameInMap("roleList")
    public java.util.List<GetUserResponseBodyRoleList> roleList;

    // 关联信息
    @NameInMap("unionEmpExt")
    public GetUserResponseBodyUnionEmpExt unionEmpExt;

    // 主管的ID，仅限企业内部开发调用
    @NameInMap("managerUserId")
    public String managerUserId;

    public static GetUserResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetUserResponseBody self = new GetUserResponseBody();
        return TeaModel.build(map, self);
    }

    public GetUserResponseBody setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public GetUserResponseBody setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public GetUserResponseBody setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public GetUserResponseBody setAvatar(String avatar) {
        this.avatar = avatar;
        return this;
    }
    public String getAvatar() {
        return this.avatar;
    }

    public GetUserResponseBody setJobNumber(String jobNumber) {
        this.jobNumber = jobNumber;
        return this;
    }
    public String getJobNumber() {
        return this.jobNumber;
    }

    public GetUserResponseBody setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public GetUserResponseBody setWorkPlace(String workPlace) {
        this.workPlace = workPlace;
        return this;
    }
    public String getWorkPlace() {
        return this.workPlace;
    }

    public GetUserResponseBody setRemark(String remark) {
        this.remark = remark;
        return this;
    }
    public String getRemark() {
        return this.remark;
    }

    public GetUserResponseBody setDeptIdList(java.util.List<Long> deptIdList) {
        this.deptIdList = deptIdList;
        return this;
    }
    public java.util.List<Long> getDeptIdList() {
        return this.deptIdList;
    }

    public GetUserResponseBody setDeptOrderSet(java.util.List<GetUserResponseBodyDeptOrderSet> deptOrderSet) {
        this.deptOrderSet = deptOrderSet;
        return this;
    }
    public java.util.List<GetUserResponseBodyDeptOrderSet> getDeptOrderSet() {
        return this.deptOrderSet;
    }

    public GetUserResponseBody setExtension(String extension) {
        this.extension = extension;
        return this;
    }
    public String getExtension() {
        return this.extension;
    }

    public GetUserResponseBody setHiredDate(Long hiredDate) {
        this.hiredDate = hiredDate;
        return this;
    }
    public Long getHiredDate() {
        return this.hiredDate;
    }

    public GetUserResponseBody setActive(Boolean active) {
        this.active = active;
        return this;
    }
    public Boolean getActive() {
        return this.active;
    }

    public GetUserResponseBody setRealAuthed(Boolean realAuthed) {
        this.realAuthed = realAuthed;
        return this;
    }
    public Boolean getRealAuthed() {
        return this.realAuthed;
    }

    public GetUserResponseBody setSenior(Boolean senior) {
        this.senior = senior;
        return this;
    }
    public Boolean getSenior() {
        return this.senior;
    }

    public GetUserResponseBody setAdmin(Boolean admin) {
        this.admin = admin;
        return this;
    }
    public Boolean getAdmin() {
        return this.admin;
    }

    public GetUserResponseBody setBoss(Boolean boss) {
        this.boss = boss;
        return this;
    }
    public Boolean getBoss() {
        return this.boss;
    }

    public GetUserResponseBody setExclusiveAccount(Boolean exclusiveAccount) {
        this.exclusiveAccount = exclusiveAccount;
        return this;
    }
    public Boolean getExclusiveAccount() {
        return this.exclusiveAccount;
    }

    public GetUserResponseBody setExclusiveAccountType(String exclusiveAccountType) {
        this.exclusiveAccountType = exclusiveAccountType;
        return this;
    }
    public String getExclusiveAccountType() {
        return this.exclusiveAccountType;
    }

    public GetUserResponseBody setLeaderInDept(java.util.List<GetUserResponseBodyLeaderInDept> leaderInDept) {
        this.leaderInDept = leaderInDept;
        return this;
    }
    public java.util.List<GetUserResponseBodyLeaderInDept> getLeaderInDept() {
        return this.leaderInDept;
    }

    public GetUserResponseBody setRoleList(java.util.List<GetUserResponseBodyRoleList> roleList) {
        this.roleList = roleList;
        return this;
    }
    public java.util.List<GetUserResponseBodyRoleList> getRoleList() {
        return this.roleList;
    }

    public GetUserResponseBody setUnionEmpExt(GetUserResponseBodyUnionEmpExt unionEmpExt) {
        this.unionEmpExt = unionEmpExt;
        return this;
    }
    public GetUserResponseBodyUnionEmpExt getUnionEmpExt() {
        return this.unionEmpExt;
    }

    public GetUserResponseBody setManagerUserId(String managerUserId) {
        this.managerUserId = managerUserId;
        return this;
    }
    public String getManagerUserId() {
        return this.managerUserId;
    }

    public static class GetUserResponseBodyDeptOrderSet extends TeaModel {
        // 部门id
        @NameInMap("deptId")
        public Long deptId;

        // 员工在部门中的排序。
        @NameInMap("order")
        public Long order;

        public static GetUserResponseBodyDeptOrderSet build(java.util.Map<String, ?> map) throws Exception {
            GetUserResponseBodyDeptOrderSet self = new GetUserResponseBodyDeptOrderSet();
            return TeaModel.build(map, self);
        }

        public GetUserResponseBodyDeptOrderSet setDeptId(Long deptId) {
            this.deptId = deptId;
            return this;
        }
        public Long getDeptId() {
            return this.deptId;
        }

        public GetUserResponseBodyDeptOrderSet setOrder(Long order) {
            this.order = order;
            return this;
        }
        public Long getOrder() {
            return this.order;
        }

    }

    public static class GetUserResponseBodyLeaderInDept extends TeaModel {
        // 部门 id
        @NameInMap("deptId")
        public Long deptId;

        // 员工在对应的部门中是否领导
        @NameInMap("leader")
        public Boolean leader;

        public static GetUserResponseBodyLeaderInDept build(java.util.Map<String, ?> map) throws Exception {
            GetUserResponseBodyLeaderInDept self = new GetUserResponseBodyLeaderInDept();
            return TeaModel.build(map, self);
        }

        public GetUserResponseBodyLeaderInDept setDeptId(Long deptId) {
            this.deptId = deptId;
            return this;
        }
        public Long getDeptId() {
            return this.deptId;
        }

        public GetUserResponseBodyLeaderInDept setLeader(Boolean leader) {
            this.leader = leader;
            return this;
        }
        public Boolean getLeader() {
            return this.leader;
        }

    }

    public static class GetUserResponseBodyRoleList extends TeaModel {
        // 角色id
        @NameInMap("id")
        public Long id;

        // 角色名称
        @NameInMap("name")
        public String name;

        // 角色组名称
        @NameInMap("groupName")
        public String groupName;

        public static GetUserResponseBodyRoleList build(java.util.Map<String, ?> map) throws Exception {
            GetUserResponseBodyRoleList self = new GetUserResponseBodyRoleList();
            return TeaModel.build(map, self);
        }

        public GetUserResponseBodyRoleList setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public GetUserResponseBodyRoleList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetUserResponseBodyRoleList setGroupName(String groupName) {
            this.groupName = groupName;
            return this;
        }
        public String getGroupName() {
            return this.groupName;
        }

    }

    public static class GetUserResponseBodyUnionEmpExtUnionEmpMapList extends TeaModel {
        // 企业 id
        @NameInMap("corpId")
        public String corpId;

        // 员工 id
        @NameInMap("staffId")
        public String staffId;

        public static GetUserResponseBodyUnionEmpExtUnionEmpMapList build(java.util.Map<String, ?> map) throws Exception {
            GetUserResponseBodyUnionEmpExtUnionEmpMapList self = new GetUserResponseBodyUnionEmpExtUnionEmpMapList();
            return TeaModel.build(map, self);
        }

        public GetUserResponseBodyUnionEmpExtUnionEmpMapList setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public GetUserResponseBodyUnionEmpExtUnionEmpMapList setStaffId(String staffId) {
            this.staffId = staffId;
            return this;
        }
        public String getStaffId() {
            return this.staffId;
        }

    }

    public static class GetUserResponseBodyUnionEmpExt extends TeaModel {
        // 企业id
        @NameInMap("corpId")
        public String corpId;

        // 员工id
        @NameInMap("staffId")
        public String staffId;

        // 关联映射关系
        @NameInMap("unionEmpMapList")
        public java.util.List<GetUserResponseBodyUnionEmpExtUnionEmpMapList> unionEmpMapList;

        public static GetUserResponseBodyUnionEmpExt build(java.util.Map<String, ?> map) throws Exception {
            GetUserResponseBodyUnionEmpExt self = new GetUserResponseBodyUnionEmpExt();
            return TeaModel.build(map, self);
        }

        public GetUserResponseBodyUnionEmpExt setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public GetUserResponseBodyUnionEmpExt setStaffId(String staffId) {
            this.staffId = staffId;
            return this;
        }
        public String getStaffId() {
            return this.staffId;
        }

        public GetUserResponseBodyUnionEmpExt setUnionEmpMapList(java.util.List<GetUserResponseBodyUnionEmpExtUnionEmpMapList> unionEmpMapList) {
            this.unionEmpMapList = unionEmpMapList;
            return this;
        }
        public java.util.List<GetUserResponseBodyUnionEmpExtUnionEmpMapList> getUnionEmpMapList() {
            return this.unionEmpMapList;
        }

    }

}
