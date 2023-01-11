// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class GetUserResponseBody extends TeaModel {
    /**
     * <p>是否激活</p>
     */
    @NameInMap("active")
    public Boolean active;

    /**
     * <p>是否管理员</p>
     */
    @NameInMap("admin")
    public Boolean admin;

    /**
     * <p>是否老板</p>
     */
    @NameInMap("boss")
    public Boolean boss;

    /**
     * <p>所属部门id列表</p>
     */
    @NameInMap("departmentIdList")
    public java.util.List<Long> departmentIdList;

    /**
     * <p>员工在对应的部门中的排序。</p>
     */
    @NameInMap("departmentOrderSet")
    public java.util.List<GetUserResponseBodyDepartmentOrderSet> departmentOrderSet;

    /**
     * <p>是否专属帐号</p>
     */
    @NameInMap("exclusiveAccount")
    public Boolean exclusiveAccount;

    /**
     * <p>专属帐号类型：{sso: 企业自定义idp;dingtalk: 钉钉idp}</p>
     */
    @NameInMap("exclusiveAccountType")
    public String exclusiveAccountType;

    /**
     * <p>扩展属性，长度最大2000个字符。可以设置多种属性（手机上最多显示10个扩展属性，具体显示哪些属性，请到OA管理后台->设置->通讯录信息设置和OA管理后台->设置->手机端显示信息设置）。 该字段的值支持链接类型填写，同时链接支持变量通配符自动替换，目前支持通配符有：userid，corpid。示例： [工位地址](http://www.dingtalk.com?userid=#userid#&corpid=#corpid#)</p>
     */
    @NameInMap("extension")
    public String extension;

    /**
     * <p>入职时间，Unix时间戳，单位ms。</p>
     */
    @NameInMap("hiredDate")
    public Long hiredDate;

    /**
     * <p>员工工号</p>
     */
    @NameInMap("jobNumber")
    public String jobNumber;

    /**
     * <p>员工在对应的部门中是否领导。</p>
     */
    @NameInMap("leaderInDepartment")
    public java.util.List<GetUserResponseBodyLeaderInDepartment> leaderInDepartment;

    /**
     * <p>主管的ID，仅限企业内部开发调用</p>
     */
    @NameInMap("managerUserId")
    public String managerUserId;

    /**
     * <p>姓名</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>是否实名认证</p>
     */
    @NameInMap("realAuthed")
    public Boolean realAuthed;

    /**
     * <p>备注</p>
     */
    @NameInMap("remark")
    public String remark;

    /**
     * <p>角色列表</p>
     */
    @NameInMap("roleList")
    public java.util.List<GetUserResponseBodyRoleList> roleList;

    /**
     * <p>是否高管</p>
     */
    @NameInMap("senior")
    public Boolean senior;

    /**
     * <p>职位</p>
     */
    @NameInMap("title")
    public String title;

    /**
     * <p>关联信息</p>
     */
    @NameInMap("unionEmpExt")
    public GetUserResponseBodyUnionEmpExt unionEmpExt;

    /**
     * <p>员工在当前开发者企业账号范围内的唯一标识</p>
     */
    @NameInMap("unionId")
    public String unionId;

    /**
     * <p>用户id</p>
     */
    @NameInMap("userId")
    public String userId;

    /**
     * <p>办公地点</p>
     */
    @NameInMap("workPlace")
    public String workPlace;

    public static GetUserResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetUserResponseBody self = new GetUserResponseBody();
        return TeaModel.build(map, self);
    }

    public GetUserResponseBody setActive(Boolean active) {
        this.active = active;
        return this;
    }
    public Boolean getActive() {
        return this.active;
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

    public GetUserResponseBody setDepartmentIdList(java.util.List<Long> departmentIdList) {
        this.departmentIdList = departmentIdList;
        return this;
    }
    public java.util.List<Long> getDepartmentIdList() {
        return this.departmentIdList;
    }

    public GetUserResponseBody setDepartmentOrderSet(java.util.List<GetUserResponseBodyDepartmentOrderSet> departmentOrderSet) {
        this.departmentOrderSet = departmentOrderSet;
        return this;
    }
    public java.util.List<GetUserResponseBodyDepartmentOrderSet> getDepartmentOrderSet() {
        return this.departmentOrderSet;
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

    public GetUserResponseBody setJobNumber(String jobNumber) {
        this.jobNumber = jobNumber;
        return this;
    }
    public String getJobNumber() {
        return this.jobNumber;
    }

    public GetUserResponseBody setLeaderInDepartment(java.util.List<GetUserResponseBodyLeaderInDepartment> leaderInDepartment) {
        this.leaderInDepartment = leaderInDepartment;
        return this;
    }
    public java.util.List<GetUserResponseBodyLeaderInDepartment> getLeaderInDepartment() {
        return this.leaderInDepartment;
    }

    public GetUserResponseBody setManagerUserId(String managerUserId) {
        this.managerUserId = managerUserId;
        return this;
    }
    public String getManagerUserId() {
        return this.managerUserId;
    }

    public GetUserResponseBody setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public GetUserResponseBody setRealAuthed(Boolean realAuthed) {
        this.realAuthed = realAuthed;
        return this;
    }
    public Boolean getRealAuthed() {
        return this.realAuthed;
    }

    public GetUserResponseBody setRemark(String remark) {
        this.remark = remark;
        return this;
    }
    public String getRemark() {
        return this.remark;
    }

    public GetUserResponseBody setRoleList(java.util.List<GetUserResponseBodyRoleList> roleList) {
        this.roleList = roleList;
        return this;
    }
    public java.util.List<GetUserResponseBodyRoleList> getRoleList() {
        return this.roleList;
    }

    public GetUserResponseBody setSenior(Boolean senior) {
        this.senior = senior;
        return this;
    }
    public Boolean getSenior() {
        return this.senior;
    }

    public GetUserResponseBody setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public GetUserResponseBody setUnionEmpExt(GetUserResponseBodyUnionEmpExt unionEmpExt) {
        this.unionEmpExt = unionEmpExt;
        return this;
    }
    public GetUserResponseBodyUnionEmpExt getUnionEmpExt() {
        return this.unionEmpExt;
    }

    public GetUserResponseBody setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public GetUserResponseBody setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public GetUserResponseBody setWorkPlace(String workPlace) {
        this.workPlace = workPlace;
        return this;
    }
    public String getWorkPlace() {
        return this.workPlace;
    }

    public static class GetUserResponseBodyDepartmentOrderSet extends TeaModel {
        /**
         * <p>下属组织的部门ID</p>
         */
        @NameInMap("departmentId")
        public Long departmentId;

        /**
         * <p>员工在部门中的排序。</p>
         */
        @NameInMap("order")
        public Long order;

        public static GetUserResponseBodyDepartmentOrderSet build(java.util.Map<String, ?> map) throws Exception {
            GetUserResponseBodyDepartmentOrderSet self = new GetUserResponseBodyDepartmentOrderSet();
            return TeaModel.build(map, self);
        }

        public GetUserResponseBodyDepartmentOrderSet setDepartmentId(Long departmentId) {
            this.departmentId = departmentId;
            return this;
        }
        public Long getDepartmentId() {
            return this.departmentId;
        }

        public GetUserResponseBodyDepartmentOrderSet setOrder(Long order) {
            this.order = order;
            return this;
        }
        public Long getOrder() {
            return this.order;
        }

    }

    public static class GetUserResponseBodyLeaderInDepartment extends TeaModel {
        /**
         * <p>下属组织的部门ID</p>
         */
        @NameInMap("departmentId")
        public Long departmentId;

        /**
         * <p>员工在对应的部门中是否领导</p>
         */
        @NameInMap("leader")
        public Boolean leader;

        public static GetUserResponseBodyLeaderInDepartment build(java.util.Map<String, ?> map) throws Exception {
            GetUserResponseBodyLeaderInDepartment self = new GetUserResponseBodyLeaderInDepartment();
            return TeaModel.build(map, self);
        }

        public GetUserResponseBodyLeaderInDepartment setDepartmentId(Long departmentId) {
            this.departmentId = departmentId;
            return this;
        }
        public Long getDepartmentId() {
            return this.departmentId;
        }

        public GetUserResponseBodyLeaderInDepartment setLeader(Boolean leader) {
            this.leader = leader;
            return this;
        }
        public Boolean getLeader() {
            return this.leader;
        }

    }

    public static class GetUserResponseBodyRoleList extends TeaModel {
        /**
         * <p>角色组名称</p>
         */
        @NameInMap("groupName")
        public String groupName;

        /**
         * <p>角色id</p>
         */
        @NameInMap("roleId")
        public Long roleId;

        /**
         * <p>角色名称</p>
         */
        @NameInMap("roleName")
        public String roleName;

        public static GetUserResponseBodyRoleList build(java.util.Map<String, ?> map) throws Exception {
            GetUserResponseBodyRoleList self = new GetUserResponseBodyRoleList();
            return TeaModel.build(map, self);
        }

        public GetUserResponseBodyRoleList setGroupName(String groupName) {
            this.groupName = groupName;
            return this;
        }
        public String getGroupName() {
            return this.groupName;
        }

        public GetUserResponseBodyRoleList setRoleId(Long roleId) {
            this.roleId = roleId;
            return this;
        }
        public Long getRoleId() {
            return this.roleId;
        }

        public GetUserResponseBodyRoleList setRoleName(String roleName) {
            this.roleName = roleName;
            return this;
        }
        public String getRoleName() {
            return this.roleName;
        }

    }

    public static class GetUserResponseBodyUnionEmpExtUnionEmpMapList extends TeaModel {
        /**
         * <p>企业 id</p>
         */
        @NameInMap("corpId")
        public String corpId;

        /**
         * <p>员工 id</p>
         */
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
        /**
         * <p>企业id</p>
         */
        @NameInMap("corpId")
        public String corpId;

        /**
         * <p>员工id</p>
         */
        @NameInMap("staffId")
        public String staffId;

        /**
         * <p>关联映射关系</p>
         */
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
