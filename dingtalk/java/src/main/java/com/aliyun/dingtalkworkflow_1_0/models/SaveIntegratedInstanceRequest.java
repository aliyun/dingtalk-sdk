// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class SaveIntegratedInstanceRequest extends TeaModel {
    @NameInMap("formComponentValueList")
    public java.util.List<SaveIntegratedInstanceRequestFormComponentValueList> formComponentValueList;

    @NameInMap("notifiers")
    public java.util.List<SaveIntegratedInstanceRequestNotifiers> notifiers;

    // 审批实例接收人的userId。
    @NameInMap("originatorUserId")
    public String originatorUserId;

    // 审批模板唯一码
    @NameInMap("processCode")
    public String processCode;

    // 实例标题
    @NameInMap("title")
    public String title;

    // 三方审批系统中审批单的详情页地址
    @NameInMap("url")
    public String url;

    public static SaveIntegratedInstanceRequest build(java.util.Map<String, ?> map) throws Exception {
        SaveIntegratedInstanceRequest self = new SaveIntegratedInstanceRequest();
        return TeaModel.build(map, self);
    }

    public SaveIntegratedInstanceRequest setFormComponentValueList(java.util.List<SaveIntegratedInstanceRequestFormComponentValueList> formComponentValueList) {
        this.formComponentValueList = formComponentValueList;
        return this;
    }
    public java.util.List<SaveIntegratedInstanceRequestFormComponentValueList> getFormComponentValueList() {
        return this.formComponentValueList;
    }

    public SaveIntegratedInstanceRequest setNotifiers(java.util.List<SaveIntegratedInstanceRequestNotifiers> notifiers) {
        this.notifiers = notifiers;
        return this;
    }
    public java.util.List<SaveIntegratedInstanceRequestNotifiers> getNotifiers() {
        return this.notifiers;
    }

    public SaveIntegratedInstanceRequest setOriginatorUserId(String originatorUserId) {
        this.originatorUserId = originatorUserId;
        return this;
    }
    public String getOriginatorUserId() {
        return this.originatorUserId;
    }

    public SaveIntegratedInstanceRequest setProcessCode(String processCode) {
        this.processCode = processCode;
        return this;
    }
    public String getProcessCode() {
        return this.processCode;
    }

    public SaveIntegratedInstanceRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public SaveIntegratedInstanceRequest setUrl(String url) {
        this.url = url;
        return this;
    }
    public String getUrl() {
        return this.url;
    }

    public static class SaveIntegratedInstanceRequestFormComponentValueList extends TeaModel {
        // 控件别名
        @NameInMap("bizAlias")
        public String bizAlias;

        // 控件类型，取值：
        // 
        // TextField：单行输入框
        // 
        // TextareaField：多行输入框
        // 
        // NumberField：数字输入框
        // 
        // DDSelectField：单选框
        // 
        // DDMultiSelectField：多选框
        // 
        // DDDateField：日期控件
        // 
        // DDDateRangeField：时间区间控件
        // 
        // TextNote：文字说明控件
        // 
        // PhoneField：电话控件
        // 
        // DDPhotoField：图片控件
        // 
        // MoneyField：金额控件
        // 
        // TableField：明细控件
        // 
        // DDAttachment：附件
        // 
        // InnerContactField：联系人控件
        // 
        // RelateField：关联审批单
        // 
        // FormRelateField：关联控件
        // 
        // AddressField：省市区控件
        // 
        // StarRatingField：评分控件
        // 
        // DepartmentField：部门控件
        @NameInMap("componentType")
        public String componentType;

        // 表单扩展值
        @NameInMap("extValue")
        public String extValue;

        // 控件id
        @NameInMap("id")
        public String id;

        // 表单名称
        @NameInMap("name")
        public String name;

        // 表单值
        @NameInMap("value")
        public String value;

        public static SaveIntegratedInstanceRequestFormComponentValueList build(java.util.Map<String, ?> map) throws Exception {
            SaveIntegratedInstanceRequestFormComponentValueList self = new SaveIntegratedInstanceRequestFormComponentValueList();
            return TeaModel.build(map, self);
        }

        public SaveIntegratedInstanceRequestFormComponentValueList setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
        }

        public SaveIntegratedInstanceRequestFormComponentValueList setComponentType(String componentType) {
            this.componentType = componentType;
            return this;
        }
        public String getComponentType() {
            return this.componentType;
        }

        public SaveIntegratedInstanceRequestFormComponentValueList setExtValue(String extValue) {
            this.extValue = extValue;
            return this;
        }
        public String getExtValue() {
            return this.extValue;
        }

        public SaveIntegratedInstanceRequestFormComponentValueList setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public SaveIntegratedInstanceRequestFormComponentValueList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public SaveIntegratedInstanceRequestFormComponentValueList setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class SaveIntegratedInstanceRequestNotifiers extends TeaModel {
        // 抄送位置，可以值有：
        // start - 审批发起时，通知抄送人
        // finish - 审批通过后，通知抄送人
        // start_finish - 审批发起时和审批通过后，都通知抄送人
        @NameInMap("position")
        public String position;

        // 抄送接收人用户ID
        @NameInMap("userid")
        public String userid;

        public static SaveIntegratedInstanceRequestNotifiers build(java.util.Map<String, ?> map) throws Exception {
            SaveIntegratedInstanceRequestNotifiers self = new SaveIntegratedInstanceRequestNotifiers();
            return TeaModel.build(map, self);
        }

        public SaveIntegratedInstanceRequestNotifiers setPosition(String position) {
            this.position = position;
            return this;
        }
        public String getPosition() {
            return this.position;
        }

        public SaveIntegratedInstanceRequestNotifiers setUserid(String userid) {
            this.userid = userid;
            return this;
        }
        public String getUserid() {
            return this.userid;
        }

    }

}
