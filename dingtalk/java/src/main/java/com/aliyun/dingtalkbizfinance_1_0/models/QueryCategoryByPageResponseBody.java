// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryCategoryByPageResponseBody extends TeaModel {
    /**
     * <p>是否还有更多数据</p>
     */
    @NameInMap("hasMore")
    public Boolean hasMore;

    /**
     * <p>resultList</p>
     */
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
        /**
         * <p>类别code</p>
         */
        @NameInMap("code")
        public String code;

        /**
         * <p>是否为目录</p>
         */
        @NameInMap("isDir")
        public Boolean isDir;

        /**
         * <p>名字</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>父类别code</p>
         */
        @NameInMap("parentCode")
        public String parentCode;

        /**
         * <p>状态:valid,invalid,deleted</p>
         */
        @NameInMap("status")
        public String status;

        /**
         * <p>类型:income收入，expense支出</p>
         */
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
