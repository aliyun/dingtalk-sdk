<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models\GetSignNoticeUrlResponseBody\data;
use AlibabaCloud\Tea\Model;

class GetSignNoticeUrlResponseBody extends Model
{
    /**
     * @description 返回错误码
     *
     * @var int
     */
    public $code;

    /**
     * @description 返回数据
     *
     * @var data
     */
    public $data;

    /**
     * @description 返回结果信息
     *
     * @var string
     */
    public $message;
    protected $_name = [
        'code'    => 'code',
        'data'    => 'data',
        'message' => 'message',
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
        if (null !== $this->data) {
            $res['data'] = null !== $this->data ? $this->data->toMap() : null;
        }
        if (null !== $this->message) {
            $res['message'] = $this->message;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetSignNoticeUrlResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['code'])) {
            $model->code = $map['code'];
        }
        if (isset($map['data'])) {
            $model->data = data::fromMap($map['data']);
        }
        if (isset($map['message'])) {
            $model->message = $map['message'];
        }

        return $model;
    }
}
