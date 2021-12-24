// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class UpdateGroupSetRequest extends TeaModel {
    @NameInMap("openGroupSetId")
    public String openGroupSetId;

    @NameInMap("name")
    public String name;

    @NameInMap("memberQuota")
    public Integer memberQuota;

    @NameInMap("ownerUserId")
    public String ownerUserId;

    @NameInMap("managerUserIds")
    public String managerUserIds;

    @NameInMap("notice")
    public String notice;

    @NameInMap("noticeToped")
    public Integer noticeToped;

    @NameInMap("templateId")
    public String templateId;

    public static UpdateGroupSetRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateGroupSetRequest self = new UpdateGroupSetRequest();
        return TeaModel.build(map, self);
    }

    public UpdateGroupSetRequest setOpenGroupSetId(String openGroupSetId) {
        this.openGroupSetId = openGroupSetId;
        return this;
    }
    public String getOpenGroupSetId() {
        return this.openGroupSetId;
    }

    public UpdateGroupSetRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public UpdateGroupSetRequest setMemberQuota(Integer memberQuota) {
        this.memberQuota = memberQuota;
        return this;
    }
    public Integer getMemberQuota() {
        return this.memberQuota;
    }

    public UpdateGroupSetRequest setOwnerUserId(String ownerUserId) {
        this.ownerUserId = ownerUserId;
        return this;
    }
    public String getOwnerUserId() {
        return this.ownerUserId;
    }

    public UpdateGroupSetRequest setManagerUserIds(String managerUserIds) {
        this.managerUserIds = managerUserIds;
        return this;
    }
    public String getManagerUserIds() {
        return this.managerUserIds;
    }

    public UpdateGroupSetRequest setNotice(String notice) {
        this.notice = notice;
        return this;
    }
    public String getNotice() {
        return this.notice;
    }

    public UpdateGroupSetRequest setNoticeToped(Integer noticeToped) {
        this.noticeToped = noticeToped;
        return this;
    }
    public Integer getNoticeToped() {
        return this.noticeToped;
    }

    public UpdateGroupSetRequest setTemplateId(String templateId) {
        this.templateId = templateId;
        return this;
    }
    public String getTemplateId() {
        return this.templateId;
    }

}
