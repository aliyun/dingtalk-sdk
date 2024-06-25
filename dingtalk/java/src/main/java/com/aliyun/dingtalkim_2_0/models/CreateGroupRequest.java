// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_2_0.models;

import com.aliyun.tea.*;

public class CreateGroupRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>http://***.png</p>
     */
    @NameInMap("groupAvatar")
    public String groupAvatar;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>客户群</p>
     */
    @NameInMap("groupName")
    public String groupName;

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

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("users")
    public java.util.List<CreateGroupRequestUsers> users;

    public static CreateGroupRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateGroupRequest self = new CreateGroupRequest();
        return TeaModel.build(map, self);
    }

    public CreateGroupRequest setGroupAvatar(String groupAvatar) {
        this.groupAvatar = groupAvatar;
        return this;
    }
    public String getGroupAvatar() {
        return this.groupAvatar;
    }

    public CreateGroupRequest setGroupName(String groupName) {
        this.groupName = groupName;
        return this;
    }
    public String getGroupName() {
        return this.groupName;
    }

    public CreateGroupRequest setGroupTemplateId(String groupTemplateId) {
        this.groupTemplateId = groupTemplateId;
        return this;
    }
    public String getGroupTemplateId() {
        return this.groupTemplateId;
    }

    public CreateGroupRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public CreateGroupRequest setUsers(java.util.List<CreateGroupRequestUsers> users) {
        this.users = users;
        return this;
    }
    public java.util.List<CreateGroupRequestUsers> getUsers() {
        return this.users;
    }

    public static class CreateGroupRequestUsers extends TeaModel {
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

        public static CreateGroupRequestUsers build(java.util.Map<String, ?> map) throws Exception {
            CreateGroupRequestUsers self = new CreateGroupRequestUsers();
            return TeaModel.build(map, self);
        }

        public CreateGroupRequestUsers setAppUserId(String appUserId) {
            this.appUserId = appUserId;
            return this;
        }
        public String getAppUserId() {
            return this.appUserId;
        }

        public CreateGroupRequestUsers setGroupOwner(Boolean groupOwner) {
            this.groupOwner = groupOwner;
            return this;
        }
        public Boolean getGroupOwner() {
            return this.groupOwner;
        }

        public CreateGroupRequestUsers setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
