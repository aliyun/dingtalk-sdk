// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class BatchAddPermissionRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("list")
    public java.util.List<BatchAddPermissionRequestList> list;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("targetId")
    public String targetId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("targetType")
    public String targetType;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userId")
    public String userId;

    public static BatchAddPermissionRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchAddPermissionRequest self = new BatchAddPermissionRequest();
        return TeaModel.build(map, self);
    }

    public BatchAddPermissionRequest setList(java.util.List<BatchAddPermissionRequestList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<BatchAddPermissionRequestList> getList() {
        return this.list;
    }

    public BatchAddPermissionRequest setTargetId(String targetId) {
        this.targetId = targetId;
        return this;
    }
    public String getTargetId() {
        return this.targetId;
    }

    public BatchAddPermissionRequest setTargetType(String targetType) {
        this.targetType = targetType;
        return this;
    }
    public String getTargetType() {
        return this.targetType;
    }

    public BatchAddPermissionRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public static class BatchAddPermissionRequestListMember extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("id")
        public String id;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("type")
        public String type;

        public static BatchAddPermissionRequestListMember build(java.util.Map<String, ?> map) throws Exception {
            BatchAddPermissionRequestListMember self = new BatchAddPermissionRequestListMember();
            return TeaModel.build(map, self);
        }

        public BatchAddPermissionRequestListMember setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public BatchAddPermissionRequestListMember setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class BatchAddPermissionRequestList extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("member")
        public BatchAddPermissionRequestListMember member;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("policyType")
        public Long policyType;

        public static BatchAddPermissionRequestList build(java.util.Map<String, ?> map) throws Exception {
            BatchAddPermissionRequestList self = new BatchAddPermissionRequestList();
            return TeaModel.build(map, self);
        }

        public BatchAddPermissionRequestList setMember(BatchAddPermissionRequestListMember member) {
            this.member = member;
            return this;
        }
        public BatchAddPermissionRequestListMember getMember() {
            return this.member;
        }

        public BatchAddPermissionRequestList setPolicyType(Long policyType) {
            this.policyType = policyType;
            return this;
        }
        public Long getPolicyType() {
            return this.policyType;
        }

    }

}
