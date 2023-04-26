// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class QueryFormInstanceResponseBody extends TeaModel {
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
    public java.util.List<QueryFormInstanceResponseBodyFormInstDataList> formInstDataList;

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

    public static QueryFormInstanceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryFormInstanceResponseBody self = new QueryFormInstanceResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryFormInstanceResponseBody setAppUuid(String appUuid) {
        this.appUuid = appUuid;
        return this;
    }
    public String getAppUuid() {
        return this.appUuid;
    }

    public QueryFormInstanceResponseBody setAttributes(java.util.Map<String, ?> attributes) {
        this.attributes = attributes;
        return this;
    }
    public java.util.Map<String, ?> getAttributes() {
        return this.attributes;
    }

    public QueryFormInstanceResponseBody setCreateTimestamp(Long createTimestamp) {
        this.createTimestamp = createTimestamp;
        return this;
    }
    public Long getCreateTimestamp() {
        return this.createTimestamp;
    }

    public QueryFormInstanceResponseBody setCreator(String creator) {
        this.creator = creator;
        return this;
    }
    public String getCreator() {
        return this.creator;
    }

    public QueryFormInstanceResponseBody setFormCode(String formCode) {
        this.formCode = formCode;
        return this;
    }
    public String getFormCode() {
        return this.formCode;
    }

    public QueryFormInstanceResponseBody setFormInstDataList(java.util.List<QueryFormInstanceResponseBodyFormInstDataList> formInstDataList) {
        this.formInstDataList = formInstDataList;
        return this;
    }
    public java.util.List<QueryFormInstanceResponseBodyFormInstDataList> getFormInstDataList() {
        return this.formInstDataList;
    }

    public QueryFormInstanceResponseBody setFormInstanceId(String formInstanceId) {
        this.formInstanceId = formInstanceId;
        return this;
    }
    public String getFormInstanceId() {
        return this.formInstanceId;
    }

    public QueryFormInstanceResponseBody setModifier(String modifier) {
        this.modifier = modifier;
        return this;
    }
    public String getModifier() {
        return this.modifier;
    }

    public QueryFormInstanceResponseBody setModifyTimestamp(Long modifyTimestamp) {
        this.modifyTimestamp = modifyTimestamp;
        return this;
    }
    public Long getModifyTimestamp() {
        return this.modifyTimestamp;
    }

    public QueryFormInstanceResponseBody setOutBizCode(String outBizCode) {
        this.outBizCode = outBizCode;
        return this;
    }
    public String getOutBizCode() {
        return this.outBizCode;
    }

    public QueryFormInstanceResponseBody setOutInstanceId(String outInstanceId) {
        this.outInstanceId = outInstanceId;
        return this;
    }
    public String getOutInstanceId() {
        return this.outInstanceId;
    }

    public QueryFormInstanceResponseBody setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public static class QueryFormInstanceResponseBodyFormInstDataList extends TeaModel {
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

        public static QueryFormInstanceResponseBodyFormInstDataList build(java.util.Map<String, ?> map) throws Exception {
            QueryFormInstanceResponseBodyFormInstDataList self = new QueryFormInstanceResponseBodyFormInstDataList();
            return TeaModel.build(map, self);
        }

        public QueryFormInstanceResponseBodyFormInstDataList setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
        }

        public QueryFormInstanceResponseBodyFormInstDataList setComponentType(String componentType) {
            this.componentType = componentType;
            return this;
        }
        public String getComponentType() {
            return this.componentType;
        }

        public QueryFormInstanceResponseBodyFormInstDataList setExtendValue(String extendValue) {
            this.extendValue = extendValue;
            return this;
        }
        public String getExtendValue() {
            return this.extendValue;
        }

        public QueryFormInstanceResponseBodyFormInstDataList setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

        public QueryFormInstanceResponseBodyFormInstDataList setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public QueryFormInstanceResponseBodyFormInstDataList setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

}
