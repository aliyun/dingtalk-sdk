// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class CreateTicketRequest extends TeaModel {
    /**
     * <p>工单创建人UnionId</p>
     */
    @NameInMap("creatorUnionId")
    public String creatorUnionId;

    /**
     * <p>自定义组件字段值(JSON格式)</p>
     */
    @NameInMap("customFields")
    public String customFields;

    /**
     * <p>通知接收人配置</p>
     */
    @NameInMap("notify")
    public CreateTicketRequestNotify notify;

    /**
     * <p>开放团队ID</p>
     */
    @NameInMap("openTeamId")
    public String openTeamId;

    /**
     * <p>工单模板业务ID</p>
     */
    @NameInMap("openTemplateBizId")
    public String openTemplateBizId;

    /**
     * <p>工单处理人UnionId列表</p>
     */
    @NameInMap("processorUnionIds")
    public java.util.List<String> processorUnionIds;

    /**
     * <p>工单场景 SG 或 VOC</p>
     */
    @NameInMap("scene")
    public String scene;

    /**
     * <p>工单场景信息</p>
     */
    @NameInMap("sceneContext")
    public CreateTicketRequestSceneContext sceneContext;

    /**
     * <p>工单标题</p>
     */
    @NameInMap("title")
    public String title;

    public static CreateTicketRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateTicketRequest self = new CreateTicketRequest();
        return TeaModel.build(map, self);
    }

    public CreateTicketRequest setCreatorUnionId(String creatorUnionId) {
        this.creatorUnionId = creatorUnionId;
        return this;
    }
    public String getCreatorUnionId() {
        return this.creatorUnionId;
    }

    public CreateTicketRequest setCustomFields(String customFields) {
        this.customFields = customFields;
        return this;
    }
    public String getCustomFields() {
        return this.customFields;
    }

    public CreateTicketRequest setNotify(CreateTicketRequestNotify notify) {
        this.notify = notify;
        return this;
    }
    public CreateTicketRequestNotify getNotify() {
        return this.notify;
    }

    public CreateTicketRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

    public CreateTicketRequest setOpenTemplateBizId(String openTemplateBizId) {
        this.openTemplateBizId = openTemplateBizId;
        return this;
    }
    public String getOpenTemplateBizId() {
        return this.openTemplateBizId;
    }

    public CreateTicketRequest setProcessorUnionIds(java.util.List<String> processorUnionIds) {
        this.processorUnionIds = processorUnionIds;
        return this;
    }
    public java.util.List<String> getProcessorUnionIds() {
        return this.processorUnionIds;
    }

    public CreateTicketRequest setScene(String scene) {
        this.scene = scene;
        return this;
    }
    public String getScene() {
        return this.scene;
    }

    public CreateTicketRequest setSceneContext(CreateTicketRequestSceneContext sceneContext) {
        this.sceneContext = sceneContext;
        return this;
    }
    public CreateTicketRequestSceneContext getSceneContext() {
        return this.sceneContext;
    }

    public CreateTicketRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public static class CreateTicketRequestNotify extends TeaModel {
        /**
         * <p>服务群通知接收人（钉钉UnionId）</p>
         */
        @NameInMap("groupNoticeReceiverUnionIds")
        public java.util.List<String> groupNoticeReceiverUnionIds;

        /**
         * <p>是否向群内推送一个全员可见工单通知卡片</p>
         */
        @NameInMap("noticeAllGroupMember")
        public Boolean noticeAllGroupMember;

        /**
         * <p>企业工作通知接收人（钉钉UnionId）</p>
         */
        @NameInMap("workNoticeReceiverUnionIds")
        public java.util.List<String> workNoticeReceiverUnionIds;

        public static CreateTicketRequestNotify build(java.util.Map<String, ?> map) throws Exception {
            CreateTicketRequestNotify self = new CreateTicketRequestNotify();
            return TeaModel.build(map, self);
        }

        public CreateTicketRequestNotify setGroupNoticeReceiverUnionIds(java.util.List<String> groupNoticeReceiverUnionIds) {
            this.groupNoticeReceiverUnionIds = groupNoticeReceiverUnionIds;
            return this;
        }
        public java.util.List<String> getGroupNoticeReceiverUnionIds() {
            return this.groupNoticeReceiverUnionIds;
        }

        public CreateTicketRequestNotify setNoticeAllGroupMember(Boolean noticeAllGroupMember) {
            this.noticeAllGroupMember = noticeAllGroupMember;
            return this;
        }
        public Boolean getNoticeAllGroupMember() {
            return this.noticeAllGroupMember;
        }

        public CreateTicketRequestNotify setWorkNoticeReceiverUnionIds(java.util.List<String> workNoticeReceiverUnionIds) {
            this.workNoticeReceiverUnionIds = workNoticeReceiverUnionIds;
            return this;
        }
        public java.util.List<String> getWorkNoticeReceiverUnionIds() {
            return this.workNoticeReceiverUnionIds;
        }

    }

    public static class CreateTicketRequestSceneContextGroupMsgs extends TeaModel {
        /**
         * <p>是否为锚点消息</p>
         */
        @NameInMap("anchor")
        public Boolean anchor;

        /**
         * <p>勾选消息openMsgId</p>
         */
        @NameInMap("openMsgId")
        public String openMsgId;

        public static CreateTicketRequestSceneContextGroupMsgs build(java.util.Map<String, ?> map) throws Exception {
            CreateTicketRequestSceneContextGroupMsgs self = new CreateTicketRequestSceneContextGroupMsgs();
            return TeaModel.build(map, self);
        }

        public CreateTicketRequestSceneContextGroupMsgs setAnchor(Boolean anchor) {
            this.anchor = anchor;
            return this;
        }
        public Boolean getAnchor() {
            return this.anchor;
        }

        public CreateTicketRequestSceneContextGroupMsgs setOpenMsgId(String openMsgId) {
            this.openMsgId = openMsgId;
            return this;
        }
        public String getOpenMsgId() {
            return this.openMsgId;
        }

    }

    public static class CreateTicketRequestSceneContext extends TeaModel {
        /**
         * <p>工单相关的群消息列表</p>
         */
        @NameInMap("groupMsgs")
        public java.util.List<CreateTicketRequestSceneContextGroupMsgs> groupMsgs;

        /**
         * <p>服务群openConversationId</p>
         */
        @NameInMap("openConversationId")
        public String openConversationId;

        /**
         * <p>工单相关人UnionId列表</p>
         */
        @NameInMap("relevantorUnionIds")
        public java.util.List<String> relevantorUnionIds;

        /**
         * <p>VOC类型工单，对应话题ID</p>
         */
        @NameInMap("topicId")
        public String topicId;

        public static CreateTicketRequestSceneContext build(java.util.Map<String, ?> map) throws Exception {
            CreateTicketRequestSceneContext self = new CreateTicketRequestSceneContext();
            return TeaModel.build(map, self);
        }

        public CreateTicketRequestSceneContext setGroupMsgs(java.util.List<CreateTicketRequestSceneContextGroupMsgs> groupMsgs) {
            this.groupMsgs = groupMsgs;
            return this;
        }
        public java.util.List<CreateTicketRequestSceneContextGroupMsgs> getGroupMsgs() {
            return this.groupMsgs;
        }

        public CreateTicketRequestSceneContext setOpenConversationId(String openConversationId) {
            this.openConversationId = openConversationId;
            return this;
        }
        public String getOpenConversationId() {
            return this.openConversationId;
        }

        public CreateTicketRequestSceneContext setRelevantorUnionIds(java.util.List<String> relevantorUnionIds) {
            this.relevantorUnionIds = relevantorUnionIds;
            return this;
        }
        public java.util.List<String> getRelevantorUnionIds() {
            return this.relevantorUnionIds;
        }

        public CreateTicketRequestSceneContext setTopicId(String topicId) {
            this.topicId = topicId;
            return this;
        }
        public String getTopicId() {
            return this.topicId;
        }

    }

}
