// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class UpdateWorkTimeApproveRequest extends TeaModel {
    @NameInMap("finishTime")
    public String finishTime;

    @NameInMap("instanceId")
    public String instanceId;

    @NameInMap("status")
    public String status;

    @NameInMap("submitTime")
    public String submitTime;

    @NameInMap("title")
    public String title;

    @NameInMap("url")
    public String url;

    public static UpdateWorkTimeApproveRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateWorkTimeApproveRequest self = new UpdateWorkTimeApproveRequest();
        return TeaModel.build(map, self);
    }

    public UpdateWorkTimeApproveRequest setFinishTime(String finishTime) {
        this.finishTime = finishTime;
        return this;
    }
    public String getFinishTime() {
        return this.finishTime;
    }

    public UpdateWorkTimeApproveRequest setInstanceId(String instanceId) {
        this.instanceId = instanceId;
        return this;
    }
    public String getInstanceId() {
        return this.instanceId;
    }

    public UpdateWorkTimeApproveRequest setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

    public UpdateWorkTimeApproveRequest setSubmitTime(String submitTime) {
        this.submitTime = submitTime;
        return this;
    }
    public String getSubmitTime() {
        return this.submitTime;
    }

    public UpdateWorkTimeApproveRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public UpdateWorkTimeApproveRequest setUrl(String url) {
        this.url = url;
        return this;
    }
    public String getUrl() {
        return this.url;
    }

}
