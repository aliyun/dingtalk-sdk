<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vaiot_1_0\Models;

use AlibabaCloud\Tea\Model;

class InvokeDeviceServiceRequest extends Model
{
    /**
     * @var mixed[]
     */
    public $args;

    /**
     * @var int
     */
    public $timeoutSeconds;
    protected $_name = [
        'args' => 'args',
        'timeoutSeconds' => 'timeoutSeconds',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->args) {
            $res['args'] = $this->args;
        }
        if (null !== $this->timeoutSeconds) {
            $res['timeoutSeconds'] = $this->timeoutSeconds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return InvokeDeviceServiceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['args'])) {
            $model->args = $map['args'];
        }
        if (isset($map['timeoutSeconds'])) {
            $model->timeoutSeconds = $map['timeoutSeconds'];
        }

        return $model;
    }
}
