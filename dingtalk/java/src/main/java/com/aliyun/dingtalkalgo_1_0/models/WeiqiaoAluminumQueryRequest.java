// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalgo_1_0.models;

import com.aliyun.tea.*;

public class WeiqiaoAluminumQueryRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>xxx</p>
     */
    @NameInMap("task_id")
    public String taskId;

    public static WeiqiaoAluminumQueryRequest build(java.util.Map<String, ?> map) throws Exception {
        WeiqiaoAluminumQueryRequest self = new WeiqiaoAluminumQueryRequest();
        return TeaModel.build(map, self);
    }

    public WeiqiaoAluminumQueryRequest setTaskId(String taskId) {
        this.taskId = taskId;
        return this;
    }
    public String getTaskId() {
        return this.taskId;
    }

}
