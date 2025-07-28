<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryDevicePropertiesRequest extends Model
{
    /**
     * @var string[]
     */
    public $propertyNames;

    /**
     * @example 1234
     *
     * @var string
     */
    public $deviceId;

    /**
     * @example "lmvUrRkpboRrSMtgsiS9V3AiEiE"
     *
     * @var string
     */
    public $deviceUnionId;

    /**
     * @description This parameter is required.
     *
     * @example "lmvUrEjpboFrSMtgsiS9V3AiEiE"
     *
     * @var string
     */
    public $operatorUnionId;
    protected $_name = [
        'propertyNames' => 'propertyNames',
        'deviceId' => 'deviceId',
        'deviceUnionId' => 'deviceUnionId',
        'operatorUnionId' => 'operatorUnionId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->propertyNames) {
            $res['propertyNames'] = $this->propertyNames;
        }
        if (null !== $this->deviceId) {
            $res['deviceId'] = $this->deviceId;
        }
        if (null !== $this->deviceUnionId) {
            $res['deviceUnionId'] = $this->deviceUnionId;
        }
        if (null !== $this->operatorUnionId) {
            $res['operatorUnionId'] = $this->operatorUnionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryDevicePropertiesRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['propertyNames'])) {
            if (!empty($map['propertyNames'])) {
                $model->propertyNames = $map['propertyNames'];
            }
        }
        if (isset($map['deviceId'])) {
            $model->deviceId = $map['deviceId'];
        }
        if (isset($map['deviceUnionId'])) {
            $model->deviceUnionId = $map['deviceUnionId'];
        }
        if (isset($map['operatorUnionId'])) {
            $model->operatorUnionId = $map['operatorUnionId'];
        }

        return $model;
    }
}
