<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vaiot_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetDevicePropertiesResponseBody extends Model
{
    /**
     * @var string
     */
    public $deviceName;

    /**
     * @var string
     */
    public $productKey;

    /**
     * @var PropertiesValue[]
     */
    public $properties;

    /**
     * @var string
     */
    public $snapshotAt;
    protected $_name = [
        'deviceName' => 'deviceName',
        'productKey' => 'productKey',
        'properties' => 'properties',
        'snapshotAt' => 'snapshotAt',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->deviceName) {
            $res['deviceName'] = $this->deviceName;
        }
        if (null !== $this->productKey) {
            $res['productKey'] = $this->productKey;
        }
        if (null !== $this->properties) {
            $res['properties'] = [];
            if (null !== $this->properties && \is_array($this->properties)) {
                foreach ($this->properties as $key => $val) {
                    $res['properties'][$key] = null !== $val ? $val->toMap() : $val;
                }
            }
        }
        if (null !== $this->snapshotAt) {
            $res['snapshotAt'] = $this->snapshotAt;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetDevicePropertiesResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deviceName'])) {
            $model->deviceName = $map['deviceName'];
        }
        if (isset($map['productKey'])) {
            $model->productKey = $map['productKey'];
        }
        if (isset($map['properties'])) {
            $model->properties = $map['properties'];
        }
        if (isset($map['snapshotAt'])) {
            $model->snapshotAt = $map['snapshotAt'];
        }

        return $model;
    }
}
