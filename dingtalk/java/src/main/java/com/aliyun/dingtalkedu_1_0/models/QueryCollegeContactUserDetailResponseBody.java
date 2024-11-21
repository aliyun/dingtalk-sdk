// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryCollegeContactUserDetailResponseBody extends TeaModel {
    @NameInMap("result")
    public QueryCollegeContactUserDetailResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static QueryCollegeContactUserDetailResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryCollegeContactUserDetailResponseBody self = new QueryCollegeContactUserDetailResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryCollegeContactUserDetailResponseBody setResult(QueryCollegeContactUserDetailResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryCollegeContactUserDetailResponseBodyResult getResult() {
        return this.result;
    }

    public QueryCollegeContactUserDetailResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class QueryCollegeContactUserDetailResponseBodyResultDeptOrderList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>123456</p>
         */
        @NameInMap("deptId")
        public Long deptId;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("order")
        public Integer order;

        public static QueryCollegeContactUserDetailResponseBodyResultDeptOrderList build(java.util.Map<String, ?> map) throws Exception {
            QueryCollegeContactUserDetailResponseBodyResultDeptOrderList self = new QueryCollegeContactUserDetailResponseBodyResultDeptOrderList();
            return TeaModel.build(map, self);
        }

        public QueryCollegeContactUserDetailResponseBodyResultDeptOrderList setDeptId(Long deptId) {
            this.deptId = deptId;
            return this;
        }
        public Long getDeptId() {
            return this.deptId;
        }

        public QueryCollegeContactUserDetailResponseBodyResultDeptOrderList setOrder(Integer order) {
            this.order = order;
            return this;
        }
        public Integer getOrder() {
            return this.order;
        }

    }

    public static class QueryCollegeContactUserDetailResponseBodyResultDeptPositionSet extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>123456</p>
         */
        @NameInMap("deptId")
        public Long deptId;

        @NameInMap("isMain")
        public Boolean isMain;

        /**
         * <strong>example:</strong>
         * <p>001</p>
         */
        @NameInMap("managerUserId")
        public String managerUserId;

        /**
         * <strong>example:</strong>
         * <p>学工处处长</p>
         */
        @NameInMap("title")
        public String title;

        /**
         * <strong>example:</strong>
         * <p>学工处办公室</p>
         */
        @NameInMap("workPlace")
        public String workPlace;

        public static QueryCollegeContactUserDetailResponseBodyResultDeptPositionSet build(java.util.Map<String, ?> map) throws Exception {
            QueryCollegeContactUserDetailResponseBodyResultDeptPositionSet self = new QueryCollegeContactUserDetailResponseBodyResultDeptPositionSet();
            return TeaModel.build(map, self);
        }

        public QueryCollegeContactUserDetailResponseBodyResultDeptPositionSet setDeptId(Long deptId) {
            this.deptId = deptId;
            return this;
        }
        public Long getDeptId() {
            return this.deptId;
        }

        public QueryCollegeContactUserDetailResponseBodyResultDeptPositionSet setIsMain(Boolean isMain) {
            this.isMain = isMain;
            return this;
        }
        public Boolean getIsMain() {
            return this.isMain;
        }

        public QueryCollegeContactUserDetailResponseBodyResultDeptPositionSet setManagerUserId(String managerUserId) {
            this.managerUserId = managerUserId;
            return this;
        }
        public String getManagerUserId() {
            return this.managerUserId;
        }

        public QueryCollegeContactUserDetailResponseBodyResultDeptPositionSet setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public QueryCollegeContactUserDetailResponseBodyResultDeptPositionSet setWorkPlace(String workPlace) {
            this.workPlace = workPlace;
            return this;
        }
        public String getWorkPlace() {
            return this.workPlace;
        }

    }

    public static class QueryCollegeContactUserDetailResponseBodyResultDeptTypeSet extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>123456</p>
         */
        @NameInMap("deptId")
        public Long deptId;

        /**
         * <strong>example:</strong>
         * <p>土木202班</p>
         */
        @NameInMap("deptName")
        public String deptName;

        /**
         * <strong>example:</strong>
         * <p>stru_standard_dept</p>
         */
        @NameInMap("deptStructType")
        public String deptStructType;

        /**
         * <strong>example:</strong>
         * <p>contact_class_dept</p>
         */
        @NameInMap("deptType")
        public String deptType;

        /**
         * <strong>example:</strong>
         * <p>10000</p>
         */
        @NameInMap("structDeptId")
        public Long structDeptId;

        public static QueryCollegeContactUserDetailResponseBodyResultDeptTypeSet build(java.util.Map<String, ?> map) throws Exception {
            QueryCollegeContactUserDetailResponseBodyResultDeptTypeSet self = new QueryCollegeContactUserDetailResponseBodyResultDeptTypeSet();
            return TeaModel.build(map, self);
        }

        public QueryCollegeContactUserDetailResponseBodyResultDeptTypeSet setDeptId(Long deptId) {
            this.deptId = deptId;
            return this;
        }
        public Long getDeptId() {
            return this.deptId;
        }

        public QueryCollegeContactUserDetailResponseBodyResultDeptTypeSet setDeptName(String deptName) {
            this.deptName = deptName;
            return this;
        }
        public String getDeptName() {
            return this.deptName;
        }

        public QueryCollegeContactUserDetailResponseBodyResultDeptTypeSet setDeptStructType(String deptStructType) {
            this.deptStructType = deptStructType;
            return this;
        }
        public String getDeptStructType() {
            return this.deptStructType;
        }

        public QueryCollegeContactUserDetailResponseBodyResultDeptTypeSet setDeptType(String deptType) {
            this.deptType = deptType;
            return this;
        }
        public String getDeptType() {
            return this.deptType;
        }

        public QueryCollegeContactUserDetailResponseBodyResultDeptTypeSet setStructDeptId(Long structDeptId) {
            this.structDeptId = structDeptId;
            return this;
        }
        public Long getStructDeptId() {
            return this.structDeptId;
        }

    }

    public static class QueryCollegeContactUserDetailResponseBodyResultLeaderInDept extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>123456</p>
         */
        @NameInMap("deptId")
        public Long deptId;

        @NameInMap("leader")
        public Boolean leader;

        public static QueryCollegeContactUserDetailResponseBodyResultLeaderInDept build(java.util.Map<String, ?> map) throws Exception {
            QueryCollegeContactUserDetailResponseBodyResultLeaderInDept self = new QueryCollegeContactUserDetailResponseBodyResultLeaderInDept();
            return TeaModel.build(map, self);
        }

        public QueryCollegeContactUserDetailResponseBodyResultLeaderInDept setDeptId(Long deptId) {
            this.deptId = deptId;
            return this;
        }
        public Long getDeptId() {
            return this.deptId;
        }

        public QueryCollegeContactUserDetailResponseBodyResultLeaderInDept setLeader(Boolean leader) {
            this.leader = leader;
            return this;
        }
        public Boolean getLeader() {
            return this.leader;
        }

    }

    public static class QueryCollegeContactUserDetailResponseBodyResultRoleList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>职务</p>
         */
        @NameInMap("groupName")
        public String groupName;

        /**
         * <strong>example:</strong>
         * <p>100</p>
         */
        @NameInMap("id")
        public Long id;

        /**
         * <strong>example:</strong>
         * <p>宿舍长</p>
         */
        @NameInMap("name")
        public String name;

        public static QueryCollegeContactUserDetailResponseBodyResultRoleList build(java.util.Map<String, ?> map) throws Exception {
            QueryCollegeContactUserDetailResponseBodyResultRoleList self = new QueryCollegeContactUserDetailResponseBodyResultRoleList();
            return TeaModel.build(map, self);
        }

        public QueryCollegeContactUserDetailResponseBodyResultRoleList setGroupName(String groupName) {
            this.groupName = groupName;
            return this;
        }
        public String getGroupName() {
            return this.groupName;
        }

        public QueryCollegeContactUserDetailResponseBodyResultRoleList setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public QueryCollegeContactUserDetailResponseBodyResultRoleList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

    public static class QueryCollegeContactUserDetailResponseBodyResultUnionEmpExtUnionEmpMapList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>dingxxx</p>
         */
        @NameInMap("corpId")
        public String corpId;

        /**
         * <strong>example:</strong>
         * <p>5000</p>
         */
        @NameInMap("userid")
        public String userid;

        public static QueryCollegeContactUserDetailResponseBodyResultUnionEmpExtUnionEmpMapList build(java.util.Map<String, ?> map) throws Exception {
            QueryCollegeContactUserDetailResponseBodyResultUnionEmpExtUnionEmpMapList self = new QueryCollegeContactUserDetailResponseBodyResultUnionEmpExtUnionEmpMapList();
            return TeaModel.build(map, self);
        }

        public QueryCollegeContactUserDetailResponseBodyResultUnionEmpExtUnionEmpMapList setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public QueryCollegeContactUserDetailResponseBodyResultUnionEmpExtUnionEmpMapList setUserid(String userid) {
            this.userid = userid;
            return this;
        }
        public String getUserid() {
            return this.userid;
        }

    }

    public static class QueryCollegeContactUserDetailResponseBodyResultUnionEmpExt extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>dingxxx</p>
         */
        @NameInMap("corpId")
        public String corpId;

        @NameInMap("unionEmpMapList")
        public java.util.List<QueryCollegeContactUserDetailResponseBodyResultUnionEmpExtUnionEmpMapList> unionEmpMapList;

        /**
         * <strong>example:</strong>
         * <p>500</p>
         */
        @NameInMap("userid")
        public String userid;

        public static QueryCollegeContactUserDetailResponseBodyResultUnionEmpExt build(java.util.Map<String, ?> map) throws Exception {
            QueryCollegeContactUserDetailResponseBodyResultUnionEmpExt self = new QueryCollegeContactUserDetailResponseBodyResultUnionEmpExt();
            return TeaModel.build(map, self);
        }

        public QueryCollegeContactUserDetailResponseBodyResultUnionEmpExt setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public QueryCollegeContactUserDetailResponseBodyResultUnionEmpExt setUnionEmpMapList(java.util.List<QueryCollegeContactUserDetailResponseBodyResultUnionEmpExtUnionEmpMapList> unionEmpMapList) {
            this.unionEmpMapList = unionEmpMapList;
            return this;
        }
        public java.util.List<QueryCollegeContactUserDetailResponseBodyResultUnionEmpExtUnionEmpMapList> getUnionEmpMapList() {
            return this.unionEmpMapList;
        }

        public QueryCollegeContactUserDetailResponseBodyResultUnionEmpExt setUserid(String userid) {
            this.userid = userid;
            return this;
        }
        public String getUserid() {
            return this.userid;
        }

    }

    public static class QueryCollegeContactUserDetailResponseBodyResult extends TeaModel {
        @NameInMap("active")
        public Boolean active;

        @NameInMap("admin")
        public Boolean admin;

        /**
         * <strong>example:</strong>
         * <p>xxxxxx</p>
         */
        @NameInMap("avatar")
        public String avatar;

        @NameInMap("boss")
        public Boolean boss;

        @NameInMap("deptIdList")
        public java.util.List<Long> deptIdList;

        @NameInMap("deptOrderList")
        public java.util.List<QueryCollegeContactUserDetailResponseBodyResultDeptOrderList> deptOrderList;

        @NameInMap("deptPositionSet")
        public java.util.List<QueryCollegeContactUserDetailResponseBodyResultDeptPositionSet> deptPositionSet;

        @NameInMap("deptTypeSet")
        public java.util.List<QueryCollegeContactUserDetailResponseBodyResultDeptTypeSet> deptTypeSet;

        /**
         * <strong>example:</strong>
         * <p><a href="mailto:test@xxx.com">test@xxx.com</a></p>
         */
        @NameInMap("email")
        public String email;

        /**
         * <strong>example:</strong>
         * <p>college_student</p>
         */
        @NameInMap("empType")
        public String empType;

        @NameInMap("exclusiveAccount")
        public Boolean exclusiveAccount;

        @NameInMap("exclusiveAccountCorpId")
        public String exclusiveAccountCorpId;

        /**
         * <strong>example:</strong>
         * <p>组织名称</p>
         */
        @NameInMap("exclusiveAccountCorpName")
        public String exclusiveAccountCorpName;

        /**
         * <strong>example:</strong>
         * <p>dingtalk</p>
         */
        @NameInMap("exclusiveAccountType")
        public String exclusiveAccountType;

        /**
         * <strong>example:</strong>
         * <p>{&quot;学号&quot;:&quot;12122294&quot;,&quot;在校状态&quot;:&quot;新生&quot;,&quot;学生类别&quot;:&quot;本科生&quot;,&quot;考生号&quot;:&quot;999888&quot;}</p>
         */
        @NameInMap("extension")
        public String extension;

        @NameInMap("hideMobile")
        public Boolean hideMobile;

        /**
         * <strong>example:</strong>
         * <p>1597573616828</p>
         */
        @NameInMap("hiredDate")
        public Long hiredDate;

        /**
         * <strong>example:</strong>
         * <p>12122294</p>
         */
        @NameInMap("jobNumber")
        public String jobNumber;

        @NameInMap("leaderInDept")
        public java.util.List<QueryCollegeContactUserDetailResponseBodyResultLeaderInDept> leaderInDept;

        /**
         * <strong>example:</strong>
         * <p>12122294</p>
         */
        @NameInMap("loginId")
        public String loginId;

        /**
         * <strong>example:</strong>
         * <p>studentNo</p>
         */
        @NameInMap("loginType")
        public String loginType;

        /**
         * <strong>example:</strong>
         * <p>123456</p>
         */
        @NameInMap("mainDeptId")
        public Long mainDeptId;

        /**
         * <strong>example:</strong>
         * <p>111111</p>
         */
        @NameInMap("managerUserid")
        public String managerUserid;

        /**
         * <strong>example:</strong>
         * <p>188****4567</p>
         */
        @NameInMap("mobile")
        public String mobile;

        /**
         * <strong>example:</strong>
         * <p>张三</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p><a href="mailto:test@xxx.com">test@xxx.com</a></p>
         */
        @NameInMap("orgEmail")
        public String orgEmail;

        /**
         * <strong>example:</strong>
         * <p>profession</p>
         */
        @NameInMap("orgEmailType")
        public String orgEmailType;

        @NameInMap("realAuthed")
        public Boolean realAuthed;

        /**
         * <strong>example:</strong>
         * <p>这是一个备注</p>
         */
        @NameInMap("remark")
        public String remark;

        @NameInMap("roleList")
        public java.util.List<QueryCollegeContactUserDetailResponseBodyResultRoleList> roleList;

        @NameInMap("senior")
        public Boolean senior;

        /**
         * <strong>example:</strong>
         * <p>86</p>
         */
        @NameInMap("stateCode")
        public String stateCode;

        /**
         * <strong>example:</strong>
         * <p>010-86123456-2345</p>
         */
        @NameInMap("telephone")
        public String telephone;

        /**
         * <strong>example:</strong>
         * <p>学工处处长</p>
         */
        @NameInMap("title")
        public String title;

        @NameInMap("unionEmpExt")
        public QueryCollegeContactUserDetailResponseBodyResultUnionEmpExt unionEmpExt;

        /**
         * <strong>example:</strong>
         * <p>z21HjQliSzpw0YWCNxmii6u2Os62cZ62iSZ</p>
         */
        @NameInMap("unionId")
        public String unionId;

        /**
         * <strong>example:</strong>
         * <p>zhangsan666</p>
         */
        @NameInMap("userid")
        public String userid;

        /**
         * <strong>example:</strong>
         * <p>学工处办公室</p>
         */
        @NameInMap("workPlace")
        public String workPlace;

        public static QueryCollegeContactUserDetailResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryCollegeContactUserDetailResponseBodyResult self = new QueryCollegeContactUserDetailResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryCollegeContactUserDetailResponseBodyResult setActive(Boolean active) {
            this.active = active;
            return this;
        }
        public Boolean getActive() {
            return this.active;
        }

        public QueryCollegeContactUserDetailResponseBodyResult setAdmin(Boolean admin) {
            this.admin = admin;
            return this;
        }
        public Boolean getAdmin() {
            return this.admin;
        }

        public QueryCollegeContactUserDetailResponseBodyResult setAvatar(String avatar) {
            this.avatar = avatar;
            return this;
        }
        public String getAvatar() {
            return this.avatar;
        }

        public QueryCollegeContactUserDetailResponseBodyResult setBoss(Boolean boss) {
            this.boss = boss;
            return this;
        }
        public Boolean getBoss() {
            return this.boss;
        }

        public QueryCollegeContactUserDetailResponseBodyResult setDeptIdList(java.util.List<Long> deptIdList) {
            this.deptIdList = deptIdList;
            return this;
        }
        public java.util.List<Long> getDeptIdList() {
            return this.deptIdList;
        }

        public QueryCollegeContactUserDetailResponseBodyResult setDeptOrderList(java.util.List<QueryCollegeContactUserDetailResponseBodyResultDeptOrderList> deptOrderList) {
            this.deptOrderList = deptOrderList;
            return this;
        }
        public java.util.List<QueryCollegeContactUserDetailResponseBodyResultDeptOrderList> getDeptOrderList() {
            return this.deptOrderList;
        }

        public QueryCollegeContactUserDetailResponseBodyResult setDeptPositionSet(java.util.List<QueryCollegeContactUserDetailResponseBodyResultDeptPositionSet> deptPositionSet) {
            this.deptPositionSet = deptPositionSet;
            return this;
        }
        public java.util.List<QueryCollegeContactUserDetailResponseBodyResultDeptPositionSet> getDeptPositionSet() {
            return this.deptPositionSet;
        }

        public QueryCollegeContactUserDetailResponseBodyResult setDeptTypeSet(java.util.List<QueryCollegeContactUserDetailResponseBodyResultDeptTypeSet> deptTypeSet) {
            this.deptTypeSet = deptTypeSet;
            return this;
        }
        public java.util.List<QueryCollegeContactUserDetailResponseBodyResultDeptTypeSet> getDeptTypeSet() {
            return this.deptTypeSet;
        }

        public QueryCollegeContactUserDetailResponseBodyResult setEmail(String email) {
            this.email = email;
            return this;
        }
        public String getEmail() {
            return this.email;
        }

        public QueryCollegeContactUserDetailResponseBodyResult setEmpType(String empType) {
            this.empType = empType;
            return this;
        }
        public String getEmpType() {
            return this.empType;
        }

        public QueryCollegeContactUserDetailResponseBodyResult setExclusiveAccount(Boolean exclusiveAccount) {
            this.exclusiveAccount = exclusiveAccount;
            return this;
        }
        public Boolean getExclusiveAccount() {
            return this.exclusiveAccount;
        }

        public QueryCollegeContactUserDetailResponseBodyResult setExclusiveAccountCorpId(String exclusiveAccountCorpId) {
            this.exclusiveAccountCorpId = exclusiveAccountCorpId;
            return this;
        }
        public String getExclusiveAccountCorpId() {
            return this.exclusiveAccountCorpId;
        }

        public QueryCollegeContactUserDetailResponseBodyResult setExclusiveAccountCorpName(String exclusiveAccountCorpName) {
            this.exclusiveAccountCorpName = exclusiveAccountCorpName;
            return this;
        }
        public String getExclusiveAccountCorpName() {
            return this.exclusiveAccountCorpName;
        }

        public QueryCollegeContactUserDetailResponseBodyResult setExclusiveAccountType(String exclusiveAccountType) {
            this.exclusiveAccountType = exclusiveAccountType;
            return this;
        }
        public String getExclusiveAccountType() {
            return this.exclusiveAccountType;
        }

        public QueryCollegeContactUserDetailResponseBodyResult setExtension(String extension) {
            this.extension = extension;
            return this;
        }
        public String getExtension() {
            return this.extension;
        }

        public QueryCollegeContactUserDetailResponseBodyResult setHideMobile(Boolean hideMobile) {
            this.hideMobile = hideMobile;
            return this;
        }
        public Boolean getHideMobile() {
            return this.hideMobile;
        }

        public QueryCollegeContactUserDetailResponseBodyResult setHiredDate(Long hiredDate) {
            this.hiredDate = hiredDate;
            return this;
        }
        public Long getHiredDate() {
            return this.hiredDate;
        }

        public QueryCollegeContactUserDetailResponseBodyResult setJobNumber(String jobNumber) {
            this.jobNumber = jobNumber;
            return this;
        }
        public String getJobNumber() {
            return this.jobNumber;
        }

        public QueryCollegeContactUserDetailResponseBodyResult setLeaderInDept(java.util.List<QueryCollegeContactUserDetailResponseBodyResultLeaderInDept> leaderInDept) {
            this.leaderInDept = leaderInDept;
            return this;
        }
        public java.util.List<QueryCollegeContactUserDetailResponseBodyResultLeaderInDept> getLeaderInDept() {
            return this.leaderInDept;
        }

        public QueryCollegeContactUserDetailResponseBodyResult setLoginId(String loginId) {
            this.loginId = loginId;
            return this;
        }
        public String getLoginId() {
            return this.loginId;
        }

        public QueryCollegeContactUserDetailResponseBodyResult setLoginType(String loginType) {
            this.loginType = loginType;
            return this;
        }
        public String getLoginType() {
            return this.loginType;
        }

        public QueryCollegeContactUserDetailResponseBodyResult setMainDeptId(Long mainDeptId) {
            this.mainDeptId = mainDeptId;
            return this;
        }
        public Long getMainDeptId() {
            return this.mainDeptId;
        }

        public QueryCollegeContactUserDetailResponseBodyResult setManagerUserid(String managerUserid) {
            this.managerUserid = managerUserid;
            return this;
        }
        public String getManagerUserid() {
            return this.managerUserid;
        }

        public QueryCollegeContactUserDetailResponseBodyResult setMobile(String mobile) {
            this.mobile = mobile;
            return this;
        }
        public String getMobile() {
            return this.mobile;
        }

        public QueryCollegeContactUserDetailResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public QueryCollegeContactUserDetailResponseBodyResult setOrgEmail(String orgEmail) {
            this.orgEmail = orgEmail;
            return this;
        }
        public String getOrgEmail() {
            return this.orgEmail;
        }

        public QueryCollegeContactUserDetailResponseBodyResult setOrgEmailType(String orgEmailType) {
            this.orgEmailType = orgEmailType;
            return this;
        }
        public String getOrgEmailType() {
            return this.orgEmailType;
        }

        public QueryCollegeContactUserDetailResponseBodyResult setRealAuthed(Boolean realAuthed) {
            this.realAuthed = realAuthed;
            return this;
        }
        public Boolean getRealAuthed() {
            return this.realAuthed;
        }

        public QueryCollegeContactUserDetailResponseBodyResult setRemark(String remark) {
            this.remark = remark;
            return this;
        }
        public String getRemark() {
            return this.remark;
        }

        public QueryCollegeContactUserDetailResponseBodyResult setRoleList(java.util.List<QueryCollegeContactUserDetailResponseBodyResultRoleList> roleList) {
            this.roleList = roleList;
            return this;
        }
        public java.util.List<QueryCollegeContactUserDetailResponseBodyResultRoleList> getRoleList() {
            return this.roleList;
        }

        public QueryCollegeContactUserDetailResponseBodyResult setSenior(Boolean senior) {
            this.senior = senior;
            return this;
        }
        public Boolean getSenior() {
            return this.senior;
        }

        public QueryCollegeContactUserDetailResponseBodyResult setStateCode(String stateCode) {
            this.stateCode = stateCode;
            return this;
        }
        public String getStateCode() {
            return this.stateCode;
        }

        public QueryCollegeContactUserDetailResponseBodyResult setTelephone(String telephone) {
            this.telephone = telephone;
            return this;
        }
        public String getTelephone() {
            return this.telephone;
        }

        public QueryCollegeContactUserDetailResponseBodyResult setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public QueryCollegeContactUserDetailResponseBodyResult setUnionEmpExt(QueryCollegeContactUserDetailResponseBodyResultUnionEmpExt unionEmpExt) {
            this.unionEmpExt = unionEmpExt;
            return this;
        }
        public QueryCollegeContactUserDetailResponseBodyResultUnionEmpExt getUnionEmpExt() {
            return this.unionEmpExt;
        }

        public QueryCollegeContactUserDetailResponseBodyResult setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

        public QueryCollegeContactUserDetailResponseBodyResult setUserid(String userid) {
            this.userid = userid;
            return this;
        }
        public String getUserid() {
            return this.userid;
        }

        public QueryCollegeContactUserDetailResponseBodyResult setWorkPlace(String workPlace) {
            this.workPlace = workPlace;
            return this;
        }
        public String getWorkPlace() {
            return this.workPlace;
        }

    }

}
