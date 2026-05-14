<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\QueryUserDeviceLocationResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\QueryUserDeviceLocationResponseBody\result\deviceLocations;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var deviceLocations[]
     */
    public $deviceLocations;
    protected $_name = [
        'deviceLocations' => 'deviceLocations',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->deviceLocations) {
            $res['deviceLocations'] = [];
            if (null !== $this->deviceLocations && \is_array($this->deviceLocations)) {
                $n = 0;
                foreach ($this->deviceLocations as $item) {
                    $res['deviceLocations'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
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
        if (isset($map['deviceLocations'])) {
            if (!empty($map['deviceLocations'])) {
                $model->deviceLocations = [];
                $n = 0;
                foreach ($map['deviceLocations'] as $item) {
                    $model->deviceLocations[$n++] = null !== $item ? deviceLocations::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
