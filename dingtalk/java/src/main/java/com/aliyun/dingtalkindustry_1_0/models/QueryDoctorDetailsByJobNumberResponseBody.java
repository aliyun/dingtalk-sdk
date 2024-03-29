// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryDoctorDetailsByJobNumberResponseBody extends TeaModel {
    @NameInMap("content")
    public QueryDoctorDetailsByJobNumberResponseBodyContent content;

    public static QueryDoctorDetailsByJobNumberResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryDoctorDetailsByJobNumberResponseBody self = new QueryDoctorDetailsByJobNumberResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryDoctorDetailsByJobNumberResponseBody setContent(QueryDoctorDetailsByJobNumberResponseBodyContent content) {
        this.content = content;
        return this;
    }
    public QueryDoctorDetailsByJobNumberResponseBodyContent getContent() {
        return this.content;
    }

    public static class QueryDoctorDetailsByJobNumberResponseBodyContentDeptList extends TeaModel {
        @NameInMap("categoryName")
        public String categoryName;

        @NameInMap("deptId")
        public Long deptId;

        @NameInMap("deptName")
        public String deptName;

        @NameInMap("gmtCreate")
        public String gmtCreate;

        @NameInMap("gmtModified")
        public String gmtModified;

        @NameInMap("relationId")
        public Long relationId;

        public static QueryDoctorDetailsByJobNumberResponseBodyContentDeptList build(java.util.Map<String, ?> map) throws Exception {
            QueryDoctorDetailsByJobNumberResponseBodyContentDeptList self = new QueryDoctorDetailsByJobNumberResponseBodyContentDeptList();
            return TeaModel.build(map, self);
        }

        public QueryDoctorDetailsByJobNumberResponseBodyContentDeptList setCategoryName(String categoryName) {
            this.categoryName = categoryName;
            return this;
        }
        public String getCategoryName() {
            return this.categoryName;
        }

        public QueryDoctorDetailsByJobNumberResponseBodyContentDeptList setDeptId(Long deptId) {
            this.deptId = deptId;
            return this;
        }
        public Long getDeptId() {
            return this.deptId;
        }

        public QueryDoctorDetailsByJobNumberResponseBodyContentDeptList setDeptName(String deptName) {
            this.deptName = deptName;
            return this;
        }
        public String getDeptName() {
            return this.deptName;
        }

        public QueryDoctorDetailsByJobNumberResponseBodyContentDeptList setGmtCreate(String gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public String getGmtCreate() {
            return this.gmtCreate;
        }

        public QueryDoctorDetailsByJobNumberResponseBodyContentDeptList setGmtModified(String gmtModified) {
            this.gmtModified = gmtModified;
            return this;
        }
        public String getGmtModified() {
            return this.gmtModified;
        }

        public QueryDoctorDetailsByJobNumberResponseBodyContentDeptList setRelationId(Long relationId) {
            this.relationId = relationId;
            return this;
        }
        public Long getRelationId() {
            return this.relationId;
        }

    }

    public static class QueryDoctorDetailsByJobNumberResponseBodyContentGroupList extends TeaModel {
        @NameInMap("deptId")
        public Long deptId;

        @NameInMap("deptName")
        public String deptName;

        @NameInMap("groupId")
        public Long groupId;

        @NameInMap("groupName")
        public String groupName;

        @NameInMap("isAssessGroup")
        public String isAssessGroup;

        @NameInMap("isLeader")
        public Boolean isLeader;

        @NameInMap("relationId")
        public Long relationId;

        public static QueryDoctorDetailsByJobNumberResponseBodyContentGroupList build(java.util.Map<String, ?> map) throws Exception {
            QueryDoctorDetailsByJobNumberResponseBodyContentGroupList self = new QueryDoctorDetailsByJobNumberResponseBodyContentGroupList();
            return TeaModel.build(map, self);
        }

        public QueryDoctorDetailsByJobNumberResponseBodyContentGroupList setDeptId(Long deptId) {
            this.deptId = deptId;
            return this;
        }
        public Long getDeptId() {
            return this.deptId;
        }

        public QueryDoctorDetailsByJobNumberResponseBodyContentGroupList setDeptName(String deptName) {
            this.deptName = deptName;
            return this;
        }
        public String getDeptName() {
            return this.deptName;
        }

        public QueryDoctorDetailsByJobNumberResponseBodyContentGroupList setGroupId(Long groupId) {
            this.groupId = groupId;
            return this;
        }
        public Long getGroupId() {
            return this.groupId;
        }

        public QueryDoctorDetailsByJobNumberResponseBodyContentGroupList setGroupName(String groupName) {
            this.groupName = groupName;
            return this;
        }
        public String getGroupName() {
            return this.groupName;
        }

        public QueryDoctorDetailsByJobNumberResponseBodyContentGroupList setIsAssessGroup(String isAssessGroup) {
            this.isAssessGroup = isAssessGroup;
            return this;
        }
        public String getIsAssessGroup() {
            return this.isAssessGroup;
        }

        public QueryDoctorDetailsByJobNumberResponseBodyContentGroupList setIsLeader(Boolean isLeader) {
            this.isLeader = isLeader;
            return this;
        }
        public Boolean getIsLeader() {
            return this.isLeader;
        }

        public QueryDoctorDetailsByJobNumberResponseBodyContentGroupList setRelationId(Long relationId) {
            this.relationId = relationId;
            return this;
        }
        public Long getRelationId() {
            return this.relationId;
        }

    }

    public static class QueryDoctorDetailsByJobNumberResponseBodyContentJobStatus extends TeaModel {
        @NameInMap("code")
        public String code;

        @NameInMap("statusName")
        public String statusName;

        public static QueryDoctorDetailsByJobNumberResponseBodyContentJobStatus build(java.util.Map<String, ?> map) throws Exception {
            QueryDoctorDetailsByJobNumberResponseBodyContentJobStatus self = new QueryDoctorDetailsByJobNumberResponseBodyContentJobStatus();
            return TeaModel.build(map, self);
        }

        public QueryDoctorDetailsByJobNumberResponseBodyContentJobStatus setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public QueryDoctorDetailsByJobNumberResponseBodyContentJobStatus setStatusName(String statusName) {
            this.statusName = statusName;
            return this;
        }
        public String getStatusName() {
            return this.statusName;
        }

    }

    public static class QueryDoctorDetailsByJobNumberResponseBodyContentProfessionalTitle extends TeaModel {
        @NameInMap("code")
        public String code;

        @NameInMap("professionalTitleCategory")
        public String professionalTitleCategory;

        @NameInMap("professionalTitleDetail")
        public String professionalTitleDetail;

        public static QueryDoctorDetailsByJobNumberResponseBodyContentProfessionalTitle build(java.util.Map<String, ?> map) throws Exception {
            QueryDoctorDetailsByJobNumberResponseBodyContentProfessionalTitle self = new QueryDoctorDetailsByJobNumberResponseBodyContentProfessionalTitle();
            return TeaModel.build(map, self);
        }

        public QueryDoctorDetailsByJobNumberResponseBodyContentProfessionalTitle setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public QueryDoctorDetailsByJobNumberResponseBodyContentProfessionalTitle setProfessionalTitleCategory(String professionalTitleCategory) {
            this.professionalTitleCategory = professionalTitleCategory;
            return this;
        }
        public String getProfessionalTitleCategory() {
            return this.professionalTitleCategory;
        }

        public QueryDoctorDetailsByJobNumberResponseBodyContentProfessionalTitle setProfessionalTitleDetail(String professionalTitleDetail) {
            this.professionalTitleDetail = professionalTitleDetail;
            return this;
        }
        public String getProfessionalTitleDetail() {
            return this.professionalTitleDetail;
        }

    }

    public static class QueryDoctorDetailsByJobNumberResponseBodyContentUserProbList extends TeaModel {
        @NameInMap("code")
        public String code;

        @NameInMap("userPropertyName")
        public String userPropertyName;

        public static QueryDoctorDetailsByJobNumberResponseBodyContentUserProbList build(java.util.Map<String, ?> map) throws Exception {
            QueryDoctorDetailsByJobNumberResponseBodyContentUserProbList self = new QueryDoctorDetailsByJobNumberResponseBodyContentUserProbList();
            return TeaModel.build(map, self);
        }

        public QueryDoctorDetailsByJobNumberResponseBodyContentUserProbList setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public QueryDoctorDetailsByJobNumberResponseBodyContentUserProbList setUserPropertyName(String userPropertyName) {
            this.userPropertyName = userPropertyName;
            return this;
        }
        public String getUserPropertyName() {
            return this.userPropertyName;
        }

    }

    public static class QueryDoctorDetailsByJobNumberResponseBodyContent extends TeaModel {
        @NameInMap("deptList")
        public java.util.List<QueryDoctorDetailsByJobNumberResponseBodyContentDeptList> deptList;

        @NameInMap("groupList")
        public java.util.List<QueryDoctorDetailsByJobNumberResponseBodyContentGroupList> groupList;

        @NameInMap("jobNumber")
        public String jobNumber;

        @NameInMap("jobStatus")
        public java.util.List<QueryDoctorDetailsByJobNumberResponseBodyContentJobStatus> jobStatus;

        @NameInMap("professionalTitle")
        public QueryDoctorDetailsByJobNumberResponseBodyContentProfessionalTitle professionalTitle;

        @NameInMap("userId")
        public String userId;

        @NameInMap("userName")
        public String userName;

        @NameInMap("userProbList")
        public java.util.List<QueryDoctorDetailsByJobNumberResponseBodyContentUserProbList> userProbList;

        public static QueryDoctorDetailsByJobNumberResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            QueryDoctorDetailsByJobNumberResponseBodyContent self = new QueryDoctorDetailsByJobNumberResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public QueryDoctorDetailsByJobNumberResponseBodyContent setDeptList(java.util.List<QueryDoctorDetailsByJobNumberResponseBodyContentDeptList> deptList) {
            this.deptList = deptList;
            return this;
        }
        public java.util.List<QueryDoctorDetailsByJobNumberResponseBodyContentDeptList> getDeptList() {
            return this.deptList;
        }

        public QueryDoctorDetailsByJobNumberResponseBodyContent setGroupList(java.util.List<QueryDoctorDetailsByJobNumberResponseBodyContentGroupList> groupList) {
            this.groupList = groupList;
            return this;
        }
        public java.util.List<QueryDoctorDetailsByJobNumberResponseBodyContentGroupList> getGroupList() {
            return this.groupList;
        }

        public QueryDoctorDetailsByJobNumberResponseBodyContent setJobNumber(String jobNumber) {
            this.jobNumber = jobNumber;
            return this;
        }
        public String getJobNumber() {
            return this.jobNumber;
        }

        public QueryDoctorDetailsByJobNumberResponseBodyContent setJobStatus(java.util.List<QueryDoctorDetailsByJobNumberResponseBodyContentJobStatus> jobStatus) {
            this.jobStatus = jobStatus;
            return this;
        }
        public java.util.List<QueryDoctorDetailsByJobNumberResponseBodyContentJobStatus> getJobStatus() {
            return this.jobStatus;
        }

        public QueryDoctorDetailsByJobNumberResponseBodyContent setProfessionalTitle(QueryDoctorDetailsByJobNumberResponseBodyContentProfessionalTitle professionalTitle) {
            this.professionalTitle = professionalTitle;
            return this;
        }
        public QueryDoctorDetailsByJobNumberResponseBodyContentProfessionalTitle getProfessionalTitle() {
            return this.professionalTitle;
        }

        public QueryDoctorDetailsByJobNumberResponseBodyContent setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public QueryDoctorDetailsByJobNumberResponseBodyContent setUserName(String userName) {
            this.userName = userName;
            return this;
        }
        public String getUserName() {
            return this.userName;
        }

        public QueryDoctorDetailsByJobNumberResponseBodyContent setUserProbList(java.util.List<QueryDoctorDetailsByJobNumberResponseBodyContentUserProbList> userProbList) {
            this.userProbList = userProbList;
            return this;
        }
        public java.util.List<QueryDoctorDetailsByJobNumberResponseBodyContentUserProbList> getUserProbList() {
            return this.userProbList;
        }

    }

}
