<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetPointInfoRequest extends Model
{
    /**
     * @example personal
     *
     * @var string
     */
    public $pointType;
    protected $_name = [
        'pointType' => 'pointType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->pointType) {
            $res['pointType'] = $this->pointType;
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
        if (isset($map['pointType'])) {
            $model->pointType = $map['pointType'];
        }

        return $model;
    }
}
