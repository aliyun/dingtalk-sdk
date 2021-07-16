<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\Tea\Model;

class TakeTicketRequest extends Model
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
     * @var string
     */
    public $takerUnionId;

    /**
     * @var string
     */
    public $openTicketId;
    protected $_name = [
        'dingIsvOrgId'       => 'dingIsvOrgId',
        'dingOrgId'          => 'dingOrgId',
        'dingSuiteKey'       => 'dingSuiteKey',
        'dingTokenGrantType' => 'dingTokenGrantType',
        'openTeamId'         => 'openTeamId',
        'takerUnionId'       => 'takerUnionId',
        'openTicketId'       => 'openTicketId',
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
        if (null !== $this->takerUnionId) {
            $res['takerUnionId'] = $this->takerUnionId;
        }
        if (null !== $this->openTicketId) {
            $res['openTicketId'] = $this->openTicketId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return TakeTicketRequest
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
        if (isset($map['takerUnionId'])) {
            $model->takerUnionId = $map['takerUnionId'];
        }
        if (isset($map['openTicketId'])) {
            $model->openTicketId = $map['openTicketId'];
        }

        return $model;
    }
}
