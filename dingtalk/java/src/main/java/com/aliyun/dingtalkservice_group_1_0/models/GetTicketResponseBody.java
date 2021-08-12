// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class GetTicketResponseBody extends TeaModel {
    // Id of the request
    @NameInMap("openTicketId")
    public String openTicketId;

    @NameInMap("createTime")
    public String createTime;

    @NameInMap("updateTime")
    public String updateTime;

    @NameInMap("openConversationId")
    public String openConversationId;

    @NameInMap("creator")
    public GetTicketResponseBodyCreator creator;

    @NameInMap("processor")
    public GetTicketResponseBodyProcessor processor;

    @NameInMap("takers")
    public java.util.List<GetTicketResponseBodyTakers> takers;

    @NameInMap("stage")
    public String stage;

    @NameInMap("title")
    public String title;

    @NameInMap("customFields")
    public String customFields;

    @NameInMap("scene")
    public String scene;

    @NameInMap("sceneContext")
    public String sceneContext;

    @NameInMap("template")
    public GetTicketResponseBodyTemplate template;

    public static GetTicketResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetTicketResponseBody self = new GetTicketResponseBody();
        return TeaModel.build(map, self);
    }

    public GetTicketResponseBody setOpenTicketId(String openTicketId) {
        this.openTicketId = openTicketId;
        return this;
    }
    public String getOpenTicketId() {
        return this.openTicketId;
    }

    public GetTicketResponseBody setCreateTime(String createTime) {
        this.createTime = createTime;
        return this;
    }
    public String getCreateTime() {
        return this.createTime;
    }

    public GetTicketResponseBody setUpdateTime(String updateTime) {
        this.updateTime = updateTime;
        return this;
    }
    public String getUpdateTime() {
        return this.updateTime;
    }

    public GetTicketResponseBody setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public GetTicketResponseBody setCreator(GetTicketResponseBodyCreator creator) {
        this.creator = creator;
        return this;
    }
    public GetTicketResponseBodyCreator getCreator() {
        return this.creator;
    }

    public GetTicketResponseBody setProcessor(GetTicketResponseBodyProcessor processor) {
        this.processor = processor;
        return this;
    }
    public GetTicketResponseBodyProcessor getProcessor() {
        return this.processor;
    }

    public GetTicketResponseBody setTakers(java.util.List<GetTicketResponseBodyTakers> takers) {
        this.takers = takers;
        return this;
    }
    public java.util.List<GetTicketResponseBodyTakers> getTakers() {
        return this.takers;
    }

    public GetTicketResponseBody setStage(String stage) {
        this.stage = stage;
        return this;
    }
    public String getStage() {
        return this.stage;
    }

    public GetTicketResponseBody setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public GetTicketResponseBody setCustomFields(String customFields) {
        this.customFields = customFields;
        return this;
    }
    public String getCustomFields() {
        return this.customFields;
    }

    public GetTicketResponseBody setScene(String scene) {
        this.scene = scene;
        return this;
    }
    public String getScene() {
        return this.scene;
    }

    public GetTicketResponseBody setSceneContext(String sceneContext) {
        this.sceneContext = sceneContext;
        return this;
    }
    public String getSceneContext() {
        return this.sceneContext;
    }

    public GetTicketResponseBody setTemplate(GetTicketResponseBodyTemplate template) {
        this.template = template;
        return this;
    }
    public GetTicketResponseBodyTemplate getTemplate() {
        return this.template;
    }

    public static class GetTicketResponseBodyCreator extends TeaModel {
        @NameInMap("unionId")
        public String unionId;

        @NameInMap("nickName")
        public String nickName;

        public static GetTicketResponseBodyCreator build(java.util.Map<String, ?> map) throws Exception {
            GetTicketResponseBodyCreator self = new GetTicketResponseBodyCreator();
            return TeaModel.build(map, self);
        }

        public GetTicketResponseBodyCreator setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

        public GetTicketResponseBodyCreator setNickName(String nickName) {
            this.nickName = nickName;
            return this;
        }
        public String getNickName() {
            return this.nickName;
        }

    }

    public static class GetTicketResponseBodyProcessor extends TeaModel {
        @NameInMap("unionId")
        public String unionId;

        @NameInMap("nickName")
        public String nickName;

        public static GetTicketResponseBodyProcessor build(java.util.Map<String, ?> map) throws Exception {
            GetTicketResponseBodyProcessor self = new GetTicketResponseBodyProcessor();
            return TeaModel.build(map, self);
        }

        public GetTicketResponseBodyProcessor setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

        public GetTicketResponseBodyProcessor setNickName(String nickName) {
            this.nickName = nickName;
            return this;
        }
        public String getNickName() {
            return this.nickName;
        }

    }

    public static class GetTicketResponseBodyTakers extends TeaModel {
        @NameInMap("unionId")
        public String unionId;

        @NameInMap("nickName")
        public String nickName;

        public static GetTicketResponseBodyTakers build(java.util.Map<String, ?> map) throws Exception {
            GetTicketResponseBodyTakers self = new GetTicketResponseBodyTakers();
            return TeaModel.build(map, self);
        }

        public GetTicketResponseBodyTakers setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

        public GetTicketResponseBodyTakers setNickName(String nickName) {
            this.nickName = nickName;
            return this;
        }
        public String getNickName() {
            return this.nickName;
        }

    }

    public static class GetTicketResponseBodyTemplate extends TeaModel {
        // 工单模版ID
        @NameInMap("openTemplateId")
        public String openTemplateId;

        // 工单模版业务ID
        @NameInMap("openTemplateBizId")
        public String openTemplateBizId;

        // 工单模版名称
        @NameInMap("templateName")
        public String templateName;

        public static GetTicketResponseBodyTemplate build(java.util.Map<String, ?> map) throws Exception {
            GetTicketResponseBodyTemplate self = new GetTicketResponseBodyTemplate();
            return TeaModel.build(map, self);
        }

        public GetTicketResponseBodyTemplate setOpenTemplateId(String openTemplateId) {
            this.openTemplateId = openTemplateId;
            return this;
        }
        public String getOpenTemplateId() {
            return this.openTemplateId;
        }

        public GetTicketResponseBodyTemplate setOpenTemplateBizId(String openTemplateBizId) {
            this.openTemplateBizId = openTemplateBizId;
            return this;
        }
        public String getOpenTemplateBizId() {
            return this.openTemplateBizId;
        }

        public GetTicketResponseBodyTemplate setTemplateName(String templateName) {
            this.templateName = templateName;
            return this;
        }
        public String getTemplateName() {
            return this.templateName;
        }

    }

}
