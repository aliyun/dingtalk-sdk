// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class ManagementListSpacesResponseBody extends TeaModel {
    @NameInMap("spaces")
    public java.util.List<ManagementListSpacesResponseBodySpaces> spaces;

    public static ManagementListSpacesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ManagementListSpacesResponseBody self = new ManagementListSpacesResponseBody();
        return TeaModel.build(map, self);
    }

    public ManagementListSpacesResponseBody setSpaces(java.util.List<ManagementListSpacesResponseBodySpaces> spaces) {
        this.spaces = spaces;
        return this;
    }
    public java.util.List<ManagementListSpacesResponseBodySpaces> getSpaces() {
        return this.spaces;
    }

    public static class ManagementListSpacesResponseBodySpaces extends TeaModel {
        // 空间id
        @NameInMap("spaceId")
        public String spaceId;

        // 空间名称
        @NameInMap("spaceName")
        public String spaceName;

        // 空间类型
        @NameInMap("spaceType")
        public String spaceType;

        // 空间总额度
        @NameInMap("quota")
        public Long quota;

        // 空间已使用额度
        @NameInMap("usedQuota")
        public Long usedQuota;

        // 授权模式
        @NameInMap("permissionMode")
        public String permissionMode;

        // 创建时间
        @NameInMap("createTime")
        public String createTime;

        // 修改时间
        @NameInMap("modifyTime")
        public String modifyTime;

        public static ManagementListSpacesResponseBodySpaces build(java.util.Map<String, ?> map) throws Exception {
            ManagementListSpacesResponseBodySpaces self = new ManagementListSpacesResponseBodySpaces();
            return TeaModel.build(map, self);
        }

        public ManagementListSpacesResponseBodySpaces setSpaceId(String spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public String getSpaceId() {
            return this.spaceId;
        }

        public ManagementListSpacesResponseBodySpaces setSpaceName(String spaceName) {
            this.spaceName = spaceName;
            return this;
        }
        public String getSpaceName() {
            return this.spaceName;
        }

        public ManagementListSpacesResponseBodySpaces setSpaceType(String spaceType) {
            this.spaceType = spaceType;
            return this;
        }
        public String getSpaceType() {
            return this.spaceType;
        }

        public ManagementListSpacesResponseBodySpaces setQuota(Long quota) {
            this.quota = quota;
            return this;
        }
        public Long getQuota() {
            return this.quota;
        }

        public ManagementListSpacesResponseBodySpaces setUsedQuota(Long usedQuota) {
            this.usedQuota = usedQuota;
            return this;
        }
        public Long getUsedQuota() {
            return this.usedQuota;
        }

        public ManagementListSpacesResponseBodySpaces setPermissionMode(String permissionMode) {
            this.permissionMode = permissionMode;
            return this;
        }
        public String getPermissionMode() {
            return this.permissionMode;
        }

        public ManagementListSpacesResponseBodySpaces setCreateTime(String createTime) {
            this.createTime = createTime;
            return this;
        }
        public String getCreateTime() {
            return this.createTime;
        }

        public ManagementListSpacesResponseBodySpaces setModifyTime(String modifyTime) {
            this.modifyTime = modifyTime;
            return this;
        }
        public String getModifyTime() {
            return this.modifyTime;
        }

    }

}
