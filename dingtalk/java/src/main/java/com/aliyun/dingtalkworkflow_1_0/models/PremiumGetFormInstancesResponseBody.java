// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumGetFormInstancesResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("result")
    public PremiumGetFormInstancesResponseBodyResult result;

    public static PremiumGetFormInstancesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PremiumGetFormInstancesResponseBody self = new PremiumGetFormInstancesResponseBody();
        return TeaModel.build(map, self);
    }

    public PremiumGetFormInstancesResponseBody setResult(PremiumGetFormInstancesResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public PremiumGetFormInstancesResponseBodyResult getResult() {
        return this.result;
    }

    public static class PremiumGetFormInstancesResponseBodyResultValuesFormInstDataList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>staff_name</p>
         */
        @NameInMap("bizAlias")
        public String bizAlias;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>具体参见审批控件列表</p>
         */
        @NameInMap("componentType")
        public String componentType;

        /**
         * <strong>example:</strong>
         * <p>{&quot;key&quot;:&quot;value}</p>
         */
        @NameInMap("extendValue")
        public String extendValue;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>TextField-abcdefg</p>
         */
        @NameInMap("key")
        public String key;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>员工姓名</p>
         */
        @NameInMap("label")
        public String label;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>张三</p>
         */
        @NameInMap("value")
        public String value;

        public static PremiumGetFormInstancesResponseBodyResultValuesFormInstDataList build(java.util.Map<String, ?> map) throws Exception {
            PremiumGetFormInstancesResponseBodyResultValuesFormInstDataList self = new PremiumGetFormInstancesResponseBodyResultValuesFormInstDataList();
            return TeaModel.build(map, self);
        }

        public PremiumGetFormInstancesResponseBodyResultValuesFormInstDataList setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
        }

        public PremiumGetFormInstancesResponseBodyResultValuesFormInstDataList setComponentType(String componentType) {
            this.componentType = componentType;
            return this;
        }
        public String getComponentType() {
            return this.componentType;
        }

        public PremiumGetFormInstancesResponseBodyResultValuesFormInstDataList setExtendValue(String extendValue) {
            this.extendValue = extendValue;
            return this;
        }
        public String getExtendValue() {
            return this.extendValue;
        }

        public PremiumGetFormInstancesResponseBodyResultValuesFormInstDataList setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

        public PremiumGetFormInstancesResponseBodyResultValuesFormInstDataList setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public PremiumGetFormInstancesResponseBodyResultValuesFormInstDataList setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class PremiumGetFormInstancesResponseBodyResultValues extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>SWAPP-abcd-example</p>
         */
        @NameInMap("appUuid")
        public String appUuid;

        @NameInMap("attributes")
        public java.util.Map<String, ?> attributes;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1635151039000</p>
         */
        @NameInMap("createTimestamp")
        public Long createTimestamp;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>30314512</p>
         */
        @NameInMap("creator")
        public String creator;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>PROC-abcd-example</p>
         */
        @NameInMap("formCode")
        public String formCode;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("formInstDataList")
        public java.util.List<PremiumGetFormInstancesResponseBodyResultValuesFormInstDataList> formInstDataList;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>abcd-eaf-acde12f</p>
         */
        @NameInMap("formInstanceId")
        public String formInstanceId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>032142312</p>
         */
        @NameInMap("modifier")
        public String modifier;

        /**
         * <strong>example:</strong>
         * <p>1635151039000</p>
         */
        @NameInMap("modifyTimestamp")
        public Long modifyTimestamp;

        /**
         * <strong>example:</strong>
         * <p>abcd</p>
         */
        @NameInMap("outBizCode")
        public String outBizCode;

        /**
         * <strong>example:</strong>
         * <p>323</p>
         */
        @NameInMap("outInstanceId")
        public String outInstanceId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>xxx提交的数据</p>
         */
        @NameInMap("title")
        public String title;

        public static PremiumGetFormInstancesResponseBodyResultValues build(java.util.Map<String, ?> map) throws Exception {
            PremiumGetFormInstancesResponseBodyResultValues self = new PremiumGetFormInstancesResponseBodyResultValues();
            return TeaModel.build(map, self);
        }

        public PremiumGetFormInstancesResponseBodyResultValues setAppUuid(String appUuid) {
            this.appUuid = appUuid;
            return this;
        }
        public String getAppUuid() {
            return this.appUuid;
        }

        public PremiumGetFormInstancesResponseBodyResultValues setAttributes(java.util.Map<String, ?> attributes) {
            this.attributes = attributes;
            return this;
        }
        public java.util.Map<String, ?> getAttributes() {
            return this.attributes;
        }

        public PremiumGetFormInstancesResponseBodyResultValues setCreateTimestamp(Long createTimestamp) {
            this.createTimestamp = createTimestamp;
            return this;
        }
        public Long getCreateTimestamp() {
            return this.createTimestamp;
        }

        public PremiumGetFormInstancesResponseBodyResultValues setCreator(String creator) {
            this.creator = creator;
            return this;
        }
        public String getCreator() {
            return this.creator;
        }

        public PremiumGetFormInstancesResponseBodyResultValues setFormCode(String formCode) {
            this.formCode = formCode;
            return this;
        }
        public String getFormCode() {
            return this.formCode;
        }

        public PremiumGetFormInstancesResponseBodyResultValues setFormInstDataList(java.util.List<PremiumGetFormInstancesResponseBodyResultValuesFormInstDataList> formInstDataList) {
            this.formInstDataList = formInstDataList;
            return this;
        }
        public java.util.List<PremiumGetFormInstancesResponseBodyResultValuesFormInstDataList> getFormInstDataList() {
            return this.formInstDataList;
        }

        public PremiumGetFormInstancesResponseBodyResultValues setFormInstanceId(String formInstanceId) {
            this.formInstanceId = formInstanceId;
            return this;
        }
        public String getFormInstanceId() {
            return this.formInstanceId;
        }

        public PremiumGetFormInstancesResponseBodyResultValues setModifier(String modifier) {
            this.modifier = modifier;
            return this;
        }
        public String getModifier() {
            return this.modifier;
        }

        public PremiumGetFormInstancesResponseBodyResultValues setModifyTimestamp(Long modifyTimestamp) {
            this.modifyTimestamp = modifyTimestamp;
            return this;
        }
        public Long getModifyTimestamp() {
            return this.modifyTimestamp;
        }

        public PremiumGetFormInstancesResponseBodyResultValues setOutBizCode(String outBizCode) {
            this.outBizCode = outBizCode;
            return this;
        }
        public String getOutBizCode() {
            return this.outBizCode;
        }

        public PremiumGetFormInstancesResponseBodyResultValues setOutInstanceId(String outInstanceId) {
            this.outInstanceId = outInstanceId;
            return this;
        }
        public String getOutInstanceId() {
            return this.outInstanceId;
        }

        public PremiumGetFormInstancesResponseBodyResultValues setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class PremiumGetFormInstancesResponseBodyResult extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>true</p>
         */
        @NameInMap("hasMore")
        public Boolean hasMore;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>20</p>
         */
        @NameInMap("maxResults")
        public Long maxResults;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>10</p>
         */
        @NameInMap("nextToken")
        public String nextToken;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("values")
        public java.util.List<PremiumGetFormInstancesResponseBodyResultValues> values;

        public static PremiumGetFormInstancesResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            PremiumGetFormInstancesResponseBodyResult self = new PremiumGetFormInstancesResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public PremiumGetFormInstancesResponseBodyResult setHasMore(Boolean hasMore) {
            this.hasMore = hasMore;
            return this;
        }
        public Boolean getHasMore() {
            return this.hasMore;
        }

        public PremiumGetFormInstancesResponseBodyResult setMaxResults(Long maxResults) {
            this.maxResults = maxResults;
            return this;
        }
        public Long getMaxResults() {
            return this.maxResults;
        }

        public PremiumGetFormInstancesResponseBodyResult setNextToken(String nextToken) {
            this.nextToken = nextToken;
            return this;
        }
        public String getNextToken() {
            return this.nextToken;
        }

        public PremiumGetFormInstancesResponseBodyResult setValues(java.util.List<PremiumGetFormInstancesResponseBodyResultValues> values) {
            this.values = values;
            return this;
        }
        public java.util.List<PremiumGetFormInstancesResponseBodyResultValues> getValues() {
            return this.values;
        }

    }

}
