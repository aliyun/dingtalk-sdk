<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryDevicePropertiesResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example "dev_app_status"
     *
     * @var string
     */
    public $propertyName;

    /**
     * @example "idle"
     *
     * @var string
     */
    public $propertyValue;
    protected $_name = [
        'propertyName' => 'propertyName',
        'propertyValue' => 'propertyValue',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->propertyName) {
            $res['propertyName'] = $this->propertyName;
        }
        if (null !== $this->propertyValue) {
            $res['propertyValue'] = $this->propertyValue;
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
        if (isset($map['propertyName'])) {
            $model->propertyName = $map['propertyName'];
        }
        if (isset($map['propertyValue'])) {
            $model->propertyValue = $map['propertyValue'];
        }

        return $model;
    }
}
