<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\TransferTicketRequest\notify;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\TransferTicketRequest\ticketMemo;
use AlibabaCloud\Tea\Model;

class TransferTicketRequest extends Model
{
    /**
     * @var notify
     */
    public $notify;

    /**
     * @description 开放团队ID
     *
     * @var string
     */
    public $openTeamId;

    /**
     * @description 工单开放ID
     *
     * @var string
     */
    public $openTicketId;

    /**
     * @description 工单处理人
     *
     * @var string
     */
    public $processorUnionId;

    /**
     * @description 被转单人UnionId列表
     *
     * @var string[]
     */
    public $processorUnionIds;

    /**
     * @description 工单备注
     *
     * @var ticketMemo
     */
    public $ticketMemo;
    protected $_name = [
        'notify'            => 'notify',
        'openTeamId'        => 'openTeamId',
        'openTicketId'      => 'openTicketId',
        'processorUnionId'  => 'processorUnionId',
        'processorUnionIds' => 'processorUnionIds',
        'ticketMemo'        => 'ticketMemo',
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
        if (null !== $this->processorUnionId) {
            $res['processorUnionId'] = $this->processorUnionId;
        }
        if (null !== $this->processorUnionIds) {
            $res['processorUnionIds'] = $this->processorUnionIds;
        }
        if (null !== $this->ticketMemo) {
            $res['ticketMemo'] = null !== $this->ticketMemo ? $this->ticketMemo->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return TransferTicketRequest
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
        if (isset($map['processorUnionId'])) {
            $model->processorUnionId = $map['processorUnionId'];
        }
        if (isset($map['processorUnionIds'])) {
            if (!empty($map['processorUnionIds'])) {
                $model->processorUnionIds = $map['processorUnionIds'];
            }
        }
        if (isset($map['ticketMemo'])) {
            $model->ticketMemo = ticketMemo::fromMap($map['ticketMemo']);
        }

        return $model;
    }
}
