// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetMsgRecordDetailResponseBody extends TeaModel {
    @NameInMap("errmsg")
    public String errmsg;

    @NameInMap("errorcode")
    public String errorcode;

    @NameInMap("result")
    public GetMsgRecordDetailResponseBodyResult result;

    public static GetMsgRecordDetailResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetMsgRecordDetailResponseBody self = new GetMsgRecordDetailResponseBody();
        return TeaModel.build(map, self);
    }

    public GetMsgRecordDetailResponseBody setErrmsg(String errmsg) {
        this.errmsg = errmsg;
        return this;
    }
    public String getErrmsg() {
        return this.errmsg;
    }

    public GetMsgRecordDetailResponseBody setErrorcode(String errorcode) {
        this.errorcode = errorcode;
        return this;
    }
    public String getErrorcode() {
        return this.errorcode;
    }

    public GetMsgRecordDetailResponseBody setResult(GetMsgRecordDetailResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetMsgRecordDetailResponseBodyResult getResult() {
        return this.result;
    }

    public static class GetMsgRecordDetailResponseBodyResultActionCardButtonList extends TeaModel {
        @NameInMap("action_url")
        public String actionUrl;

        @NameInMap("title")
        public String title;

        public static GetMsgRecordDetailResponseBodyResultActionCardButtonList build(java.util.Map<String, ?> map) throws Exception {
            GetMsgRecordDetailResponseBodyResultActionCardButtonList self = new GetMsgRecordDetailResponseBodyResultActionCardButtonList();
            return TeaModel.build(map, self);
        }

        public GetMsgRecordDetailResponseBodyResultActionCardButtonList setActionUrl(String actionUrl) {
            this.actionUrl = actionUrl;
            return this;
        }
        public String getActionUrl() {
            return this.actionUrl;
        }

        public GetMsgRecordDetailResponseBodyResultActionCardButtonList setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class GetMsgRecordDetailResponseBodyResultActionCard extends TeaModel {
        @NameInMap("bnt_orientation")
        public String bntOrientation;

        @NameInMap("button_list")
        public java.util.List<GetMsgRecordDetailResponseBodyResultActionCardButtonList> buttonList;

        @NameInMap("markdown")
        public String markdown;

        @NameInMap("single_title")
        public String singleTitle;

        @NameInMap("single_url")
        public String singleUrl;

        @NameInMap("title")
        public String title;

        public static GetMsgRecordDetailResponseBodyResultActionCard build(java.util.Map<String, ?> map) throws Exception {
            GetMsgRecordDetailResponseBodyResultActionCard self = new GetMsgRecordDetailResponseBodyResultActionCard();
            return TeaModel.build(map, self);
        }

        public GetMsgRecordDetailResponseBodyResultActionCard setBntOrientation(String bntOrientation) {
            this.bntOrientation = bntOrientation;
            return this;
        }
        public String getBntOrientation() {
            return this.bntOrientation;
        }

        public GetMsgRecordDetailResponseBodyResultActionCard setButtonList(java.util.List<GetMsgRecordDetailResponseBodyResultActionCardButtonList> buttonList) {
            this.buttonList = buttonList;
            return this;
        }
        public java.util.List<GetMsgRecordDetailResponseBodyResultActionCardButtonList> getButtonList() {
            return this.buttonList;
        }

        public GetMsgRecordDetailResponseBodyResultActionCard setMarkdown(String markdown) {
            this.markdown = markdown;
            return this;
        }
        public String getMarkdown() {
            return this.markdown;
        }

        public GetMsgRecordDetailResponseBodyResultActionCard setSingleTitle(String singleTitle) {
            this.singleTitle = singleTitle;
            return this;
        }
        public String getSingleTitle() {
            return this.singleTitle;
        }

        public GetMsgRecordDetailResponseBodyResultActionCard setSingleUrl(String singleUrl) {
            this.singleUrl = singleUrl;
            return this;
        }
        public String getSingleUrl() {
            return this.singleUrl;
        }

        public GetMsgRecordDetailResponseBodyResultActionCard setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class GetMsgRecordDetailResponseBodyResultArticles extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>129003</p>
         */
        @NameInMap("article_id")
        public Long articleId;

        @NameInMap("content")
        public String content;

        @NameInMap("create_time")
        public Long createTime;

        @NameInMap("digest")
        public String digest;

        @NameInMap("publish_status")
        public Long publishStatus;

        @NameInMap("publish_time")
        public Long publishTime;

        @NameInMap("thumb_media_id")
        public String thumbMediaId;

        @NameInMap("title")
        public String title;

        @NameInMap("update_time")
        public Long updateTime;

        @NameInMap("url")
        public String url;

        public static GetMsgRecordDetailResponseBodyResultArticles build(java.util.Map<String, ?> map) throws Exception {
            GetMsgRecordDetailResponseBodyResultArticles self = new GetMsgRecordDetailResponseBodyResultArticles();
            return TeaModel.build(map, self);
        }

        public GetMsgRecordDetailResponseBodyResultArticles setArticleId(Long articleId) {
            this.articleId = articleId;
            return this;
        }
        public Long getArticleId() {
            return this.articleId;
        }

        public GetMsgRecordDetailResponseBodyResultArticles setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public GetMsgRecordDetailResponseBodyResultArticles setCreateTime(Long createTime) {
            this.createTime = createTime;
            return this;
        }
        public Long getCreateTime() {
            return this.createTime;
        }

        public GetMsgRecordDetailResponseBodyResultArticles setDigest(String digest) {
            this.digest = digest;
            return this;
        }
        public String getDigest() {
            return this.digest;
        }

        public GetMsgRecordDetailResponseBodyResultArticles setPublishStatus(Long publishStatus) {
            this.publishStatus = publishStatus;
            return this;
        }
        public Long getPublishStatus() {
            return this.publishStatus;
        }

        public GetMsgRecordDetailResponseBodyResultArticles setPublishTime(Long publishTime) {
            this.publishTime = publishTime;
            return this;
        }
        public Long getPublishTime() {
            return this.publishTime;
        }

        public GetMsgRecordDetailResponseBodyResultArticles setThumbMediaId(String thumbMediaId) {
            this.thumbMediaId = thumbMediaId;
            return this;
        }
        public String getThumbMediaId() {
            return this.thumbMediaId;
        }

        public GetMsgRecordDetailResponseBodyResultArticles setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public GetMsgRecordDetailResponseBodyResultArticles setUpdateTime(Long updateTime) {
            this.updateTime = updateTime;
            return this;
        }
        public Long getUpdateTime() {
            return this.updateTime;
        }

        public GetMsgRecordDetailResponseBodyResultArticles setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

    public static class GetMsgRecordDetailResponseBodyResultLink extends TeaModel {
        @NameInMap("cover_image_media_id")
        public String coverImageMediaId;

        @NameInMap("link_url")
        public String linkUrl;

        @NameInMap("open_type")
        public Integer openType;

        @NameInMap("summary")
        public String summary;

        @NameInMap("title")
        public String title;

        public static GetMsgRecordDetailResponseBodyResultLink build(java.util.Map<String, ?> map) throws Exception {
            GetMsgRecordDetailResponseBodyResultLink self = new GetMsgRecordDetailResponseBodyResultLink();
            return TeaModel.build(map, self);
        }

        public GetMsgRecordDetailResponseBodyResultLink setCoverImageMediaId(String coverImageMediaId) {
            this.coverImageMediaId = coverImageMediaId;
            return this;
        }
        public String getCoverImageMediaId() {
            return this.coverImageMediaId;
        }

        public GetMsgRecordDetailResponseBodyResultLink setLinkUrl(String linkUrl) {
            this.linkUrl = linkUrl;
            return this;
        }
        public String getLinkUrl() {
            return this.linkUrl;
        }

        public GetMsgRecordDetailResponseBodyResultLink setOpenType(Integer openType) {
            this.openType = openType;
            return this;
        }
        public Integer getOpenType() {
            return this.openType;
        }

        public GetMsgRecordDetailResponseBodyResultLink setSummary(String summary) {
            this.summary = summary;
            return this;
        }
        public String getSummary() {
            return this.summary;
        }

        public GetMsgRecordDetailResponseBodyResultLink setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class GetMsgRecordDetailResponseBodyResultMarkdown extends TeaModel {
        @NameInMap("text")
        public String text;

        @NameInMap("title")
        public String title;

        public static GetMsgRecordDetailResponseBodyResultMarkdown build(java.util.Map<String, ?> map) throws Exception {
            GetMsgRecordDetailResponseBodyResultMarkdown self = new GetMsgRecordDetailResponseBodyResultMarkdown();
            return TeaModel.build(map, self);
        }

        public GetMsgRecordDetailResponseBodyResultMarkdown setText(String text) {
            this.text = text;
            return this;
        }
        public String getText() {
            return this.text;
        }

        public GetMsgRecordDetailResponseBodyResultMarkdown setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class GetMsgRecordDetailResponseBodyResult extends TeaModel {
        @NameInMap("action_card")
        public GetMsgRecordDetailResponseBodyResultActionCard actionCard;

        @NameInMap("allow_comment")
        public Boolean allowComment;

        @NameInMap("allow_forward")
        public Boolean allowForward;

        @NameInMap("articles")
        public java.util.List<GetMsgRecordDetailResponseBodyResultArticles> articles;

        /**
         * <strong>example:</strong>
         * <p>1766028831000</p>
         */
        @NameInMap("create_time")
        public Long createTime;

        @NameInMap("dep_id_list")
        public java.util.List<String> depIdList;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("is_to_all")
        public Boolean isToAll;

        @NameInMap("link")
        public GetMsgRecordDetailResponseBodyResultLink link;

        @NameInMap("markdown")
        public GetMsgRecordDetailResponseBodyResultMarkdown markdown;

        /**
         * <strong>example:</strong>
         * <p>@sdafgffxxrgdssa1123</p>
         */
        @NameInMap("mediaId")
        public String mediaId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>text</p>
         */
        @NameInMap("msg_type")
        public String msgType;

        /**
         * <strong>example:</strong>
         * <p>2569131246</p>
         */
        @NameInMap("operator_user_id")
        public String operatorUserId;

        @NameInMap("roleIdList")
        public java.util.List<String> roleIdList;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1766028831000</p>
         */
        @NameInMap("send_time")
        public Long sendTime;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>pushkxQ2b2DTDAb0qkTjNdKLmwiEiE</p>
         */
        @NameInMap("task_id")
        public String taskId;

        /**
         * <strong>example:</strong>
         * <p>文本消息</p>
         */
        @NameInMap("textContent")
        public String textContent;

        /**
         * <strong>example:</strong>
         * <p>文本消息</p>
         */
        @NameInMap("title")
        public String title;

        @NameInMap("userid_list")
        public java.util.List<String> useridList;

        @NameInMap("view_scope_type")
        public String viewScopeType;

        public static GetMsgRecordDetailResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetMsgRecordDetailResponseBodyResult self = new GetMsgRecordDetailResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetMsgRecordDetailResponseBodyResult setActionCard(GetMsgRecordDetailResponseBodyResultActionCard actionCard) {
            this.actionCard = actionCard;
            return this;
        }
        public GetMsgRecordDetailResponseBodyResultActionCard getActionCard() {
            return this.actionCard;
        }

        public GetMsgRecordDetailResponseBodyResult setAllowComment(Boolean allowComment) {
            this.allowComment = allowComment;
            return this;
        }
        public Boolean getAllowComment() {
            return this.allowComment;
        }

        public GetMsgRecordDetailResponseBodyResult setAllowForward(Boolean allowForward) {
            this.allowForward = allowForward;
            return this;
        }
        public Boolean getAllowForward() {
            return this.allowForward;
        }

        public GetMsgRecordDetailResponseBodyResult setArticles(java.util.List<GetMsgRecordDetailResponseBodyResultArticles> articles) {
            this.articles = articles;
            return this;
        }
        public java.util.List<GetMsgRecordDetailResponseBodyResultArticles> getArticles() {
            return this.articles;
        }

        public GetMsgRecordDetailResponseBodyResult setCreateTime(Long createTime) {
            this.createTime = createTime;
            return this;
        }
        public Long getCreateTime() {
            return this.createTime;
        }

        public GetMsgRecordDetailResponseBodyResult setDepIdList(java.util.List<String> depIdList) {
            this.depIdList = depIdList;
            return this;
        }
        public java.util.List<String> getDepIdList() {
            return this.depIdList;
        }

        public GetMsgRecordDetailResponseBodyResult setIsToAll(Boolean isToAll) {
            this.isToAll = isToAll;
            return this;
        }
        public Boolean getIsToAll() {
            return this.isToAll;
        }

        public GetMsgRecordDetailResponseBodyResult setLink(GetMsgRecordDetailResponseBodyResultLink link) {
            this.link = link;
            return this;
        }
        public GetMsgRecordDetailResponseBodyResultLink getLink() {
            return this.link;
        }

        public GetMsgRecordDetailResponseBodyResult setMarkdown(GetMsgRecordDetailResponseBodyResultMarkdown markdown) {
            this.markdown = markdown;
            return this;
        }
        public GetMsgRecordDetailResponseBodyResultMarkdown getMarkdown() {
            return this.markdown;
        }

        public GetMsgRecordDetailResponseBodyResult setMediaId(String mediaId) {
            this.mediaId = mediaId;
            return this;
        }
        public String getMediaId() {
            return this.mediaId;
        }

        public GetMsgRecordDetailResponseBodyResult setMsgType(String msgType) {
            this.msgType = msgType;
            return this;
        }
        public String getMsgType() {
            return this.msgType;
        }

        public GetMsgRecordDetailResponseBodyResult setOperatorUserId(String operatorUserId) {
            this.operatorUserId = operatorUserId;
            return this;
        }
        public String getOperatorUserId() {
            return this.operatorUserId;
        }

        public GetMsgRecordDetailResponseBodyResult setRoleIdList(java.util.List<String> roleIdList) {
            this.roleIdList = roleIdList;
            return this;
        }
        public java.util.List<String> getRoleIdList() {
            return this.roleIdList;
        }

        public GetMsgRecordDetailResponseBodyResult setSendTime(Long sendTime) {
            this.sendTime = sendTime;
            return this;
        }
        public Long getSendTime() {
            return this.sendTime;
        }

        public GetMsgRecordDetailResponseBodyResult setTaskId(String taskId) {
            this.taskId = taskId;
            return this;
        }
        public String getTaskId() {
            return this.taskId;
        }

        public GetMsgRecordDetailResponseBodyResult setTextContent(String textContent) {
            this.textContent = textContent;
            return this;
        }
        public String getTextContent() {
            return this.textContent;
        }

        public GetMsgRecordDetailResponseBodyResult setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public GetMsgRecordDetailResponseBodyResult setUseridList(java.util.List<String> useridList) {
            this.useridList = useridList;
            return this;
        }
        public java.util.List<String> getUseridList() {
            return this.useridList;
        }

        public GetMsgRecordDetailResponseBodyResult setViewScopeType(String viewScopeType) {
            this.viewScopeType = viewScopeType;
            return this;
        }
        public String getViewScopeType() {
            return this.viewScopeType;
        }

    }

}
