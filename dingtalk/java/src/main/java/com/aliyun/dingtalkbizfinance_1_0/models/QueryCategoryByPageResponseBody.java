// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryCategoryByPageResponseBody extends TeaModel {
    // resultList
    @NameInMap("list")
    public java.util.List<QueryCategoryByPageResponseBodyList> list;

    // 是否还有更多数据
    @NameInMap("hasMore")
    public Boolean hasMore;

    public static QueryCategoryByPageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryCategoryByPageResponseBody self = new QueryCategoryByPageResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryCategoryByPageResponseBody setList(java.util.List<QueryCategoryByPageResponseBodyList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<QueryCategoryByPageResponseBodyList> getList() {
        return this.list;
    }

    public QueryCategoryByPageResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public static class QueryCategoryByPageResponseBodyList extends TeaModel {
        // 类别code
        @NameInMap("code")
        public String code;

        // 类型:income收入，expense支出
        @NameInMap("type")
        public String type;

        // 名字
        @NameInMap("name")
        public String name;

        // 是否为目录
        @NameInMap("isDir")
        public Boolean isDir;

        // 父类别code
        @NameInMap("parentCode")
        public String parentCode;

        // 状态:valid,invalid,deleted
        @NameInMap("status")
        public String status;

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

        public QueryCategoryByPageResponseBodyList setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public QueryCategoryByPageResponseBodyList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public QueryCategoryByPageResponseBodyList setIsDir(Boolean isDir) {
            this.isDir = isDir;
            return this;
        }
        public Boolean getIsDir() {
            return this.isDir;
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

    }

}
