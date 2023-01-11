// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class ResubmitTicketRequest extends TeaModel {
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

    @NameInMap("notify")
    public ResubmitTicketRequestNotify notify;

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
     * <p>工单开放ID</p>
     */
    @NameInMap("openTicketId")
    public String openTicketId;

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
    public ResubmitTicketRequestSceneContext sceneContext;

    /**
     * <p>备注</p>
     */
    @NameInMap("ticketMemo")
    public ResubmitTicketRequestTicketMemo ticketMemo;

    /**
     * <p>工单标题</p>
     */
    @NameInMap("title")
    public String title;

    public static ResubmitTicketRequest build(java.util.Map<String, ?> map) throws Exception {
        ResubmitTicketRequest self = new ResubmitTicketRequest();
        return TeaModel.build(map, self);
    }

    public ResubmitTicketRequest setCreatorUnionId(String creatorUnionId) {
        this.creatorUnionId = creatorUnionId;
        return this;
    }
    public String getCreatorUnionId() {
        return this.creatorUnionId;
    }

    public ResubmitTicketRequest setCustomFields(String customFields) {
        this.customFields = customFields;
        return this;
    }
    public String getCustomFields() {
        return this.customFields;
    }

    public ResubmitTicketRequest setNotify(ResubmitTicketRequestNotify notify) {
        this.notify = notify;
        return this;
    }
    public ResubmitTicketRequestNotify getNotify() {
        return this.notify;
    }

    public ResubmitTicketRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

    public ResubmitTicketRequest setOpenTemplateBizId(String openTemplateBizId) {
        this.openTemplateBizId = openTemplateBizId;
        return this;
    }
    public String getOpenTemplateBizId() {
        return this.openTemplateBizId;
    }

    public ResubmitTicketRequest setOpenTicketId(String openTicketId) {
        this.openTicketId = openTicketId;
        return this;
    }
    public String getOpenTicketId() {
        return this.openTicketId;
    }

    public ResubmitTicketRequest setProcessorUnionIds(java.util.List<String> processorUnionIds) {
        this.processorUnionIds = processorUnionIds;
        return this;
    }
    public java.util.List<String> getProcessorUnionIds() {
        return this.processorUnionIds;
    }

    public ResubmitTicketRequest setScene(String scene) {
        this.scene = scene;
        return this;
    }
    public String getScene() {
        return this.scene;
    }

    public ResubmitTicketRequest setSceneContext(ResubmitTicketRequestSceneContext sceneContext) {
        this.sceneContext = sceneContext;
        return this;
    }
    public ResubmitTicketRequestSceneContext getSceneContext() {
        return this.sceneContext;
    }

    public ResubmitTicketRequest setTicketMemo(ResubmitTicketRequestTicketMemo ticketMemo) {
        this.ticketMemo = ticketMemo;
        return this;
    }
    public ResubmitTicketRequestTicketMemo getTicketMemo() {
        return this.ticketMemo;
    }

    public ResubmitTicketRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public static class ResubmitTicketRequestNotify extends TeaModel {
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

        public static ResubmitTicketRequestNotify build(java.util.Map<String, ?> map) throws Exception {
            ResubmitTicketRequestNotify self = new ResubmitTicketRequestNotify();
            return TeaModel.build(map, self);
        }

        public ResubmitTicketRequestNotify setGroupNoticeReceiverUnionIds(java.util.List<String> groupNoticeReceiverUnionIds) {
            this.groupNoticeReceiverUnionIds = groupNoticeReceiverUnionIds;
            return this;
        }
        public java.util.List<String> getGroupNoticeReceiverUnionIds() {
            return this.groupNoticeReceiverUnionIds;
        }

        public ResubmitTicketRequestNotify setNoticeAllGroupMember(Boolean noticeAllGroupMember) {
            this.noticeAllGroupMember = noticeAllGroupMember;
            return this;
        }
        public Boolean getNoticeAllGroupMember() {
            return this.noticeAllGroupMember;
        }

        public ResubmitTicketRequestNotify setWorkNoticeReceiverUnionIds(java.util.List<String> workNoticeReceiverUnionIds) {
            this.workNoticeReceiverUnionIds = workNoticeReceiverUnionIds;
            return this;
        }
        public java.util.List<String> getWorkNoticeReceiverUnionIds() {
            return this.workNoticeReceiverUnionIds;
        }

    }

    public static class ResubmitTicketRequestSceneContextGroupMsgs extends TeaModel {
        @NameInMap("anchor")
        public Boolean anchor;

        /**
         * <p>勾选消息openMsgId</p>
         */
        @NameInMap("openMsgId")
        public String openMsgId;

        @NameInMap("topicId")
        public String topicId;

        public static ResubmitTicketRequestSceneContextGroupMsgs build(java.util.Map<String, ?> map) throws Exception {
            ResubmitTicketRequestSceneContextGroupMsgs self = new ResubmitTicketRequestSceneContextGroupMsgs();
            return TeaModel.build(map, self);
        }

        public ResubmitTicketRequestSceneContextGroupMsgs setAnchor(Boolean anchor) {
            this.anchor = anchor;
            return this;
        }
        public Boolean getAnchor() {
            return this.anchor;
        }

        public ResubmitTicketRequestSceneContextGroupMsgs setOpenMsgId(String openMsgId) {
            this.openMsgId = openMsgId;
            return this;
        }
        public String getOpenMsgId() {
            return this.openMsgId;
        }

        public ResubmitTicketRequestSceneContextGroupMsgs setTopicId(String topicId) {
            this.topicId = topicId;
            return this;
        }
        public String getTopicId() {
            return this.topicId;
        }

    }

    public static class ResubmitTicketRequestSceneContext extends TeaModel {
        @NameInMap("groupMsgs")
        public java.util.List<ResubmitTicketRequestSceneContextGroupMsgs> groupMsgs;

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

        public static ResubmitTicketRequestSceneContext build(java.util.Map<String, ?> map) throws Exception {
            ResubmitTicketRequestSceneContext self = new ResubmitTicketRequestSceneContext();
            return TeaModel.build(map, self);
        }

        public ResubmitTicketRequestSceneContext setGroupMsgs(java.util.List<ResubmitTicketRequestSceneContextGroupMsgs> groupMsgs) {
            this.groupMsgs = groupMsgs;
            return this;
        }
        public java.util.List<ResubmitTicketRequestSceneContextGroupMsgs> getGroupMsgs() {
            return this.groupMsgs;
        }

        public ResubmitTicketRequestSceneContext setOpenConversationId(String openConversationId) {
            this.openConversationId = openConversationId;
            return this;
        }
        public String getOpenConversationId() {
            return this.openConversationId;
        }

        public ResubmitTicketRequestSceneContext setRelevantorUnionIds(java.util.List<String> relevantorUnionIds) {
            this.relevantorUnionIds = relevantorUnionIds;
            return this;
        }
        public java.util.List<String> getRelevantorUnionIds() {
            return this.relevantorUnionIds;
        }

    }

    public static class ResubmitTicketRequestTicketMemoAttachments extends TeaModel {
        /**
         * <p>文件名</p>
         */
        @NameInMap("fileName")
        public String fileName;

        /**
         * <p>文件key</p>
         */
        @NameInMap("key")
        public String key;

        public static ResubmitTicketRequestTicketMemoAttachments build(java.util.Map<String, ?> map) throws Exception {
            ResubmitTicketRequestTicketMemoAttachments self = new ResubmitTicketRequestTicketMemoAttachments();
            return TeaModel.build(map, self);
        }

        public ResubmitTicketRequestTicketMemoAttachments setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

        public ResubmitTicketRequestTicketMemoAttachments setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

    }

    public static class ResubmitTicketRequestTicketMemo extends TeaModel {
        @NameInMap("attachments")
        public java.util.List<ResubmitTicketRequestTicketMemoAttachments> attachments;

        /**
         * <p>备注文字</p>
         */
        @NameInMap("memo")
        public String memo;

        public static ResubmitTicketRequestTicketMemo build(java.util.Map<String, ?> map) throws Exception {
            ResubmitTicketRequestTicketMemo self = new ResubmitTicketRequestTicketMemo();
            return TeaModel.build(map, self);
        }

        public ResubmitTicketRequestTicketMemo setAttachments(java.util.List<ResubmitTicketRequestTicketMemoAttachments> attachments) {
            this.attachments = attachments;
            return this;
        }
        public java.util.List<ResubmitTicketRequestTicketMemoAttachments> getAttachments() {
            return this.attachments;
        }

        public ResubmitTicketRequestTicketMemo setMemo(String memo) {
            this.memo = memo;
            return this;
        }
        public String getMemo() {
            return this.memo;
        }

    }

}
