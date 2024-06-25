// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_2_0.models;

import com.aliyun.tea.*;

public class CreateCoupleGroupRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>8d42****nkld</p>
     */
    @NameInMap("groupTemplateId")
    public String groupTemplateId;

    /**
     * <strong>example:</strong>
     * <p>1745****8777</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    @NameInMap("users")
    public java.util.List<CreateCoupleGroupRequestUsers> users;

    public static CreateCoupleGroupRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateCoupleGroupRequest self = new CreateCoupleGroupRequest();
        return TeaModel.build(map, self);
    }

    public CreateCoupleGroupRequest setGroupTemplateId(String groupTemplateId) {
        this.groupTemplateId = groupTemplateId;
        return this;
    }
    public String getGroupTemplateId() {
        return this.groupTemplateId;
    }

    public CreateCoupleGroupRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public CreateCoupleGroupRequest setUsers(java.util.List<CreateCoupleGroupRequestUsers> users) {
        this.users = users;
        return this;
    }
    public java.util.List<CreateCoupleGroupRequestUsers> getUsers() {
        return this.users;
    }

    public static class CreateCoupleGroupRequestUsers extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>1107****2120</p>
         */
        @NameInMap("appUserId")
        public String appUserId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("groupOwner")
        public Boolean groupOwner;

        /**
         * <strong>example:</strong>
         * <p>1745****8778</p>
         */
        @NameInMap("userId")
        public String userId;

        public static CreateCoupleGroupRequestUsers build(java.util.Map<String, ?> map) throws Exception {
            CreateCoupleGroupRequestUsers self = new CreateCoupleGroupRequestUsers();
            return TeaModel.build(map, self);
        }

        public CreateCoupleGroupRequestUsers setAppUserId(String appUserId) {
            this.appUserId = appUserId;
            return this;
        }
        public String getAppUserId() {
            return this.appUserId;
        }

        public CreateCoupleGroupRequestUsers setGroupOwner(Boolean groupOwner) {
            this.groupOwner = groupOwner;
            return this;
        }
        public Boolean getGroupOwner() {
            return this.groupOwner;
        }

        public CreateCoupleGroupRequestUsers setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
