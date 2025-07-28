<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\QueryServiceRecordResponseBody;

use AlibabaCloud\Tea\Model;

class values extends Model
{
    /**
     * @example FINST-J8766S91O2UYN87ZX3XOF1MY8MBA2912BSV0L24
     *
     * @var string
     */
    public $formInstanceId;

    /**
     * @example FORM-GX866MC1NC1VOFF6WVQW33FD16E23L3CPMKVKA
     *
     * @var string
     */
    public $formUuid;

    /**
     * @example HTTP
     *
     * @var string
     */
    public $hookType;

    /**
     * @example INVOKE-E7766VC1KJ4ZVFCR346USCT2ORYI2UVRBHA1L0
     *
     * @var string
     */
    public $hookUuid;

    /**
     * @example {"parameter1":"测试服务执行"}
     *
     * @var string
     */
    public $invokeParameter;

    /**
     * @example {"content":{"currentPage":1,"data":[{"industry_id":"互联网","role":"人事","textField_kzi3b7ql":"场景","textField_kzi3b7qk":"角色","description":"用于企业员工假期请假、值班、就近办公等信息统计，便于假期工作事项安排。","orderNum":5,"industry":"互联网","textField_kzi3b7qj":"推荐","usageNum_value":"3365","textField_kzi3b7qm":"能力","scene":"企业应用","usageNum":3365,"role_id":"人事","suggest_id":"快速入门","imageUrl":"https://tianshu-vpc.oss-cn-shanghai.aliyuncs.com/49315603-3a20-4bd8-aeb0-a1430be3177a.jpg","templateTitle":"员工排班表","guide":"","orderNum_value":"5","author":"宜搭官方","appTplUuid":"TPL_RAOW06MPQBKKNENFMD5U","textField_kzp6ix74":"行业","scene_id":"企业应用","suggest":"快速入门","tags":["表单"],"isShow":"显示","isShow_id":"y","tags_id":["表单"]},{"industry_id":"互联网","role":"行政","textField_kzi3b7ql":"场景","textField_kzi3b7qk":"角色","description":"1.可用于公司内部收集员工意见。\n2.可意见类型对意见进行整理。\n由杭州鑫峰维网络科技有限公司免费提供，可钉钉沟通或电话咨询 肖经理：15869116881","orderNum":14,"industry":"互联网","textField_kzi3b7qj":"推荐","usageNum_value":"678","textField_kzi3b7qm":"能力","scene":"人事行政","usageNum":678,"role_id":"行政","suggest_id":"快速入门","imageUrl":"https://tianshu-vpc.oss-cn-shanghai.aliyuncs.com/72c0dcce-dded-417c-a003-db4679cc1c96.jpg","templateTitle":"意见反馈表","guide":"","orderNum_value":"14","author":"杭州鑫蜂维网络科技有限公司","appTplUuid":"TPL_KI4RE0NWXGTA1DV028XR","textField_kzp6ix74":"行业","scene_id":"人事行政","suggest":"快速入门","tags":["表单"],"isShow":"显示","isShow_id":"y","tags_id":["表单"]},{"industry_id":"制造业","role":"生产","textField_kzi3b7ql":"场景","textField_kzi3b7qk":"角色","description":"一物一码，为每台设备生成二维码，并制作成标牌。业务巡检人员使用钉钉扫码，添加巡检和维修记录，上传现场照片，实现无纸化巡检。","orderNum":29,"industry":"制造业","textField_kzi3b7qj":"推荐","usageNum_value":"145","textField_kzi3b7qm":"能力","scene":"不展示","usageNum":145,"category_id":"NEW","role_id":"生产","suggest_id":"快速入门","imageUrl":"https://tianshu-vpc.oss-cn-shanghai.aliyuncs.com/bb437d98-4015-4830-9224-42d90cfe6089.jpeg","templateTitle":"设备扫码巡检","guide":"一物一码，为每台设备生成二维码，并制作成标牌。业务巡检人员使用钉钉扫码，添加巡检和维修记录，上传现场照片，实现无纸化巡检。","orderNum_value":"29","author":"宜搭官方","appTplUuid":"TPL_G4P53OFFXISLNOWZW0QT","textField_kzp6ix74":"行业","scene_id":"不展示","suggest":"快速入门","tags":["二维码"],"isShow":"显示","isShow_id":"y","tags_id":["二维码"],"category":"NEW"},{"industry_id":"互联网","role":"行政","textField_kzi3b7ql":"场景","textField_kzi3b7qk":"角色","description":"是基于企业办公物品领用或申请的场景下，\n1、对物品自定义的录入和信息维护。\n2、库存流水，库存汇总的报表展示。\n由杭州鑫峰维网络科技有限公司免费提供，可钉钉沟通或电话咨询 肖经理：15869116881","orderNum":74,"industry":"互联网","textField_kzi3b7qj":"推荐","usageNum_value":"16238","textField_kzi3b7qm":"能力","scene":"人事行政","usageNum":16238,"role_id":"行政","suggest_id":"快速入门","imageUrl":"https://tianshu-vpc.oss-cn-shanghai.aliyuncs.com/8c6d63b2-8a9f-4b05-8299-79e7dd97efc9.jpg","templateTitle":"办公物品申请","guide":"","orderNum_value":"74","author":"杭州鑫蜂维网络科技有限公司","appTplUuid":"TPL_WDGWQFTJD6FCG44NM4JC","textField_kzp6ix74":"行业","scene_id":"人事行政","suggest":"快速入门","tags":["流程表单"],"isShow":"显示","isShow_id":"y","tags_id":["流程表单"]},{"industry_id":"互联网","role":"行政","textField_kzi3b7ql":"场景","textField_kzi3b7qk":"角色","description":"借用宜搭最新连接器能力，活动报名申请通过后自动拉入指定群。","orderNum":145,"industry":"互联网","textField_kzi3b7qj":"推荐","usageNum_value":"2522","textField_kzi3b7qm":"能力","scene":"人事行政","usageNum":2522,"role_id":"行政","suggest_id":"快速入门","imageUrl":"https://tianshu-vpc.oss-cn-shanghai.aliyuncs.com/9b6d7f1a-135b-435a-88c5-97e9fed7e75c.jpg","templateTitle":"活动报名","guide":"","orderNum_value":"145","author":"宜搭官方","appTplUuid":"TPL_GLXCK24WLMDCRV8EMU0K","textField_kzp6ix74":"行业","scene_id":"人事行政","suggest":"快速入门","tags":["连接器"],"isShow":"显示","isShow_id":"y","tags_id":["连接器"]},{"industry_id":"互联网","role":"人事","textField_kzi3b7ql":"场景","textField_kzi3b7qk":"角色","description":"一键导入工资，生成工资条消息，钉钉消息查看工资条","orderNum":277,"industry":"互联网","textField_kzi3b7qj":"推荐","usageNum_value":"746","textField_kzi3b7qm":"能力","scene":"人事行政","usageNum":746,"role_id":"人事","suggest_id":"快速入门","imageUrl":"https://tianshu-vpc.oss-cn-shanghai.aliyuncs.com/462be093-cc4f-4e7e-a72e-bdf15c2edfb7.jpg","templateTitle":"工资条","guide":"","orderNum_value":"277","author":"广州汇华信息科技有限公司","appTplUuid":"TPL_DQXKIBK2E06KKOP2BX2B","textField_kzp6ix74":"行业","scene_id":"人事行政","suggest":"快速入门","tags":["表单","快捷消息"],"isShow":"显示","isShow_id":"y","tags_id":["快捷消息","表单"]},{"industry_id":"教育行业","role":"行政","textField_kzi3b7ql":"场景","textField_kzi3b7qk":"角色","description":"多岗位、多校区、涉及人员多，班次多，调班多；\n值班岗位，值班人员一目了然；线上调班，值班表信息同步；\n值班通知，系统自动推送；值班日志，记录留痕可查；\n值班阅览室，最新公告、流程汇总可查","orderNum":318,"industry":"教育行业","textField_kzi3b7qj":"推荐","usageNum_value":"608","textField_kzi3b7qm":"能力","scene":"不展示","usageNum":608,"role_id":"行政","suggest_id":"快速入门","imageUrl":"https://tianshu-vpc.oss-cn-shanghai.aliyuncs.com/16d71251-a7ef-4a23-bcb0-77563bd3f7a9.jpg?x-oss-process=image/resize,m_fixed,h_380,w_680","templateTitle":"值班管理系统","guide":"多岗位、多校区、涉及人员多，班次多，调班多；\n值班岗位，值班人员一目了然；线上调班，值班表信息同步；\n值班通知，系统自动推送；值班日志，记录留痕可查；\n值班阅览室，最新公告、流程汇总可查","orderNum_value":"318","author":"宜搭官方","appTplUuid":"TPL_HC18Z4Y3SQDWO2SH1ZT9","textField_kzp6ix74":"行业","scene_id":"不展示","suggest":"快速入门","tags":["流程表单"],"isShow":"显示","isShow_id":"y","tags_id":["流程表单"]}],"entities":null,"hasMore":false,"idCursor":0,"totalCount":7},"errorCode":"","errorExtInfo":null,"errorLevel":"","errorMsg":"","success":true,"throwable":""}
     *
     * @var string
     */
    public $invokeResult;

