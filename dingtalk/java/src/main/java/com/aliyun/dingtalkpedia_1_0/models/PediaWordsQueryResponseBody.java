// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkpedia_1_0.models;

import com.aliyun.tea.*;

public class PediaWordsQueryResponseBody extends TeaModel {
    @NameInMap("data")
    public PediaWordsQueryResponseBodyData data;

    @NameInMap("success")
    public Boolean success;

    public static PediaWordsQueryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PediaWordsQueryResponseBody self = new PediaWordsQueryResponseBody();
        return TeaModel.build(map, self);
    }

    public PediaWordsQueryResponseBody setData(PediaWordsQueryResponseBodyData data) {
        this.data = data;
        return this;
    }
    public PediaWordsQueryResponseBodyData getData() {
        return this.data;
    }

    public PediaWordsQueryResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class PediaWordsQueryResponseBodyDataAppLink extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>相关应用</p>
         */
        @NameInMap("appName")
        public String appName;

        /**
         * <strong>example:</strong>
         * <p>htttps://1234567</p>
         */
        @NameInMap("iconLink")
        public String iconLink;

        /**
         * <strong>example:</strong>
         * <p><a href="http://123344.com">http://123344.com</a></p>
         */
        @NameInMap("pcLink")
        public String pcLink;

        /**
         * <strong>example:</strong>
         * <p><a href="https://12334.com">https://12334.com</a></p>
         */
        @NameInMap("phoneLink")
        public String phoneLink;

        public static PediaWordsQueryResponseBodyDataAppLink build(java.util.Map<String, ?> map) throws Exception {
            PediaWordsQueryResponseBodyDataAppLink self = new PediaWordsQueryResponseBodyDataAppLink();
            return TeaModel.build(map, self);
        }

        public PediaWordsQueryResponseBodyDataAppLink setAppName(String appName) {
            this.appName = appName;
            return this;
        }
        public String getAppName() {
            return this.appName;
        }

        public PediaWordsQueryResponseBodyDataAppLink setIconLink(String iconLink) {
            this.iconLink = iconLink;
            return this;
        }
        public String getIconLink() {
            return this.iconLink;
        }

        public PediaWordsQueryResponseBodyDataAppLink setPcLink(String pcLink) {
            this.pcLink = pcLink;
            return this;
        }
        public String getPcLink() {
            return this.pcLink;
        }

        public PediaWordsQueryResponseBodyDataAppLink setPhoneLink(String phoneLink) {
            this.phoneLink = phoneLink;
            return this;
        }
        public String getPhoneLink() {
            return this.phoneLink;
        }

    }

    public static class PediaWordsQueryResponseBodyDataContactList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>@dasdasd</p>
         */
        @NameInMap("avatarMediaId")
        public String avatarMediaId;

        /**
         * <strong>example:</strong>
         * <p>相关联系人</p>
         */
        @NameInMap("nickName")
        public String nickName;

        /**
         * <strong>example:</strong>
         * <p>12321231</p>
         */
        @NameInMap("userId")
        public String userId;

        public static PediaWordsQueryResponseBodyDataContactList build(java.util.Map<String, ?> map) throws Exception {
            PediaWordsQueryResponseBodyDataContactList self = new PediaWordsQueryResponseBodyDataContactList();
            return TeaModel.build(map, self);
        }

        public PediaWordsQueryResponseBodyDataContactList setAvatarMediaId(String avatarMediaId) {
            this.avatarMediaId = avatarMediaId;
            return this;
        }
        public String getAvatarMediaId() {
            return this.avatarMediaId;
        }

        public PediaWordsQueryResponseBodyDataContactList setNickName(String nickName) {
            this.nickName = nickName;
            return this;
        }
        public String getNickName() {
            return this.nickName;
        }

        public PediaWordsQueryResponseBodyDataContactList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class PediaWordsQueryResponseBodyDataPicList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p><a href="http://123455.com">http://123455.com</a></p>
         */
        @NameInMap("mediaIdUrl")
        public String mediaIdUrl;

        public static PediaWordsQueryResponseBodyDataPicList build(java.util.Map<String, ?> map) throws Exception {
            PediaWordsQueryResponseBodyDataPicList self = new PediaWordsQueryResponseBodyDataPicList();
            return TeaModel.build(map, self);
        }

        public PediaWordsQueryResponseBodyDataPicList setMediaIdUrl(String mediaIdUrl) {
            this.mediaIdUrl = mediaIdUrl;
            return this;
        }
        public String getMediaIdUrl() {
            return this.mediaIdUrl;
        }

    }

    public static class PediaWordsQueryResponseBodyDataRelatedDoc extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p><a href="http://123456.com">http://123456.com</a></p>
         */
        @NameInMap("link")
        public String link;

        /**
         * <strong>example:</strong>
         * <p>相关文档</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>adoc</p>
         */
        @NameInMap("type")
        public String type;

        public static PediaWordsQueryResponseBodyDataRelatedDoc build(java.util.Map<String, ?> map) throws Exception {
            PediaWordsQueryResponseBodyDataRelatedDoc self = new PediaWordsQueryResponseBodyDataRelatedDoc();
            return TeaModel.build(map, self);
        }

        public PediaWordsQueryResponseBodyDataRelatedDoc setLink(String link) {
            this.link = link;
            return this;
        }
        public String getLink() {
            return this.link;
        }

        public PediaWordsQueryResponseBodyDataRelatedDoc setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public PediaWordsQueryResponseBodyDataRelatedDoc setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class PediaWordsQueryResponseBodyDataRelatedLink extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p><a href="http://123343.com">http://123343.com</a></p>
         */
        @NameInMap("link")
        public String link;

        /**
         * <strong>example:</strong>
         * <p>相关链接</p>
         */
        @NameInMap("name")
        public String name;

        public static PediaWordsQueryResponseBodyDataRelatedLink build(java.util.Map<String, ?> map) throws Exception {
            PediaWordsQueryResponseBodyDataRelatedLink self = new PediaWordsQueryResponseBodyDataRelatedLink();
            return TeaModel.build(map, self);
        }

        public PediaWordsQueryResponseBodyDataRelatedLink setLink(String link) {
            this.link = link;
            return this;
        }
        public String getLink() {
            return this.link;
        }

        public PediaWordsQueryResponseBodyDataRelatedLink setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

    public static class PediaWordsQueryResponseBodyData extends TeaModel {
        @NameInMap("appLink")
        public java.util.List<PediaWordsQueryResponseBodyDataAppLink> appLink;

        /**
         * <strong>example:</strong>
         * <p>审核者</p>
         */
        @NameInMap("approveName")
        public String approveName;

        @NameInMap("contactList")
        public java.util.List<PediaWordsQueryResponseBodyDataContactList> contactList;

        @NameInMap("contacts")
        public java.util.List<String> contacts;

        /**
         * <strong>example:</strong>
         * <p>创建者</p>
         */
        @NameInMap("creatorName")
        public String creatorName;

        /**
         * <strong>example:</strong>
         * <p>31312312</p>
         */
        @NameInMap("gmtCreate")
        public Long gmtCreate;

        /**
         * <strong>example:</strong>
         * <p>321312312</p>
         */
        @NameInMap("gmtModify")
        public Long gmtModify;

        @NameInMap("highLightWordAlias")
        public java.util.List<String> highLightWordAlias;

        @NameInMap("imHighLight")
        public Boolean imHighLight;

        /**
         * <strong>example:</strong>
         * <p>12345678</p>
         */
        @NameInMap("parentUuid")
        public Long parentUuid;

        @NameInMap("picList")
        public java.util.List<PediaWordsQueryResponseBodyDataPicList> picList;

        @NameInMap("relatedDoc")
        public java.util.List<PediaWordsQueryResponseBodyDataRelatedDoc> relatedDoc;

        @NameInMap("relatedLink")
        public java.util.List<PediaWordsQueryResponseBodyDataRelatedLink> relatedLink;

        @NameInMap("simHighLight")
        public Boolean simHighLight;

        /**
         * <strong>example:</strong>
         * <p>剔除富文本释义</p>
         */
        @NameInMap("simpleWordParaphrase")
        public String simpleWordParaphrase;

        @NameInMap("tagsList")
        public java.util.List<String> tagsList;

        /**
         * <strong>example:</strong>
         * <p>更新者</p>
         */
        @NameInMap("updaterName")
        public String updaterName;

        /**
         * <strong>example:</strong>
         * <p>213123123</p>
         */
        @NameInMap("userId")
        public String userId;

        /**
         * <strong>example:</strong>
         * <p>123123121</p>
         */
        @NameInMap("uuid")
        public Long uuid;

        @NameInMap("wordAlias")
        public java.util.List<String> wordAlias;

        /**
         * <strong>example:</strong>
         * <p>词条名称</p>
         */
        @NameInMap("wordName")
        public String wordName;

        /**
         * <strong>example:</strong>
         * <p>释义</p>
         */
        @NameInMap("wordParaphrase")
        public String wordParaphrase;

        public static PediaWordsQueryResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            PediaWordsQueryResponseBodyData self = new PediaWordsQueryResponseBodyData();
            return TeaModel.build(map, self);
        }

        public PediaWordsQueryResponseBodyData setAppLink(java.util.List<PediaWordsQueryResponseBodyDataAppLink> appLink) {
            this.appLink = appLink;
            return this;
        }
        public java.util.List<PediaWordsQueryResponseBodyDataAppLink> getAppLink() {
            return this.appLink;
        }

        public PediaWordsQueryResponseBodyData setApproveName(String approveName) {
            this.approveName = approveName;
            return this;
        }
        public String getApproveName() {
            return this.approveName;
        }

        public PediaWordsQueryResponseBodyData setContactList(java.util.List<PediaWordsQueryResponseBodyDataContactList> contactList) {
            this.contactList = contactList;
            return this;
        }
        public java.util.List<PediaWordsQueryResponseBodyDataContactList> getContactList() {
            return this.contactList;
        }

        public PediaWordsQueryResponseBodyData setContacts(java.util.List<String> contacts) {
            this.contacts = contacts;
            return this;
        }
        public java.util.List<String> getContacts() {
            return this.contacts;
        }

        public PediaWordsQueryResponseBodyData setCreatorName(String creatorName) {
            this.creatorName = creatorName;
            return this;
        }
        public String getCreatorName() {
            return this.creatorName;
        }

        public PediaWordsQueryResponseBodyData setGmtCreate(Long gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public Long getGmtCreate() {
            return this.gmtCreate;
        }

        public PediaWordsQueryResponseBodyData setGmtModify(Long gmtModify) {
            this.gmtModify = gmtModify;
            return this;
        }
        public Long getGmtModify() {
            return this.gmtModify;
        }

        public PediaWordsQueryResponseBodyData setHighLightWordAlias(java.util.List<String> highLightWordAlias) {
            this.highLightWordAlias = highLightWordAlias;
            return this;
        }
        public java.util.List<String> getHighLightWordAlias() {
            return this.highLightWordAlias;
        }

        public PediaWordsQueryResponseBodyData setImHighLight(Boolean imHighLight) {
            this.imHighLight = imHighLight;
            return this;
        }
        public Boolean getImHighLight() {
            return this.imHighLight;
        }

        public PediaWordsQueryResponseBodyData setParentUuid(Long parentUuid) {
            this.parentUuid = parentUuid;
            return this;
        }
        public Long getParentUuid() {
            return this.parentUuid;
        }

        public PediaWordsQueryResponseBodyData setPicList(java.util.List<PediaWordsQueryResponseBodyDataPicList> picList) {
            this.picList = picList;
            return this;
        }
        public java.util.List<PediaWordsQueryResponseBodyDataPicList> getPicList() {
            return this.picList;
        }

        public PediaWordsQueryResponseBodyData setRelatedDoc(java.util.List<PediaWordsQueryResponseBodyDataRelatedDoc> relatedDoc) {
            this.relatedDoc = relatedDoc;
            return this;
        }
        public java.util.List<PediaWordsQueryResponseBodyDataRelatedDoc> getRelatedDoc() {
            return this.relatedDoc;
        }

        public PediaWordsQueryResponseBodyData setRelatedLink(java.util.List<PediaWordsQueryResponseBodyDataRelatedLink> relatedLink) {
            this.relatedLink = relatedLink;
            return this;
        }
        public java.util.List<PediaWordsQueryResponseBodyDataRelatedLink> getRelatedLink() {
            return this.relatedLink;
        }

        public PediaWordsQueryResponseBodyData setSimHighLight(Boolean simHighLight) {
            this.simHighLight = simHighLight;
            return this;
        }
        public Boolean getSimHighLight() {
            return this.simHighLight;
        }

        public PediaWordsQueryResponseBodyData setSimpleWordParaphrase(String simpleWordParaphrase) {
            this.simpleWordParaphrase = simpleWordParaphrase;
            return this;
        }
        public String getSimpleWordParaphrase() {
            return this.simpleWordParaphrase;
        }

        public PediaWordsQueryResponseBodyData setTagsList(java.util.List<String> tagsList) {
            this.tagsList = tagsList;
            return this;
        }
        public java.util.List<String> getTagsList() {
            return this.tagsList;
        }

        public PediaWordsQueryResponseBodyData setUpdaterName(String updaterName) {
            this.updaterName = updaterName;
            return this;
        }
        public String getUpdaterName() {
            return this.updaterName;
        }

        public PediaWordsQueryResponseBodyData setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public PediaWordsQueryResponseBodyData setUuid(Long uuid) {
            this.uuid = uuid;
            return this;
        }
        public Long getUuid() {
            return this.uuid;
        }

        public PediaWordsQueryResponseBodyData setWordAlias(java.util.List<String> wordAlias) {
            this.wordAlias = wordAlias;
            return this;
        }
        public java.util.List<String> getWordAlias() {
            return this.wordAlias;
        }

        public PediaWordsQueryResponseBodyData setWordName(String wordName) {
            this.wordName = wordName;
            return this;
        }
        public String getWordName() {
            return this.wordName;
        }

        public PediaWordsQueryResponseBodyData setWordParaphrase(String wordParaphrase) {
            this.wordParaphrase = wordParaphrase;
            return this;
        }
        public String getWordParaphrase() {
            return this.wordParaphrase;
        }

    }

}
