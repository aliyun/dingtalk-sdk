<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\UpdateInteractiveOTOMessageRequest\detail;
use AlibabaCloud\Tea\Model;

class UpdateInteractiveOTOMessageRequest extends Model
{
    /**
     * @description 消息详情
     *
     * @var detail
     */
    public $detail;
    protected $_name = [
        'detail' => 'detail',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->detail) {
            $res['detail'] = null !== $this->detail ? $this->detail->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateInteractiveOTOMessageRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['detail'])) {
            $model->detail = detail::fromMap($map['detail']);
        }

        return $model;
    }
}
