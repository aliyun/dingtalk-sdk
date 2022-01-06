// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class CreateGroupSetRequest extends TeaModel {
    @NameInMap("name")
    public String name;

    @NameInMap("ownerUserId")
    public String ownerUserId;

    @NameInMap("creatorUserId")
    public String creatorUserId;

    @NameInMap("templateId")
    public String templateId;

    @NameInMap("memberQuota")
    public Long memberQuota;

    @NameInMap("managerUserIds")
    public String managerUserIds;

    @NameInMap("notice")
    public String notice;

    @NameInMap("noticeToped")
    public Integer noticeToped;

    @NameInMap("relationType")
    public String relationType;

    public static CreateGroupSetRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateGroupSetRequest self = new CreateGroupSetRequest();
        return TeaModel.build(map, self);
    }

    public CreateGroupSetRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public CreateGroupSetRequest setOwnerUserId(String ownerUserId) {
        this.ownerUserId = ownerUserId;
        return this;
    }
    public String getOwnerUserId() {
        return this.ownerUserId;
    }

    public CreateGroupSetRequest setCreatorUserId(String creatorUserId) {
        this.creatorUserId = creatorUserId;
        return this;
    }
    public String getCreatorUserId() {
        return this.creatorUserId;
    }

    public CreateGroupSetRequest setTemplateId(String templateId) {
        this.templateId = templateId;
        return this;
    }
    public String getTemplateId() {
        return this.templateId;
    }

    public CreateGroupSetRequest setMemberQuota(Long memberQuota) {
        this.memberQuota = memberQuota;
        return this;
    }
    public Long getMemberQuota() {
        return this.memberQuota;
    }

    public CreateGroupSetRequest setManagerUserIds(String managerUserIds) {
        this.managerUserIds = managerUserIds;
        return this;
    }
    public String getManagerUserIds() {
        return this.managerUserIds;
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

    public CreateGroupSetRequest setRelationType(String relationType) {
        this.relationType = relationType;
        return this;
    }
    public String getRelationType() {
        return this.relationType;
    }

}