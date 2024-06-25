// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkpedia_1_0.models;

import com.aliyun.tea.*;

public class PediaWordsUpdateRequest extends TeaModel {
    @NameInMap("appLink")
    public java.util.List<PediaWordsUpdateRequestAppLink> appLink;

    @NameInMap("contactList")
    public java.util.List<PediaWordsUpdateRequestContactList> contactList;

    @NameInMap("highLightWordAlias")
    public java.util.List<String> highLightWordAlias;

    @NameInMap("picList")
    public java.util.List<PediaWordsUpdateRequestPicList> picList;

    @NameInMap("relatedDoc")
    public java.util.List<PediaWordsUpdateRequestRelatedDoc> relatedDoc;

    @NameInMap("relatedLink")
    public java.util.List<PediaWordsUpdateRequestRelatedLink> relatedLink;

    /**
     * <strong>example:</strong>
     * <p>312123213</p>
     */
    @NameInMap("userId")
    public String userId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>2131321</p>
     */
    @NameInMap("uuid")
    public Long uuid;

    @NameInMap("wordAlias")
    public java.util.List<String> wordAlias;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>词条名称</p>
     */
    @NameInMap("wordName")
    public String wordName;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>释义</p>
     */
    @NameInMap("wordParaphrase")
    public String wordParaphrase;

    public static PediaWordsUpdateRequest build(java.util.Map<String, ?> map) throws Exception {
        PediaWordsUpdateRequest self = new PediaWordsUpdateRequest();
        return TeaModel.build(map, self);
    }

    public PediaWordsUpdateRequest setAppLink(java.util.List<PediaWordsUpdateRequestAppLink> appLink) {
        this.appLink = appLink;
        return this;
    }
    public java.util.List<PediaWordsUpdateRequestAppLink> getAppLink() {
        return this.appLink;
    }

    public PediaWordsUpdateRequest setContactList(java.util.List<PediaWordsUpdateRequestContactList> contactList) {
        this.contactList = contactList;
        return this;
    }
    public java.util.List<PediaWordsUpdateRequestContactList> getContactList() {
        return this.contactList;
    }

    public PediaWordsUpdateRequest setHighLightWordAlias(java.util.List<String> highLightWordAlias) {
        this.highLightWordAlias = highLightWordAlias;
        return this;
    }
    public java.util.List<String> getHighLightWordAlias() {
        return this.highLightWordAlias;
    }

    public PediaWordsUpdateRequest setPicList(java.util.List<PediaWordsUpdateRequestPicList> picList) {
        this.picList = picList;
        return this;
    }
    public java.util.List<PediaWordsUpdateRequestPicList> getPicList() {
        return this.picList;
    }

    public PediaWordsUpdateRequest setRelatedDoc(java.util.List<PediaWordsUpdateRequestRelatedDoc> relatedDoc) {
        this.relatedDoc = relatedDoc;
        return this;
    }
    public java.util.List<PediaWordsUpdateRequestRelatedDoc> getRelatedDoc() {
        return this.relatedDoc;
    }

    public PediaWordsUpdateRequest setRelatedLink(java.util.List<PediaWordsUpdateRequestRelatedLink> relatedLink) {
        this.relatedLink = relatedLink;
        return this;
    }
    public java.util.List<PediaWordsUpdateRequestRelatedLink> getRelatedLink() {
        return this.relatedLink;
    }

    public PediaWordsUpdateRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public PediaWordsUpdateRequest setUuid(Long uuid) {
        this.uuid = uuid;
        return this;
    }
    public Long getUuid() {
        return this.uuid;
    }

    public PediaWordsUpdateRequest setWordAlias(java.util.List<String> wordAlias) {
        this.wordAlias = wordAlias;
        return this;
    }
    public java.util.List<String> getWordAlias() {
        return this.wordAlias;
    }

    public PediaWordsUpdateRequest setWordName(String wordName) {
        this.wordName = wordName;
        return this;
    }
    public String getWordName() {
        return this.wordName;
    }

    public PediaWordsUpdateRequest setWordParaphrase(String wordParaphrase) {
        this.wordParaphrase = wordParaphrase;
        return this;
    }
    public String getWordParaphrase() {
        return this.wordParaphrase;
    }

    public static class PediaWordsUpdateRequestAppLink extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>应用名称</p>
         */
        @NameInMap("appName")
        public String appName;

        /**
         * <strong>example:</strong>
         * <p><a href="https://123243435.com">https://123243435.com</a></p>
         */
        @NameInMap("iconLink")
        public String iconLink;

        /**
         * <strong>example:</strong>
         * <p><a href="http://213435.com">http://213435.com</a></p>
         */
        @NameInMap("pcLink")
        public String pcLink;

