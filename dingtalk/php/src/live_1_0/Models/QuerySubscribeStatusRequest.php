<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\QuerySubscribeStatusRequest\body;
use AlibabaCloud\Tea\Model;

class QuerySubscribeStatusRequest extends Model
{
    /**
     * @description post请求体, 开放平台建议以对象形式存储
     *
     * @var body
     */
    public $body;

    /**
     * @description 用户id（主播id）
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'body'    => 'body',
        'unionId' => 'unionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->body) {
            $res['body'] = null !== $this->body ? $this->body->toMap() : null;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QuerySubscribeStatusRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['body'])) {
            $model->body = body::fromMap($map['body']);
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
