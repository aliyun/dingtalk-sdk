// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryAllGroupsInDeptResponseBody extends TeaModel {
    // Id of the request
    @NameInMap("content")
    public java.util.List<QueryAllGroupsInDeptResponseBodyContent> content;

    // 总页数
    @NameInMap("totalPages")
    public Long totalPages;

    // 数据总量
    @NameInMap("totalCount")
    public Long totalCount;

    // 当前页码
    @NameInMap("currentPage")
    public Long currentPage;

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

    public QueryAllGroupsInDeptResponseBody setTotalPages(Long totalPages) {
        this.totalPages = totalPages;
        return this;
    }
    public Long getTotalPages() {
        return this.totalPages;
    }

    public QueryAllGroupsInDeptResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public QueryAllGroupsInDeptResponseBody setCurrentPage(Long currentPage) {
        this.currentPage = currentPage;
        return this;
    }
    public Long getCurrentPage() {
        return this.currentPage;
    }

    public static class QueryAllGroupsInDeptResponseBodyContent extends TeaModel {
        // 医疗组Id
        @NameInMap("id")
        public Long id;

        // 医疗组名称
        @NameInMap("name")
        public String name;

        // 所在科室Id
        @NameInMap("deptId")
        public Long deptId;

        public static QueryAllGroupsInDeptResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            QueryAllGroupsInDeptResponseBodyContent self = new QueryAllGroupsInDeptResponseBodyContent();
            return TeaModel.build(map, self);
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

        public QueryAllGroupsInDeptResponseBodyContent setDeptId(Long deptId) {
            this.deptId = deptId;
            return this;
        }
        public Long getDeptId() {
            return this.deptId;
        }

    }

}
