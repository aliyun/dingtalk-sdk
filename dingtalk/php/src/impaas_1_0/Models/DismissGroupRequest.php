<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models;

use AlibabaCloud\Tea\Model;

class DismissGroupRequest extends Model
{
    /**
     * @var string
     */
    public $operatorUid;

    /**
     * @var string
     */
    public $conversationId;
    protected $_name = [
        'operatorUid'    => 'operatorUid',
        'conversationId' => 'conversationId',
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

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DismissGroupRequest
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

        return $model;
    }
}
