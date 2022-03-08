<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\RegisterAndActivateDeviceBatchRequest\registerAndActivateVOS;
use AlibabaCloud\Tea\Model;

class RegisterAndActivateDeviceBatchRequest extends Model
{
    /**
     * @var registerAndActivateVOS[]
     */
    public $registerAndActivateVOS;
    protected $_name = [
        'registerAndActivateVOS' => 'registerAndActivateVOS',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->registerAndActivateVOS) {
            $res['registerAndActivateVOS'] = [];
            if (null !== $this->registerAndActivateVOS && \is_array($this->registerAndActivateVOS)) {
                $n = 0;
                foreach ($this->registerAndActivateVOS as $item) {
                    $res['registerAndActivateVOS'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RegisterAndActivateDeviceBatchRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['registerAndActivateVOS'])) {
            if (!empty($map['registerAndActivateVOS'])) {
                $model->registerAndActivateVOS = [];
                $n                             = 0;
                foreach ($map['registerAndActivateVOS'] as $item) {
                    $model->registerAndActivateVOS[$n++] = null !== $item ? registerAndActivateVOS::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
