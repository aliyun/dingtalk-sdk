<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetCardInfoResponseBody\extension\cardContactInfo\address;

use AlibabaCloud\Tea\Model;

class area extends Model
{
    /**
     * @description 地区
     *
     * @var string
     */
    public $region;

    /**
     * @description 地区详细数据
     *
     * @var string
     */
    public $regionFullName;
    protected $_name = [
        'region'         => 'region',
        'regionFullName' => 'regionFullName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->region) {
            $res['region'] = $this->region;
        }
        if (null !== $this->regionFullName) {
            $res['regionFullName'] = $this->regionFullName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return area
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['region'])) {
            $model->region = $map['region'];
        }
        if (isset($map['regionFullName'])) {
            $model->regionFullName = $map['regionFullName'];
        }

        return $model;
    }
}
