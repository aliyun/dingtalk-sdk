// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcustomer_service_1_0.models;

import com.aliyun.tea.*;

public class CreateTicketRequest extends TeaModel {
    /**
     * <p>第三方会员ID</p>
     */
    @NameInMap("foreignId")
    public String foreignId;

    /**
     * <p>第三方会员名称</p>
     */
    @NameInMap("foreignName")
    public String foreignName;

    /**
     * <p>实例ID</p>
     */
    @NameInMap("openInstanceId")
    public String openInstanceId;

    /**
     * <p>智能客服产品</p>
     */
    @NameInMap("productionType")
    public Integer productionType;

    /**
     * <p>工单表单</p>
     */
    @NameInMap("properties")
    public java.util.List<CreateTicketRequestProperties> properties;

    /**
     * <p>会员来源</p>
     */
    @NameInMap("sourceId")
    public String sourceId;

    /**
     * <p>工单模板ID</p>
     */
    @NameInMap("templateId")
    public String templateId;

    /**
     * <p>工单标题</p>
     */
    @NameInMap("title")
    public String title;

    public static CreateTicketRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateTicketRequest self = new CreateTicketRequest();
        return TeaModel.build(map, self);
    }

    public CreateTicketRequest setForeignId(String foreignId) {
        this.foreignId = foreignId;
        return this;
    }
    public String getForeignId() {
        return this.foreignId;
    }

    public CreateTicketRequest setForeignName(String foreignName) {
        this.foreignName = foreignName;
        return this;
    }
    public String getForeignName() {
        return this.foreignName;
    }

    public CreateTicketRequest setOpenInstanceId(String openInstanceId) {
        this.openInstanceId = openInstanceId;
        return this;
    }
    public String getOpenInstanceId() {
        return this.openInstanceId;
    }

    public CreateTicketRequest setProductionType(Integer productionType) {
        this.productionType = productionType;
        return this;
    }
    public Integer getProductionType() {
        return this.productionType;
    }

    public CreateTicketRequest setProperties(java.util.List<CreateTicketRequestProperties> properties) {
        this.properties = properties;
        return this;
    }
    public java.util.List<CreateTicketRequestProperties> getProperties() {
        return this.properties;
    }

    public CreateTicketRequest setSourceId(String sourceId) {
        this.sourceId = sourceId;
        return this;
    }
    public String getSourceId() {
        return this.sourceId;
    }

    public CreateTicketRequest setTemplateId(String templateId) {
        this.templateId = templateId;
        return this;
    }
    public String getTemplateId() {
        return this.templateId;
    }

    public CreateTicketRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public static class CreateTicketRequestProperties extends TeaModel {
        @NameInMap("name")
        public String name;

        @NameInMap("value")
        public String value;

        public static CreateTicketRequestProperties build(java.util.Map<String, ?> map) throws Exception {
            CreateTicketRequestProperties self = new CreateTicketRequestProperties();
            return TeaModel.build(map, self);
        }

        public CreateTicketRequestProperties setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public CreateTicketRequestProperties setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

}
