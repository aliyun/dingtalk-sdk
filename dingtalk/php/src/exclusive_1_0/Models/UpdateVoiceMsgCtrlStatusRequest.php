<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\UpdateVoiceMsgCtrlStatusRequest\voiceMsgCtrlInfo;
use AlibabaCloud\Tea\Model;

class UpdateVoiceMsgCtrlStatusRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 1-检测通过，2-检测失败
     *
     * @var int
     */
    public $status;

    /**
     * @description This parameter is required.
     *
     * @var voiceMsgCtrlInfo
     */
    public $voiceMsgCtrlInfo;
    protected $_name = [
        'status' => 'status',
        'voiceMsgCtrlInfo' => 'voiceMsgCtrlInfo',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->voiceMsgCtrlInfo) {
            $res['voiceMsgCtrlInfo'] = null !== $this->voiceMsgCtrlInfo ? $this->voiceMsgCtrlInfo->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateVoiceMsgCtrlStatusRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['voiceMsgCtrlInfo'])) {
            $model->voiceMsgCtrlInfo = voiceMsgCtrlInfo::fromMap($map['voiceMsgCtrlInfo']);
        }

        return $model;
    }
}
