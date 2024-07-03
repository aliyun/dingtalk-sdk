// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class HandoverTeamWithoutAuthRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("param")
    public HandoverTeamWithoutAuthRequestParam param;

    public static HandoverTeamWithoutAuthRequest build(java.util.Map<String, ?> map) throws Exception {
        HandoverTeamWithoutAuthRequest self = new HandoverTeamWithoutAuthRequest();
        return TeaModel.build(map, self);
    }

    public HandoverTeamWithoutAuthRequest setParam(HandoverTeamWithoutAuthRequestParam param) {
        this.param = param;
        return this;
    }
    public HandoverTeamWithoutAuthRequestParam getParam() {
        return this.param;
    }

    public static class HandoverTeamWithoutAuthRequestParam extends TeaModel {
        @NameInMap("leave")
        public Boolean leave;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("newOwner")
        public String newOwner;

        @NameInMap("notify")
        public Boolean notify;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("teamId")
        public String teamId;

        public static HandoverTeamWithoutAuthRequestParam build(java.util.Map<String, ?> map) throws Exception {
            HandoverTeamWithoutAuthRequestParam self = new HandoverTeamWithoutAuthRequestParam();
            return TeaModel.build(map, self);
        }

        public HandoverTeamWithoutAuthRequestParam setLeave(Boolean leave) {
            this.leave = leave;
            return this;
        }
        public Boolean getLeave() {
            return this.leave;
        }

        public HandoverTeamWithoutAuthRequestParam setNewOwner(String newOwner) {
            this.newOwner = newOwner;
            return this;
        }
        public String getNewOwner() {
            return this.newOwner;
        }

        public HandoverTeamWithoutAuthRequestParam setNotify(Boolean notify) {
            this.notify = notify;
            return this;
        }
        public Boolean getNotify() {
            return this.notify;
        }

        public HandoverTeamWithoutAuthRequestParam setTeamId(String teamId) {
            this.teamId = teamId;
            return this;
        }
        public String getTeamId() {
            return this.teamId;
        }

    }

}
