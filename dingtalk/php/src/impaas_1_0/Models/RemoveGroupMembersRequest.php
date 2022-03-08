<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models;

use AlibabaCloud\Tea\Model;

class RemoveGroupMembersRequest extends Model
{
    /**
     * @var string
     */
    public $conversationId;

    /**
     * @var string[]
     */
    public $memberUids;

    /**
     * @var string
     */
    public $operatorUid;
    protected $_name = [
        'conversationId' => 'conversationId',
        'memberUids'     => 'memberUids',
        'operatorUid'    => 'operatorUid',
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
        if (null !== $this->memberUids) {
            $res['memberUids'] = $this->memberUids;
        }
        if (null !== $this->operatorUid) {
            $res['operatorUid'] = $this->operatorUid;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RemoveGroupMembersRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['conversationId'])) {
            $model->conversationId = $map['conversationId'];
        }
        if (isset($map['memberUids'])) {
            if (!empty($map['memberUids'])) {
                $model->memberUids = $map['memberUids'];
            }
        }
        if (isset($map['operatorUid'])) {
            $model->operatorUid = $map['operatorUid'];
        }

        return $model;
    }
}
