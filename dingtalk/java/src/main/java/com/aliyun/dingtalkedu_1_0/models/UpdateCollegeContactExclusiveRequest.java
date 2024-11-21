// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class UpdateCollegeContactExclusiveRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>@lALPDfmVUw19YdrNA-jNA-g</p>
     */
    @NameInMap("avatarMediaId")
    public String avatarMediaId;

    @NameInMap("deptIdList")
    public java.util.List<Long> deptIdList;

    @NameInMap("deptOrderList")
    public java.util.List<UpdateCollegeContactExclusiveRequestDeptOrderList> deptOrderList;

    @NameInMap("deptPositionSet")
    public java.util.List<UpdateCollegeContactExclusiveRequestDeptPositionSet> deptPositionSet;

    @NameInMap("deptTitleList")
    public java.util.List<UpdateCollegeContactExclusiveRequestDeptTitleList> deptTitleList;

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

    @NameInMap("extension")
    public java.util.Map<String, String> extension;

    /**
     * <strong>example:</strong>
     * <p>manager_userid</p>
     */
    @NameInMap("forceUpdateFields")
    public String forceUpdateFields;

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
     * <p>666666</p>
     */
    @NameInMap("jobNumber")
    public String jobNumber;

    /**
     * <strong>example:</strong>
     * <p>zh_CN</p>
     */
    @NameInMap("language")
    public String language;

    /**
     * <strong>example:</strong>
     * <p>studentNo</p>
     */
    @NameInMap("loginIdType")
    public String loginIdType;

    /**
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
     * <p>This parameter is required.</p>
     * 
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

    public static UpdateCollegeContactExclusiveRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateCollegeContactExclusiveRequest self = new UpdateCollegeContactExclusiveRequest();
        return TeaModel.build(map, self);
    }

    public UpdateCollegeContactExclusiveRequest setAvatarMediaId(String avatarMediaId) {
        this.avatarMediaId = avatarMediaId;
        return this;
    }
    public String getAvatarMediaId() {
        return this.avatarMediaId;
    }

    public UpdateCollegeContactExclusiveRequest setDeptIdList(java.util.List<Long> deptIdList) {
        this.deptIdList = deptIdList;
        return this;
    }
    public java.util.List<Long> getDeptIdList() {
        return this.deptIdList;
    }

    public UpdateCollegeContactExclusiveRequest setDeptOrderList(java.util.List<UpdateCollegeContactExclusiveRequestDeptOrderList> deptOrderList) {
        this.deptOrderList = deptOrderList;
        return this;
    }
    public java.util.List<UpdateCollegeContactExclusiveRequestDeptOrderList> getDeptOrderList() {
        return this.deptOrderList;
    }

    public UpdateCollegeContactExclusiveRequest setDeptPositionSet(java.util.List<UpdateCollegeContactExclusiveRequestDeptPositionSet> deptPositionSet) {
        this.deptPositionSet = deptPositionSet;
        return this;
    }
    public java.util.List<UpdateCollegeContactExclusiveRequestDeptPositionSet> getDeptPositionSet() {
        return this.deptPositionSet;
    }

    public UpdateCollegeContactExclusiveRequest setDeptTitleList(java.util.List<UpdateCollegeContactExclusiveRequestDeptTitleList> deptTitleList) {
        this.deptTitleList = deptTitleList;
        return this;
    }
    public java.util.List<UpdateCollegeContactExclusiveRequestDeptTitleList> getDeptTitleList() {
        return this.deptTitleList;
    }

    public UpdateCollegeContactExclusiveRequest setEmail(String email) {
        this.email = email;
        return this;
    }
    public String getEmail() {
        return this.email;
    }

    public UpdateCollegeContactExclusiveRequest setEmpType(String empType) {
        this.empType = empType;
        return this;
    }
    public String getEmpType() {
        return this.empType;
    }

    public UpdateCollegeContactExclusiveRequest setExtension(java.util.Map<String, String> extension) {
        this.extension = extension;
        return this;
    }
    public java.util.Map<String, String> getExtension() {
        return this.extension;
    }

    public UpdateCollegeContactExclusiveRequest setForceUpdateFields(String forceUpdateFields) {
        this.forceUpdateFields = forceUpdateFields;
        return this;
    }
    public String getForceUpdateFields() {
        return this.forceUpdateFields;
    }

    public UpdateCollegeContactExclusiveRequest setHideMobile(Boolean hideMobile) {
        this.hideMobile = hideMobile;
        return this;
    }
    public Boolean getHideMobile() {
        return this.hideMobile;
    }

    public UpdateCollegeContactExclusiveRequest setHiredDate(Long hiredDate) {
        this.hiredDate = hiredDate;
        return this;
    }
    public Long getHiredDate() {
        return this.hiredDate;
    }

    public UpdateCollegeContactExclusiveRequest setJobNumber(String jobNumber) {
        this.jobNumber = jobNumber;
        return this;
    }
    public String getJobNumber() {
        return this.jobNumber;
    }

    public UpdateCollegeContactExclusiveRequest setLanguage(String language) {
        this.language = language;
        return this;
    }
    public String getLanguage() {
        return this.language;
    }

    public UpdateCollegeContactExclusiveRequest setLoginIdType(String loginIdType) {
        this.loginIdType = loginIdType;
        return this;
    }
    public String getLoginIdType() {
        return this.loginIdType;
    }

    public UpdateCollegeContactExclusiveRequest setMainDeptId(Long mainDeptId) {
        this.mainDeptId = mainDeptId;
        return this;
    }
    public Long getMainDeptId() {
        return this.mainDeptId;
    }

    public UpdateCollegeContactExclusiveRequest setManagerUserid(String managerUserid) {
        this.managerUserid = managerUserid;
        return this;
    }
    public String getManagerUserid() {
        return this.managerUserid;
    }

    public UpdateCollegeContactExclusiveRequest setMobile(String mobile) {
        this.mobile = mobile;
        return this;
    }
    public String getMobile() {
        return this.mobile;
    }

    public UpdateCollegeContactExclusiveRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public UpdateCollegeContactExclusiveRequest setNickname(String nickname) {
        this.nickname = nickname;
        return this;
    }
    public String getNickname() {
        return this.nickname;
    }

    public UpdateCollegeContactExclusiveRequest setOrgEmail(String orgEmail) {
        this.orgEmail = orgEmail;
        return this;
    }
    public String getOrgEmail() {
        return this.orgEmail;
    }

    public UpdateCollegeContactExclusiveRequest setOrgEmailType(String orgEmailType) {
        this.orgEmailType = orgEmailType;
        return this;
    }
    public String getOrgEmailType() {
        return this.orgEmailType;
    }

    public UpdateCollegeContactExclusiveRequest setRemark(String remark) {
        this.remark = remark;
        return this;
    }
    public String getRemark() {
        return this.remark;
    }

    public UpdateCollegeContactExclusiveRequest setSeniorMode(Boolean seniorMode) {
        this.seniorMode = seniorMode;
        return this;
    }
    public Boolean getSeniorMode() {
        return this.seniorMode;
    }

    public UpdateCollegeContactExclusiveRequest setTelephone(String telephone) {
        this.telephone = telephone;
        return this;
    }
    public String getTelephone() {
        return this.telephone;
    }

    public UpdateCollegeContactExclusiveRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public UpdateCollegeContactExclusiveRequest setUserid(String userid) {
        this.userid = userid;
        return this;
    }
    public String getUserid() {
        return this.userid;
    }

    public UpdateCollegeContactExclusiveRequest setWorkPlace(String workPlace) {
        this.workPlace = workPlace;
        return this;
    }
    public String getWorkPlace() {
        return this.workPlace;
    }

    public static class UpdateCollegeContactExclusiveRequestDeptOrderList extends TeaModel {
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

        public static UpdateCollegeContactExclusiveRequestDeptOrderList build(java.util.Map<String, ?> map) throws Exception {
            UpdateCollegeContactExclusiveRequestDeptOrderList self = new UpdateCollegeContactExclusiveRequestDeptOrderList();
            return TeaModel.build(map, self);
        }

        public UpdateCollegeContactExclusiveRequestDeptOrderList setDeptId(Long deptId) {
            this.deptId = deptId;
            return this;
        }
        public Long getDeptId() {
            return this.deptId;
        }

        public UpdateCollegeContactExclusiveRequestDeptOrderList setOrder(Integer order) {
            this.order = order;
            return this;
        }
        public Integer getOrder() {
            return this.order;
        }

    }

    public static class UpdateCollegeContactExclusiveRequestDeptPositionSet extends TeaModel {
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

        public static UpdateCollegeContactExclusiveRequestDeptPositionSet build(java.util.Map<String, ?> map) throws Exception {
            UpdateCollegeContactExclusiveRequestDeptPositionSet self = new UpdateCollegeContactExclusiveRequestDeptPositionSet();
            return TeaModel.build(map, self);
        }

        public UpdateCollegeContactExclusiveRequestDeptPositionSet setDeptId(Long deptId) {
            this.deptId = deptId;
            return this;
        }
        public Long getDeptId() {
            return this.deptId;
        }

        public UpdateCollegeContactExclusiveRequestDeptPositionSet setManagerUserId(String managerUserId) {
            this.managerUserId = managerUserId;
            return this;
        }
        public String getManagerUserId() {
            return this.managerUserId;
        }

        public UpdateCollegeContactExclusiveRequestDeptPositionSet setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public UpdateCollegeContactExclusiveRequestDeptPositionSet setWorkPlace(String workPlace) {
            this.workPlace = workPlace;
            return this;
        }
        public String getWorkPlace() {
            return this.workPlace;
        }

    }

    public static class UpdateCollegeContactExclusiveRequestDeptTitleList extends TeaModel {
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

        public static UpdateCollegeContactExclusiveRequestDeptTitleList build(java.util.Map<String, ?> map) throws Exception {
            UpdateCollegeContactExclusiveRequestDeptTitleList self = new UpdateCollegeContactExclusiveRequestDeptTitleList();
            return TeaModel.build(map, self);
        }

        public UpdateCollegeContactExclusiveRequestDeptTitleList setDeptId(Long deptId) {
            this.deptId = deptId;
            return this;
        }
        public Long getDeptId() {
            return this.deptId;
        }

        public UpdateCollegeContactExclusiveRequestDeptTitleList setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

}
