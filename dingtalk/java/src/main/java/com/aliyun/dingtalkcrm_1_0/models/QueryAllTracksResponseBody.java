// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class QueryAllTracksResponseBody extends TeaModel {
    // 客户动态分页数据
    @NameInMap("values")
    public java.util.List<QueryAllTracksResponseBodyValues> values;

    // 是否还有数据
    @NameInMap("hasMore")
    public Boolean hasMore;

    // 下页翻页起始游标
    @NameInMap("nextToken")
    public String nextToken;

    // 翻页size
    @NameInMap("maxResults")
    public Integer maxResults;

    public static QueryAllTracksResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryAllTracksResponseBody self = new QueryAllTracksResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryAllTracksResponseBody setValues(java.util.List<QueryAllTracksResponseBodyValues> values) {
        this.values = values;
        return this;
    }
    public java.util.List<QueryAllTracksResponseBodyValues> getValues() {
        return this.values;
    }

    public QueryAllTracksResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public QueryAllTracksResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public QueryAllTracksResponseBody setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public static class QueryAllTracksResponseBodyValues extends TeaModel {
        // 企业id
        @NameInMap("corpId")
        public String corpId;

        // 客户id
        @NameInMap("customerId")
        public String customerId;

        // 动态类型
        @NameInMap("type")
        public Integer type;

        // 动态子类型
        @NameInMap("subType")
        public Integer subType;

        // 创建时间
        @NameInMap("gmtCreate")
        public Long gmtCreate;

        // 创建人userId
        @NameInMap("creator")
        public String creator;

        // 动态外键
        @NameInMap("bizId")
        public String bizId;

        // 动态加密主键
        @NameInMap("id")
        public String id;

        public static QueryAllTracksResponseBodyValues build(java.util.Map<String, ?> map) throws Exception {
            QueryAllTracksResponseBodyValues self = new QueryAllTracksResponseBodyValues();
            return TeaModel.build(map, self);
        }

        public QueryAllTracksResponseBodyValues setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public QueryAllTracksResponseBodyValues setCustomerId(String customerId) {
            this.customerId = customerId;
            return this;
        }
        public String getCustomerId() {
            return this.customerId;
        }

        public QueryAllTracksResponseBodyValues setType(Integer type) {
            this.type = type;
            return this;
        }
        public Integer getType() {
            return this.type;
        }

        public QueryAllTracksResponseBodyValues setSubType(Integer subType) {
            this.subType = subType;
            return this;
        }
        public Integer getSubType() {
            return this.subType;
        }

        public QueryAllTracksResponseBodyValues setGmtCreate(Long gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public Long getGmtCreate() {
            return this.gmtCreate;
        }

        public QueryAllTracksResponseBodyValues setCreator(String creator) {
            this.creator = creator;
            return this;
        }
        public String getCreator() {
            return this.creator;
        }

        public QueryAllTracksResponseBodyValues setBizId(String bizId) {
            this.bizId = bizId;
            return this;
        }
        public String getBizId() {
            return this.bizId;
        }

        public QueryAllTracksResponseBodyValues setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

    }

}
