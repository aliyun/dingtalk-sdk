// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryAllDepartmentResponseBody extends TeaModel {
    // 科室列表
    @NameInMap("content")
    public java.util.List<QueryAllDepartmentResponseBodyContent> content;

    // 总页数
    @NameInMap("totalPages")
    public Integer totalPages;

    // 数据总量
    @NameInMap("totalCount")
    public Long totalCount;

    // 当前页码
    @NameInMap("currentPage")
    public Integer currentPage;

    public static QueryAllDepartmentResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryAllDepartmentResponseBody self = new QueryAllDepartmentResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryAllDepartmentResponseBody setContent(java.util.List<QueryAllDepartmentResponseBodyContent> content) {
        this.content = content;
        return this;
    }
    public java.util.List<QueryAllDepartmentResponseBodyContent> getContent() {
        return this.content;
    }

    public QueryAllDepartmentResponseBody setTotalPages(Integer totalPages) {
        this.totalPages = totalPages;
        return this;
    }
    public Integer getTotalPages() {
        return this.totalPages;
    }

    public QueryAllDepartmentResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public QueryAllDepartmentResponseBody setCurrentPage(Integer currentPage) {
        this.currentPage = currentPage;
        return this;
    }
    public Integer getCurrentPage() {
        return this.currentPage;
    }

    public static class QueryAllDepartmentResponseBodyContent extends TeaModel {
        // 科室Id
        @NameInMap("id")
        public Long id;

        // 科室名称
        @NameInMap("name")
        public String name;

        public static QueryAllDepartmentResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            QueryAllDepartmentResponseBodyContent self = new QueryAllDepartmentResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public QueryAllDepartmentResponseBodyContent setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public QueryAllDepartmentResponseBodyContent setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

}
