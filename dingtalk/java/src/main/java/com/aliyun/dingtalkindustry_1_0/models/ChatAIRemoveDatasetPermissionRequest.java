// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class ChatAIRemoveDatasetPermissionRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>user</p>
     */
    @NameInMap("authorizationType")
    public String authorizationType;

    @NameInMap("authorizedObjectId")
    public java.util.List<String> authorizedObjectId;

    @NameInMap("datasetId")
    public Long datasetId;

    /**
     * <strong>example:</strong>
     * <p>操作人id</p>
     */
    @NameInMap("optUser")
    public String optUser;

    public static ChatAIRemoveDatasetPermissionRequest build(java.util.Map<String, ?> map) throws Exception {
        ChatAIRemoveDatasetPermissionRequest self = new ChatAIRemoveDatasetPermissionRequest();
        return TeaModel.build(map, self);
    }

    public ChatAIRemoveDatasetPermissionRequest setAuthorizationType(String authorizationType) {
        this.authorizationType = authorizationType;
        return this;
    }
    public String getAuthorizationType() {
        return this.authorizationType;
    }

    public ChatAIRemoveDatasetPermissionRequest setAuthorizedObjectId(java.util.List<String> authorizedObjectId) {
        this.authorizedObjectId = authorizedObjectId;
        return this;
    }
    public java.util.List<String> getAuthorizedObjectId() {
        return this.authorizedObjectId;
    }

    public ChatAIRemoveDatasetPermissionRequest setDatasetId(Long datasetId) {
        this.datasetId = datasetId;
        return this;
    }
    public Long getDatasetId() {
        return this.datasetId;
    }

    public ChatAIRemoveDatasetPermissionRequest setOptUser(String optUser) {
        this.optUser = optUser;
        return this;
    }
    public String getOptUser() {
        return this.optUser;
    }

}
