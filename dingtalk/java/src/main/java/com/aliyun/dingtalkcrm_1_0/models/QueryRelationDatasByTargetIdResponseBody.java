// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class QueryRelationDatasByTargetIdResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("relations")
    public java.util.List<QueryRelationDatasByTargetIdResponseBodyRelations> relations;

    public static QueryRelationDatasByTargetIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryRelationDatasByTargetIdResponseBody self = new QueryRelationDatasByTargetIdResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryRelationDatasByTargetIdResponseBody setRelations(java.util.List<QueryRelationDatasByTargetIdResponseBodyRelations> relations) {
        this.relations = relations;
        return this;
    }
    public java.util.List<QueryRelationDatasByTargetIdResponseBodyRelations> getRelations() {
        return this.relations;
    }

    public static class QueryRelationDatasByTargetIdResponseBodyRelationsBizDataList extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>{}</p>
         */
        @NameInMap("extendValue")
        public String extendValue;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>customer_name</p>
         */
        @NameInMap("key")
        public String key;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>abc123</p>
         */
        @NameInMap("value")
        public String value;

        public static QueryRelationDatasByTargetIdResponseBodyRelationsBizDataList build(java.util.Map<String, ?> map) throws Exception {
            QueryRelationDatasByTargetIdResponseBodyRelationsBizDataList self = new QueryRelationDatasByTargetIdResponseBodyRelationsBizDataList();
            return TeaModel.build(map, self);
        }

        public QueryRelationDatasByTargetIdResponseBodyRelationsBizDataList setExtendValue(String extendValue) {
            this.extendValue = extendValue;
            return this;
        }
        public String getExtendValue() {
            return this.extendValue;
        }

        public QueryRelationDatasByTargetIdResponseBodyRelationsBizDataList setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

        public QueryRelationDatasByTargetIdResponseBodyRelationsBizDataList setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class QueryRelationDatasByTargetIdResponseBodyRelations extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("bizDataList")
        public java.util.List<QueryRelationDatasByTargetIdResponseBodyRelationsBizDataList> bizDataList;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("openConversationIds")
        public java.util.List<String> openConversationIds;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>abc123</p>
         */
        @NameInMap("relationId")
        public String relationId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>abc123</p>
         */
        @NameInMap("relationType")
        public String relationType;

        public static QueryRelationDatasByTargetIdResponseBodyRelations build(java.util.Map<String, ?> map) throws Exception {
            QueryRelationDatasByTargetIdResponseBodyRelations self = new QueryRelationDatasByTargetIdResponseBodyRelations();
            return TeaModel.build(map, self);
        }

        public QueryRelationDatasByTargetIdResponseBodyRelations setBizDataList(java.util.List<QueryRelationDatasByTargetIdResponseBodyRelationsBizDataList> bizDataList) {
            this.bizDataList = bizDataList;
            return this;
        }
        public java.util.List<QueryRelationDatasByTargetIdResponseBodyRelationsBizDataList> getBizDataList() {
            return this.bizDataList;
        }

        public QueryRelationDatasByTargetIdResponseBodyRelations setOpenConversationIds(java.util.List<String> openConversationIds) {
            this.openConversationIds = openConversationIds;
            return this;
        }
        public java.util.List<String> getOpenConversationIds() {
            return this.openConversationIds;
        }

        public QueryRelationDatasByTargetIdResponseBodyRelations setRelationId(String relationId) {
            this.relationId = relationId;
            return this;
        }
        public String getRelationId() {
            return this.relationId;
        }

        public QueryRelationDatasByTargetIdResponseBodyRelations setRelationType(String relationType) {
            this.relationType = relationType;
            return this;
        }
        public String getRelationType() {
            return this.relationType;
        }

    }

}
