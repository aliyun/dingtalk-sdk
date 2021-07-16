// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class CreateTicketRequest extends TeaModel {
    @NameInMap("dingIsvOrgId")
    public Long dingIsvOrgId;

    @NameInMap("dingOrgId")
    public Long dingOrgId;

    @NameInMap("dingSuiteKey")
    public String dingSuiteKey;

    @NameInMap("dingTokenGrantType")
    public Long dingTokenGrantType;

    // 开放团队ID
    @NameInMap("openTeamId")
    public String openTeamId;

    // 工单创建人UnionId
    @NameInMap("creatorUnionId")
    public String creatorUnionId;

    // 工单处理人UnionId列表
    @NameInMap("processorUnionIds")
    public java.util.List<String> processorUnionIds;

    // 工单场景 SG 或 VOC
    @NameInMap("scene")
    public String scene;

    // 工单场景信息
    @NameInMap("sceneContext")
    public CreateTicketRequestSceneContext sceneContext;

    // 工单模板业务ID
    @NameInMap("openTemplateBizId")
    public String openTemplateBizId;

    // 工单标题
    @NameInMap("title")
    public String title;

    // 自定义组件字段值(JSON格式)
    @NameInMap("customFields")
    public String customFields;

    // 通知接收人配置
    @NameInMap("notify")
    public CreateTicketRequestNotify notify;

    public static CreateTicketRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateTicketRequest self = new CreateTicketRequest();
        return TeaModel.build(map, self);
    }

    public CreateTicketRequest setDingIsvOrgId(Long dingIsvOrgId) {
        this.dingIsvOrgId = dingIsvOrgId;
        return this;
    }
    public Long getDingIsvOrgId() {
        return this.dingIsvOrgId;
    }

    public CreateTicketRequest setDingOrgId(Long dingOrgId) {
        this.dingOrgId = dingOrgId;
        return this;
    }
    public Long getDingOrgId() {
        return this.dingOrgId;
    }

    public CreateTicketRequest setDingSuiteKey(String dingSuiteKey) {
        this.dingSuiteKey = dingSuiteKey;
        return this;
    }
    public String getDingSuiteKey() {
        return this.dingSuiteKey;
    }

    public CreateTicketRequest setDingTokenGrantType(Long dingTokenGrantType) {
        this.dingTokenGrantType = dingTokenGrantType;
        return this;
    }
    public Long getDingTokenGrantType() {
        return this.dingTokenGrantType;
    }

    public CreateTicketRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

    public CreateTicketRequest setCreatorUnionId(String creatorUnionId) {
        this.creatorUnionId = creatorUnionId;
        return this;
    }
    public String getCreatorUnionId() {
        return this.creatorUnionId;
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

    public CreateTicketRequest setOpenTemplateBizId(String openTemplateBizId) {
        this.openTemplateBizId = openTemplateBizId;
        return this;
    }
    public String getOpenTemplateBizId() {
        return this.openTemplateBizId;
    }

    public CreateTicketRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
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

    public static class CreateTicketRequestSceneContextGroupMsgs extends TeaModel {
        // 勾选消息openMsgId
        @NameInMap("openMsgId")
        public String openMsgId;

        // 是否为锚点消息
        @NameInMap("anchor")
        public Boolean anchor;

        public static CreateTicketRequestSceneContextGroupMsgs build(java.util.Map<String, ?> map) throws Exception {
            CreateTicketRequestSceneContextGroupMsgs self = new CreateTicketRequestSceneContextGroupMsgs();
            return TeaModel.build(map, self);
        }

        public CreateTicketRequestSceneContextGroupMsgs setOpenMsgId(String openMsgId) {
            this.openMsgId = openMsgId;
            return this;
        }
        public String getOpenMsgId() {
            return this.openMsgId;
        }

        public CreateTicketRequestSceneContextGroupMsgs setAnchor(Boolean anchor) {
            this.anchor = anchor;
            return this;
        }
        public Boolean getAnchor() {
            return this.anchor;
        }

    }

    public static class CreateTicketRequestSceneContext extends TeaModel {
        // 服务群openConversationId
        @NameInMap("openConversationId")
        public String openConversationId;

        // 工单相关人UnionId列表
        @NameInMap("relevantorUnionIds")
        public java.util.List<String> relevantorUnionIds;

        // 工单相关的群消息列表
        @NameInMap("groupMsgs")
        public java.util.List<CreateTicketRequestSceneContextGroupMsgs> groupMsgs;

        // VOC类型工单，对应话题ID
        @NameInMap("topicId")
        public String topicId;

        public static CreateTicketRequestSceneContext build(java.util.Map<String, ?> map) throws Exception {
            CreateTicketRequestSceneContext self = new CreateTicketRequestSceneContext();
            return TeaModel.build(map, self);
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

        public CreateTicketRequestSceneContext setGroupMsgs(java.util.List<CreateTicketRequestSceneContextGroupMsgs> groupMsgs) {
            this.groupMsgs = groupMsgs;
            return this;
        }
        public java.util.List<CreateTicketRequestSceneContextGroupMsgs> getGroupMsgs() {
            return this.groupMsgs;
        }

        public CreateTicketRequestSceneContext setTopicId(String topicId) {
            this.topicId = topicId;
            return this;
        }
        public String getTopicId() {
            return this.topicId;
        }

    }

    public static class CreateTicketRequestNotify extends TeaModel {
        // 企业工作通知接收人（钉钉UnionId）
        @NameInMap("workNoticeReceiverUnionIds")
        public java.util.List<String> workNoticeReceiverUnionIds;

        // 服务群通知接收人（钉钉UnionId）
        @NameInMap("groupNoticeReceiverUnionIds")
        public java.util.List<String> groupNoticeReceiverUnionIds;

        // 是否向群内推送一个全员可见工单通知卡片
        @NameInMap("noticeAllGroupMember")
        public Boolean noticeAllGroupMember;

        public static CreateTicketRequestNotify build(java.util.Map<String, ?> map) throws Exception {
            CreateTicketRequestNotify self = new CreateTicketRequestNotify();
            return TeaModel.build(map, self);
        }

        public CreateTicketRequestNotify setWorkNoticeReceiverUnionIds(java.util.List<String> workNoticeReceiverUnionIds) {
            this.workNoticeReceiverUnionIds = workNoticeReceiverUnionIds;
            return this;
        }
        public java.util.List<String> getWorkNoticeReceiverUnionIds() {
            return this.workNoticeReceiverUnionIds;
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

    }

}
