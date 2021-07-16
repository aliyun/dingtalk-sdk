<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\FinishTicketRequest\notify;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\FinishTicketRequest\ticketMemo;
use AlibabaCloud\Tea\Model;

class FinishTicketRequest extends Model
{
    /**
     * @var int
     */
    public $dingIsvOrgId;

    /**
     * @var int
     */
    public $dingOrgId;

    /**
     * @var string
     */
    public $dingSuiteKey;

    /**
     * @var int
     */
    public $dingTokenGrantType;

    /**
     * @var string
     */
    public $openTeamId;

    /**
     * @description 当前工单处理人
     *
     * @var string
     */
    public $processorUnionId;

    /**
     * @description 工单开放id
     *
     * @var string
     */
    public $openTicketId;

    /**
     * @description 备注
     *
     * @var ticketMemo
     */
    public $ticketMemo;

    /**
     * @description 工单通知
     *
     * @var notify
     */
    public $notify;
    protected $_name = [
        'dingIsvOrgId'       => 'dingIsvOrgId',
        'dingOrgId'          => 'dingOrgId',
        'dingSuiteKey'       => 'dingSuiteKey',
        'dingTokenGrantType' => 'dingTokenGrantType',
        'openTeamId'         => 'openTeamId',
        'processorUnionId'   => 'processorUnionId',
        'openTicketId'       => 'openTicketId',
        'ticketMemo'         => 'ticketMemo',
        'notify'             => 'notify',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dingIsvOrgId) {
            $res['dingIsvOrgId'] = $this->dingIsvOrgId;
        }
        if (null !== $this->dingOrgId) {
            $res['dingOrgId'] = $this->dingOrgId;
        }
        if (null !== $this->dingSuiteKey) {
            $res['dingSuiteKey'] = $this->dingSuiteKey;
        }
        if (null !== $this->dingTokenGrantType) {
            $res['dingTokenGrantType'] = $this->dingTokenGrantType;
        }
        if (null !== $this->openTeamId) {
            $res['openTeamId'] = $this->openTeamId;
        }
        if (null !== $this->processorUnionId) {
            $res['processorUnionId'] = $this->processorUnionId;
        }
        if (null !== $this->openTicketId) {
            $res['openTicketId'] = $this->openTicketId;
        }
        if (null !== $this->ticketMemo) {
            $res['ticketMemo'] = null !== $this->ticketMemo ? $this->ticketMemo->toMap() : null;
        }
        if (null !== $this->notify) {
            $res['notify'] = null !== $this->notify ? $this->notify->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return FinishTicketRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dingIsvOrgId'])) {
            $model->dingIsvOrgId = $map['dingIsvOrgId'];
        }
        if (isset($map['dingOrgId'])) {
            $model->dingOrgId = $map['dingOrgId'];
        }
        if (isset($map['dingSuiteKey'])) {
            $model->dingSuiteKey = $map['dingSuiteKey'];
        }
        if (isset($map['dingTokenGrantType'])) {
            $model->dingTokenGrantType = $map['dingTokenGrantType'];
        }
        if (isset($map['openTeamId'])) {
            $model->openTeamId = $map['openTeamId'];
        }
        if (isset($map['processorUnionId'])) {
            $model->processorUnionId = $map['processorUnionId'];
        }
        if (isset($map['openTicketId'])) {
            $model->openTicketId = $map['openTicketId'];
        }
        if (isset($map['ticketMemo'])) {
            $model->ticketMemo = ticketMemo::fromMap($map['ticketMemo']);
        }
        if (isset($map['notify'])) {
            $model->notify = notify::fromMap($map['notify']);
        }

        return $model;
    }
}
