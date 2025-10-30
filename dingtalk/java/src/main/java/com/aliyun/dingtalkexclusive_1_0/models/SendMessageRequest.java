// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class SendMessageRequest extends TeaModel {
    @NameInMap("allow_comment")
    public Boolean allowComment;

    @NameInMap("comment_type")
    public Integer commentType;

    @NameInMap("dep_id_list")
    public java.util.List<Long> depIdList;

    @NameInMap("is_preview")
    public Boolean isPreview;

    @NameInMap("is_to_all")
    public Boolean isToAll;

    /**
     * <strong>example:</strong>
     * <p>P16mHftLYX8iE</p>
     */
    @NameInMap("media_id")
    public String mediaId;

    @NameInMap("msg_body")
    public SendMessageRequestMsgBody msgBody;

    /**
     * <strong>example:</strong>
     * <p>text</p>
     */
    @NameInMap("msg_type")
    public String msgType;

    @NameInMap("roleIds")
    public java.util.List<Long> roleIds;

    @NameInMap("show_homepage")
    public Integer showHomepage;

    /**
     * <strong>example:</strong>
     * <p>hello</p>
     */
    @NameInMap("text_content")
    public String textContent;

    /**
     * <strong>example:</strong>
     * <p>jYdrJoCmTo0iE</p>
     */
    @NameInMap("unionid")
    public String unionid;

    @NameInMap("userid_list")
    public java.util.List<String> useridList;

    /**
     * <strong>example:</strong>
     * <p>48566508-3f35</p>
     */
    @NameInMap("uuid")
    public String uuid;

    public static SendMessageRequest build(java.util.Map<String, ?> map) throws Exception {
        SendMessageRequest self = new SendMessageRequest();
        return TeaModel.build(map, self);
    }

    public SendMessageRequest setAllowComment(Boolean allowComment) {
        this.allowComment = allowComment;
        return this;
    }
    public Boolean getAllowComment() {
        return this.allowComment;
    }

    public SendMessageRequest setCommentType(Integer commentType) {
        this.commentType = commentType;
        return this;
    }
    public Integer getCommentType() {
        return this.commentType;
    }

    public SendMessageRequest setDepIdList(java.util.List<Long> depIdList) {
        this.depIdList = depIdList;
        return this;
    }
    public java.util.List<Long> getDepIdList() {
        return this.depIdList;
    }

    public SendMessageRequest setIsPreview(Boolean isPreview) {
        this.isPreview = isPreview;
        return this;
    }
    public Boolean getIsPreview() {
        return this.isPreview;
    }

    public SendMessageRequest setIsToAll(Boolean isToAll) {
        this.isToAll = isToAll;
        return this;
    }
    public Boolean getIsToAll() {
        return this.isToAll;
    }

    public SendMessageRequest setMediaId(String mediaId) {
        this.mediaId = mediaId;
        return this;
    }
    public String getMediaId() {
        return this.mediaId;
    }

    public SendMessageRequest setMsgBody(SendMessageRequestMsgBody msgBody) {
        this.msgBody = msgBody;
        return this;
    }
    public SendMessageRequestMsgBody getMsgBody() {
        return this.msgBody;
    }

    public SendMessageRequest setMsgType(String msgType) {
        this.msgType = msgType;
        return this;
    }
    public String getMsgType() {
        return this.msgType;
    }

    public SendMessageRequest setRoleIds(java.util.List<Long> roleIds) {
        this.roleIds = roleIds;
        return this;
    }
    public java.util.List<Long> getRoleIds() {
        return this.roleIds;
    }

    public SendMessageRequest setShowHomepage(Integer showHomepage) {
        this.showHomepage = showHomepage;
        return this;
    }
    public Integer getShowHomepage() {
        return this.showHomepage;
    }

    public SendMessageRequest setTextContent(String textContent) {
        this.textContent = textContent;
        return this;
    }
    public String getTextContent() {
        return this.textContent;
    }

    public SendMessageRequest setUnionid(String unionid) {
        this.unionid = unionid;
        return this;
    }
    public String getUnionid() {
        return this.unionid;
    }

    public SendMessageRequest setUseridList(java.util.List<String> useridList) {
        this.useridList = useridList;
        return this;
    }
    public java.util.List<String> getUseridList() {
        return this.useridList;
    }

    public SendMessageRequest setUuid(String uuid) {
        this.uuid = uuid;
        return this;
    }
    public String getUuid() {
        return this.uuid;
    }

    public static class SendMessageRequestMsgBodyActionCardButtonList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>btn_action_url1</p>
         */
        @NameInMap("action_url")
        public String actionUrl;

        /**
         * <strong>example:</strong>
         * <p>btn_title1</p>
         */
        @NameInMap("title")
        public String title;

        public static SendMessageRequestMsgBodyActionCardButtonList build(java.util.Map<String, ?> map) throws Exception {
            SendMessageRequestMsgBodyActionCardButtonList self = new SendMessageRequestMsgBodyActionCardButtonList();
            return TeaModel.build(map, self);
        }

        public SendMessageRequestMsgBodyActionCardButtonList setActionUrl(String actionUrl) {
            this.actionUrl = actionUrl;
            return this;
        }
        public String getActionUrl() {
            return this.actionUrl;
        }

        public SendMessageRequestMsgBodyActionCardButtonList setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class SendMessageRequestMsgBodyActionCard extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>0</p>
         */
        @NameInMap("btn_orientation")
        public String btnOrientation;

        @NameInMap("button_list")
        public java.util.List<SendMessageRequestMsgBodyActionCardButtonList> buttonList;

        /**
         * <strong>example:</strong>
         * <p>markdown text</p>
         */
        @NameInMap("markdown")
        public String markdown;

        /**
         * <strong>example:</strong>
         * <p>single title</p>
         */
        @NameInMap("single_title")
        public String singleTitle;

        /**
         * <strong>example:</strong>
         * <p><a href="https://dingtalk.com">https://dingtalk.com</a></p>
         */
        @NameInMap("single_url")
        public String singleUrl;

        /**
         * <strong>example:</strong>
         * <p>title</p>
         */
        @NameInMap("title")
        public String title;

        public static SendMessageRequestMsgBodyActionCard build(java.util.Map<String, ?> map) throws Exception {
            SendMessageRequestMsgBodyActionCard self = new SendMessageRequestMsgBodyActionCard();
            return TeaModel.build(map, self);
        }

        public SendMessageRequestMsgBodyActionCard setBtnOrientation(String btnOrientation) {
            this.btnOrientation = btnOrientation;
            return this;
        }
        public String getBtnOrientation() {
            return this.btnOrientation;
        }

        public SendMessageRequestMsgBodyActionCard setButtonList(java.util.List<SendMessageRequestMsgBodyActionCardButtonList> buttonList) {
            this.buttonList = buttonList;
            return this;
        }
        public java.util.List<SendMessageRequestMsgBodyActionCardButtonList> getButtonList() {
            return this.buttonList;
        }

        public SendMessageRequestMsgBodyActionCard setMarkdown(String markdown) {
            this.markdown = markdown;
            return this;
        }
        public String getMarkdown() {
            return this.markdown;
        }

        public SendMessageRequestMsgBodyActionCard setSingleTitle(String singleTitle) {
            this.singleTitle = singleTitle;
            return this;
        }
        public String getSingleTitle() {
            return this.singleTitle;
        }

        public SendMessageRequestMsgBodyActionCard setSingleUrl(String singleUrl) {
            this.singleUrl = singleUrl;
            return this;
        }
        public String getSingleUrl() {
            return this.singleUrl;
        }

        public SendMessageRequestMsgBodyActionCard setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class SendMessageRequestMsgBodyLink extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>P16mHftLYX8iE</p>
         */
        @NameInMap("cover_image_media_id")
        public String coverImageMediaId;

        /**
         * <strong>example:</strong>
         * <p><a href="https://dingtalk.com">https://dingtalk.com</a></p>
         */
        @NameInMap("link_url")
        public String linkUrl;

        @NameInMap("open_type")
        public Integer openType;

        /**
         * <strong>example:</strong>
         * <p>描述信息</p>
         */
        @NameInMap("summary")
        public String summary;

        /**
         * <strong>example:</strong>
         * <p>title</p>
         */
        @NameInMap("title")
        public String title;

        public static SendMessageRequestMsgBodyLink build(java.util.Map<String, ?> map) throws Exception {
            SendMessageRequestMsgBodyLink self = new SendMessageRequestMsgBodyLink();
            return TeaModel.build(map, self);
        }

        public SendMessageRequestMsgBodyLink setCoverImageMediaId(String coverImageMediaId) {
            this.coverImageMediaId = coverImageMediaId;
            return this;
        }
        public String getCoverImageMediaId() {
            return this.coverImageMediaId;
        }

        public SendMessageRequestMsgBodyLink setLinkUrl(String linkUrl) {
            this.linkUrl = linkUrl;
            return this;
        }
        public String getLinkUrl() {
            return this.linkUrl;
        }

        public SendMessageRequestMsgBodyLink setOpenType(Integer openType) {
            this.openType = openType;
            return this;
        }
        public Integer getOpenType() {
            return this.openType;
        }

        public SendMessageRequestMsgBodyLink setSummary(String summary) {
            this.summary = summary;
            return this;
        }
        public String getSummary() {
            return this.summary;
        }

        public SendMessageRequestMsgBodyLink setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class SendMessageRequestMsgBodyMarkdown extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>markdown text</p>
         */
        @NameInMap("text")
        public String text;

        /**
         * <strong>example:</strong>
         * <p>title</p>
         */
        @NameInMap("title")
        public String title;

        public static SendMessageRequestMsgBodyMarkdown build(java.util.Map<String, ?> map) throws Exception {
            SendMessageRequestMsgBodyMarkdown self = new SendMessageRequestMsgBodyMarkdown();
            return TeaModel.build(map, self);
        }

        public SendMessageRequestMsgBodyMarkdown setText(String text) {
            this.text = text;
            return this;
        }
        public String getText() {
            return this.text;
        }

        public SendMessageRequestMsgBodyMarkdown setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class SendMessageRequestMsgBody extends TeaModel {
        @NameInMap("action_card")
        public SendMessageRequestMsgBodyActionCard actionCard;

        @NameInMap("link")
        public SendMessageRequestMsgBodyLink link;

        @NameInMap("markdown")
        public SendMessageRequestMsgBodyMarkdown markdown;

        public static SendMessageRequestMsgBody build(java.util.Map<String, ?> map) throws Exception {
            SendMessageRequestMsgBody self = new SendMessageRequestMsgBody();
            return TeaModel.build(map, self);
        }

        public SendMessageRequestMsgBody setActionCard(SendMessageRequestMsgBodyActionCard actionCard) {
            this.actionCard = actionCard;
            return this;
        }
        public SendMessageRequestMsgBodyActionCard getActionCard() {
            return this.actionCard;
        }

        public SendMessageRequestMsgBody setLink(SendMessageRequestMsgBodyLink link) {
            this.link = link;
            return this;
        }
        public SendMessageRequestMsgBodyLink getLink() {
            return this.link;
        }

        public SendMessageRequestMsgBody setMarkdown(SendMessageRequestMsgBodyMarkdown markdown) {
            this.markdown = markdown;
            return this;
        }
        public SendMessageRequestMsgBodyMarkdown getMarkdown() {
            return this.markdown;
        }

    }

}
