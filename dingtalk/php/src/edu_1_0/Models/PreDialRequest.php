<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class PreDialRequest extends Model
{
    /**
     * @description 通话发起人的userId
     *
     * @var string
     */
    public $callerUserId;

    /**
     * @description 通话接收人的userId
     *
     * @var string
     */
    public $receiverUserId;

    /**
     * @description 设备sn码
     *
     * @var string
     */
    public $sn;

    /**
     * @description 设备类型
     *
     * @var string
     */
    public $type;
    protected $_name = [
        'callerUserId'   => 'callerUserId',
        'receiverUserId' => 'receiverUserId',
        'sn'             => 'sn',
        'type'           => 'type',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->callerUserId) {
            $res['callerUserId'] = $this->callerUserId;
        }
        if (null !== $this->receiverUserId) {
            $res['receiverUserId'] = $this->receiverUserId;
        }
        if (null !== $this->sn) {
            $res['sn'] = $this->sn;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PreDialRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['callerUserId'])) {
            $model->callerUserId = $map['callerUserId'];
        }
        if (isset($map['receiverUserId'])) {
            $model->receiverUserId = $map['receiverUserId'];
        }
        if (isset($map['sn'])) {
            $model->sn = $map['sn'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
