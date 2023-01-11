// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkwiki_1_0.models;

import com.aliyun.tea.*;

public class WikiWordsDetailResponseBody extends TeaModel {
    /**
     * <p>返回的参数</p>
     */
    @NameInMap("data")
    public java.util.List<WikiWordsDetailResponseBodyData> data;

    /**
     * <p>返回的错误信息</p>
     */
    @NameInMap("errMsg")
    public String errMsg;

    /**
     * <p>查询是否成功</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static WikiWordsDetailResponseBody build(java.util.Map<String, ?> map) throws Exception {
        WikiWordsDetailResponseBody self = new WikiWordsDetailResponseBody();
        return TeaModel.build(map, self);
    }

    public WikiWordsDetailResponseBody setData(java.util.List<WikiWordsDetailResponseBodyData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<WikiWordsDetailResponseBodyData> getData() {
        return this.data;
    }

    public WikiWordsDetailResponseBody setErrMsg(String errMsg) {
        this.errMsg = errMsg;
        return this;
    }
    public String getErrMsg() {
        return this.errMsg;
    }

    public WikiWordsDetailResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class WikiWordsDetailResponseBodyDataAppLink extends TeaModel {
        /**
         * <p>应用编号</p>
         */
        @NameInMap("appId")
        public Long appId;

        /**
         * <p>应用名称</p>
         */
        @NameInMap("appName")
        public String appName;

        /**
         * <p>应用图片链接</p>
         */
        @NameInMap("iconLink")
        public String iconLink;

        /**
         * <p>应用PC端链接</p>
         */
        @NameInMap("pcLink")
        public String pcLink;

        /**
         * <p>应用手机端链接</p>
         */
        @NameInMap("phoneLink")
        public String phoneLink;

        public static WikiWordsDetailResponseBodyDataAppLink build(java.util.Map<String, ?> map) throws Exception {
            WikiWordsDetailResponseBodyDataAppLink self = new WikiWordsDetailResponseBodyDataAppLink();
            return TeaModel.build(map, self);
        }

        public WikiWordsDetailResponseBodyDataAppLink setAppId(Long appId) {
            this.appId = appId;
            return this;
        }
        public Long getAppId() {
            return this.appId;
        }

        public WikiWordsDetailResponseBodyDataAppLink setAppName(String appName) {
            this.appName = appName;
            return this;
        }
        public String getAppName() {
            return this.appName;
        }

        public WikiWordsDetailResponseBodyDataAppLink setIconLink(String iconLink) {
            this.iconLink = iconLink;
            return this;
        }
        public String getIconLink() {
            return this.iconLink;
        }

        public WikiWordsDetailResponseBodyDataAppLink setPcLink(String pcLink) {
            this.pcLink = pcLink;
            return this;
        }
        public String getPcLink() {
            return this.pcLink;
        }

