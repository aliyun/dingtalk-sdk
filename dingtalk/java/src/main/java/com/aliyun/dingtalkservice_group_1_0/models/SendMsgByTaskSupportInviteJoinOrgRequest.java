// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class SendMsgByTaskSupportInviteJoinOrgRequest extends TeaModel {
    @NameInMap("messageContent")
    public SendMsgByTaskSupportInviteJoinOrgRequestMessageContent messageContent;

    @NameInMap("mobilePhones")
    public java.util.List<String> mobilePhones;

    @NameInMap("needUrlTrack")
    public Boolean needUrlTrack;

    @NameInMap("openTeamId")
    public String openTeamId;

    @NameInMap("sendChannel")
    public String sendChannel;

    @NameInMap("taskName")
    public String taskName;

    public static SendMsgByTaskSupportInviteJoinOrgRequest build(java.util.Map<String, ?> map) throws Exception {
        SendMsgByTaskSupportInviteJoinOrgRequest self = new SendMsgByTaskSupportInviteJoinOrgRequest();
        return TeaModel.build(map, self);
    }

    public SendMsgByTaskSupportInviteJoinOrgRequest setMessageContent(SendMsgByTaskSupportInviteJoinOrgRequestMessageContent messageContent) {
        this.messageContent = messageContent;
        return this;
    }
    public SendMsgByTaskSupportInviteJoinOrgRequestMessageContent getMessageContent() {
        return this.messageContent;
    }

    public SendMsgByTaskSupportInviteJoinOrgRequest setMobilePhones(java.util.List<String> mobilePhones) {
        this.mobilePhones = mobilePhones;
        return this;
    }
    public java.util.List<String> getMobilePhones() {
        return this.mobilePhones;
    }

    public SendMsgByTaskSupportInviteJoinOrgRequest setNeedUrlTrack(Boolean needUrlTrack) {
        this.needUrlTrack = needUrlTrack;
        return this;
    }
    public Boolean getNeedUrlTrack() {
        return this.needUrlTrack;
    }

    public SendMsgByTaskSupportInviteJoinOrgRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

    public SendMsgByTaskSupportInviteJoinOrgRequest setSendChannel(String sendChannel) {
        this.sendChannel = sendChannel;
        return this;
    }
    public String getSendChannel() {
        return this.sendChannel;
    }

    public SendMsgByTaskSupportInviteJoinOrgRequest setTaskName(String taskName) {
        this.taskName = taskName;
        return this;
    }
    public String getTaskName() {
        return this.taskName;
    }

    public static class SendMsgByTaskSupportInviteJoinOrgRequestMessageContentBtns extends TeaModel {
        @NameInMap("actionURL")
        public String actionURL;

        @NameInMap("title")
        public String title;

        public static SendMsgByTaskSupportInviteJoinOrgRequestMessageContentBtns build(java.util.Map<String, ?> map) throws Exception {
            SendMsgByTaskSupportInviteJoinOrgRequestMessageContentBtns self = new SendMsgByTaskSupportInviteJoinOrgRequestMessageContentBtns();
            return TeaModel.build(map, self);
        }

        public SendMsgByTaskSupportInviteJoinOrgRequestMessageContentBtns setActionURL(String actionURL) {
            this.actionURL = actionURL;
            return this;
        }
        public String getActionURL() {
            return this.actionURL;
        }

        public SendMsgByTaskSupportInviteJoinOrgRequestMessageContentBtns setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class SendMsgByTaskSupportInviteJoinOrgRequestMessageContent extends TeaModel {
        @NameInMap("btns")
        public java.util.List<SendMsgByTaskSupportInviteJoinOrgRequestMessageContentBtns> btns;

        @NameInMap("content")
        public String content;

        @NameInMap("messageType")
        public String messageType;

        @NameInMap("title")
        public String title;

        public static SendMsgByTaskSupportInviteJoinOrgRequestMessageContent build(java.util.Map<String, ?> map) throws Exception {
            SendMsgByTaskSupportInviteJoinOrgRequestMessageContent self = new SendMsgByTaskSupportInviteJoinOrgRequestMessageContent();
            return TeaModel.build(map, self);
        }

        public SendMsgByTaskSupportInviteJoinOrgRequestMessageContent setBtns(java.util.List<SendMsgByTaskSupportInviteJoinOrgRequestMessageContentBtns> btns) {
            this.btns = btns;
            return this;
        }
        public java.util.List<SendMsgByTaskSupportInviteJoinOrgRequestMessageContentBtns> getBtns() {
            return this.btns;
        }

        public SendMsgByTaskSupportInviteJoinOrgRequestMessageContent setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public SendMsgByTaskSupportInviteJoinOrgRequestMessageContent setMessageType(String messageType) {
            this.messageType = messageType;
            return this;
        }
        public String getMessageType() {
            return this.messageType;
        }

        public SendMsgByTaskSupportInviteJoinOrgRequestMessageContent setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

}
