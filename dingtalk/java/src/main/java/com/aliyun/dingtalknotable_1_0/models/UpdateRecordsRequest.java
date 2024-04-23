// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class UpdateRecordsRequest extends TeaModel {
    @NameInMap("records")
    public java.util.List<UpdateRecordsRequestRecords> records;

    @NameInMap("operatorId")
    public String operatorId;

    public static UpdateRecordsRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateRecordsRequest self = new UpdateRecordsRequest();
        return TeaModel.build(map, self);
    }

    public UpdateRecordsRequest setRecords(java.util.List<UpdateRecordsRequestRecords> records) {
        this.records = records;
        return this;
    }
    public java.util.List<UpdateRecordsRequestRecords> getRecords() {
        return this.records;
    }

    public UpdateRecordsRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public static class UpdateRecordsRequestRecords extends TeaModel {
        @NameInMap("fields")
        public java.util.Map<String, ?> fields;

        @NameInMap("id")
        public String id;

        public static UpdateRecordsRequestRecords build(java.util.Map<String, ?> map) throws Exception {
            UpdateRecordsRequestRecords self = new UpdateRecordsRequestRecords();
            return TeaModel.build(map, self);
        }

        public UpdateRecordsRequestRecords setFields(java.util.Map<String, ?> fields) {
            this.fields = fields;
            return this;
        }
        public java.util.Map<String, ?> getFields() {
            return this.fields;
        }

        public UpdateRecordsRequestRecords setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

    }

}
