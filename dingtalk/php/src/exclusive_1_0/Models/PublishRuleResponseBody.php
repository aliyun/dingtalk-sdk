<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class PublishRuleResponseBody extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example true
     *
     * @var bool
     */
    public $isPublish;
    protected $_name = [
        'isPublish' => 'isPublish',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->isPublish) {
            $res['isPublish'] = $this->isPublish;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PublishRuleResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['isPublish'])) {
            $model->isPublish = $map['isPublish'];
        }

        return $model;
    }
}
