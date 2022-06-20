// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class UniqueQueryUserCardResponseBody extends TeaModel {
    // 图标
    @NameInMap("avatarUrl")
    public String avatarUrl;

    // 名片id
    @NameInMap("cardId")
    public String cardId;

    // 额外信息
    @NameInMap("extension")
    public java.util.Map<String, ?> extension;

    // 工业名
    @NameInMap("industryName")
    public String industryName;

    // 介绍
    @NameInMap("introduce")
    public String introduce;

    // 名称
    @NameInMap("name")
    public String name;

    // 组织名
    @NameInMap("orgName")
    public String orgName;

    // 模版id
    @NameInMap("templateId")
    public String templateId;

    // 标题
    @NameInMap("title")
    public String title;

    public static UniqueQueryUserCardResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UniqueQueryUserCardResponseBody self = new UniqueQueryUserCardResponseBody();
        return TeaModel.build(map, self);
    }

    public UniqueQueryUserCardResponseBody setAvatarUrl(String avatarUrl) {
        this.avatarUrl = avatarUrl;
        return this;
    }
    public String getAvatarUrl() {
        return this.avatarUrl;
    }

    public UniqueQueryUserCardResponseBody setCardId(String cardId) {
        this.cardId = cardId;
        return this;
    }
    public String getCardId() {
        return this.cardId;
    }

    public UniqueQueryUserCardResponseBody setExtension(java.util.Map<String, ?> extension) {
        this.extension = extension;
        return this;
    }
    public java.util.Map<String, ?> getExtension() {
        return this.extension;
    }

    public UniqueQueryUserCardResponseBody setIndustryName(String industryName) {
        this.industryName = industryName;
        return this;
    }
    public String getIndustryName() {
        return this.industryName;
    }

    public UniqueQueryUserCardResponseBody setIntroduce(String introduce) {
        this.introduce = introduce;
        return this;
    }
    public String getIntroduce() {
        return this.introduce;
    }

    public UniqueQueryUserCardResponseBody setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public UniqueQueryUserCardResponseBody setOrgName(String orgName) {
        this.orgName = orgName;
        return this;
    }
    public String getOrgName() {
        return this.orgName;
    }

    public UniqueQueryUserCardResponseBody setTemplateId(String templateId) {
        this.templateId = templateId;
        return this;
    }
    public String getTemplateId() {
        return this.templateId;
    }

    public UniqueQueryUserCardResponseBody setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

}
