<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetInstancesByIdListRequest extends Model
{
    /**
     * @example APP_PBKT0MFBEBTDO8T7SLVP
     *
     * @var string
     */
    public $appType;

    /**
     * @example zh_CN
     *
     * @var string
     */
    public $language;

    /**
     * @example f30233fb-72e1-4af4-8cb8-c7e0ea9ee530,d230233fb-72e1-4af4-8cb8-c7e0ea9ee530
     *
     * @var string
     */
    public $processInstanceIds;

    /**
     * @example hexxyy
     *
     * @var string
     */
    public $systemToken;

    /**
     * @example 未知
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
