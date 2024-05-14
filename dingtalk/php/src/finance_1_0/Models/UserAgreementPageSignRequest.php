<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class UserAgreementPageSignRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example TRADE
     *
     * @var string
     */
    public $bizCode;

    /**
     * @description This parameter is required.
     *
     * @example WITHHOLDING
     *
     * @var string
     */
    public $bizScene;

    /**
     * @description This parameter is required.
     *
     * @example 202111090001
     *
     * @var string
     */
    public $instId;

    /**
     * @description This parameter is required.
     *
     * @example 支付宝
     *
     * @var string
     */
    public $payChannel;

    /**
     * @example 备注
     *
     * @var string
     */
    public $remark;

    /**
     * @example http://****.com
     *
     * @var string
     */
    public $returnUrl;

    /**
     * @description This parameter is required.
     *
     * @example 详见支付宝接口文档https://opendocs.alipay.com/open/20190319114403226822/signscene
     *
     * @var string
     */
    public $signScene;

    /**
     * @description This parameter is required.
     *
     * @example 1001
     *
     * @var string
     */
    public $subInstId;

    /**
     * @description This parameter is required.
     *
     * @example 滴滴出行
     *
     * @var string
     */
    public $subMerchantName;

    /**
     * @description This parameter is required.
     *
     * @example 免密付车费，单次最高500元
     *
     * @var string
     */
    public $subMerchantServiceDesc;

    /**
     * @description This parameter is required.
     *
     * @example 滴滴出行免密支付
     *
     * @var string
     */
    public $subMerchantServiceName;

    /**
     * @description This parameter is required.
     *
     * @example 2120493284
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