    /**
     * @example 可选值：SUCCESS、FAIL、FINAL_SUCCESS、ERROR
     *
     * @var string
     */
    public $invokeStatus;

    /**
     * @example 成功：y，失败：n
     *
     * @var string
     */
    public $invokeSuccess;

    /**
     * @example https://www.aliwork.com/query/loginFreeFormData/listFormDataByType.json?type=templateCenter&searchFieldJson=%7B%22isShow%22%3A%22y%22%2C%22suggest%22%3A%22%E5%BF%AB%E9%80%9F%E5%85%A5%E9%97%A8%22%2C%22industry%22%3A%22%22%2C%22role%22%3A%22%22%2C%22tags%22%3A%22%22%2C%22templateTitle%22%3A%22%22%7D&dynamicOrder=%7B%22orderNum%22%3A%22%2B%22%7D&pageSize=48&currentPage=1
     *
     * @var string
     */
    public $invokeUrl;

    /**
     * @example {"url":"https://www.aliwork.com/query/loginFreeFormData/listFormDataByType.json?type=templateCenter&searchFieldJson=%7B%22isShow%22%3A%22y%22%2C%22suggest%22%3A%22%E5%BF%AB%E9%80%9F%E5%85%A5%E9%97%A8%22%2C%22industry%22%3A%22%22%2C%22role%22%3A%22%22%2C%22tags%22%3A%22%22%2C%22templateTitle%22%3A%22%22%7D&dynamicOrder=%7B%22orderNum%22%3A%22%2B%22%7D&pageSize=48&currentPage=1","isMd5":null,"signature":"","isSHA":null,"hmacSecret":"","type":"HttpExt","params":[{"field":"name","value":"name","label":{"zh_CN":"name","en_US":"name","type":"i18n"},"type":"java.lang.String"}]}
     *
     * @var string
     */
    public $serviceContent;

