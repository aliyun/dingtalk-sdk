// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class ChatAiQueryLogsRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>123</p>
     */
    @NameInMap("appId")
    public Long appId;

    /**
     * <strong>example:</strong>
     * <p>1744124223000</p>
     */
    @NameInMap("endTime")
    public Long endTime;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("pageNumber")
    public Long pageNumber;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>20</p>
     */
    @NameInMap("pageSize")
    public Long pageSize;

    /**
     * <strong>example:</strong>
     * <p>123</p>
     */
    @NameInMap("scenceId")
    public Long scenceId;

    /**
     * <strong>example:</strong>
     * <p>1744124223000</p>
     */
    @NameInMap("startTime")
    public Long startTime;

    public static ChatAiQueryLogsRequest build(java.util.Map<String, ?> map) throws Exception {
        ChatAiQueryLogsRequest self = new ChatAiQueryLogsRequest();
        return TeaModel.build(map, self);
    }

    public ChatAiQueryLogsRequest setAppId(Long appId) {
        this.appId = appId;
        return this;
    }
    public Long getAppId() {
        return this.appId;
    }

    public ChatAiQueryLogsRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public ChatAiQueryLogsRequest setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public ChatAiQueryLogsRequest setPageSize(Long pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Long getPageSize() {
        return this.pageSize;
    }

    public ChatAiQueryLogsRequest setScenceId(Long scenceId) {
        this.scenceId = scenceId;
        return this;
    }
    public Long getScenceId() {
        return this.scenceId;
    }

    public ChatAiQueryLogsRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

}
