// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryReceiptForInvoiceResponseBody extends TeaModel {
    // 是否还有数据
    @NameInMap("hasMore")
    public String hasMore;

    // 分页数据
    @NameInMap("list")
    public java.util.List<QueryReceiptForInvoiceResponseBodyList> list;

    // 总数
    @NameInMap("totalCount")
    public Long totalCount;

    public static QueryReceiptForInvoiceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryReceiptForInvoiceResponseBody self = new QueryReceiptForInvoiceResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryReceiptForInvoiceResponseBody setHasMore(String hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public String getHasMore() {
        return this.hasMore;
    }

    public QueryReceiptForInvoiceResponseBody setList(java.util.List<QueryReceiptForInvoiceResponseBodyList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<QueryReceiptForInvoiceResponseBodyList> getList() {
        return this.list;
    }

    public QueryReceiptForInvoiceResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public static class QueryReceiptForInvoiceResponseBodyList extends TeaModel {
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

        public static QueryReceiptForInvoiceResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            QueryReceiptForInvoiceResponseBodyList self = new QueryReceiptForInvoiceResponseBodyList();
            return TeaModel.build(map, self);
        }

        public QueryReceiptForInvoiceResponseBodyList setAppId(String appId) {
            this.appId = appId;
            return this;
        }
        public String getAppId() {
            return this.appId;
        }

        public QueryReceiptForInvoiceResponseBodyList setData(String data) {
            this.data = data;
            return this;
        }
        public String getData() {
            return this.data;
        }

        public QueryReceiptForInvoiceResponseBodyList setModelId(String modelId) {
            this.modelId = modelId;
            return this;
        }
        public String getModelId() {
            return this.modelId;
        }

        public QueryReceiptForInvoiceResponseBodyList setSource(String source) {
            this.source = source;
            return this;
        }
        public String getSource() {
            return this.source;
        }

    }

}
