// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class ManagementModifySpaceResponseBody extends TeaModel {
    /**
     * <p>空间列表</p>
     */
    @NameInMap("spaces")
    public java.util.List<ManagementModifySpaceResponseBodySpaces> spaces;

    public static ManagementModifySpaceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ManagementModifySpaceResponseBody self = new ManagementModifySpaceResponseBody();
        return TeaModel.build(map, self);
    }

    public ManagementModifySpaceResponseBody setSpaces(java.util.List<ManagementModifySpaceResponseBodySpaces> spaces) {
        this.spaces = spaces;
        return this;
    }
    public java.util.List<ManagementModifySpaceResponseBodySpaces> getSpaces() {
        return this.spaces;
    }

    public static class ManagementModifySpaceResponseBodySpaces extends TeaModel {
        /**
         * <p>创建时间</p>
         */
        @NameInMap("createTime")
        public String createTime;

        /**
         * <p>修改时间</p>
         */
        @NameInMap("modifyTime")
        public String modifyTime;

        /**
         * <p>授权模式</p>
         */
        @NameInMap("permissionMode")
        public String permissionMode;

        /**
         * <p>空间总额度</p>
         */
        @NameInMap("quota")
        public Long quota;

        /**
         * <p>空间id</p>
         */
        @NameInMap("spaceId")
        public String spaceId;

        /**
         * <p>空间名称</p>
         */
        @NameInMap("spaceName")
        public String spaceName;

        /**
         * <p>空间类型</p>
         */
        @NameInMap("spaceType")
        public String spaceType;

        /**
         * <p>空间已使用额度</p>
         */
        @NameInMap("usedQuota")
        public Long usedQuota;

        public static ManagementModifySpaceResponseBodySpaces build(java.util.Map<String, ?> map) throws Exception {
            ManagementModifySpaceResponseBodySpaces self = new ManagementModifySpaceResponseBodySpaces();
            return TeaModel.build(map, self);
        }

        public ManagementModifySpaceResponseBodySpaces setCreateTime(String createTime) {
            this.createTime = createTime;
            return this;
        }
        public String getCreateTime() {
            return this.createTime;
        }

        public ManagementModifySpaceResponseBodySpaces setModifyTime(String modifyTime) {
            this.modifyTime = modifyTime;
            return this;
        }
        public String getModifyTime() {
            return this.modifyTime;
        }

        public ManagementModifySpaceResponseBodySpaces setPermissionMode(String permissionMode) {
            this.permissionMode = permissionMode;
            return this;
        }
        public String getPermissionMode() {
            return this.permissionMode;
        }

        public ManagementModifySpaceResponseBodySpaces setQuota(Long quota) {
            this.quota = quota;
            return this;
        }
        public Long getQuota() {
            return this.quota;
        }

        public ManagementModifySpaceResponseBodySpaces setSpaceId(String spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public String getSpaceId() {
            return this.spaceId;
        }

        public ManagementModifySpaceResponseBodySpaces setSpaceName(String spaceName) {
            this.spaceName = spaceName;
            return this;
        }
        public String getSpaceName() {
            return this.spaceName;
        }

        public ManagementModifySpaceResponseBodySpaces setSpaceType(String spaceType) {
            this.spaceType = spaceType;
            return this;
        }
        public String getSpaceType() {
            return this.spaceType;
        }

        public ManagementModifySpaceResponseBodySpaces setUsedQuota(Long usedQuota) {
            this.usedQuota = usedQuota;
            return this;
        }
        public Long getUsedQuota() {
            return this.usedQuota;
        }

    }

}
