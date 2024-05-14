// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class ListSpacesResponseBody extends TeaModel {
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("spaces")
    public java.util.List<ListSpacesResponseBodySpaces> spaces;

    public static ListSpacesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListSpacesResponseBody self = new ListSpacesResponseBody();
        return TeaModel.build(map, self);
    }

    public ListSpacesResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public ListSpacesResponseBody setSpaces(java.util.List<ListSpacesResponseBodySpaces> spaces) {
        this.spaces = spaces;
        return this;
    }
    public java.util.List<ListSpacesResponseBodySpaces> getSpaces() {
        return this.spaces;
    }

    public static class ListSpacesResponseBodySpaces extends TeaModel {
        /**
         * <p>Use the UTC time format: yyyy-MM-ddTHH:mmZ</p>
         */
        @NameInMap("createTime")
        public String createTime;

        /**
         * <p>Use the UTC time format: yyyy-MM-ddTHH:mmZ</p>
         */
        @NameInMap("modifyTime")
        public String modifyTime;

        @NameInMap("permissionMode")
        public String permissionMode;

        @NameInMap("quota")
        public Long quota;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("spaceId")
        public String spaceId;

        @NameInMap("spaceName")
        public String spaceName;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("spaceType")
        public String spaceType;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("usedQuota")
        public Long usedQuota;

        public static ListSpacesResponseBodySpaces build(java.util.Map<String, ?> map) throws Exception {
            ListSpacesResponseBodySpaces self = new ListSpacesResponseBodySpaces();
            return TeaModel.build(map, self);
        }

        public ListSpacesResponseBodySpaces setCreateTime(String createTime) {
            this.createTime = createTime;
            return this;
        }
        public String getCreateTime() {
            return this.createTime;
        }

        public ListSpacesResponseBodySpaces setModifyTime(String modifyTime) {
            this.modifyTime = modifyTime;
            return this;
        }
        public String getModifyTime() {
            return this.modifyTime;
        }

        public ListSpacesResponseBodySpaces setPermissionMode(String permissionMode) {
            this.permissionMode = permissionMode;
            return this;
        }
        public String getPermissionMode() {
            return this.permissionMode;
        }

        public ListSpacesResponseBodySpaces setQuota(Long quota) {
            this.quota = quota;
            return this;
        }
        public Long getQuota() {
            return this.quota;
        }

        public ListSpacesResponseBodySpaces setSpaceId(String spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public String getSpaceId() {
            return this.spaceId;
        }

        public ListSpacesResponseBodySpaces setSpaceName(String spaceName) {
            this.spaceName = spaceName;
            return this;
        }
        public String getSpaceName() {
            return this.spaceName;
        }

        public ListSpacesResponseBodySpaces setSpaceType(String spaceType) {
            this.spaceType = spaceType;
            return this;
        }
        public String getSpaceType() {
            return this.spaceType;
        }

        public ListSpacesResponseBodySpaces setUsedQuota(Long usedQuota) {
            this.usedQuota = usedQuota;
            return this;
        }
        public Long getUsedQuota() {
            return this.usedQuota;
        }

    }

}
