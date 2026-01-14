// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkflashmeeting_1_0.models;

import com.aliyun.tea.*;

public class CopyLinkToWorkspaceRequest extends TeaModel {
    @NameInMap("parentNodeKey")
    public String parentNodeKey;

    @NameInMap("shanhuiKey")
    public String shanhuiKey;

    @NameInMap("userId")
    public String userId;

    @NameInMap("workspaceKey")
    public String workspaceKey;

    public static CopyLinkToWorkspaceRequest build(java.util.Map<String, ?> map) throws Exception {
        CopyLinkToWorkspaceRequest self = new CopyLinkToWorkspaceRequest();
        return TeaModel.build(map, self);
    }

    public CopyLinkToWorkspaceRequest setParentNodeKey(String parentNodeKey) {
        this.parentNodeKey = parentNodeKey;
        return this;
    }
    public String getParentNodeKey() {
        return this.parentNodeKey;
    }

    public CopyLinkToWorkspaceRequest setShanhuiKey(String shanhuiKey) {
        this.shanhuiKey = shanhuiKey;
        return this;
    }
    public String getShanhuiKey() {
        return this.shanhuiKey;
    }

    public CopyLinkToWorkspaceRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public CopyLinkToWorkspaceRequest setWorkspaceKey(String workspaceKey) {
        this.workspaceKey = workspaceKey;
        return this;
    }
    public String getWorkspaceKey() {
        return this.workspaceKey;
    }

}
