// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class SearchOrgInnerGroupInfoRequest extends TeaModel {
    /**
     * <p>createTimeEnd</p>
     */
    @NameInMap("createTimeEnd")
    public Long createTimeEnd;

    /**
     * <p>createTimeStart</p>
     */
    @NameInMap("createTimeStart")
    public Long createTimeStart;

    /**
     * <p>groupMembersCntEnd</p>
     */
    @NameInMap("groupMembersCountEnd")
    public Integer groupMembersCountEnd;

    /**
     * <p>groupMembersCntStart</p>
     */
    @NameInMap("groupMembersCountStart")
    public Integer groupMembersCountStart;

    /**
     * <p>groupName</p>
     */
    @NameInMap("groupName")
    public String groupName;

    /**
     * <p>groupOwner</p>
     */
    @NameInMap("groupOwner")
    public String groupOwner;

    /**
     * <p>lastActiveTimeEnd</p>
     */
    @NameInMap("lastActiveTimeEnd")
    public Long lastActiveTimeEnd;

    /**
     * <p>lastActiveTimeStart</p>
     */
    @NameInMap("lastActiveTimeStart")
    public Long lastActiveTimeStart;

    /**
     * <p>operatorUserId</p>
     */
    @NameInMap("operatorUserId")
    public String operatorUserId;

    /**
     * <p>pageSize</p>
     */
    @NameInMap("pageSize")
    public Integer pageSize;

    /**
     * <p>pageStart</p>
     */
    @NameInMap("pageStart")
    public Integer pageStart;

    /**
     * <p>syncToDingpan</p>
     */
    @NameInMap("syncToDingpan")
    public Integer syncToDingpan;

    /**
     * <p>uuid</p>
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
