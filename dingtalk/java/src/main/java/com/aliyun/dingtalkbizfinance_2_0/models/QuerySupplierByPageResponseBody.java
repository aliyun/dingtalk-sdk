// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class QuerySupplierByPageResponseBody extends TeaModel {
    @NameInMap("hasMore")
    public Boolean hasMore;

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
        @NameInMap("code")
        public String code;

        @NameInMap("createTime")
        public Long createTime;

        @NameInMap("description")
        public String description;

        @NameInMap("name")
        public String name;

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
