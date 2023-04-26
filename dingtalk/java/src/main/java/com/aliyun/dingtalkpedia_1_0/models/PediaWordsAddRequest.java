// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkpedia_1_0.models;

import com.aliyun.tea.*;

public class PediaWordsAddRequest extends TeaModel {
    @NameInMap("contactList")
    public java.util.List<PediaWordsAddRequestContactList> contactList;

    @NameInMap("highLightWordAlias")
    public java.util.List<String> highLightWordAlias;

    @NameInMap("picList")
    public java.util.List<PediaWordsAddRequestPicList> picList;

    @NameInMap("relatedDoc")
    public java.util.List<PediaWordsAddRequestRelatedDoc> relatedDoc;

    @NameInMap("relatedLink")
    public java.util.List<PediaWordsAddRequestRelatedLink> relatedLink;

    @NameInMap("userId")
    public String userId;

    @NameInMap("wordAlias")
    public java.util.List<String> wordAlias;

    @NameInMap("wordName")
    public String wordName;

    @NameInMap("wordParaphrase")
    public String wordParaphrase;

    public static PediaWordsAddRequest build(java.util.Map<String, ?> map) throws Exception {
        PediaWordsAddRequest self = new PediaWordsAddRequest();
        return TeaModel.build(map, self);
    }

    public PediaWordsAddRequest setContactList(java.util.List<PediaWordsAddRequestContactList> contactList) {
        this.contactList = contactList;
        return this;
    }
    public java.util.List<PediaWordsAddRequestContactList> getContactList() {
        return this.contactList;
    }

    public PediaWordsAddRequest setHighLightWordAlias(java.util.List<String> highLightWordAlias) {
        this.highLightWordAlias = highLightWordAlias;
        return this;
    }
    public java.util.List<String> getHighLightWordAlias() {
        return this.highLightWordAlias;
    }

    public PediaWordsAddRequest setPicList(java.util.List<PediaWordsAddRequestPicList> picList) {
        this.picList = picList;
        return this;
    }
    public java.util.List<PediaWordsAddRequestPicList> getPicList() {
        return this.picList;
    }

    public PediaWordsAddRequest setRelatedDoc(java.util.List<PediaWordsAddRequestRelatedDoc> relatedDoc) {
        this.relatedDoc = relatedDoc;
        return this;
    }
    public java.util.List<PediaWordsAddRequestRelatedDoc> getRelatedDoc() {
        return this.relatedDoc;
    }

    public PediaWordsAddRequest setRelatedLink(java.util.List<PediaWordsAddRequestRelatedLink> relatedLink) {
        this.relatedLink = relatedLink;
        return this;
    }
    public java.util.List<PediaWordsAddRequestRelatedLink> getRelatedLink() {
        return this.relatedLink;
    }

    public PediaWordsAddRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public PediaWordsAddRequest setWordAlias(java.util.List<String> wordAlias) {
        this.wordAlias = wordAlias;
        return this;
    }
    public java.util.List<String> getWordAlias() {
        return this.wordAlias;
    }

    public PediaWordsAddRequest setWordName(String wordName) {
        this.wordName = wordName;
        return this;
    }
    public String getWordName() {
        return this.wordName;
    }

    public PediaWordsAddRequest setWordParaphrase(String wordParaphrase) {
        this.wordParaphrase = wordParaphrase;
        return this;
    }
    public String getWordParaphrase() {
        return this.wordParaphrase;
    }

    public static class PediaWordsAddRequestContactList extends TeaModel {
        @NameInMap("avatarMediaId")
        public String avatarMediaId;

        @NameInMap("nickName")
        public String nickName;

        @NameInMap("userId")
        public String userId;

        public static PediaWordsAddRequestContactList build(java.util.Map<String, ?> map) throws Exception {
            PediaWordsAddRequestContactList self = new PediaWordsAddRequestContactList();
            return TeaModel.build(map, self);
        }

        public PediaWordsAddRequestContactList setAvatarMediaId(String avatarMediaId) {
            this.avatarMediaId = avatarMediaId;
            return this;
        }
        public String getAvatarMediaId() {
            return this.avatarMediaId;
        }

        public PediaWordsAddRequestContactList setNickName(String nickName) {
            this.nickName = nickName;
            return this;
        }
        public String getNickName() {
            return this.nickName;
        }

        public PediaWordsAddRequestContactList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class PediaWordsAddRequestPicList extends TeaModel {
        @NameInMap("mediaIdUrl")
        public String mediaIdUrl;

        public static PediaWordsAddRequestPicList build(java.util.Map<String, ?> map) throws Exception {
            PediaWordsAddRequestPicList self = new PediaWordsAddRequestPicList();
            return TeaModel.build(map, self);
        }

        public PediaWordsAddRequestPicList setMediaIdUrl(String mediaIdUrl) {
            this.mediaIdUrl = mediaIdUrl;
            return this;
        }
        public String getMediaIdUrl() {
            return this.mediaIdUrl;
        }

    }

    public static class PediaWordsAddRequestRelatedDoc extends TeaModel {
        @NameInMap("link")
        public String link;

        @NameInMap("name")
        public String name;

        @NameInMap("type")
        public String type;

        public static PediaWordsAddRequestRelatedDoc build(java.util.Map<String, ?> map) throws Exception {
            PediaWordsAddRequestRelatedDoc self = new PediaWordsAddRequestRelatedDoc();
            return TeaModel.build(map, self);
        }

        public PediaWordsAddRequestRelatedDoc setLink(String link) {
            this.link = link;
            return this;
        }
        public String getLink() {
            return this.link;
        }

        public PediaWordsAddRequestRelatedDoc setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public PediaWordsAddRequestRelatedDoc setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class PediaWordsAddRequestRelatedLink extends TeaModel {
        @NameInMap("link")
        public String link;

        @NameInMap("name")
        public String name;

        public static PediaWordsAddRequestRelatedLink build(java.util.Map<String, ?> map) throws Exception {
            PediaWordsAddRequestRelatedLink self = new PediaWordsAddRequestRelatedLink();
            return TeaModel.build(map, self);
        }

        public PediaWordsAddRequestRelatedLink setLink(String link) {
            this.link = link;
            return this;
        }
        public String getLink() {
            return this.link;
        }

        public PediaWordsAddRequestRelatedLink setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

}
