// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class EmployeeAttachmentUpdateRequest extends TeaModel {
    @NameInMap("appAgentId")
    public Long appAgentId;

    @NameInMap("fieldCode")
    public String fieldCode;

    @NameInMap("fileSuffix")
    public String fileSuffix;

    @NameInMap("mediaId")
    public String mediaId;

    @NameInMap("userId")
    public String userId;

    public static EmployeeAttachmentUpdateRequest build(java.util.Map<String, ?> map) throws Exception {
        EmployeeAttachmentUpdateRequest self = new EmployeeAttachmentUpdateRequest();
        return TeaModel.build(map, self);
    }

    public EmployeeAttachmentUpdateRequest setAppAgentId(Long appAgentId) {
        this.appAgentId = appAgentId;
        return this;
    }
    public Long getAppAgentId() {
        return this.appAgentId;
    }

    public EmployeeAttachmentUpdateRequest setFieldCode(String fieldCode) {
        this.fieldCode = fieldCode;
        return this;
    }
    public String getFieldCode() {
        return this.fieldCode;
    }

    public EmployeeAttachmentUpdateRequest setFileSuffix(String fileSuffix) {
        this.fileSuffix = fileSuffix;
        return this;
    }
    public String getFileSuffix() {
        return this.fileSuffix;
    }

    public EmployeeAttachmentUpdateRequest setMediaId(String mediaId) {
        this.mediaId = mediaId;
        return this;
    }
    public String getMediaId() {
        return this.mediaId;
    }

    public EmployeeAttachmentUpdateRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
