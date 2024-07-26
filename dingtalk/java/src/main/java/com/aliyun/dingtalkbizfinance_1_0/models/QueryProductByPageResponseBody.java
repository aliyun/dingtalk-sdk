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
        @NameInMap("code")
        public String code;

        @NameInMap("createTime")
        public Long createTime;

        @NameInMap("description")
        public String description;

        @NameInMap("information")
        public String information;

        @NameInMap("name")
        public String name;

        @NameInMap("specification")
        public String specification;

        @NameInMap("status")
        public String status;

        @NameInMap("unit")
        public String unit;

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

        public QueryProductByPageResponseBodyList setInformation(String information) {
            this.information = information;
            return this;
        }
        public String getInformation() {
            return this.information;
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
