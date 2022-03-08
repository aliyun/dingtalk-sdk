<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateGroupOwnerRequest extends Model
{
    /**
     * @var string
     */
    public $conversationId;

    /**
     * @var string
     */
    public $operatorUid;

    /**
     * @var string
     */
    public $ownerUid;
    protected $_name = [
        'conversationId' => 'conversationId',
        'operatorUid'    => 'operatorUid',
        'ownerUid'       => 'ownerUid',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->conversationId) {
            $res['conversationId'] = $this->conversationId;
        }
        if (null !== $this->operatorUid) {
            $res['operatorUid'] = $this->operatorUid;
        }
        if (null !== $this->ownerUid) {
            $res['ownerUid'] = $this->ownerUid;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateGroupOwnerRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['conversationId'])) {
            $model->conversationId = $map['conversationId'];
        }
        if (isset($map['operatorUid'])) {
            $model->operatorUid = $map['operatorUid'];
        }
        if (isset($map['ownerUid'])) {
            $model->ownerUid = $map['ownerUid'];
        }

        return $model;
    }
}
