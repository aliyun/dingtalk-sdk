// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class RestoreRecycleItemResponseBody extends TeaModel {
    /**
     * <p>是否是异步任务</p>
     * <p>如果操作对象有子节点，则会异步处理</p>
     */
    @NameInMap("async")
    public Boolean async;

    /**
     * <p>操作对应根节点还原之后的文件id</p>
     * <p>非失败的情况下同步或者异步都会返回</p>
     */
    @NameInMap("dentryId")
    public String dentryId;

    /**
     * <p>操作对应根节点还原之后的空间id</p>
     * <p>非失败的情况下同步或者异步都会返回</p>
     */
    @NameInMap("spaceId")
    public String spaceId;

    /**
     * <p>异步任务id，用于查询任务执行状态</p>
     */
    @NameInMap("taskId")
    public String taskId;

    public static RestoreRecycleItemResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RestoreRecycleItemResponseBody self = new RestoreRecycleItemResponseBody();
        return TeaModel.build(map, self);
    }

    public RestoreRecycleItemResponseBody setAsync(Boolean async) {
        this.async = async;
        return this;
    }
    public Boolean getAsync() {
        return this.async;
    }

    public RestoreRecycleItemResponseBody setDentryId(String dentryId) {
        this.dentryId = dentryId;
        return this;
    }
    public String getDentryId() {
        return this.dentryId;
    }

    public RestoreRecycleItemResponseBody setSpaceId(String spaceId) {
        this.spaceId = spaceId;
        return this;
    }
    public String getSpaceId() {
        return this.spaceId;
    }

    public RestoreRecycleItemResponseBody setTaskId(String taskId) {
        this.taskId = taskId;
        return this;
    }
    public String getTaskId() {
        return this.taskId;
    }

}
