// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class GetCardInUserHolderResponseBody extends TeaModel {
    /**
     * <p>头像</p>
     */
    @NameInMap("avatarUrl")
    public String avatarUrl;

    /**
     * <p>名片收下状态</p>
     */
    @NameInMap("cardAcceptStatus")
    public Integer cardAcceptStatus;

    /**
     * <p>名片收下时间</p>
     */
    @NameInMap("cardAcceptTime")
    public Object cardAcceptTime;

    /**
     * <p>名片ID</p>
     */
    @NameInMap("cardId")
    public String cardId;

    /**
     * <p>扩展信息</p>
     */
    @NameInMap("extension")
    public java.util.Map<String, ?> extension;

    /**
     * <p>行业</p>
     */
    @NameInMap("industryName")
    public String industryName;

    /**
     * <p>简介</p>
     */
    @NameInMap("introduce")
    public String introduce;

    /**
     * <p>名字</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>组织名称</p>
     */
    @NameInMap("orgName")
    public String orgName;

    /**
     * <p>模板ID</p>
     */
    @NameInMap("templateId")
    public String templateId;

    /**
     * <p>职位</p>
     */
    @NameInMap("title")
    public String title;

    public static GetCardInUserHolderResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetCardInUserHolderResponseBody self = new GetCardInUserHolderResponseBody();
        return TeaModel.build(map, self);
    }

    public GetCardInUserHolderResponseBody setAvatarUrl(String avatarUrl) {
        this.avatarUrl = avatarUrl;
        return this;
    }
    public String getAvatarUrl() {
        return this.avatarUrl;
    }

    public GetCardInUserHolderResponseBody setCardAcceptStatus(Integer cardAcceptStatus) {
        this.cardAcceptStatus = cardAcceptStatus;
        return this;
    }
    public Integer getCardAcceptStatus() {
        return this.cardAcceptStatus;
    }

    public GetCardInUserHolderResponseBody setCardAcceptTime(Object cardAcceptTime) {
        this.cardAcceptTime = cardAcceptTime;
        return this;
    }
    public Object getCardAcceptTime() {
        return this.cardAcceptTime;
    }

    public GetCardInUserHolderResponseBody setCardId(String cardId) {
        this.cardId = cardId;
        return this;
    }
    public String getCardId() {
        return this.cardId;
    }

    public GetCardInUserHolderResponseBody setExtension(java.util.Map<String, ?> extension) {
        this.extension = extension;
        return this;
    }
    public java.util.Map<String, ?> getExtension() {
        return this.extension;
    }

    public GetCardInUserHolderResponseBody setIndustryName(String industryName) {
        this.industryName = industryName;
        return this;
    }
    public String getIndustryName() {
        return this.industryName;
    }

    public GetCardInUserHolderResponseBody setIntroduce(String introduce) {
        this.introduce = introduce;
        return this;
    }
    public String getIntroduce() {
        return this.introduce;
    }

    public GetCardInUserHolderResponseBody setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public GetCardInUserHolderResponseBody setOrgName(String orgName) {
        this.orgName = orgName;
        return this;
    }
    public String getOrgName() {
        return this.orgName;
    }

    public GetCardInUserHolderResponseBody setTemplateId(String templateId) {
        this.templateId = templateId;
        return this;
    }
    public String getTemplateId() {
        return this.templateId;
    }

    public GetCardInUserHolderResponseBody setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

}
