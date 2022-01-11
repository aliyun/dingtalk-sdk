// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class ListSpacesResponseBody extends TeaModel {
    // 分页加载更多锚点, nextToken不为空表示有更多数据
    @NameInMap("nextToken")
    public String nextToken;

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
        // 创建时间
        @NameInMap("createTime")
        public String createTime;

        // 修改时间
        @NameInMap("modifyTime")
        public String modifyTime;

        // 授权模式
        @NameInMap("permissionMode")
        public String permissionMode;

        // 空间总额度
        @NameInMap("quota")
        public Long quota;

        // 空间id
        @NameInMap("spaceId")
        public String spaceId;

        // 空间名称
        @NameInMap("spaceName")
        public String spaceName;

        // 空间类型
        @NameInMap("spaceType")
        public String spaceType;

        // 空间已使用额度
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

    public static class ManagementListSpacesResponseBodySpaces extends TeaModel {
        // 创建时间
        @NameInMap("createTime")
        public String createTime;

        // 修改时间
        @NameInMap("modifyTime")
        public String modifyTime;

        // 授权模式
        @NameInMap("permissionMode")
        public String permissionMode;

        // 空间总额度
        @NameInMap("quota")
        public Long quota;

        // 空间id
        @NameInMap("spaceId")
        public String spaceId;

        // 空间名称
        @NameInMap("spaceName")
        public String spaceName;

        // 空间类型
        @NameInMap("spaceType")
        public String spaceType;

        // 空间已使用额度
        @NameInMap("usedQuota")
        public Long usedQuota;

        public static ManagementListSpacesResponseBodySpaces build(java.util.Map<String, ?> map) throws Exception {
            ManagementListSpacesResponseBodySpaces self = new ManagementListSpacesResponseBodySpaces();
            return TeaModel.build(map, self);
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

        public ManagementListSpacesResponseBodySpaces setPermissionMode(String permissionMode) {
            this.permissionMode = permissionMode;
            return this;
        }
        public String getPermissionMode() {
            return this.permissionMode;
        }

        public ManagementListSpacesResponseBodySpaces setQuota(Long quota) {
            this.quota = quota;
            return this;
        }
        public Long getQuota() {
            return this.quota;
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

        public ManagementListSpacesResponseBodySpaces setUsedQuota(Long usedQuota) {
            this.usedQuota = usedQuota;
            return this;
        }
        public Long getUsedQuota() {
            return this.usedQuota;
        }

    }

}
