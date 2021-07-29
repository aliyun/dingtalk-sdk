<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateGroupNameRequest extends Model
{
    /**
     * @var string
     */
    public $operatorUid;

    /**
     * @var string
     */
    public $conversationId;

    /**
     * @var string
     */
    public $name;
    protected $_name = [
        'operatorUid'    => 'operatorUid',
        'conversationId' => 'conversationId',
        'name'           => 'name',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->operatorUid) {
            $res['operatorUid'] = $this->operatorUid;
        }
        if (null !== $this->conversationId) {
            $res['conversationId'] = $this->conversationId;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateGroupNameRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['operatorUid'])) {
            $model->operatorUid = $map['operatorUid'];
        }
        if (isset($map['conversationId'])) {
            $model->conversationId = $map['conversationId'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }

        return $model;
    }
}
