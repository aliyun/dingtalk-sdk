<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateGroupTagRequest extends Model
{
    /**
     * @var int
     */
    public $dingIsvOrgId;

    /**
     * @var int
     */
    public $dingOrgId;

    /**
     * @var string
     */
    public $dingSuiteKey;

    /**
     * @var int
     */
    public $dingTokenGrantType;

    /**
     * @description 群会话ID集合
     *
     * @var string[]
     */
    public $openConversationIds;

    /**
     * @var string[]
     */
    public $tagNames;

    /**
     * @description 更新类型，APPEND、NOTAPPEND、DELETE三种类型
     *
     * @var string
     */
    public $updateType;
    protected $_name = [
        'dingIsvOrgId'        => 'dingIsvOrgId',
        'dingOrgId'           => 'dingOrgId',
        'dingSuiteKey'        => 'dingSuiteKey',
        'dingTokenGrantType'  => 'dingTokenGrantType',
        'openConversationIds' => 'openConversationIds',
        'tagNames'            => 'tagNames',
        'updateType'          => 'updateType',
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
        if (null !== $this->dingOrgId) {
            $res['dingOrgId'] = $this->dingOrgId;
        }
        if (null !== $this->dingSuiteKey) {
            $res['dingSuiteKey'] = $this->dingSuiteKey;
        }
        if (null !== $this->dingTokenGrantType) {
            $res['dingTokenGrantType'] = $this->dingTokenGrantType;
        }
        if (null !== $this->openConversationIds) {
            $res['openConversationIds'] = $this->openConversationIds;
        }
        if (null !== $this->tagNames) {
            $res['tagNames'] = $this->tagNames;
        }
        if (null !== $this->updateType) {
            $res['updateType'] = $this->updateType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateGroupTagRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dingIsvOrgId'])) {
            $model->dingIsvOrgId = $map['dingIsvOrgId'];
        }
        if (isset($map['dingOrgId'])) {
            $model->dingOrgId = $map['dingOrgId'];
        }
        if (isset($map['dingSuiteKey'])) {
            $model->dingSuiteKey = $map['dingSuiteKey'];
        }
        if (isset($map['dingTokenGrantType'])) {
            $model->dingTokenGrantType = $map['dingTokenGrantType'];
        }
        if (isset($map['openConversationIds'])) {
            if (!empty($map['openConversationIds'])) {
                $model->openConversationIds = $map['openConversationIds'];
            }
        }
        if (isset($map['tagNames'])) {
            if (!empty($map['tagNames'])) {
                $model->tagNames = $map['tagNames'];
            }
        }
        if (isset($map['updateType'])) {
            $model->updateType = $map['updateType'];
        }

        return $model;
    }
}
