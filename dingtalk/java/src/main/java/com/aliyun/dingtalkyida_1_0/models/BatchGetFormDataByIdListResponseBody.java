// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class BatchGetFormDataByIdListResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<BatchGetFormDataByIdListResponseBodyResult> result;

    public static BatchGetFormDataByIdListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BatchGetFormDataByIdListResponseBody self = new BatchGetFormDataByIdListResponseBody();
        return TeaModel.build(map, self);
    }

    public BatchGetFormDataByIdListResponseBody setResult(java.util.List<BatchGetFormDataByIdListResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<BatchGetFormDataByIdListResponseBodyResult> getResult() {
        return this.result;
    }

    public static class BatchGetFormDataByIdListResponseBodyResultModifyUserName extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>张三</p>
         */
        @NameInMap("nameInChinese")
        public String nameInChinese;

        /**
         * <strong>example:</strong>
         * <p>ZhangSan</p>
         */
        @NameInMap("nameInEnglish")
        public String nameInEnglish;

        public static BatchGetFormDataByIdListResponseBodyResultModifyUserName build(java.util.Map<String, ?> map) throws Exception {
            BatchGetFormDataByIdListResponseBodyResultModifyUserName self = new BatchGetFormDataByIdListResponseBodyResultModifyUserName();
            return TeaModel.build(map, self);
        }

        public BatchGetFormDataByIdListResponseBodyResultModifyUserName setNameInChinese(String nameInChinese) {
            this.nameInChinese = nameInChinese;
            return this;
        }
        public String getNameInChinese() {
            return this.nameInChinese;
        }

        public BatchGetFormDataByIdListResponseBodyResultModifyUserName setNameInEnglish(String nameInEnglish) {
            this.nameInEnglish = nameInEnglish;
            return this;
        }
        public String getNameInEnglish() {
            return this.nameInEnglish;
        }

    }

    public static class BatchGetFormDataByIdListResponseBodyResultModifyUser extends TeaModel {
        @NameInMap("name")
        public BatchGetFormDataByIdListResponseBodyResultModifyUserName name;

        /**
         * <strong>example:</strong>
         * <p>ding173982232112232</p>
         */
        @NameInMap("userId")
        public String userId;

        public static BatchGetFormDataByIdListResponseBodyResultModifyUser build(java.util.Map<String, ?> map) throws Exception {
            BatchGetFormDataByIdListResponseBodyResultModifyUser self = new BatchGetFormDataByIdListResponseBodyResultModifyUser();
            return TeaModel.build(map, self);
        }

        public BatchGetFormDataByIdListResponseBodyResultModifyUser setName(BatchGetFormDataByIdListResponseBodyResultModifyUserName name) {
            this.name = name;
            return this;
        }
        public BatchGetFormDataByIdListResponseBodyResultModifyUserName getName() {
            return this.name;
        }

        public BatchGetFormDataByIdListResponseBodyResultModifyUser setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class BatchGetFormDataByIdListResponseBodyResultOriginatorName extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>张三</p>
         */
        @NameInMap("nameInChinese")
        public String nameInChinese;

        /**
         * <strong>example:</strong>
         * <p>ZhangSan</p>
         */
        @NameInMap("nameInEnglish")
        public String nameInEnglish;

        public static BatchGetFormDataByIdListResponseBodyResultOriginatorName build(java.util.Map<String, ?> map) throws Exception {
            BatchGetFormDataByIdListResponseBodyResultOriginatorName self = new BatchGetFormDataByIdListResponseBodyResultOriginatorName();
            return TeaModel.build(map, self);
        }

        public BatchGetFormDataByIdListResponseBodyResultOriginatorName setNameInChinese(String nameInChinese) {
            this.nameInChinese = nameInChinese;
            return this;
        }
        public String getNameInChinese() {
            return this.nameInChinese;
        }

        public BatchGetFormDataByIdListResponseBodyResultOriginatorName setNameInEnglish(String nameInEnglish) {
            this.nameInEnglish = nameInEnglish;
            return this;
        }
        public String getNameInEnglish() {
            return this.nameInEnglish;
        }

    }

    public static class BatchGetFormDataByIdListResponseBodyResultOriginator extends TeaModel {
        @NameInMap("name")
        public BatchGetFormDataByIdListResponseBodyResultOriginatorName name;

        /**
         * <strong>example:</strong>
         * <p>ding173982232112232</p>
         */
        @NameInMap("userId")
        public String userId;

        public static BatchGetFormDataByIdListResponseBodyResultOriginator build(java.util.Map<String, ?> map) throws Exception {
            BatchGetFormDataByIdListResponseBodyResultOriginator self = new BatchGetFormDataByIdListResponseBodyResultOriginator();
            return TeaModel.build(map, self);
        }

        public BatchGetFormDataByIdListResponseBodyResultOriginator setName(BatchGetFormDataByIdListResponseBodyResultOriginatorName name) {
            this.name = name;
            return this;
        }
        public BatchGetFormDataByIdListResponseBodyResultOriginatorName getName() {
            return this.name;
        }

        public BatchGetFormDataByIdListResponseBodyResultOriginator setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class BatchGetFormDataByIdListResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>2021-05-01</p>
         */
        @NameInMap("createTimeGMT")
        public String createTimeGMT;

        /**
         * <strong>example:</strong>
         * <p>ding12345</p>
         */
        @NameInMap("creatorUserId")
        public String creatorUserId;

        /**
         * <strong>example:</strong>
         * <p>{&quot;addressField_l0c1cwiy_id&quot;:&quot;&quot;海南省/469027/国营红岗农场/111&quot;&quot;,&quot;associationFormField_l0c1hdz4_id&quot;:&quot;&quot;[{\&quot;formType\&quot;:\&quot;receipt\&quot;,\&quot;formUuid\&quot;:\&quot;FORM-QQ866JB1QW8YM5XZZZ64VQB61OGM1MLWE1C0LG\&quot;,\&quot;instanceId\&quot;:\&quot;FINST-CC666Y6198RY0LAN39XGND212MSX3TFT95S0LN31\&quot;,\&quot;subTitle\&quot;:\&quot;{\\\&quot;type\\\&quot;:\\\&quot;div\\\&quot;,\\\&quot;props\\\&quot;:{\\\&quot;children\\\&quot;:{\\\&quot;type\\\&quot;:\\\&quot;a\\\&quot;,\\\&quot;props\\\&quot;:{\\\&quot;children\\\&quot;:\\\&quot;查看签名\\\&quot;,\\\&quot;className\\\&quot;:\\\&quot;inst-cell-item-link\\\&quot;,\\\&quot;style\\\&quot;:{\\\&quot;cursor\\\&quot;:\\\&quot;pointer\\\&quot;,\\\&quot;color\\\&quot;:\\\&quot;#0068ff\\\&quot;}}},\\\&quot;className\\\&quot;:\\\&quot;inst-cell-item\\\&quot;}}\&quot;,\&quot;appType\&quot;:\&quot;APP_K6IGJJ6PFAARLPDSWKXQ\&quot;,\&quot;title\&quot;:\&quot;1\&quot;}]&quot;&quot;,&quot;countrySelectField_l0c1cwiu_id&quot;:[&quot;PG&quot;]}</p>
         */
        @NameInMap("formData")
        public java.util.Map<String, ?> formData;

        /**
         * <strong>example:</strong>
         * <p>FINST-J8766S91O2UYN87ZX3XOF1MY8MBA2912BSV0L24</p>
         */
        @NameInMap("formInstanceId")
        public String formInstanceId;

        /**
         * <strong>example:</strong>
         * <p>FORM-GX866MC1NC1VOFF6WVQW33FD16E23L3CPMKVKA</p>
         */
        @NameInMap("formUuid")
        public String formUuid;

        /**
         * <strong>example:</strong>
         * <p>12345</p>
         */
        @NameInMap("id")
        public Long id;

        /**
         * <strong>example:</strong>
         * <p>符合宜搭表单实例格式的json数据</p>
         */
        @NameInMap("instanceValue")
        public String instanceValue;

        /**
         * <strong>example:</strong>
         * <p>2021-05-01</p>
         */
        @NameInMap("modifiedTimeGMT")
        public String modifiedTimeGMT;

        /**
         * <strong>example:</strong>
         * <p>manager123</p>
         */
        @NameInMap("modifier")
        public String modifier;

        @NameInMap("modifyUser")
        public BatchGetFormDataByIdListResponseBodyResultModifyUser modifyUser;

        @NameInMap("originator")
        public BatchGetFormDataByIdListResponseBodyResultOriginator originator;

        /**
         * <strong>example:</strong>
         * <p>IMPORT-388664B1BAUVB3AYZE1RIUE88TDM1QI9WIOWK2</p>
         */
        @NameInMap("sequence")
        public String sequence;

        /**
         * <strong>example:</strong>
         * <p>YIDA909202202250027</p>
         */
        @NameInMap("serialNumber")
        public String serialNumber;

        /**
         * <strong>example:</strong>
         * <p>李四发起的请购单</p>
         */
        @NameInMap("title")
        public String title;

        /**
         * <strong>example:</strong>
         * <p>1.0</p>
         */
        @NameInMap("version")
        public Long version;

        public static BatchGetFormDataByIdListResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            BatchGetFormDataByIdListResponseBodyResult self = new BatchGetFormDataByIdListResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public BatchGetFormDataByIdListResponseBodyResult setCreateTimeGMT(String createTimeGMT) {
            this.createTimeGMT = createTimeGMT;
            return this;
        }
        public String getCreateTimeGMT() {
            return this.createTimeGMT;
        }

        public BatchGetFormDataByIdListResponseBodyResult setCreatorUserId(String creatorUserId) {
            this.creatorUserId = creatorUserId;
            return this;
        }
        public String getCreatorUserId() {
            return this.creatorUserId;
        }

        public BatchGetFormDataByIdListResponseBodyResult setFormData(java.util.Map<String, ?> formData) {
            this.formData = formData;
            return this;
        }
        public java.util.Map<String, ?> getFormData() {
            return this.formData;
        }

        public BatchGetFormDataByIdListResponseBodyResult setFormInstanceId(String formInstanceId) {
            this.formInstanceId = formInstanceId;
            return this;
        }
        public String getFormInstanceId() {
            return this.formInstanceId;
        }

        public BatchGetFormDataByIdListResponseBodyResult setFormUuid(String formUuid) {
            this.formUuid = formUuid;
            return this;
        }
        public String getFormUuid() {
            return this.formUuid;
        }

        public BatchGetFormDataByIdListResponseBodyResult setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public BatchGetFormDataByIdListResponseBodyResult setInstanceValue(String instanceValue) {
            this.instanceValue = instanceValue;
            return this;
        }
        public String getInstanceValue() {
            return this.instanceValue;
        }

        public BatchGetFormDataByIdListResponseBodyResult setModifiedTimeGMT(String modifiedTimeGMT) {
            this.modifiedTimeGMT = modifiedTimeGMT;
            return this;
        }
        public String getModifiedTimeGMT() {
            return this.modifiedTimeGMT;
        }

        public BatchGetFormDataByIdListResponseBodyResult setModifier(String modifier) {
            this.modifier = modifier;
            return this;
        }
        public String getModifier() {
            return this.modifier;
        }

        public BatchGetFormDataByIdListResponseBodyResult setModifyUser(BatchGetFormDataByIdListResponseBodyResultModifyUser modifyUser) {
            this.modifyUser = modifyUser;
            return this;
        }
        public BatchGetFormDataByIdListResponseBodyResultModifyUser getModifyUser() {
            return this.modifyUser;
        }

        public BatchGetFormDataByIdListResponseBodyResult setOriginator(BatchGetFormDataByIdListResponseBodyResultOriginator originator) {
            this.originator = originator;
            return this;
        }
        public BatchGetFormDataByIdListResponseBodyResultOriginator getOriginator() {
            return this.originator;
        }

        public BatchGetFormDataByIdListResponseBodyResult setSequence(String sequence) {
            this.sequence = sequence;
            return this;
        }
        public String getSequence() {
            return this.sequence;
        }

        public BatchGetFormDataByIdListResponseBodyResult setSerialNumber(String serialNumber) {
            this.serialNumber = serialNumber;
            return this;
        }
        public String getSerialNumber() {
            return this.serialNumber;
        }

        public BatchGetFormDataByIdListResponseBodyResult setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public BatchGetFormDataByIdListResponseBodyResult setVersion(Long version) {
            this.version = version;
            return this;
        }
        public Long getVersion() {
            return this.version;
        }

    }

}
