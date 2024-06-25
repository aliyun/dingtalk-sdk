// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class PushBadgeRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>110000000</p>
     */
    @NameInMap("agentId")
    public String agentId;

    @NameInMap("badgeItems")
    public java.util.List<PushBadgeRequestBadgeItems> badgeItems;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>0</p>
     */
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
        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("pushValue")
        public String pushValue;

        /**
         * <strong>example:</strong>
         * <p>12345</p>
         */
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
