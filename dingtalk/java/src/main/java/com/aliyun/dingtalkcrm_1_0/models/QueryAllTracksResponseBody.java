// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class QueryAllTracksResponseBody extends TeaModel {
    /**
     * <p>是否还有数据</p>
     */
    @NameInMap("hasMore")
    public Boolean hasMore;

    /**
     * <p>翻页size</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    /**
     * <p>下页翻页起始游标</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>客户动态分页数据</p>
     */
    @NameInMap("values")
    public java.util.List<QueryAllTracksResponseBodyValues> values;

    public static QueryAllTracksResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryAllTracksResponseBody self = new QueryAllTracksResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryAllTracksResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public QueryAllTracksResponseBody setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public QueryAllTracksResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public QueryAllTracksResponseBody setValues(java.util.List<QueryAllTracksResponseBodyValues> values) {
        this.values = values;
        return this;
    }
    public java.util.List<QueryAllTracksResponseBodyValues> getValues() {
        return this.values;
    }

    public static class QueryAllTracksResponseBodyValues extends TeaModel {
        /**
         * <p>动态外键</p>
         */
        @NameInMap("bizId")
        public String bizId;

        /**
         * <p>创建人userId</p>
         */
        @NameInMap("creator")
        public String creator;

        /**
         * <p>客户id</p>
         */
        @NameInMap("customerId")
        public String customerId;

        /**
         * <p>创建时间</p>
         */
        @NameInMap("gmtCreate")
        public Long gmtCreate;

        /**
         * <p>动态加密主键</p>
         */
        @NameInMap("id")
        public String id;

        /**
         * <p>动态子类型</p>
         */
        @NameInMap("subType")
        public Integer subType;

        /**
         * <p>动态类型</p>
         */
        @NameInMap("type")
        public Integer type;

        public static QueryAllTracksResponseBodyValues build(java.util.Map<String, ?> map) throws Exception {
            QueryAllTracksResponseBodyValues self = new QueryAllTracksResponseBodyValues();
            return TeaModel.build(map, self);
        }

        public QueryAllTracksResponseBodyValues setBizId(String bizId) {
            this.bizId = bizId;
            return this;
        }
        public String getBizId() {
            return this.bizId;
        }

        public QueryAllTracksResponseBodyValues setCreator(String creator) {
            this.creator = creator;
            return this;
        }
        public String getCreator() {
            return this.creator;
        }

        public QueryAllTracksResponseBodyValues setCustomerId(String customerId) {
            this.customerId = customerId;
            return this;
        }
        public String getCustomerId() {
            return this.customerId;
        }

        public QueryAllTracksResponseBodyValues setGmtCreate(Long gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public Long getGmtCreate() {
            return this.gmtCreate;
        }

        public QueryAllTracksResponseBodyValues setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public QueryAllTracksResponseBodyValues setSubType(Integer subType) {
            this.subType = subType;
            return this;
        }
        public Integer getSubType() {
            return this.subType;
        }

        public QueryAllTracksResponseBodyValues setType(Integer type) {
            this.type = type;
            return this;
        }
        public Integer getType() {
            return this.type;
        }

    }

}
