<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class PreDialRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 00003213130
     *
     * @var string
     */
    public $callerUserId;

    /**
     * @description This parameter is required.
     *
     * @example 312000030213120
     *
     * @var string
     */
    public $receiverUserId;

    /**
     * @description This parameter is required.
     *
     * @example fdaf-2132
     *
     * @var string
     */
    public $sn;

    /**
     * @description This parameter is required.
     *
     * @example VIDEO_CALL
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
