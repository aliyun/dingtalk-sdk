<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetRunningTaskListRequest extends Model
{
    /**
     * @description appType
     *
     * @var string
     */
    public $appType;

    /**
     * @description 流程实例id列表, 逗号分隔
     *
     * @var string
     */
    public $processInstanceIdList;

    /**
     * @description systemToken
     *
     * @var string
     */
    public $systemToken;

    /**
     * @description 用户所属的企业id
     *
     * @var string
     */
    public $userCorpId;

    /**
     * @description userId
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'appType'               => 'appType',
        'processInstanceIdList' => 'processInstanceIdList',
        'systemToken'           => 'systemToken',
        'userCorpId'            => 'userCorpId',
        'userId'                => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appType) {
            $res['appType'] = $this->appType;
        }
        if (null !== $this->processInstanceIdList) {
            $res['processInstanceIdList'] = $this->processInstanceIdList;
        }
        if (null !== $this->systemToken) {
            $res['systemToken'] = $this->systemToken;
        }
        if (null !== $this->userCorpId) {
            $res['userCorpId'] = $this->userCorpId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
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
        if (isset($map['appType'])) {
            $model->appType = $map['appType'];
        }
        if (isset($map['processInstanceIdList'])) {
            $model->processInstanceIdList = $map['processInstanceIdList'];
        }
        if (isset($map['systemToken'])) {
            $model->systemToken = $map['systemToken'];
        }
        if (isset($map['userCorpId'])) {
            $model->userCorpId = $map['userCorpId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
