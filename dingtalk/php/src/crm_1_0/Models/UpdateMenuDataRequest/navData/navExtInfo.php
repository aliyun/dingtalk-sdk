<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\UpdateMenuDataRequest\navData;

use AlibabaCloud\Tea\Model;

class navExtInfo extends Model
{
    /**
     * @example oem
     *
     * @var string
     */
    public $productMode;

    /**
     * @example tj
     *
     * @var string
     */
    public $provider;
    protected $_name = [
        'productMode' => 'productMode',
        'provider' => 'provider',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->productMode) {
            $res['productMode'] = $this->productMode;
        }
        if (null !== $this->provider) {
            $res['provider'] = $this->provider;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return navExtInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['productMode'])) {
            $model->productMode = $map['productMode'];
        }
        if (isset($map['provider'])) {
            $model->provider = $map['provider'];
        }

        return $model;
    }
}
