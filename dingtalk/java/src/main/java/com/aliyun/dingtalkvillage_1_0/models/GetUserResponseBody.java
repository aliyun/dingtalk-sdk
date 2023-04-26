// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class GetUserResponseBody extends TeaModel {
    @NameInMap("active")
    public Boolean active;

    @NameInMap("admin")
    public Boolean admin;

    @NameInMap("boss")
    public Boolean boss;

    @NameInMap("departmentIdList")
    public java.util.List<Long> departmentIdList;

    @NameInMap("departmentOrderSet")
    public java.util.List<GetUserResponseBodyDepartmentOrderSet> departmentOrderSet;

    @NameInMap("exclusiveAccount")
    public Boolean exclusiveAccount;

    @NameInMap("exclusiveAccountType")
    public String exclusiveAccountType;

    @NameInMap("extension")
    public String extension;

    @NameInMap("hiredDate")
    public Long hiredDate;

    @NameInMap("jobNumber")
    public String jobNumber;

    @NameInMap("leaderInDepartment")
    public java.util.List<GetUserResponseBodyLeaderInDepartment> leaderInDepartment;

    @NameInMap("managerUserId")
    public String managerUserId;

    @NameInMap("name")
    public String name;

    @NameInMap("realAuthed")
    public Boolean realAuthed;

    @NameInMap("remark")
    public String remark;

    @NameInMap("roleList")
    public java.util.List<GetUserResponseBodyRoleList> roleList;

    @NameInMap("senior")
    public Boolean senior;

    @NameInMap("title")
    public String title;

    @NameInMap("unionEmpExt")
    public GetUserResponseBodyUnionEmpExt unionEmpExt;

    @NameInMap("unionId")
    public String unionId;

    @NameInMap("userId")
    public String userId;

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
        @NameInMap("departmentId")
        public Long departmentId;

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
        @NameInMap("departmentId")
        public Long departmentId;

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
        @NameInMap("groupName")
        public String groupName;

        @NameInMap("roleId")
        public Long roleId;

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
        @NameInMap("corpId")
        public String corpId;

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
        @NameInMap("corpId")
        public String corpId;

        @NameInMap("staffId")
        public String staffId;

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
