<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models;

use AlibabaCloud\Tea\Model;

class GetContractMarginResponseBody extends Model
{
    /**
     * @var float
     */
    public $margin;
    protected $_name = [
        'margin' => 'margin',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->margin) {
            $res['margin'] = $this->margin;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetContractMarginResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['margin'])) {
            $model->margin = $map['margin'];
        }

        return $model;
    }
}
