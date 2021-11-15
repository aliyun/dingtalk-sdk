<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class MoveStudentRequest extends Model
{
    /**
     * @var int
     */
    public $dingIsvOrgId;

    /**
     * @var string
     */
    public $dingCorpId;

    /**
     * @var int
     */
    public $dingOauthAppId;

    /**
     * @var string
     */
    public $dingSuiteKey;

    /**
     * @var int
     */
    public $dingTokenGrantType;

    /**
     * @var int
     */
    public $dingOrgId;

    /**
     * @description 管理员id
     *
     * @var string
     */
    public $operator;

    /**
     * @description 学生id
     *
     * @var string
     */
    public $userId;

    /**
     * @description 愿班级id
     *
     * @var int
     */
    public $originClassId;

    /**
     * @description 目标班级id
     *
     * @var int
     */
    public $targetClassId;
    protected $_name = [
        'dingIsvOrgId'       => 'dingIsvOrgId',
        'dingCorpId'         => 'dingCorpId',
        'dingOauthAppId'     => 'dingOauthAppId',
        'dingSuiteKey'       => 'dingSuiteKey',
        'dingTokenGrantType' => 'dingTokenGrantType',
        'dingOrgId'          => 'dingOrgId',
        'operator'           => 'operator',
        'userId'             => 'userId',
        'originClassId'      => 'originClassId',
        'targetClassId'      => 'targetClassId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dingIsvOrgId) {
            $res['dingIsvOrgId'] = $this->dingIsvOrgId;
        }
        if (null !== $this->dingCorpId) {
            $res['dingCorpId'] = $this->dingCorpId;
        }
        if (null !== $this->dingOauthAppId) {
            $res['dingOauthAppId'] = $this->dingOauthAppId;
        }
        if (null !== $this->dingSuiteKey) {
            $res['dingSuiteKey'] = $this->dingSuiteKey;
        }
        if (null !== $this->dingTokenGrantType) {
            $res['dingTokenGrantType'] = $this->dingTokenGrantType;
        }
        if (null !== $this->dingOrgId) {
            $res['dingOrgId'] = $this->dingOrgId;
        }
        if (null !== $this->operator) {
            $res['operator'] = $this->operator;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->originClassId) {
            $res['originClassId'] = $this->originClassId;
        }
        if (null !== $this->targetClassId) {
            $res['targetClassId'] = $this->targetClassId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return MoveStudentRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dingIsvOrgId'])) {
            $model->dingIsvOrgId = $map['dingIsvOrgId'];
        }
        if (isset($map['dingCorpId'])) {
            $model->dingCorpId = $map['dingCorpId'];
        }
        if (isset($map['dingOauthAppId'])) {
            $model->dingOauthAppId = $map['dingOauthAppId'];
        }
        if (isset($map['dingSuiteKey'])) {
            $model->dingSuiteKey = $map['dingSuiteKey'];
        }
        if (isset($map['dingTokenGrantType'])) {
            $model->dingTokenGrantType = $map['dingTokenGrantType'];
        }
        if (isset($map['dingOrgId'])) {
            $model->dingOrgId = $map['dingOrgId'];
        }
        if (isset($map['operator'])) {
            $model->operator = $map['operator'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['originClassId'])) {
            $model->originClassId = $map['originClassId'];
        }
        if (isset($map['targetClassId'])) {
            $model->targetClassId = $map['targetClassId'];
        }

        return $model;
    }
}
