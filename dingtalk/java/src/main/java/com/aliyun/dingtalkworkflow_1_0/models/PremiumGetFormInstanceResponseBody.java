// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumGetFormInstanceResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>SWAPP-dfeacds-example</p>
     */
    @NameInMap("appUuid")
    public String appUuid;

    @NameInMap("attributes")
    public java.util.Map<String, ?> attributes;

    /**
     * <strong>example:</strong>
     * <p>1631870043000</p>
     */
    @NameInMap("createTimestamp")
    public Long createTimestamp;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>00003</p>
     */
    @NameInMap("creator")
    public String creator;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>PROC-abcdef-example</p>
     */
    @NameInMap("formCode")
    public String formCode;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("formInstDataList")
    public java.util.List<PremiumGetFormInstanceResponseBodyFormInstDataList> formInstDataList;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>951a8-8828-430c-b3e-example</p>
     */
    @NameInMap("formInstanceId")
    public String formInstanceId;

    /**
     * <strong>example:</strong>
     * <p>000025</p>
     */
    @NameInMap("modifier")
    public String modifier;

    /**
     * <strong>example:</strong>
     * <p>1631870043000</p>
     */
    @NameInMap("modifyTimestamp")
    public Long modifyTimestamp;

    /**
     * <strong>example:</strong>
     * <p>PROC-abcdef-example</p>
     */
    @NameInMap("outBizCode")
    public String outBizCode;

    /**
     * <strong>example:</strong>
     * <p>951a8-8828-430c-b3e-example</p>
     */
    @NameInMap("outInstanceId")
    public String outInstanceId;

    /**
     * <strong>example:</strong>
     * <p>xxx提交的表单数据</p>
     */
    @NameInMap("title")
    public String title;

    public static PremiumGetFormInstanceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PremiumGetFormInstanceResponseBody self = new PremiumGetFormInstanceResponseBody();
        return TeaModel.build(map, self);
    }

    public PremiumGetFormInstanceResponseBody setAppUuid(String appUuid) {
        this.appUuid = appUuid;
        return this;
    }
    public String getAppUuid() {
        return this.appUuid;
    }

    public PremiumGetFormInstanceResponseBody setAttributes(java.util.Map<String, ?> attributes) {
        this.attributes = attributes;
        return this;
    }
    public java.util.Map<String, ?> getAttributes() {
        return this.attributes;
    }

    public PremiumGetFormInstanceResponseBody setCreateTimestamp(Long createTimestamp) {
        this.createTimestamp = createTimestamp;
        return this;
    }
    public Long getCreateTimestamp() {
        return this.createTimestamp;
    }

    public PremiumGetFormInstanceResponseBody setCreator(String creator) {
        this.creator = creator;
        return this;
    }
    public String getCreator() {
        return this.creator;
    }

    public PremiumGetFormInstanceResponseBody setFormCode(String formCode) {
        this.formCode = formCode;
        return this;
    }
    public String getFormCode() {
        return this.formCode;
    }

    public PremiumGetFormInstanceResponseBody setFormInstDataList(java.util.List<PremiumGetFormInstanceResponseBodyFormInstDataList> formInstDataList) {
        this.formInstDataList = formInstDataList;
        return this;
    }
    public java.util.List<PremiumGetFormInstanceResponseBodyFormInstDataList> getFormInstDataList() {
        return this.formInstDataList;
    }

    public PremiumGetFormInstanceResponseBody setFormInstanceId(String formInstanceId) {
        this.formInstanceId = formInstanceId;
        return this;
    }
    public String getFormInstanceId() {
        return this.formInstanceId;
    }

    public PremiumGetFormInstanceResponseBody setModifier(String modifier) {
        this.modifier = modifier;
        return this;
    }
    public String getModifier() {
        return this.modifier;
    }

    public PremiumGetFormInstanceResponseBody setModifyTimestamp(Long modifyTimestamp) {
        this.modifyTimestamp = modifyTimestamp;
        return this;
    }
    public Long getModifyTimestamp() {
        return this.modifyTimestamp;
    }

    public PremiumGetFormInstanceResponseBody setOutBizCode(String outBizCode) {
        this.outBizCode = outBizCode;
        return this;
    }
    public String getOutBizCode() {
        return this.outBizCode;
    }

    public PremiumGetFormInstanceResponseBody setOutInstanceId(String outInstanceId) {
        this.outInstanceId = outInstanceId;
        return this;
    }
    public String getOutInstanceId() {
        return this.outInstanceId;
    }

    public PremiumGetFormInstanceResponseBody setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public static class PremiumGetFormInstanceResponseBodyFormInstDataList extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("bizAlias")
        public String bizAlias;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("componentType")
        public String componentType;

        /**
         * <p>This parameter is required.</p>
         */
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
        @NameInMap("label")
        public String label;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("value")
        public String value;

        public static PremiumGetFormInstanceResponseBodyFormInstDataList build(java.util.Map<String, ?> map) throws Exception {
            PremiumGetFormInstanceResponseBodyFormInstDataList self = new PremiumGetFormInstanceResponseBodyFormInstDataList();
            return TeaModel.build(map, self);
        }

        public PremiumGetFormInstanceResponseBodyFormInstDataList setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
        }

        public PremiumGetFormInstanceResponseBodyFormInstDataList setComponentType(String componentType) {
            this.componentType = componentType;
            return this;
        }
        public String getComponentType() {
            return this.componentType;
        }

        public PremiumGetFormInstanceResponseBodyFormInstDataList setExtendValue(String extendValue) {
            this.extendValue = extendValue;
            return this;
        }
        public String getExtendValue() {
            return this.extendValue;
        }

        public PremiumGetFormInstanceResponseBodyFormInstDataList setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

        public PremiumGetFormInstanceResponseBodyFormInstDataList setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public PremiumGetFormInstanceResponseBodyFormInstDataList setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

}
