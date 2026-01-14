// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetPrivateStoreFileTaskInfosByPageRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("pageNumber")
    public Integer pageNumber;

    /**
     * <strong>example:</strong>
     * <p>20</p>
     */
    @NameInMap("pageSize")
    public Integer pageSize;

    /**
     * <strong>example:</strong>
     * <p>初始化完毕 0 正在删除 1 删除完成 2 正在回滚 3 回滚完成 4 数据初始化中 5  任务状态异常 6  待删除 7</p>
     */
    @NameInMap("taskStatus")
    public Integer taskStatus;

    public static GetPrivateStoreFileTaskInfosByPageRequest build(java.util.Map<String, ?> map) throws Exception {
        GetPrivateStoreFileTaskInfosByPageRequest self = new GetPrivateStoreFileTaskInfosByPageRequest();
        return TeaModel.build(map, self);
    }

    public GetPrivateStoreFileTaskInfosByPageRequest setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public GetPrivateStoreFileTaskInfosByPageRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public GetPrivateStoreFileTaskInfosByPageRequest setTaskStatus(Integer taskStatus) {
        this.taskStatus = taskStatus;
        return this;
    }
    public Integer getTaskStatus() {
        return this.taskStatus;
    }

}
