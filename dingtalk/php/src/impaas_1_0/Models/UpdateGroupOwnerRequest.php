<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateGroupOwnerRequest extends Model
{
    /**
     * @var string
     */
    public $ownerId;

    /**
     * @var string
     */
    public $operatorUid;

    /**
     * @var string
     */
    public $conversationId;
    protected $_name = [
        'ownerId'        => 'ownerId',
        'operatorUid'    => 'operatorUid',
        'conversationId' => 'conversationId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->ownerId) {
            $res['ownerId'] = $this->ownerId;
        }
        if (null !== $this->operatorUid) {
            $res['operatorUid'] = $this->operatorUid;
        }
        if (null !== $this->conversationId) {
            $res['conversationId'] = $this->conversationId;
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
        if (isset($map['ownerId'])) {
            $model->ownerId = $map['ownerId'];
        }
        if (isset($map['operatorUid'])) {
            $model->operatorUid = $map['operatorUid'];
        }
        if (isset($map['conversationId'])) {
            $model->conversationId = $map['conversationId'];
        }

        return $model;
    }
}
