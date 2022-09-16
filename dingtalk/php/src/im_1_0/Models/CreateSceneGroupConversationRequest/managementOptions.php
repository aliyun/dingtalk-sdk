<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\CreateSceneGroupConversationRequest;

use AlibabaCloud\Tea\Model;

class managementOptions extends Model
{
    /**
     * @description 群禁言，0-默认，不禁言，1-全员禁言
     *
     * @var int
     */
    public $chatBannedType;

    /**
     * @description 管理类型，0-默认，所有人可管理，1-仅群主可管理
     *
     * @var int
     */
    public $managementType;

    /**
     * @description @ all 权限，0-默认，所有人，1-仅群主可@all
     *
     * @var int
     */
    public $mentionAllAuthority;

    /**
     * @description 群可搜索，0-默认，不可搜索，1-可搜索
     *
     * @var int
     */
    public $searchable;

    /**
     * @description 新成员是否可查看聊天历史消息，0-默认，否，1-是
     *
     * @var int
     */
    public $showHistoryType;

    /**
     * @description 入群验证，0：不入群验证（默认） 1：入群验证
     *
     * @var int
     */
    public $validationType;
    protected $_name = [
        'chatBannedType'      => 'chatBannedType',
        'managementType'      => 'managementType',
        'mentionAllAuthority' => 'mentionAllAuthority',
        'searchable'          => 'searchable',
        'showHistoryType'     => 'showHistoryType',
        'validationType'      => 'validationType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->chatBannedType) {
            $res['chatBannedType'] = $this->chatBannedType;
        }
        if (null !== $this->managementType) {
            $res['managementType'] = $this->managementType;
        }
        if (null !== $this->mentionAllAuthority) {
            $res['mentionAllAuthority'] = $this->mentionAllAuthority;
        }
        if (null !== $this->searchable) {
            $res['searchable'] = $this->searchable;
        }
        if (null !== $this->showHistoryType) {
            $res['showHistoryType'] = $this->showHistoryType;
        }
        if (null !== $this->validationType) {
            $res['validationType'] = $this->validationType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return managementOptions
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['chatBannedType'])) {
            $model->chatBannedType = $map['chatBannedType'];
        }
        if (isset($map['managementType'])) {
            $model->managementType = $map['managementType'];
        }
        if (isset($map['mentionAllAuthority'])) {
            $model->mentionAllAuthority = $map['mentionAllAuthority'];
        }
        if (isset($map['searchable'])) {
            $model->searchable = $map['searchable'];
        }
        if (isset($map['showHistoryType'])) {
            $model->showHistoryType = $map['showHistoryType'];
        }
        if (isset($map['validationType'])) {
            $model->validationType = $map['validationType'];
        }

        return $model;
    }
}
