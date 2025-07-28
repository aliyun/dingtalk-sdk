<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vwatt_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetPointInfoRequest extends Model
{
    /**
     * @var string
     */
    public $pointPoolCode;
    protected $_name = [
        'pointPoolCode' => 'pointPoolCode',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->pointPoolCode) {
            $res['pointPoolCode'] = $this->pointPoolCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetPointInfoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['pointPoolCode'])) {
            $model->pointPoolCode = $map['pointPoolCode'];
        }

        return $model;
    }
}
