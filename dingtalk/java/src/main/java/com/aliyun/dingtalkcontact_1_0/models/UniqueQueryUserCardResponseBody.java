// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class UniqueQueryUserCardResponseBody extends TeaModel {
    @NameInMap("avatarUrl")
    public String avatarUrl;

    @NameInMap("cardId")
    public String cardId;

    @NameInMap("extension")
    public java.util.Map<String, ?> extension;

    @NameInMap("industryName")
    public String industryName;

    @NameInMap("introduce")
    public String introduce;

    @NameInMap("name")
    public String name;

    @NameInMap("orgName")
    public String orgName;

    @NameInMap("settings")
    public java.util.Map<String, ?> settings;

    @NameInMap("templateId")
    public String templateId;

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

    public UniqueQueryUserCardResponseBody setSettings(java.util.Map<String, ?> settings) {
        this.settings = settings;
        return this;
    }
    public java.util.Map<String, ?> getSettings() {
        return this.settings;
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
