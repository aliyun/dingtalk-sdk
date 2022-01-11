// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class QueryAllFormInstancesResponseBody extends TeaModel {
    // 分页结果
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
        // 控件别名
        @NameInMap("bizAlias")
        public String bizAlias;

        // 控件类型
        @NameInMap("componentType")
        public String componentType;

        // 表单控件扩展数据
        @NameInMap("extendValue")
        public String extendValue;

        // 控件唯一id
        @NameInMap("key")
        public String key;

        // 控件名称
        @NameInMap("label")
        public String label;

        // 控件填写的数据
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
        // 应用搭建id
        @NameInMap("appUuid")
        public String appUuid;

        // 扩展信息
        @NameInMap("attributes")
        public java.util.Map<String, ?> attributes;

        // 创建时间
        @NameInMap("createTimestamp")
        public Long createTimestamp;

        // 创建人
        @NameInMap("creator")
        public String creator;

        // 表单模板code
        @NameInMap("formCode")
        public String formCode;

        // 表单实例数据
        @NameInMap("formInstDataList")
        public java.util.List<QueryAllFormInstancesResponseBodyResultValuesFormInstDataList> formInstDataList;

        // 表单实例id
        @NameInMap("formInstanceId")
        public String formInstanceId;

        // 修改人
        @NameInMap("modifier")
        public String modifier;

        // 修改时间
        @NameInMap("modifyTimestamp")
        public Long modifyTimestamp;

        // 外部业务编码
        @NameInMap("outBizCode")
        public String outBizCode;

        // 外部实例编码
        @NameInMap("outInstanceId")
        public String outInstanceId;

        // 标题
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
        // 是否有更多数据
        @NameInMap("hasMore")
        public Boolean hasMore;

        // 分页大小
        @NameInMap("maxResults")
        public Long maxResults;

        // 下一页的游标
        @NameInMap("nextToken")
        public String nextToken;

        // 表单列表
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
