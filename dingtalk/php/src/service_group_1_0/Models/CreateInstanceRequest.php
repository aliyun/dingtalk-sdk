<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateInstanceRequest extends Model
{
    /**
     * @example DOU_YIN
     *
     * @var string
     */
    public $channel;

    /**
     * @example 888888
     *
     * @var string
     */
    public $externalBizId;

    /**
     * @description This parameter is required.
     *
     * @example DING_CUSTOMER
     *
     * @var string
     */
    public $formCode;

    /**
     * @description This parameter is required.
     *
     * @example {"node_1111":"hahha"}
     *
     * @var string
     */
    public $formDataList;

    /**
     * @description This parameter is required.
     *
     * @example 88444***
     *
     * @var string
     */
    public $openTeamId;

    /**
     * @example 88855
     *
     * @var string
     */
    public $operatorUnionId;

    /**
     * @example 88855
     *
     * @var string
     */
    public $ownerUnionId;
    protected $_name = [
        'channel'         => 'channel',
        'externalBizId'   => 'externalBizId',
        'formCode'        => 'formCode',
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
        if (null !== $this->channel) {
            $res['channel'] = $this->channel;
        }
        if (null !== $this->externalBizId) {
            $res['externalBizId'] = $this->externalBizId;
        }
        if (null !== $this->formCode) {
            $res['formCode'] = $this->formCode;
        }
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
     * @return CreateInstanceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['channel'])) {
            $model->channel = $map['channel'];
        }
        if (isset($map['externalBizId'])) {
            $model->externalBizId = $map['externalBizId'];
        }
        if (isset($map['formCode'])) {
            $model->formCode = $map['formCode'];
        }
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
