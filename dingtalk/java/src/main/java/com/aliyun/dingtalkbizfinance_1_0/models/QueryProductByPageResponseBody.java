// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryProductByPageResponseBody extends TeaModel {
    @NameInMap("hasMore")
    public Boolean hasMore;

    @NameInMap("list")
    public java.util.List<QueryProductByPageResponseBodyList> list;

    public static QueryProductByPageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryProductByPageResponseBody self = new QueryProductByPageResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryProductByPageResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public QueryProductByPageResponseBody setList(java.util.List<QueryProductByPageResponseBodyList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<QueryProductByPageResponseBodyList> getList() {
        return this.list;
    }

    public static class QueryProductByPageResponseBodyList extends TeaModel {
        /**
         * <p>商品code</p>
         */
        @NameInMap("code")
        public String code;

        /**
         * <p>创建时间</p>
         */
        @NameInMap("createTime")
        public Long createTime;

        /**
         * <p>商品备注</p>
         */
        @NameInMap("description")
        public String description;

        /**
         * <p>商品名称</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>商品规格</p>
         */
        @NameInMap("specification")
        public String specification;

        /**
         * <p>商品状态</p>
         */
        @NameInMap("status")
        public String status;

        /**
         * <p>商品单位</p>
         */
        @NameInMap("unit")
        public String unit;

        /**
         * <p>商品用户自定义码</p>
         */
        @NameInMap("userDefineCode")
        public String userDefineCode;

        public static QueryProductByPageResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            QueryProductByPageResponseBodyList self = new QueryProductByPageResponseBodyList();
            return TeaModel.build(map, self);
        }

        public QueryProductByPageResponseBodyList setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public QueryProductByPageResponseBodyList setCreateTime(Long createTime) {
            this.createTime = createTime;
            return this;
        }
        public Long getCreateTime() {
            return this.createTime;
        }

        public QueryProductByPageResponseBodyList setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public QueryProductByPageResponseBodyList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public QueryProductByPageResponseBodyList setSpecification(String specification) {
            this.specification = specification;
            return this;
        }
        public String getSpecification() {
            return this.specification;
        }

        public QueryProductByPageResponseBodyList setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public QueryProductByPageResponseBodyList setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

        public QueryProductByPageResponseBodyList setUserDefineCode(String userDefineCode) {
            this.userDefineCode = userDefineCode;
            return this;
        }
        public String getUserDefineCode() {
            return this.userDefineCode;
        }

    }

}
