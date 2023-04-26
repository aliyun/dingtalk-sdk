// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class BatchUpdateFollowRecordsRequest extends TeaModel {
    @NameInMap("instanceList")
    public java.util.List<BatchUpdateFollowRecordsRequestInstanceList> instanceList;

    @NameInMap("operatorUserId")
    public String operatorUserId;

    public static BatchUpdateFollowRecordsRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchUpdateFollowRecordsRequest self = new BatchUpdateFollowRecordsRequest();
        return TeaModel.build(map, self);
    }

    public BatchUpdateFollowRecordsRequest setInstanceList(java.util.List<BatchUpdateFollowRecordsRequestInstanceList> instanceList) {
        this.instanceList = instanceList;
        return this;
    }
    public java.util.List<BatchUpdateFollowRecordsRequestInstanceList> getInstanceList() {
        return this.instanceList;
    }

    public BatchUpdateFollowRecordsRequest setOperatorUserId(String operatorUserId) {
        this.operatorUserId = operatorUserId;
        return this;
    }
    public String getOperatorUserId() {
        return this.operatorUserId;
    }

    public static class BatchUpdateFollowRecordsRequestInstanceListDataArray extends TeaModel {
        @NameInMap("extendValue")
        public String extendValue;

        @NameInMap("key")
        public String key;

        @NameInMap("value")
        public String value;

        public static BatchUpdateFollowRecordsRequestInstanceListDataArray build(java.util.Map<String, ?> map) throws Exception {
            BatchUpdateFollowRecordsRequestInstanceListDataArray self = new BatchUpdateFollowRecordsRequestInstanceListDataArray();
            return TeaModel.build(map, self);
        }

        public BatchUpdateFollowRecordsRequestInstanceListDataArray setExtendValue(String extendValue) {
            this.extendValue = extendValue;
            return this;
        }
        public String getExtendValue() {
            return this.extendValue;
        }

        public BatchUpdateFollowRecordsRequestInstanceListDataArray setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

        public BatchUpdateFollowRecordsRequestInstanceListDataArray setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class BatchUpdateFollowRecordsRequestInstanceList extends TeaModel {
        @NameInMap("dataArray")
        public java.util.List<BatchUpdateFollowRecordsRequestInstanceListDataArray> dataArray;

        @NameInMap("instanceId")
        public String instanceId;

        public static BatchUpdateFollowRecordsRequestInstanceList build(java.util.Map<String, ?> map) throws Exception {
            BatchUpdateFollowRecordsRequestInstanceList self = new BatchUpdateFollowRecordsRequestInstanceList();
            return TeaModel.build(map, self);
        }

        public BatchUpdateFollowRecordsRequestInstanceList setDataArray(java.util.List<BatchUpdateFollowRecordsRequestInstanceListDataArray> dataArray) {
            this.dataArray = dataArray;
            return this;
        }
        public java.util.List<BatchUpdateFollowRecordsRequestInstanceListDataArray> getDataArray() {
            return this.dataArray;
        }

        public BatchUpdateFollowRecordsRequestInstanceList setInstanceId(String instanceId) {
            this.instanceId = instanceId;
            return this;
        }
        public String getInstanceId() {
            return this.instanceId;
        }

    }

}
