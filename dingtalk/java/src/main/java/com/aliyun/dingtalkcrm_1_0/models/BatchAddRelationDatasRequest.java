// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class BatchAddRelationDatasRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("operatorUserId")
    public String operatorUserId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("relationList")
    public java.util.List<BatchAddRelationDatasRequestRelationList> relationList;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("relationType")
    public String relationType;

    @NameInMap("skipDuplicateCheck")
    public Boolean skipDuplicateCheck;

    public static BatchAddRelationDatasRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchAddRelationDatasRequest self = new BatchAddRelationDatasRequest();
        return TeaModel.build(map, self);
    }

    public BatchAddRelationDatasRequest setOperatorUserId(String operatorUserId) {
        this.operatorUserId = operatorUserId;
        return this;
    }
    public String getOperatorUserId() {
        return this.operatorUserId;
    }

    public BatchAddRelationDatasRequest setRelationList(java.util.List<BatchAddRelationDatasRequestRelationList> relationList) {
        this.relationList = relationList;
        return this;
    }
    public java.util.List<BatchAddRelationDatasRequestRelationList> getRelationList() {
        return this.relationList;
    }

    public BatchAddRelationDatasRequest setRelationType(String relationType) {
        this.relationType = relationType;
        return this;
    }
    public String getRelationType() {
        return this.relationType;
    }

    public BatchAddRelationDatasRequest setSkipDuplicateCheck(Boolean skipDuplicateCheck) {
        this.skipDuplicateCheck = skipDuplicateCheck;
        return this;
    }
    public Boolean getSkipDuplicateCheck() {
        return this.skipDuplicateCheck;
    }

    public static class BatchAddRelationDatasRequestRelationListBizDataList extends TeaModel {
        @NameInMap("extendValue")
        public String extendValue;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("key")
        public String key;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("value")
        public String value;

        public static BatchAddRelationDatasRequestRelationListBizDataList build(java.util.Map<String, ?> map) throws Exception {
            BatchAddRelationDatasRequestRelationListBizDataList self = new BatchAddRelationDatasRequestRelationListBizDataList();
            return TeaModel.build(map, self);
        }

        public BatchAddRelationDatasRequestRelationListBizDataList setExtendValue(String extendValue) {
            this.extendValue = extendValue;
            return this;
        }
        public String getExtendValue() {
            return this.extendValue;
        }

        public BatchAddRelationDatasRequestRelationListBizDataList setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

        public BatchAddRelationDatasRequestRelationListBizDataList setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class BatchAddRelationDatasRequestRelationListRelationPermissionDTO extends TeaModel {
        @NameInMap("participantUserIds")
        public java.util.List<String> participantUserIds;

        @NameInMap("principalUserIds")
        public java.util.List<String> principalUserIds;

        public static BatchAddRelationDatasRequestRelationListRelationPermissionDTO build(java.util.Map<String, ?> map) throws Exception {
            BatchAddRelationDatasRequestRelationListRelationPermissionDTO self = new BatchAddRelationDatasRequestRelationListRelationPermissionDTO();
            return TeaModel.build(map, self);
        }

        public BatchAddRelationDatasRequestRelationListRelationPermissionDTO setParticipantUserIds(java.util.List<String> participantUserIds) {
            this.participantUserIds = participantUserIds;
            return this;
        }
        public java.util.List<String> getParticipantUserIds() {
            return this.participantUserIds;
        }

        public BatchAddRelationDatasRequestRelationListRelationPermissionDTO setPrincipalUserIds(java.util.List<String> principalUserIds) {
            this.principalUserIds = principalUserIds;
            return this;
        }
        public java.util.List<String> getPrincipalUserIds() {
            return this.principalUserIds;
        }

    }

    public static class BatchAddRelationDatasRequestRelationList extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("bizDataList")
        public java.util.List<BatchAddRelationDatasRequestRelationListBizDataList> bizDataList;

        @NameInMap("bizExtMap")
        public java.util.Map<String, String> bizExtMap;

        @NameInMap("relationPermissionDTO")
        public BatchAddRelationDatasRequestRelationListRelationPermissionDTO relationPermissionDTO;

        @NameInMap("sourceDataId")
        public String sourceDataId;

        public static BatchAddRelationDatasRequestRelationList build(java.util.Map<String, ?> map) throws Exception {
            BatchAddRelationDatasRequestRelationList self = new BatchAddRelationDatasRequestRelationList();
            return TeaModel.build(map, self);
        }

        public BatchAddRelationDatasRequestRelationList setBizDataList(java.util.List<BatchAddRelationDatasRequestRelationListBizDataList> bizDataList) {
            this.bizDataList = bizDataList;
            return this;
        }
        public java.util.List<BatchAddRelationDatasRequestRelationListBizDataList> getBizDataList() {
            return this.bizDataList;
        }

        public BatchAddRelationDatasRequestRelationList setBizExtMap(java.util.Map<String, String> bizExtMap) {
            this.bizExtMap = bizExtMap;
            return this;
        }
        public java.util.Map<String, String> getBizExtMap() {
            return this.bizExtMap;
        }

        public BatchAddRelationDatasRequestRelationList setRelationPermissionDTO(BatchAddRelationDatasRequestRelationListRelationPermissionDTO relationPermissionDTO) {
            this.relationPermissionDTO = relationPermissionDTO;
            return this;
        }
        public BatchAddRelationDatasRequestRelationListRelationPermissionDTO getRelationPermissionDTO() {
            return this.relationPermissionDTO;
        }

        public BatchAddRelationDatasRequestRelationList setSourceDataId(String sourceDataId) {
            this.sourceDataId = sourceDataId;
            return this;
        }
        public String getSourceDataId() {
            return this.sourceDataId;
        }

    }

}
