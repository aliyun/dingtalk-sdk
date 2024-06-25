// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryAllGroupsInDeptResponseBody extends TeaModel {
    @NameInMap("content")
    public java.util.List<QueryAllGroupsInDeptResponseBodyContent> content;

    @NameInMap("currentPage")
    public Long currentPage;

    @NameInMap("totalCount")
    public Long totalCount;

    @NameInMap("totalPages")
    public Long totalPages;

    public static QueryAllGroupsInDeptResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryAllGroupsInDeptResponseBody self = new QueryAllGroupsInDeptResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryAllGroupsInDeptResponseBody setContent(java.util.List<QueryAllGroupsInDeptResponseBodyContent> content) {
        this.content = content;
        return this;
    }
    public java.util.List<QueryAllGroupsInDeptResponseBodyContent> getContent() {
        return this.content;
    }

    public QueryAllGroupsInDeptResponseBody setCurrentPage(Long currentPage) {
        this.currentPage = currentPage;
        return this;
    }
    public Long getCurrentPage() {
        return this.currentPage;
    }

    public QueryAllGroupsInDeptResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public QueryAllGroupsInDeptResponseBody setTotalPages(Long totalPages) {
        this.totalPages = totalPages;
        return this;
    }
    public Long getTotalPages() {
        return this.totalPages;
    }

    public static class QueryAllGroupsInDeptResponseBodyContent extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>12</p>
         */
        @NameInMap("deptId")
        public Long deptId;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("id")
        public Long id;

        /**
         * <strong>example:</strong>
         * <p>医疗组1</p>
         */
        @NameInMap("name")
        public String name;

        public static QueryAllGroupsInDeptResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            QueryAllGroupsInDeptResponseBodyContent self = new QueryAllGroupsInDeptResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public QueryAllGroupsInDeptResponseBodyContent setDeptId(Long deptId) {
            this.deptId = deptId;
            return this;
        }
        public Long getDeptId() {
            return this.deptId;
        }

        public QueryAllGroupsInDeptResponseBodyContent setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public QueryAllGroupsInDeptResponseBodyContent setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

}
