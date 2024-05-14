// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class QueryAllTracksResponseBody extends TeaModel {
    @NameInMap("hasMore")
    public Boolean hasMore;

    @NameInMap("maxResults")
    public Integer maxResults;

    @NameInMap("nextToken")
    public String nextToken;

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
        @NameInMap("bizId")
        public String bizId;

        @NameInMap("creator")
        public String creator;

        @NameInMap("customerId")
        public String customerId;

        @NameInMap("gmtCreate")
        public Long gmtCreate;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("id")
        public String id;

        @NameInMap("subType")
        public Integer subType;

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
