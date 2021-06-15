// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryAllMemberByGroupResponseBody extends TeaModel {
    // 人员列表
    @NameInMap("content")
    public java.util.List<QueryAllMemberByGroupResponseBodyContent> content;

    // 总页数
    @NameInMap("totalPages")
    public Integer totalPages;

    // 数据总量
    @NameInMap("totalCount")
    public Long totalCount;

    // 当前页码
    @NameInMap("currentPage")
    public Integer currentPage;

    public static QueryAllMemberByGroupResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryAllMemberByGroupResponseBody self = new QueryAllMemberByGroupResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryAllMemberByGroupResponseBody setContent(java.util.List<QueryAllMemberByGroupResponseBodyContent> content) {
        this.content = content;
        return this;
    }
    public java.util.List<QueryAllMemberByGroupResponseBodyContent> getContent() {
        return this.content;
    }

    public QueryAllMemberByGroupResponseBody setTotalPages(Integer totalPages) {
        this.totalPages = totalPages;
        return this;
    }
    public Integer getTotalPages() {
        return this.totalPages;
    }

    public QueryAllMemberByGroupResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public QueryAllMemberByGroupResponseBody setCurrentPage(Integer currentPage) {
        this.currentPage = currentPage;
        return this;
    }
    public Integer getCurrentPage() {
        return this.currentPage;
    }

    public static class QueryAllMemberByGroupResponseBodyContentJob extends TeaModel {
        // 标签Code
        @NameInMap("code")
        public String code;

        // 标签类型
        @NameInMap("bizType")
        public String bizType;

        // 分类
        @NameInMap("category")
        public String category;

        // 展示名称
        @NameInMap("displayName")
        public String displayName;

        public static QueryAllMemberByGroupResponseBodyContentJob build(java.util.Map<String, ?> map) throws Exception {
            QueryAllMemberByGroupResponseBodyContentJob self = new QueryAllMemberByGroupResponseBodyContentJob();
            return TeaModel.build(map, self);
        }

        public QueryAllMemberByGroupResponseBodyContentJob setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public QueryAllMemberByGroupResponseBodyContentJob setBizType(String bizType) {
            this.bizType = bizType;
            return this;
        }
        public String getBizType() {
            return this.bizType;
        }

        public QueryAllMemberByGroupResponseBodyContentJob setCategory(String category) {
            this.category = category;
            return this;
        }
        public String getCategory() {
            return this.category;
        }

        public QueryAllMemberByGroupResponseBodyContentJob setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

    }

    public static class QueryAllMemberByGroupResponseBodyContentJobStatus extends TeaModel {
        // 标签Code
        @NameInMap("code")
        public String code;

        // 标签类型
        @NameInMap("bizType")
        public String bizType;

        // 分类
        @NameInMap("category")
        public String category;

        // 展示名称
        @NameInMap("displayName")
        public String displayName;

        public static QueryAllMemberByGroupResponseBodyContentJobStatus build(java.util.Map<String, ?> map) throws Exception {
            QueryAllMemberByGroupResponseBodyContentJobStatus self = new QueryAllMemberByGroupResponseBodyContentJobStatus();
            return TeaModel.build(map, self);
        }

        public QueryAllMemberByGroupResponseBodyContentJobStatus setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public QueryAllMemberByGroupResponseBodyContentJobStatus setBizType(String bizType) {
            this.bizType = bizType;
            return this;
        }
        public String getBizType() {
            return this.bizType;
        }

        public QueryAllMemberByGroupResponseBodyContentJobStatus setCategory(String category) {
            this.category = category;
            return this;
        }
        public String getCategory() {
            return this.category;
        }

        public QueryAllMemberByGroupResponseBodyContentJobStatus setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

    }

    public static class QueryAllMemberByGroupResponseBodyContentUserProb extends TeaModel {
        // 标签Code
        @NameInMap("code")
        public String code;

        // 标签类型
        @NameInMap("bizType")
        public String bizType;

        // 分类
        @NameInMap("category")
        public String category;

        // 展示名称
        @NameInMap("displayName")
        public String displayName;

        public static QueryAllMemberByGroupResponseBodyContentUserProb build(java.util.Map<String, ?> map) throws Exception {
            QueryAllMemberByGroupResponseBodyContentUserProb self = new QueryAllMemberByGroupResponseBodyContentUserProb();
            return TeaModel.build(map, self);
        }

        public QueryAllMemberByGroupResponseBodyContentUserProb setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public QueryAllMemberByGroupResponseBodyContentUserProb setBizType(String bizType) {
            this.bizType = bizType;
            return this;
        }
        public String getBizType() {
            return this.bizType;
        }

        public QueryAllMemberByGroupResponseBodyContentUserProb setCategory(String category) {
            this.category = category;
            return this;
        }
        public String getCategory() {
            return this.category;
        }

        public QueryAllMemberByGroupResponseBodyContentUserProb setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

    }

    public static class QueryAllMemberByGroupResponseBodyContent extends TeaModel {
        // 钉钉staffId
        @NameInMap("staffId")
        public String staffId;

        // 用户Id
        @NameInMap("uid")
        public String uid;

        // 用户名称
        @NameInMap("userName")
        public String userName;

        // 职称标签
        @NameInMap("job")
        public QueryAllMemberByGroupResponseBodyContentJob job;

        // 工号
        @NameInMap("jobNum")
        public String jobNum;

        // 工作状态标签
        @NameInMap("jobStatus")
        public QueryAllMemberByGroupResponseBodyContentJobStatus jobStatus;

        // 人员属性标签
        @NameInMap("userProb")
        public QueryAllMemberByGroupResponseBodyContentUserProb userProb;

        public static QueryAllMemberByGroupResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            QueryAllMemberByGroupResponseBodyContent self = new QueryAllMemberByGroupResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public QueryAllMemberByGroupResponseBodyContent setStaffId(String staffId) {
            this.staffId = staffId;
            return this;
        }
        public String getStaffId() {
            return this.staffId;
        }

        public QueryAllMemberByGroupResponseBodyContent setUid(String uid) {
            this.uid = uid;
            return this;
        }
        public String getUid() {
            return this.uid;
        }

        public QueryAllMemberByGroupResponseBodyContent setUserName(String userName) {
            this.userName = userName;
            return this;
        }
        public String getUserName() {
            return this.userName;
        }

        public QueryAllMemberByGroupResponseBodyContent setJob(QueryAllMemberByGroupResponseBodyContentJob job) {
            this.job = job;
            return this;
        }
        public QueryAllMemberByGroupResponseBodyContentJob getJob() {
            return this.job;
        }

        public QueryAllMemberByGroupResponseBodyContent setJobNum(String jobNum) {
            this.jobNum = jobNum;
            return this;
        }
        public String getJobNum() {
            return this.jobNum;
        }

        public QueryAllMemberByGroupResponseBodyContent setJobStatus(QueryAllMemberByGroupResponseBodyContentJobStatus jobStatus) {
            this.jobStatus = jobStatus;
            return this;
        }
        public QueryAllMemberByGroupResponseBodyContentJobStatus getJobStatus() {
            return this.jobStatus;
        }

        public QueryAllMemberByGroupResponseBodyContent setUserProb(QueryAllMemberByGroupResponseBodyContentUserProb userProb) {
            this.userProb = userProb;
            return this;
        }
        public QueryAllMemberByGroupResponseBodyContentUserProb getUserProb() {
            return this.userProb;
        }

    }

}
