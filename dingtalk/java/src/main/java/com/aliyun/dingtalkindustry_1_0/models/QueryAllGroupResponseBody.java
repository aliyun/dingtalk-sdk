// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryAllGroupResponseBody extends TeaModel {
    /**
     * <p>Id of the request</p>
     */
    @NameInMap("content")
    public java.util.List<QueryAllGroupResponseBodyContent> content;

    /**
     * <p>当前页码</p>
     */
    @NameInMap("currentPage")
    public Long currentPage;

    /**
     * <p>数据总量</p>
     */
    @NameInMap("totalCount")
    public Long totalCount;

    /**
     * <p>总页数</p>
     */
    @NameInMap("totalPages")
    public Long totalPages;

    public static QueryAllGroupResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryAllGroupResponseBody self = new QueryAllGroupResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryAllGroupResponseBody setContent(java.util.List<QueryAllGroupResponseBodyContent> content) {
        this.content = content;
        return this;
    }
    public java.util.List<QueryAllGroupResponseBodyContent> getContent() {
        return this.content;
    }

    public QueryAllGroupResponseBody setCurrentPage(Long currentPage) {
        this.currentPage = currentPage;
        return this;
    }
    public Long getCurrentPage() {
        return this.currentPage;
    }

    public QueryAllGroupResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public QueryAllGroupResponseBody setTotalPages(Long totalPages) {
        this.totalPages = totalPages;
        return this;
    }
    public Long getTotalPages() {
        return this.totalPages;
    }

    public static class QueryAllGroupResponseBodyContent extends TeaModel {
        /**
         * <p>所在科室Id</p>
         */
        @NameInMap("deptId")
        public Long deptId;

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

        public static QueryAllGroupResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            QueryAllGroupResponseBodyContent self = new QueryAllGroupResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public QueryAllGroupResponseBodyContent setDeptId(Long deptId) {
            this.deptId = deptId;
            return this;
        }
        public Long getDeptId() {
            return this.deptId;
        }

        public QueryAllGroupResponseBodyContent setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public QueryAllGroupResponseBodyContent setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

}
