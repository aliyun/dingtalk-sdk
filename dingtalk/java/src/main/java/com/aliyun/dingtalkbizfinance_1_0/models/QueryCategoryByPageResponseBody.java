// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryCategoryByPageResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("hasMore")
    public Boolean hasMore;

    /**
     * <p>This parameter is required.</p>
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
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>INCOME_XXX</p>
         */
        @NameInMap("code")
        public String code;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>false</p>
         */
        @NameInMap("isDir")
        public Boolean isDir;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>汽车</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>INCOM_XXX</p>
         */
        @NameInMap("parentCode")
        public String parentCode;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>valid</p>
         */
        @NameInMap("status")
        public String status;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>income</p>
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
