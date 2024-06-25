// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class RestoreRecycleItemResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("async")
    public Boolean async;

    /**
     * <strong>example:</strong>
     * <p>dentry_id</p>
     */
    @NameInMap("dentryId")
    public String dentryId;

    /**
     * <strong>example:</strong>
     * <p>space_id</p>
     */
    @NameInMap("spaceId")
    public String spaceId;

    /**
     * <strong>example:</strong>
     * <p>task_id</p>
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
