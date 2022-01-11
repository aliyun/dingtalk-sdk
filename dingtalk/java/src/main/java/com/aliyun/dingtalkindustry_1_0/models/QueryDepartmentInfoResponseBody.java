// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryDepartmentInfoResponseBody extends TeaModel {
    // 科室详情
    @NameInMap("content")
    public QueryDepartmentInfoResponseBodyContent content;

    public static QueryDepartmentInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryDepartmentInfoResponseBody self = new QueryDepartmentInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryDepartmentInfoResponseBody setContent(QueryDepartmentInfoResponseBodyContent content) {
        this.content = content;
        return this;
    }
    public QueryDepartmentInfoResponseBodyContent getContent() {
        return this.content;
    }

    public static class QueryDepartmentInfoResponseBodyContentLeaderJob extends TeaModel {
        // 业务类型
        @NameInMap("bizType")
        public String bizType;

        // 分类
        @NameInMap("category")
        public String category;

        // 标签Code
        @NameInMap("code")
        public String code;

        // 展示名称
        @NameInMap("displayName")
        public String displayName;

        public static QueryDepartmentInfoResponseBodyContentLeaderJob build(java.util.Map<String, ?> map) throws Exception {
            QueryDepartmentInfoResponseBodyContentLeaderJob self = new QueryDepartmentInfoResponseBodyContentLeaderJob();
            return TeaModel.build(map, self);
        }

        public QueryDepartmentInfoResponseBodyContentLeaderJob setBizType(String bizType) {
            this.bizType = bizType;
            return this;
        }
        public String getBizType() {
            return this.bizType;
        }

        public QueryDepartmentInfoResponseBodyContentLeaderJob setCategory(String category) {
            this.category = category;
            return this;
        }
        public String getCategory() {
            return this.category;
        }

        public QueryDepartmentInfoResponseBodyContentLeaderJob setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public QueryDepartmentInfoResponseBodyContentLeaderJob setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

    }

    public static class QueryDepartmentInfoResponseBodyContentLeader extends TeaModel {
        // 工作标签
        @NameInMap("job")
        public QueryDepartmentInfoResponseBodyContentLeaderJob job;

        // 工号
        @NameInMap("jobNumber")
        public String jobNumber;

        // 姓名
        @NameInMap("name")
        public String name;

        // 人员Id
        @NameInMap("userId")
        public String userId;

        public static QueryDepartmentInfoResponseBodyContentLeader build(java.util.Map<String, ?> map) throws Exception {
            QueryDepartmentInfoResponseBodyContentLeader self = new QueryDepartmentInfoResponseBodyContentLeader();
            return TeaModel.build(map, self);
        }

        public QueryDepartmentInfoResponseBodyContentLeader setJob(QueryDepartmentInfoResponseBodyContentLeaderJob job) {
            this.job = job;
            return this;
        }
        public QueryDepartmentInfoResponseBodyContentLeaderJob getJob() {
            return this.job;
        }

        public QueryDepartmentInfoResponseBodyContentLeader setJobNumber(String jobNumber) {
            this.jobNumber = jobNumber;
            return this;
        }
        public String getJobNumber() {
            return this.jobNumber;
        }

        public QueryDepartmentInfoResponseBodyContentLeader setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public QueryDepartmentInfoResponseBodyContentLeader setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class QueryDepartmentInfoResponseBodyContentResidentLeaderJob extends TeaModel {
        // 业务类型
        @NameInMap("bizType")
        public String bizType;

        // 分类
        @NameInMap("category")
        public String category;

        // 标签Code
        @NameInMap("code")
        public String code;

        // 展示名称
        @NameInMap("displayName")
        public String displayName;

        public static QueryDepartmentInfoResponseBodyContentResidentLeaderJob build(java.util.Map<String, ?> map) throws Exception {
            QueryDepartmentInfoResponseBodyContentResidentLeaderJob self = new QueryDepartmentInfoResponseBodyContentResidentLeaderJob();
            return TeaModel.build(map, self);
        }

        public QueryDepartmentInfoResponseBodyContentResidentLeaderJob setBizType(String bizType) {
            this.bizType = bizType;
            return this;
        }
        public String getBizType() {
            return this.bizType;
        }

        public QueryDepartmentInfoResponseBodyContentResidentLeaderJob setCategory(String category) {
            this.category = category;
            return this;
        }
        public String getCategory() {
            return this.category;
        }

        public QueryDepartmentInfoResponseBodyContentResidentLeaderJob setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public QueryDepartmentInfoResponseBodyContentResidentLeaderJob setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

    }

    public static class QueryDepartmentInfoResponseBodyContentResidentLeader extends TeaModel {
        // 工作标签
        @NameInMap("job")
        public QueryDepartmentInfoResponseBodyContentResidentLeaderJob job;

        // 工号
        @NameInMap("jobNumber")
        public String jobNumber;

        // 姓名
        @NameInMap("name")
        public String name;

        // 人员Id
        @NameInMap("userId")
        public String userId;

        public static QueryDepartmentInfoResponseBodyContentResidentLeader build(java.util.Map<String, ?> map) throws Exception {
            QueryDepartmentInfoResponseBodyContentResidentLeader self = new QueryDepartmentInfoResponseBodyContentResidentLeader();
            return TeaModel.build(map, self);
        }

        public QueryDepartmentInfoResponseBodyContentResidentLeader setJob(QueryDepartmentInfoResponseBodyContentResidentLeaderJob job) {
            this.job = job;
            return this;
        }
        public QueryDepartmentInfoResponseBodyContentResidentLeaderJob getJob() {
            return this.job;
        }

        public QueryDepartmentInfoResponseBodyContentResidentLeader setJobNumber(String jobNumber) {
            this.jobNumber = jobNumber;
            return this;
        }
        public String getJobNumber() {
            return this.jobNumber;
        }

        public QueryDepartmentInfoResponseBodyContentResidentLeader setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public QueryDepartmentInfoResponseBodyContentResidentLeader setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class QueryDepartmentInfoResponseBodyContent extends TeaModel {
        // 科室Id
        @NameInMap("id")
        public Long id;

        // 科室主任
        @NameInMap("leader")
        public QueryDepartmentInfoResponseBodyContentLeader leader;

        // 科室名称
        @NameInMap("name")
        public String name;

        // 住院总医师
        @NameInMap("residentLeader")
        public QueryDepartmentInfoResponseBodyContentResidentLeader residentLeader;

        public static QueryDepartmentInfoResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            QueryDepartmentInfoResponseBodyContent self = new QueryDepartmentInfoResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public QueryDepartmentInfoResponseBodyContent setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public QueryDepartmentInfoResponseBodyContent setLeader(QueryDepartmentInfoResponseBodyContentLeader leader) {
            this.leader = leader;
            return this;
        }
        public QueryDepartmentInfoResponseBodyContentLeader getLeader() {
            return this.leader;
        }

        public QueryDepartmentInfoResponseBodyContent setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public QueryDepartmentInfoResponseBodyContent setResidentLeader(QueryDepartmentInfoResponseBodyContentResidentLeader residentLeader) {
            this.residentLeader = residentLeader;
            return this;
        }
        public QueryDepartmentInfoResponseBodyContentResidentLeader getResidentLeader() {
            return this.residentLeader;
        }

    }

}
