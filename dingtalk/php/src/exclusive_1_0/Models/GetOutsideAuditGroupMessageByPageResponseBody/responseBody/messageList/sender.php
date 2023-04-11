<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetOutsideAuditGroupMessageByPageResponseBody\responseBody\messageList;

use AlibabaCloud\Tea\Model;

class sender extends Model
{
    /**
     * @description 根据id的类型决定是哪一种id
     *
     * @var string
     */
    public $id;

    /**
     * @description 发送者的id类型，可以是userId或者unionId
     *
     * @var string
     */
    public $idType;

    /**
     * @description 用户-user 机器人-bot 系统账号-sys
     *
     * @var string
     */
    public $type;
    protected $_name = [
        'id'     => 'id',
        'idType' => 'idType',
        'type'   => 'type',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->idType) {
            $res['idType'] = $this->idType;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return sender
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['idType'])) {
            $model->idType = $map['idType'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
