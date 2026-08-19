<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcustomer_1_0\Models;

use AlibabaCloud\Tea\Model;

class CustomeRpcCallShrinkRequest extends Model
{
    /**
     * @var string
     */
    public $methodName;

    /**
     * @var string
     */
    public $paramsShrink;
    protected $_name = [
        'methodName' => 'methodName',
        'paramsShrink' => 'params',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->methodName) {
            $res['methodName'] = $this->methodName;
        }
        if (null !== $this->paramsShrink) {
            $res['params'] = $this->paramsShrink;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CustomeRpcCallShrinkRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['methodName'])) {
            $model->methodName = $map['methodName'];
        }
        if (isset($map['params'])) {
            $model->paramsShrink = $map['params'];
        }

        return $model;
    }
}
