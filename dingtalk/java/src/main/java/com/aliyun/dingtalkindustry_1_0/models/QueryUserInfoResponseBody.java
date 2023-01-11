// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryUserInfoResponseBody extends TeaModel {
    /**
     * <p>人员详情</p>
     */
    @NameInMap("content")
    public QueryUserInfoResponseBodyContent content;

    public static QueryUserInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryUserInfoResponseBody self = new QueryUserInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryUserInfoResponseBody setContent(QueryUserInfoResponseBodyContent content) {
        this.content = content;
        return this;
    }
    public QueryUserInfoResponseBodyContent getContent() {
        return this.content;
    }

    public static class QueryUserInfoResponseBodyContentDept extends TeaModel {
        /**
         * <p>创建时间</p>
         */
        @NameInMap("gmtCreateStr")
        public String gmtCreateStr;

        /**
         * <p>修改时间</p>
         */
        @NameInMap("gmtModifiedStr")
        public String gmtModifiedStr;

        /**
         * <p>科室Id</p>
         */
        @NameInMap("id")
        public Long id;

        /**
         * <p>科室名称</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>人科关联id</p>
         */
        @NameInMap("relId")
        public Long relId;

        public static QueryUserInfoResponseBodyContentDept build(java.util.Map<String, ?> map) throws Exception {
            QueryUserInfoResponseBodyContentDept self = new QueryUserInfoResponseBodyContentDept();
            return TeaModel.build(map, self);
        }

        public QueryUserInfoResponseBodyContentDept setGmtCreateStr(String gmtCreateStr) {
            this.gmtCreateStr = gmtCreateStr;
            return this;
        }
        public String getGmtCreateStr() {
            return this.gmtCreateStr;
        }

        public QueryUserInfoResponseBodyContentDept setGmtModifiedStr(String gmtModifiedStr) {
            this.gmtModifiedStr = gmtModifiedStr;
            return this;
        }
        public String getGmtModifiedStr() {
            return this.gmtModifiedStr;
        }

        public QueryUserInfoResponseBodyContentDept setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public QueryUserInfoResponseBodyContentDept setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public QueryUserInfoResponseBodyContentDept setRelId(Long relId) {
            this.relId = relId;
            return this;
        }
        public Long getRelId() {
            return this.relId;
        }

    }

    public static class QueryUserInfoResponseBodyContentGroup extends TeaModel {
        /**
         * <p>医疗组所在科室Id</p>
         */
        @NameInMap("deptId")
        public Long deptId;

        /**
         * <p>医疗组所在科室名称</p>
         */
        @NameInMap("deptName")
        public String deptName;

        @NameInMap("gmtCreateStr")
        public String gmtCreateStr;

        @NameInMap("gmtModifiedStr")
        public String gmtModifiedStr;

        /**
         * <p>医疗组Id</p>
         */
        @NameInMap("id")
        public Long id;

        /**
         * <p>医疗组名称</p>
         */
        @NameInMap("name")
        public String name;

        @NameInMap("relId")
        public Long relId;

        public static QueryUserInfoResponseBodyContentGroup build(java.util.Map<String, ?> map) throws Exception {
            QueryUserInfoResponseBodyContentGroup self = new QueryUserInfoResponseBodyContentGroup();
            return TeaModel.build(map, self);
        }

        public QueryUserInfoResponseBodyContentGroup setDeptId(Long deptId) {
            this.deptId = deptId;
            return this;
        }
        public Long getDeptId() {
            return this.deptId;
        }

        public QueryUserInfoResponseBodyContentGroup setDeptName(String deptName) {
            this.deptName = deptName;
            return this;
        }
        public String getDeptName() {
            return this.deptName;
        }

        public QueryUserInfoResponseBodyContentGroup setGmtCreateStr(String gmtCreateStr) {
            this.gmtCreateStr = gmtCreateStr;
            return this;
        }
        public String getGmtCreateStr() {
            return this.gmtCreateStr;
        }

        public QueryUserInfoResponseBodyContentGroup setGmtModifiedStr(String gmtModifiedStr) {
            this.gmtModifiedStr = gmtModifiedStr;
            return this;
        }
        public String getGmtModifiedStr() {
            return this.gmtModifiedStr;
        }

        public QueryUserInfoResponseBodyContentGroup setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public QueryUserInfoResponseBodyContentGroup setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public QueryUserInfoResponseBodyContentGroup setRelId(Long relId) {
            this.relId = relId;
            return this;
        }
        public Long getRelId() {
            return this.relId;
        }

    }

    public static class QueryUserInfoResponseBodyContentJob extends TeaModel {
        /**
         * <p>标签类型</p>
         */
        @NameInMap("bizType")
        public String bizType;

        /**
         * <p>分类</p>
         */
        @NameInMap("category")
        public String category;

        /**
         * <p>标签Code</p>
         */
        @NameInMap("code")
        public String code;

        /**
         * <p>展示名称</p>
         */
        @NameInMap("displayName")
        public String displayName;

        public static QueryUserInfoResponseBodyContentJob build(java.util.Map<String, ?> map) throws Exception {
            QueryUserInfoResponseBodyContentJob self = new QueryUserInfoResponseBodyContentJob();
            return TeaModel.build(map, self);
        }

        public QueryUserInfoResponseBodyContentJob setBizType(String bizType) {
            this.bizType = bizType;
            return this;
        }
        public String getBizType() {
            return this.bizType;
        }

        public QueryUserInfoResponseBodyContentJob setCategory(String category) {
            this.category = category;
            return this;
        }
        public String getCategory() {
            return this.category;
        }

        public QueryUserInfoResponseBodyContentJob setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public QueryUserInfoResponseBodyContentJob setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

    }

    public static class QueryUserInfoResponseBodyContentJobStatus extends TeaModel {
        /**
         * <p>标签类型</p>
         */
        @NameInMap("bizType")
        public String bizType;

        /**
         * <p>分类</p>
         */
        @NameInMap("category")
        public String category;

        /**
         * <p>标签Code</p>
         */
        @NameInMap("code")
        public String code;

        /**
         * <p>展示名称</p>
         */
        @NameInMap("displayName")
        public String displayName;

        public static QueryUserInfoResponseBodyContentJobStatus build(java.util.Map<String, ?> map) throws Exception {
            QueryUserInfoResponseBodyContentJobStatus self = new QueryUserInfoResponseBodyContentJobStatus();
            return TeaModel.build(map, self);
        }

        public QueryUserInfoResponseBodyContentJobStatus setBizType(String bizType) {
            this.bizType = bizType;
            return this;
        }
        public String getBizType() {
            return this.bizType;
        }

        public QueryUserInfoResponseBodyContentJobStatus setCategory(String category) {
            this.category = category;
            return this;
        }
        public String getCategory() {
            return this.category;
        }

        public QueryUserInfoResponseBodyContentJobStatus setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public QueryUserInfoResponseBodyContentJobStatus setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

    }

    public static class QueryUserInfoResponseBodyContentJobStatusList extends TeaModel {
        /**
         * <p>标签类型</p>
         */
        @NameInMap("bizType")
        public String bizType;

        /**
         * <p>分类</p>
         */
        @NameInMap("category")
        public String category;

        /**
         * <p>标签Code</p>
         */
        @NameInMap("code")
        public String code;

        /**
         * <p>展示名称</p>
         */
        @NameInMap("displayName")
        public String displayName;

        public static QueryUserInfoResponseBodyContentJobStatusList build(java.util.Map<String, ?> map) throws Exception {
            QueryUserInfoResponseBodyContentJobStatusList self = new QueryUserInfoResponseBodyContentJobStatusList();
            return TeaModel.build(map, self);
        }

        public QueryUserInfoResponseBodyContentJobStatusList setBizType(String bizType) {
            this.bizType = bizType;
            return this;
        }
        public String getBizType() {
            return this.bizType;
        }

        public QueryUserInfoResponseBodyContentJobStatusList setCategory(String category) {
            this.category = category;
            return this;
        }
        public String getCategory() {
            return this.category;
        }

        public QueryUserInfoResponseBodyContentJobStatusList setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public QueryUserInfoResponseBodyContentJobStatusList setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

    }

    public static class QueryUserInfoResponseBodyContentUserProb extends TeaModel {
        /**
         * <p>标签类型</p>
         */
        @NameInMap("bizType")
        public String bizType;

        /**
         * <p>分类</p>
         */
        @NameInMap("category")
        public String category;

        /**
         * <p>标签Code</p>
         */
        @NameInMap("code")
        public String code;

        /**
         * <p>展示名称</p>
         */
        @NameInMap("displayName")
        public String displayName;

        public static QueryUserInfoResponseBodyContentUserProb build(java.util.Map<String, ?> map) throws Exception {
            QueryUserInfoResponseBodyContentUserProb self = new QueryUserInfoResponseBodyContentUserProb();
            return TeaModel.build(map, self);
        }

        public QueryUserInfoResponseBodyContentUserProb setBizType(String bizType) {
            this.bizType = bizType;
            return this;
        }
        public String getBizType() {
            return this.bizType;
        }

        public QueryUserInfoResponseBodyContentUserProb setCategory(String category) {
            this.category = category;
            return this;
        }
        public String getCategory() {
            return this.category;
        }

        public QueryUserInfoResponseBodyContentUserProb setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public QueryUserInfoResponseBodyContentUserProb setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

    }

    public static class QueryUserInfoResponseBodyContent extends TeaModel {
        /**
         * <p>comments</p>
         */
        @NameInMap("comments")
        public String comments;

        /**
         * <p>所在科室</p>
         */
        @NameInMap("dept")
        public java.util.List<QueryUserInfoResponseBodyContentDept> dept;

        /**
         * <p>所在医疗组</p>
         */
        @NameInMap("group")
        public java.util.List<QueryUserInfoResponseBodyContentGroup> group;

        /**
         * <p>职称标签</p>
         */
        @NameInMap("job")
        public QueryUserInfoResponseBodyContentJob job;

        /**
         * <p>工号</p>
         */
        @NameInMap("jobNum")
        public String jobNum;

        /**
         * <p>工作状态标签, 已废弃, 请使用jobStatusList字段</p>
         */
        @NameInMap("jobStatus")
        public QueryUserInfoResponseBodyContentJobStatus jobStatus;

        /**
         * <p>工作状态标签</p>
         */
        @NameInMap("jobStatusList")
        public java.util.List<QueryUserInfoResponseBodyContentJobStatusList> jobStatusList;

        /**
         * <p>用户Id</p>
         */
        @NameInMap("uid")
        public String uid;

        /**
         * <p>用户名称</p>
         */
        @NameInMap("userName")
        public String userName;

        /**
         * <p>人员属性标签</p>
         */
        @NameInMap("userProb")
        public QueryUserInfoResponseBodyContentUserProb userProb;

        public static QueryUserInfoResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            QueryUserInfoResponseBodyContent self = new QueryUserInfoResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public QueryUserInfoResponseBodyContent setComments(String comments) {
            this.comments = comments;
            return this;
        }
        public String getComments() {
            return this.comments;
        }

        public QueryUserInfoResponseBodyContent setDept(java.util.List<QueryUserInfoResponseBodyContentDept> dept) {
            this.dept = dept;
            return this;
        }
        public java.util.List<QueryUserInfoResponseBodyContentDept> getDept() {
            return this.dept;
        }

        public QueryUserInfoResponseBodyContent setGroup(java.util.List<QueryUserInfoResponseBodyContentGroup> group) {
            this.group = group;
            return this;
        }
        public java.util.List<QueryUserInfoResponseBodyContentGroup> getGroup() {
            return this.group;
        }

        public QueryUserInfoResponseBodyContent setJob(QueryUserInfoResponseBodyContentJob job) {
            this.job = job;
            return this;
        }
        public QueryUserInfoResponseBodyContentJob getJob() {
            return this.job;
        }

        public QueryUserInfoResponseBodyContent setJobNum(String jobNum) {
            this.jobNum = jobNum;
            return this;
        }
        public String getJobNum() {
            return this.jobNum;
        }

        public QueryUserInfoResponseBodyContent setJobStatus(QueryUserInfoResponseBodyContentJobStatus jobStatus) {
            this.jobStatus = jobStatus;
            return this;
        }
        public QueryUserInfoResponseBodyContentJobStatus getJobStatus() {
            return this.jobStatus;
        }

        public QueryUserInfoResponseBodyContent setJobStatusList(java.util.List<QueryUserInfoResponseBodyContentJobStatusList> jobStatusList) {
            this.jobStatusList = jobStatusList;
            return this;
        }
        public java.util.List<QueryUserInfoResponseBodyContentJobStatusList> getJobStatusList() {
            return this.jobStatusList;
        }

        public QueryUserInfoResponseBodyContent setUid(String uid) {
            this.uid = uid;
            return this;
        }
        public String getUid() {
            return this.uid;
        }

        public QueryUserInfoResponseBodyContent setUserName(String userName) {
            this.userName = userName;
            return this;
        }
        public String getUserName() {
            return this.userName;
        }

        public QueryUserInfoResponseBodyContent setUserProb(QueryUserInfoResponseBodyContentUserProb userProb) {
            this.userProb = userProb;
            return this;
        }
        public QueryUserInfoResponseBodyContentUserProb getUserProb() {
            return this.userProb;
        }

    }

}
