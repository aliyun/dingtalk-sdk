// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class UpdateStatusRequest extends TeaModel {
    @NameInMap("importSequence")
    public String importSequence;

    @NameInMap("errorLines")
    public java.util.List<Integer> errorLines;

    @NameInMap("appType")
    public String appType;

    @NameInMap("systemToken")
    public String systemToken;

    @NameInMap("language")
    public String language;

    @NameInMap("userId")
    public String userId;

    @NameInMap("status")
    public String status;

    public static UpdateStatusRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateStatusRequest self = new UpdateStatusRequest();
        return TeaModel.build(map, self);
    }

    public UpdateStatusRequest setImportSequence(String importSequence) {
        this.importSequence = importSequence;
        return this;
    }
    public String getImportSequence() {
        return this.importSequence;
    }

    public UpdateStatusRequest setErrorLines(java.util.List<Integer> errorLines) {
        this.errorLines = errorLines;
        return this;
    }
    public java.util.List<Integer> getErrorLines() {
        return this.errorLines;
    }

    public UpdateStatusRequest setAppType(String appType) {
        this.appType = appType;
        return this;
    }
    public String getAppType() {
        return this.appType;
    }

    public UpdateStatusRequest setSystemToken(String systemToken) {
        this.systemToken = systemToken;
        return this;
    }
    public String getSystemToken() {
        return this.systemToken;
    }

    public UpdateStatusRequest setLanguage(String language) {
        this.language = language;
        return this;
    }
    public String getLanguage() {
        return this.language;
    }

    public UpdateStatusRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public UpdateStatusRequest setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

}
