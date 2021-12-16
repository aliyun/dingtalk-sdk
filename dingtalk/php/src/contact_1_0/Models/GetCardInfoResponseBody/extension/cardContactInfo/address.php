<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetCardInfoResponseBody\extension\cardContactInfo;

use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetCardInfoResponseBody\extension\cardContactInfo\address\area;
use AlibabaCloud\Tea\Model;

class address extends Model
{
    /**
     * @description 区域
     *
     * @var area
     */
    public $area;

    /**
     * @description 详细地址
     *
     * @var string
     */
    public $detail;
    protected $_name = [
        'area'   => 'area',
        'detail' => 'detail',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->area) {
            $res['area'] = null !== $this->area ? $this->area->toMap() : null;
        }
        if (null !== $this->detail) {
            $res['detail'] = $this->detail;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return address
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['area'])) {
            $model->area = area::fromMap($map['area']);
        }
        if (isset($map['detail'])) {
            $model->detail = $map['detail'];
        }

        return $model;
    }
}
