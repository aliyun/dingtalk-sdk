// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class UniqueQueryUserCardResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>@lADPD2sQxoYs677NAavNAao</p>
     */
    @NameInMap("avatarUrl")
    public String avatarUrl;

    /**
     * <strong>example:</strong>
     * <p>CARD-6F0DA174-A0F4-4EBF-B24B-5FDFA648D25E</p>
     */
    @NameInMap("cardId")
    public String cardId;

    @NameInMap("extension")
    public java.util.Map<String, ?> extension;

    /**
     * <strong>example:</strong>
     * <p>工业</p>
     */
    @NameInMap("industryName")
    public String industryName;

    /**
     * <strong>example:</strong>
     * <p>我是谁</p>
     */
    @NameInMap("introduce")
    public String introduce;

    /**
     * <strong>example:</strong>
     * <p>张三</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <strong>example:</strong>
     * <p>测试企业</p>
     */
    @NameInMap("orgName")
    public String orgName;

    @NameInMap("settings")
    public java.util.Map<String, ?> settings;

    /**
     * <strong>example:</strong>
     * <p>163520027_5FE66C522EA142C8r7Abf7VY</p>
     */
    @NameInMap("templateId")
    public String templateId;

    /**
     * <strong>example:</strong>
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
