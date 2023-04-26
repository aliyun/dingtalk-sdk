<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\Tea\Model;

class DeleteInstanceRequest extends Model
{
    /**
     * @example DING_CUSTOMER
     *
     * @var string
     */
    public $formCode;

    /**
     * @example 888***
     *
     * @var string
     */
    public $openDataInstanceId;

    /**
     * @example 888**
     *
     * @var string
     */
    public $openTeamId;

    /**
     * @example 8889999
     *
     * @var string
     */
    public $operatorUnionId;
    protected $_name = [
        'formCode'           => 'formCode',
        'openDataInstanceId' => 'openDataInstanceId',
        'openTeamId'         => 'openTeamId',
        'operatorUnionId'    => 'operatorUnionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->formCode) {
            $res['formCode'] = $this->formCode;
        }
        if (null !== $this->openDataInstanceId) {
            $res['openDataInstanceId'] = $this->openDataInstanceId;
        }
        if (null !== $this->openTeamId) {
            $res['openTeamId'] = $this->openTeamId;
        }
        if (null !== $this->operatorUnionId) {
            $res['operatorUnionId'] = $this->operatorUnionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeleteInstanceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['formCode'])) {
            $model->formCode = $map['formCode'];
        }
        if (isset($map['openDataInstanceId'])) {
            $model->openDataInstanceId = $map['openDataInstanceId'];
        }
        if (isset($map['openTeamId'])) {
            $model->openTeamId = $map['openTeamId'];
        }
        if (isset($map['operatorUnionId'])) {
            $model->operatorUnionId = $map['operatorUnionId'];
        }

        return $model;
    }
}