    /**
     * @example 查询宜搭模板
     *
     * @var string
     */
    public $serviceName;

    /**
     * @example {"parameter1":"测试服务执行"}
     *
     * @var string
     */
    public $serviceParameter;

    /**
     * @example INVOKE-E7766VC1KJ4ZVFCR346USCT2ORYI2UVRBHA1LI
     *
     * @var string
     */
    public $sourceUuid;
    protected $_name = [
        'formInstanceId' => 'formInstanceId',
        'formUuid' => 'formUuid',
        'hookType' => 'hookType',
        'hookUuid' => 'hookUuid',
        'invokeParameter' => 'invokeParameter',
        'invokeResult' => 'invokeResult',
        'invokeStatus' => 'invokeStatus',
        'invokeSuccess' => 'invokeSuccess',
        'invokeUrl' => 'invokeUrl',
        'serviceContent' => 'serviceContent',
        'serviceName' => 'serviceName',
        'serviceParameter' => 'serviceParameter',
        'sourceUuid' => 'sourceUuid',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->formInstanceId) {
            $res['formInstanceId'] = $this->formInstanceId;
        }
        if (null !== $this->formUuid) {
            $res['formUuid'] = $this->formUuid;
        }
        if (null !== $this->hookType) {
            $res['hookType'] = $this->hookType;
        }
        if (null !== $this->hookUuid) {
            $res['hookUuid'] = $this->hookUuid;
        }
        if (null !== $this->invokeParameter) {
            $res['invokeParameter'] = $this->invokeParameter;
        }
        if (null !== $this->invokeResult) {
            $res['invokeResult'] = $this->invokeResult;
        }
        if (null !== $this->invokeStatus) {
            $res['invokeStatus'] = $this->invokeStatus;
        }
        if (null !== $this->invokeSuccess) {
            $res['invokeSuccess'] = $this->invokeSuccess;
        }
        if (null !== $this->invokeUrl) {
            $res['invokeUrl'] = $this->invokeUrl;
        }
        if (null !== $this->serviceContent) {
            $res['serviceContent'] = $this->serviceContent;
        }
        if (null !== $this->serviceName) {
            $res['serviceName'] = $this->serviceName;
        }
        if (null !== $this->serviceParameter) {
            $res['serviceParameter'] = $this->serviceParameter;
        }
        if (null !== $this->sourceUuid) {
            $res['sourceUuid'] = $this->sourceUuid;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return values
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['formInstanceId'])) {
            $model->formInstanceId = $map['formInstanceId'];
        }
        if (isset($map['formUuid'])) {
            $model->formUuid = $map['formUuid'];
        }
        if (isset($map['hookType'])) {
            $model->hookType = $map['hookType'];
        }
        if (isset($map['hookUuid'])) {
            $model->hookUuid = $map['hookUuid'];
        }
        if (isset($map['invokeParameter'])) {
            $model->invokeParameter = $map['invokeParameter'];
        }
        if (isset($map['invokeResult'])) {
            $model->invokeResult = $map['invokeResult'];
        }
        if (isset($map['invokeStatus'])) {
            $model->invokeStatus = $map['invokeStatus'];
        }
        if (isset($map['invokeSuccess'])) {
            $model->invokeSuccess = $map['invokeSuccess'];
        }
        if (isset($map['invokeUrl'])) {
            $model->invokeUrl = $map['invokeUrl'];
        }
        if (isset($map['serviceContent'])) {
            $model->serviceContent = $map['serviceContent'];
        }
        if (isset($map['serviceName'])) {
            $model->serviceName = $map['serviceName'];
        }
        if (isset($map['serviceParameter'])) {
            $model->serviceParameter = $map['serviceParameter'];
        }
        if (isset($map['sourceUuid'])) {
            $model->sourceUuid = $map['sourceUuid'];
        }

        return $model;
    }
}
