// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class IntelligentSendCardRequest extends TeaModel {
    @NameInMap("atAll")
    public Boolean atAll;

    @NameInMap("atOpenGroupRoleIds")
    public java.util.List<String> atOpenGroupRoleIds;

    @NameInMap("atUnionIds")
    public java.util.List<String> atUnionIds;

    @NameInMap("atUserIds")
    public java.util.List<String> atUserIds;

    @NameInMap("excludeIds")
    public java.util.List<String> excludeIds;

    /**
     * <strong>example:</strong>
     * <p>cidt*****Xa4K10w==</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    @NameInMap("outTrackId")
    public String outTrackId;

    @NameInMap("receivers")
    public java.util.List<String> receivers;

    /**
     * <strong>example:</strong>
     * <p>axcf*-<em><strong><strong>-</strong></strong></em>-23da*</p>
     */
    @NameInMap("uuid")
    public String uuid;

    public static IntelligentSendCardRequest build(java.util.Map<String, ?> map) throws Exception {
        IntelligentSendCardRequest self = new IntelligentSendCardRequest();
        return TeaModel.build(map, self);
    }

    public IntelligentSendCardRequest setAtAll(Boolean atAll) {
        this.atAll = atAll;
        return this;
    }
    public Boolean getAtAll() {
        return this.atAll;
    }

    public IntelligentSendCardRequest setAtOpenGroupRoleIds(java.util.List<String> atOpenGroupRoleIds) {
        this.atOpenGroupRoleIds = atOpenGroupRoleIds;
        return this;
    }
    public java.util.List<String> getAtOpenGroupRoleIds() {
        return this.atOpenGroupRoleIds;
    }

    public IntelligentSendCardRequest setAtUnionIds(java.util.List<String> atUnionIds) {
        this.atUnionIds = atUnionIds;
        return this;
    }
    public java.util.List<String> getAtUnionIds() {
        return this.atUnionIds;
    }

    public IntelligentSendCardRequest setAtUserIds(java.util.List<String> atUserIds) {
        this.atUserIds = atUserIds;
        return this;
    }
    public java.util.List<String> getAtUserIds() {
        return this.atUserIds;
    }

    public IntelligentSendCardRequest setExcludeIds(java.util.List<String> excludeIds) {
        this.excludeIds = excludeIds;
        return this;
    }
    public java.util.List<String> getExcludeIds() {
        return this.excludeIds;
    }

    public IntelligentSendCardRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public IntelligentSendCardRequest setOutTrackId(String outTrackId) {
        this.outTrackId = outTrackId;
        return this;
    }
    public String getOutTrackId() {
        return this.outTrackId;
    }

    public IntelligentSendCardRequest setReceivers(java.util.List<String> receivers) {
        this.receivers = receivers;
        return this;
    }
    public java.util.List<String> getReceivers() {
        return this.receivers;
    }

    public IntelligentSendCardRequest setUuid(String uuid) {
        this.uuid = uuid;
        return this;
    }
    public String getUuid() {
        return this.uuid;
    }

}
