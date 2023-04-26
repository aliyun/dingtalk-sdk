<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryMembersOfGroupRoleRequest extends Model
{
    /**
     * @example cidXXXXXXX
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @example roleXXXXX
     *
     * @var string
     */
    public $openRoleId;

    /**
     * @example 1621502140000
     *
     * @var int
     */
    public $timestamp;
    protected $_name = [
        'openConversationId' => 'openConversationId',
        'openRoleId'         => 'openRoleId',
        'timestamp'          => 'timestamp',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->openRoleId) {
            $res['openRoleId'] = $this->openRoleId;
        }
        if (null !== $this->timestamp) {
            $res['timestamp'] = $this->timestamp;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryMembersOfGroupRoleRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['openRoleId'])) {
            $model->openRoleId = $map['openRoleId'];
        }
        if (isset($map['timestamp'])) {
            $model->timestamp = $map['timestamp'];
        }

        return $model;
    }
}
