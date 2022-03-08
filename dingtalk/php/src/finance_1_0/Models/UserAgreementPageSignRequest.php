<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class UserAgreementPageSignRequest extends Model
{
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
     * @description 主机构编号
     *
     * @var string
     */
    public $instId;

    /**
     * @description 支付渠道
     *
     * @var string
     */
    public $payChannel;

    /**
     * @description 备注
     *
     * @var string
     */
    public $remark;

    /**
     * @description 签约后页面返回url
     *
     * @var string
     */
    public $returnUrl;

    /**
     * @description 签约场景
     *
     * @var string
     */
    public $signScene;

    /**
     * @description 子机构编号
     *
     * @var string
     */
    public $subInstId;

    /**
     * @description 子商户商户名称
     *
     * @var string
     */
    public $subMerchantName;

    /**
     * @description 子商户服务描述
     *
     * @var string
     */
    public $subMerchantServiceDesc;

    /**
     * @description 子商户服务名称
     *
     * @var string
     */
    public $subMerchantServiceName;

    /**
     * @description 付款人staffId
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'bizCode'                => 'bizCode',
        'bizScene'               => 'bizScene',
        'instId'                 => 'instId',
        'payChannel'             => 'payChannel',
        'remark'                 => 'remark',
        'returnUrl'              => 'returnUrl',
        'signScene'              => 'signScene',
        'subInstId'              => 'subInstId',
        'subMerchantName'        => 'subMerchantName',
        'subMerchantServiceDesc' => 'subMerchantServiceDesc',
        'subMerchantServiceName' => 'subMerchantServiceName',
        'userId'                 => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizCode) {
            $res['bizCode'] = $this->bizCode;
        }
        if (null !== $this->bizScene) {
            $res['bizScene'] = $this->bizScene;
        }
        if (null !== $this->instId) {
            $res['instId'] = $this->instId;
        }
        if (null !== $this->payChannel) {
            $res['payChannel'] = $this->payChannel;
        }
        if (null !== $this->remark) {
            $res['remark'] = $this->remark;
        }
        if (null !== $this->returnUrl) {
            $res['returnUrl'] = $this->returnUrl;
        }
        if (null !== $this->signScene) {
            $res['signScene'] = $this->signScene;
        }
        if (null !== $this->subInstId) {
            $res['subInstId'] = $this->subInstId;
        }
        if (null !== $this->subMerchantName) {
            $res['subMerchantName'] = $this->subMerchantName;
        }
        if (null !== $this->subMerchantServiceDesc) {
            $res['subMerchantServiceDesc'] = $this->subMerchantServiceDesc;
        }
        if (null !== $this->subMerchantServiceName) {
            $res['subMerchantServiceName'] = $this->subMerchantServiceName;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
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
        if (isset($map['bizCode'])) {
            $model->bizCode = $map['bizCode'];
        }
        if (isset($map['bizScene'])) {
            $model->bizScene = $map['bizScene'];
        }
        if (isset($map['instId'])) {
            $model->instId = $map['instId'];
        }
        if (isset($map['payChannel'])) {
            $model->payChannel = $map['payChannel'];
        }
        if (isset($map['remark'])) {
            $model->remark = $map['remark'];
        }
        if (isset($map['returnUrl'])) {
            $model->returnUrl = $map['returnUrl'];
        }
        if (isset($map['signScene'])) {
            $model->signScene = $map['signScene'];
        }
        if (isset($map['subInstId'])) {
            $model->subInstId = $map['subInstId'];
        }
        if (isset($map['subMerchantName'])) {
            $model->subMerchantName = $map['subMerchantName'];
        }
        if (isset($map['subMerchantServiceDesc'])) {
            $model->subMerchantServiceDesc = $map['subMerchantServiceDesc'];
        }
        if (isset($map['subMerchantServiceName'])) {
            $model->subMerchantServiceName = $map['subMerchantServiceName'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
