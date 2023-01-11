// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryCustomerByPageResponseBody extends TeaModel {
    /**
     * <p>是否还有更多数据</p>
     */
    @NameInMap("hasMore")
    public Boolean hasMore;

    /**
     * <p>resultList</p>
     */
    @NameInMap("list")
    public java.util.List<QueryCustomerByPageResponseBodyList> list;

    public static QueryCustomerByPageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryCustomerByPageResponseBody self = new QueryCustomerByPageResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryCustomerByPageResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public QueryCustomerByPageResponseBody setList(java.util.List<QueryCustomerByPageResponseBodyList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<QueryCustomerByPageResponseBodyList> getList() {
        return this.list;
    }

    public static class QueryCustomerByPageResponseBodyList extends TeaModel {
        /**
         * <p>客户Code</p>
         */
        @NameInMap("code")
        public String code;

        /**
         * <p>创建时间(单位MS)</p>
         */
        @NameInMap("createTime")
        public Long createTime;

        /**
         * <p>客户描述</p>
         */
        @NameInMap("description")
        public String description;

        /**
         * <p>客户名称</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>状态：启用(valid), 停用(invalid), 删除(deleted)</p>
         */
        @NameInMap("status")
        public String status;

        /**
         * <p>用户自定义code</p>
         */
        @NameInMap("userDefineCode")
        public String userDefineCode;

        public static QueryCustomerByPageResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            QueryCustomerByPageResponseBodyList self = new QueryCustomerByPageResponseBodyList();
            return TeaModel.build(map, self);
        }

        public QueryCustomerByPageResponseBodyList setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public QueryCustomerByPageResponseBodyList setCreateTime(Long createTime) {
            this.createTime = createTime;
            return this;
        }
        public Long getCreateTime() {
            return this.createTime;
        }

        public QueryCustomerByPageResponseBodyList setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public QueryCustomerByPageResponseBodyList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public QueryCustomerByPageResponseBodyList setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public QueryCustomerByPageResponseBodyList setUserDefineCode(String userDefineCode) {
            this.userDefineCode = userDefineCode;
            return this;
        }
        public String getUserDefineCode() {
            return this.userDefineCode;
        }

    }

}
