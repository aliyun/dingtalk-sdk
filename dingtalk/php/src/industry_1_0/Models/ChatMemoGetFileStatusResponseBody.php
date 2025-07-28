<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class ChatMemoGetFileStatusResponseBody extends Model
{
    /**
     * @example -1
     *
     * @var int
     */
    public $status;

    /**
     * @example 待处理
     *
     * @var string
     */
    public $statusDesc;
    protected $_name = [
        'status' => 'status',
        'statusDesc' => 'statusDesc',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->statusDesc) {
            $res['statusDesc'] = $this->statusDesc;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ChatMemoGetFileStatusResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['statusDesc'])) {
            $model->statusDesc = $map['statusDesc'];
        }

        return $model;
    }
}
