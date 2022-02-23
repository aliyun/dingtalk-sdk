<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\UpdateActionRequest\actionInfo;

use AlibabaCloud\Tea\Model;

class outputDataRules extends Model
{
    /**
     * @description 规则的属性路径。
     *
     * @var string
     */
    public $propertyPath;

    /**
     * @description 操作类型。
     *
     * @var string
     */
    public $operate;

    /**
     * @description 规则的预期值。
     *
     * @var string
     */
    public $expectValue;
    protected $_name = [
        'propertyPath' => 'propertyPath',
        'operate'      => 'operate',
        'expectValue'  => 'expectValue',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->propertyPath) {
            $res['propertyPath'] = $this->propertyPath;
        }
        if (null !== $this->operate) {
            $res['operate'] = $this->operate;
        }
        if (null !== $this->expectValue) {
            $res['expectValue'] = $this->expectValue;
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
        if (isset($map['propertyPath'])) {
            $model->propertyPath = $map['propertyPath'];
        }
        if (isset($map['operate'])) {
            $model->operate = $map['operate'];
        }
        if (isset($map['expectValue'])) {
            $model->expectValue = $map['expectValue'];
        }

        return $model;
    }
}
