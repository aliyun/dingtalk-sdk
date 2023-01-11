// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class BatchAddRelationDatasRequest extends TeaModel {
    /**
     * <p>操作人userId</p>
     */
    @NameInMap("operatorUserId")
    public String operatorUserId;

    /**
     * <p>关系数据列表。</p>
     */
    @NameInMap("relationList")
    public java.util.List<BatchAddRelationDatasRequestRelationList> relationList;

    /**
     * <p>关系类型。</p>
     */
    @NameInMap("relationType")
    public String relationType;

    /**
     * <p>是否跳过查重，默认不跳过。</p>
     */
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
        /**
         * <p>协同人列表</p>
         */
        @NameInMap("participantUserIds")
        public java.util.List<String> participantUserIds;

        /**
         * <p>负责人列表</p>
         */
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
         * <p>关系模型数据。</p>
         */
        @NameInMap("bizDataList")
        public java.util.List<BatchAddRelationDatasRequestRelationListBizDataList> bizDataList;

        /**
         * <p>扩展业务字段。</p>
         */
        @NameInMap("bizExtMap")
        public java.util.Map<String, String> bizExtMap;

        /**
         * <p>负责人、协同人信息。</p>
         */
        @NameInMap("relationPermissionDTO")
        public BatchAddRelationDatasRequestRelationListRelationPermissionDTO relationPermissionDTO;

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

    }

}
