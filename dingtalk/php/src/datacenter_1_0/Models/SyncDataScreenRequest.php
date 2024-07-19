<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models;

use AlibabaCloud\Tea\Model;

class SyncDataScreenRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 123
     *
     * @var string
     */
    public $screenId;

    /**
     * @description This parameter is required.
     *
     * @example ABC
     *
     * @var string
     */
    public $ticket;
    protected $_name = [
        'screenId' => 'screenId',
        'ticket'   => 'ticket',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->screenId) {
            $res['screenId'] = $this->screenId;
        }
        if (null !== $this->ticket) {
            $res['ticket'] = $this->ticket;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SyncDataScreenRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['screenId'])) {
            $model->screenId = $map['screenId'];
        }
        if (isset($map['ticket'])) {
            $model->ticket = $map['ticket'];
        }

        return $model;
    }
}
