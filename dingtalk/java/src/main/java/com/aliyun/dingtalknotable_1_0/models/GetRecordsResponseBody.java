// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class GetRecordsResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("hasMore")
    public Boolean hasMore;

    /**
     * <strong>example:</strong>
     * <p>nextToken</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("records")
    public java.util.List<GetRecordsResponseBodyRecords> records;

    public static GetRecordsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetRecordsResponseBody self = new GetRecordsResponseBody();
        return TeaModel.build(map, self);
    }

    public GetRecordsResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public GetRecordsResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public GetRecordsResponseBody setRecords(java.util.List<GetRecordsResponseBodyRecords> records) {
        this.records = records;
        return this;
    }
    public java.util.List<GetRecordsResponseBodyRecords> getRecords() {
        return this.records;
    }

    public static class GetRecordsResponseBodyRecords extends TeaModel {
        @NameInMap("fields")
        public java.util.Map<String, ?> fields;

        @NameInMap("id")
        public String id;

        public static GetRecordsResponseBodyRecords build(java.util.Map<String, ?> map) throws Exception {
            GetRecordsResponseBodyRecords self = new GetRecordsResponseBodyRecords();
            return TeaModel.build(map, self);
        }

        public GetRecordsResponseBodyRecords setFields(java.util.Map<String, ?> fields) {
            this.fields = fields;
            return this;
        }
        public java.util.Map<String, ?> getFields() {
            return this.fields;
        }

        public GetRecordsResponseBodyRecords setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

    }

}
