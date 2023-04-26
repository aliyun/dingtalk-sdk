<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetTbProjectSourceResponseBody extends Model
{
    /**
     * @example ”0“
     *
     * @var string
     */
    public $installSource;
    protected $_name = [
        'installSource' => 'installSource',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->installSource) {
            $res['installSource'] = $this->installSource;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetTbProjectSourceResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['installSource'])) {
            $model->installSource = $map['installSource'];
        }

        return $model;
    }
}
