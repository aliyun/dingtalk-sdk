<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models\GetProcessStartUrlResponseBody\data;
use AlibabaCloud\Tea\Model;

class GetProcessStartUrlResponseBody extends Model
{
    /**
     * @var string
     */
    public $message;

    /**
     * @var int
     */
    public $code;

    /**
     * @var data
     */
    public $data;
    protected $_name = [
        'message' => 'message',
        'code'    => 'code',
        'data'    => 'data',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->message) {
            $res['message'] = $this->message;
        }
        if (null !== $this->code) {
            $res['code'] = $this->code;
        }
        if (null !== $this->data) {
            $res['data'] = null !== $this->data ? $this->data->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetProcessStartUrlResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['message'])) {
            $model->message = $map['message'];
        }
        if (isset($map['code'])) {
            $model->code = $map['code'];
        }
        if (isset($map['data'])) {
            $model->data = data::fromMap($map['data']);
        }

        return $model;
    }
}
