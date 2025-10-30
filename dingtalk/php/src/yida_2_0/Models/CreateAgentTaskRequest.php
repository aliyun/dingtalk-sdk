<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_2_0\Models;

use AlibabaCloud\Tea\Model;

class CreateAgentTaskRequest extends Model
{
    /**
     * @example EXECUTE
     *
     * @var string
     */
    public $agentCategory;

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
     * @example ALL
     *
     * @var string
     */
    public $agentType;

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
     * @description This parameter is required.
     *
     * @example 10002
     *
     * @var string
     */
    public $principalUserId;

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
        'agentCategory' => 'agentCategory',
        'agentRangeType' => 'agentRangeType',
        'agentRangeValue' => 'agentRangeValue',
        'agentType' => 'agentType',
        'agentUserId' => 'agentUserId',
        'corpId' => 'corpId',
        'endTimestamp' => 'endTimestamp',
        'needNoticePrincipal' => 'needNoticePrincipal',
        'principalUserId' => 'principalUserId',
        'startTimestamp' => 'startTimestamp',
        'token' => 'token',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->agentCategory) {
            $res['agentCategory'] = $this->agentCategory;
        }
        if (null !== $this->agentRangeType) {
            $res['agentRangeType'] = $this->agentRangeType;
        }
        if (null !== $this->agentRangeValue) {
            $res['agentRangeValue'] = $this->agentRangeValue;
        }
        if (null !== $this->agentType) {
            $res['agentType'] = $this->agentType;
        }
        if (null !== $this->agentUserId) {
            $res['agentUserId'] = $this->agentUserId;
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
        if (null !== $this->principalUserId) {
            $res['principalUserId'] = $this->principalUserId;
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
     * @return CreateAgentTaskRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['agentCategory'])) {
            $model->agentCategory = $map['agentCategory'];
        }
        if (isset($map['agentRangeType'])) {
            $model->agentRangeType = $map['agentRangeType'];
        }
        if (isset($map['agentRangeValue'])) {
            $model->agentRangeValue = $map['agentRangeValue'];
        }
        if (isset($map['agentType'])) {
            $model->agentType = $map['agentType'];
        }
        if (isset($map['agentUserId'])) {
            $model->agentUserId = $map['agentUserId'];
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
        if (isset($map['principalUserId'])) {
            $model->principalUserId = $map['principalUserId'];
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
