<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetOutsideAuditGroupMessageByPageResponseBody\responseBody\messageList;

use AlibabaCloud\Tea\Model;

class sender extends Model
{
    /**
     * @example user1234
     *
     * @var string
     */
    public $id;

    /**
     * @example userId
     *
     * @var string
     */
    public $idType;

    /**
     * @example user
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
