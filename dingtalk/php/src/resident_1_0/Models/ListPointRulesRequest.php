<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListPointRulesRequest extends Model
{
    /**
     * @description 是否查询全员圈积分
     *
     * @var bool
     */
    public $isCircle;
    protected $_name = [
        'isCircle' => 'isCircle',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->isCircle) {
            $res['isCircle'] = $this->isCircle;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListPointRulesRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['isCircle'])) {
            $model->isCircle = $map['isCircle'];
        }

        return $model;
    }
}
