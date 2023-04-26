// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryCategoryByPageResponseBody extends TeaModel {
    @NameInMap("hasMore")
    public Boolean hasMore;

    @NameInMap("list")
    public java.util.List<QueryCategoryByPageResponseBodyList> list;

    public static QueryCategoryByPageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryCategoryByPageResponseBody self = new QueryCategoryByPageResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryCategoryByPageResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public QueryCategoryByPageResponseBody setList(java.util.List<QueryCategoryByPageResponseBodyList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<QueryCategoryByPageResponseBodyList> getList() {
        return this.list;
    }

    public static class QueryCategoryByPageResponseBodyList extends TeaModel {
        @NameInMap("code")
        public String code;

        @NameInMap("isDir")
        public Boolean isDir;

        @NameInMap("name")
        public String name;

        @NameInMap("parentCode")
        public String parentCode;

        @NameInMap("status")
        public String status;

        @NameInMap("type")
        public String type;

        public static QueryCategoryByPageResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            QueryCategoryByPageResponseBodyList self = new QueryCategoryByPageResponseBodyList();
            return TeaModel.build(map, self);
        }

        public QueryCategoryByPageResponseBodyList setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public QueryCategoryByPageResponseBodyList setIsDir(Boolean isDir) {
            this.isDir = isDir;
            return this;
        }
        public Boolean getIsDir() {
            return this.isDir;
        }

        public QueryCategoryByPageResponseBodyList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public QueryCategoryByPageResponseBodyList setParentCode(String parentCode) {
            this.parentCode = parentCode;
            return this;
        }
        public String getParentCode() {
            return this.parentCode;
        }

        public QueryCategoryByPageResponseBodyList setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public QueryCategoryByPageResponseBodyList setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

}
