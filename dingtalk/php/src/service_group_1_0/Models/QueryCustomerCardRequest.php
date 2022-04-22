<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryCustomerCardRequest extends Model
{
    /**
     * @description 查询jsonString
     *
     * @var string
     */
    public $jsonParams;

    /**
     * @var string
     */
    public $openTeamId;
    protected $_name = [
        'jsonParams' => 'jsonParams',
        'openTeamId' => 'openTeamId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->jsonParams) {
            $res['jsonParams'] = $this->jsonParams;
        }
        if (null !== $this->openTeamId) {
            $res['openTeamId'] = $this->openTeamId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryCustomerCardRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['jsonParams'])) {
            $model->jsonParams = $map['jsonParams'];
        }
        if (isset($map['openTeamId'])) {
            $model->openTeamId = $map['openTeamId'];
        }

        return $model;
    }
}
