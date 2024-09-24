// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_2_0.models;

import com.aliyun.tea.*;

public class GetFormDataByIDResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>{       &quot;numberField_jcr0069o&quot;: 1,       &quot;multiSelectField_jcr0069s&quot;: [         &quot;选项三&quot;,         &quot;选项二&quot;       ],       &quot;textareaField_jcr0069n&quot;: &quot;duohang&quot;,       &quot;employeeField_jcr0069x&quot;: [         &quot;xxxx&quot;       ],       &quot;departmentField_jcr0069z&quot;: &quot;xxxx&quot;,       &quot;cascadeDate_jcr0069u&quot;: [         &quot;1514736000000&quot;,         &quot;1517328000000&quot;       ],       &quot;cascadeSelectField_jcr006a0&quot;: [         &quot;part&quot;,         &quot;part_b&quot;       ],       &quot;tableField_jcr006a1&quot;: [         {           &quot;departmentField_jcr006ad&quot;: &quot;xxxx&quot;,           &quot;cascadeDate_jcr006aa&quot;: [             &quot;1514736000000&quot;,             &quot;1517328000000&quot;           ],           &quot;selectField_jcr006a6&quot;: &quot;选项三&quot;,           &quot;citySelectField_jcr006ac&quot;: [             &quot;天津&quot;,             &quot;天津市&quot;,             &quot;河东区&quot;           ],           &quot;radioField_jcr006a5&quot;: &quot;选项二&quot;,           &quot;employeeField_jcr006ab&quot;: [             &quot;xxxxxx&quot;,             &quot;yyyyyy&quot;           ],           &quot;dateField_jcr006a9&quot;: 1517328000000,           &quot;textField_jcr006a2&quot;: &quot;明细下单行&quot;,           &quot;textareaField_jcr006a3&quot;: &quot;明细下多行&quot;,           &quot;cascadeSelectField_jcr006ae&quot;: [             &quot;product&quot;,             &quot;product_a&quot;           ],           &quot;numberField_jcr006a4&quot;: 2,           &quot;checkboxField_jcr006a7&quot;: [             &quot;选项一&quot;,             &quot;选项三&quot;,             &quot;选项二&quot;           ],           &quot;multiSelectField_jcr006a8&quot;: [             &quot;选项一&quot;,             &quot;选项三&quot;,             &quot;选项二&quot;           ]         }       ],       &quot;selectField_jcr0069q&quot;: &quot;选项一&quot;,       &quot;citySelectField_jcr0069y&quot;: [         &quot;北京&quot;,         &quot;北京市&quot;,         &quot;东城区&quot;       ],       &quot;checkboxField_jcr0069r&quot;: [         &quot;选项三&quot;,         &quot;选项二&quot;       ],       &quot;textField_jcr0069m&quot;: &quot;danhang&quot;,       &quot;radioField_jcr0069p&quot;: &quot;选项一&quot;,       &quot;dateField_jcr0069t&quot;: 1516636800000     }</p>
     */
    @NameInMap("formData")
    public java.util.Map<String, ?> formData;

    /**
     * <strong>example:</strong>
     * <p>33f6d221-17f8-42b7-836a-682b95a046c2</p>
     */
    @NameInMap("formInstId")
    public String formInstId;

    /**
     * <strong>example:</strong>
     * <p>2018-01-24 11:22:01</p>
     */
    @NameInMap("modifiedTimeGMT")
    public String modifiedTimeGMT;

    @NameInMap("originator")
    public GetFormDataByIDResponseBodyOriginator originator;

    public static GetFormDataByIDResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetFormDataByIDResponseBody self = new GetFormDataByIDResponseBody();
        return TeaModel.build(map, self);
    }

    public GetFormDataByIDResponseBody setFormData(java.util.Map<String, ?> formData) {
        this.formData = formData;
        return this;
    }
    public java.util.Map<String, ?> getFormData() {
        return this.formData;
    }

    public GetFormDataByIDResponseBody setFormInstId(String formInstId) {
        this.formInstId = formInstId;
        return this;
    }
    public String getFormInstId() {
        return this.formInstId;
    }

    public GetFormDataByIDResponseBody setModifiedTimeGMT(String modifiedTimeGMT) {
        this.modifiedTimeGMT = modifiedTimeGMT;
        return this;
    }
    public String getModifiedTimeGMT() {
        return this.modifiedTimeGMT;
    }

    public GetFormDataByIDResponseBody setOriginator(GetFormDataByIDResponseBodyOriginator originator) {
        this.originator = originator;
        return this;
    }
    public GetFormDataByIDResponseBodyOriginator getOriginator() {
        return this.originator;
    }

    public static class GetFormDataByIDResponseBodyOriginatorName extends TeaModel {
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

        /**
         * <strong>example:</strong>
         * <p>i18n</p>
         */
        @NameInMap("type")
        public String type;

        public static GetFormDataByIDResponseBodyOriginatorName build(java.util.Map<String, ?> map) throws Exception {
            GetFormDataByIDResponseBodyOriginatorName self = new GetFormDataByIDResponseBodyOriginatorName();
            return TeaModel.build(map, self);
        }

        public GetFormDataByIDResponseBodyOriginatorName setNameInChinese(String nameInChinese) {
            this.nameInChinese = nameInChinese;
            return this;
        }
        public String getNameInChinese() {
            return this.nameInChinese;
        }

        public GetFormDataByIDResponseBodyOriginatorName setNameInEnglish(String nameInEnglish) {
            this.nameInEnglish = nameInEnglish;
            return this;
        }
        public String getNameInEnglish() {
            return this.nameInEnglish;
        }

        public GetFormDataByIDResponseBodyOriginatorName setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class GetFormDataByIDResponseBodyOriginator extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>开发部</p>
         */
        @NameInMap("departmentName")
        public String departmentName;

        @NameInMap("email")
        public String email;

        @NameInMap("name")
        public GetFormDataByIDResponseBodyOriginatorName name;

        @NameInMap("userId")
        public String userId;

        public static GetFormDataByIDResponseBodyOriginator build(java.util.Map<String, ?> map) throws Exception {
            GetFormDataByIDResponseBodyOriginator self = new GetFormDataByIDResponseBodyOriginator();
            return TeaModel.build(map, self);
        }

        public GetFormDataByIDResponseBodyOriginator setDepartmentName(String departmentName) {
            this.departmentName = departmentName;
            return this;
        }
        public String getDepartmentName() {
            return this.departmentName;
        }

        public GetFormDataByIDResponseBodyOriginator setEmail(String email) {
            this.email = email;
            return this;
        }
        public String getEmail() {
            return this.email;
        }

        public GetFormDataByIDResponseBodyOriginator setName(GetFormDataByIDResponseBodyOriginatorName name) {
            this.name = name;
            return this;
        }
        public GetFormDataByIDResponseBodyOriginatorName getName() {
            return this.name;
        }

        public GetFormDataByIDResponseBodyOriginator setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
