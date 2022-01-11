// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QuerySupplierByPageResponseBody extends TeaModel {
    // 是否还有更多数据
    @NameInMap("hasMore")
    public Boolean hasMore;

    // resultList
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
        // 供应商Code
        @NameInMap("code")
        public String code;

        // 创建时间(单位MS)
        @NameInMap("createTime")
        public Long createTime;

        // 供应商描述
        @NameInMap("description")
        public String description;

        // 供应商名称
        @NameInMap("name")
        public String name;

        // 状态：启用(valid), 停用(invalid), 删除(deleted)
        @NameInMap("status")
        public String status;

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

    }

}
