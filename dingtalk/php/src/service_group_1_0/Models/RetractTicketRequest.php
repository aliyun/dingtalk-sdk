<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\RetractTicketRequest\notify;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\RetractTicketRequest\ticketMemo;
use AlibabaCloud\Tea\Model;

class RetractTicketRequest extends Model
{
    /**
     * @var notify
     */
    public $notify;

    /**
     * @example eKWh3GBwsKEiE
     *
     * @var string
     */
    public $openTeamId;

    /**
     * @example a8iS4X94TgtgiE
     *
     * @var string
     */
    public $openTicketId;

    /**
     * @var string
     */
    public $operatorUnionId;

    /**
     * @var ticketMemo
     */
    public $ticketMemo;
    protected $_name = [
        'notify'          => 'notify',
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
        if (null !== $this->notify) {
            $res['notify'] = null !== $this->notify ? $this->notify->toMap() : null;
        }
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
     * @return RetractTicketRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['notify'])) {
            $model->notify = notify::fromMap($map['notify']);
        }
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
