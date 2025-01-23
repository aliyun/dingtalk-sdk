// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkflashmeeting_1_0.models;

import com.aliyun.tea.*;

public class ExportShanhuiToDocRequest extends TeaModel {
    @NameInMap("contentEnums")
    public java.util.List<String> contentEnums;

    @NameInMap("parentNodeKey")
    public String parentNodeKey;

    @NameInMap("shanhuiKey")
    public String shanhuiKey;

    @NameInMap("userId")
    public String userId;

    @NameInMap("workspaceKey")
    public String workspaceKey;

    public static ExportShanhuiToDocRequest build(java.util.Map<String, ?> map) throws Exception {
        ExportShanhuiToDocRequest self = new ExportShanhuiToDocRequest();
        return TeaModel.build(map, self);
    }

    public ExportShanhuiToDocRequest setContentEnums(java.util.List<String> contentEnums) {
        this.contentEnums = contentEnums;
        return this;
    }
    public java.util.List<String> getContentEnums() {
        return this.contentEnums;
    }

    public ExportShanhuiToDocRequest setParentNodeKey(String parentNodeKey) {
        this.parentNodeKey = parentNodeKey;
        return this;
    }
    public String getParentNodeKey() {
        return this.parentNodeKey;
    }

    public ExportShanhuiToDocRequest setShanhuiKey(String shanhuiKey) {
        this.shanhuiKey = shanhuiKey;
        return this;
    }
    public String getShanhuiKey() {
        return this.shanhuiKey;
    }

    public ExportShanhuiToDocRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public ExportShanhuiToDocRequest setWorkspaceKey(String workspaceKey) {
        this.workspaceKey = workspaceKey;
        return this;
    }
    public String getWorkspaceKey() {
        return this.workspaceKey;
    }

}
