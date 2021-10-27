// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class QueryFormInstanceResponseBody extends TeaModel {
    // 实例id
    @NameInMap("formInstanceId")
    public String formInstanceId;

    // 表单数据
    @NameInMap("formInstDataList")
    public java.util.List<QueryFormInstanceResponseBodyFormInstDataList> formInstDataList;

    // 应用搭建id
    @NameInMap("appUuid")
    public String appUuid;

    // 表单模板id
    @NameInMap("formCode")
    public String formCode;

    // 表单标题
    @NameInMap("title")
    public String title;

    // 创建人
    @NameInMap("creator")
    public String creator;

    // 修改人
    @NameInMap("modifier")
    public String modifier;

    // 实例创建时间戳
    @NameInMap("createTimestamp")
    public Long createTimestamp;

    // 实例最近修改时间戳
    @NameInMap("modifyTimestamp")
    public Long modifyTimestamp;

    // 外联业务实例id
    @NameInMap("outInstanceId")
    public String outInstanceId;

    // 外联业务code
    @NameInMap("outBizCode")
    public String outBizCode;

    // 扩展信息
    @NameInMap("attributes")
    public java.util.Map<String, ?> attributes;

    public static QueryFormInstanceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryFormInstanceResponseBody self = new QueryFormInstanceResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryFormInstanceResponseBody setFormInstanceId(String formInstanceId) {
        this.formInstanceId = formInstanceId;
        return this;
    }
    public String getFormInstanceId() {
        return this.formInstanceId;
    }

    public QueryFormInstanceResponseBody setFormInstDataList(java.util.List<QueryFormInstanceResponseBodyFormInstDataList> formInstDataList) {
        this.formInstDataList = formInstDataList;
        return this;
    }
    public java.util.List<QueryFormInstanceResponseBodyFormInstDataList> getFormInstDataList() {
        return this.formInstDataList;
    }

    public QueryFormInstanceResponseBody setAppUuid(String appUuid) {
        this.appUuid = appUuid;
        return this;
    }
    public String getAppUuid() {
        return this.appUuid;
    }

    public QueryFormInstanceResponseBody setFormCode(String formCode) {
        this.formCode = formCode;
        return this;
    }
    public String getFormCode() {
        return this.formCode;
    }

    public QueryFormInstanceResponseBody setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public QueryFormInstanceResponseBody setCreator(String creator) {
        this.creator = creator;
        return this;
    }
    public String getCreator() {
        return this.creator;
    }

    public QueryFormInstanceResponseBody setModifier(String modifier) {
        this.modifier = modifier;
        return this;
    }
    public String getModifier() {
        return this.modifier;
    }

    public QueryFormInstanceResponseBody setCreateTimestamp(Long createTimestamp) {
        this.createTimestamp = createTimestamp;
        return this;
    }
    public Long getCreateTimestamp() {
        return this.createTimestamp;
    }

    public QueryFormInstanceResponseBody setModifyTimestamp(Long modifyTimestamp) {
        this.modifyTimestamp = modifyTimestamp;
        return this;
    }
    public Long getModifyTimestamp() {
        return this.modifyTimestamp;
    }

    public QueryFormInstanceResponseBody setOutInstanceId(String outInstanceId) {
        this.outInstanceId = outInstanceId;
        return this;
    }
    public String getOutInstanceId() {
        return this.outInstanceId;
    }

    public QueryFormInstanceResponseBody setOutBizCode(String outBizCode) {
        this.outBizCode = outBizCode;
        return this;
    }
    public String getOutBizCode() {
        return this.outBizCode;
    }

    public QueryFormInstanceResponseBody setAttributes(java.util.Map<String, ?> attributes) {
        this.attributes = attributes;
        return this;
    }
    public java.util.Map<String, ?> getAttributes() {
        return this.attributes;
    }

    public static class QueryFormInstanceResponseBodyFormInstDataList extends TeaModel {
        @NameInMap("componentType")
        public String componentType;

        @NameInMap("bizAlias")
        public String bizAlias;

        @NameInMap("extendValue")
        public String extendValue;

        @NameInMap("label")
        public String label;

        @NameInMap("value")
        public String value;

        @NameInMap("key")
        public String key;

        public static QueryFormInstanceResponseBodyFormInstDataList build(java.util.Map<String, ?> map) throws Exception {
            QueryFormInstanceResponseBodyFormInstDataList self = new QueryFormInstanceResponseBodyFormInstDataList();
            return TeaModel.build(map, self);
        }

        public QueryFormInstanceResponseBodyFormInstDataList setComponentType(String componentType) {
            this.componentType = componentType;
            return this;
        }
        public String getComponentType() {
            return this.componentType;
        }

        public QueryFormInstanceResponseBodyFormInstDataList setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
        }

        public QueryFormInstanceResponseBodyFormInstDataList setExtendValue(String extendValue) {
            this.extendValue = extendValue;
            return this;
        }
        public String getExtendValue() {
            return this.extendValue;
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

        public QueryFormInstanceResponseBodyFormInstDataList setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

    }

}
