<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models;

use AlibabaCloud\Tea\Model;

class QueryCityRequest extends Model
{
    /**
     * @var string
     */
    public $province;
    protected $_name = [
        'province' => 'province',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->province) {
            $res['province'] = $this->province;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryCityRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['province'])) {
            $model->province = $map['province'];
        }

        return $model;
    }
}
