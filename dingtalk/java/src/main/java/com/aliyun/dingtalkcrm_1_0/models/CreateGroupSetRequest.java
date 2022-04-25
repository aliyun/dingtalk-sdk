// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class CreateGroupSetRequest extends TeaModel {
    @NameInMap("creatorUserId")
    public String creatorUserId;

    @NameInMap("managerUserIds")
    public String managerUserIds;

    @NameInMap("memberQuota")
    public Integer memberQuota;

    @NameInMap("name")
    public String name;

    @NameInMap("notice")
    public String notice;

    @NameInMap("noticeToped")
    public Integer noticeToped;

    @NameInMap("ownerUserId")
    public String ownerUserId;

    @NameInMap("relationType")
    public String relationType;

    @NameInMap("templateId")
    public String templateId;

    @NameInMap("welcome")
    public String welcome;

    public static CreateGroupSetRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateGroupSetRequest self = new CreateGroupSetRequest();
        return TeaModel.build(map, self);
    }

    public CreateGroupSetRequest setCreatorUserId(String creatorUserId) {
        this.creatorUserId = creatorUserId;
        return this;
    }
    public String getCreatorUserId() {
        return this.creatorUserId;
    }

    public CreateGroupSetRequest setManagerUserIds(String managerUserIds) {
        this.managerUserIds = managerUserIds;
        return this;
    }
    public String getManagerUserIds() {
        return this.managerUserIds;
    }

    public CreateGroupSetRequest setMemberQuota(Integer memberQuota) {
        this.memberQuota = memberQuota;
        return this;
    }
    public Integer getMemberQuota() {
        return this.memberQuota;
    }

    public CreateGroupSetRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public CreateGroupSetRequest setNotice(String notice) {
        this.notice = notice;
        return this;
    }
    public String getNotice() {
        return this.notice;
    }

    public CreateGroupSetRequest setNoticeToped(Integer noticeToped) {
        this.noticeToped = noticeToped;
        return this;
    }
    public Integer getNoticeToped() {
        return this.noticeToped;
    }

    public CreateGroupSetRequest setOwnerUserId(String ownerUserId) {
        this.ownerUserId = ownerUserId;
        return this;
    }
    public String getOwnerUserId() {
        return this.ownerUserId;
    }

    public CreateGroupSetRequest setRelationType(String relationType) {
        this.relationType = relationType;
        return this;
    }
    public String getRelationType() {
        return this.relationType;
    }

    public CreateGroupSetRequest setTemplateId(String templateId) {
        this.templateId = templateId;
        return this;
    }
    public String getTemplateId() {
        return this.templateId;
    }

    public CreateGroupSetRequest setWelcome(String welcome) {
        this.welcome = welcome;
        return this;
    }
    public String getWelcome() {
        return this.welcome;
    }

}
