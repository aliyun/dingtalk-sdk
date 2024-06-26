// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkwms_1_0.models;

import com.aliyun.tea.*;

public class QueryGoodsListResponseBody extends TeaModel {
    @NameInMap("result")
    public QueryGoodsListResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static QueryGoodsListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryGoodsListResponseBody self = new QueryGoodsListResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryGoodsListResponseBody setResult(QueryGoodsListResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryGoodsListResponseBodyResult getResult() {
        return this.result;
    }

    public QueryGoodsListResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class QueryGoodsListResponseBodyResultList extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>衣服</p>
         */
        @NameInMap("goodsName")
        public String goodsName;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>0001</p>
         */
        @NameInMap("goodsNo")
        public String goodsNo;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>abcdse-dse-example</p>
         */
        @NameInMap("instanceId")
        public String instanceId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>XXL</p>
         */
        @NameInMap("productSpecs")
        public String productSpecs;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>件</p>
         */
        @NameInMap("unit")
        public String unit;

        public static QueryGoodsListResponseBodyResultList build(java.util.Map<String, ?> map) throws Exception {
            QueryGoodsListResponseBodyResultList self = new QueryGoodsListResponseBodyResultList();
            return TeaModel.build(map, self);
        }

        public QueryGoodsListResponseBodyResultList setGoodsName(String goodsName) {
            this.goodsName = goodsName;
            return this;
        }
        public String getGoodsName() {
            return this.goodsName;
        }

        public QueryGoodsListResponseBodyResultList setGoodsNo(String goodsNo) {
            this.goodsNo = goodsNo;
            return this;
        }
        public String getGoodsNo() {
            return this.goodsNo;
        }

        public QueryGoodsListResponseBodyResultList setInstanceId(String instanceId) {
            this.instanceId = instanceId;
            return this;
        }
        public String getInstanceId() {
            return this.instanceId;
        }

        public QueryGoodsListResponseBodyResultList setProductSpecs(String productSpecs) {
            this.productSpecs = productSpecs;
            return this;
        }
        public String getProductSpecs() {
            return this.productSpecs;
        }

        public QueryGoodsListResponseBodyResultList setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

    }

    public static class QueryGoodsListResponseBodyResult extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>true</p>
         */
        @NameInMap("hasMore")
        public Boolean hasMore;

        @NameInMap("list")
        public java.util.List<QueryGoodsListResponseBodyResultList> list;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>20</p>
         */
        @NameInMap("maxResults")
        public Long maxResults;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>10</p>
         */
        @NameInMap("nextToken")
        public String nextToken;

        public static QueryGoodsListResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryGoodsListResponseBodyResult self = new QueryGoodsListResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryGoodsListResponseBodyResult setHasMore(Boolean hasMore) {
            this.hasMore = hasMore;
            return this;
        }
        public Boolean getHasMore() {
            return this.hasMore;
        }

        public QueryGoodsListResponseBodyResult setList(java.util.List<QueryGoodsListResponseBodyResultList> list) {
            this.list = list;
            return this;
        }
        public java.util.List<QueryGoodsListResponseBodyResultList> getList() {
            return this.list;
        }

        public QueryGoodsListResponseBodyResult setMaxResults(Long maxResults) {
            this.maxResults = maxResults;
            return this;
        }
        public Long getMaxResults() {
            return this.maxResults;
        }

        public QueryGoodsListResponseBodyResult setNextToken(String nextToken) {
            this.nextToken = nextToken;
            return this;
        }
        public String getNextToken() {
            return this.nextToken;
        }

    }

}
