// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class AddCollegeContactUserRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("deptIdList")
    public java.util.List<Long> deptIdList;

    @NameInMap("deptOrderList")
    public java.util.List<AddCollegeContactUserRequestDeptOrderList> deptOrderList;

    @NameInMap("deptTitleList")
    public java.util.List<AddCollegeContactUserRequestDeptTitleList> deptTitleList;

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

    @NameInMap("extension")
    public java.util.Map<String, String> extension;

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
     * <p><a href="mailto:test@xxx.com">test@xxx.com</a></p>
     */
    @NameInMap("loginEmail")
    public String loginEmail;

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
     * <p>This parameter is required.</p>
     * 
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
     * <p>阿里巴巴c区</p>
     */
    @NameInMap("workPlace")
    public String workPlace;

    public static AddCollegeContactUserRequest build(java.util.Map<String, ?> map) throws Exception {
        AddCollegeContactUserRequest self = new AddCollegeContactUserRequest();
        return TeaModel.build(map, self);
    }

    public AddCollegeContactUserRequest setDeptIdList(java.util.List<Long> deptIdList) {
        this.deptIdList = deptIdList;
        return this;
    }
    public java.util.List<Long> getDeptIdList() {
        return this.deptIdList;
    }

    public AddCollegeContactUserRequest setDeptOrderList(java.util.List<AddCollegeContactUserRequestDeptOrderList> deptOrderList) {
        this.deptOrderList = deptOrderList;
        return this;
    }
    public java.util.List<AddCollegeContactUserRequestDeptOrderList> getDeptOrderList() {
        return this.deptOrderList;
    }

    public AddCollegeContactUserRequest setDeptTitleList(java.util.List<AddCollegeContactUserRequestDeptTitleList> deptTitleList) {
        this.deptTitleList = deptTitleList;
        return this;
    }
    public java.util.List<AddCollegeContactUserRequestDeptTitleList> getDeptTitleList() {
        return this.deptTitleList;
    }

    public AddCollegeContactUserRequest setEmail(String email) {
        this.email = email;
        return this;
    }
    public String getEmail() {
        return this.email;
    }

    public AddCollegeContactUserRequest setEmpType(String empType) {
        this.empType = empType;
        return this;
    }
    public String getEmpType() {
        return this.empType;
    }

    public AddCollegeContactUserRequest setExtension(java.util.Map<String, String> extension) {
        this.extension = extension;
        return this;
    }
    public java.util.Map<String, String> getExtension() {
        return this.extension;
    }

    public AddCollegeContactUserRequest setHideMobile(Boolean hideMobile) {
        this.hideMobile = hideMobile;
        return this;
    }
    public Boolean getHideMobile() {
        return this.hideMobile;
    }

    public AddCollegeContactUserRequest setHiredDate(Long hiredDate) {
        this.hiredDate = hiredDate;
        return this;
    }
    public Long getHiredDate() {
        return this.hiredDate;
    }

    public AddCollegeContactUserRequest setJobNumber(String jobNumber) {
        this.jobNumber = jobNumber;
        return this;
    }
    public String getJobNumber() {
        return this.jobNumber;
    }

    public AddCollegeContactUserRequest setLoginEmail(String loginEmail) {
        this.loginEmail = loginEmail;
        return this;
    }
    public String getLoginEmail() {
        return this.loginEmail;
    }

    public AddCollegeContactUserRequest setMainDeptId(Long mainDeptId) {
        this.mainDeptId = mainDeptId;
        return this;
    }
    public Long getMainDeptId() {
        return this.mainDeptId;
    }

    public AddCollegeContactUserRequest setManagerUserid(String managerUserid) {
        this.managerUserid = managerUserid;
        return this;
    }
    public String getManagerUserid() {
        return this.managerUserid;
    }

    public AddCollegeContactUserRequest setMobile(String mobile) {
        this.mobile = mobile;
        return this;
    }
    public String getMobile() {
        return this.mobile;
    }

    public AddCollegeContactUserRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public AddCollegeContactUserRequest setOrgEmail(String orgEmail) {
        this.orgEmail = orgEmail;
        return this;
    }
    public String getOrgEmail() {
        return this.orgEmail;
    }

    public AddCollegeContactUserRequest setOrgEmailType(String orgEmailType) {
        this.orgEmailType = orgEmailType;
        return this;
    }
    public String getOrgEmailType() {
        return this.orgEmailType;
    }

    public AddCollegeContactUserRequest setRemark(String remark) {
        this.remark = remark;
        return this;
    }
    public String getRemark() {
        return this.remark;
    }

    public AddCollegeContactUserRequest setSendActiveSms(Boolean sendActiveSms) {
        this.sendActiveSms = sendActiveSms;
        return this;
    }
    public Boolean getSendActiveSms() {
        return this.sendActiveSms;
    }

    public AddCollegeContactUserRequest setSeniorMode(Boolean seniorMode) {
        this.seniorMode = seniorMode;
        return this;
    }
    public Boolean getSeniorMode() {
        return this.seniorMode;
    }

    public AddCollegeContactUserRequest setTelephone(String telephone) {
        this.telephone = telephone;
        return this;
    }
    public String getTelephone() {
        return this.telephone;
    }

    public AddCollegeContactUserRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public AddCollegeContactUserRequest setUserid(String userid) {
        this.userid = userid;
        return this;
    }
    public String getUserid() {
        return this.userid;
    }

    public AddCollegeContactUserRequest setWorkPlace(String workPlace) {
        this.workPlace = workPlace;
        return this;
    }
    public String getWorkPlace() {
        return this.workPlace;
    }

    public static class AddCollegeContactUserRequestDeptOrderList extends TeaModel {
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

        public static AddCollegeContactUserRequestDeptOrderList build(java.util.Map<String, ?> map) throws Exception {
            AddCollegeContactUserRequestDeptOrderList self = new AddCollegeContactUserRequestDeptOrderList();
            return TeaModel.build(map, self);
        }

        public AddCollegeContactUserRequestDeptOrderList setDeptId(Long deptId) {
            this.deptId = deptId;
            return this;
        }
        public Long getDeptId() {
            return this.deptId;
        }

        public AddCollegeContactUserRequestDeptOrderList setOrder(Integer order) {
            this.order = order;
            return this;
        }
        public Integer getOrder() {
            return this.order;
        }

    }

    public static class AddCollegeContactUserRequestDeptTitleList extends TeaModel {
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

        public static AddCollegeContactUserRequestDeptTitleList build(java.util.Map<String, ?> map) throws Exception {
            AddCollegeContactUserRequestDeptTitleList self = new AddCollegeContactUserRequestDeptTitleList();
            return TeaModel.build(map, self);
        }

        public AddCollegeContactUserRequestDeptTitleList setDeptId(Long deptId) {
            this.deptId = deptId;
            return this;
        }
        public Long getDeptId() {
            return this.deptId;
        }

        public AddCollegeContactUserRequestDeptTitleList setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

}
