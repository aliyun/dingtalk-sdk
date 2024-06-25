// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class BatchAddContactsRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>manager021a</p>
     */
    @NameInMap("operatorUserId")
    public String operatorUserId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("relationList")
    public java.util.List<BatchAddContactsRequestRelationList> relationList;

    public static BatchAddContactsRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchAddContactsRequest self = new BatchAddContactsRequest();
        return TeaModel.build(map, self);
    }

    public BatchAddContactsRequest setOperatorUserId(String operatorUserId) {
        this.operatorUserId = operatorUserId;
        return this;
    }
    public String getOperatorUserId() {
        return this.operatorUserId;
    }

    public BatchAddContactsRequest setRelationList(java.util.List<BatchAddContactsRequestRelationList> relationList) {
        this.relationList = relationList;
        return this;
    }
    public java.util.List<BatchAddContactsRequestRelationList> getRelationList() {
        return this.relationList;
    }

    public static class BatchAddContactsRequestRelationListBizDataList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>{}</p>
         */
        @NameInMap("extendValue")
        public String extendValue;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>TextField_71U51A</p>
         */
        @NameInMap("key")
        public String key;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>XX有限公司</p>
         */
        @NameInMap("value")
        public String value;

        public static BatchAddContactsRequestRelationListBizDataList build(java.util.Map<String, ?> map) throws Exception {
            BatchAddContactsRequestRelationListBizDataList self = new BatchAddContactsRequestRelationListBizDataList();
            return TeaModel.build(map, self);
        }

        public BatchAddContactsRequestRelationListBizDataList setExtendValue(String extendValue) {
            this.extendValue = extendValue;
            return this;
        }
        public String getExtendValue() {
            return this.extendValue;
        }

        public BatchAddContactsRequestRelationListBizDataList setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

        public BatchAddContactsRequestRelationListBizDataList setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class BatchAddContactsRequestRelationList extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("bizDataList")
        public java.util.List<BatchAddContactsRequestRelationListBizDataList> bizDataList;

        /**
         * <strong>if can be null:</strong>
         * <p>true</p>
         */
        @NameInMap("bizExtMap")
        public java.util.Map<String, String> bizExtMap;

        /**
         * <strong>example:</strong>
         * <p>1343434dd</p>
         */
        @NameInMap("sourceDataId")
        public String sourceDataId;

        public static BatchAddContactsRequestRelationList build(java.util.Map<String, ?> map) throws Exception {
            BatchAddContactsRequestRelationList self = new BatchAddContactsRequestRelationList();
            return TeaModel.build(map, self);
        }

        public BatchAddContactsRequestRelationList setBizDataList(java.util.List<BatchAddContactsRequestRelationListBizDataList> bizDataList) {
            this.bizDataList = bizDataList;
            return this;
        }
        public java.util.List<BatchAddContactsRequestRelationListBizDataList> getBizDataList() {
            return this.bizDataList;
        }

        public BatchAddContactsRequestRelationList setBizExtMap(java.util.Map<String, String> bizExtMap) {
            this.bizExtMap = bizExtMap;
            return this;
        }
        public java.util.Map<String, String> getBizExtMap() {
            return this.bizExtMap;
        }

        public BatchAddContactsRequestRelationList setSourceDataId(String sourceDataId) {
            this.sourceDataId = sourceDataId;
            return this;
        }
        public String getSourceDataId() {
            return this.sourceDataId;
        }

    }

}
