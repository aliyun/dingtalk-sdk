// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SubmitTaskPackageResponseBody extends TeaModel {
    @NameInMap("taskIdList")
    public java.util.List<String> taskIdList;

    @NameInMap("taskPackageId")
    public String taskPackageId;

    public static SubmitTaskPackageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SubmitTaskPackageResponseBody self = new SubmitTaskPackageResponseBody();
        return TeaModel.build(map, self);
    }

    public SubmitTaskPackageResponseBody setTaskIdList(java.util.List<String> taskIdList) {
        this.taskIdList = taskIdList;
        return this;
    }
    public java.util.List<String> getTaskIdList() {
        return this.taskIdList;
    }

    public SubmitTaskPackageResponseBody setTaskPackageId(String taskPackageId) {
        this.taskPackageId = taskPackageId;
        return this;
    }
    public String getTaskPackageId() {
        return this.taskPackageId;
    }

}
