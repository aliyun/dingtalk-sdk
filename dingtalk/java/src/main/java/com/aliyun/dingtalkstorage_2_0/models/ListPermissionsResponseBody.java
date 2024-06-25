// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_2_0.models;

import com.aliyun.tea.*;

public class ListPermissionsResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>next_token</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("permissions")
    public java.util.List<ListPermissionsResponseBodyPermissions> permissions;

    public static ListPermissionsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListPermissionsResponseBody self = new ListPermissionsResponseBody();
        return TeaModel.build(map, self);
    }

    public ListPermissionsResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public ListPermissionsResponseBody setPermissions(java.util.List<ListPermissionsResponseBodyPermissions> permissions) {
        this.permissions = permissions;
        return this;
    }
    public java.util.List<ListPermissionsResponseBodyPermissions> getPermissions() {
        return this.permissions;
    }

    public static class ListPermissionsResponseBodyPermissionsMember extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>corp_id</p>
         */
        @NameInMap("corpId")
        public String corpId;

        /**
         * <strong>example:</strong>
         * <p>member_id</p>
         */
        @NameInMap("id")
        public String id;

        /**
         * <strong>example:</strong>
         * <p>USER</p>
         */
        @NameInMap("type")
        public String type;

        public static ListPermissionsResponseBodyPermissionsMember build(java.util.Map<String, ?> map) throws Exception {
            ListPermissionsResponseBodyPermissionsMember self = new ListPermissionsResponseBodyPermissionsMember();
            return TeaModel.build(map, self);
        }

        public ListPermissionsResponseBodyPermissionsMember setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public ListPermissionsResponseBodyPermissionsMember setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public ListPermissionsResponseBodyPermissionsMember setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class ListPermissionsResponseBodyPermissionsRole extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>MANAGER</p>
         */
        @NameInMap("id")
        public String id;

        /**
         * <strong>example:</strong>
         * <p>MANAGER</p>
         */
        @NameInMap("name")
        public String name;

        public static ListPermissionsResponseBodyPermissionsRole build(java.util.Map<String, ?> map) throws Exception {
            ListPermissionsResponseBodyPermissionsRole self = new ListPermissionsResponseBodyPermissionsRole();
            return TeaModel.build(map, self);
        }

        public ListPermissionsResponseBodyPermissionsRole setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public ListPermissionsResponseBodyPermissionsRole setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

    public static class ListPermissionsResponseBodyPermissions extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>space_id</p>
         */
        @NameInMap("dentryUuid")
        public String dentryUuid;

        /**
         * <strong>example:</strong>
         * <p>3600</p>
         */
        @NameInMap("duration")
        public Long duration;

        @NameInMap("member")
        public ListPermissionsResponseBodyPermissionsMember member;

        @NameInMap("role")
        public ListPermissionsResponseBodyPermissionsRole role;

        public static ListPermissionsResponseBodyPermissions build(java.util.Map<String, ?> map) throws Exception {
            ListPermissionsResponseBodyPermissions self = new ListPermissionsResponseBodyPermissions();
            return TeaModel.build(map, self);
        }

        public ListPermissionsResponseBodyPermissions setDentryUuid(String dentryUuid) {
            this.dentryUuid = dentryUuid;
            return this;
        }
        public String getDentryUuid() {
            return this.dentryUuid;
        }

        public ListPermissionsResponseBodyPermissions setDuration(Long duration) {
            this.duration = duration;
            return this;
        }
        public Long getDuration() {
            return this.duration;
        }

        public ListPermissionsResponseBodyPermissions setMember(ListPermissionsResponseBodyPermissionsMember member) {
            this.member = member;
            return this;
        }
        public ListPermissionsResponseBodyPermissionsMember getMember() {
            return this.member;
        }

        public ListPermissionsResponseBodyPermissions setRole(ListPermissionsResponseBodyPermissionsRole role) {
            this.role = role;
            return this;
        }
        public ListPermissionsResponseBodyPermissionsRole getRole() {
            return this.role;
        }

    }

}
