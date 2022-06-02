<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateInstanceRequest extends Model
{
    /**
     * @description 外部业务ID
     *
     * @var string
     */
    public $externalBizId;

    /**
     * @description 表单CODE
     *
     * @var string
     */
    public $formCode;

    /**
     * @description 数据表单实例数据，JSON格式
     *
     * @var string
     */
    public $formDataList;

    /**
     * @description 开放数据实例ID
     *
     * @var string
     */
    public $openDataInstanceId;

    /**
     * @description 开放团队ID
     *
     * @var string
     */
    public $openTeamId;

    /**
     * @description 操作人unionId
     *
     * @var string
     */
    public $operatorUnionId;

    /**
     * @description 拥有人unionId
     *
     * @var string
     */
    public $ownerUnionId;
    protected $_name = [
        'externalBizId'      => 'externalBizId',
        'formCode'           => 'formCode',
        'formDataList'       => 'formDataList',
        'openDataInstanceId' => 'openDataInstanceId',
        'openTeamId'         => 'openTeamId',
        'operatorUnionId'    => 'operatorUnionId',
        'ownerUnionId'       => 'ownerUnionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->externalBizId) {
            $res['externalBizId'] = $this->externalBizId;
        }
        if (null !== $this->formCode) {
            $res['formCode'] = $this->formCode;
        }
        if (null !== $this->formDataList) {
            $res['formDataList'] = $this->formDataList;
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
        if (null !== $this->ownerUnionId) {
            $res['ownerUnionId'] = $this->ownerUnionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateInstanceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['externalBizId'])) {
            $model->externalBizId = $map['externalBizId'];
        }
        if (isset($map['formCode'])) {
            $model->formCode = $map['formCode'];
        }
        if (isset($map['formDataList'])) {
            $model->formDataList = $map['formDataList'];
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
        if (isset($map['ownerUnionId'])) {
            $model->ownerUnionId = $map['ownerUnionId'];
        }

        return $model;
    }
}
