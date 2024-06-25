// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class UpdateRealmLicenseRequest extends TeaModel {
    @NameInMap("detailList")
    public java.util.List<UpdateRealmLicenseRequestDetailList> detailList;

    public static UpdateRealmLicenseRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateRealmLicenseRequest self = new UpdateRealmLicenseRequest();
        return TeaModel.build(map, self);
    }

    public UpdateRealmLicenseRequest setDetailList(java.util.List<UpdateRealmLicenseRequestDetailList> detailList) {
        this.detailList = detailList;
        return this;
    }
    public java.util.List<UpdateRealmLicenseRequestDetailList> getDetailList() {
        return this.detailList;
    }

    public static class UpdateRealmLicenseRequestDetailList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>1001</p>
         */
        @NameInMap("licenseType")
        public Integer licenseType;

        /**
         * <strong>example:</strong>
         * <p>123</p>
         */
        @NameInMap("userId")
        public String userId;

        public static UpdateRealmLicenseRequestDetailList build(java.util.Map<String, ?> map) throws Exception {
            UpdateRealmLicenseRequestDetailList self = new UpdateRealmLicenseRequestDetailList();
            return TeaModel.build(map, self);
        }

        public UpdateRealmLicenseRequestDetailList setLicenseType(Integer licenseType) {
            this.licenseType = licenseType;
            return this;
        }
        public Integer getLicenseType() {
            return this.licenseType;
        }

        public UpdateRealmLicenseRequestDetailList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
