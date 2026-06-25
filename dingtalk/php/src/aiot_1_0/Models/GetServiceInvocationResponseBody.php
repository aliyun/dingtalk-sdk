<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vaiot_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetServiceInvocationResponseBody extends Model
{
    /**
     * @var string
     */
    public $completedAt;

    /**
     * @var string
     */
    public $createdAt;

    /**
     * @var string
     */
    public $deviceName;

    /**
     * @var string
     */
    public $errorCode;

    /**
     * @var string
     */
    public $errorMsg;

    /**
     * @var string
     */
    public $identifier;

    /**
     * @var string
     */
    public $invocationId;

    /**
     * @var mixed[]
     */
    public $outputData;

    /**
     * @var int
     */
    public $processingTimeMs;

    /**
     * @var string
     */
    public $productKey;

    /**
     * @var string
     */
    public $status;
    protected $_name = [
        'completedAt' => 'completedAt',
        'createdAt' => 'createdAt',
        'deviceName' => 'deviceName',
        'errorCode' => 'errorCode',
        'errorMsg' => 'errorMsg',
        'identifier' => 'identifier',
        'invocationId' => 'invocationId',
        'outputData' => 'outputData',
        'processingTimeMs' => 'processingTimeMs',
        'productKey' => 'productKey',
        'status' => 'status',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->completedAt) {
            $res['completedAt'] = $this->completedAt;
        }
        if (null !== $this->createdAt) {
            $res['createdAt'] = $this->createdAt;
        }
        if (null !== $this->deviceName) {
            $res['deviceName'] = $this->deviceName;
        }
        if (null !== $this->errorCode) {
            $res['errorCode'] = $this->errorCode;
        }
        if (null !== $this->errorMsg) {
            $res['errorMsg'] = $this->errorMsg;
        }
        if (null !== $this->identifier) {
            $res['identifier'] = $this->identifier;
        }
        if (null !== $this->invocationId) {
            $res['invocationId'] = $this->invocationId;
        }
        if (null !== $this->outputData) {
            $res['outputData'] = $this->outputData;
        }
        if (null !== $this->processingTimeMs) {
            $res['processingTimeMs'] = $this->processingTimeMs;
        }
        if (null !== $this->productKey) {
            $res['productKey'] = $this->productKey;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetServiceInvocationResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['completedAt'])) {
            $model->completedAt = $map['completedAt'];
        }
        if (isset($map['createdAt'])) {
            $model->createdAt = $map['createdAt'];
        }
        if (isset($map['deviceName'])) {
            $model->deviceName = $map['deviceName'];
        }
        if (isset($map['errorCode'])) {
            $model->errorCode = $map['errorCode'];
        }
        if (isset($map['errorMsg'])) {
            $model->errorMsg = $map['errorMsg'];
        }
        if (isset($map['identifier'])) {
            $model->identifier = $map['identifier'];
        }
        if (isset($map['invocationId'])) {
            $model->invocationId = $map['invocationId'];
        }
        if (isset($map['outputData'])) {
            $model->outputData = $map['outputData'];
        }
        if (isset($map['processingTimeMs'])) {
            $model->processingTimeMs = $map['processingTimeMs'];
        }
        if (isset($map['productKey'])) {
            $model->productKey = $map['productKey'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }

        return $model;
    }
}
