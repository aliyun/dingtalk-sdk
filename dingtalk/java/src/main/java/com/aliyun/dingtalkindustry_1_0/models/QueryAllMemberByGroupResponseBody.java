// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryAllMemberByGroupResponseBody extends TeaModel {
    /**
     * <p>人员列表</p>
     */
    @NameInMap("content")
    public java.util.List<QueryAllMemberByGroupResponseBodyContent> content;

    /**
     * <p>当前页码</p>
     */
    @NameInMap("currentPage")
    public Integer currentPage;

    /**
     * <p>数据总量</p>
     */
    @NameInMap("totalCount")
    public Long totalCount;

    /**
     * <p>总页数</p>
     */
    @NameInMap("totalPages")
    public Integer totalPages;

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

    public QueryAllMemberByGroupResponseBody setCurrentPage(Integer currentPage) {
        this.currentPage = currentPage;
        return this;
    }
    public Integer getCurrentPage() {
        return this.currentPage;
    }

    public QueryAllMemberByGroupResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public QueryAllMemberByGroupResponseBody setTotalPages(Integer totalPages) {
        this.totalPages = totalPages;
        return this;
    }
    public Integer getTotalPages() {
        return this.totalPages;
    }

    public static class QueryAllMemberByGroupResponseBodyContent extends TeaModel {
        /**
         * <p>工号</p>
         */
        @NameInMap("jobNum")
        public String jobNum;

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

        public static QueryAllMemberByGroupResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            QueryAllMemberByGroupResponseBodyContent self = new QueryAllMemberByGroupResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public QueryAllMemberByGroupResponseBodyContent setJobNum(String jobNum) {
            this.jobNum = jobNum;
            return this;
        }
        public String getJobNum() {
            return this.jobNum;
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

    }

}
