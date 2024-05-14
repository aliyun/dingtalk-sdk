// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrip_1_0.models;

import com.aliyun.tea.*;

public class SyncInvoiceEntityRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("channelCorpId")
    public String channelCorpId;

    @NameInMap("delAll")
    public Boolean delAll;

    @NameInMap("entityList")
    public java.util.List<SyncInvoiceEntityRequestEntityList> entityList;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("invoiceId")
    public String invoiceId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userId")
    public String userId;

    public static SyncInvoiceEntityRequest build(java.util.Map<String, ?> map) throws Exception {
        SyncInvoiceEntityRequest self = new SyncInvoiceEntityRequest();
        return TeaModel.build(map, self);
    }

    public SyncInvoiceEntityRequest setChannelCorpId(String channelCorpId) {
        this.channelCorpId = channelCorpId;
        return this;
    }
    public String getChannelCorpId() {
        return this.channelCorpId;
    }

    public SyncInvoiceEntityRequest setDelAll(Boolean delAll) {
        this.delAll = delAll;
        return this;
    }
    public Boolean getDelAll() {
        return this.delAll;
    }

    public SyncInvoiceEntityRequest setEntityList(java.util.List<SyncInvoiceEntityRequestEntityList> entityList) {
        this.entityList = entityList;
        return this;
    }
    public java.util.List<SyncInvoiceEntityRequestEntityList> getEntityList() {
        return this.entityList;
    }

    public SyncInvoiceEntityRequest setInvoiceId(String invoiceId) {
        this.invoiceId = invoiceId;
        return this;
    }
    public String getInvoiceId() {
        return this.invoiceId;
    }

    public SyncInvoiceEntityRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public static class SyncInvoiceEntityRequestEntityList extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("entityId")
        public String entityId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("entityType")
        public String entityType;

        public static SyncInvoiceEntityRequestEntityList build(java.util.Map<String, ?> map) throws Exception {
            SyncInvoiceEntityRequestEntityList self = new SyncInvoiceEntityRequestEntityList();
            return TeaModel.build(map, self);
        }

        public SyncInvoiceEntityRequestEntityList setEntityId(String entityId) {
            this.entityId = entityId;
            return this;
        }
        public String getEntityId() {
            return this.entityId;
        }

        public SyncInvoiceEntityRequestEntityList setEntityType(String entityType) {
            this.entityType = entityType;
            return this;
        }
        public String getEntityType() {
            return this.entityType;
        }

    }

}
