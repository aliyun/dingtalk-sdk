// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryAllMemberByDeptResponseBody extends TeaModel {
    // 人员列表
    @NameInMap("content")
    public java.util.List<QueryAllMemberByDeptResponseBodyContent> content;

    // 总页数
    @NameInMap("totalPages")
    public Integer totalPages;

    // 数据总量
    @NameInMap("totalCount")
    public Long totalCount;

    // 当前页码
    @NameInMap("currentPage")
    public Integer currentPage;

    public static QueryAllMemberByDeptResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryAllMemberByDeptResponseBody self = new QueryAllMemberByDeptResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryAllMemberByDeptResponseBody setContent(java.util.List<QueryAllMemberByDeptResponseBodyContent> content) {
        this.content = content;
        return this;
    }
    public java.util.List<QueryAllMemberByDeptResponseBodyContent> getContent() {
        return this.content;
    }

    public QueryAllMemberByDeptResponseBody setTotalPages(Integer totalPages) {
        this.totalPages = totalPages;
        return this;
    }
    public Integer getTotalPages() {
        return this.totalPages;
    }

    public QueryAllMemberByDeptResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public QueryAllMemberByDeptResponseBody setCurrentPage(Integer currentPage) {
        this.currentPage = currentPage;
        return this;
    }
    public Integer getCurrentPage() {
        return this.currentPage;
    }

    public static class QueryAllMemberByDeptResponseBodyContentJob extends TeaModel {
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

        public static QueryAllMemberByDeptResponseBodyContentJob build(java.util.Map<String, ?> map) throws Exception {
            QueryAllMemberByDeptResponseBodyContentJob self = new QueryAllMemberByDeptResponseBodyContentJob();
            return TeaModel.build(map, self);
        }

        public QueryAllMemberByDeptResponseBodyContentJob setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public QueryAllMemberByDeptResponseBodyContentJob setBizType(String bizType) {
            this.bizType = bizType;
            return this;
        }
        public String getBizType() {
            return this.bizType;
        }

        public QueryAllMemberByDeptResponseBodyContentJob setCategory(String category) {
            this.category = category;
            return this;
        }
        public String getCategory() {
            return this.category;
        }

        public QueryAllMemberByDeptResponseBodyContentJob setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

    }

    public static class QueryAllMemberByDeptResponseBodyContentJobStatus extends TeaModel {
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

        public static QueryAllMemberByDeptResponseBodyContentJobStatus build(java.util.Map<String, ?> map) throws Exception {
            QueryAllMemberByDeptResponseBodyContentJobStatus self = new QueryAllMemberByDeptResponseBodyContentJobStatus();
            return TeaModel.build(map, self);
        }

        public QueryAllMemberByDeptResponseBodyContentJobStatus setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public QueryAllMemberByDeptResponseBodyContentJobStatus setBizType(String bizType) {
            this.bizType = bizType;
            return this;
        }
        public String getBizType() {
            return this.bizType;
        }

        public QueryAllMemberByDeptResponseBodyContentJobStatus setCategory(String category) {
            this.category = category;
            return this;
        }
        public String getCategory() {
            return this.category;
        }

        public QueryAllMemberByDeptResponseBodyContentJobStatus setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

    }

    public static class QueryAllMemberByDeptResponseBodyContentUserProb extends TeaModel {
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

        public static QueryAllMemberByDeptResponseBodyContentUserProb build(java.util.Map<String, ?> map) throws Exception {
            QueryAllMemberByDeptResponseBodyContentUserProb self = new QueryAllMemberByDeptResponseBodyContentUserProb();
            return TeaModel.build(map, self);
        }

        public QueryAllMemberByDeptResponseBodyContentUserProb setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public QueryAllMemberByDeptResponseBodyContentUserProb setBizType(String bizType) {
            this.bizType = bizType;
            return this;
        }
        public String getBizType() {
            return this.bizType;
        }

        public QueryAllMemberByDeptResponseBodyContentUserProb setCategory(String category) {
            this.category = category;
            return this;
        }
        public String getCategory() {
            return this.category;
        }

        public QueryAllMemberByDeptResponseBodyContentUserProb setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

    }

    public static class QueryAllMemberByDeptResponseBodyContent extends TeaModel {
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
        public QueryAllMemberByDeptResponseBodyContentJob job;

        // 工号
        @NameInMap("jobNum")
        public String jobNum;

        // 工作状态标签
        @NameInMap("jobStatus")
        public QueryAllMemberByDeptResponseBodyContentJobStatus jobStatus;

        // 人员属性标签
        @NameInMap("userProb")
        public QueryAllMemberByDeptResponseBodyContentUserProb userProb;

        public static QueryAllMemberByDeptResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            QueryAllMemberByDeptResponseBodyContent self = new QueryAllMemberByDeptResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public QueryAllMemberByDeptResponseBodyContent setStaffId(String staffId) {
            this.staffId = staffId;
            return this;
        }
        public String getStaffId() {
            return this.staffId;
        }

        public QueryAllMemberByDeptResponseBodyContent setUid(String uid) {
            this.uid = uid;
            return this;
        }
        public String getUid() {
            return this.uid;
        }

        public QueryAllMemberByDeptResponseBodyContent setUserName(String userName) {
            this.userName = userName;
            return this;
        }
        public String getUserName() {
            return this.userName;
        }

        public QueryAllMemberByDeptResponseBodyContent setJob(QueryAllMemberByDeptResponseBodyContentJob job) {
            this.job = job;
            return this;
        }
        public QueryAllMemberByDeptResponseBodyContentJob getJob() {
            return this.job;
        }

        public QueryAllMemberByDeptResponseBodyContent setJobNum(String jobNum) {
            this.jobNum = jobNum;
            return this;
        }
        public String getJobNum() {
            return this.jobNum;
        }

        public QueryAllMemberByDeptResponseBodyContent setJobStatus(QueryAllMemberByDeptResponseBodyContentJobStatus jobStatus) {
            this.jobStatus = jobStatus;
            return this;
        }
        public QueryAllMemberByDeptResponseBodyContentJobStatus getJobStatus() {
            return this.jobStatus;
        }

        public QueryAllMemberByDeptResponseBodyContent setUserProb(QueryAllMemberByDeptResponseBodyContentUserProb userProb) {
            this.userProb = userProb;
            return this;
        }
        public QueryAllMemberByDeptResponseBodyContentUserProb getUserProb() {
            return this.userProb;
        }

    }

}
