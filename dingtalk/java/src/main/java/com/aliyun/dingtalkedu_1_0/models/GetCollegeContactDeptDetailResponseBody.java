// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class GetCollegeContactDeptDetailResponseBody extends TeaModel {
    @NameInMap("result")
    public GetCollegeContactDeptDetailResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static GetCollegeContactDeptDetailResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetCollegeContactDeptDetailResponseBody self = new GetCollegeContactDeptDetailResponseBody();
        return TeaModel.build(map, self);
    }

    public GetCollegeContactDeptDetailResponseBody setResult(GetCollegeContactDeptDetailResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetCollegeContactDeptDetailResponseBodyResult getResult() {
        return this.result;
    }

    public GetCollegeContactDeptDetailResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class GetCollegeContactDeptDetailResponseBodyResultHideSceneConfig extends TeaModel {
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

        public static GetCollegeContactDeptDetailResponseBodyResultHideSceneConfig build(java.util.Map<String, ?> map) throws Exception {
            GetCollegeContactDeptDetailResponseBodyResultHideSceneConfig self = new GetCollegeContactDeptDetailResponseBodyResultHideSceneConfig();
            return TeaModel.build(map, self);
        }

        public GetCollegeContactDeptDetailResponseBodyResultHideSceneConfig setActive(Boolean active) {
            this.active = active;
            return this;
        }
        public Boolean getActive() {
            return this.active;
        }

        public GetCollegeContactDeptDetailResponseBodyResultHideSceneConfig setChatboxSubtitle(Boolean chatboxSubtitle) {
            this.chatboxSubtitle = chatboxSubtitle;
            return this;
        }
        public Boolean getChatboxSubtitle() {
            return this.chatboxSubtitle;
        }

        public GetCollegeContactDeptDetailResponseBodyResultHideSceneConfig setNodeList(Boolean nodeList) {
            this.nodeList = nodeList;
            return this;
        }
        public Boolean getNodeList() {
            return this.nodeList;
        }

        public GetCollegeContactDeptDetailResponseBodyResultHideSceneConfig setProfile(Boolean profile) {
            this.profile = profile;
            return this;
        }
        public Boolean getProfile() {
            return this.profile;
        }

        public GetCollegeContactDeptDetailResponseBodyResultHideSceneConfig setSearch(Boolean search) {
            this.search = search;
            return this;
        }
        public Boolean getSearch() {
            return this.search;
        }

    }

    public static class GetCollegeContactDeptDetailResponseBodyResultOuterSceneConfig extends TeaModel {
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

        public static GetCollegeContactDeptDetailResponseBodyResultOuterSceneConfig build(java.util.Map<String, ?> map) throws Exception {
            GetCollegeContactDeptDetailResponseBodyResultOuterSceneConfig self = new GetCollegeContactDeptDetailResponseBodyResultOuterSceneConfig();
            return TeaModel.build(map, self);
        }

        public GetCollegeContactDeptDetailResponseBodyResultOuterSceneConfig setActive(Boolean active) {
            this.active = active;
            return this;
        }
        public Boolean getActive() {
            return this.active;
        }

        public GetCollegeContactDeptDetailResponseBodyResultOuterSceneConfig setChatboxSubtitle(Boolean chatboxSubtitle) {
            this.chatboxSubtitle = chatboxSubtitle;
            return this;
        }
        public Boolean getChatboxSubtitle() {
            return this.chatboxSubtitle;
        }

        public GetCollegeContactDeptDetailResponseBodyResultOuterSceneConfig setNodeList(Boolean nodeList) {
            this.nodeList = nodeList;
            return this;
        }
        public Boolean getNodeList() {
            return this.nodeList;
        }

        public GetCollegeContactDeptDetailResponseBodyResultOuterSceneConfig setProfile(Boolean profile) {
            this.profile = profile;
            return this;
        }
        public Boolean getProfile() {
            return this.profile;
        }

        public GetCollegeContactDeptDetailResponseBodyResultOuterSceneConfig setSearch(Boolean search) {
            this.search = search;
            return this;
        }
        public Boolean getSearch() {
            return this.search;
        }

    }

    public static class GetCollegeContactDeptDetailResponseBodyResult extends TeaModel {
        @NameInMap("autoAddUser")
        public Boolean autoAddUser;

        @NameInMap("autoApproveApply")
        public Boolean autoApproveApply;

        /**
         * <strong>example:</strong>
         * <p>这是简介</p>
         */
        @NameInMap("brief")
        public String brief;

        /**
         * <strong>example:</strong>
         * <p>10000</p>
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
         * <p>chat234</p>
         */
        @NameInMap("deptGroupChatId")
        public String deptGroupChatId;

        /**
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

        /**
         * <strong>example:</strong>
         * <p>{}</p>
         */
        @NameInMap("extension")
        public String extension;

        @NameInMap("fromUnionOrg")
        public Boolean fromUnionOrg;

        @NameInMap("groupContainSubDept")
        public Boolean groupContainSubDept;

        @NameInMap("hideDept")
        public Boolean hideDept;

        @NameInMap("hideSceneConfig")
        public GetCollegeContactDeptDetailResponseBodyResultHideSceneConfig hideSceneConfig;

        /**
         * <strong>example:</strong>
         * <p>软件工程</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>200</p>
         */
        @NameInMap("order")
        public Long order;

        /**
         * <strong>example:</strong>
         * <p>user345</p>
         */
        @NameInMap("orgDeptOwner")
        public String orgDeptOwner;

        @NameInMap("outerDept")
        public Boolean outerDept;

        @NameInMap("outerPermitDepts")
        public java.util.List<Long> outerPermitDepts;

        @NameInMap("outerPermitUsers")
        public java.util.List<String> outerPermitUsers;

        @NameInMap("outerSceneConfig")
        public GetCollegeContactDeptDetailResponseBodyResultOuterSceneConfig outerSceneConfig;

        /**
         * <strong>example:</strong>
         * <p>200</p>
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
         * <p>200</p>
         */
        @NameInMap("struId")
        public Long struId;

        /**
         * <strong>example:</strong>
         * <p>campus</p>
         */
        @NameInMap("tags")
        public String tags;

        /**
         * <strong>example:</strong>
         * <p>138xxxx0000</p>
         */
        @NameInMap("telephone")
        public String telephone;

        @NameInMap("userPermits")
        public java.util.List<String> userPermits;

        public static GetCollegeContactDeptDetailResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetCollegeContactDeptDetailResponseBodyResult self = new GetCollegeContactDeptDetailResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetCollegeContactDeptDetailResponseBodyResult setAutoAddUser(Boolean autoAddUser) {
            this.autoAddUser = autoAddUser;
            return this;
        }
        public Boolean getAutoAddUser() {
            return this.autoAddUser;
        }

        public GetCollegeContactDeptDetailResponseBodyResult setAutoApproveApply(Boolean autoApproveApply) {
            this.autoApproveApply = autoApproveApply;
            return this;
        }
        public Boolean getAutoApproveApply() {
            return this.autoApproveApply;
        }

        public GetCollegeContactDeptDetailResponseBodyResult setBrief(String brief) {
            this.brief = brief;
            return this;
        }
        public String getBrief() {
            return this.brief;
        }

        public GetCollegeContactDeptDetailResponseBodyResult setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public GetCollegeContactDeptDetailResponseBodyResult setCreateDeptGroup(Boolean createDeptGroup) {
            this.createDeptGroup = createDeptGroup;
            return this;
        }
        public Boolean getCreateDeptGroup() {
            return this.createDeptGroup;
        }

        public GetCollegeContactDeptDetailResponseBodyResult setDeptCode(String deptCode) {
            this.deptCode = deptCode;
            return this;
        }
        public String getDeptCode() {
            return this.deptCode;
        }

        public GetCollegeContactDeptDetailResponseBodyResult setDeptGroupChatId(String deptGroupChatId) {
            this.deptGroupChatId = deptGroupChatId;
            return this;
        }
        public String getDeptGroupChatId() {
            return this.deptGroupChatId;
        }

        public GetCollegeContactDeptDetailResponseBodyResult setDeptId(Long deptId) {
            this.deptId = deptId;
            return this;
        }
        public Long getDeptId() {
            return this.deptId;
        }

        public GetCollegeContactDeptDetailResponseBodyResult setDeptManagerUseridList(java.util.List<String> deptManagerUseridList) {
            this.deptManagerUseridList = deptManagerUseridList;
            return this;
        }
        public java.util.List<String> getDeptManagerUseridList() {
            return this.deptManagerUseridList;
        }

        public GetCollegeContactDeptDetailResponseBodyResult setDeptPermits(java.util.List<Long> deptPermits) {
            this.deptPermits = deptPermits;
            return this;
        }
        public java.util.List<Long> getDeptPermits() {
            return this.deptPermits;
        }

        public GetCollegeContactDeptDetailResponseBodyResult setDeptType(String deptType) {
            this.deptType = deptType;
            return this;
        }
        public String getDeptType() {
            return this.deptType;
        }

        public GetCollegeContactDeptDetailResponseBodyResult setEmpApplyJoinDept(Boolean empApplyJoinDept) {
            this.empApplyJoinDept = empApplyJoinDept;
            return this;
        }
        public Boolean getEmpApplyJoinDept() {
            return this.empApplyJoinDept;
        }

        public GetCollegeContactDeptDetailResponseBodyResult setExtension(String extension) {
            this.extension = extension;
            return this;
        }
        public String getExtension() {
            return this.extension;
        }

        public GetCollegeContactDeptDetailResponseBodyResult setFromUnionOrg(Boolean fromUnionOrg) {
            this.fromUnionOrg = fromUnionOrg;
            return this;
        }
        public Boolean getFromUnionOrg() {
            return this.fromUnionOrg;
        }

        public GetCollegeContactDeptDetailResponseBodyResult setGroupContainSubDept(Boolean groupContainSubDept) {
            this.groupContainSubDept = groupContainSubDept;
            return this;
        }
        public Boolean getGroupContainSubDept() {
            return this.groupContainSubDept;
        }

        public GetCollegeContactDeptDetailResponseBodyResult setHideDept(Boolean hideDept) {
            this.hideDept = hideDept;
            return this;
        }
        public Boolean getHideDept() {
            return this.hideDept;
        }

        public GetCollegeContactDeptDetailResponseBodyResult setHideSceneConfig(GetCollegeContactDeptDetailResponseBodyResultHideSceneConfig hideSceneConfig) {
            this.hideSceneConfig = hideSceneConfig;
            return this;
        }
        public GetCollegeContactDeptDetailResponseBodyResultHideSceneConfig getHideSceneConfig() {
            return this.hideSceneConfig;
        }

        public GetCollegeContactDeptDetailResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetCollegeContactDeptDetailResponseBodyResult setOrder(Long order) {
            this.order = order;
            return this;
        }
        public Long getOrder() {
            return this.order;
        }

        public GetCollegeContactDeptDetailResponseBodyResult setOrgDeptOwner(String orgDeptOwner) {
            this.orgDeptOwner = orgDeptOwner;
            return this;
        }
        public String getOrgDeptOwner() {
            return this.orgDeptOwner;
        }

        public GetCollegeContactDeptDetailResponseBodyResult setOuterDept(Boolean outerDept) {
            this.outerDept = outerDept;
            return this;
        }
        public Boolean getOuterDept() {
            return this.outerDept;
        }

        public GetCollegeContactDeptDetailResponseBodyResult setOuterPermitDepts(java.util.List<Long> outerPermitDepts) {
            this.outerPermitDepts = outerPermitDepts;
            return this;
        }
        public java.util.List<Long> getOuterPermitDepts() {
            return this.outerPermitDepts;
        }

        public GetCollegeContactDeptDetailResponseBodyResult setOuterPermitUsers(java.util.List<String> outerPermitUsers) {
            this.outerPermitUsers = outerPermitUsers;
            return this;
        }
        public java.util.List<String> getOuterPermitUsers() {
            return this.outerPermitUsers;
        }

        public GetCollegeContactDeptDetailResponseBodyResult setOuterSceneConfig(GetCollegeContactDeptDetailResponseBodyResultOuterSceneConfig outerSceneConfig) {
            this.outerSceneConfig = outerSceneConfig;
            return this;
        }
        public GetCollegeContactDeptDetailResponseBodyResultOuterSceneConfig getOuterSceneConfig() {
            return this.outerSceneConfig;
        }

        public GetCollegeContactDeptDetailResponseBodyResult setParentId(Long parentId) {
            this.parentId = parentId;
            return this;
        }
        public Long getParentId() {
            return this.parentId;
        }

        public GetCollegeContactDeptDetailResponseBodyResult setSourceIdentifier(String sourceIdentifier) {
            this.sourceIdentifier = sourceIdentifier;
            return this;
        }
        public String getSourceIdentifier() {
            return this.sourceIdentifier;
        }

        public GetCollegeContactDeptDetailResponseBodyResult setStruId(Long struId) {
            this.struId = struId;
            return this;
        }
        public Long getStruId() {
            return this.struId;
        }

        public GetCollegeContactDeptDetailResponseBodyResult setTags(String tags) {
            this.tags = tags;
            return this;
        }
        public String getTags() {
            return this.tags;
        }

        public GetCollegeContactDeptDetailResponseBodyResult setTelephone(String telephone) {
            this.telephone = telephone;
            return this;
        }
        public String getTelephone() {
            return this.telephone;
        }

        public GetCollegeContactDeptDetailResponseBodyResult setUserPermits(java.util.List<String> userPermits) {
            this.userPermits = userPermits;
            return this;
        }
        public java.util.List<String> getUserPermits() {
            return this.userPermits;
        }

    }

}
