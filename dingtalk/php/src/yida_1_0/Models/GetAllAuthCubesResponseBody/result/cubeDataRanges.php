<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetAllAuthCubesResponseBody\result;

use AlibabaCloud\Tea\Model;

class cubeDataRanges extends Model
{
    /**
     * @var string
     */
    public $classifiedCode;

    /**
     * @var string
     */
    public $conditionKey;

    /**
     * @var mixed[]
     */
    public $conditionValue;

    /**
     * @var string
     */
    public $elementCode;

    /**
     * @var string
     */
    public $elementType;

    /**
     * @example manager123
     *
     * @var string
     */
    public $operator;
    protected $_name = [
        'classifiedCode' => 'classifiedCode',
        'conditionKey' => 'conditionKey',
        'conditionValue' => 'conditionValue',
        'elementCode' => 'elementCode',
        'elementType' => 'elementType',
        'operator' => 'operator',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->classifiedCode) {
            $res['classifiedCode'] = $this->classifiedCode;
        }
        if (null !== $this->conditionKey) {
            $res['conditionKey'] = $this->conditionKey;
        }
        if (null !== $this->conditionValue) {
            $res['conditionValue'] = $this->conditionValue;
        }
        if (null !== $this->elementCode) {
            $res['elementCode'] = $this->elementCode;
        }
        if (null !== $this->elementType) {
            $res['elementType'] = $this->elementType;
        }
        if (null !== $this->operator) {
            $res['operator'] = $this->operator;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return cubeDataRanges
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['classifiedCode'])) {
            $model->classifiedCode = $map['classifiedCode'];
        }
        if (isset($map['conditionKey'])) {
            $model->conditionKey = $map['conditionKey'];
        }
        if (isset($map['conditionValue'])) {
            if (!empty($map['conditionValue'])) {
                $model->conditionValue = $map['conditionValue'];
            }
        }
        if (isset($map['elementCode'])) {
            $model->elementCode = $map['elementCode'];
        }
        if (isset($map['elementType'])) {
            $model->elementType = $map['elementType'];
        }
        if (isset($map['operator'])) {
            $model->operator = $map['operator'];
        }

        return $model;
    }
}
