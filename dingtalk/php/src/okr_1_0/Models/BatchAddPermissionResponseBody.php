<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\BatchAddPermissionResponseBody\data;
use AlibabaCloud\Tea\Model;

class BatchAddPermissionResponseBody extends Model
{
    /**
     * @var data
     */
    public $data;

    /**
     * @example true
     *
     * @var bool
     */
    public $success;
    protected $_name = [
        'data'    => 'data',
        'success' => 'success',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->data) {
            $res['data'] = null !== $this->data ? $this->data->toMap() : null;
        }
        if (null !== $this->success) {
            $res['success'] = $this->success;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BatchAddPermissionResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['data'])) {
            $model->data = data::fromMap($map['data']);
        }
        if (isset($map['success'])) {
            $model->success = $map['success'];
        }

        return $model;
    }
}
