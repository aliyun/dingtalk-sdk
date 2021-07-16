<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetTicketRequest extends Model
{
    /**
     * @description eKWh3GBwsKEiE
     *
     * @var string
     */
    public $openTeamId;

    /**
     * @description hNiPO2OVktNMiE
     *
     * @var string
     */
    public $openTicketId;
    protected $_name = [
        'openTeamId'   => 'openTeamId',
        'openTicketId' => 'openTicketId',
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

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetTicketRequest
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

        return $model;
    }
}
