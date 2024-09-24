// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class UpdateCollegeContactUserRequest extends TeaModel {
    @NameInMap("deptIdList")
    public java.util.List<Long> deptIdList;

    @NameInMap("deptOrderList")
    public java.util.List<UpdateCollegeContactUserRequestDeptOrderList> deptOrderList;

    @NameInMap("deptTitleList")
    public java.util.List<UpdateCollegeContactUserRequestDeptTitleList> deptTitleList;

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
     * <p>阿里巴巴c区</p>
     */
    @NameInMap("workPlace")
    public String workPlace;

    public static UpdateCollegeContactUserRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateCollegeContactUserRequest self = new UpdateCollegeContactUserRequest();
        return TeaModel.build(map, self);
    }

    public UpdateCollegeContactUserRequest setDeptIdList(java.util.List<Long> deptIdList) {
        this.deptIdList = deptIdList;
        return this;
    }
    public java.util.List<Long> getDeptIdList() {
        return this.deptIdList;
    }

    public UpdateCollegeContactUserRequest setDeptOrderList(java.util.List<UpdateCollegeContactUserRequestDeptOrderList> deptOrderList) {
        this.deptOrderList = deptOrderList;
        return this;
    }
    public java.util.List<UpdateCollegeContactUserRequestDeptOrderList> getDeptOrderList() {
        return this.deptOrderList;
    }

    public UpdateCollegeContactUserRequest setDeptTitleList(java.util.List<UpdateCollegeContactUserRequestDeptTitleList> deptTitleList) {
        this.deptTitleList = deptTitleList;
        return this;
    }
    public java.util.List<UpdateCollegeContactUserRequestDeptTitleList> getDeptTitleList() {
        return this.deptTitleList;
    }

    public UpdateCollegeContactUserRequest setEmail(String email) {
        this.email = email;
        return this;
    }
    public String getEmail() {
        return this.email;
    }

    public UpdateCollegeContactUserRequest setEmpType(String empType) {
        this.empType = empType;
        return this;
    }
    public String getEmpType() {
        return this.empType;
    }

    public UpdateCollegeContactUserRequest setExtension(java.util.Map<String, String> extension) {
        this.extension = extension;
        return this;
    }
    public java.util.Map<String, String> getExtension() {
        return this.extension;
    }

    public UpdateCollegeContactUserRequest setForceUpdateFields(String forceUpdateFields) {
        this.forceUpdateFields = forceUpdateFields;
        return this;
    }
    public String getForceUpdateFields() {
        return this.forceUpdateFields;
    }

    public UpdateCollegeContactUserRequest setHideMobile(Boolean hideMobile) {
        this.hideMobile = hideMobile;
        return this;
    }
    public Boolean getHideMobile() {
        return this.hideMobile;
    }

    public UpdateCollegeContactUserRequest setHiredDate(Long hiredDate) {
        this.hiredDate = hiredDate;
        return this;
    }
    public Long getHiredDate() {
        return this.hiredDate;
    }

    public UpdateCollegeContactUserRequest setJobNumber(String jobNumber) {
        this.jobNumber = jobNumber;
        return this;
    }
    public String getJobNumber() {
        return this.jobNumber;
    }

    public UpdateCollegeContactUserRequest setLanguage(String language) {
        this.language = language;
        return this;
    }
    public String getLanguage() {
        return this.language;
    }

    public UpdateCollegeContactUserRequest setMainDeptId(Long mainDeptId) {
        this.mainDeptId = mainDeptId;
        return this;
    }
    public Long getMainDeptId() {
        return this.mainDeptId;
    }

    public UpdateCollegeContactUserRequest setManagerUserid(String managerUserid) {
        this.managerUserid = managerUserid;
        return this;
    }
    public String getManagerUserid() {
        return this.managerUserid;
    }

    public UpdateCollegeContactUserRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public UpdateCollegeContactUserRequest setOrgEmail(String orgEmail) {
        this.orgEmail = orgEmail;
        return this;
    }
    public String getOrgEmail() {
        return this.orgEmail;
    }

    public UpdateCollegeContactUserRequest setRemark(String remark) {
        this.remark = remark;
        return this;
    }
    public String getRemark() {
        return this.remark;
    }

    public UpdateCollegeContactUserRequest setSeniorMode(Boolean seniorMode) {
        this.seniorMode = seniorMode;
        return this;
    }
    public Boolean getSeniorMode() {
        return this.seniorMode;
    }

    public UpdateCollegeContactUserRequest setTelephone(String telephone) {
        this.telephone = telephone;
        return this;
    }
    public String getTelephone() {
        return this.telephone;
    }

    public UpdateCollegeContactUserRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public UpdateCollegeContactUserRequest setUserid(String userid) {
        this.userid = userid;
        return this;
    }
    public String getUserid() {
        return this.userid;
    }

    public UpdateCollegeContactUserRequest setWorkPlace(String workPlace) {
        this.workPlace = workPlace;
        return this;
    }
    public String getWorkPlace() {
        return this.workPlace;
    }

    public static class UpdateCollegeContactUserRequestDeptOrderList extends TeaModel {
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

        public static UpdateCollegeContactUserRequestDeptOrderList build(java.util.Map<String, ?> map) throws Exception {
            UpdateCollegeContactUserRequestDeptOrderList self = new UpdateCollegeContactUserRequestDeptOrderList();
            return TeaModel.build(map, self);
        }

        public UpdateCollegeContactUserRequestDeptOrderList setDeptId(Long deptId) {
            this.deptId = deptId;
            return this;
        }
        public Long getDeptId() {
            return this.deptId;
        }

        public UpdateCollegeContactUserRequestDeptOrderList setOrder(Integer order) {
            this.order = order;
            return this;
        }
        public Integer getOrder() {
            return this.order;
        }

    }

    public static class UpdateCollegeContactUserRequestDeptTitleList extends TeaModel {
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

        public static UpdateCollegeContactUserRequestDeptTitleList build(java.util.Map<String, ?> map) throws Exception {
            UpdateCollegeContactUserRequestDeptTitleList self = new UpdateCollegeContactUserRequestDeptTitleList();
            return TeaModel.build(map, self);
        }

        public UpdateCollegeContactUserRequestDeptTitleList setDeptId(Long deptId) {
            this.deptId = deptId;
            return this;
        }
        public Long getDeptId() {
            return this.deptId;
        }

        public UpdateCollegeContactUserRequestDeptTitleList setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

}
