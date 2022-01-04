<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class UploadRegisterImageResponseBody extends Model
{
    /**
     * @description 进件图片上传响应
     *
     * @var string
     */
    public $ossUrl;
    protected $_name = [
        'ossUrl' => 'ossUrl',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->ossUrl) {
            $res['ossUrl'] = $this->ossUrl;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UploadRegisterImageResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['ossUrl'])) {
            $model->ossUrl = $map['ossUrl'];
        }

        return $model;
    }
}
