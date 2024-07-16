// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class GetRecordResponseBody extends TeaModel {
    @NameInMap("createdBy")
    public GetRecordResponseBodyCreatedBy createdBy;

    @NameInMap("createdTime")
    public Long createdTime;

    @NameInMap("fields")
    public java.util.Map<String, ?> fields;

    @NameInMap("id")
    public String id;

    @NameInMap("lastModifiedBy")
    public GetRecordResponseBodyLastModifiedBy lastModifiedBy;

    @NameInMap("lastModifiedTime")
    public Long lastModifiedTime;

    public static GetRecordResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetRecordResponseBody self = new GetRecordResponseBody();
        return TeaModel.build(map, self);
    }

    public GetRecordResponseBody setCreatedBy(GetRecordResponseBodyCreatedBy createdBy) {
        this.createdBy = createdBy;
        return this;
    }
    public GetRecordResponseBodyCreatedBy getCreatedBy() {
        return this.createdBy;
    }

    public GetRecordResponseBody setCreatedTime(Long createdTime) {
        this.createdTime = createdTime;
        return this;
    }
    public Long getCreatedTime() {
        return this.createdTime;
    }

    public GetRecordResponseBody setFields(java.util.Map<String, ?> fields) {
        this.fields = fields;
        return this;
    }
    public java.util.Map<String, ?> getFields() {
        return this.fields;
    }

    public GetRecordResponseBody setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

    public GetRecordResponseBody setLastModifiedBy(GetRecordResponseBodyLastModifiedBy lastModifiedBy) {
        this.lastModifiedBy = lastModifiedBy;
        return this;
    }
    public GetRecordResponseBodyLastModifiedBy getLastModifiedBy() {
        return this.lastModifiedBy;
    }

    public GetRecordResponseBody setLastModifiedTime(Long lastModifiedTime) {
        this.lastModifiedTime = lastModifiedTime;
        return this;
    }
    public Long getLastModifiedTime() {
        return this.lastModifiedTime;
    }

    public static class GetRecordResponseBodyCreatedBy extends TeaModel {
        @NameInMap("unionId")
        public String unionId;

        public static GetRecordResponseBodyCreatedBy build(java.util.Map<String, ?> map) throws Exception {
            GetRecordResponseBodyCreatedBy self = new GetRecordResponseBodyCreatedBy();
            return TeaModel.build(map, self);
        }

        public GetRecordResponseBodyCreatedBy setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

    }

    public static class GetRecordResponseBodyLastModifiedBy extends TeaModel {
        @NameInMap("unionId")
        public String unionId;

        public static GetRecordResponseBodyLastModifiedBy build(java.util.Map<String, ?> map) throws Exception {
            GetRecordResponseBodyLastModifiedBy self = new GetRecordResponseBodyLastModifiedBy();
            return TeaModel.build(map, self);
        }

        public GetRecordResponseBodyLastModifiedBy setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

    }

}
