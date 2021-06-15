// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryAllDoctorsResponseBody extends TeaModel {
    // 人员列表
    @NameInMap("content")
    public java.util.List<QueryAllDoctorsResponseBodyContent> content;

    // 总页数
    @NameInMap("totalPages")
    public Integer totalPages;

    // 数据总量
    @NameInMap("totalCount")
    public Long totalCount;

    // 当前页码
    @NameInMap("currentPage")
    public Integer currentPage;

    public static QueryAllDoctorsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryAllDoctorsResponseBody self = new QueryAllDoctorsResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryAllDoctorsResponseBody setContent(java.util.List<QueryAllDoctorsResponseBodyContent> content) {
        this.content = content;
        return this;
    }
    public java.util.List<QueryAllDoctorsResponseBodyContent> getContent() {
        return this.content;
    }

    public QueryAllDoctorsResponseBody setTotalPages(Integer totalPages) {
        this.totalPages = totalPages;
        return this;
    }
    public Integer getTotalPages() {
        return this.totalPages;
    }

    public QueryAllDoctorsResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public QueryAllDoctorsResponseBody setCurrentPage(Integer currentPage) {
        this.currentPage = currentPage;
        return this;
    }
    public Integer getCurrentPage() {
        return this.currentPage;
    }

    public static class QueryAllDoctorsResponseBodyContentJob extends TeaModel {
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

        public static QueryAllDoctorsResponseBodyContentJob build(java.util.Map<String, ?> map) throws Exception {
            QueryAllDoctorsResponseBodyContentJob self = new QueryAllDoctorsResponseBodyContentJob();
            return TeaModel.build(map, self);
        }

        public QueryAllDoctorsResponseBodyContentJob setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public QueryAllDoctorsResponseBodyContentJob setBizType(String bizType) {
            this.bizType = bizType;
            return this;
        }
        public String getBizType() {
            return this.bizType;
        }

        public QueryAllDoctorsResponseBodyContentJob setCategory(String category) {
            this.category = category;
            return this;
        }
        public String getCategory() {
            return this.category;
        }

        public QueryAllDoctorsResponseBodyContentJob setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

    }

    public static class QueryAllDoctorsResponseBodyContentJobStatus extends TeaModel {
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

        public static QueryAllDoctorsResponseBodyContentJobStatus build(java.util.Map<String, ?> map) throws Exception {
            QueryAllDoctorsResponseBodyContentJobStatus self = new QueryAllDoctorsResponseBodyContentJobStatus();
            return TeaModel.build(map, self);
        }

        public QueryAllDoctorsResponseBodyContentJobStatus setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public QueryAllDoctorsResponseBodyContentJobStatus setBizType(String bizType) {
            this.bizType = bizType;
            return this;
        }
        public String getBizType() {
            return this.bizType;
        }

        public QueryAllDoctorsResponseBodyContentJobStatus setCategory(String category) {
            this.category = category;
            return this;
        }
        public String getCategory() {
            return this.category;
        }

        public QueryAllDoctorsResponseBodyContentJobStatus setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

    }

    public static class QueryAllDoctorsResponseBodyContentUserProb extends TeaModel {
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

        public static QueryAllDoctorsResponseBodyContentUserProb build(java.util.Map<String, ?> map) throws Exception {
            QueryAllDoctorsResponseBodyContentUserProb self = new QueryAllDoctorsResponseBodyContentUserProb();
            return TeaModel.build(map, self);
        }

        public QueryAllDoctorsResponseBodyContentUserProb setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public QueryAllDoctorsResponseBodyContentUserProb setBizType(String bizType) {
            this.bizType = bizType;
            return this;
        }
        public String getBizType() {
            return this.bizType;
        }

        public QueryAllDoctorsResponseBodyContentUserProb setCategory(String category) {
            this.category = category;
            return this;
        }
        public String getCategory() {
            return this.category;
        }

        public QueryAllDoctorsResponseBodyContentUserProb setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

    }

    public static class QueryAllDoctorsResponseBodyContent extends TeaModel {
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
        public QueryAllDoctorsResponseBodyContentJob job;

        // 工号
        @NameInMap("jobNum")
        public String jobNum;

        // 工作状态标签
        @NameInMap("jobStatus")
        public QueryAllDoctorsResponseBodyContentJobStatus jobStatus;

        // 人员属性标签
        @NameInMap("userProb")
        public QueryAllDoctorsResponseBodyContentUserProb userProb;

        public static QueryAllDoctorsResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            QueryAllDoctorsResponseBodyContent self = new QueryAllDoctorsResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public QueryAllDoctorsResponseBodyContent setStaffId(String staffId) {
            this.staffId = staffId;
            return this;
        }
        public String getStaffId() {
            return this.staffId;
        }

        public QueryAllDoctorsResponseBodyContent setUid(String uid) {
            this.uid = uid;
            return this;
        }
        public String getUid() {
            return this.uid;
        }

        public QueryAllDoctorsResponseBodyContent setUserName(String userName) {
            this.userName = userName;
            return this;
        }
        public String getUserName() {
            return this.userName;
        }

        public QueryAllDoctorsResponseBodyContent setJob(QueryAllDoctorsResponseBodyContentJob job) {
            this.job = job;
            return this;
        }
        public QueryAllDoctorsResponseBodyContentJob getJob() {
            return this.job;
        }

        public QueryAllDoctorsResponseBodyContent setJobNum(String jobNum) {
            this.jobNum = jobNum;
            return this;
        }
        public String getJobNum() {
            return this.jobNum;
        }

        public QueryAllDoctorsResponseBodyContent setJobStatus(QueryAllDoctorsResponseBodyContentJobStatus jobStatus) {
            this.jobStatus = jobStatus;
            return this;
        }
        public QueryAllDoctorsResponseBodyContentJobStatus getJobStatus() {
            return this.jobStatus;
        }

        public QueryAllDoctorsResponseBodyContent setUserProb(QueryAllDoctorsResponseBodyContentUserProb userProb) {
            this.userProb = userProb;
            return this;
        }
        public QueryAllDoctorsResponseBodyContentUserProb getUserProb() {
            return this.userProb;
        }

    }

}
