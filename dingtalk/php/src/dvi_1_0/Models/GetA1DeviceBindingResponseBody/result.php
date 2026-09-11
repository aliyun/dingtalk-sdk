<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetA1DeviceBindingResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetA1DeviceBindingResponseBody\result\binding;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var binding
     */
    public $binding;
    protected $_name = [
        'binding' => 'binding',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->binding) {
            $res['binding'] = null !== $this->binding ? $this->binding->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['binding'])) {
            $model->binding = binding::fromMap($map['binding']);
        }

        return $model;
    }
}
