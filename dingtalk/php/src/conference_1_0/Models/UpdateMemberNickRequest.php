<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateMemberNickRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 新昵称
     *
     * @var string
     */
    public $nick;

    /**
     * @description This parameter is required.
     *
     * @example qzR1iSMDvzR9iP7Pxxxxxxxxxxxxxxx
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'nick' => 'nick',
        'unionId' => 'unionId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->nick) {
            $res['nick'] = $this->nick;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateMemberNickRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['nick'])) {
            $model->nick = $map['nick'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
