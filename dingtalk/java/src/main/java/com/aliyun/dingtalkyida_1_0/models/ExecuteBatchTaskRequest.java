// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class ExecuteBatchTaskRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>APP_XCE0EVXS6DYG3YDYC5RD</p>
     */
    @NameInMap("appType")
    public String appType;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>备选值：agree/disagree</p>
     */
    @NameInMap("outResult")
    public String outResult;

    /**
     * <strong>example:</strong>
     * <p>OK</p>
     */
    @NameInMap("remark")
    public String remark;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>09866181UTZVVD4R3DC955FNKIM52HVPU5WWK7</p>
     */
    @NameInMap("systemToken")
    public String systemToken;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>[{&quot;taskId&quot;:&quot;2267855699&quot;,&quot;formInstId&quot;:&quot;4d226eb1-1f4e-4348-a9cc-616477c3daa6&quot;},{&quot;taskId&quot;:&quot;2267855700&quot;,&quot;formInstId&quot;:&quot;905a922e-da05-4ef9-ba1c-db9ad60bbe60&quot;}]</p>
     */
    @NameInMap("taskInformationList")
    public String taskInformationList;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>ding173982232112232</p>
     */
    @NameInMap("userId")
    public String userId;

    public static ExecuteBatchTaskRequest build(java.util.Map<String, ?> map) throws Exception {
        ExecuteBatchTaskRequest self = new ExecuteBatchTaskRequest();
        return TeaModel.build(map, self);
    }

    public ExecuteBatchTaskRequest setAppType(String appType) {
        this.appType = appType;
        return this;
    }
    public String getAppType() {
        return this.appType;
    }

    public ExecuteBatchTaskRequest setOutResult(String outResult) {
        this.outResult = outResult;
        return this;
    }
    public String getOutResult() {
        return this.outResult;
    }

    public ExecuteBatchTaskRequest setRemark(String remark) {
        this.remark = remark;
        return this;
    }
    public String getRemark() {
        return this.remark;
    }

    public ExecuteBatchTaskRequest setSystemToken(String systemToken) {
        this.systemToken = systemToken;
        return this;
    }
    public String getSystemToken() {
        return this.systemToken;
    }

    public ExecuteBatchTaskRequest setTaskInformationList(String taskInformationList) {
        this.taskInformationList = taskInformationList;
        return this;
    }
    public String getTaskInformationList() {
        return this.taskInformationList;
    }

    public ExecuteBatchTaskRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
