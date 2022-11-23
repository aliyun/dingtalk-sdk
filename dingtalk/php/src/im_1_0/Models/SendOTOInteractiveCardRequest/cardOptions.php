<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\SendOTOInteractiveCardRequest;

use AlibabaCloud\Tea\Model;

class cardOptions extends Model
{
    /**
     * @description 是否支持转发
     *
     * @var bool
     */
    public $supportForward;
    protected $_name = [
        'supportForward' => 'supportForward',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->supportForward) {
            $res['supportForward'] = $this->supportForward;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return cardOptions
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['supportForward'])) {
            $model->supportForward = $map['supportForward'];
        }

        return $model;
    }
}
