// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class UniqueQueryUserCardResponseBody extends TeaModel {
    /**
     * <p>图标</p>
     */
    @NameInMap("avatarUrl")
    public String avatarUrl;

    /**
     * <p>名片id</p>
     */
    @NameInMap("cardId")
    public String cardId;

    /**
     * <p>额外信息</p>
     */
    @NameInMap("extension")
    public java.util.Map<String, ?> extension;

    /**
     * <p>工业名</p>
     */
    @NameInMap("industryName")
    public String industryName;

    /**
     * <p>介绍</p>
     */
    @NameInMap("introduce")
    public String introduce;

    /**
     * <p>名称</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>组织名</p>
     */
    @NameInMap("orgName")
    public String orgName;

    /**
     * <p>用户设置</p>
     */
    @NameInMap("settings")
    public java.util.Map<String, ?> settings;

    /**
     * <p>模版id</p>
     */
    @NameInMap("templateId")
    public String templateId;

    /**
     * <p>标题</p>
     */
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
