<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\Tea\Model;

class SaveFormInstanceRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example {}
     *
     * @var string
     */
    public $formDataList;

    /**
     * @description This parameter is required.
     *
     * @example 8888
     *
     * @var string
     */
    public $openTeamId;

    /**
     * @example 88888
     *
     * @var string
     */
    public $operatorUnionId;

    /**
     * @example 8888
     *
     * @var string
     */
    public $ownerUnionId;
    protected $_name = [
        'formDataList'    => 'formDataList',
        'openTeamId'      => 'openTeamId',
        'operatorUnionId' => 'operatorUnionId',
        'ownerUnionId'    => 'ownerUnionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->formDataList) {
            $res['formDataList'] = $this->formDataList;
        }
        if (null !== $this->openTeamId) {
            $res['openTeamId'] = $this->openTeamId;
        }
        if (null !== $this->operatorUnionId) {
            $res['operatorUnionId'] = $this->operatorUnionId;
        }
        if (null !== $this->ownerUnionId) {
            $res['ownerUnionId'] = $this->ownerUnionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SaveFormInstanceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['formDataList'])) {
            $model->formDataList = $map['formDataList'];
        }
        if (isset($map['openTeamId'])) {
            $model->openTeamId = $map['openTeamId'];
        }
        if (isset($map['operatorUnionId'])) {
            $model->operatorUnionId = $map['operatorUnionId'];
        }
        if (isset($map['ownerUnionId'])) {
            $model->ownerUnionId = $map['ownerUnionId'];
        }

        return $model;
    }
}
