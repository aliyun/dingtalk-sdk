<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListGroupStaffMembersRequest extends Model
{
    /**
     * @var string
     */
    public $conversationId;
    protected $_name = [
        'conversationId' => 'conversationId',
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

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListGroupStaffMembersRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['conversationId'])) {
            $model->conversationId = $map['conversationId'];
        }

        return $model;
    }
}
