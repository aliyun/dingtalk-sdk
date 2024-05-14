// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_2_0.models;

import com.aliyun.tea.*;

public class GetExecuteUrlRequest extends TeaModel {
    @NameInMap("account")
    public String account;

    @NameInMap("signContainer")
    public Integer signContainer;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("taskId")
    public String taskId;

    public static GetExecuteUrlRequest build(java.util.Map<String, ?> map) throws Exception {
        GetExecuteUrlRequest self = new GetExecuteUrlRequest();
        return TeaModel.build(map, self);
    }

    public GetExecuteUrlRequest setAccount(String account) {
        this.account = account;
        return this;
    }
    public String getAccount() {
        return this.account;
    }

    public GetExecuteUrlRequest setSignContainer(Integer signContainer) {
        this.signContainer = signContainer;
        return this;
    }
    public Integer getSignContainer() {
        return this.signContainer;
    }

    public GetExecuteUrlRequest setTaskId(String taskId) {
        this.taskId = taskId;
        return this;
    }
    public String getTaskId() {
        return this.taskId;
    }

}
