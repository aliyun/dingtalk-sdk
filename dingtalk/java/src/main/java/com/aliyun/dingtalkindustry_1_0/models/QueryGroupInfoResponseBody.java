// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryGroupInfoResponseBody extends TeaModel {
    // 医疗组详情
    @NameInMap("content")
    public QueryGroupInfoResponseBodyContent content;

    public static QueryGroupInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryGroupInfoResponseBody self = new QueryGroupInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryGroupInfoResponseBody setContent(QueryGroupInfoResponseBodyContent content) {
        this.content = content;
        return this;
    }
    public QueryGroupInfoResponseBodyContent getContent() {
        return this.content;
    }

    public static class QueryGroupInfoResponseBodyContentLeaderJob extends TeaModel {
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

        public static QueryGroupInfoResponseBodyContentLeaderJob build(java.util.Map<String, ?> map) throws Exception {
            QueryGroupInfoResponseBodyContentLeaderJob self = new QueryGroupInfoResponseBodyContentLeaderJob();
            return TeaModel.build(map, self);
        }

        public QueryGroupInfoResponseBodyContentLeaderJob setBizType(String bizType) {
            this.bizType = bizType;
            return this;
        }
        public String getBizType() {
            return this.bizType;
        }

        public QueryGroupInfoResponseBodyContentLeaderJob setCategory(String category) {
            this.category = category;
            return this;
        }
        public String getCategory() {
            return this.category;
        }

        public QueryGroupInfoResponseBodyContentLeaderJob setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public QueryGroupInfoResponseBodyContentLeaderJob setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

    }

    public static class QueryGroupInfoResponseBodyContentLeader extends TeaModel {
        // 工作标签
        @NameInMap("job")
        public QueryGroupInfoResponseBodyContentLeaderJob job;

        // 工号
        @NameInMap("jobNumber")
        public String jobNumber;

        // 姓名
        @NameInMap("name")
        public String name;

        // 人员Id
        @NameInMap("userId")
        public String userId;

        public static QueryGroupInfoResponseBodyContentLeader build(java.util.Map<String, ?> map) throws Exception {
            QueryGroupInfoResponseBodyContentLeader self = new QueryGroupInfoResponseBodyContentLeader();
            return TeaModel.build(map, self);
        }

        public QueryGroupInfoResponseBodyContentLeader setJob(QueryGroupInfoResponseBodyContentLeaderJob job) {
            this.job = job;
            return this;
        }
        public QueryGroupInfoResponseBodyContentLeaderJob getJob() {
            return this.job;
        }

        public QueryGroupInfoResponseBodyContentLeader setJobNumber(String jobNumber) {
            this.jobNumber = jobNumber;
            return this;
        }
        public String getJobNumber() {
            return this.jobNumber;
        }

        public QueryGroupInfoResponseBodyContentLeader setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public QueryGroupInfoResponseBodyContentLeader setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class QueryGroupInfoResponseBodyContent extends TeaModel {
        // 科室Id
        @NameInMap("deptId")
        public Long deptId;

        // 有效期结束时间
        @NameInMap("endTime")
        public Long endTime;

        // 医疗组Id
        @NameInMap("id")
        public Long id;

        // 医疗组组长
        @NameInMap("leader")
        public QueryGroupInfoResponseBodyContentLeader leader;

        // 医疗组名称
        @NameInMap("name")
        public String name;

        // 有效期开始时间
        @NameInMap("startTime")
        public Long startTime;

        public static QueryGroupInfoResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            QueryGroupInfoResponseBodyContent self = new QueryGroupInfoResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public QueryGroupInfoResponseBodyContent setDeptId(Long deptId) {
            this.deptId = deptId;
            return this;
        }
        public Long getDeptId() {
            return this.deptId;
        }

        public QueryGroupInfoResponseBodyContent setEndTime(Long endTime) {
            this.endTime = endTime;
            return this;
        }
        public Long getEndTime() {
            return this.endTime;
        }

        public QueryGroupInfoResponseBodyContent setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public QueryGroupInfoResponseBodyContent setLeader(QueryGroupInfoResponseBodyContentLeader leader) {
            this.leader = leader;
            return this;
        }
        public QueryGroupInfoResponseBodyContentLeader getLeader() {
            return this.leader;
        }

        public QueryGroupInfoResponseBodyContent setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public QueryGroupInfoResponseBodyContent setStartTime(Long startTime) {
            this.startTime = startTime;
            return this;
        }
        public Long getStartTime() {
            return this.startTime;
        }

    }

}
