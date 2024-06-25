// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class QueryServiceRecordResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>100</p>
     */
    @NameInMap("totalCount")
    public Integer totalCount;

    @NameInMap("values")
    public java.util.List<QueryServiceRecordResponseBodyValues> values;

    public static QueryServiceRecordResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryServiceRecordResponseBody self = new QueryServiceRecordResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryServiceRecordResponseBody setTotalCount(Integer totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Integer getTotalCount() {
        return this.totalCount;
    }

    public QueryServiceRecordResponseBody setValues(java.util.List<QueryServiceRecordResponseBodyValues> values) {
        this.values = values;
        return this;
    }
    public java.util.List<QueryServiceRecordResponseBodyValues> getValues() {
        return this.values;
    }

    public static class QueryServiceRecordResponseBodyValues extends TeaModel {
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
         * <p>HTTP</p>
         */
        @NameInMap("hookType")
        public String hookType;

        /**
         * <strong>example:</strong>
         * <p>INVOKE-E7766VC1KJ4ZVFCR346USCT2ORYI2UVRBHA1L0</p>
         */
        @NameInMap("hookUuid")
        public String hookUuid;

        /**
         * <strong>example:</strong>
         * <p>{&quot;parameter1&quot;:&quot;测试服务执行&quot;}</p>
         */
        @NameInMap("invokeParameter")
        public String invokeParameter;

        /**
         * <strong>example:</strong>
         * <p>{&quot;content&quot;:{&quot;currentPage&quot;:1,&quot;data&quot;:[{&quot;industry_id&quot;:&quot;互联网&quot;,&quot;role&quot;:&quot;人事&quot;,&quot;textField_kzi3b7ql&quot;:&quot;场景&quot;,&quot;textField_kzi3b7qk&quot;:&quot;角色&quot;,&quot;description&quot;:&quot;用于企业员工假期请假、值班、就近办公等信息统计，便于假期工作事项安排。&quot;,&quot;orderNum&quot;:5,&quot;industry&quot;:&quot;互联网&quot;,&quot;textField_kzi3b7qj&quot;:&quot;推荐&quot;,&quot;usageNum_value&quot;:&quot;3365&quot;,&quot;textField_kzi3b7qm&quot;:&quot;能力&quot;,&quot;scene&quot;:&quot;企业应用&quot;,&quot;usageNum&quot;:3365,&quot;role_id&quot;:&quot;人事&quot;,&quot;suggest_id&quot;:&quot;快速入门&quot;,&quot;imageUrl&quot;:&quot;<a href="https://tianshu-vpc.oss-cn-shanghai.aliyuncs.com/49315603-3a20-4bd8-aeb0-a1430be3177a.jpg%22,%22templateTitle%22:%22%E5%91%98%E5%B7%A5%E6%8E%92%E7%8F%AD%E8%A1%A8%22,%22guide%22:%22%22,%22orderNum_value%22:%225%22,%22author%22:%22%E5%AE%9C%E6%90%AD%E5%AE%98%E6%96%B9%22,%22appTplUuid%22:%22TPL_RAOW06MPQBKKNENFMD5U%22,%22textField_kzp6ix74%22:%22%E8%A1%8C%E4%B8%9A%22,%22scene_id%22:%22%E4%BC%81%E4%B8%9A%E5%BA%94%E7%94%A8%22,%22suggest%22:%22%E5%BF%AB%E9%80%9F%E5%85%A5%E9%97%A8%22,%22tags%22:%5B%22%E8%A1%A8%E5%8D%95%22%5D,%22isShow%22:%22%E6%98%BE%E7%A4%BA%22,%22isShow_id%22:%22y%22,%22tags_id%22:%5B%22%E8%A1%A8%E5%8D%95%22%5D%7D,%7B%22industry_id%22:%22%E4%BA%92%E8%81%94%E7%BD%91%22,%22role%22:%22%E8%A1%8C%E6%94%BF%22,%22textField_kzi3b7ql%22:%22%E5%9C%BA%E6%99%AF%22,%22textField_kzi3b7qk%22:%22%E8%A7%92%E8%89%B2%22,%22description%22:%221.%E5%8F%AF%E7%94%A8%E4%BA%8E%E5%85%AC%E5%8F%B8%E5%86%85%E9%83%A8%E6%94%B6%E9%9B%86%E5%91%98%E5%B7%A5%E6%84%8F%E8%A7%81%E3%80%82%5Cn2.%E5%8F%AF%E6%84%8F%E8%A7%81%E7%B1%BB%E5%9E%8B%E5%AF%B9%E6%84%8F%E8%A7%81%E8%BF%9B%E8%A1%8C%E6%95%B4%E7%90%86%E3%80%82%5Cn%E7%94%B1%E6%9D%AD%E5%B7%9E%E9%91%AB%E5%B3%B0%E7%BB%B4%E7%BD%91%E7%BB%9C%E7%A7%91%E6%8A%80%E6%9C%89%E9%99%90%E5%85%AC%E5%8F%B8%E5%85%8D%E8%B4%B9%E6%8F%90%E4%BE%9B%EF%BC%8C%E5%8F%AF%E9%92%89%E9%92%89%E6%B2%9F%E9%80%9A%E6%88%96%E7%94%B5%E8%AF%9D%E5%92%A8%E8%AF%A2">https://tianshu-vpc.oss-cn-shanghai.aliyuncs.com/49315603-3a20-4bd8-aeb0-a1430be3177a.jpg&quot;,&quot;templateTitle&quot;:&quot;员工排班表&quot;,&quot;guide&quot;:&quot;&quot;,&quot;orderNum_value&quot;:&quot;5&quot;,&quot;author&quot;:&quot;宜搭官方&quot;,&quot;appTplUuid&quot;:&quot;TPL_RAOW06MPQBKKNENFMD5U&quot;,&quot;textField_kzp6ix74&quot;:&quot;行业&quot;,&quot;scene_id&quot;:&quot;企业应用&quot;,&quot;suggest&quot;:&quot;快速入门&quot;,&quot;tags&quot;:[&quot;表单&quot;],&quot;isShow&quot;:&quot;显示&quot;,&quot;isShow_id&quot;:&quot;y&quot;,&quot;tags_id&quot;:[&quot;表单&quot;]},{&quot;industry_id&quot;:&quot;互联网&quot;,&quot;role&quot;:&quot;行政&quot;,&quot;textField_kzi3b7ql&quot;:&quot;场景&quot;,&quot;textField_kzi3b7qk&quot;:&quot;角色&quot;,&quot;description&quot;:&quot;1.可用于公司内部收集员工意见。\n2.可意见类型对意见进行整理。\n由杭州鑫峰维网络科技有限公司免费提供，可钉钉沟通或电话咨询</a> 肖经理：15869116881&quot;,&quot;orderNum&quot;:14,&quot;industry&quot;:&quot;互联网&quot;,&quot;textField_kzi3b7qj&quot;:&quot;推荐&quot;,&quot;usageNum_value&quot;:&quot;678&quot;,&quot;textField_kzi3b7qm&quot;:&quot;能力&quot;,&quot;scene&quot;:&quot;人事行政&quot;,&quot;usageNum&quot;:678,&quot;role_id&quot;:&quot;行政&quot;,&quot;suggest_id&quot;:&quot;快速入门&quot;,&quot;imageUrl&quot;:&quot;<a href="https://tianshu-vpc.oss-cn-shanghai.aliyuncs.com/72c0dcce-dded-417c-a003-db4679cc1c96.jpg%22,%22templateTitle%22:%22%E6%84%8F%E8%A7%81%E5%8F%8D%E9%A6%88%E8%A1%A8%22,%22guide%22:%22%22,%22orderNum_value%22:%2214%22,%22author%22:%22%E6%9D%AD%E5%B7%9E%E9%91%AB%E8%9C%82%E7%BB%B4%E7%BD%91%E7%BB%9C%E7%A7%91%E6%8A%80%E6%9C%89%E9%99%90%E5%85%AC%E5%8F%B8%22,%22appTplUuid%22:%22TPL_KI4RE0NWXGTA1DV028XR%22,%22textField_kzp6ix74%22:%22%E8%A1%8C%E4%B8%9A%22,%22scene_id%22:%22%E4%BA%BA%E4%BA%8B%E8%A1%8C%E6%94%BF%22,%22suggest%22:%22%E5%BF%AB%E9%80%9F%E5%85%A5%E9%97%A8%22,%22tags%22:%5B%22%E8%A1%A8%E5%8D%95%22%5D,%22isShow%22:%22%E6%98%BE%E7%A4%BA%22,%22isShow_id%22:%22y%22,%22tags_id%22:%5B%22%E8%A1%A8%E5%8D%95%22%5D%7D,%7B%22industry_id%22:%22%E5%88%B6%E9%80%A0%E4%B8%9A%22,%22role%22:%22%E7%94%9F%E4%BA%A7%22,%22textField_kzi3b7ql%22:%22%E5%9C%BA%E6%99%AF%22,%22textField_kzi3b7qk%22:%22%E8%A7%92%E8%89%B2%22,%22description%22:%22%E4%B8%80%E7%89%A9%E4%B8%80%E7%A0%81%EF%BC%8C%E4%B8%BA%E6%AF%8F%E5%8F%B0%E8%AE%BE%E5%A4%87%E7%94%9F%E6%88%90%E4%BA%8C%E7%BB%B4%E7%A0%81%EF%BC%8C%E5%B9%B6%E5%88%B6%E4%BD%9C%E6%88%90%E6%A0%87%E7%89%8C%E3%80%82%E4%B8%9A%E5%8A%A1%E5%B7%A1%E6%A3%80%E4%BA%BA%E5%91%98%E4%BD%BF%E7%94%A8%E9%92%89%E9%92%89%E6%89%AB%E7%A0%81%EF%BC%8C%E6%B7%BB%E5%8A%A0%E5%B7%A1%E6%A3%80%E5%92%8C%E7%BB%B4%E4%BF%AE%E8%AE%B0%E5%BD%95%EF%BC%8C%E4%B8%8A%E4%BC%A0%E7%8E%B0%E5%9C%BA%E7%85%A7%E7%89%87%EF%BC%8C%E5%AE%9E%E7%8E%B0%E6%97%A0%E7%BA%B8%E5%8C%96%E5%B7%A1%E6%A3%80%E3%80%82%22,%22orderNum%22:29,%22industry%22:%22%E5%88%B6%E9%80%A0%E4%B8%9A%22,%22textField_kzi3b7qj%22:%22%E6%8E%A8%E8%8D%90%22,%22usageNum_value%22:%22145%22,%22textField_kzi3b7qm%22:%22%E8%83%BD%E5%8A%9B%22,%22scene%22:%22%E4%B8%8D%E5%B1%95%E7%A4%BA%22,%22usageNum%22:145,%22category_id%22:%22NEW%22,%22role_id%22:%22%E7%94%9F%E4%BA%A7%22,%22suggest_id%22:%22%E5%BF%AB%E9%80%9F%E5%85%A5%E9%97%A8%22,%22imageUrl%22:%22https://tianshu-vpc.oss-cn-shanghai.aliyuncs.com/bb437d98-4015-4830-9224-42d90cfe6089.jpeg%22,%22templateTitle%22:%22%E8%AE%BE%E5%A4%87%E6%89%AB%E7%A0%81%E5%B7%A1%E6%A3%80%22,%22guide%22:%22%E4%B8%80%E7%89%A9%E4%B8%80%E7%A0%81%EF%BC%8C%E4%B8%BA%E6%AF%8F%E5%8F%B0%E8%AE%BE%E5%A4%87%E7%94%9F%E6%88%90%E4%BA%8C%E7%BB%B4%E7%A0%81%EF%BC%8C%E5%B9%B6%E5%88%B6%E4%BD%9C%E6%88%90%E6%A0%87%E7%89%8C%E3%80%82%E4%B8%9A%E5%8A%A1%E5%B7%A1%E6%A3%80%E4%BA%BA%E5%91%98%E4%BD%BF%E7%94%A8%E9%92%89%E9%92%89%E6%89%AB%E7%A0%81%EF%BC%8C%E6%B7%BB%E5%8A%A0%E5%B7%A1%E6%A3%80%E5%92%8C%E7%BB%B4%E4%BF%AE%E8%AE%B0%E5%BD%95%EF%BC%8C%E4%B8%8A%E4%BC%A0%E7%8E%B0%E5%9C%BA%E7%85%A7%E7%89%87%EF%BC%8C%E5%AE%9E%E7%8E%B0%E6%97%A0%E7%BA%B8%E5%8C%96%E5%B7%A1%E6%A3%80%E3%80%82%22,%22orderNum_value%22:%2229%22,%22author%22:%22%E5%AE%9C%E6%90%AD%E5%AE%98%E6%96%B9%22,%22appTplUuid%22:%22TPL_G4P53OFFXISLNOWZW0QT%22,%22textField_kzp6ix74%22:%22%E8%A1%8C%E4%B8%9A%22,%22scene_id%22:%22%E4%B8%8D%E5%B1%95%E7%A4%BA%22,%22suggest%22:%22%E5%BF%AB%E9%80%9F%E5%85%A5%E9%97%A8%22,%22tags%22:%5B%22%E4%BA%8C%E7%BB%B4%E7%A0%81%22%5D,%22isShow%22:%22%E6%98%BE%E7%A4%BA%22,%22isShow_id%22:%22y%22,%22tags_id%22:%5B%22%E4%BA%8C%E7%BB%B4%E7%A0%81%22%5D,%22category%22:%22NEW%22%7D,%7B%22industry_id%22:%22%E4%BA%92%E8%81%94%E7%BD%91%22,%22role%22:%22%E8%A1%8C%E6%94%BF%22,%22textField_kzi3b7ql%22:%22%E5%9C%BA%E6%99%AF%22,%22textField_kzi3b7qk%22:%22%E8%A7%92%E8%89%B2%22,%22description%22:%22%E6%98%AF%E5%9F%BA%E4%BA%8E%E4%BC%81%E4%B8%9A%E5%8A%9E%E5%85%AC%E7%89%A9%E5%93%81%E9%A2%86%E7%94%A8%E6%88%96%E7%94%B3%E8%AF%B7%E7%9A%84%E5%9C%BA%E6%99%AF%E4%B8%8B%EF%BC%8C%5Cn1%E3%80%81%E5%AF%B9%E7%89%A9%E5%93%81%E8%87%AA%E5%AE%9A%E4%B9%89%E7%9A%84%E5%BD%95%E5%85%A5%E5%92%8C%E4%BF%A1%E6%81%AF%E7%BB%B4%E6%8A%A4%E3%80%82%5Cn2%E3%80%81%E5%BA%93%E5%AD%98%E6%B5%81%E6%B0%B4%EF%BC%8C%E5%BA%93%E5%AD%98%E6%B1%87%E6%80%BB%E7%9A%84%E6%8A%A5%E8%A1%A8%E5%B1%95%E7%A4%BA%E3%80%82%5Cn%E7%94%B1%E6%9D%AD%E5%B7%9E%E9%91%AB%E5%B3%B0%E7%BB%B4%E7%BD%91%E7%BB%9C%E7%A7%91%E6%8A%80%E6%9C%89%E9%99%90%E5%85%AC%E5%8F%B8%E5%85%8D%E8%B4%B9%E6%8F%90%E4%BE%9B%EF%BC%8C%E5%8F%AF%E9%92%89%E9%92%89%E6%B2%9F%E9%80%9A%E6%88%96%E7%94%B5%E8%AF%9D%E5%92%A8%E8%AF%A2">https://tianshu-vpc.oss-cn-shanghai.aliyuncs.com/72c0dcce-dded-417c-a003-db4679cc1c96.jpg&quot;,&quot;templateTitle&quot;:&quot;意见反馈表&quot;,&quot;guide&quot;:&quot;&quot;,&quot;orderNum_value&quot;:&quot;14&quot;,&quot;author&quot;:&quot;杭州鑫蜂维网络科技有限公司&quot;,&quot;appTplUuid&quot;:&quot;TPL_KI4RE0NWXGTA1DV028XR&quot;,&quot;textField_kzp6ix74&quot;:&quot;行业&quot;,&quot;scene_id&quot;:&quot;人事行政&quot;,&quot;suggest&quot;:&quot;快速入门&quot;,&quot;tags&quot;:[&quot;表单&quot;],&quot;isShow&quot;:&quot;显示&quot;,&quot;isShow_id&quot;:&quot;y&quot;,&quot;tags_id&quot;:[&quot;表单&quot;]},{&quot;industry_id&quot;:&quot;制造业&quot;,&quot;role&quot;:&quot;生产&quot;,&quot;textField_kzi3b7ql&quot;:&quot;场景&quot;,&quot;textField_kzi3b7qk&quot;:&quot;角色&quot;,&quot;description&quot;:&quot;一物一码，为每台设备生成二维码，并制作成标牌。业务巡检人员使用钉钉扫码，添加巡检和维修记录，上传现场照片，实现无纸化巡检。&quot;,&quot;orderNum&quot;:29,&quot;industry&quot;:&quot;制造业&quot;,&quot;textField_kzi3b7qj&quot;:&quot;推荐&quot;,&quot;usageNum_value&quot;:&quot;145&quot;,&quot;textField_kzi3b7qm&quot;:&quot;能力&quot;,&quot;scene&quot;:&quot;不展示&quot;,&quot;usageNum&quot;:145,&quot;category_id&quot;:&quot;NEW&quot;,&quot;role_id&quot;:&quot;生产&quot;,&quot;suggest_id&quot;:&quot;快速入门&quot;,&quot;imageUrl&quot;:&quot;https://tianshu-vpc.oss-cn-shanghai.aliyuncs.com/bb437d98-4015-4830-9224-42d90cfe6089.jpeg&quot;,&quot;templateTitle&quot;:&quot;设备扫码巡检&quot;,&quot;guide&quot;:&quot;一物一码，为每台设备生成二维码，并制作成标牌。业务巡检人员使用钉钉扫码，添加巡检和维修记录，上传现场照片，实现无纸化巡检。&quot;,&quot;orderNum_value&quot;:&quot;29&quot;,&quot;author&quot;:&quot;宜搭官方&quot;,&quot;appTplUuid&quot;:&quot;TPL_G4P53OFFXISLNOWZW0QT&quot;,&quot;textField_kzp6ix74&quot;:&quot;行业&quot;,&quot;scene_id&quot;:&quot;不展示&quot;,&quot;suggest&quot;:&quot;快速入门&quot;,&quot;tags&quot;:[&quot;二维码&quot;],&quot;isShow&quot;:&quot;显示&quot;,&quot;isShow_id&quot;:&quot;y&quot;,&quot;tags_id&quot;:[&quot;二维码&quot;],&quot;category&quot;:&quot;NEW&quot;},{&quot;industry_id&quot;:&quot;互联网&quot;,&quot;role&quot;:&quot;行政&quot;,&quot;textField_kzi3b7ql&quot;:&quot;场景&quot;,&quot;textField_kzi3b7qk&quot;:&quot;角色&quot;,&quot;description&quot;:&quot;是基于企业办公物品领用或申请的场景下，\n1、对物品自定义的录入和信息维护。\n2、库存流水，库存汇总的报表展示。\n由杭州鑫峰维网络科技有限公司免费提供，可钉钉沟通或电话咨询</a> 肖经理：15869116881&quot;,&quot;orderNum&quot;:74,&quot;industry&quot;:&quot;互联网&quot;,&quot;textField_kzi3b7qj&quot;:&quot;推荐&quot;,&quot;usageNum_value&quot;:&quot;16238&quot;,&quot;textField_kzi3b7qm&quot;:&quot;能力&quot;,&quot;scene&quot;:&quot;人事行政&quot;,&quot;usageNum&quot;:16238,&quot;role_id&quot;:&quot;行政&quot;,&quot;suggest_id&quot;:&quot;快速入门&quot;,&quot;imageUrl&quot;:&quot;<a href="https://tianshu-vpc.oss-cn-shanghai.aliyuncs.com/8c6d63b2-8a9f-4b05-8299-79e7dd97efc9.jpg%22,%22templateTitle%22:%22%E5%8A%9E%E5%85%AC%E7%89%A9%E5%93%81%E7%94%B3%E8%AF%B7%22,%22guide%22:%22%22,%22orderNum_value%22:%2274%22,%22author%22:%22%E6%9D%AD%E5%B7%9E%E9%91%AB%E8%9C%82%E7%BB%B4%E7%BD%91%E7%BB%9C%E7%A7%91%E6%8A%80%E6%9C%89%E9%99%90%E5%85%AC%E5%8F%B8%22,%22appTplUuid%22:%22TPL_WDGWQFTJD6FCG44NM4JC%22,%22textField_kzp6ix74%22:%22%E8%A1%8C%E4%B8%9A%22,%22scene_id%22:%22%E4%BA%BA%E4%BA%8B%E8%A1%8C%E6%94%BF%22,%22suggest%22:%22%E5%BF%AB%E9%80%9F%E5%85%A5%E9%97%A8%22,%22tags%22:%5B%22%E6%B5%81%E7%A8%8B%E8%A1%A8%E5%8D%95%22%5D,%22isShow%22:%22%E6%98%BE%E7%A4%BA%22,%22isShow_id%22:%22y%22,%22tags_id%22:%5B%22%E6%B5%81%E7%A8%8B%E8%A1%A8%E5%8D%95%22%5D%7D,%7B%22industry_id%22:%22%E4%BA%92%E8%81%94%E7%BD%91%22,%22role%22:%22%E8%A1%8C%E6%94%BF%22,%22textField_kzi3b7ql%22:%22%E5%9C%BA%E6%99%AF%22,%22textField_kzi3b7qk%22:%22%E8%A7%92%E8%89%B2%22,%22description%22:%22%E5%80%9F%E7%94%A8%E5%AE%9C%E6%90%AD%E6%9C%80%E6%96%B0%E8%BF%9E%E6%8E%A5%E5%99%A8%E8%83%BD%E5%8A%9B%EF%BC%8C%E6%B4%BB%E5%8A%A8%E6%8A%A5%E5%90%8D%E7%94%B3%E8%AF%B7%E9%80%9A%E8%BF%87%E5%90%8E%E8%87%AA%E5%8A%A8%E6%8B%89%E5%85%A5%E6%8C%87%E5%AE%9A%E7%BE%A4%E3%80%82%22,%22orderNum%22:145,%22industry%22:%22%E4%BA%92%E8%81%94%E7%BD%91%22,%22textField_kzi3b7qj%22:%22%E6%8E%A8%E8%8D%90%22,%22usageNum_value%22:%222522%22,%22textField_kzi3b7qm%22:%22%E8%83%BD%E5%8A%9B%22,%22scene%22:%22%E4%BA%BA%E4%BA%8B%E8%A1%8C%E6%94%BF%22,%22usageNum%22:2522,%22role_id%22:%22%E8%A1%8C%E6%94%BF%22,%22suggest_id%22:%22%E5%BF%AB%E9%80%9F%E5%85%A5%E9%97%A8%22,%22imageUrl%22:%22https://tianshu-vpc.oss-cn-shanghai.aliyuncs.com/9b6d7f1a-135b-435a-88c5-97e9fed7e75c.jpg%22,%22templateTitle%22:%22%E6%B4%BB%E5%8A%A8%E6%8A%A5%E5%90%8D%22,%22guide%22:%22%22,%22orderNum_value%22:%22145%22,%22author%22:%22%E5%AE%9C%E6%90%AD%E5%AE%98%E6%96%B9%22,%22appTplUuid%22:%22TPL_GLXCK24WLMDCRV8EMU0K%22,%22textField_kzp6ix74%22:%22%E8%A1%8C%E4%B8%9A%22,%22scene_id%22:%22%E4%BA%BA%E4%BA%8B%E8%A1%8C%E6%94%BF%22,%22suggest%22:%22%E5%BF%AB%E9%80%9F%E5%85%A5%E9%97%A8%22,%22tags%22:%5B%22%E8%BF%9E%E6%8E%A5%E5%99%A8%22%5D,%22isShow%22:%22%E6%98%BE%E7%A4%BA%22,%22isShow_id%22:%22y%22,%22tags_id%22:%5B%22%E8%BF%9E%E6%8E%A5%E5%99%A8%22%5D%7D,%7B%22industry_id%22:%22%E4%BA%92%E8%81%94%E7%BD%91%22,%22role%22:%22%E4%BA%BA%E4%BA%8B%22,%22textField_kzi3b7ql%22:%22%E5%9C%BA%E6%99%AF%22,%22textField_kzi3b7qk%22:%22%E8%A7%92%E8%89%B2%22,%22description%22:%22%E4%B8%80%E9%94%AE%E5%AF%BC%E5%85%A5%E5%B7%A5%E8%B5%84%EF%BC%8C%E7%94%9F%E6%88%90%E5%B7%A5%E8%B5%84%E6%9D%A1%E6%B6%88%E6%81%AF%EF%BC%8C%E9%92%89%E9%92%89%E6%B6%88%E6%81%AF%E6%9F%A5%E7%9C%8B%E5%B7%A5%E8%B5%84%E6%9D%A1%22,%22orderNum%22:277,%22industry%22:%22%E4%BA%92%E8%81%94%E7%BD%91%22,%22textField_kzi3b7qj%22:%22%E6%8E%A8%E8%8D%90%22,%22usageNum_value%22:%22746%22,%22textField_kzi3b7qm%22:%22%E8%83%BD%E5%8A%9B%22,%22scene%22:%22%E4%BA%BA%E4%BA%8B%E8%A1%8C%E6%94%BF%22,%22usageNum%22:746,%22role_id%22:%22%E4%BA%BA%E4%BA%8B%22,%22suggest_id%22:%22%E5%BF%AB%E9%80%9F%E5%85%A5%E9%97%A8%22,%22imageUrl%22:%22https://tianshu-vpc.oss-cn-shanghai.aliyuncs.com/462be093-cc4f-4e7e-a72e-bdf15c2edfb7.jpg%22,%22templateTitle%22:%22%E5%B7%A5%E8%B5%84%E6%9D%A1%22,%22guide%22:%22%22,%22orderNum_value%22:%22277%22,%22author%22:%22%E5%B9%BF%E5%B7%9E%E6%B1%87%E5%8D%8E%E4%BF%A1%E6%81%AF%E7%A7%91%E6%8A%80%E6%9C%89%E9%99%90%E5%85%AC%E5%8F%B8%22,%22appTplUuid%22:%22TPL_DQXKIBK2E06KKOP2BX2B%22,%22textField_kzp6ix74%22:%22%E8%A1%8C%E4%B8%9A%22,%22scene_id%22:%22%E4%BA%BA%E4%BA%8B%E8%A1%8C%E6%94%BF%22,%22suggest%22:%22%E5%BF%AB%E9%80%9F%E5%85%A5%E9%97%A8%22,%22tags%22:%5B%22%E8%A1%A8%E5%8D%95%22,%22%E5%BF%AB%E6%8D%B7%E6%B6%88%E6%81%AF%22%5D,%22isShow%22:%22%E6%98%BE%E7%A4%BA%22,%22isShow_id%22:%22y%22,%22tags_id%22:%5B%22%E5%BF%AB%E6%8D%B7%E6%B6%88%E6%81%AF%22,%22%E8%A1%A8%E5%8D%95%22%5D%7D,%7B%22industry_id%22:%22%E6%95%99%E8%82%B2%E8%A1%8C%E4%B8%9A%22,%22role%22:%22%E8%A1%8C%E6%94%BF%22,%22textField_kzi3b7ql%22:%22%E5%9C%BA%E6%99%AF%22,%22textField_kzi3b7qk%22:%22%E8%A7%92%E8%89%B2%22,%22description%22:%22%E5%A4%9A%E5%B2%97%E4%BD%8D%E3%80%81%E5%A4%9A%E6%A0%A1%E5%8C%BA%E3%80%81%E6%B6%89%E5%8F%8A%E4%BA%BA%E5%91%98%E5%A4%9A%EF%BC%8C%E7%8F%AD%E6%AC%A1%E5%A4%9A%EF%BC%8C%E8%B0%83%E7%8F%AD%E5%A4%9A%EF%BC%9B%5Cn%E5%80%BC%E7%8F%AD%E5%B2%97%E4%BD%8D%EF%BC%8C%E5%80%BC%E7%8F%AD%E4%BA%BA%E5%91%98%E4%B8%80%E7%9B%AE%E4%BA%86%E7%84%B6%EF%BC%9B%E7%BA%BF%E4%B8%8A%E8%B0%83%E7%8F%AD%EF%BC%8C%E5%80%BC%E7%8F%AD%E8%A1%A8%E4%BF%A1%E6%81%AF%E5%90%8C%E6%AD%A5%EF%BC%9B%5Cn%E5%80%BC%E7%8F%AD%E9%80%9A%E7%9F%A5%EF%BC%8C%E7%B3%BB%E7%BB%9F%E8%87%AA%E5%8A%A8%E6%8E%A8%E9%80%81%EF%BC%9B%E5%80%BC%E7%8F%AD%E6%97%A5%E5%BF%97%EF%BC%8C%E8%AE%B0%E5%BD%95%E7%95%99%E7%97%95%E5%8F%AF%E6%9F%A5%EF%BC%9B%5Cn%E5%80%BC%E7%8F%AD%E9%98%85%E8%A7%88%E5%AE%A4%EF%BC%8C%E6%9C%80%E6%96%B0%E5%85%AC%E5%91%8A%E3%80%81%E6%B5%81%E7%A8%8B%E6%B1%87%E6%80%BB%E5%8F%AF%E6%9F%A5%22,%22orderNum%22:318,%22industry%22:%22%E6%95%99%E8%82%B2%E8%A1%8C%E4%B8%9A%22,%22textField_kzi3b7qj%22:%22%E6%8E%A8%E8%8D%90%22,%22usageNum_value%22:%22608%22,%22textField_kzi3b7qm%22:%22%E8%83%BD%E5%8A%9B%22,%22scene%22:%22%E4%B8%8D%E5%B1%95%E7%A4%BA%22,%22usageNum%22:608,%22role_id%22:%22%E8%A1%8C%E6%94%BF%22,%22suggest_id%22:%22%E5%BF%AB%E9%80%9F%E5%85%A5%E9%97%A8%22,%22imageUrl%22:%22https://tianshu-vpc.oss-cn-shanghai.aliyuncs.com/16d71251-a7ef-4a23-bcb0-77563bd3f7a9.jpg?x-oss-process=image/resize,m_fixed,h_380,w_680%22,%22templateTitle%22:%22%E5%80%BC%E7%8F%AD%E7%AE%A1%E7%90%86%E7%B3%BB%E7%BB%9F%22,%22guide%22:%22%E5%A4%9A%E5%B2%97%E4%BD%8D%E3%80%81%E5%A4%9A%E6%A0%A1%E5%8C%BA%E3%80%81%E6%B6%89%E5%8F%8A%E4%BA%BA%E5%91%98%E5%A4%9A%EF%BC%8C%E7%8F%AD%E6%AC%A1%E5%A4%9A%EF%BC%8C%E8%B0%83%E7%8F%AD%E5%A4%9A%EF%BC%9B%5Cn%E5%80%BC%E7%8F%AD%E5%B2%97%E4%BD%8D%EF%BC%8C%E5%80%BC%E7%8F%AD%E4%BA%BA%E5%91%98%E4%B8%80%E7%9B%AE%E4%BA%86%E7%84%B6%EF%BC%9B%E7%BA%BF%E4%B8%8A%E8%B0%83%E7%8F%AD%EF%BC%8C%E5%80%BC%E7%8F%AD%E8%A1%A8%E4%BF%A1%E6%81%AF%E5%90%8C%E6%AD%A5%EF%BC%9B%5Cn%E5%80%BC%E7%8F%AD%E9%80%9A%E7%9F%A5%EF%BC%8C%E7%B3%BB%E7%BB%9F%E8%87%AA%E5%8A%A8%E6%8E%A8%E9%80%81%EF%BC%9B%E5%80%BC%E7%8F%AD%E6%97%A5%E5%BF%97%EF%BC%8C%E8%AE%B0%E5%BD%95%E7%95%99%E7%97%95%E5%8F%AF%E6%9F%A5%EF%BC%9B%5Cn%E5%80%BC%E7%8F%AD%E9%98%85%E8%A7%88%E5%AE%A4%EF%BC%8C%E6%9C%80%E6%96%B0%E5%85%AC%E5%91%8A%E3%80%81%E6%B5%81%E7%A8%8B%E6%B1%87%E6%80%BB%E5%8F%AF%E6%9F%A5%22,%22orderNum_value%22:%22318%22,%22author%22:%22%E5%AE%9C%E6%90%AD%E5%AE%98%E6%96%B9%22,%22appTplUuid%22:%22TPL_HC18Z4Y3SQDWO2SH1ZT9%22,%22textField_kzp6ix74%22:%22%E8%A1%8C%E4%B8%9A%22,%22scene_id%22:%22%E4%B8%8D%E5%B1%95%E7%A4%BA%22,%22suggest%22:%22%E5%BF%AB%E9%80%9F%E5%85%A5%E9%97%A8%22,%22tags%22:%5B%22%E6%B5%81%E7%A8%8B%E8%A1%A8%E5%8D%95%22%5D,%22isShow%22:%22%E6%98%BE%E7%A4%BA%22,%22isShow_id%22:%22y%22,%22tags_id%22:%5B%22%E6%B5%81%E7%A8%8B%E8%A1%A8%E5%8D%95%22%5D%7D%5D,%22entities%22:null,%22hasMore%22:false,%22idCursor%22:0,%22totalCount%22:7%7D,%22errorCode%22:%22%22,%22errorExtInfo%22:null,%22errorLevel%22:%22%22,%22errorMsg%22:%22%22,%22success%22:true,%22throwable%22:%22%22%7D">https://tianshu-vpc.oss-cn-shanghai.aliyuncs.com/8c6d63b2-8a9f-4b05-8299-79e7dd97efc9.jpg&quot;,&quot;templateTitle&quot;:&quot;办公物品申请&quot;,&quot;guide&quot;:&quot;&quot;,&quot;orderNum_value&quot;:&quot;74&quot;,&quot;author&quot;:&quot;杭州鑫蜂维网络科技有限公司&quot;,&quot;appTplUuid&quot;:&quot;TPL_WDGWQFTJD6FCG44NM4JC&quot;,&quot;textField_kzp6ix74&quot;:&quot;行业&quot;,&quot;scene_id&quot;:&quot;人事行政&quot;,&quot;suggest&quot;:&quot;快速入门&quot;,&quot;tags&quot;:[&quot;流程表单&quot;],&quot;isShow&quot;:&quot;显示&quot;,&quot;isShow_id&quot;:&quot;y&quot;,&quot;tags_id&quot;:[&quot;流程表单&quot;]},{&quot;industry_id&quot;:&quot;互联网&quot;,&quot;role&quot;:&quot;行政&quot;,&quot;textField_kzi3b7ql&quot;:&quot;场景&quot;,&quot;textField_kzi3b7qk&quot;:&quot;角色&quot;,&quot;description&quot;:&quot;借用宜搭最新连接器能力，活动报名申请通过后自动拉入指定群。&quot;,&quot;orderNum&quot;:145,&quot;industry&quot;:&quot;互联网&quot;,&quot;textField_kzi3b7qj&quot;:&quot;推荐&quot;,&quot;usageNum_value&quot;:&quot;2522&quot;,&quot;textField_kzi3b7qm&quot;:&quot;能力&quot;,&quot;scene&quot;:&quot;人事行政&quot;,&quot;usageNum&quot;:2522,&quot;role_id&quot;:&quot;行政&quot;,&quot;suggest_id&quot;:&quot;快速入门&quot;,&quot;imageUrl&quot;:&quot;https://tianshu-vpc.oss-cn-shanghai.aliyuncs.com/9b6d7f1a-135b-435a-88c5-97e9fed7e75c.jpg&quot;,&quot;templateTitle&quot;:&quot;活动报名&quot;,&quot;guide&quot;:&quot;&quot;,&quot;orderNum_value&quot;:&quot;145&quot;,&quot;author&quot;:&quot;宜搭官方&quot;,&quot;appTplUuid&quot;:&quot;TPL_GLXCK24WLMDCRV8EMU0K&quot;,&quot;textField_kzp6ix74&quot;:&quot;行业&quot;,&quot;scene_id&quot;:&quot;人事行政&quot;,&quot;suggest&quot;:&quot;快速入门&quot;,&quot;tags&quot;:[&quot;连接器&quot;],&quot;isShow&quot;:&quot;显示&quot;,&quot;isShow_id&quot;:&quot;y&quot;,&quot;tags_id&quot;:[&quot;连接器&quot;]},{&quot;industry_id&quot;:&quot;互联网&quot;,&quot;role&quot;:&quot;人事&quot;,&quot;textField_kzi3b7ql&quot;:&quot;场景&quot;,&quot;textField_kzi3b7qk&quot;:&quot;角色&quot;,&quot;description&quot;:&quot;一键导入工资，生成工资条消息，钉钉消息查看工资条&quot;,&quot;orderNum&quot;:277,&quot;industry&quot;:&quot;互联网&quot;,&quot;textField_kzi3b7qj&quot;:&quot;推荐&quot;,&quot;usageNum_value&quot;:&quot;746&quot;,&quot;textField_kzi3b7qm&quot;:&quot;能力&quot;,&quot;scene&quot;:&quot;人事行政&quot;,&quot;usageNum&quot;:746,&quot;role_id&quot;:&quot;人事&quot;,&quot;suggest_id&quot;:&quot;快速入门&quot;,&quot;imageUrl&quot;:&quot;https://tianshu-vpc.oss-cn-shanghai.aliyuncs.com/462be093-cc4f-4e7e-a72e-bdf15c2edfb7.jpg&quot;,&quot;templateTitle&quot;:&quot;工资条&quot;,&quot;guide&quot;:&quot;&quot;,&quot;orderNum_value&quot;:&quot;277&quot;,&quot;author&quot;:&quot;广州汇华信息科技有限公司&quot;,&quot;appTplUuid&quot;:&quot;TPL_DQXKIBK2E06KKOP2BX2B&quot;,&quot;textField_kzp6ix74&quot;:&quot;行业&quot;,&quot;scene_id&quot;:&quot;人事行政&quot;,&quot;suggest&quot;:&quot;快速入门&quot;,&quot;tags&quot;:[&quot;表单&quot;,&quot;快捷消息&quot;],&quot;isShow&quot;:&quot;显示&quot;,&quot;isShow_id&quot;:&quot;y&quot;,&quot;tags_id&quot;:[&quot;快捷消息&quot;,&quot;表单&quot;]},{&quot;industry_id&quot;:&quot;教育行业&quot;,&quot;role&quot;:&quot;行政&quot;,&quot;textField_kzi3b7ql&quot;:&quot;场景&quot;,&quot;textField_kzi3b7qk&quot;:&quot;角色&quot;,&quot;description&quot;:&quot;多岗位、多校区、涉及人员多，班次多，调班多；\n值班岗位，值班人员一目了然；线上调班，值班表信息同步；\n值班通知，系统自动推送；值班日志，记录留痕可查；\n值班阅览室，最新公告、流程汇总可查&quot;,&quot;orderNum&quot;:318,&quot;industry&quot;:&quot;教育行业&quot;,&quot;textField_kzi3b7qj&quot;:&quot;推荐&quot;,&quot;usageNum_value&quot;:&quot;608&quot;,&quot;textField_kzi3b7qm&quot;:&quot;能力&quot;,&quot;scene&quot;:&quot;不展示&quot;,&quot;usageNum&quot;:608,&quot;role_id&quot;:&quot;行政&quot;,&quot;suggest_id&quot;:&quot;快速入门&quot;,&quot;imageUrl&quot;:&quot;https://tianshu-vpc.oss-cn-shanghai.aliyuncs.com/16d71251-a7ef-4a23-bcb0-77563bd3f7a9.jpg?x-oss-process=image/resize,m_fixed,h_380,w_680&quot;,&quot;templateTitle&quot;:&quot;值班管理系统&quot;,&quot;guide&quot;:&quot;多岗位、多校区、涉及人员多，班次多，调班多；\n值班岗位，值班人员一目了然；线上调班，值班表信息同步；\n值班通知，系统自动推送；值班日志，记录留痕可查；\n值班阅览室，最新公告、流程汇总可查&quot;,&quot;orderNum_value&quot;:&quot;318&quot;,&quot;author&quot;:&quot;宜搭官方&quot;,&quot;appTplUuid&quot;:&quot;TPL_HC18Z4Y3SQDWO2SH1ZT9&quot;,&quot;textField_kzp6ix74&quot;:&quot;行业&quot;,&quot;scene_id&quot;:&quot;不展示&quot;,&quot;suggest&quot;:&quot;快速入门&quot;,&quot;tags&quot;:[&quot;流程表单&quot;],&quot;isShow&quot;:&quot;显示&quot;,&quot;isShow_id&quot;:&quot;y&quot;,&quot;tags_id&quot;:[&quot;流程表单&quot;]}],&quot;entities&quot;:null,&quot;hasMore&quot;:false,&quot;idCursor&quot;:0,&quot;totalCount&quot;:7},&quot;errorCode&quot;:&quot;&quot;,&quot;errorExtInfo&quot;:null,&quot;errorLevel&quot;:&quot;&quot;,&quot;errorMsg&quot;:&quot;&quot;,&quot;success&quot;:true,&quot;throwable&quot;:&quot;&quot;}</a></p>
         */
        @NameInMap("invokeResult")
        public String invokeResult;

        /**
         * <strong>example:</strong>
         * <p>可选值：SUCCESS、FAIL、FINAL_SUCCESS、ERROR</p>
         */
        @NameInMap("invokeStatus")
        public String invokeStatus;

        /**
         * <strong>example:</strong>
         * <p>成功：y，失败：n</p>
         */
        @NameInMap("invokeSuccess")
        public String invokeSuccess;

        /**
         * <strong>example:</strong>
         * <p><a href="https://www.aliwork.com/query/loginFreeFormData/listFormDataByType.json?type=templateCenter&searchFieldJson=%7B%22isShow%22%3A%22y%22%2C%22suggest%22%3A%22%E5%BF%AB%E9%80%9F%E5%85%A5%E9%97%A8%22%2C%22industry%22%3A%22%22%2C%22role%22%3A%22%22%2C%22tags%22%3A%22%22%2C%22templateTitle%22%3A%22%22%7D&dynamicOrder=%7B%22orderNum%22%3A%22%2B%22%7D&pageSize=48&currentPage=1">https://www.aliwork.com/query/loginFreeFormData/listFormDataByType.json?type=templateCenter&amp;searchFieldJson=%7B%22isShow%22%3A%22y%22%2C%22suggest%22%3A%22%E5%BF%AB%E9%80%9F%E5%85%A5%E9%97%A8%22%2C%22industry%22%3A%22%22%2C%22role%22%3A%22%22%2C%22tags%22%3A%22%22%2C%22templateTitle%22%3A%22%22%7D&amp;dynamicOrder=%7B%22orderNum%22%3A%22%2B%22%7D&amp;pageSize=48&amp;currentPage=1</a></p>
         */
        @NameInMap("invokeUrl")
        public String invokeUrl;

        /**
         * <strong>example:</strong>
         * <p>{&quot;url&quot;:&quot;<a href="https://www.aliwork.com/query/loginFreeFormData/listFormDataByType.json?type=templateCenter&searchFieldJson=%7B%22isShow%22%3A%22y%22%2C%22suggest%22%3A%22%E5%BF%AB%E9%80%9F%E5%85%A5%E9%97%A8%22%2C%22industry%22%3A%22%22%2C%22role%22%3A%22%22%2C%22tags%22%3A%22%22%2C%22templateTitle%22%3A%22%22%7D&dynamicOrder=%7B%22orderNum%22%3A%22%2B%22%7D&pageSize=48&currentPage=1%22,%22isMd5%22:null,%22signature%22:%22%22,%22isSHA%22:null,%22hmacSecret%22:%22%22,%22type%22:%22HttpExt%22,%22params%22:%5B%7B%22field%22:%22name%22,%22value%22:%22name%22,%22label%22:%7B%22zh_CN%22:%22name%22,%22en_US%22:%22name%22,%22type%22:%22i18n%22%7D,%22type%22:%22java.lang.String%22%7D%5D%7D">https://www.aliwork.com/query/loginFreeFormData/listFormDataByType.json?type=templateCenter&amp;searchFieldJson=%7B%22isShow%22%3A%22y%22%2C%22suggest%22%3A%22%E5%BF%AB%E9%80%9F%E5%85%A5%E9%97%A8%22%2C%22industry%22%3A%22%22%2C%22role%22%3A%22%22%2C%22tags%22%3A%22%22%2C%22templateTitle%22%3A%22%22%7D&amp;dynamicOrder=%7B%22orderNum%22%3A%22%2B%22%7D&amp;pageSize=48&amp;currentPage=1&quot;,&quot;isMd5&quot;:null,&quot;signature&quot;:&quot;&quot;,&quot;isSHA&quot;:null,&quot;hmacSecret&quot;:&quot;&quot;,&quot;type&quot;:&quot;HttpExt&quot;,&quot;params&quot;:[{&quot;field&quot;:&quot;name&quot;,&quot;value&quot;:&quot;name&quot;,&quot;label&quot;:{&quot;zh_CN&quot;:&quot;name&quot;,&quot;en_US&quot;:&quot;name&quot;,&quot;type&quot;:&quot;i18n&quot;},&quot;type&quot;:&quot;java.lang.String&quot;}]}</a></p>
         */
        @NameInMap("serviceContent")
        public String serviceContent;

        /**
         * <strong>example:</strong>
         * <p>查询宜搭模板</p>
         */
        @NameInMap("serviceName")
        public String serviceName;

        /**
         * <strong>example:</strong>
         * <p>{&quot;parameter1&quot;:&quot;测试服务执行&quot;}</p>
         */
        @NameInMap("serviceParameter")
        public String serviceParameter;

        /**
         * <strong>example:</strong>
         * <p>INVOKE-E7766VC1KJ4ZVFCR346USCT2ORYI2UVRBHA1LI</p>
         */
        @NameInMap("sourceUuid")
        public String sourceUuid;

        public static QueryServiceRecordResponseBodyValues build(java.util.Map<String, ?> map) throws Exception {
            QueryServiceRecordResponseBodyValues self = new QueryServiceRecordResponseBodyValues();
            return TeaModel.build(map, self);
        }

        public QueryServiceRecordResponseBodyValues setFormInstanceId(String formInstanceId) {
            this.formInstanceId = formInstanceId;
            return this;
        }
        public String getFormInstanceId() {
            return this.formInstanceId;
        }

        public QueryServiceRecordResponseBodyValues setFormUuid(String formUuid) {
            this.formUuid = formUuid;
            return this;
        }
        public String getFormUuid() {
            return this.formUuid;
        }

        public QueryServiceRecordResponseBodyValues setHookType(String hookType) {
            this.hookType = hookType;
            return this;
        }
        public String getHookType() {
            return this.hookType;
        }

        public QueryServiceRecordResponseBodyValues setHookUuid(String hookUuid) {
            this.hookUuid = hookUuid;
            return this;
        }
        public String getHookUuid() {
            return this.hookUuid;
        }

        public QueryServiceRecordResponseBodyValues setInvokeParameter(String invokeParameter) {
            this.invokeParameter = invokeParameter;
            return this;
        }
        public String getInvokeParameter() {
            return this.invokeParameter;
        }

        public QueryServiceRecordResponseBodyValues setInvokeResult(String invokeResult) {
            this.invokeResult = invokeResult;
            return this;
        }
        public String getInvokeResult() {
            return this.invokeResult;
        }

        public QueryServiceRecordResponseBodyValues setInvokeStatus(String invokeStatus) {
            this.invokeStatus = invokeStatus;
            return this;
        }
        public String getInvokeStatus() {
            return this.invokeStatus;
        }

        public QueryServiceRecordResponseBodyValues setInvokeSuccess(String invokeSuccess) {
            this.invokeSuccess = invokeSuccess;
            return this;
        }
        public String getInvokeSuccess() {
            return this.invokeSuccess;
        }

        public QueryServiceRecordResponseBodyValues setInvokeUrl(String invokeUrl) {
            this.invokeUrl = invokeUrl;
            return this;
        }
        public String getInvokeUrl() {
            return this.invokeUrl;
        }

        public QueryServiceRecordResponseBodyValues setServiceContent(String serviceContent) {
            this.serviceContent = serviceContent;
            return this;
        }
        public String getServiceContent() {
            return this.serviceContent;
        }

        public QueryServiceRecordResponseBodyValues setServiceName(String serviceName) {
            this.serviceName = serviceName;
            return this;
        }
        public String getServiceName() {
            return this.serviceName;
        }

        public QueryServiceRecordResponseBodyValues setServiceParameter(String serviceParameter) {
            this.serviceParameter = serviceParameter;
            return this;
        }
        public String getServiceParameter() {
            return this.serviceParameter;
        }

        public QueryServiceRecordResponseBodyValues setSourceUuid(String sourceUuid) {
            this.sourceUuid = sourceUuid;
            return this;
        }
        public String getSourceUuid() {
            return this.sourceUuid;
        }

    }

}
