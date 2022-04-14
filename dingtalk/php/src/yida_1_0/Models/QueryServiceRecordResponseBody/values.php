<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\QueryServiceRecordResponseBody;

use AlibabaCloud\Tea\Model;

class values extends Model
{
    /**
     * @description 表单实例id
     *
     * @var string
     */
    public $formInstanceId;

    /**
     * @description 表单编码
     *
     * @var string
     */
    public $formUuid;

    /**
     * @description 服务类型
     *
     * @var string
     */
    public $hookType;

    /**
     * @description 本次服务调用的唯一ID
     *
     * @var string
     */
    public $hookUuid;

    /**
     * @description 服务调用的实际入参
     *
     * @var string
     */
    public $invokeParameter;

    /**
     * @description 服务调用的返回结果
     *
     * @var string
     */
    public $invokeResult;

    /**
     * @description 服务调用状态
     *
     * @var string
     */
    public $invokeStatus;

    /**
     * @description 服务调用是否成功
     *
     * @var string
     */
    public $invokeSuccess;

    /**
     * @description 服务调用地址
     *
     * @var string
     */
    public $invokeUrl;

    /**
     * @description 宜搭调用目标服务时传的实际参数
     *
     * @var string
     */
    public $serviceContent;

    /**
     * @description 服务名称
     *
     * @var string
     */
    public $serviceName;

    /**
     * @description 服务调用的实际入参
     *
     * @var string
     */
    public $serviceParameter;

    /**
     * @description 重试的服务调用唯一ID(此次服务调用是重试哪个执行失败的服务调用)
     *
     * @var string
     */
    public $sourceUuid;
    protected $_name = [
        'formInstanceId'   => 'formInstanceId',
        'formUuid'         => 'formUuid',
        'hookType'         => 'hookType',
        'hookUuid'         => 'hookUuid',
        'invokeParameter'  => 'invokeParameter',
        'invokeResult'     => 'invokeResult',
        'invokeStatus'     => 'invokeStatus',
        'invokeSuccess'    => 'invokeSuccess',
        'invokeUrl'        => 'invokeUrl',
        'serviceContent'   => 'serviceContent',
        'serviceName'      => 'serviceName',
        'serviceParameter' => 'serviceParameter',
        'sourceUuid'       => 'sourceUuid',
    ];

    public function validate()
    {
    }

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
