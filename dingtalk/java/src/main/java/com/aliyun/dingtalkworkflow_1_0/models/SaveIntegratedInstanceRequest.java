// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class SaveIntegratedInstanceRequest extends TeaModel {
    @NameInMap("formComponentValueList")
    public java.util.List<SaveIntegratedInstanceRequestFormComponentValueList> formComponentValueList;

    @NameInMap("notifiers")
    public java.util.List<SaveIntegratedInstanceRequestNotifiers> notifiers;

    @NameInMap("originatorUserId")
    public String originatorUserId;

    @NameInMap("processCode")
    public String processCode;

    @NameInMap("title")
    public String title;

    @NameInMap("url")
    public String url;

    public static SaveIntegratedInstanceRequest build(java.util.Map<String, ?> map) throws Exception {
        SaveIntegratedInstanceRequest self = new SaveIntegratedInstanceRequest();
        return TeaModel.build(map, self);
    }

    public SaveIntegratedInstanceRequest setFormComponentValueList(java.util.List<SaveIntegratedInstanceRequestFormComponentValueList> formComponentValueList) {
        this.formComponentValueList = formComponentValueList;
        return this;
    }
    public java.util.List<SaveIntegratedInstanceRequestFormComponentValueList> getFormComponentValueList() {
        return this.formComponentValueList;
    }

    public SaveIntegratedInstanceRequest setNotifiers(java.util.List<SaveIntegratedInstanceRequestNotifiers> notifiers) {
        this.notifiers = notifiers;
        return this;
    }
    public java.util.List<SaveIntegratedInstanceRequestNotifiers> getNotifiers() {
        return this.notifiers;
    }

    public SaveIntegratedInstanceRequest setOriginatorUserId(String originatorUserId) {
        this.originatorUserId = originatorUserId;
        return this;
    }
    public String getOriginatorUserId() {
        return this.originatorUserId;
    }

    public SaveIntegratedInstanceRequest setProcessCode(String processCode) {
        this.processCode = processCode;
        return this;
    }
    public String getProcessCode() {
        return this.processCode;
    }

    public SaveIntegratedInstanceRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public SaveIntegratedInstanceRequest setUrl(String url) {
        this.url = url;
        return this;
    }
    public String getUrl() {
        return this.url;
    }

    public static class SaveIntegratedInstanceRequestFormComponentValueList extends TeaModel {
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

        public static SaveIntegratedInstanceRequestFormComponentValueList build(java.util.Map<String, ?> map) throws Exception {
            SaveIntegratedInstanceRequestFormComponentValueList self = new SaveIntegratedInstanceRequestFormComponentValueList();
            return TeaModel.build(map, self);
        }

        public SaveIntegratedInstanceRequestFormComponentValueList setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
        }

        public SaveIntegratedInstanceRequestFormComponentValueList setComponentType(String componentType) {
            this.componentType = componentType;
            return this;
        }
        public String getComponentType() {
            return this.componentType;
        }

        public SaveIntegratedInstanceRequestFormComponentValueList setExtValue(String extValue) {
            this.extValue = extValue;
            return this;
        }
        public String getExtValue() {
            return this.extValue;
        }

        public SaveIntegratedInstanceRequestFormComponentValueList setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public SaveIntegratedInstanceRequestFormComponentValueList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public SaveIntegratedInstanceRequestFormComponentValueList setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class SaveIntegratedInstanceRequestNotifiers extends TeaModel {
        @NameInMap("position")
        public String position;

        @NameInMap("userid")
        public String userid;

        public static SaveIntegratedInstanceRequestNotifiers build(java.util.Map<String, ?> map) throws Exception {
            SaveIntegratedInstanceRequestNotifiers self = new SaveIntegratedInstanceRequestNotifiers();
            return TeaModel.build(map, self);
        }

        public SaveIntegratedInstanceRequestNotifiers setPosition(String position) {
            this.position = position;
            return this;
        }
        public String getPosition() {
            return this.position;
        }

        public SaveIntegratedInstanceRequestNotifiers setUserid(String userid) {
            this.userid = userid;
            return this;
        }
        public String getUserid() {
            return this.userid;
        }

    }

}
