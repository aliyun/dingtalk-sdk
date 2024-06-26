// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class CreateTicketRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>Dq9hP8Sk2v6vQ6l05nCe5wiEiE</p>
     */
    @NameInMap("creatorUnionId")
    public String creatorUnionId;

    /**
     * <strong>example:</strong>
     * <p>[{&quot;identifier&quot;:&quot;input1&quot;,&quot;value&quot;:&quot;123&quot;}]</p>
     */
    @NameInMap("customFields")
    public String customFields;

    @NameInMap("notify")
    public CreateTicketRequestNotify notify;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>eKWh3GBwsKEiE</p>
     */
    @NameInMap("openTeamId")
    public String openTeamId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>bLkvfXKiSngQiE</p>
     */
    @NameInMap("openTemplateBizId")
    public String openTemplateBizId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("processorUnionIds")
    public java.util.List<String> processorUnionIds;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>SG</p>
     */
    @NameInMap("scene")
    public String scene;

    @NameInMap("sceneContext")
    public CreateTicketRequestSceneContext sceneContext;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
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
        @NameInMap("groupNoticeReceiverUnionIds")
        public java.util.List<String> groupNoticeReceiverUnionIds;

        /**
         * <strong>example:</strong>
         * <p>true</p>
         */
        @NameInMap("noticeAllGroupMember")
        public Boolean noticeAllGroupMember;

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
         * <strong>example:</strong>
         * <p>true</p>
         */
        @NameInMap("anchor")
        public Boolean anchor;

        /**
         * <strong>example:</strong>
         * <p>msgsbY4BzTCNX0/ClUwoTTs7w==</p>
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
        @NameInMap("groupMsgs")
        public java.util.List<CreateTicketRequestSceneContextGroupMsgs> groupMsgs;

        /**
         * <strong>example:</strong>
         * <p>cidZBSNlUi/Jq9x76PAXUCrAA==</p>
         */
        @NameInMap("openConversationId")
        public String openConversationId;

        @NameInMap("relevantorUnionIds")
        public java.util.List<String> relevantorUnionIds;

        /**
         * <strong>example:</strong>
         * <p>a0ba57d5d29a48b51d0eca48da6b1d09</p>
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
