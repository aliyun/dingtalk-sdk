// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class GetOfficialAccountContactsResponseBody extends TeaModel {
    /**
     * <p>分页大小</p>
     */
    @NameInMap("maxResults")
    public Long maxResults;

    /**
     * <p>下一页的游标，为null则表示无数据</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>客户数据节点</p>
     */
    @NameInMap("values")
    public java.util.List<GetOfficialAccountContactsResponseBodyValues> values;

    public static GetOfficialAccountContactsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetOfficialAccountContactsResponseBody self = new GetOfficialAccountContactsResponseBody();
        return TeaModel.build(map, self);
    }

    public GetOfficialAccountContactsResponseBody setMaxResults(Long maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Long getMaxResults() {
        return this.maxResults;
    }

    public GetOfficialAccountContactsResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public GetOfficialAccountContactsResponseBody setValues(java.util.List<GetOfficialAccountContactsResponseBodyValues> values) {
        this.values = values;
        return this;
    }
    public java.util.List<GetOfficialAccountContactsResponseBodyValues> getValues() {
        return this.values;
    }

    public static class GetOfficialAccountContactsResponseBodyValuesContactsPermission extends TeaModel {
        /**
         * <p>负责人用户ID列表</p>
         */
        @NameInMap("ownerStaffIds")
        public java.util.List<String> ownerStaffIds;

        /**
         * <p>协同人用户ID列表</p>
         */
        @NameInMap("participantStaffIds")
        public java.util.List<String> participantStaffIds;

        public static GetOfficialAccountContactsResponseBodyValuesContactsPermission build(java.util.Map<String, ?> map) throws Exception {
            GetOfficialAccountContactsResponseBodyValuesContactsPermission self = new GetOfficialAccountContactsResponseBodyValuesContactsPermission();
            return TeaModel.build(map, self);
        }

        public GetOfficialAccountContactsResponseBodyValuesContactsPermission setOwnerStaffIds(java.util.List<String> ownerStaffIds) {
            this.ownerStaffIds = ownerStaffIds;
            return this;
        }
        public java.util.List<String> getOwnerStaffIds() {
            return this.ownerStaffIds;
        }

        public GetOfficialAccountContactsResponseBodyValuesContactsPermission setParticipantStaffIds(java.util.List<String> participantStaffIds) {
            this.participantStaffIds = participantStaffIds;
            return this;
        }
        public java.util.List<String> getParticipantStaffIds() {
            return this.participantStaffIds;
        }

    }

    public static class GetOfficialAccountContactsResponseBodyValuesContacts extends TeaModel {
        /**
         * <p>记录创建时间</p>
         */
        @NameInMap("createTime")
        public String createTime;

        /**
         * <p>创建记录的用户昵称</p>
         */
        @NameInMap("creatorNick")
        public String creatorNick;

        /**
         * <p>创建记录的用户ID</p>
         */
        @NameInMap("creatorUserId")
        public String creatorUserId;

        /**
         * <p>数据内容</p>
         */
        @NameInMap("data")
        public java.util.Map<String, ?> data;

        /**
         * <p>扩展数据内容</p>
         */
        @NameInMap("extendData")
        public java.util.Map<String, ?> extendData;

        /**
         * <p>数据ID</p>
         */
        @NameInMap("instanceId")
        public String instanceId;

        /**
         * <p>记录修改时间</p>
         */
        @NameInMap("modifyTime")
        public String modifyTime;

        /**
         * <p>数据权限信息</p>
         */
        @NameInMap("permission")
        public GetOfficialAccountContactsResponseBodyValuesContactsPermission permission;

        public static GetOfficialAccountContactsResponseBodyValuesContacts build(java.util.Map<String, ?> map) throws Exception {
            GetOfficialAccountContactsResponseBodyValuesContacts self = new GetOfficialAccountContactsResponseBodyValuesContacts();
            return TeaModel.build(map, self);
        }

        public GetOfficialAccountContactsResponseBodyValuesContacts setCreateTime(String createTime) {
            this.createTime = createTime;
            return this;
        }
        public String getCreateTime() {
            return this.createTime;
        }

        public GetOfficialAccountContactsResponseBodyValuesContacts setCreatorNick(String creatorNick) {
            this.creatorNick = creatorNick;
            return this;
        }
        public String getCreatorNick() {
            return this.creatorNick;
        }

        public GetOfficialAccountContactsResponseBodyValuesContacts setCreatorUserId(String creatorUserId) {
            this.creatorUserId = creatorUserId;
            return this;
        }
        public String getCreatorUserId() {
            return this.creatorUserId;
        }

        public GetOfficialAccountContactsResponseBodyValuesContacts setData(java.util.Map<String, ?> data) {
            this.data = data;
            return this;
        }
        public java.util.Map<String, ?> getData() {
            return this.data;
        }

        public GetOfficialAccountContactsResponseBodyValuesContacts setExtendData(java.util.Map<String, ?> extendData) {
            this.extendData = extendData;
            return this;
        }
        public java.util.Map<String, ?> getExtendData() {
            return this.extendData;
        }

        public GetOfficialAccountContactsResponseBodyValuesContacts setInstanceId(String instanceId) {
            this.instanceId = instanceId;
            return this;
        }
        public String getInstanceId() {
            return this.instanceId;
        }

        public GetOfficialAccountContactsResponseBodyValuesContacts setModifyTime(String modifyTime) {
            this.modifyTime = modifyTime;
            return this;
        }
        public String getModifyTime() {
            return this.modifyTime;
        }

        public GetOfficialAccountContactsResponseBodyValuesContacts setPermission(GetOfficialAccountContactsResponseBodyValuesContactsPermission permission) {
            this.permission = permission;
            return this;
        }
        public GetOfficialAccountContactsResponseBodyValuesContactsPermission getPermission() {
            return this.permission;
        }

    }

    public static class GetOfficialAccountContactsResponseBodyValues extends TeaModel {
        /**
         * <p>用户的联系人数据</p>
         */
        @NameInMap("contacts")
        public java.util.List<GetOfficialAccountContactsResponseBodyValuesContacts> contacts;

        /**
         * <p>用户userId</p>
         */
        @NameInMap("userId")
        public String userId;

        public static GetOfficialAccountContactsResponseBodyValues build(java.util.Map<String, ?> map) throws Exception {
            GetOfficialAccountContactsResponseBodyValues self = new GetOfficialAccountContactsResponseBodyValues();
            return TeaModel.build(map, self);
        }

        public GetOfficialAccountContactsResponseBodyValues setContacts(java.util.List<GetOfficialAccountContactsResponseBodyValuesContacts> contacts) {
            this.contacts = contacts;
            return this;
        }
        public java.util.List<GetOfficialAccountContactsResponseBodyValuesContacts> getContacts() {
            return this.contacts;
        }

        public GetOfficialAccountContactsResponseBodyValues setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
