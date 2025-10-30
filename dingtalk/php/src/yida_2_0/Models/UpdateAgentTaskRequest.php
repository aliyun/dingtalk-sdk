<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_2_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateAgentTaskRequest extends Model
{
    /**
     * @example ALL
     *
     * @var string
     */
    public $agentRangeType;

    /**
     * @example [{\"appType\":\"APP_xxx\",\"formUuid\":\"FORM-xxx\"}]
     *
     * @var string
     */
    public $agentRangeValue;

    /**
     * @description This parameter is required.
     *
     * @example 10001
     *
     * @var string
     */
    public $agentUserId;

    /**
     * @description This parameter is required.
     *
     * @example Agent--xxxxx
     *
     * @var string
     */
    public $agentUuid;

    /**
     * @description This parameter is required.
     *
     * @example dingxxxx
     *
     * @var string
     */
    public $corpId;

    /**
     * @example 1761204600404
     *
     * @var string
     */
    public $endTimestamp;

    /**
     * @var string
     */
    public $needNoticePrincipal;

    /**
     * @example 1761204600404
     *
     * @var string
     */
    public $startTimestamp;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $token;

    /**
     * @description This parameter is required.
     *
     * @example 501453
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'agentRangeType' => 'agentRangeType',
        'agentRangeValue' => 'agentRangeValue',
        'agentUserId' => 'agentUserId',
        'agentUuid' => 'agentUuid',
        'corpId' => 'corpId',
        'endTimestamp' => 'endTimestamp',
        'needNoticePrincipal' => 'needNoticePrincipal',
        'startTimestamp' => 'startTimestamp',
        'token' => 'token',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->agentRangeType) {
            $res['agentRangeType'] = $this->agentRangeType;
        }
        if (null !== $this->agentRangeValue) {
            $res['agentRangeValue'] = $this->agentRangeValue;
        }
        if (null !== $this->agentUserId) {
            $res['agentUserId'] = $this->agentUserId;
        }
        if (null !== $this->agentUuid) {
            $res['agentUuid'] = $this->agentUuid;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->endTimestamp) {
            $res['endTimestamp'] = $this->endTimestamp;
        }
        if (null !== $this->needNoticePrincipal) {
            $res['needNoticePrincipal'] = $this->needNoticePrincipal;
        }
        if (null !== $this->startTimestamp) {
            $res['startTimestamp'] = $this->startTimestamp;
        }
        if (null !== $this->token) {
            $res['token'] = $this->token;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateAgentTaskRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['agentRangeType'])) {
            $model->agentRangeType = $map['agentRangeType'];
        }
        if (isset($map['agentRangeValue'])) {
            $model->agentRangeValue = $map['agentRangeValue'];
        }
        if (isset($map['agentUserId'])) {
            $model->agentUserId = $map['agentUserId'];
        }
        if (isset($map['agentUuid'])) {
            $model->agentUuid = $map['agentUuid'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['endTimestamp'])) {
            $model->endTimestamp = $map['endTimestamp'];
        }
        if (isset($map['needNoticePrincipal'])) {
            $model->needNoticePrincipal = $map['needNoticePrincipal'];
        }
        if (isset($map['startTimestamp'])) {
            $model->startTimestamp = $map['startTimestamp'];
        }
        if (isset($map['token'])) {
            $model->token = $map['token'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
