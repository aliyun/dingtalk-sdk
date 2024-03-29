// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class QueryAllFormInstancesResponseBody extends TeaModel {
    @NameInMap("result")
    public QueryAllFormInstancesResponseBodyResult result;

    public static QueryAllFormInstancesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryAllFormInstancesResponseBody self = new QueryAllFormInstancesResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryAllFormInstancesResponseBody setResult(QueryAllFormInstancesResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryAllFormInstancesResponseBodyResult getResult() {
        return this.result;
    }

    public static class QueryAllFormInstancesResponseBodyResultValuesFormInstDataList extends TeaModel {
        @NameInMap("bizAlias")
        public String bizAlias;

        @NameInMap("componentType")
        public String componentType;

        @NameInMap("extendValue")
        public String extendValue;

        @NameInMap("key")
        public String key;

        @NameInMap("label")
        public String label;

        @NameInMap("value")
        public String value;

        public static QueryAllFormInstancesResponseBodyResultValuesFormInstDataList build(java.util.Map<String, ?> map) throws Exception {
            QueryAllFormInstancesResponseBodyResultValuesFormInstDataList self = new QueryAllFormInstancesResponseBodyResultValuesFormInstDataList();
            return TeaModel.build(map, self);
        }

        public QueryAllFormInstancesResponseBodyResultValuesFormInstDataList setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
        }

        public QueryAllFormInstancesResponseBodyResultValuesFormInstDataList setComponentType(String componentType) {
            this.componentType = componentType;
            return this;
        }
        public String getComponentType() {
            return this.componentType;
        }

        public QueryAllFormInstancesResponseBodyResultValuesFormInstDataList setExtendValue(String extendValue) {
            this.extendValue = extendValue;
            return this;
        }
        public String getExtendValue() {
            return this.extendValue;
        }

        public QueryAllFormInstancesResponseBodyResultValuesFormInstDataList setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

        public QueryAllFormInstancesResponseBodyResultValuesFormInstDataList setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public QueryAllFormInstancesResponseBodyResultValuesFormInstDataList setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class QueryAllFormInstancesResponseBodyResultValues extends TeaModel {
        @NameInMap("appUuid")
        public String appUuid;

        @NameInMap("attributes")
        public java.util.Map<String, ?> attributes;

        @NameInMap("createTimestamp")
        public Long createTimestamp;

        @NameInMap("creator")
        public String creator;

        @NameInMap("formCode")
        public String formCode;

        @NameInMap("formInstDataList")
        public java.util.List<QueryAllFormInstancesResponseBodyResultValuesFormInstDataList> formInstDataList;

        @NameInMap("formInstanceId")
        public String formInstanceId;

        @NameInMap("modifier")
        public String modifier;

        @NameInMap("modifyTimestamp")
        public Long modifyTimestamp;

        @NameInMap("outBizCode")
        public String outBizCode;

        @NameInMap("outInstanceId")
        public String outInstanceId;

        @NameInMap("title")
        public String title;

        public static QueryAllFormInstancesResponseBodyResultValues build(java.util.Map<String, ?> map) throws Exception {
            QueryAllFormInstancesResponseBodyResultValues self = new QueryAllFormInstancesResponseBodyResultValues();
            return TeaModel.build(map, self);
        }

        public QueryAllFormInstancesResponseBodyResultValues setAppUuid(String appUuid) {
            this.appUuid = appUuid;
            return this;
        }
        public String getAppUuid() {
            return this.appUuid;
        }

        public QueryAllFormInstancesResponseBodyResultValues setAttributes(java.util.Map<String, ?> attributes) {
            this.attributes = attributes;
            return this;
        }
        public java.util.Map<String, ?> getAttributes() {
            return this.attributes;
        }

        public QueryAllFormInstancesResponseBodyResultValues setCreateTimestamp(Long createTimestamp) {
            this.createTimestamp = createTimestamp;
            return this;
        }
        public Long getCreateTimestamp() {
            return this.createTimestamp;
        }

        public QueryAllFormInstancesResponseBodyResultValues setCreator(String creator) {
            this.creator = creator;
            return this;
        }
        public String getCreator() {
            return this.creator;
        }

        public QueryAllFormInstancesResponseBodyResultValues setFormCode(String formCode) {
            this.formCode = formCode;
            return this;
        }
        public String getFormCode() {
            return this.formCode;
        }

        public QueryAllFormInstancesResponseBodyResultValues setFormInstDataList(java.util.List<QueryAllFormInstancesResponseBodyResultValuesFormInstDataList> formInstDataList) {
            this.formInstDataList = formInstDataList;
            return this;
        }
        public java.util.List<QueryAllFormInstancesResponseBodyResultValuesFormInstDataList> getFormInstDataList() {
            return this.formInstDataList;
        }

        public QueryAllFormInstancesResponseBodyResultValues setFormInstanceId(String formInstanceId) {
            this.formInstanceId = formInstanceId;
            return this;
        }
        public String getFormInstanceId() {
            return this.formInstanceId;
        }

        public QueryAllFormInstancesResponseBodyResultValues setModifier(String modifier) {
            this.modifier = modifier;
            return this;
        }
        public String getModifier() {
            return this.modifier;
        }

        public QueryAllFormInstancesResponseBodyResultValues setModifyTimestamp(Long modifyTimestamp) {
            this.modifyTimestamp = modifyTimestamp;
            return this;
        }
        public Long getModifyTimestamp() {
            return this.modifyTimestamp;
        }

        public QueryAllFormInstancesResponseBodyResultValues setOutBizCode(String outBizCode) {
            this.outBizCode = outBizCode;
            return this;
        }
        public String getOutBizCode() {
            return this.outBizCode;
        }

        public QueryAllFormInstancesResponseBodyResultValues setOutInstanceId(String outInstanceId) {
            this.outInstanceId = outInstanceId;
            return this;
        }
        public String getOutInstanceId() {
            return this.outInstanceId;
        }

        public QueryAllFormInstancesResponseBodyResultValues setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class QueryAllFormInstancesResponseBodyResult extends TeaModel {
        @NameInMap("hasMore")
        public Boolean hasMore;

        @NameInMap("maxResults")
        public Long maxResults;

        @NameInMap("nextToken")
        public String nextToken;

        @NameInMap("values")
        public java.util.List<QueryAllFormInstancesResponseBodyResultValues> values;

        public static QueryAllFormInstancesResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryAllFormInstancesResponseBodyResult self = new QueryAllFormInstancesResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryAllFormInstancesResponseBodyResult setHasMore(Boolean hasMore) {
            this.hasMore = hasMore;
            return this;
        }
        public Boolean getHasMore() {
            return this.hasMore;
        }

        public QueryAllFormInstancesResponseBodyResult setMaxResults(Long maxResults) {
            this.maxResults = maxResults;
            return this;
        }
        public Long getMaxResults() {
            return this.maxResults;
        }

        public QueryAllFormInstancesResponseBodyResult setNextToken(String nextToken) {
            this.nextToken = nextToken;
            return this;
        }
        public String getNextToken() {
            return this.nextToken;
        }

        public QueryAllFormInstancesResponseBodyResult setValues(java.util.List<QueryAllFormInstancesResponseBodyResultValues> values) {
            this.values = values;
            return this;
        }
        public java.util.List<QueryAllFormInstancesResponseBodyResultValues> getValues() {
            return this.values;
        }

    }

}
