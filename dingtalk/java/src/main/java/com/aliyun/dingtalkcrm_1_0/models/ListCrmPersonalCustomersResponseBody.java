// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class ListCrmPersonalCustomersResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("result")
    public java.util.List<ListCrmPersonalCustomersResponseBodyResult> result;

    public static ListCrmPersonalCustomersResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListCrmPersonalCustomersResponseBody self = new ListCrmPersonalCustomersResponseBody();
        return TeaModel.build(map, self);
    }

    public ListCrmPersonalCustomersResponseBody setResult(java.util.List<ListCrmPersonalCustomersResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<ListCrmPersonalCustomersResponseBodyResult> getResult() {
        return this.result;
    }

    public static class ListCrmPersonalCustomersResponseBodyResultPermission extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("ownerStaffIds")
        public java.util.List<String> ownerStaffIds;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("participantStaffIds")
        public java.util.List<String> participantStaffIds;

        public static ListCrmPersonalCustomersResponseBodyResultPermission build(java.util.Map<String, ?> map) throws Exception {
            ListCrmPersonalCustomersResponseBodyResultPermission self = new ListCrmPersonalCustomersResponseBodyResultPermission();
            return TeaModel.build(map, self);
        }

        public ListCrmPersonalCustomersResponseBodyResultPermission setOwnerStaffIds(java.util.List<String> ownerStaffIds) {
            this.ownerStaffIds = ownerStaffIds;
            return this;
        }
        public java.util.List<String> getOwnerStaffIds() {
            return this.ownerStaffIds;
        }

        public ListCrmPersonalCustomersResponseBodyResultPermission setParticipantStaffIds(java.util.List<String> participantStaffIds) {
            this.participantStaffIds = participantStaffIds;
            return this;
        }
        public java.util.List<String> getParticipantStaffIds() {
            return this.participantStaffIds;
        }

    }

    public static class ListCrmPersonalCustomersResponseBodyResult extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("appUuid")
        public String appUuid;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("creatorNick")
        public String creatorNick;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("creatorUserId")
        public String creatorUserId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("data")
        public java.util.Map<String, ?> data;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("extendData")
        public java.util.Map<String, ?> extendData;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("formCode")
        public String formCode;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("gmtCreate")
        public String gmtCreate;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("gmtModified")
        public String gmtModified;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("instanceId")
        public String instanceId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("objectType")
        public String objectType;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("permission")
        public ListCrmPersonalCustomersResponseBodyResultPermission permission;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("procInstStatus")
        public String procInstStatus;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("procOutResult")
        public String procOutResult;

        public static ListCrmPersonalCustomersResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            ListCrmPersonalCustomersResponseBodyResult self = new ListCrmPersonalCustomersResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public ListCrmPersonalCustomersResponseBodyResult setAppUuid(String appUuid) {
            this.appUuid = appUuid;
            return this;
        }
        public String getAppUuid() {
            return this.appUuid;
        }

        public ListCrmPersonalCustomersResponseBodyResult setCreatorNick(String creatorNick) {
            this.creatorNick = creatorNick;
            return this;
        }
        public String getCreatorNick() {
            return this.creatorNick;
        }

        public ListCrmPersonalCustomersResponseBodyResult setCreatorUserId(String creatorUserId) {
            this.creatorUserId = creatorUserId;
            return this;
        }
        public String getCreatorUserId() {
            return this.creatorUserId;
        }

        public ListCrmPersonalCustomersResponseBodyResult setData(java.util.Map<String, ?> data) {
            this.data = data;
            return this;
        }
        public java.util.Map<String, ?> getData() {
            return this.data;
        }

        public ListCrmPersonalCustomersResponseBodyResult setExtendData(java.util.Map<String, ?> extendData) {
            this.extendData = extendData;
            return this;
        }
        public java.util.Map<String, ?> getExtendData() {
            return this.extendData;
        }

        public ListCrmPersonalCustomersResponseBodyResult setFormCode(String formCode) {
            this.formCode = formCode;
            return this;
        }
        public String getFormCode() {
            return this.formCode;
        }

        public ListCrmPersonalCustomersResponseBodyResult setGmtCreate(String gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public String getGmtCreate() {
            return this.gmtCreate;
        }

        public ListCrmPersonalCustomersResponseBodyResult setGmtModified(String gmtModified) {
            this.gmtModified = gmtModified;
            return this;
        }
        public String getGmtModified() {
            return this.gmtModified;
        }

        public ListCrmPersonalCustomersResponseBodyResult setInstanceId(String instanceId) {
            this.instanceId = instanceId;
            return this;
        }
        public String getInstanceId() {
            return this.instanceId;
        }

        public ListCrmPersonalCustomersResponseBodyResult setObjectType(String objectType) {
            this.objectType = objectType;
            return this;
        }
        public String getObjectType() {
            return this.objectType;
        }

        public ListCrmPersonalCustomersResponseBodyResult setPermission(ListCrmPersonalCustomersResponseBodyResultPermission permission) {
            this.permission = permission;
            return this;
        }
        public ListCrmPersonalCustomersResponseBodyResultPermission getPermission() {
            return this.permission;
        }

        public ListCrmPersonalCustomersResponseBodyResult setProcInstStatus(String procInstStatus) {
            this.procInstStatus = procInstStatus;
            return this;
        }
        public String getProcInstStatus() {
            return this.procInstStatus;
        }

        public ListCrmPersonalCustomersResponseBodyResult setProcOutResult(String procOutResult) {
            this.procOutResult = procOutResult;
            return this;
        }
        public String getProcOutResult() {
            return this.procOutResult;
        }

    }

}
