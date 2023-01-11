// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class AddPermissionRequest extends TeaModel {
    /**
     * <p>权限成员列表</p>
     * <p>最大size:</p>
     * <p>	30</p>
     */
    @NameInMap("members")
    public java.util.List<AddPermissionRequestMembers> members;

    /**
     * <p>可选参数</p>
     */
    @NameInMap("option")
    public AddPermissionRequestOption option;

    /**
     * <p>权限角色id</p>
     */
    @NameInMap("roleId")
    public String roleId;

    /**
     * <p>用户id</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static AddPermissionRequest build(java.util.Map<String, ?> map) throws Exception {
        AddPermissionRequest self = new AddPermissionRequest();
        return TeaModel.build(map, self);
    }

    public AddPermissionRequest setMembers(java.util.List<AddPermissionRequestMembers> members) {
        this.members = members;
        return this;
    }
    public java.util.List<AddPermissionRequestMembers> getMembers() {
        return this.members;
    }

    public AddPermissionRequest setOption(AddPermissionRequestOption option) {
        this.option = option;
        return this;
    }
    public AddPermissionRequestOption getOption() {
        return this.option;
    }

    public AddPermissionRequest setRoleId(String roleId) {
        this.roleId = roleId;
        return this;
    }
    public String getRoleId() {
        return this.roleId;
    }

    public AddPermissionRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public static class AddPermissionRequestMembers extends TeaModel {
        /**
         * <p>权限归属的企业</p>
         * <p>如果存在企业id, 对应member离职的时候会自动清理权限</p>
         * <p>如果memberType是dept类型，必须要有企业id</p>
         */
        @NameInMap("corpId")
        public String corpId;

        /**
         * <p>权限成员id</p>
         */
        @NameInMap("id")
        public String id;

        /**
         * <p>权限成员类型</p>
         * <p>枚举值:</p>
         * <p>	ORG: 企业</p>
         * <p>	DEPT: 部门</p>
         * <p>	TAG: 自定义tag</p>
         * <p>	CONVERSATION: 会话</p>
         * <p>	GG: 通用组</p>
         * <p>	USER: 用户</p>
         * <p>	ALL_USERS: 所有用户</p>
         */
        @NameInMap("type")
        public String type;

        public static AddPermissionRequestMembers build(java.util.Map<String, ?> map) throws Exception {
            AddPermissionRequestMembers self = new AddPermissionRequestMembers();
            return TeaModel.build(map, self);
        }

        public AddPermissionRequestMembers setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public AddPermissionRequestMembers setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public AddPermissionRequestMembers setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class AddPermissionRequestOption extends TeaModel {
        /**
         * <p>有效时间(秒)</p>
         * <p>最大值:</p>
         * <p>	3600</p>
         */
        @NameInMap("duration")
        public Long duration;

        public static AddPermissionRequestOption build(java.util.Map<String, ?> map) throws Exception {
            AddPermissionRequestOption self = new AddPermissionRequestOption();
            return TeaModel.build(map, self);
        }

        public AddPermissionRequestOption setDuration(Long duration) {
            this.duration = duration;
            return this;
        }
        public Long getDuration() {
            return this.duration;
        }

    }

}
