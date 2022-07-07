// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryReceiptsBaseInfoResponseBody extends TeaModel {
    // 是否还有数据
    @NameInMap("hasMore")
    public String hasMore;

    // 分页数据
    @NameInMap("list")
    public java.util.List<QueryReceiptsBaseInfoResponseBodyList> list;

    // 总数
    @NameInMap("totalCount")
    public Long totalCount;

    public static QueryReceiptsBaseInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryReceiptsBaseInfoResponseBody self = new QueryReceiptsBaseInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryReceiptsBaseInfoResponseBody setHasMore(String hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public String getHasMore() {
        return this.hasMore;
    }

    public QueryReceiptsBaseInfoResponseBody setList(java.util.List<QueryReceiptsBaseInfoResponseBodyList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<QueryReceiptsBaseInfoResponseBodyList> getList() {
        return this.list;
    }

    public QueryReceiptsBaseInfoResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public static class QueryReceiptsBaseInfoResponseBodyList extends TeaModel {
        // 应用id
        @NameInMap("appId")
        public String appId;

        // 主数据
        @NameInMap("data")
        public String data;

        // 主数据modelID
        @NameInMap("modelId")
        public String modelId;

        // 来源
        @NameInMap("source")
        public String source;

        public static QueryReceiptsBaseInfoResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            QueryReceiptsBaseInfoResponseBodyList self = new QueryReceiptsBaseInfoResponseBodyList();
            return TeaModel.build(map, self);
        }

        public QueryReceiptsBaseInfoResponseBodyList setAppId(String appId) {
            this.appId = appId;
            return this;
        }
        public String getAppId() {
            return this.appId;
        }

        public QueryReceiptsBaseInfoResponseBodyList setData(String data) {
            this.data = data;
            return this;
        }
        public String getData() {
            return this.data;
        }

        public QueryReceiptsBaseInfoResponseBodyList setModelId(String modelId) {
            this.modelId = modelId;
            return this;
        }
        public String getModelId() {
            return this.modelId;
        }

        public QueryReceiptsBaseInfoResponseBodyList setSource(String source) {
            this.source = source;
            return this;
        }
        public String getSource() {
            return this.source;
        }

    }

}
