<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\CreateActionRequest\actionInfo;

use AlibabaCloud\Tea\Model;

class outputDataRules extends Model
{
    /**
     * @example 1
     *
     * @var string
     */
    public $expectValue;

    /**
     * @example EQ
     *
     * @var string
     */
    public $operate;

    /**
     * @example a/b/c
     *
     * @var string
     */
    public $propertyPath;
    protected $_name = [
        'expectValue'  => 'expectValue',
        'operate'      => 'operate',
        'propertyPath' => 'propertyPath',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->expectValue) {
            $res['expectValue'] = $this->expectValue;
        }
        if (null !== $this->operate) {
            $res['operate'] = $this->operate;
        }
        if (null !== $this->propertyPath) {
            $res['propertyPath'] = $this->propertyPath;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return outputDataRules
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['expectValue'])) {
            $model->expectValue = $map['expectValue'];
        }
        if (isset($map['operate'])) {
            $model->operate = $map['operate'];
        }
        if (isset($map['propertyPath'])) {
            $model->propertyPath = $map['propertyPath'];
        }

        return $model;
    }
}
