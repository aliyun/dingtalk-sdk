<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\UrgeTicketRequest\ticketMemo;
use AlibabaCloud\Tea\Model;

class UrgeTicketRequest extends Model
{
    /**
     * @example bLkvfXKiSngQiE
     *
     * @var string
     */
    public $openTeamId;

    /**
     * @example iPbrfXjdNjRoiE
     *
     * @var string
     */
    public $openTicketId;

    /**
     * @example Dq9hP8Sk2v6vQ6l05nCe5wiEiE
     *
     * @var string
     */
    public $operatorUnionId;

    /**
     * @var ticketMemo
     */
    public $ticketMemo;
    protected $_name = [
        'openTeamId'      => 'openTeamId',
        'openTicketId'    => 'openTicketId',
        'operatorUnionId' => 'operatorUnionId',
        'ticketMemo'      => 'ticketMemo',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->openTeamId) {
            $res['openTeamId'] = $this->openTeamId;
        }
        if (null !== $this->openTicketId) {
            $res['openTicketId'] = $this->openTicketId;
        }
        if (null !== $this->operatorUnionId) {
            $res['operatorUnionId'] = $this->operatorUnionId;
        }
        if (null !== $this->ticketMemo) {
            $res['ticketMemo'] = null !== $this->ticketMemo ? $this->ticketMemo->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UrgeTicketRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['openTeamId'])) {
            $model->openTeamId = $map['openTeamId'];
        }
        if (isset($map['openTicketId'])) {
            $model->openTicketId = $map['openTicketId'];
        }
        if (isset($map['operatorUnionId'])) {
            $model->operatorUnionId = $map['operatorUnionId'];
        }
        if (isset($map['ticketMemo'])) {
            $model->ticketMemo = ticketMemo::fromMap($map['ticketMemo']);
        }

        return $model;
    }
}