        /**
         * <strong>example:</strong>
         * <p>htttps://12345.com</p>
         */
        @NameInMap("phoneLink")
        public String phoneLink;

        public static PediaWordsUpdateRequestAppLink build(java.util.Map<String, ?> map) throws Exception {
            PediaWordsUpdateRequestAppLink self = new PediaWordsUpdateRequestAppLink();
            return TeaModel.build(map, self);
        }

        public PediaWordsUpdateRequestAppLink setAppName(String appName) {
            this.appName = appName;
            return this;
        }
        public String getAppName() {
            return this.appName;
        }

        public PediaWordsUpdateRequestAppLink setIconLink(String iconLink) {
            this.iconLink = iconLink;
            return this;
        }
        public String getIconLink() {
            return this.iconLink;
        }

        public PediaWordsUpdateRequestAppLink setPcLink(String pcLink) {
            this.pcLink = pcLink;
            return this;
        }
        public String getPcLink() {
            return this.pcLink;
        }

        public PediaWordsUpdateRequestAppLink setPhoneLink(String phoneLink) {
            this.phoneLink = phoneLink;
            return this;
        }
        public String getPhoneLink() {
            return this.phoneLink;
        }

    }

    public static class PediaWordsUpdateRequestContactList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>@12312312</p>
         */
        @NameInMap("avatarMediaId")
        public String avatarMediaId;

        /**
         * <strong>example:</strong>
         * <p>名称</p>
         */
        @NameInMap("nickName")
        public String nickName;

        /**
         * <strong>example:</strong>
         * <p>12131312</p>
         */
        @NameInMap("userId")
        public String userId;

        public static PediaWordsUpdateRequestContactList build(java.util.Map<String, ?> map) throws Exception {
            PediaWordsUpdateRequestContactList self = new PediaWordsUpdateRequestContactList();
            return TeaModel.build(map, self);
        }

        public PediaWordsUpdateRequestContactList setAvatarMediaId(String avatarMediaId) {
            this.avatarMediaId = avatarMediaId;
            return this;
        }
        public String getAvatarMediaId() {
            return this.avatarMediaId;
        }

        public PediaWordsUpdateRequestContactList setNickName(String nickName) {
            this.nickName = nickName;
            return this;
        }
        public String getNickName() {
            return this.nickName;
        }

        public PediaWordsUpdateRequestContactList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class PediaWordsUpdateRequestPicList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p><a href="https://1234554.com">https://1234554.com</a></p>
         */
        @NameInMap("mediaIdUrl")
        public String mediaIdUrl;

        public static PediaWordsUpdateRequestPicList build(java.util.Map<String, ?> map) throws Exception {
            PediaWordsUpdateRequestPicList self = new PediaWordsUpdateRequestPicList();
            return TeaModel.build(map, self);
        }

        public PediaWordsUpdateRequestPicList setMediaIdUrl(String mediaIdUrl) {
            this.mediaIdUrl = mediaIdUrl;
            return this;
        }
        public String getMediaIdUrl() {
            return this.mediaIdUrl;
        }

    }

    public static class PediaWordsUpdateRequestRelatedDoc extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p><a href="https://213567.com">https://213567.com</a></p>
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

        public static PediaWordsUpdateRequestRelatedDoc build(java.util.Map<String, ?> map) throws Exception {
            PediaWordsUpdateRequestRelatedDoc self = new PediaWordsUpdateRequestRelatedDoc();
            return TeaModel.build(map, self);
        }

        public PediaWordsUpdateRequestRelatedDoc setLink(String link) {
            this.link = link;
            return this;
        }
        public String getLink() {
            return this.link;
        }

        public PediaWordsUpdateRequestRelatedDoc setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public PediaWordsUpdateRequestRelatedDoc setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class PediaWordsUpdateRequestRelatedLink extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p><a href="https://123466.com">https://123466.com</a></p>
         */
        @NameInMap("link")
        public String link;

        /**
         * <strong>example:</strong>
         * <p>相关链接</p>
         */
        @NameInMap("name")
        public String name;

        public static PediaWordsUpdateRequestRelatedLink build(java.util.Map<String, ?> map) throws Exception {
            PediaWordsUpdateRequestRelatedLink self = new PediaWordsUpdateRequestRelatedLink();
            return TeaModel.build(map, self);
        }

        public PediaWordsUpdateRequestRelatedLink setLink(String link) {
            this.link = link;
            return this;
        }
        public String getLink() {
            return this.link;
        }

        public PediaWordsUpdateRequestRelatedLink setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

}
