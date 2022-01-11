// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class GrantPrivilegeOfCustomSpaceRequest extends TeaModel {
    // 权限有效时间
    @NameInMap("duration")
    public Long duration;

    // 授权访问的文件id列表
    @NameInMap("fileIds")
    public java.util.List<String> fileIds;

    // 权限类型
    @NameInMap("type")
    public String type;

    // 用户id
    @NameInMap("unionId")
    public String unionId;

    // 被授予权限的员工id
    @NameInMap("userId")
    public String userId;

    public static GrantPrivilegeOfCustomSpaceRequest build(java.util.Map<String, ?> map) throws Exception {
        GrantPrivilegeOfCustomSpaceRequest self = new GrantPrivilegeOfCustomSpaceRequest();
        return TeaModel.build(map, self);
    }

    public GrantPrivilegeOfCustomSpaceRequest setDuration(Long duration) {
        this.duration = duration;
        return this;
    }
    public Long getDuration() {
        return this.duration;
    }

    public GrantPrivilegeOfCustomSpaceRequest setFileIds(java.util.List<String> fileIds) {
        this.fileIds = fileIds;
        return this;
    }
    public java.util.List<String> getFileIds() {
        return this.fileIds;
    }

    public GrantPrivilegeOfCustomSpaceRequest setType(String type) {
        this.type = type;
        return this;
    }
    public String getType() {
        return this.type;
    }

    public GrantPrivilegeOfCustomSpaceRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public GrantPrivilegeOfCustomSpaceRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
