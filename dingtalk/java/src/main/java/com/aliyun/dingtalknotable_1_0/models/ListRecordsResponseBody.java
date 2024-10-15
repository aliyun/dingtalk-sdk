// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class ListRecordsResponseBody extends TeaModel {
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
    public java.util.List<ListRecordsResponseBodyRecords> records;

    public static ListRecordsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListRecordsResponseBody self = new ListRecordsResponseBody();
        return TeaModel.build(map, self);
    }

    public ListRecordsResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public ListRecordsResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public ListRecordsResponseBody setRecords(java.util.List<ListRecordsResponseBodyRecords> records) {
        this.records = records;
        return this;
    }
    public java.util.List<ListRecordsResponseBodyRecords> getRecords() {
        return this.records;
    }

    public static class ListRecordsResponseBodyRecordsCreatedBy extends TeaModel {
        @NameInMap("unionId")
        public String unionId;

        public static ListRecordsResponseBodyRecordsCreatedBy build(java.util.Map<String, ?> map) throws Exception {
            ListRecordsResponseBodyRecordsCreatedBy self = new ListRecordsResponseBodyRecordsCreatedBy();
            return TeaModel.build(map, self);
        }

        public ListRecordsResponseBodyRecordsCreatedBy setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

    }

    public static class ListRecordsResponseBodyRecordsLastModifiedBy extends TeaModel {
        @NameInMap("unionId")
        public String unionId;

        public static ListRecordsResponseBodyRecordsLastModifiedBy build(java.util.Map<String, ?> map) throws Exception {
            ListRecordsResponseBodyRecordsLastModifiedBy self = new ListRecordsResponseBodyRecordsLastModifiedBy();
            return TeaModel.build(map, self);
        }

        public ListRecordsResponseBodyRecordsLastModifiedBy setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

    }

    public static class ListRecordsResponseBodyRecords extends TeaModel {
        @NameInMap("createdBy")
        public ListRecordsResponseBodyRecordsCreatedBy createdBy;

        @NameInMap("createdTime")
        public Long createdTime;

        @NameInMap("fields")
        public java.util.Map<String, ?> fields;

        @NameInMap("id")
        public String id;

        @NameInMap("lastModifiedBy")
        public ListRecordsResponseBodyRecordsLastModifiedBy lastModifiedBy;

        @NameInMap("lastModifiedTime")
        public Long lastModifiedTime;

        public static ListRecordsResponseBodyRecords build(java.util.Map<String, ?> map) throws Exception {
            ListRecordsResponseBodyRecords self = new ListRecordsResponseBodyRecords();
            return TeaModel.build(map, self);
        }

        public ListRecordsResponseBodyRecords setCreatedBy(ListRecordsResponseBodyRecordsCreatedBy createdBy) {
            this.createdBy = createdBy;
            return this;
        }
        public ListRecordsResponseBodyRecordsCreatedBy getCreatedBy() {
            return this.createdBy;
        }

        public ListRecordsResponseBodyRecords setCreatedTime(Long createdTime) {
            this.createdTime = createdTime;
            return this;
        }
        public Long getCreatedTime() {
            return this.createdTime;
        }

        public ListRecordsResponseBodyRecords setFields(java.util.Map<String, ?> fields) {
            this.fields = fields;
            return this;
        }
        public java.util.Map<String, ?> getFields() {
            return this.fields;
        }

        public ListRecordsResponseBodyRecords setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public ListRecordsResponseBodyRecords setLastModifiedBy(ListRecordsResponseBodyRecordsLastModifiedBy lastModifiedBy) {
            this.lastModifiedBy = lastModifiedBy;
            return this;
        }
        public ListRecordsResponseBodyRecordsLastModifiedBy getLastModifiedBy() {
            return this.lastModifiedBy;
        }

        public ListRecordsResponseBodyRecords setLastModifiedTime(Long lastModifiedTime) {
            this.lastModifiedTime = lastModifiedTime;
            return this;
        }
        public Long getLastModifiedTime() {
            return this.lastModifiedTime;
        }

    }

}
