<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vaiot_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vaiot_1_0\Models\CheckDeviceUpdateResponseBody\modules;
use AlibabaCloud\Tea\Model;

class CheckDeviceUpdateResponseBody extends Model
{
    /**
     * @var modules[]
     */
    public $modules;
    protected $_name = [
        'modules' => 'modules',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->modules) {
            $res['modules'] = [];
            if (null !== $this->modules && \is_array($this->modules)) {
                $n = 0;
                foreach ($this->modules as $item) {
                    $res['modules'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CheckDeviceUpdateResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['modules'])) {
            if (!empty($map['modules'])) {
                $model->modules = [];
                $n = 0;
                foreach ($map['modules'] as $item) {
                    $model->modules[$n++] = null !== $item ? modules::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
