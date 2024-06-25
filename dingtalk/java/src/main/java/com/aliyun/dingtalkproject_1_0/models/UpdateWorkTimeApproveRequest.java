// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class UpdateWorkTimeApproveRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>2023-04-04T00:00:00.000Z</p>
     */
    @NameInMap("finishTime")
    public String finishTime;

    /**
     * <strong>example:</strong>
     * <p>1233</p>
     */
    @NameInMap("instanceId")
    public String instanceId;

    /**
     * <strong>example:</strong>
     * <p>NEW</p>
     */
    @NameInMap("status")
    public String status;

    /**
     * <strong>example:</strong>
     * <p>2023-04-04T00:00:00.000Z</p>
     */
    @NameInMap("submitTime")
    public String submitTime;

    /**
     * <strong>example:</strong>
     * <p>xxxx 用工申请</p>
     */
    @NameInMap("title")
    public String title;

    /**
     * <strong>example:</strong>
     * <p><a href="https://xxxbpms.xxx/xxxx">https://xxxbpms.xxx/xxxx</a></p>
     */
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
