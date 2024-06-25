// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class InsertRecordsRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("records")
    public java.util.List<InsertRecordsRequestRecords> records;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>union_id</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static InsertRecordsRequest build(java.util.Map<String, ?> map) throws Exception {
        InsertRecordsRequest self = new InsertRecordsRequest();
        return TeaModel.build(map, self);
    }

    public InsertRecordsRequest setRecords(java.util.List<InsertRecordsRequestRecords> records) {
        this.records = records;
        return this;
    }
    public java.util.List<InsertRecordsRequestRecords> getRecords() {
        return this.records;
    }

    public InsertRecordsRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public static class InsertRecordsRequestRecords extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("fields")
        public java.util.Map<String, ?> fields;

        public static InsertRecordsRequestRecords build(java.util.Map<String, ?> map) throws Exception {
            InsertRecordsRequestRecords self = new InsertRecordsRequestRecords();
            return TeaModel.build(map, self);
        }

        public InsertRecordsRequestRecords setFields(java.util.Map<String, ?> fields) {
            this.fields = fields;
            return this;
        }
        public java.util.Map<String, ?> getFields() {
            return this.fields;
        }

    }

}
