// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryAllMemberByDeptResponseBody extends TeaModel {
    @NameInMap("content")
    public java.util.List<QueryAllMemberByDeptResponseBodyContent> content;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("currentPage")
    public Integer currentPage;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("totalCount")
    public Long totalCount;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("totalPages")
    public Integer totalPages;

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

    public QueryAllMemberByDeptResponseBody setCurrentPage(Integer currentPage) {
        this.currentPage = currentPage;
        return this;
    }
    public Integer getCurrentPage() {
        return this.currentPage;
    }

    public QueryAllMemberByDeptResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public QueryAllMemberByDeptResponseBody setTotalPages(Integer totalPages) {
        this.totalPages = totalPages;
        return this;
    }
    public Integer getTotalPages() {
        return this.totalPages;
    }

    public static class QueryAllMemberByDeptResponseBodyContent extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("jobNum")
        public String jobNum;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("uid")
        public String uid;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("userName")
        public String userName;

        public static QueryAllMemberByDeptResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            QueryAllMemberByDeptResponseBodyContent self = new QueryAllMemberByDeptResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public QueryAllMemberByDeptResponseBodyContent setJobNum(String jobNum) {
            this.jobNum = jobNum;
            return this;
        }
        public String getJobNum() {
            return this.jobNum;
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

    }

}
