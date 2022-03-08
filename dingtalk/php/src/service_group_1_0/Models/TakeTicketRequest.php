<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\Tea\Model;

class TakeTicketRequest extends Model
{
    /**
     * @var string
     */
    public $openTeamId;

    /**
     * @var string
     */
    public $openTicketId;

    /**
     * @var string
     */
    public $takerUnionId;
    protected $_name = [
        'openTeamId'   => 'openTeamId',
        'openTicketId' => 'openTicketId',
        'takerUnionId' => 'takerUnionId',
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
        if (null !== $this->takerUnionId) {
            $res['takerUnionId'] = $this->takerUnionId;
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
        if (isset($map['openTeamId'])) {
            $model->openTeamId = $map['openTeamId'];
        }
        if (isset($map['openTicketId'])) {
            $model->openTicketId = $map['openTicketId'];
        }
        if (isset($map['takerUnionId'])) {
            $model->takerUnionId = $map['takerUnionId'];
        }

        return $model;
    }
}
