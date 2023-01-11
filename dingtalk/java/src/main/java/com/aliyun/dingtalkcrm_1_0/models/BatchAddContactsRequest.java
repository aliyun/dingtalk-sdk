// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class BatchAddContactsRequest extends TeaModel {
    /**
     * <p>操作人userId</p>
     */
    @NameInMap("operatorUserId")
    public String operatorUserId;

    /**
     * <p>关系数据列表。</p>
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
         * <p>模型字段extendValue。</p>
         */
        @NameInMap("extendValue")
        public String extendValue;

        /**
         * <p>模型字段id。</p>
         */
        @NameInMap("key")
        public String key;

        /**
         * <p>模型字段value。</p>
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
         * <p>关系模型数据。</p>
         */
        @NameInMap("bizDataList")
        public java.util.List<BatchAddContactsRequestRelationListBizDataList> bizDataList;

        /**
         * <p>扩展业务字段。</p>
         */
        @NameInMap("bizExtMap")
        public java.util.Map<String, String> bizExtMap;

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

    }

}
