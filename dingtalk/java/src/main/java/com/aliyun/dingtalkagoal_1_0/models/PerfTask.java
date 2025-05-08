// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class PerfTask extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>328497234</p>
     */
    @NameInMap("id")
    public String id;

    /**
     * <strong>example:</strong>
     * <p>y/n</p>
     */
    @NameInMap("isDeleted")
    public String isDeleted;

    /**
     * <strong>example:</strong>
     * <p>ONGOING</p>
     */
    @NameInMap("status")
    public String status;

    /**
     * <strong>example:</strong>
     * <p>xxx考核任务</p>
     */
    @NameInMap("title")
    public String title;

    /**
     * <strong>example:</strong>
     * <p>23223423</p>
     */
    @NameInMap("userId")
    public String userId;

    public static PerfTask build(java.util.Map<String, ?> map) throws Exception {
        PerfTask self = new PerfTask();
        return TeaModel.build(map, self);
    }

    public PerfTask setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

    public PerfTask setIsDeleted(String isDeleted) {
        this.isDeleted = isDeleted;
        return this;
    }
    public String getIsDeleted() {
        return this.isDeleted;
    }

    public PerfTask setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

    public PerfTask setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public PerfTask setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
