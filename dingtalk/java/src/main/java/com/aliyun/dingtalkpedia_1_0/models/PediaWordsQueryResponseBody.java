// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkpedia_1_0.models;

import com.aliyun.tea.*;

public class PediaWordsQueryResponseBody extends TeaModel {
    /**
     * <p>返回词条具体对象</p>
     * <br>
     */
    @NameInMap("data")
    public PediaWordsQueryResponseBodyData data;

    /**
     * <p>返回结果</p>
     * <p>false，失败</p>
     * <p>trur，成功</p>
     */
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
         * <p>应用名称</p>
         */
        @NameInMap("appName")
        public String appName;

        /**
         * <p>应用icon</p>
         */
        @NameInMap("iconLink")
        public String iconLink;

        /**
         * <p>桌面端链接</p>
         */
        @NameInMap("pcLink")
        public String pcLink;

        /**
         * <p>手机端链接</p>
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
         * <p>联系人图片办好</p>
         */
        @NameInMap("avatarMediaId")
        public String avatarMediaId;

        /**
         * <p>联系人名称</p>
         */
        @NameInMap("nickName")
        public String nickName;

        /**
         * <p>联系人员工编号</p>
         * <br>
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
         * <p>图片HTTP地址</p>
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
        @NameInMap("link")
        public String link;

        /**
         * <p>文档名称</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>文档类型，分别为adoc或者asheet</p>
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
         * <p>链接地址</p>
         */
        @NameInMap("link")
        public String link;

        /**
         * <p>链接名称</p>
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
        /**
         * <p>相关应用</p>
         */
        @NameInMap("appLink")
        public java.util.List<PediaWordsQueryResponseBodyDataAppLink> appLink;

        /**
         * <p>审核人</p>
         */
        @NameInMap("approveName")
        public String approveName;

        /**
         * <p>联系人列表</p>
         */
        @NameInMap("contactList")
        public java.util.List<PediaWordsQueryResponseBodyDataContactList> contactList;

        /**
         * <p>相关联系人</p>
         */
        @NameInMap("contacts")
        public java.util.List<String> contacts;

        /**
         * <p>创建者</p>
         */
        @NameInMap("creatorName")
        public String creatorName;

        /**
         * <p>创建时间</p>
         */
        @NameInMap("gmtCreate")
        public Long gmtCreate;

        /**
         * <p>修改时间</p>
         */
        @NameInMap("gmtModify")
        public Long gmtModify;

        /**
         * <p>高亮的词条别名</p>
         * <br>
         */
        @NameInMap("highLightWordAlias")
        public java.util.List<String> highLightWordAlias;

        /**
         * <p>内部群是否高亮</p>
         */
        @NameInMap("imHighLight")
        public Boolean imHighLight;

        /**
         * <p>当为待审核词条的时候的父编号</p>
         */
        @NameInMap("parentUuid")
        public Long parentUuid;

        @NameInMap("picList")
        public java.util.List<PediaWordsQueryResponseBodyDataPicList> picList;

        /**
         * <p>相关文档</p>
         */
        @NameInMap("relatedDoc")
        public java.util.List<PediaWordsQueryResponseBodyDataRelatedDoc> relatedDoc;

        /**
         * <p>相关链接</p>
         */
        @NameInMap("relatedLink")
        public java.util.List<PediaWordsQueryResponseBodyDataRelatedLink> relatedLink;

        /**
         * <p>服务群是否高亮</p>
         */
        @NameInMap("simHighLight")
        public Boolean simHighLight;

        /**
         * <p>词条释义非富文本</p>
         */
        @NameInMap("simpleWordParaphrase")
        public String simpleWordParaphrase;

        /**
         * <p>分类名称</p>
         */
        @NameInMap("tagsList")
        public java.util.List<String> tagsList;

        /**
         * <p>更新人</p>
         */
        @NameInMap("updaterName")
        public String updaterName;

        /**
         * <p>操作员工userId</p>
         */
        @NameInMap("userId")
        public String userId;

        /**
         * <p>词条主键ID</p>
         */
        @NameInMap("uuid")
        public Long uuid;

        /**
         * <p>词条别名</p>
         */
        @NameInMap("wordAlias")
        public java.util.List<String> wordAlias;

        /**
         * <p>词条名称</p>
         * <br>
         */
        @NameInMap("wordName")
        public String wordName;

        /**
         * <p>词条释义，富文本</p>
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
