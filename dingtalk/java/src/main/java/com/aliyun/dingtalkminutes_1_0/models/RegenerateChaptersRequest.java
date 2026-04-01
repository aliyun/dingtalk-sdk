// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class RegenerateChaptersRequest extends TeaModel {
    @NameInMap("customPrompt")
    public String customPrompt;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("taskUuid")
    public String taskUuid;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>lJcRnm39OsU4jlFVmRGXXXXX</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static RegenerateChaptersRequest build(java.util.Map<String, ?> map) throws Exception {
        RegenerateChaptersRequest self = new RegenerateChaptersRequest();
        return TeaModel.build(map, self);
    }

    public RegenerateChaptersRequest setCustomPrompt(String customPrompt) {
        this.customPrompt = customPrompt;
        return this;
    }
    public String getCustomPrompt() {
        return this.customPrompt;
    }

    public RegenerateChaptersRequest setTaskUuid(String taskUuid) {
        this.taskUuid = taskUuid;
        return this;
    }
    public String getTaskUuid() {
        return this.taskUuid;
    }

    public RegenerateChaptersRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
