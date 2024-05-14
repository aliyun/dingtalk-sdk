<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vactivity_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vactivity_1_0\Models\CreateActivityRequest\detail;
use AlibabaCloud\Tea\Model;

class CreateActivityRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var detail
     */
    public $detail;
    protected $_name = [
        'detail' => 'detail',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->detail) {
            $res['detail'] = null !== $this->detail ? $this->detail->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateActivityRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['detail'])) {
            $model->detail = detail::fromMap($map['detail']);
        }

        return $model;
    }
}
