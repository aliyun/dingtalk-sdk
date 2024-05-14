// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class GetCardInUserHolderResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("avatarUrl")
    public String avatarUrl;

    @NameInMap("cardAcceptStatus")
    public Integer cardAcceptStatus;

    @NameInMap("cardAcceptTimeLong")
    public Long cardAcceptTimeLong;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("cardId")
    public String cardId;

    @NameInMap("cardSource")
    public Integer cardSource;

    @NameInMap("extension")
    public java.util.Map<String, ?> extension;

    @NameInMap("industryName")
    public String industryName;

    @NameInMap("introduce")
    public String introduce;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("orgName")
    public String orgName;

    @NameInMap("templateId")
    public String templateId;

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

    public GetCardInUserHolderResponseBody setCardAcceptTimeLong(Long cardAcceptTimeLong) {
        this.cardAcceptTimeLong = cardAcceptTimeLong;
        return this;
    }
    public Long getCardAcceptTimeLong() {
        return this.cardAcceptTimeLong;
    }

    public GetCardInUserHolderResponseBody setCardId(String cardId) {
        this.cardId = cardId;
        return this;
    }
    public String getCardId() {
        return this.cardId;
    }

    public GetCardInUserHolderResponseBody setCardSource(Integer cardSource) {
        this.cardSource = cardSource;
        return this;
    }
    public Integer getCardSource() {
        return this.cardSource;
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
