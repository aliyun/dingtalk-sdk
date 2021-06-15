// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryAllGroupResponseBody extends TeaModel {
    // Id of the request
    @NameInMap("content")
    public java.util.List<QueryAllGroupResponseBodyContent> content;

    // 总页数
    @NameInMap("totalPages")
    public Long totalPages;

    // 数据总量
    @NameInMap("totalCount")
    public Long totalCount;

    // 当前页码
    @NameInMap("currentPage")
    public Long currentPage;

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

    public QueryAllGroupResponseBody setTotalPages(Long totalPages) {
        this.totalPages = totalPages;
        return this;
    }
    public Long getTotalPages() {
        return this.totalPages;
    }

    public QueryAllGroupResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public QueryAllGroupResponseBody setCurrentPage(Long currentPage) {
        this.currentPage = currentPage;
        return this;
    }
    public Long getCurrentPage() {
        return this.currentPage;
    }

    public static class QueryAllGroupResponseBodyContent extends TeaModel {
        // 医疗组Id
        @NameInMap("id")
        public Long id;

        // 医疗组名称
        @NameInMap("name")
        public String name;

        // 所在科室Id
        @NameInMap("deptId")
        public Long deptId;

        public static QueryAllGroupResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            QueryAllGroupResponseBodyContent self = new QueryAllGroupResponseBodyContent();
            return TeaModel.build(map, self);
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

        public QueryAllGroupResponseBodyContent setDeptId(Long deptId) {
            this.deptId = deptId;
            return this;
        }
        public Long getDeptId() {
            return this.deptId;
        }

    }

}
