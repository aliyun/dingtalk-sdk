// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class UpdateHrmLegalEntityWithoutNameResponseBody extends TeaModel {
    @NameInMap("result")
    public UpdateHrmLegalEntityWithoutNameResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static UpdateHrmLegalEntityWithoutNameResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateHrmLegalEntityWithoutNameResponseBody self = new UpdateHrmLegalEntityWithoutNameResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateHrmLegalEntityWithoutNameResponseBody setResult(UpdateHrmLegalEntityWithoutNameResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public UpdateHrmLegalEntityWithoutNameResponseBodyResult getResult() {
        return this.result;
    }

    public UpdateHrmLegalEntityWithoutNameResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class UpdateHrmLegalEntityWithoutNameResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>ding123</p>
         */
        @NameInMap("corpId")
        public String corpId;

        /**
         * <strong>example:</strong>
         * <p>2023-01-01</p>
         */
        @NameInMap("gmtCreate")
        public Long gmtCreate;

        /**
         * <strong>example:</strong>
         * <p>2023-01-01</p>
         */
        @NameInMap("gmtModified")
        public Long gmtModified;

        /**
         * <strong>example:</strong>
         * <p>123456</p>
         */
        @NameInMap("legalEntityId")
        public String legalEntityId;

        /**
         * <strong>example:</strong>
         * <p>公司1</p>
         */
        @NameInMap("legalEntityName")
        public String legalEntityName;

        /**
         * <strong>example:</strong>
         * <p>公1</p>
         */
        @NameInMap("legalEntityShortName")
        public String legalEntityShortName;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("legalEntityStatus")
        public Integer legalEntityStatus;

        /**
         * <strong>example:</strong>
         * <p>法人</p>
         */
        @NameInMap("legalPersonName")
        public String legalPersonName;

        public static UpdateHrmLegalEntityWithoutNameResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            UpdateHrmLegalEntityWithoutNameResponseBodyResult self = new UpdateHrmLegalEntityWithoutNameResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public UpdateHrmLegalEntityWithoutNameResponseBodyResult setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public UpdateHrmLegalEntityWithoutNameResponseBodyResult setGmtCreate(Long gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public Long getGmtCreate() {
            return this.gmtCreate;
        }

        public UpdateHrmLegalEntityWithoutNameResponseBodyResult setGmtModified(Long gmtModified) {
            this.gmtModified = gmtModified;
            return this;
        }
        public Long getGmtModified() {
            return this.gmtModified;
        }

        public UpdateHrmLegalEntityWithoutNameResponseBodyResult setLegalEntityId(String legalEntityId) {
            this.legalEntityId = legalEntityId;
            return this;
        }
        public String getLegalEntityId() {
            return this.legalEntityId;
        }

        public UpdateHrmLegalEntityWithoutNameResponseBodyResult setLegalEntityName(String legalEntityName) {
            this.legalEntityName = legalEntityName;
            return this;
        }
        public String getLegalEntityName() {
            return this.legalEntityName;
        }

        public UpdateHrmLegalEntityWithoutNameResponseBodyResult setLegalEntityShortName(String legalEntityShortName) {
            this.legalEntityShortName = legalEntityShortName;
            return this;
        }
        public String getLegalEntityShortName() {
            return this.legalEntityShortName;
        }

        public UpdateHrmLegalEntityWithoutNameResponseBodyResult setLegalEntityStatus(Integer legalEntityStatus) {
            this.legalEntityStatus = legalEntityStatus;
            return this;
        }
        public Integer getLegalEntityStatus() {
            return this.legalEntityStatus;
        }

        public UpdateHrmLegalEntityWithoutNameResponseBodyResult setLegalPersonName(String legalPersonName) {
            this.legalPersonName = legalPersonName;
            return this;
        }
        public String getLegalPersonName() {
            return this.legalPersonName;
        }

    }

}
