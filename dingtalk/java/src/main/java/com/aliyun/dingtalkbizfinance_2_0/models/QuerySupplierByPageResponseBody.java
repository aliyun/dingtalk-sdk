// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class QuerySupplierByPageResponseBody extends TeaModel {
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
    public java.util.List<QuerySupplierByPageResponseBodyList> list;

    public static QuerySupplierByPageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QuerySupplierByPageResponseBody self = new QuerySupplierByPageResponseBody();
        return TeaModel.build(map, self);
    }

    public QuerySupplierByPageResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public QuerySupplierByPageResponseBody setList(java.util.List<QuerySupplierByPageResponseBodyList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<QuerySupplierByPageResponseBodyList> getList() {
        return this.list;
    }

    public static class QuerySupplierByPageResponseBodyList extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>SUP_XXX</p>
         */
        @NameInMap("code")
        public String code;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1634786828686</p>
         */
        @NameInMap("createTime")
        public Long createTime;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>原材料供应商</p>
         */
        @NameInMap("description")
        public String description;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>XX供应商</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>valid</p>
         */
        @NameInMap("status")
        public String status;

        @NameInMap("userDefineCode")
        public String userDefineCode;

        public static QuerySupplierByPageResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            QuerySupplierByPageResponseBodyList self = new QuerySupplierByPageResponseBodyList();
            return TeaModel.build(map, self);
        }

        public QuerySupplierByPageResponseBodyList setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public QuerySupplierByPageResponseBodyList setCreateTime(Long createTime) {
            this.createTime = createTime;
            return this;
        }
        public Long getCreateTime() {
            return this.createTime;
        }

        public QuerySupplierByPageResponseBodyList setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public QuerySupplierByPageResponseBodyList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public QuerySupplierByPageResponseBodyList setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public QuerySupplierByPageResponseBodyList setUserDefineCode(String userDefineCode) {
            this.userDefineCode = userDefineCode;
            return this;
        }
        public String getUserDefineCode() {
            return this.userDefineCode;
        }

    }

}
