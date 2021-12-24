// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class QueryRelationDatasByTargetIdResponseBody extends TeaModel {
    // 关系数据。
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
        // 关系模型数据字段名。
        @NameInMap("key")
        public String key;

        // 关系模型数据字段值。
        @NameInMap("value")
        public String value;

        // 关系模型数据字段扩展值。
        @NameInMap("extendValue")
        public String extendValue;

        public static QueryRelationDatasByTargetIdResponseBodyRelationsBizDataList build(java.util.Map<String, ?> map) throws Exception {
            QueryRelationDatasByTargetIdResponseBodyRelationsBizDataList self = new QueryRelationDatasByTargetIdResponseBodyRelationsBizDataList();
            return TeaModel.build(map, self);
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

        public QueryRelationDatasByTargetIdResponseBodyRelationsBizDataList setExtendValue(String extendValue) {
            this.extendValue = extendValue;
            return this;
        }
        public String getExtendValue() {
            return this.extendValue;
        }

    }

    public static class QueryRelationDatasByTargetIdResponseBodyRelations extends TeaModel {
        // 关系实例ID。
        @NameInMap("relationId")
        public String relationId;

        // 关系类型。
        @NameInMap("relationType")
        public String relationType;

        @NameInMap("bizDataList")
        public java.util.List<QueryRelationDatasByTargetIdResponseBodyRelationsBizDataList> bizDataList;

        public static QueryRelationDatasByTargetIdResponseBodyRelations build(java.util.Map<String, ?> map) throws Exception {
            QueryRelationDatasByTargetIdResponseBodyRelations self = new QueryRelationDatasByTargetIdResponseBodyRelations();
            return TeaModel.build(map, self);
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

        public QueryRelationDatasByTargetIdResponseBodyRelations setBizDataList(java.util.List<QueryRelationDatasByTargetIdResponseBodyRelationsBizDataList> bizDataList) {
            this.bizDataList = bizDataList;
            return this;
        }
        public java.util.List<QueryRelationDatasByTargetIdResponseBodyRelationsBizDataList> getBizDataList() {
            return this.bizDataList;
        }

    }

}
