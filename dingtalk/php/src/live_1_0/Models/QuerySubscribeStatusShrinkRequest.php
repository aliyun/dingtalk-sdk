<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models;

use AlibabaCloud\Tea\Model;

class QuerySubscribeStatusShrinkRequest extends Model
{
    /**
     * @description post请求体, 开放平台建议以对象形式存储
     *
     * @var string
     */
    public $bodyShrink;

    /**
     * @description 用户id（主播id）
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'bodyShrink' => 'body',
        'unionId'    => 'unionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bodyShrink) {
            $res['body'] = $this->bodyShrink;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QuerySubscribeStatusShrinkRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['body'])) {
            $model->bodyShrink = $map['body'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
