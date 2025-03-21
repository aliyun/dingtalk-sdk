<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetOutGroupsByPageResponseBody\responseBody;
use AlibabaCloud\Tea\Model;

class GetOutGroupsByPageResponseBody extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var responseBody
     */
    public $responseBody;
    protected $_name = [
        'responseBody' => 'responseBody',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->responseBody) {
            $res['responseBody'] = null !== $this->responseBody ? $this->responseBody->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetOutGroupsByPageResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['responseBody'])) {
            $model->responseBody = responseBody::fromMap($map['responseBody']);
        }

        return $model;
    }
}
