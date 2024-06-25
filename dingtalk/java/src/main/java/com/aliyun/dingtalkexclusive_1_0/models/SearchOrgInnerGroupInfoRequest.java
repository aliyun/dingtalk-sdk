// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class SearchOrgInnerGroupInfoRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>创建时间查询最大时间戳</p>
     */
    @NameInMap("createTimeEnd")
    public Long createTimeEnd;

    /**
     * <strong>example:</strong>
     * <p>创建时间查询最小时间戳</p>
     */
    @NameInMap("createTimeStart")
    public Long createTimeStart;

    /**
     * <strong>example:</strong>
     * <p>群人数范围最大值，例如100</p>
     */
    @NameInMap("groupMembersCountEnd")
    public Integer groupMembersCountEnd;

    /**
     * <strong>example:</strong>
     * <p>群人数范围最小值，例如1</p>
     */
    @NameInMap("groupMembersCountStart")
    public Integer groupMembersCountStart;

    /**
     * <strong>example:</strong>
     * <p>群名称</p>
     */
    @NameInMap("groupName")
    public String groupName;

    /**
     * <strong>example:</strong>
     * <p>群主userId</p>
     */
    @NameInMap("groupOwner")
    public String groupOwner;

    /**
     * <strong>example:</strong>
     * <p>最后一次活跃时间戳最大值</p>
     */
    @NameInMap("lastActiveTimeEnd")
    public Long lastActiveTimeEnd;

    /**
     * <strong>example:</strong>
     * <p>最后一次活跃时间戳最小值</p>
     */
    @NameInMap("lastActiveTimeStart")
    public Long lastActiveTimeStart;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>当前查询人的userId</p>
     */
    @NameInMap("operatorUserId")
    public String operatorUserId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>分页大小，最大不能超过100</p>
     */
    @NameInMap("pageSize")
    public Integer pageSize;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>分页号，从1开始</p>
     */
    @NameInMap("pageStart")
    public Integer pageStart;

    /**
     * <strong>example:</strong>
     * <p>是否同步到钉盘 0不同步 1同步</p>
     */
    @NameInMap("syncToDingpan")
    public Integer syncToDingpan;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>每次查询唯一标识，保证每次分页查询时该值不变</p>
     */
    @NameInMap("uuid")
    public String uuid;

    public static SearchOrgInnerGroupInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        SearchOrgInnerGroupInfoRequest self = new SearchOrgInnerGroupInfoRequest();
        return TeaModel.build(map, self);
    }

    public SearchOrgInnerGroupInfoRequest setCreateTimeEnd(Long createTimeEnd) {
        this.createTimeEnd = createTimeEnd;
        return this;
    }
    public Long getCreateTimeEnd() {
        return this.createTimeEnd;
    }

    public SearchOrgInnerGroupInfoRequest setCreateTimeStart(Long createTimeStart) {
        this.createTimeStart = createTimeStart;
        return this;
    }
    public Long getCreateTimeStart() {
        return this.createTimeStart;
    }

    public SearchOrgInnerGroupInfoRequest setGroupMembersCountEnd(Integer groupMembersCountEnd) {
        this.groupMembersCountEnd = groupMembersCountEnd;
        return this;
    }
    public Integer getGroupMembersCountEnd() {
        return this.groupMembersCountEnd;
    }

    public SearchOrgInnerGroupInfoRequest setGroupMembersCountStart(Integer groupMembersCountStart) {
        this.groupMembersCountStart = groupMembersCountStart;
        return this;
    }
    public Integer getGroupMembersCountStart() {
        return this.groupMembersCountStart;
    }

    public SearchOrgInnerGroupInfoRequest setGroupName(String groupName) {
        this.groupName = groupName;
        return this;
    }
    public String getGroupName() {
        return this.groupName;
    }

    public SearchOrgInnerGroupInfoRequest setGroupOwner(String groupOwner) {
        this.groupOwner = groupOwner;
        return this;
    }
    public String getGroupOwner() {
        return this.groupOwner;
    }

    public SearchOrgInnerGroupInfoRequest setLastActiveTimeEnd(Long lastActiveTimeEnd) {
        this.lastActiveTimeEnd = lastActiveTimeEnd;
        return this;
    }
    public Long getLastActiveTimeEnd() {
        return this.lastActiveTimeEnd;
    }

    public SearchOrgInnerGroupInfoRequest setLastActiveTimeStart(Long lastActiveTimeStart) {
        this.lastActiveTimeStart = lastActiveTimeStart;
        return this;
    }
    public Long getLastActiveTimeStart() {
        return this.lastActiveTimeStart;
    }

    public SearchOrgInnerGroupInfoRequest setOperatorUserId(String operatorUserId) {
        this.operatorUserId = operatorUserId;
        return this;
    }
    public String getOperatorUserId() {
        return this.operatorUserId;
    }

    public SearchOrgInnerGroupInfoRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public SearchOrgInnerGroupInfoRequest setPageStart(Integer pageStart) {
        this.pageStart = pageStart;
        return this;
    }
    public Integer getPageStart() {
        return this.pageStart;
    }

    public SearchOrgInnerGroupInfoRequest setSyncToDingpan(Integer syncToDingpan) {
        this.syncToDingpan = syncToDingpan;
        return this;
    }
    public Integer getSyncToDingpan() {
        return this.syncToDingpan;
    }

    public SearchOrgInnerGroupInfoRequest setUuid(String uuid) {
        this.uuid = uuid;
        return this;
    }
    public String getUuid() {
        return this.uuid;
    }

}
