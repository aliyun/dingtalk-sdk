// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkpedia_1_0.models;

import com.aliyun.tea.*;

public class PediaWordsSearchResponseBody extends TeaModel {
    @NameInMap("data")
    public java.util.List<PediaWordsSearchResponseBodyData> data;

    @NameInMap("success")
    public Boolean success;

    public static PediaWordsSearchResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PediaWordsSearchResponseBody self = new PediaWordsSearchResponseBody();
        return TeaModel.build(map, self);
    }

    public PediaWordsSearchResponseBody setData(java.util.List<PediaWordsSearchResponseBodyData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<PediaWordsSearchResponseBodyData> getData() {
        return this.data;
    }

    public PediaWordsSearchResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class PediaWordsSearchResponseBodyDataAppLink extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>应用名</p>
         */
        @NameInMap("appName")
        public String appName;

        /**
         * <strong>example:</strong>
         * <p><a href="https://123434.com">https://123434.com</a></p>
         */
        @NameInMap("iconLink")
        public String iconLink;

        /**
         * <strong>example:</strong>
         * <p><a href="http://123.com">http://123.com</a></p>
         */
        @NameInMap("pcLink")
        public String pcLink;

        /**
         * <strong>example:</strong>
         * <p><a href="http://1244.com">http://1244.com</a></p>
         */
        @NameInMap("phoneLink")
        public String phoneLink;

        public static PediaWordsSearchResponseBodyDataAppLink build(java.util.Map<String, ?> map) throws Exception {
            PediaWordsSearchResponseBodyDataAppLink self = new PediaWordsSearchResponseBodyDataAppLink();
            return TeaModel.build(map, self);
        }

        public PediaWordsSearchResponseBodyDataAppLink setAppName(String appName) {
            this.appName = appName;
            return this;
        }
        public String getAppName() {
            return this.appName;
        }

        public PediaWordsSearchResponseBodyDataAppLink setIconLink(String iconLink) {
            this.iconLink = iconLink;
            return this;
        }
        public String getIconLink() {
            return this.iconLink;
        }

        public PediaWordsSearchResponseBodyDataAppLink setPcLink(String pcLink) {
            this.pcLink = pcLink;
            return this;
        }
        public String getPcLink() {
            return this.pcLink;
        }

        public PediaWordsSearchResponseBodyDataAppLink setPhoneLink(String phoneLink) {
            this.phoneLink = phoneLink;
            return this;
        }
        public String getPhoneLink() {
            return this.phoneLink;
        }

    }

    public static class PediaWordsSearchResponseBodyDataContactList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>@12321312ds</p>
         */
        @NameInMap("avatarMediaId")
        public String avatarMediaId;

        /**
         * <strong>example:</strong>
         * <p>员工名称</p>
         */
        @NameInMap("nickName")
        public String nickName;

        /**
         * <strong>example:</strong>
         * <p>1232343</p>
         */
        @NameInMap("userId")
        public String userId;

        public static PediaWordsSearchResponseBodyDataContactList build(java.util.Map<String, ?> map) throws Exception {
            PediaWordsSearchResponseBodyDataContactList self = new PediaWordsSearchResponseBodyDataContactList();
            return TeaModel.build(map, self);
        }

        public PediaWordsSearchResponseBodyDataContactList setAvatarMediaId(String avatarMediaId) {
            this.avatarMediaId = avatarMediaId;
            return this;
        }
        public String getAvatarMediaId() {
            return this.avatarMediaId;
        }

        public PediaWordsSearchResponseBodyDataContactList setNickName(String nickName) {
            this.nickName = nickName;
            return this;
        }
        public String getNickName() {
            return this.nickName;
        }

        public PediaWordsSearchResponseBodyDataContactList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class PediaWordsSearchResponseBodyDataPicList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p><a href="https://1234.com">https://1234.com</a></p>
         */
        @NameInMap("mediaIdUrl")
        public String mediaIdUrl;

        public static PediaWordsSearchResponseBodyDataPicList build(java.util.Map<String, ?> map) throws Exception {
            PediaWordsSearchResponseBodyDataPicList self = new PediaWordsSearchResponseBodyDataPicList();
            return TeaModel.build(map, self);
        }

        public PediaWordsSearchResponseBodyDataPicList setMediaIdUrl(String mediaIdUrl) {
            this.mediaIdUrl = mediaIdUrl;
            return this;
        }
        public String getMediaIdUrl() {
            return this.mediaIdUrl;
        }

    }

    public static class PediaWordsSearchResponseBodyDataRelatedDoc extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p><a href="https://12324.com">https://12324.com</a></p>
         */
        @NameInMap("link")
        public String link;

        /**
         * <strong>example:</strong>
         * <p>文档名</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>adoc</p>
         */
        @NameInMap("type")
        public String type;

        public static PediaWordsSearchResponseBodyDataRelatedDoc build(java.util.Map<String, ?> map) throws Exception {
            PediaWordsSearchResponseBodyDataRelatedDoc self = new PediaWordsSearchResponseBodyDataRelatedDoc();
            return TeaModel.build(map, self);
        }

        public PediaWordsSearchResponseBodyDataRelatedDoc setLink(String link) {
            this.link = link;
            return this;
        }
        public String getLink() {
            return this.link;
        }

        public PediaWordsSearchResponseBodyDataRelatedDoc setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public PediaWordsSearchResponseBodyDataRelatedDoc setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class PediaWordsSearchResponseBodyDataRelatedLink extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p><a href="https://123112.com">https://123112.com</a></p>
         */
        @NameInMap("link")
        public String link;

        /**
         * <strong>example:</strong>
         * <p>文档名字</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>空值</p>
         */
        @NameInMap("type")
        public String type;

        public static PediaWordsSearchResponseBodyDataRelatedLink build(java.util.Map<String, ?> map) throws Exception {
            PediaWordsSearchResponseBodyDataRelatedLink self = new PediaWordsSearchResponseBodyDataRelatedLink();
            return TeaModel.build(map, self);
        }

        public PediaWordsSearchResponseBodyDataRelatedLink setLink(String link) {
            this.link = link;
            return this;
        }
        public String getLink() {
            return this.link;
        }

        public PediaWordsSearchResponseBodyDataRelatedLink setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public PediaWordsSearchResponseBodyDataRelatedLink setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class PediaWordsSearchResponseBodyData extends TeaModel {
        @NameInMap("appLink")
        public java.util.List<PediaWordsSearchResponseBodyDataAppLink> appLink;

        /**
         * <strong>example:</strong>
         * <p>审核人钉钉名称</p>
         */
        @NameInMap("approveName")
        public String approveName;

        @NameInMap("contactList")
        public java.util.List<PediaWordsSearchResponseBodyDataContactList> contactList;

        @NameInMap("contacts")
        public java.util.List<String> contacts;

        /**
         * <strong>example:</strong>
         * <p>创建者</p>
         */
        @NameInMap("creatorName")
        public String creatorName;

        @NameInMap("gmtCreate")
        public Long gmtCreate;

        @NameInMap("gmtModify")
        public Long gmtModify;

        @NameInMap("highLightWordAlias")
        public java.util.List<String> highLightWordAlias;

        @NameInMap("imHighLight")
        public Boolean imHighLight;

        @NameInMap("parentUuid")
        public Long parentUuid;

        @NameInMap("picList")
        public java.util.List<PediaWordsSearchResponseBodyDataPicList> picList;

        @NameInMap("relatedDoc")
        public java.util.List<PediaWordsSearchResponseBodyDataRelatedDoc> relatedDoc;

        @NameInMap("relatedLink")
        public java.util.List<PediaWordsSearchResponseBodyDataRelatedLink> relatedLink;

        @NameInMap("simHighLight")
        public Boolean simHighLight;

        /**
         * <strong>example:</strong>
         * <p>剔除了富文本格式后的释义信息</p>
         */
        @NameInMap("simpleWordParaphrase")
        public String simpleWordParaphrase;

        @NameInMap("tagsList")
        public java.util.List<String> tagsList;

        /**
         * <strong>example:</strong>
         * <p>修改人钉钉名称</p>
         */
        @NameInMap("updaterName")
        public String updaterName;

        /**
         * <strong>example:</strong>
         * <p>312312312</p>
         */
        @NameInMap("userId")
        public String userId;

        @NameInMap("uuid")
        public Long uuid;

        @NameInMap("wordAlias")
        public java.util.List<String> wordAlias;

        /**
         * <strong>example:</strong>
         * <p>测试词条</p>
         */
        @NameInMap("wordName")
        public String wordName;

        /**
         * <strong>example:</strong>
         * <p>释义信息</p>
         */
        @NameInMap("wordParaphrase")
        public String wordParaphrase;

        public static PediaWordsSearchResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            PediaWordsSearchResponseBodyData self = new PediaWordsSearchResponseBodyData();
            return TeaModel.build(map, self);
        }

        public PediaWordsSearchResponseBodyData setAppLink(java.util.List<PediaWordsSearchResponseBodyDataAppLink> appLink) {
            this.appLink = appLink;
            return this;
        }
        public java.util.List<PediaWordsSearchResponseBodyDataAppLink> getAppLink() {
            return this.appLink;
        }

        public PediaWordsSearchResponseBodyData setApproveName(String approveName) {
            this.approveName = approveName;
            return this;
        }
        public String getApproveName() {
            return this.approveName;
        }

        public PediaWordsSearchResponseBodyData setContactList(java.util.List<PediaWordsSearchResponseBodyDataContactList> contactList) {
            this.contactList = contactList;
            return this;
        }
        public java.util.List<PediaWordsSearchResponseBodyDataContactList> getContactList() {
            return this.contactList;
        }

        public PediaWordsSearchResponseBodyData setContacts(java.util.List<String> contacts) {
            this.contacts = contacts;
            return this;
        }
        public java.util.List<String> getContacts() {
            return this.contacts;
        }

        public PediaWordsSearchResponseBodyData setCreatorName(String creatorName) {
            this.creatorName = creatorName;
            return this;
        }
        public String getCreatorName() {
            return this.creatorName;
        }

        public PediaWordsSearchResponseBodyData setGmtCreate(Long gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public Long getGmtCreate() {
            return this.gmtCreate;
        }

        public PediaWordsSearchResponseBodyData setGmtModify(Long gmtModify) {
            this.gmtModify = gmtModify;
            return this;
        }
        public Long getGmtModify() {
            return this.gmtModify;
        }

        public PediaWordsSearchResponseBodyData setHighLightWordAlias(java.util.List<String> highLightWordAlias) {
            this.highLightWordAlias = highLightWordAlias;
            return this;
        }
        public java.util.List<String> getHighLightWordAlias() {
            return this.highLightWordAlias;
        }

        public PediaWordsSearchResponseBodyData setImHighLight(Boolean imHighLight) {
            this.imHighLight = imHighLight;
            return this;
        }
        public Boolean getImHighLight() {
            return this.imHighLight;
        }

        public PediaWordsSearchResponseBodyData setParentUuid(Long parentUuid) {
            this.parentUuid = parentUuid;
            return this;
        }
        public Long getParentUuid() {
            return this.parentUuid;
        }

        public PediaWordsSearchResponseBodyData setPicList(java.util.List<PediaWordsSearchResponseBodyDataPicList> picList) {
            this.picList = picList;
            return this;
        }
        public java.util.List<PediaWordsSearchResponseBodyDataPicList> getPicList() {
            return this.picList;
        }

        public PediaWordsSearchResponseBodyData setRelatedDoc(java.util.List<PediaWordsSearchResponseBodyDataRelatedDoc> relatedDoc) {
            this.relatedDoc = relatedDoc;
            return this;
        }
        public java.util.List<PediaWordsSearchResponseBodyDataRelatedDoc> getRelatedDoc() {
            return this.relatedDoc;
        }

        public PediaWordsSearchResponseBodyData setRelatedLink(java.util.List<PediaWordsSearchResponseBodyDataRelatedLink> relatedLink) {
            this.relatedLink = relatedLink;
            return this;
        }
        public java.util.List<PediaWordsSearchResponseBodyDataRelatedLink> getRelatedLink() {
            return this.relatedLink;
        }

        public PediaWordsSearchResponseBodyData setSimHighLight(Boolean simHighLight) {
            this.simHighLight = simHighLight;
            return this;
        }
        public Boolean getSimHighLight() {
            return this.simHighLight;
        }

        public PediaWordsSearchResponseBodyData setSimpleWordParaphrase(String simpleWordParaphrase) {
            this.simpleWordParaphrase = simpleWordParaphrase;
            return this;
        }
        public String getSimpleWordParaphrase() {
            return this.simpleWordParaphrase;
        }

        public PediaWordsSearchResponseBodyData setTagsList(java.util.List<String> tagsList) {
            this.tagsList = tagsList;
            return this;
        }
        public java.util.List<String> getTagsList() {
            return this.tagsList;
        }

        public PediaWordsSearchResponseBodyData setUpdaterName(String updaterName) {
            this.updaterName = updaterName;
            return this;
        }
        public String getUpdaterName() {
            return this.updaterName;
        }

        public PediaWordsSearchResponseBodyData setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public PediaWordsSearchResponseBodyData setUuid(Long uuid) {
            this.uuid = uuid;
            return this;
        }
        public Long getUuid() {
            return this.uuid;
        }

        public PediaWordsSearchResponseBodyData setWordAlias(java.util.List<String> wordAlias) {
            this.wordAlias = wordAlias;
            return this;
        }
        public java.util.List<String> getWordAlias() {
            return this.wordAlias;
        }

        public PediaWordsSearchResponseBodyData setWordName(String wordName) {
            this.wordName = wordName;
            return this;
        }
        public String getWordName() {
            return this.wordName;
        }

        public PediaWordsSearchResponseBodyData setWordParaphrase(String wordParaphrase) {
            this.wordParaphrase = wordParaphrase;
            return this;
        }
        public String getWordParaphrase() {
            return this.wordParaphrase;
        }

    }

}
