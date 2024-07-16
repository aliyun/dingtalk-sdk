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

    public static class GetRecordsResponseBodyRecordsCreatedBy extends TeaModel {
        @NameInMap("unionId")
        public String unionId;

        public static GetRecordsResponseBodyRecordsCreatedBy build(java.util.Map<String, ?> map) throws Exception {
            GetRecordsResponseBodyRecordsCreatedBy self = new GetRecordsResponseBodyRecordsCreatedBy();
            return TeaModel.build(map, self);
        }

        public GetRecordsResponseBodyRecordsCreatedBy setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

    }

    public static class GetRecordsResponseBodyRecordsLastModifiedBy extends TeaModel {
        @NameInMap("unionId")
        public String unionId;

        public static GetRecordsResponseBodyRecordsLastModifiedBy build(java.util.Map<String, ?> map) throws Exception {
            GetRecordsResponseBodyRecordsLastModifiedBy self = new GetRecordsResponseBodyRecordsLastModifiedBy();
            return TeaModel.build(map, self);
        }

        public GetRecordsResponseBodyRecordsLastModifiedBy setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

    }

    public static class GetRecordsResponseBodyRecords extends TeaModel {
        @NameInMap("createdBy")
        public GetRecordsResponseBodyRecordsCreatedBy createdBy;

        @NameInMap("createdTime")
        public Long createdTime;

        @NameInMap("fields")
        public java.util.Map<String, ?> fields;

        @NameInMap("id")
        public String id;

        @NameInMap("lastModifiedBy")
        public GetRecordsResponseBodyRecordsLastModifiedBy lastModifiedBy;

        @NameInMap("lastModifiedTime")
        public Long lastModifiedTime;

        public static GetRecordsResponseBodyRecords build(java.util.Map<String, ?> map) throws Exception {
            GetRecordsResponseBodyRecords self = new GetRecordsResponseBodyRecords();
            return TeaModel.build(map, self);
        }

        public GetRecordsResponseBodyRecords setCreatedBy(GetRecordsResponseBodyRecordsCreatedBy createdBy) {
            this.createdBy = createdBy;
            return this;
        }
        public GetRecordsResponseBodyRecordsCreatedBy getCreatedBy() {
            return this.createdBy;
        }

        public GetRecordsResponseBodyRecords setCreatedTime(Long createdTime) {
            this.createdTime = createdTime;
            return this;
        }
        public Long getCreatedTime() {
            return this.createdTime;
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

        public GetRecordsResponseBodyRecords setLastModifiedBy(GetRecordsResponseBodyRecordsLastModifiedBy lastModifiedBy) {
            this.lastModifiedBy = lastModifiedBy;
            return this;
        }
        public GetRecordsResponseBodyRecordsLastModifiedBy getLastModifiedBy() {
            return this.lastModifiedBy;
        }

        public GetRecordsResponseBodyRecords setLastModifiedTime(Long lastModifiedTime) {
            this.lastModifiedTime = lastModifiedTime;
            return this;
        }
        public Long getLastModifiedTime() {
            return this.lastModifiedTime;
        }

    }

}
