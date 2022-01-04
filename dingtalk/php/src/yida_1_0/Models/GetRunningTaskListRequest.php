<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetRunningTaskListRequest extends Model
{
    /**
     * @description 流程实例id列表, 逗号分隔
     *
     * @var string
     */
    public $processInstanceIdList;

    /**
     * @description appType
     *
     * @var string
     */
    public $appType;

    /**
     * @description systemToken
     *
     * @var string
     */
    public $systemToken;

    /**
     * @description userId
     *
     * @var string
     */
    public $userId;

    /**
     * @description 用户所属的企业id
     *
     * @var string
     */
    public $userCorpId;
    protected $_name = [
        'processInstanceIdList' => 'processInstanceIdList',
        'appType'               => 'appType',
        'systemToken'           => 'systemToken',
        'userId'                => 'userId',
        'userCorpId'            => 'userCorpId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->processInstanceIdList) {
            $res['processInstanceIdList'] = $this->processInstanceIdList;
        }
        if (null !== $this->appType) {
            $res['appType'] = $this->appType;
        }
        if (null !== $this->systemToken) {
            $res['systemToken'] = $this->systemToken;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->userCorpId) {
            $res['userCorpId'] = $this->userCorpId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetRunningTaskListRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['processInstanceIdList'])) {
            $model->processInstanceIdList = $map['processInstanceIdList'];
        }
        if (isset($map['appType'])) {
            $model->appType = $map['appType'];
        }
        if (isset($map['systemToken'])) {
            $model->systemToken = $map['systemToken'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['userCorpId'])) {
            $model->userCorpId = $map['userCorpId'];
        }

        return $model;
    }
}
