<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\QueryUserDeviceLocationResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\QueryUserDeviceLocationResponseBody\result\deviceLocations\locations;
use AlibabaCloud\Tea\Model;

class deviceLocations extends Model
{
    /**
     * @var locations[]
     */
    public $locations;

    /**
     * @var string
     */
    public $sn;
    protected $_name = [
        'locations' => 'locations',
        'sn' => 'sn',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->locations) {
            $res['locations'] = [];
            if (null !== $this->locations && \is_array($this->locations)) {
                $n = 0;
                foreach ($this->locations as $item) {
                    $res['locations'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->sn) {
            $res['sn'] = $this->sn;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return deviceLocations
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['locations'])) {
            if (!empty($map['locations'])) {
                $model->locations = [];
                $n = 0;
                foreach ($map['locations'] as $item) {
                    $model->locations[$n++] = null !== $item ? locations::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['sn'])) {
            $model->sn = $map['sn'];
        }

        return $model;
    }
}