        public WikiWordsDetailResponseBodyDataAppLink setPhoneLink(String phoneLink) {
            this.phoneLink = phoneLink;
            return this;
        }
        public String getPhoneLink() {
            return this.phoneLink;
        }

    }

    public static class WikiWordsDetailResponseBodyDataRelatedDoc extends TeaModel {
        /**
         * <p>链接</p>
         */
        @NameInMap("link")
        public String link;

        /**
         * <p>名称</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>文档类型doc或者sheet</p>
         */
        @NameInMap("type")
        public String type;

        public static WikiWordsDetailResponseBodyDataRelatedDoc build(java.util.Map<String, ?> map) throws Exception {
            WikiWordsDetailResponseBodyDataRelatedDoc self = new WikiWordsDetailResponseBodyDataRelatedDoc();
            return TeaModel.build(map, self);
        }

        public WikiWordsDetailResponseBodyDataRelatedDoc setLink(String link) {
            this.link = link;
            return this;
        }
        public String getLink() {
            return this.link;
        }

        public WikiWordsDetailResponseBodyDataRelatedDoc setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public WikiWordsDetailResponseBodyDataRelatedDoc setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class WikiWordsDetailResponseBodyDataRelatedLink extends TeaModel {
        /**
         * <p>链接</p>
         */
        @NameInMap("link")
        public String link;

        /**
         * <p>链接名称</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>链接类型</p>
         */
        @NameInMap("type")
        public String type;

        public static WikiWordsDetailResponseBodyDataRelatedLink build(java.util.Map<String, ?> map) throws Exception {
            WikiWordsDetailResponseBodyDataRelatedLink self = new WikiWordsDetailResponseBodyDataRelatedLink();
            return TeaModel.build(map, self);
        }

        public WikiWordsDetailResponseBodyDataRelatedLink setLink(String link) {
            this.link = link;
            return this;
        }
        public String getLink() {
            return this.link;
        }

        public WikiWordsDetailResponseBodyDataRelatedLink setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public WikiWordsDetailResponseBodyDataRelatedLink setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class WikiWordsDetailResponseBodyData extends TeaModel {
        /**
         * <p>应用对象</p>
         */
        @NameInMap("appLink")
        public java.util.List<WikiWordsDetailResponseBodyDataAppLink> appLink;

        /**
         * <p>审批人</p>
         */
        @NameInMap("approveName")
        public String approveName;

        /**
         * <p>联系人</p>
         */
        @NameInMap("contacts")
        public java.util.List<String> contacts;

        /**
         * <p>创建人</p>
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

        @NameInMap("highLightWordAlias")
        public java.util.List<String> highLightWordAlias;

        /**
         * <p>内部群是否高亮</p>
         */
        @NameInMap("imHighLight")
        public Boolean imHighLight;

        /**
         * <p>组织名称</p>
         */
        @NameInMap("orgName")
        public String orgName;

        /**
         * <p>相关文档</p>
         */
        @NameInMap("relatedDoc")
        public java.util.List<WikiWordsDetailResponseBodyDataRelatedDoc> relatedDoc;

        /**
         * <p>相关链接</p>
         */
        @NameInMap("relatedLink")
        public java.util.List<WikiWordsDetailResponseBodyDataRelatedLink> relatedLink;

        /**
         * <p>服务群是否高亮</p>
         */
        @NameInMap("simHighLight")
        public Boolean simHighLight;

        /**
         * <p>抹除文本格式后的释义</p>
         */
        @NameInMap("simpleWordParaphrase")
        public String simpleWordParaphrase;

        /**
         * <p>标签列表</p>
         */
        @NameInMap("tagsList")
        public java.util.List<String> tagsList;

        /**
         * <p>更新人</p>
         */
        @NameInMap("updaterName")
        public String updaterName;

        /**
         * <p>唯一编号</p>
         */
        @NameInMap("uuid")
        public Long uuid;

        /**
         * <p>别名</p>
         */
        @NameInMap("wordAlias")
        public java.util.List<String> wordAlias;

        /**
         * <p>全名</p>
         */
        @NameInMap("wordFullName")
        public String wordFullName;

        /**
         * <p>词条名称</p>
         */
        @NameInMap("wordName")
        public String wordName;

        /**
         * <p>原始释义(带格式数据的释义）</p>
         */
        @NameInMap("wordParaphrase")
        public String wordParaphrase;

        public static WikiWordsDetailResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            WikiWordsDetailResponseBodyData self = new WikiWordsDetailResponseBodyData();
            return TeaModel.build(map, self);
        }

        public WikiWordsDetailResponseBodyData setAppLink(java.util.List<WikiWordsDetailResponseBodyDataAppLink> appLink) {
            this.appLink = appLink;
            return this;
        }
        public java.util.List<WikiWordsDetailResponseBodyDataAppLink> getAppLink() {
            return this.appLink;
        }

        public WikiWordsDetailResponseBodyData setApproveName(String approveName) {
            this.approveName = approveName;
            return this;
        }
        public String getApproveName() {
            return this.approveName;
        }

        public WikiWordsDetailResponseBodyData setContacts(java.util.List<String> contacts) {
            this.contacts = contacts;
            return this;
        }
        public java.util.List<String> getContacts() {
            return this.contacts;
        }

        public WikiWordsDetailResponseBodyData setCreatorName(String creatorName) {
            this.creatorName = creatorName;
            return this;
        }
        public String getCreatorName() {
            return this.creatorName;
        }

        public WikiWordsDetailResponseBodyData setGmtCreate(Long gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public Long getGmtCreate() {
            return this.gmtCreate;
        }

        public WikiWordsDetailResponseBodyData setGmtModify(Long gmtModify) {
            this.gmtModify = gmtModify;
            return this;
        }
        public Long getGmtModify() {
            return this.gmtModify;
        }

        public WikiWordsDetailResponseBodyData setHighLightWordAlias(java.util.List<String> highLightWordAlias) {
            this.highLightWordAlias = highLightWordAlias;
            return this;
        }
        public java.util.List<String> getHighLightWordAlias() {
            return this.highLightWordAlias;
        }

        public WikiWordsDetailResponseBodyData setImHighLight(Boolean imHighLight) {
            this.imHighLight = imHighLight;
            return this;
        }
        public Boolean getImHighLight() {
            return this.imHighLight;
        }

        public WikiWordsDetailResponseBodyData setOrgName(String orgName) {
            this.orgName = orgName;
            return this;
        }
        public String getOrgName() {
            return this.orgName;
        }

        public WikiWordsDetailResponseBodyData setRelatedDoc(java.util.List<WikiWordsDetailResponseBodyDataRelatedDoc> relatedDoc) {
            this.relatedDoc = relatedDoc;
            return this;
        }
        public java.util.List<WikiWordsDetailResponseBodyDataRelatedDoc> getRelatedDoc() {
            return this.relatedDoc;
        }

        public WikiWordsDetailResponseBodyData setRelatedLink(java.util.List<WikiWordsDetailResponseBodyDataRelatedLink> relatedLink) {
            this.relatedLink = relatedLink;
            return this;
        }
        public java.util.List<WikiWordsDetailResponseBodyDataRelatedLink> getRelatedLink() {
            return this.relatedLink;
        }

        public WikiWordsDetailResponseBodyData setSimHighLight(Boolean simHighLight) {
            this.simHighLight = simHighLight;
            return this;
        }
        public Boolean getSimHighLight() {
            return this.simHighLight;
        }

        public WikiWordsDetailResponseBodyData setSimpleWordParaphrase(String simpleWordParaphrase) {
            this.simpleWordParaphrase = simpleWordParaphrase;
            return this;
        }
        public String getSimpleWordParaphrase() {
            return this.simpleWordParaphrase;
        }

        public WikiWordsDetailResponseBodyData setTagsList(java.util.List<String> tagsList) {
            this.tagsList = tagsList;
            return this;
        }
        public java.util.List<String> getTagsList() {
            return this.tagsList;
        }

        public WikiWordsDetailResponseBodyData setUpdaterName(String updaterName) {
            this.updaterName = updaterName;
            return this;
        }
        public String getUpdaterName() {
            return this.updaterName;
        }

        public WikiWordsDetailResponseBodyData setUuid(Long uuid) {
            this.uuid = uuid;
            return this;
        }
        public Long getUuid() {
            return this.uuid;
        }

        public WikiWordsDetailResponseBodyData setWordAlias(java.util.List<String> wordAlias) {
            this.wordAlias = wordAlias;
            return this;
        }
        public java.util.List<String> getWordAlias() {
            return this.wordAlias;
        }

        public WikiWordsDetailResponseBodyData setWordFullName(String wordFullName) {
            this.wordFullName = wordFullName;
            return this;
        }
        public String getWordFullName() {
            return this.wordFullName;
        }

        public WikiWordsDetailResponseBodyData setWordName(String wordName) {
            this.wordName = wordName;
            return this;
        }
        public String getWordName() {
            return this.wordName;
        }

        public WikiWordsDetailResponseBodyData setWordParaphrase(String wordParaphrase) {
            this.wordParaphrase = wordParaphrase;
            return this;
        }
        public String getWordParaphrase() {
            return this.wordParaphrase;
        }

    }

}
