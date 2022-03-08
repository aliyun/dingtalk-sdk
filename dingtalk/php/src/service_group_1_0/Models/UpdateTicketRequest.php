<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\UpdateTicketRequest\ticketMemo;
use AlibabaCloud\Tea\Model;

class UpdateTicketRequest extends Model
{
    /**
     * @description 自定义字段值JSON格式
     *
     * @var string
     */
    public $customFields;

    /**
     * @description 团队ID
     *
     * @var string
     */
    public $openTeamId;

    /**
     * @description 工单开放id
     *
     * @var string
     */
    public $openTicketId;

    /**
     * @description 工单处理人unionId
     *
     * @var string
     */
    public $processorUnionId;

    /**
     * @description 备注
     *
     * @var ticketMemo
     */
    public $ticketMemo;
    protected $_name = [
        'customFields'     => 'customFields',
        'openTeamId'       => 'openTeamId',
        'openTicketId'     => 'openTicketId',
        'processorUnionId' => 'processorUnionId',
        'ticketMemo'       => 'ticketMemo',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->customFields) {
            $res['customFields'] = $this->customFields;
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
        if (null !== $this->ticketMemo) {
            $res['ticketMemo'] = null !== $this->ticketMemo ? $this->ticketMemo->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateTicketRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['customFields'])) {
            $model->customFields = $map['customFields'];
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
        if (isset($map['ticketMemo'])) {
            $model->ticketMemo = ticketMemo::fromMap($map['ticketMemo']);
        }

        return $model;
    }
}
