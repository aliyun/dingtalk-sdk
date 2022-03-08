<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class NotifyAuthorizationResultRequest extends Model
{
    /**
     * @var string
     */
    public $accessKey;

    /**
     * @var string
     */
    public $accountNumber;

    /**
     * @var int
     */
    public $beginTimeGMT;

    /**
     * @var string
     */
    public $callerUid;

    /**
     * @var string
     */
    public $chargeType;

    /**
     * @var string
     */
    public $commerceType;

    /**
     * @var string
     */
    public $commodityType;

    /**
     * @var int
     */
    public $endTimeGMT;

    /**
     * @var string
     */
    public $instanceId;

    /**
     * @var string
     */
    public $instanceName;

    /**
     * @description 阿里云产品code
     *
     * @var string
     */
    public $produceCode;
    protected $_name = [
        'accessKey'     => 'accessKey',
        'accountNumber' => 'accountNumber',
        'beginTimeGMT'  => 'beginTimeGMT',
        'callerUid'     => 'callerUid',
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
        if (null !== $this->callerUid) {
            $res['callerUid'] = $this->callerUid;
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
     * @return NotifyAuthorizationResultRequest
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
        if (isset($map['callerUid'])) {
            $model->callerUid = $map['callerUid'];
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
