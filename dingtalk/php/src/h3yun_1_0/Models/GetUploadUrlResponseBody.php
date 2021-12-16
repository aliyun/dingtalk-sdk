<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\GetUploadUrlResponseBody\data;
use AlibabaCloud\Tea\Model;

class GetUploadUrlResponseBody extends Model
{
    /**
     * @description 状态码
     *
     * @var string
     */
    public $code;

    /**
     * @description 提示信息
     *
     * @var string
     */
    public $message;

    /**
     * @description 返回结果
     *
     * @var data
     */
    public $data;
    protected $_name = [
        'code'    => 'code',
        'message' => 'message',
        'data'    => 'data',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->code) {
            $res['code'] = $this->code;
        }
        if (null !== $this->message) {
            $res['message'] = $this->message;
        }
        if (null !== $this->data) {
            $res['data'] = null !== $this->data ? $this->data->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetUploadUrlResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['code'])) {
            $model->code = $map['code'];
        }
        if (isset($map['message'])) {
            $model->message = $map['message'];
        }
        if (isset($map['data'])) {
            $model->data = data::fromMap($map['data']);
        }

        return $model;
    }
}
