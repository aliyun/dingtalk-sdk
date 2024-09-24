// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class UpdateCollegeContactDeptRequest extends TeaModel {
    @NameInMap("autoAddUser")
    public Boolean autoAddUser;

    @NameInMap("autoApproveApply")
    public Boolean autoApproveApply;

    /**
     * <strong>example:</strong>
     * <p>这是组织单元简介</p>
     */
    @NameInMap("brief")
    public String brief;

    /**
     * <strong>example:</strong>
     * <p>20000</p>
     */
    @NameInMap("code")
    public String code;

    @NameInMap("createDeptGroup")
    public Boolean createDeptGroup;

    /**
     * <strong>example:</strong>
     * <p>dept456</p>
     */
    @NameInMap("deptCode")
    public String deptCode;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>200</p>
     */
    @NameInMap("deptId")
    public Long deptId;

    @NameInMap("deptManagerUseridList")
    public java.util.List<String> deptManagerUseridList;

    @NameInMap("deptPermits")
    public java.util.List<Long> deptPermits;

    /**
     * <strong>example:</strong>
     * <p>contact_class_dept</p>
     */
    @NameInMap("deptType")
    public String deptType;

    @NameInMap("empApplyJoinDept")
    public Boolean empApplyJoinDept;

    @NameInMap("extension")
    public java.util.Map<String, String> extension;

    @NameInMap("forceUpdateFields")
    public java.util.List<String> forceUpdateFields;

    @NameInMap("groupContainHiddenDept")
    public Boolean groupContainHiddenDept;

    @NameInMap("groupContainOuterDept")
    public Boolean groupContainOuterDept;

    @NameInMap("groupContainSubDept")
    public Boolean groupContainSubDept;

    @NameInMap("hideDept")
    public Boolean hideDept;

    @NameInMap("hideSceneConfig")
    public UpdateCollegeContactDeptRequestHideSceneConfig hideSceneConfig;

    /**
     * <strong>example:</strong>
     * <p>zh_CN</p>
     */
    @NameInMap("language")
    public String language;

    /**
     * <strong>example:</strong>
     * <p>软件工程</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <strong>example:</strong>
     * <p>20</p>
     */
    @NameInMap("order")
    public Long order;

    /**
     * <strong>example:</strong>
     * <p>user234</p>
     */
    @NameInMap("orgDeptOwner")
    public String orgDeptOwner;

    @NameInMap("outerDept")
    public Boolean outerDept;

    @NameInMap("outerDeptOnlySelf")
    public Boolean outerDeptOnlySelf;

    @NameInMap("outerPermitDepts")
    public java.util.List<Long> outerPermitDepts;

    @NameInMap("outerPermitUsers")
    public java.util.List<String> outerPermitUsers;

    @NameInMap("outerSceneConfig")
    public UpdateCollegeContactDeptRequestOuterSceneConfig outerSceneConfig;

    /**
     * <strong>example:</strong>
     * <p>20</p>
     */
    @NameInMap("parentId")
    public Long parentId;

    /**
     * <strong>example:</strong>
     * <p>软件工程标识</p>
     */
    @NameInMap("sourceIdentifier")
    public String sourceIdentifier;

    /**
     * <strong>example:</strong>
     * <p>138xxxx0000</p>
     */
    @NameInMap("telephone")
    public String telephone;

    @NameInMap("userPermits")
    public java.util.List<String> userPermits;

    public static UpdateCollegeContactDeptRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateCollegeContactDeptRequest self = new UpdateCollegeContactDeptRequest();
        return TeaModel.build(map, self);
    }

    public UpdateCollegeContactDeptRequest setAutoAddUser(Boolean autoAddUser) {
        this.autoAddUser = autoAddUser;
        return this;
    }
    public Boolean getAutoAddUser() {
        return this.autoAddUser;
    }

    public UpdateCollegeContactDeptRequest setAutoApproveApply(Boolean autoApproveApply) {
        this.autoApproveApply = autoApproveApply;
        return this;
    }
    public Boolean getAutoApproveApply() {
        return this.autoApproveApply;
    }

    public UpdateCollegeContactDeptRequest setBrief(String brief) {
        this.brief = brief;
        return this;
    }
    public String getBrief() {
        return this.brief;
    }

    public UpdateCollegeContactDeptRequest setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

    public UpdateCollegeContactDeptRequest setCreateDeptGroup(Boolean createDeptGroup) {
        this.createDeptGroup = createDeptGroup;
        return this;
    }
    public Boolean getCreateDeptGroup() {
        return this.createDeptGroup;
    }

    public UpdateCollegeContactDeptRequest setDeptCode(String deptCode) {
        this.deptCode = deptCode;
        return this;
    }
    public String getDeptCode() {
        return this.deptCode;
    }

    public UpdateCollegeContactDeptRequest setDeptId(Long deptId) {
        this.deptId = deptId;
        return this;
    }
    public Long getDeptId() {
        return this.deptId;
    }

    public UpdateCollegeContactDeptRequest setDeptManagerUseridList(java.util.List<String> deptManagerUseridList) {
        this.deptManagerUseridList = deptManagerUseridList;
        return this;
    }
    public java.util.List<String> getDeptManagerUseridList() {
        return this.deptManagerUseridList;
    }

    public UpdateCollegeContactDeptRequest setDeptPermits(java.util.List<Long> deptPermits) {
        this.deptPermits = deptPermits;
        return this;
    }
    public java.util.List<Long> getDeptPermits() {
        return this.deptPermits;
    }

    public UpdateCollegeContactDeptRequest setDeptType(String deptType) {
        this.deptType = deptType;
        return this;
    }
    public String getDeptType() {
        return this.deptType;
    }

    public UpdateCollegeContactDeptRequest setEmpApplyJoinDept(Boolean empApplyJoinDept) {
        this.empApplyJoinDept = empApplyJoinDept;
        return this;
    }
    public Boolean getEmpApplyJoinDept() {
        return this.empApplyJoinDept;
    }

    public UpdateCollegeContactDeptRequest setExtension(java.util.Map<String, String> extension) {
        this.extension = extension;
        return this;
    }
    public java.util.Map<String, String> getExtension() {
        return this.extension;
    }

    public UpdateCollegeContactDeptRequest setForceUpdateFields(java.util.List<String> forceUpdateFields) {
        this.forceUpdateFields = forceUpdateFields;
        return this;
    }
    public java.util.List<String> getForceUpdateFields() {
        return this.forceUpdateFields;
    }

    public UpdateCollegeContactDeptRequest setGroupContainHiddenDept(Boolean groupContainHiddenDept) {
        this.groupContainHiddenDept = groupContainHiddenDept;
        return this;
    }
    public Boolean getGroupContainHiddenDept() {
        return this.groupContainHiddenDept;
    }

    public UpdateCollegeContactDeptRequest setGroupContainOuterDept(Boolean groupContainOuterDept) {
        this.groupContainOuterDept = groupContainOuterDept;
        return this;
    }
    public Boolean getGroupContainOuterDept() {
        return this.groupContainOuterDept;
    }

    public UpdateCollegeContactDeptRequest setGroupContainSubDept(Boolean groupContainSubDept) {
        this.groupContainSubDept = groupContainSubDept;
        return this;
    }
    public Boolean getGroupContainSubDept() {
        return this.groupContainSubDept;
    }

    public UpdateCollegeContactDeptRequest setHideDept(Boolean hideDept) {
        this.hideDept = hideDept;
        return this;
    }
    public Boolean getHideDept() {
        return this.hideDept;
    }

    public UpdateCollegeContactDeptRequest setHideSceneConfig(UpdateCollegeContactDeptRequestHideSceneConfig hideSceneConfig) {
        this.hideSceneConfig = hideSceneConfig;
        return this;
    }
    public UpdateCollegeContactDeptRequestHideSceneConfig getHideSceneConfig() {
        return this.hideSceneConfig;
    }

    public UpdateCollegeContactDeptRequest setLanguage(String language) {
        this.language = language;
        return this;
    }
    public String getLanguage() {
        return this.language;
    }

    public UpdateCollegeContactDeptRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public UpdateCollegeContactDeptRequest setOrder(Long order) {
        this.order = order;
        return this;
    }
    public Long getOrder() {
        return this.order;
    }

    public UpdateCollegeContactDeptRequest setOrgDeptOwner(String orgDeptOwner) {
        this.orgDeptOwner = orgDeptOwner;
        return this;
    }
    public String getOrgDeptOwner() {
        return this.orgDeptOwner;
    }

    public UpdateCollegeContactDeptRequest setOuterDept(Boolean outerDept) {
        this.outerDept = outerDept;
        return this;
    }
    public Boolean getOuterDept() {
        return this.outerDept;
    }

    public UpdateCollegeContactDeptRequest setOuterDeptOnlySelf(Boolean outerDeptOnlySelf) {
        this.outerDeptOnlySelf = outerDeptOnlySelf;
        return this;
    }
    public Boolean getOuterDeptOnlySelf() {
        return this.outerDeptOnlySelf;
    }

    public UpdateCollegeContactDeptRequest setOuterPermitDepts(java.util.List<Long> outerPermitDepts) {
        this.outerPermitDepts = outerPermitDepts;
        return this;
    }
    public java.util.List<Long> getOuterPermitDepts() {
        return this.outerPermitDepts;
    }

    public UpdateCollegeContactDeptRequest setOuterPermitUsers(java.util.List<String> outerPermitUsers) {
        this.outerPermitUsers = outerPermitUsers;
        return this;
    }
    public java.util.List<String> getOuterPermitUsers() {
        return this.outerPermitUsers;
    }

    public UpdateCollegeContactDeptRequest setOuterSceneConfig(UpdateCollegeContactDeptRequestOuterSceneConfig outerSceneConfig) {
        this.outerSceneConfig = outerSceneConfig;
        return this;
    }
    public UpdateCollegeContactDeptRequestOuterSceneConfig getOuterSceneConfig() {
        return this.outerSceneConfig;
    }

    public UpdateCollegeContactDeptRequest setParentId(Long parentId) {
        this.parentId = parentId;
        return this;
    }
    public Long getParentId() {
        return this.parentId;
    }

    public UpdateCollegeContactDeptRequest setSourceIdentifier(String sourceIdentifier) {
        this.sourceIdentifier = sourceIdentifier;
        return this;
    }
    public String getSourceIdentifier() {
        return this.sourceIdentifier;
    }

    public UpdateCollegeContactDeptRequest setTelephone(String telephone) {
        this.telephone = telephone;
        return this;
    }
    public String getTelephone() {
        return this.telephone;
    }

    public UpdateCollegeContactDeptRequest setUserPermits(java.util.List<String> userPermits) {
        this.userPermits = userPermits;
        return this;
    }
    public java.util.List<String> getUserPermits() {
        return this.userPermits;
    }

    public static class UpdateCollegeContactDeptRequestHideSceneConfig extends TeaModel {
        @NameInMap("active")
        public Boolean active;

        @NameInMap("chatboxSubtitle")
        public Boolean chatboxSubtitle;

        @NameInMap("nodeList")
        public Boolean nodeList;

        @NameInMap("profile")
        public Boolean profile;

        @NameInMap("search")
        public Boolean search;

        public static UpdateCollegeContactDeptRequestHideSceneConfig build(java.util.Map<String, ?> map) throws Exception {
            UpdateCollegeContactDeptRequestHideSceneConfig self = new UpdateCollegeContactDeptRequestHideSceneConfig();
            return TeaModel.build(map, self);
        }

        public UpdateCollegeContactDeptRequestHideSceneConfig setActive(Boolean active) {
            this.active = active;
            return this;
        }
        public Boolean getActive() {
            return this.active;
        }

        public UpdateCollegeContactDeptRequestHideSceneConfig setChatboxSubtitle(Boolean chatboxSubtitle) {
            this.chatboxSubtitle = chatboxSubtitle;
            return this;
        }
        public Boolean getChatboxSubtitle() {
            return this.chatboxSubtitle;
        }

        public UpdateCollegeContactDeptRequestHideSceneConfig setNodeList(Boolean nodeList) {
            this.nodeList = nodeList;
            return this;
        }
        public Boolean getNodeList() {
            return this.nodeList;
        }

        public UpdateCollegeContactDeptRequestHideSceneConfig setProfile(Boolean profile) {
            this.profile = profile;
            return this;
        }
        public Boolean getProfile() {
            return this.profile;
        }

        public UpdateCollegeContactDeptRequestHideSceneConfig setSearch(Boolean search) {
            this.search = search;
            return this;
        }
        public Boolean getSearch() {
            return this.search;
        }

    }

    public static class UpdateCollegeContactDeptRequestOuterSceneConfig extends TeaModel {
        @NameInMap("active")
        public Boolean active;

        @NameInMap("chatboxSubtitle")
        public Boolean chatboxSubtitle;

        @NameInMap("nodeList")
        public Boolean nodeList;

        @NameInMap("profile")
        public Boolean profile;

        @NameInMap("search")
        public Boolean search;

        public static UpdateCollegeContactDeptRequestOuterSceneConfig build(java.util.Map<String, ?> map) throws Exception {
            UpdateCollegeContactDeptRequestOuterSceneConfig self = new UpdateCollegeContactDeptRequestOuterSceneConfig();
            return TeaModel.build(map, self);
        }

        public UpdateCollegeContactDeptRequestOuterSceneConfig setActive(Boolean active) {
            this.active = active;
            return this;
        }
        public Boolean getActive() {
            return this.active;
        }

        public UpdateCollegeContactDeptRequestOuterSceneConfig setChatboxSubtitle(Boolean chatboxSubtitle) {
            this.chatboxSubtitle = chatboxSubtitle;
            return this;
        }
        public Boolean getChatboxSubtitle() {
            return this.chatboxSubtitle;
        }

        public UpdateCollegeContactDeptRequestOuterSceneConfig setNodeList(Boolean nodeList) {
            this.nodeList = nodeList;
            return this;
        }
        public Boolean getNodeList() {
            return this.nodeList;
        }

        public UpdateCollegeContactDeptRequestOuterSceneConfig setProfile(Boolean profile) {
            this.profile = profile;
            return this;
        }
        public Boolean getProfile() {
            return this.profile;
        }

        public UpdateCollegeContactDeptRequestOuterSceneConfig setSearch(Boolean search) {
            this.search = search;
            return this;
        }
        public Boolean getSearch() {
            return this.search;
        }

    }

}
