// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class BatchUpdateRelationDatasRequest extends TeaModel {
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
    public java.util.List<BatchUpdateRelationDatasRequestRelationList> relationList;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>crm_customer</p>
     */
    @NameInMap("relationType")
    public String relationType;

    /**
     * <strong>example:</strong>
     * <p>false</p>
     */
    @NameInMap("skipDuplicateCheck")
    public Boolean skipDuplicateCheck;

    public static BatchUpdateRelationDatasRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchUpdateRelationDatasRequest self = new BatchUpdateRelationDatasRequest();
        return TeaModel.build(map, self);
    }

    public BatchUpdateRelationDatasRequest setOperatorUserId(String operatorUserId) {
        this.operatorUserId = operatorUserId;
        return this;
    }
    public String getOperatorUserId() {
        return this.operatorUserId;
    }

    public BatchUpdateRelationDatasRequest setRelationList(java.util.List<BatchUpdateRelationDatasRequestRelationList> relationList) {
        this.relationList = relationList;
        return this;
    }
    public java.util.List<BatchUpdateRelationDatasRequestRelationList> getRelationList() {
        return this.relationList;
    }

    public BatchUpdateRelationDatasRequest setRelationType(String relationType) {
        this.relationType = relationType;
        return this;
    }
    public String getRelationType() {
        return this.relationType;
    }

    public BatchUpdateRelationDatasRequest setSkipDuplicateCheck(Boolean skipDuplicateCheck) {
        this.skipDuplicateCheck = skipDuplicateCheck;
        return this;
    }
    public Boolean getSkipDuplicateCheck() {
        return this.skipDuplicateCheck;
    }

    public static class BatchUpdateRelationDatasRequestRelationListBizDataList extends TeaModel {
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

        public static BatchUpdateRelationDatasRequestRelationListBizDataList build(java.util.Map<String, ?> map) throws Exception {
            BatchUpdateRelationDatasRequestRelationListBizDataList self = new BatchUpdateRelationDatasRequestRelationListBizDataList();
            return TeaModel.build(map, self);
        }

        public BatchUpdateRelationDatasRequestRelationListBizDataList setExtendValue(String extendValue) {
            this.extendValue = extendValue;
            return this;
        }
        public String getExtendValue() {
            return this.extendValue;
        }

        public BatchUpdateRelationDatasRequestRelationListBizDataList setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

        public BatchUpdateRelationDatasRequestRelationListBizDataList setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class BatchUpdateRelationDatasRequestRelationList extends TeaModel {
        @NameInMap("bizDataList")
        public java.util.List<BatchUpdateRelationDatasRequestRelationListBizDataList> bizDataList;

        /**
         * <strong>if can be null:</strong>
         * <p>true</p>
         */
        @NameInMap("bizExtMap")
        public java.util.Map<String, String> bizExtMap;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>fasdg8i814-0afsd</p>
         */
        @NameInMap("relationId")
        public String relationId;

        public static BatchUpdateRelationDatasRequestRelationList build(java.util.Map<String, ?> map) throws Exception {
            BatchUpdateRelationDatasRequestRelationList self = new BatchUpdateRelationDatasRequestRelationList();
            return TeaModel.build(map, self);
        }

        public BatchUpdateRelationDatasRequestRelationList setBizDataList(java.util.List<BatchUpdateRelationDatasRequestRelationListBizDataList> bizDataList) {
            this.bizDataList = bizDataList;
            return this;
        }
        public java.util.List<BatchUpdateRelationDatasRequestRelationListBizDataList> getBizDataList() {
            return this.bizDataList;
        }

        public BatchUpdateRelationDatasRequestRelationList setBizExtMap(java.util.Map<String, String> bizExtMap) {
            this.bizExtMap = bizExtMap;
            return this;
        }
        public java.util.Map<String, String> getBizExtMap() {
            return this.bizExtMap;
        }

        public BatchUpdateRelationDatasRequestRelationList setRelationId(String relationId) {
            this.relationId = relationId;
            return this;
        }
        public String getRelationId() {
            return this.relationId;
        }

    }

}
