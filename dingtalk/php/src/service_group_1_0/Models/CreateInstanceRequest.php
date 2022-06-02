<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateInstanceRequest extends Model
{
    /**
     * @description 渠道
     *
     * @var string
     */
    public $channel;

    /**
     * @description 外部业务ID，由英文、数字构成
     *
     * @var string
     */
    public $externalBizId;

    /**
     * @description 表单CODE,客户表单：DING_CUSTOMER；联系人表单：DING_CONTACT
     *
     * @var string
     */
    public $formCode;

    /**
     * @description 表单数据，JSON格式
     *
     * @var string
     */
    public $formDataList;

    /**
     * @description 开放团队ID，从服务群后台ID信息中获取
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
