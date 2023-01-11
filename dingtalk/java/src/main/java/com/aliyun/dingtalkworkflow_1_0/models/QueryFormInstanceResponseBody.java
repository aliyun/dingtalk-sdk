// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class QueryFormInstanceResponseBody extends TeaModel {
    /**
     * <p>应用搭建id</p>
     */
    @NameInMap("appUuid")
    public String appUuid;

    /**
     * <p>扩展信息</p>
     */
    @NameInMap("attributes")
    public java.util.Map<String, ?> attributes;

    /**
     * <p>实例创建时间戳</p>
     */
    @NameInMap("createTimestamp")
    public Long createTimestamp;

    /**
     * <p>创建人</p>
     */
    @NameInMap("creator")
    public String creator;

    /**
     * <p>表单模板id</p>
     */
    @NameInMap("formCode")
    public String formCode;

    /**
     * <p>表单数据</p>
     */
    @NameInMap("formInstDataList")
    public java.util.List<QueryFormInstanceResponseBodyFormInstDataList> formInstDataList;

    /**
     * <p>实例id</p>
     */
    @NameInMap("formInstanceId")
    public String formInstanceId;

    /**
     * <p>修改人</p>
     */
    @NameInMap("modifier")
    public String modifier;

    /**
     * <p>实例最近修改时间戳</p>
     */
    @NameInMap("modifyTimestamp")
    public Long modifyTimestamp;

    /**
     * <p>外联业务code</p>
     */
    @NameInMap("outBizCode")
    public String outBizCode;

    /**
     * <p>外联业务实例id</p>
     */
    @NameInMap("outInstanceId")
    public String outInstanceId;

    /**
     * <p>表单标题</p>
     */
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
