<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class BuyFreshOrderRequest extends Model
{
    /**
     * @example hexaaaa
     *
     * @var string
     */
    public $accessKey;

    /**
     * @example 123
     *
     * @var string
     */
    public $accountNumber;

    /**
     * @example 1234567891234
     *
     * @var int
     */
    public $beginTimeGMT;

    /**
     * @example 44234122
     *
     * @var string
     */
    public $callerUnionId;

    /**
     * @example subscribe
     *
     * @var string
     */
    public $chargeType;

    /**
     * @example subscribe
     *
     * @var string
     */
    public $commerceType;

    /**
     * @example Business
     *
     * @var string
     */
    public $commodityType;

    /**
     * @example 1234567891234
     *
     * @var int
     */
    public $endTimeGMT;

    /**
     * @example 12
     *
     * @var string
     */
    public $instanceId;

    /**
     * @example A发起的实例
     *
     * @var string
     */
    public $instanceName;

    /**
     * @example yun-1234
     *
     * @var string
     */
    public $produceCode;
    protected $_name = [
        'accessKey'     => 'accessKey',
        'accountNumber' => 'accountNumber',
        'beginTimeGMT'  => 'beginTimeGMT',
        'callerUnionId' => 'callerUnionId',
        'chargeType'    => 'chargeType',
        'commerceType'  => 'commerceType',
        'commodityType' => 'commodityType',
        'endTimeGMT'    => 'endTimeGMT',
        'instanceId'    => 'instanceId',
        'instanceName'  => 'instanceName',
        'produceCode'   => 'produceCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->accessKey) {
            $res['accessKey'] = $this->accessKey;
        }
        if (null !== $this->accountNumber) {
            $res['accountNumber'] = $this->accountNumber;
        }
        if (null !== $this->beginTimeGMT) {
            $res['beginTimeGMT'] = $this->beginTimeGMT;
        }
        if (null !== $this->callerUnionId) {
            $res['callerUnionId'] = $this->callerUnionId;
        }
        if (null !== $this->chargeType) {
            $res['chargeType'] = $this->chargeType;
        }
        if (null !== $this->commerceType) {
            $res['commerceType'] = $this->commerceType;
        }
        if (null !== $this->commodityType) {
            $res['commodityType'] = $this->commodityType;
        }
        if (null !== $this->endTimeGMT) {
            $res['endTimeGMT'] = $this->endTimeGMT;
        }
        if (null !== $this->instanceId) {
            $res['instanceId'] = $this->instanceId;
        }
        if (null !== $this->instanceName) {
            $res['instanceName'] = $this->instanceName;
        }
        if (null !== $this->produceCode) {
            $res['produceCode'] = $this->produceCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BuyFreshOrderRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['accessKey'])) {
            $model->accessKey = $map['accessKey'];
        }
        if (isset($map['accountNumber'])) {
            $model->accountNumber = $map['accountNumber'];
        }
        if (isset($map['beginTimeGMT'])) {
            $model->beginTimeGMT = $map['beginTimeGMT'];
        }
        if (isset($map['callerUnionId'])) {
            $model->callerUnionId = $map['callerUnionId'];
        }
        if (isset($map['chargeType'])) {
            $model->chargeType = $map['chargeType'];
        }
        if (isset($map['commerceType'])) {
            $model->commerceType = $map['commerceType'];
        }
        if (isset($map['commodityType'])) {
            $model->commodityType = $map['commodityType'];
        }
        if (isset($map['endTimeGMT'])) {
            $model->endTimeGMT = $map['endTimeGMT'];
        }
        if (isset($map['instanceId'])) {
            $model->instanceId = $map['instanceId'];
        }
        if (isset($map['instanceName'])) {
            $model->instanceName = $map['instanceName'];
        }
        if (isset($map['produceCode'])) {
            $model->produceCode = $map['produceCode'];
        }

        return $model;
    }
}
