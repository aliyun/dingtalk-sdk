<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class UserAgreementPageSignRequest extends Model
{
    /**
     * @description 主机构编号
     *
     * @var string
     */
    public $instId;

    /**
     * @description 子机构编号
     *
     * @var string
     */
    public $subInstId;

    /**
     * @description 付款人staffId
     *
     * @var string
     */
    public $userId;

    /**
     * @description 备注
     *
     * @var string
     */
    public $remark;

    /**
     * @description 支付渠道
     *
     * @var string
     */
    public $payChannel;

    /**
     * @description 子商户服务名称
     *
     * @var string
     */
    public $subMerchantServiceName;

    /**
     * @description 子商户服务描述
     *
     * @var string
     */
    public $subMerchantServiceDesc;

    /**
     * @description 子商户商户名称
     *
     * @var string
     */
    public $subMerchantName;

    /**
     * @description 业务编码
     *
     * @var string
     */
    public $bizCode;

    /**
     * @description 业务场景
     *
     * @var string
     */
    public $bizScene;

    /**
     * @description 签约场景
     *
     * @var string
     */
    public $signScene;

    /**
     * @description 组织id
     *
     * @var int
     */
    public $dingOrgId;

    /**
     * @description isv组织id
     *
     * @var int
     */
    public $dingIsvOrgId;

    /**
     * @description 应用id
     *
     * @var string
     */
    public $dingClientId;

    /**
     * @description 应用类型
     *
     * @var int
     */
    public $dingTokenGrantType;
    protected $_name = [
        'instId'                 => 'instId',
        'subInstId'              => 'subInstId',
        'userId'                 => 'userId',
        'remark'                 => 'remark',
        'payChannel'             => 'payChannel',
        'subMerchantServiceName' => 'subMerchantServiceName',
        'subMerchantServiceDesc' => 'subMerchantServiceDesc',
        'subMerchantName'        => 'subMerchantName',
        'bizCode'                => 'bizCode',
        'bizScene'               => 'bizScene',
        'signScene'              => 'signScene',
        'dingOrgId'              => 'dingOrgId',
        'dingIsvOrgId'           => 'dingIsvOrgId',
        'dingClientId'           => 'dingClientId',
        'dingTokenGrantType'     => 'dingTokenGrantType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->instId) {
            $res['instId'] = $this->instId;
        }
        if (null !== $this->subInstId) {
            $res['subInstId'] = $this->subInstId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->remark) {
            $res['remark'] = $this->remark;
        }
        if (null !== $this->payChannel) {
            $res['payChannel'] = $this->payChannel;
        }
        if (null !== $this->subMerchantServiceName) {
            $res['subMerchantServiceName'] = $this->subMerchantServiceName;
        }
        if (null !== $this->subMerchantServiceDesc) {
            $res['subMerchantServiceDesc'] = $this->subMerchantServiceDesc;
        }
        if (null !== $this->subMerchantName) {
            $res['subMerchantName'] = $this->subMerchantName;
        }
        if (null !== $this->bizCode) {
            $res['bizCode'] = $this->bizCode;
        }
        if (null !== $this->bizScene) {
            $res['bizScene'] = $this->bizScene;
        }
        if (null !== $this->signScene) {
            $res['signScene'] = $this->signScene;
        }
        if (null !== $this->dingOrgId) {
            $res['dingOrgId'] = $this->dingOrgId;
        }
        if (null !== $this->dingIsvOrgId) {
            $res['dingIsvOrgId'] = $this->dingIsvOrgId;
        }
        if (null !== $this->dingClientId) {
            $res['dingClientId'] = $this->dingClientId;
        }
        if (null !== $this->dingTokenGrantType) {
            $res['dingTokenGrantType'] = $this->dingTokenGrantType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UserAgreementPageSignRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['instId'])) {
            $model->instId = $map['instId'];
        }
        if (isset($map['subInstId'])) {
            $model->subInstId = $map['subInstId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['remark'])) {
            $model->remark = $map['remark'];
        }
        if (isset($map['payChannel'])) {
            $model->payChannel = $map['payChannel'];
        }
        if (isset($map['subMerchantServiceName'])) {
            $model->subMerchantServiceName = $map['subMerchantServiceName'];
        }
        if (isset($map['subMerchantServiceDesc'])) {
            $model->subMerchantServiceDesc = $map['subMerchantServiceDesc'];
        }
        if (isset($map['subMerchantName'])) {
            $model->subMerchantName = $map['subMerchantName'];
        }
        if (isset($map['bizCode'])) {
            $model->bizCode = $map['bizCode'];
        }
        if (isset($map['bizScene'])) {
            $model->bizScene = $map['bizScene'];
        }
        if (isset($map['signScene'])) {
            $model->signScene = $map['signScene'];
        }
        if (isset($map['dingOrgId'])) {
            $model->dingOrgId = $map['dingOrgId'];
        }
        if (isset($map['dingIsvOrgId'])) {
            $model->dingIsvOrgId = $map['dingIsvOrgId'];
        }
        if (isset($map['dingClientId'])) {
            $model->dingClientId = $map['dingClientId'];
        }
        if (isset($map['dingTokenGrantType'])) {
            $model->dingTokenGrantType = $map['dingTokenGrantType'];
        }

        return $model;
    }
}
