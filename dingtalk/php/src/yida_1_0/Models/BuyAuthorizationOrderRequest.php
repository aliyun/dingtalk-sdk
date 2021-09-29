<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class BuyAuthorizationOrderRequest extends Model
{
    /**
     * @description 阿里云产品码
     *
     * @var string
     */
    public $produceCode;

    /**
     * @description 实例id
     *
     * @var string
     */
    public $instanceId;

    /**
     * @description 实例名称
     *
     * @var string
     */
    public $instanceName;

    /**
     * @description 访问秘钥
     *
     * @var string
     */
    public $accessKey;

    /**
     * @description 调用者unionId
     *
     * @var string
     */
    public $callerUnionId;

    /**
     * @description 收费类型
     *
     * @var string
     */
    public $chargeType;

    /**
     * @description 结束时间
     *
     * @var int
     */
    public $endTimeGMT;

    /**
     * @description 开始时间
     *
     * @var int
     */
    public $beginTimeGMT;

    /**
     * @description 账户号
     *
     * @var string
     */
    public $accountNumber;

    /**
     * @description 商业类型
     *
     * @var string
     */
    public $commerceType;

    /**
     * @description 商品类型
     *
     * @var string
     */
    public $commodityType;
    protected $_name = [
        'produceCode'   => 'produceCode',
        'instanceId'    => 'instanceId',
        'instanceName'  => 'instanceName',
        'accessKey'     => 'accessKey',
        'callerUnionId' => 'callerUnionId',
        'chargeType'    => 'chargeType',
        'endTimeGMT'    => 'endTimeGMT',
        'beginTimeGMT'  => 'beginTimeGMT',
        'accountNumber' => 'accountNumber',
        'commerceType'  => 'commerceType',
        'commodityType' => 'commodityType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->produceCode) {
            $res['produceCode'] = $this->produceCode;
        }
        if (null !== $this->instanceId) {
            $res['instanceId'] = $this->instanceId;
        }
        if (null !== $this->instanceName) {
            $res['instanceName'] = $this->instanceName;
        }
        if (null !== $this->accessKey) {
            $res['accessKey'] = $this->accessKey;
        }
        if (null !== $this->callerUnionId) {
            $res['callerUnionId'] = $this->callerUnionId;
        }
        if (null !== $this->chargeType) {
            $res['chargeType'] = $this->chargeType;
        }
        if (null !== $this->endTimeGMT) {
            $res['endTimeGMT'] = $this->endTimeGMT;
        }
        if (null !== $this->beginTimeGMT) {
            $res['beginTimeGMT'] = $this->beginTimeGMT;
        }
        if (null !== $this->accountNumber) {
            $res['accountNumber'] = $this->accountNumber;
        }
        if (null !== $this->commerceType) {
            $res['commerceType'] = $this->commerceType;
        }
        if (null !== $this->commodityType) {
            $res['commodityType'] = $this->commodityType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BuyAuthorizationOrderRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['produceCode'])) {
            $model->produceCode = $map['produceCode'];
        }
        if (isset($map['instanceId'])) {
            $model->instanceId = $map['instanceId'];
        }
        if (isset($map['instanceName'])) {
            $model->instanceName = $map['instanceName'];
        }
        if (isset($map['accessKey'])) {
            $model->accessKey = $map['accessKey'];
        }
        if (isset($map['callerUnionId'])) {
            $model->callerUnionId = $map['callerUnionId'];
        }
        if (isset($map['chargeType'])) {
            $model->chargeType = $map['chargeType'];
        }
        if (isset($map['endTimeGMT'])) {
            $model->endTimeGMT = $map['endTimeGMT'];
        }
        if (isset($map['beginTimeGMT'])) {
            $model->beginTimeGMT = $map['beginTimeGMT'];
        }
        if (isset($map['accountNumber'])) {
            $model->accountNumber = $map['accountNumber'];
        }
        if (isset($map['commerceType'])) {
            $model->commerceType = $map['commerceType'];
        }
        if (isset($map['commodityType'])) {
            $model->commodityType = $map['commodityType'];
        }

        return $model;
    }
}
