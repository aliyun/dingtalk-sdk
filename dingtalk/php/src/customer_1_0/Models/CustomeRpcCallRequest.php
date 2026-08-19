<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcustomer_1_0\Models;

use AlibabaCloud\Tea\Model;

class CustomeRpcCallRequest extends Model
{
    /**
     * @var string
     */
    public $methodName;

    /**
     * @var mixed[]
     */
    public $params;
    protected $_name = [
        'methodName' => 'methodName',
        'params' => 'params',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->methodName) {
            $res['methodName'] = $this->methodName;
        }
        if (null !== $this->params) {
            $res['params'] = $this->params;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CustomeRpcCallRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['methodName'])) {
            $model->methodName = $map['methodName'];
        }
        if (isset($map['params'])) {
            $model->params = $map['params'];
        }

        return $model;
    }
}
