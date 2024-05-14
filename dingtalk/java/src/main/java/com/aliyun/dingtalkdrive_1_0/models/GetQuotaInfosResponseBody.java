// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class GetQuotaInfosResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("quotas")
    public java.util.List<GetQuotaInfosResponseBodyQuotas> quotas;

    public static GetQuotaInfosResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetQuotaInfosResponseBody self = new GetQuotaInfosResponseBody();
        return TeaModel.build(map, self);
    }

    public GetQuotaInfosResponseBody setQuotas(java.util.List<GetQuotaInfosResponseBodyQuotas> quotas) {
        this.quotas = quotas;
        return this;
    }
    public java.util.List<GetQuotaInfosResponseBodyQuotas> getQuotas() {
        return this.quotas;
    }

    public static class GetQuotaInfosResponseBodyQuotas extends TeaModel {
        @NameInMap("identifier")
        public String identifier;

        @NameInMap("quota")
        public Long quota;

        @NameInMap("type")
        public String type;

        @NameInMap("usedQuota")
        public Long usedQuota;

        public static GetQuotaInfosResponseBodyQuotas build(java.util.Map<String, ?> map) throws Exception {
            GetQuotaInfosResponseBodyQuotas self = new GetQuotaInfosResponseBodyQuotas();
            return TeaModel.build(map, self);
        }

        public GetQuotaInfosResponseBodyQuotas setIdentifier(String identifier) {
            this.identifier = identifier;
            return this;
        }
        public String getIdentifier() {
            return this.identifier;
        }

        public GetQuotaInfosResponseBodyQuotas setQuota(Long quota) {
            this.quota = quota;
            return this;
        }
        public Long getQuota() {
            return this.quota;
        }

        public GetQuotaInfosResponseBodyQuotas setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public GetQuotaInfosResponseBodyQuotas setUsedQuota(Long usedQuota) {
            this.usedQuota = usedQuota;
            return this;
        }
        public Long getUsedQuota() {
            return this.usedQuota;
        }

    }

}
