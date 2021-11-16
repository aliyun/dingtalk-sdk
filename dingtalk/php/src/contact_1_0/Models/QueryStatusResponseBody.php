<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryStatusResponseBody extends Model
{
    /**
     * @description disable
     *
     * @var bool
     */
    public $disable;
    protected $_name = [
        'disable' => 'disable',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->disable) {
            $res['disable'] = $this->disable;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryStatusResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['disable'])) {
            $model->disable = $map['disable'];
        }

        return $model;
    }
}
