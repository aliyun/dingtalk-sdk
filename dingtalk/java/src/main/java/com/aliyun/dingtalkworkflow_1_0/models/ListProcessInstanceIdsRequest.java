// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class ListProcessInstanceIdsRequest extends TeaModel {
    /**
     * <p>审批实例结束时间，Unix时间戳，单位毫秒。  例如：获取审批单发起时间在2020.4.10-2020.4.14之间审批单，该值传2020.4.14 23:59:59对应的时间戳1586879999000。</p>
     */
    @NameInMap("endTime")
    public Long endTime;

    /**
     * <p>分页参数，每页大小，最多传20。</p>
     */
    @NameInMap("maxResults")
    public Long maxResults;

    /**
     * <p>分页查询的游标，最开始传0，后续传返回参数中的nextToken值。</p>
     */
    @NameInMap("nextToken")
    public Long nextToken;

    /**
     * <p>审批流的唯一码。</p>
     * <br>
     * <p>processCode在审批模板编辑页面的URL中获取。</p>
     */
    @NameInMap("processCode")
    public String processCode;

    /**
     * <p>审批实例开始时间。Unix时间戳，单位毫秒。</p>
     * <br>
     * <p>例如：获取审批单发起时间在2020.4.10-2020.4.14之间审批单，该值传2020.4.10 00:00:00对应的时间戳1586448000000。</p>
     */
    @NameInMap("startTime")
    public Long startTime;

    /**
     * <p>流程实例状态，未传值代表查询所有状态的实例ID列表。</p>
     * <p>NEW：新创建  </p>
     * <p>RUNNING：审批中  </p>
     * <p>TERMINATED：被终止  </p>
     * <p>COMPLETED：完成  </p>
     * <p>CANCELED：取消</p>
     */
    @NameInMap("statuses")
    public java.util.List<String> statuses;

    /**
     * <p>发起userid列表，最大列表长度为10。</p>
     */
    @NameInMap("userIds")
    public java.util.List<String> userIds;

    public static ListProcessInstanceIdsRequest build(java.util.Map<String, ?> map) throws Exception {
        ListProcessInstanceIdsRequest self = new ListProcessInstanceIdsRequest();
        return TeaModel.build(map, self);
    }

    public ListProcessInstanceIdsRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public ListProcessInstanceIdsRequest setMaxResults(Long maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Long getMaxResults() {
        return this.maxResults;
    }

    public ListProcessInstanceIdsRequest setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

    public ListProcessInstanceIdsRequest setProcessCode(String processCode) {
        this.processCode = processCode;
        return this;
    }
    public String getProcessCode() {
        return this.processCode;
    }

    public ListProcessInstanceIdsRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public ListProcessInstanceIdsRequest setStatuses(java.util.List<String> statuses) {
        this.statuses = statuses;
        return this;
    }
    public java.util.List<String> getStatuses() {
        return this.statuses;
    }

    public ListProcessInstanceIdsRequest setUserIds(java.util.List<String> userIds) {
        this.userIds = userIds;
        return this;
    }
    public java.util.List<String> getUserIds() {
        return this.userIds;
    }

}
