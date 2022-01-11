// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryReceiptsByPageResponseBody extends TeaModel {
    // 是否还有更多数据
    @NameInMap("hasMore")
    public String hasMore;

    // 数据列表
    @NameInMap("list")
    public java.util.List<QueryReceiptsByPageResponseBodyList> list;

    public static QueryReceiptsByPageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryReceiptsByPageResponseBody self = new QueryReceiptsByPageResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryReceiptsByPageResponseBody setHasMore(String hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public String getHasMore() {
        return this.hasMore;
    }

    public QueryReceiptsByPageResponseBody setList(java.util.List<QueryReceiptsByPageResponseBodyList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<QueryReceiptsByPageResponseBodyList> getList() {
        return this.list;
    }

    public static class QueryReceiptsByPageResponseBodyList extends TeaModel {
        // 数据来源于开放时，对应的微应用id
        @NameInMap("appId")
        public String appId;

        // 单据数据体json
        @NameInMap("data")
        public String data;

        // 模型id
        @NameInMap("modelId")
        public String modelId;

        // 数据来源：审批(approval)，开放接口(openapi)
        @NameInMap("source")
        public String source;

        public static QueryReceiptsByPageResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            QueryReceiptsByPageResponseBodyList self = new QueryReceiptsByPageResponseBodyList();
            return TeaModel.build(map, self);
        }

        public QueryReceiptsByPageResponseBodyList setAppId(String appId) {
            this.appId = appId;
            return this;
        }
        public String getAppId() {
            return this.appId;
        }

        public QueryReceiptsByPageResponseBodyList setData(String data) {
            this.data = data;
            return this;
        }
        public String getData() {
            return this.data;
        }

        public QueryReceiptsByPageResponseBodyList setModelId(String modelId) {
            this.modelId = modelId;
            return this;
        }
        public String getModelId() {
            return this.modelId;
        }

        public QueryReceiptsByPageResponseBodyList setSource(String source) {
            this.source = source;
            return this;
        }
        public String getSource() {
            return this.source;
        }

    }

}
