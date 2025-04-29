// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateCollegeContactDeptRequest extends TeaModel {
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
     * <strong>example:</strong>
     * <p>234567</p>
     */
    @NameInMap("deptId")
    public Long deptId;

    @NameInMap("deptPermits")
    public java.util.List<Long> deptPermits;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>contact_class_dept</p>
     */
    @NameInMap("deptType")
    public String deptType;

    @NameInMap("empApplyJoinDept")
    public Boolean empApplyJoinDept;

    @NameInMap("extension")
    public java.util.Map<String, String> extension;

    @NameInMap("hideDept")
    public Boolean hideDept;

    @NameInMap("hideSceneConfig")
    public CreateCollegeContactDeptRequestHideSceneConfig hideSceneConfig;

    /**
     * <p>This parameter is required.</p>
     * 
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

    @NameInMap("outerDept")
    public Boolean outerDept;

    @NameInMap("outerDeptOnlySelf")
    public Boolean outerDeptOnlySelf;

    @NameInMap("outerPermitDepts")
    public java.util.List<Long> outerPermitDepts;

    @NameInMap("outerPermitUsers")
    public java.util.List<String> outerPermitUsers;

    @NameInMap("outerSceneConfig")
    public CreateCollegeContactDeptRequestOuterSceneConfig outerSceneConfig;

    /**
     * <p>This parameter is required.</p>
     * 
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
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>10</p>
     */
    @NameInMap("struId")
    public Long struId;

    /**
     * <strong>example:</strong>
     * <p>138xxxx0000</p>
     */
    @NameInMap("telephone")
    public String telephone;

    @NameInMap("userPermits")
    public java.util.List<String> userPermits;

    public static CreateCollegeContactDeptRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateCollegeContactDeptRequest self = new CreateCollegeContactDeptRequest();
        return TeaModel.build(map, self);
    }

    public CreateCollegeContactDeptRequest setAutoApproveApply(Boolean autoApproveApply) {
        this.autoApproveApply = autoApproveApply;
        return this;
    }
    public Boolean getAutoApproveApply() {
        return this.autoApproveApply;
    }

    public CreateCollegeContactDeptRequest setBrief(String brief) {
        this.brief = brief;
        return this;
    }
    public String getBrief() {
        return this.brief;
    }

    public CreateCollegeContactDeptRequest setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

    public CreateCollegeContactDeptRequest setCreateDeptGroup(Boolean createDeptGroup) {
        this.createDeptGroup = createDeptGroup;
        return this;
    }
    public Boolean getCreateDeptGroup() {
        return this.createDeptGroup;
    }

    public CreateCollegeContactDeptRequest setDeptCode(String deptCode) {
        this.deptCode = deptCode;
        return this;
    }
    public String getDeptCode() {
        return this.deptCode;
    }

    public CreateCollegeContactDeptRequest setDeptId(Long deptId) {
        this.deptId = deptId;
        return this;
    }
    public Long getDeptId() {
        return this.deptId;
    }

    public CreateCollegeContactDeptRequest setDeptPermits(java.util.List<Long> deptPermits) {
        this.deptPermits = deptPermits;
        return this;
    }
    public java.util.List<Long> getDeptPermits() {
        return this.deptPermits;
    }

    public CreateCollegeContactDeptRequest setDeptType(String deptType) {
        this.deptType = deptType;
        return this;
    }
    public String getDeptType() {
        return this.deptType;
    }

    public CreateCollegeContactDeptRequest setEmpApplyJoinDept(Boolean empApplyJoinDept) {
        this.empApplyJoinDept = empApplyJoinDept;
        return this;
    }
    public Boolean getEmpApplyJoinDept() {
        return this.empApplyJoinDept;
    }

    public CreateCollegeContactDeptRequest setExtension(java.util.Map<String, String> extension) {
        this.extension = extension;
        return this;
    }
    public java.util.Map<String, String> getExtension() {
        return this.extension;
    }

    public CreateCollegeContactDeptRequest setHideDept(Boolean hideDept) {
        this.hideDept = hideDept;
        return this;
    }
    public Boolean getHideDept() {
        return this.hideDept;
    }

    public CreateCollegeContactDeptRequest setHideSceneConfig(CreateCollegeContactDeptRequestHideSceneConfig hideSceneConfig) {
        this.hideSceneConfig = hideSceneConfig;
        return this;
    }
    public CreateCollegeContactDeptRequestHideSceneConfig getHideSceneConfig() {
        return this.hideSceneConfig;
    }

    public CreateCollegeContactDeptRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public CreateCollegeContactDeptRequest setOrder(Long order) {
        this.order = order;
        return this;
    }
    public Long getOrder() {
        return this.order;
    }

    public CreateCollegeContactDeptRequest setOuterDept(Boolean outerDept) {
        this.outerDept = outerDept;
        return this;
    }
    public Boolean getOuterDept() {
        return this.outerDept;
    }

    public CreateCollegeContactDeptRequest setOuterDeptOnlySelf(Boolean outerDeptOnlySelf) {
        this.outerDeptOnlySelf = outerDeptOnlySelf;
        return this;
    }
    public Boolean getOuterDeptOnlySelf() {
        return this.outerDeptOnlySelf;
    }

    public CreateCollegeContactDeptRequest setOuterPermitDepts(java.util.List<Long> outerPermitDepts) {
        this.outerPermitDepts = outerPermitDepts;
        return this;
    }
    public java.util.List<Long> getOuterPermitDepts() {
        return this.outerPermitDepts;
    }

    public CreateCollegeContactDeptRequest setOuterPermitUsers(java.util.List<String> outerPermitUsers) {
        this.outerPermitUsers = outerPermitUsers;
        return this;
    }
    public java.util.List<String> getOuterPermitUsers() {
        return this.outerPermitUsers;
    }

    public CreateCollegeContactDeptRequest setOuterSceneConfig(CreateCollegeContactDeptRequestOuterSceneConfig outerSceneConfig) {
        this.outerSceneConfig = outerSceneConfig;
        return this;
    }
    public CreateCollegeContactDeptRequestOuterSceneConfig getOuterSceneConfig() {
        return this.outerSceneConfig;
    }

    public CreateCollegeContactDeptRequest setParentId(Long parentId) {
        this.parentId = parentId;
        return this;
    }
    public Long getParentId() {
        return this.parentId;
    }

    public CreateCollegeContactDeptRequest setSourceIdentifier(String sourceIdentifier) {
        this.sourceIdentifier = sourceIdentifier;
        return this;
    }
    public String getSourceIdentifier() {
        return this.sourceIdentifier;
    }

    public CreateCollegeContactDeptRequest setStruId(Long struId) {
        this.struId = struId;
        return this;
    }
    public Long getStruId() {
        return this.struId;
    }

    public CreateCollegeContactDeptRequest setTelephone(String telephone) {
        this.telephone = telephone;
        return this;
    }
    public String getTelephone() {
        return this.telephone;
    }

    public CreateCollegeContactDeptRequest setUserPermits(java.util.List<String> userPermits) {
        this.userPermits = userPermits;
        return this;
    }
    public java.util.List<String> getUserPermits() {
        return this.userPermits;
    }

    public static class CreateCollegeContactDeptRequestHideSceneConfig extends TeaModel {
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

        public static CreateCollegeContactDeptRequestHideSceneConfig build(java.util.Map<String, ?> map) throws Exception {
            CreateCollegeContactDeptRequestHideSceneConfig self = new CreateCollegeContactDeptRequestHideSceneConfig();
            return TeaModel.build(map, self);
        }

        public CreateCollegeContactDeptRequestHideSceneConfig setActive(Boolean active) {
            this.active = active;
            return this;
        }
        public Boolean getActive() {
            return this.active;
        }

        public CreateCollegeContactDeptRequestHideSceneConfig setChatboxSubtitle(Boolean chatboxSubtitle) {
            this.chatboxSubtitle = chatboxSubtitle;
            return this;
        }
        public Boolean getChatboxSubtitle() {
            return this.chatboxSubtitle;
        }

        public CreateCollegeContactDeptRequestHideSceneConfig setNodeList(Boolean nodeList) {
            this.nodeList = nodeList;
            return this;
        }
        public Boolean getNodeList() {
            return this.nodeList;
        }

        public CreateCollegeContactDeptRequestHideSceneConfig setProfile(Boolean profile) {
            this.profile = profile;
            return this;
        }
        public Boolean getProfile() {
            return this.profile;
        }

        public CreateCollegeContactDeptRequestHideSceneConfig setSearch(Boolean search) {
            this.search = search;
            return this;
        }
        public Boolean getSearch() {
            return this.search;
        }

    }

    public static class CreateCollegeContactDeptRequestOuterSceneConfig extends TeaModel {
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

        public static CreateCollegeContactDeptRequestOuterSceneConfig build(java.util.Map<String, ?> map) throws Exception {
            CreateCollegeContactDeptRequestOuterSceneConfig self = new CreateCollegeContactDeptRequestOuterSceneConfig();
            return TeaModel.build(map, self);
        }

        public CreateCollegeContactDeptRequestOuterSceneConfig setActive(Boolean active) {
            this.active = active;
            return this;
        }
        public Boolean getActive() {
            return this.active;
        }

        public CreateCollegeContactDeptRequestOuterSceneConfig setChatboxSubtitle(Boolean chatboxSubtitle) {
            this.chatboxSubtitle = chatboxSubtitle;
            return this;
        }
        public Boolean getChatboxSubtitle() {
            return this.chatboxSubtitle;
        }

        public CreateCollegeContactDeptRequestOuterSceneConfig setNodeList(Boolean nodeList) {
            this.nodeList = nodeList;
            return this;
        }
        public Boolean getNodeList() {
            return this.nodeList;
        }

        public CreateCollegeContactDeptRequestOuterSceneConfig setProfile(Boolean profile) {
            this.profile = profile;
            return this;
        }
        public Boolean getProfile() {
            return this.profile;
        }

        public CreateCollegeContactDeptRequestOuterSceneConfig setSearch(Boolean search) {
            this.search = search;
            return this;
        }
        public Boolean getSearch() {
            return this.search;
        }

    }

}
