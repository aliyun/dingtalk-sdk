// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class GetCardInUserHolderResponseBody extends TeaModel {
    // 头像
    @NameInMap("avatarUrl")
    public String avatarUrl;

    // 名片ID
    @NameInMap("cardId")
    public String cardId;

    // 扩展信息
    @NameInMap("extension")
    public java.util.Map<String, ?> extension;

    // 行业
    @NameInMap("industryName")
    public String industryName;

    // 简介
    @NameInMap("introduce")
    public String introduce;

    // 名字
    @NameInMap("name")
    public String name;

    // 组织名称
    @NameInMap("orgName")
    public String orgName;

    // 模板ID
    @NameInMap("templateId")
    public String templateId;

    // 职位
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
