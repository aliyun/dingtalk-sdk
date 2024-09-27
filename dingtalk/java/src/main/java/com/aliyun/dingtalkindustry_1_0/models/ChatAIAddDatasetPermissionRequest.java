// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class ChatAIAddDatasetPermissionRequest extends TeaModel {
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

    public static ChatAIAddDatasetPermissionRequest build(java.util.Map<String, ?> map) throws Exception {
        ChatAIAddDatasetPermissionRequest self = new ChatAIAddDatasetPermissionRequest();
        return TeaModel.build(map, self);
    }

    public ChatAIAddDatasetPermissionRequest setAuthorizationType(String authorizationType) {
        this.authorizationType = authorizationType;
        return this;
    }
    public String getAuthorizationType() {
        return this.authorizationType;
    }

    public ChatAIAddDatasetPermissionRequest setAuthorizedObjectId(java.util.List<String> authorizedObjectId) {
        this.authorizedObjectId = authorizedObjectId;
        return this;
    }
    public java.util.List<String> getAuthorizedObjectId() {
        return this.authorizedObjectId;
    }

    public ChatAIAddDatasetPermissionRequest setDatasetId(Long datasetId) {
        this.datasetId = datasetId;
        return this;
    }
    public Long getDatasetId() {
        return this.datasetId;
    }

    public ChatAIAddDatasetPermissionRequest setOptUser(String optUser) {
        this.optUser = optUser;
        return this;
    }
    public String getOptUser() {
        return this.optUser;
    }

}
