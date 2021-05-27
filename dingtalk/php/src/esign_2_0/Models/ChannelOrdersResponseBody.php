<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models;

use AlibabaCloud\Tea\Model;

class ChannelOrdersResponseBody extends Model
{
    /**
     * @var string
     */
    public $esignOrderId;
    protected $_name = [
        'esignOrderId' => 'esignOrderId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->esignOrderId) {
            $res['esignOrderId'] = $this->esignOrderId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ChannelOrdersResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['esignOrderId'])) {
            $model->esignOrderId = $map['esignOrderId'];
        }

        return $model;
    }
}
