// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class AddCollegeContactExclusiveRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>@lALPDfmVUw19YdrNA-jNA-g</p>
     */
    @NameInMap("avatarMediaId")
    public String avatarMediaId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("deptIdList")
    public java.util.List<Long> deptIdList;

    @NameInMap("deptOrderList")
    public java.util.List<AddCollegeContactExclusiveRequestDeptOrderList> deptOrderList;

    @NameInMap("deptPositionSet")
    public java.util.List<AddCollegeContactExclusiveRequestDeptPositionSet> deptPositionSet;

    @NameInMap("deptTitleList")
    public java.util.List<AddCollegeContactExclusiveRequestDeptTitleList> deptTitleList;

    /**
     * <strong>example:</strong>
     * <p><a href="mailto:test@xxx.com">test@xxx.com</a></p>
     */
    @NameInMap("email")
    public String email;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>college_student</p>
     */
    @NameInMap("empType")
    public String empType;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("exclusiveAccount")
    public Boolean exclusiveAccount;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>dingtalk</p>
     */
    @NameInMap("exclusiveAccountType")
    public String exclusiveAccountType;

    @NameInMap("exclusiveMobileVerifyStatus")
    public String exclusiveMobileVerifyStatus;

    @NameInMap("extension")
    public java.util.Map<String, String> extension;

    /**
     * <strong>example:</strong>
     * <p>1597573616828</p>
     */
    @NameInMap("hiredDate")
    public Long hiredDate;

    @NameInMap("initPassword")
    public String initPassword;

    /**
     * <strong>example:</strong>
     * <p>666666</p>
     */
    @NameInMap("jobNumber")
    public String jobNumber;

    /**
     * <strong>example:</strong>
     * <p>studentNo</p>
     */
    @NameInMap("loginIdType")
    public String loginIdType;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>123456</p>
     */
    @NameInMap("mainDeptId")
    public Long mainDeptId;

    /**
     * <strong>example:</strong>
     * <p>001</p>
     */
    @NameInMap("managerUserid")
    public String managerUserid;

    /**
     * <strong>example:</strong>
     * <p>185xxxx8888</p>
     */
    @NameInMap("mobile")
    public String mobile;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>张三</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <strong>example:</strong>
     * <p>昵称</p>
     */
    @NameInMap("nickname")
    public String nickname;

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

    /**
     * <strong>example:</strong>
     * <p>备注</p>
     */
    @NameInMap("remark")
    public String remark;

    @NameInMap("sendActiveSms")
    public Boolean sendActiveSms;

    @NameInMap("seniorMode")
    public Boolean seniorMode;

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

    public static AddCollegeContactExclusiveRequest build(java.util.Map<String, ?> map) throws Exception {
        AddCollegeContactExclusiveRequest self = new AddCollegeContactExclusiveRequest();
        return TeaModel.build(map, self);
    }

    public AddCollegeContactExclusiveRequest setAvatarMediaId(String avatarMediaId) {
        this.avatarMediaId = avatarMediaId;
        return this;
    }
    public String getAvatarMediaId() {
        return this.avatarMediaId;
    }

    public AddCollegeContactExclusiveRequest setDeptIdList(java.util.List<Long> deptIdList) {
        this.deptIdList = deptIdList;
        return this;
    }
    public java.util.List<Long> getDeptIdList() {
        return this.deptIdList;
    }

    public AddCollegeContactExclusiveRequest setDeptOrderList(java.util.List<AddCollegeContactExclusiveRequestDeptOrderList> deptOrderList) {
        this.deptOrderList = deptOrderList;
        return this;
    }
    public java.util.List<AddCollegeContactExclusiveRequestDeptOrderList> getDeptOrderList() {
        return this.deptOrderList;
    }

    public AddCollegeContactExclusiveRequest setDeptPositionSet(java.util.List<AddCollegeContactExclusiveRequestDeptPositionSet> deptPositionSet) {
        this.deptPositionSet = deptPositionSet;
        return this;
    }
    public java.util.List<AddCollegeContactExclusiveRequestDeptPositionSet> getDeptPositionSet() {
        return this.deptPositionSet;
    }

    public AddCollegeContactExclusiveRequest setDeptTitleList(java.util.List<AddCollegeContactExclusiveRequestDeptTitleList> deptTitleList) {
        this.deptTitleList = deptTitleList;
        return this;
    }
    public java.util.List<AddCollegeContactExclusiveRequestDeptTitleList> getDeptTitleList() {
        return this.deptTitleList;
    }

    public AddCollegeContactExclusiveRequest setEmail(String email) {
        this.email = email;
        return this;
    }
    public String getEmail() {
        return this.email;
    }

    public AddCollegeContactExclusiveRequest setEmpType(String empType) {
        this.empType = empType;
        return this;
    }
    public String getEmpType() {
        return this.empType;
    }

    public AddCollegeContactExclusiveRequest setExclusiveAccount(Boolean exclusiveAccount) {
        this.exclusiveAccount = exclusiveAccount;
        return this;
    }
    public Boolean getExclusiveAccount() {
        return this.exclusiveAccount;
    }

    public AddCollegeContactExclusiveRequest setExclusiveAccountType(String exclusiveAccountType) {
        this.exclusiveAccountType = exclusiveAccountType;
        return this;
    }
    public String getExclusiveAccountType() {
        return this.exclusiveAccountType;
    }

    public AddCollegeContactExclusiveRequest setExclusiveMobileVerifyStatus(String exclusiveMobileVerifyStatus) {
        this.exclusiveMobileVerifyStatus = exclusiveMobileVerifyStatus;
        return this;
    }
    public String getExclusiveMobileVerifyStatus() {
        return this.exclusiveMobileVerifyStatus;
    }

    public AddCollegeContactExclusiveRequest setExtension(java.util.Map<String, String> extension) {
        this.extension = extension;
        return this;
    }
    public java.util.Map<String, String> getExtension() {
        return this.extension;
    }

    public AddCollegeContactExclusiveRequest setHiredDate(Long hiredDate) {
        this.hiredDate = hiredDate;
        return this;
    }
    public Long getHiredDate() {
        return this.hiredDate;
    }

    public AddCollegeContactExclusiveRequest setInitPassword(String initPassword) {
        this.initPassword = initPassword;
        return this;
    }
    public String getInitPassword() {
        return this.initPassword;
    }

    public AddCollegeContactExclusiveRequest setJobNumber(String jobNumber) {
        this.jobNumber = jobNumber;
        return this;
    }
    public String getJobNumber() {
        return this.jobNumber;
    }

    public AddCollegeContactExclusiveRequest setLoginIdType(String loginIdType) {
        this.loginIdType = loginIdType;
        return this;
    }
    public String getLoginIdType() {
        return this.loginIdType;
    }

    public AddCollegeContactExclusiveRequest setMainDeptId(Long mainDeptId) {
        this.mainDeptId = mainDeptId;
        return this;
    }
    public Long getMainDeptId() {
        return this.mainDeptId;
    }

    public AddCollegeContactExclusiveRequest setManagerUserid(String managerUserid) {
        this.managerUserid = managerUserid;
        return this;
    }
    public String getManagerUserid() {
        return this.managerUserid;
    }

    public AddCollegeContactExclusiveRequest setMobile(String mobile) {
        this.mobile = mobile;
        return this;
    }
    public String getMobile() {
        return this.mobile;
    }

    public AddCollegeContactExclusiveRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public AddCollegeContactExclusiveRequest setNickname(String nickname) {
        this.nickname = nickname;
        return this;
    }
    public String getNickname() {
        return this.nickname;
    }

    public AddCollegeContactExclusiveRequest setOrgEmail(String orgEmail) {
        this.orgEmail = orgEmail;
        return this;
    }
    public String getOrgEmail() {
        return this.orgEmail;
    }

    public AddCollegeContactExclusiveRequest setOrgEmailType(String orgEmailType) {
        this.orgEmailType = orgEmailType;
        return this;
    }
    public String getOrgEmailType() {
        return this.orgEmailType;
    }

    public AddCollegeContactExclusiveRequest setRemark(String remark) {
        this.remark = remark;
        return this;
    }
    public String getRemark() {
        return this.remark;
    }

    public AddCollegeContactExclusiveRequest setSendActiveSms(Boolean sendActiveSms) {
        this.sendActiveSms = sendActiveSms;
        return this;
    }
    public Boolean getSendActiveSms() {
        return this.sendActiveSms;
    }

    public AddCollegeContactExclusiveRequest setSeniorMode(Boolean seniorMode) {
        this.seniorMode = seniorMode;
        return this;
    }
    public Boolean getSeniorMode() {
        return this.seniorMode;
    }

    public AddCollegeContactExclusiveRequest setTelephone(String telephone) {
        this.telephone = telephone;
        return this;
    }
    public String getTelephone() {
        return this.telephone;
    }

    public AddCollegeContactExclusiveRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public AddCollegeContactExclusiveRequest setUserid(String userid) {
        this.userid = userid;
        return this;
    }
    public String getUserid() {
        return this.userid;
    }

    public AddCollegeContactExclusiveRequest setWorkPlace(String workPlace) {
        this.workPlace = workPlace;
        return this;
    }
    public String getWorkPlace() {
        return this.workPlace;
    }

    public static class AddCollegeContactExclusiveRequestDeptOrderList extends TeaModel {
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

        public static AddCollegeContactExclusiveRequestDeptOrderList build(java.util.Map<String, ?> map) throws Exception {
            AddCollegeContactExclusiveRequestDeptOrderList self = new AddCollegeContactExclusiveRequestDeptOrderList();
            return TeaModel.build(map, self);
        }

        public AddCollegeContactExclusiveRequestDeptOrderList setDeptId(Long deptId) {
            this.deptId = deptId;
            return this;
        }
        public Long getDeptId() {
            return this.deptId;
        }

        public AddCollegeContactExclusiveRequestDeptOrderList setOrder(Integer order) {
            this.order = order;
            return this;
        }
        public Integer getOrder() {
            return this.order;
        }

    }

    public static class AddCollegeContactExclusiveRequestDeptPositionSet extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>123456</p>
         */
        @NameInMap("deptId")
        public Long deptId;

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

        public static AddCollegeContactExclusiveRequestDeptPositionSet build(java.util.Map<String, ?> map) throws Exception {
            AddCollegeContactExclusiveRequestDeptPositionSet self = new AddCollegeContactExclusiveRequestDeptPositionSet();
            return TeaModel.build(map, self);
        }

        public AddCollegeContactExclusiveRequestDeptPositionSet setDeptId(Long deptId) {
            this.deptId = deptId;
            return this;
        }
        public Long getDeptId() {
            return this.deptId;
        }

        public AddCollegeContactExclusiveRequestDeptPositionSet setManagerUserId(String managerUserId) {
            this.managerUserId = managerUserId;
            return this;
        }
        public String getManagerUserId() {
            return this.managerUserId;
        }

        public AddCollegeContactExclusiveRequestDeptPositionSet setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public AddCollegeContactExclusiveRequestDeptPositionSet setWorkPlace(String workPlace) {
            this.workPlace = workPlace;
            return this;
        }
        public String getWorkPlace() {
            return this.workPlace;
        }

    }

    public static class AddCollegeContactExclusiveRequestDeptTitleList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>123456</p>
         */
        @NameInMap("deptId")
        public Long deptId;

        /**
         * <strong>example:</strong>
         * <p>学工处处长</p>
         */
        @NameInMap("title")
        public String title;

        public static AddCollegeContactExclusiveRequestDeptTitleList build(java.util.Map<String, ?> map) throws Exception {
            AddCollegeContactExclusiveRequestDeptTitleList self = new AddCollegeContactExclusiveRequestDeptTitleList();
            return TeaModel.build(map, self);
        }

        public AddCollegeContactExclusiveRequestDeptTitleList setDeptId(Long deptId) {
            this.deptId = deptId;
            return this;
        }
        public Long getDeptId() {
            return this.deptId;
        }

        public AddCollegeContactExclusiveRequestDeptTitleList setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

}
