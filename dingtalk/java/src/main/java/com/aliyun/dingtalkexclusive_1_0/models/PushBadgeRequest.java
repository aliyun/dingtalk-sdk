// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class PushBadgeRequest extends TeaModel {
    @NameInMap("agentId")
    public String agentId;

    @NameInMap("badgeItems")
    public java.util.List<PushBadgeRequestBadgeItems> badgeItems;

    @NameInMap("pushType")
    public String pushType;

    public static PushBadgeRequest build(java.util.Map<String, ?> map) throws Exception {
        PushBadgeRequest self = new PushBadgeRequest();
        return TeaModel.build(map, self);
    }

    public PushBadgeRequest setAgentId(String agentId) {
        this.agentId = agentId;
        return this;
    }
    public String getAgentId() {
        return this.agentId;
    }

    public PushBadgeRequest setBadgeItems(java.util.List<PushBadgeRequestBadgeItems> badgeItems) {
        this.badgeItems = badgeItems;
        return this;
    }
    public java.util.List<PushBadgeRequestBadgeItems> getBadgeItems() {
        return this.badgeItems;
    }

    public PushBadgeRequest setPushType(String pushType) {
        this.pushType = pushType;
        return this;
    }
    public String getPushType() {
        return this.pushType;
    }

    public static class PushBadgeRequestBadgeItems extends TeaModel {
        @NameInMap("pushValue")
        public String pushValue;

        @NameInMap("userId")
        public String userId;

        public static PushBadgeRequestBadgeItems build(java.util.Map<String, ?> map) throws Exception {
            PushBadgeRequestBadgeItems self = new PushBadgeRequestBadgeItems();
            return TeaModel.build(map, self);
        }

        public PushBadgeRequestBadgeItems setPushValue(String pushValue) {
            this.pushValue = pushValue;
            return this;
        }
        public String getPushValue() {
            return this.pushValue;
        }

        public PushBadgeRequestBadgeItems setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
