// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumSaveIntegratedProcessInstanceRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>&quot;{&quot;mykey&quot;: &quot;myData&quot;}&quot;</p>
     */
    @NameInMap("bizData")
    public String bizData;

    @NameInMap("formComponentValueList")
    public java.util.List<PremiumSaveIntegratedProcessInstanceRequestFormComponentValueList> formComponentValueList;

    @NameInMap("notifiers")
    public java.util.List<PremiumSaveIntegratedProcessInstanceRequestNotifiers> notifiers;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("originatorUserId")
    public String originatorUserId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("processCode")
    public String processCode;

    @NameInMap("title")
    public String title;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p><a href="https://www.dingtalk.com/">https://www.dingtalk.com/</a></p>
     */
    @NameInMap("url")
    public String url;

    public static PremiumSaveIntegratedProcessInstanceRequest build(java.util.Map<String, ?> map) throws Exception {
        PremiumSaveIntegratedProcessInstanceRequest self = new PremiumSaveIntegratedProcessInstanceRequest();
        return TeaModel.build(map, self);
    }

    public PremiumSaveIntegratedProcessInstanceRequest setBizData(String bizData) {
        this.bizData = bizData;
        return this;
    }
    public String getBizData() {
        return this.bizData;
    }

    public PremiumSaveIntegratedProcessInstanceRequest setFormComponentValueList(java.util.List<PremiumSaveIntegratedProcessInstanceRequestFormComponentValueList> formComponentValueList) {
        this.formComponentValueList = formComponentValueList;
        return this;
    }
    public java.util.List<PremiumSaveIntegratedProcessInstanceRequestFormComponentValueList> getFormComponentValueList() {
        return this.formComponentValueList;
    }

    public PremiumSaveIntegratedProcessInstanceRequest setNotifiers(java.util.List<PremiumSaveIntegratedProcessInstanceRequestNotifiers> notifiers) {
        this.notifiers = notifiers;
        return this;
    }
    public java.util.List<PremiumSaveIntegratedProcessInstanceRequestNotifiers> getNotifiers() {
        return this.notifiers;
    }

    public PremiumSaveIntegratedProcessInstanceRequest setOriginatorUserId(String originatorUserId) {
        this.originatorUserId = originatorUserId;
        return this;
    }
    public String getOriginatorUserId() {
        return this.originatorUserId;
    }

    public PremiumSaveIntegratedProcessInstanceRequest setProcessCode(String processCode) {
        this.processCode = processCode;
        return this;
    }
    public String getProcessCode() {
        return this.processCode;
    }

    public PremiumSaveIntegratedProcessInstanceRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public PremiumSaveIntegratedProcessInstanceRequest setUrl(String url) {
        this.url = url;
        return this;
    }
    public String getUrl() {
        return this.url;
    }

    public static class PremiumSaveIntegratedProcessInstanceRequestFormComponentValueList extends TeaModel {
        @NameInMap("bizAlias")
        public String bizAlias;

        @NameInMap("componentType")
        public String componentType;

        @NameInMap("extValue")
        public String extValue;

        @NameInMap("id")
        public String id;

        @NameInMap("name")
        public String name;

        @NameInMap("value")
        public String value;

        public static PremiumSaveIntegratedProcessInstanceRequestFormComponentValueList build(java.util.Map<String, ?> map) throws Exception {
            PremiumSaveIntegratedProcessInstanceRequestFormComponentValueList self = new PremiumSaveIntegratedProcessInstanceRequestFormComponentValueList();
            return TeaModel.build(map, self);
        }

        public PremiumSaveIntegratedProcessInstanceRequestFormComponentValueList setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
        }

        public PremiumSaveIntegratedProcessInstanceRequestFormComponentValueList setComponentType(String componentType) {
            this.componentType = componentType;
            return this;
        }
        public String getComponentType() {
            return this.componentType;
        }

        public PremiumSaveIntegratedProcessInstanceRequestFormComponentValueList setExtValue(String extValue) {
            this.extValue = extValue;
            return this;
        }
        public String getExtValue() {
            return this.extValue;
        }

        public PremiumSaveIntegratedProcessInstanceRequestFormComponentValueList setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public PremiumSaveIntegratedProcessInstanceRequestFormComponentValueList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public PremiumSaveIntegratedProcessInstanceRequestFormComponentValueList setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class PremiumSaveIntegratedProcessInstanceRequestNotifiers extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>start</p>
         */
        @NameInMap("position")
        public String position;

        /**
         * <strong>example:</strong>
         * <p>manager001</p>
         */
        @NameInMap("userid")
        public String userid;

        public static PremiumSaveIntegratedProcessInstanceRequestNotifiers build(java.util.Map<String, ?> map) throws Exception {
            PremiumSaveIntegratedProcessInstanceRequestNotifiers self = new PremiumSaveIntegratedProcessInstanceRequestNotifiers();
            return TeaModel.build(map, self);
        }

        public PremiumSaveIntegratedProcessInstanceRequestNotifiers setPosition(String position) {
            this.position = position;
            return this;
        }
        public String getPosition() {
            return this.position;
        }

        public PremiumSaveIntegratedProcessInstanceRequestNotifiers setUserid(String userid) {
            this.userid = userid;
            return this;
        }
        public String getUserid() {
            return this.userid;
        }

    }

}
