<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetInstancesByIdListRequest extends Model
{
    /**
     * @description 应用ID
     *
     * @var string
     */
    public $appType;

    /**
     * @description 语言
     *
     * @var string
     */
    public $language;

    /**
     * @description 流程实例ID列表，多个用,分割
     *
     * @var string
     */
    public $processInstanceIds;

    /**
     * @description 应用秘钥
     *
     * @var string
     */
    public $systemToken;

    /**
     * @description 钉钉的userId
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'appType'            => 'appType',
        'language'           => 'language',
        'processInstanceIds' => 'processInstanceIds',
        'systemToken'        => 'systemToken',
        'userId'             => 'userId',
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
        if (null !== $this->language) {
            $res['language'] = $this->language;
        }
        if (null !== $this->processInstanceIds) {
            $res['processInstanceIds'] = $this->processInstanceIds;
        }
        if (null !== $this->systemToken) {
            $res['systemToken'] = $this->systemToken;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetInstancesByIdListRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appType'])) {
            $model->appType = $map['appType'];
        }
        if (isset($map['language'])) {
            $model->language = $map['language'];
        }
        if (isset($map['processInstanceIds'])) {
            $model->processInstanceIds = $map['processInstanceIds'];
        }
        if (isset($map['systemToken'])) {
            $model->systemToken = $map['systemToken'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
