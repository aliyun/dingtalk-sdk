<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\CreateSceneGroupConversationRequest;

use AlibabaCloud\Tea\Model;

class managementOptions extends Model
{
    /**
     * @var int
     */
    public $chatBannedType;

    /**
     * @var int
     */
    public $managementType;

    /**
     * @var int
     */
    public $mentionAllAuthority;

    /**
     * @var int
     */
    public $searchable;

    /**
     * @var int
     */
    public $showHistoryType;

    /**
     * @var int
     */
    public $validationType;
    protected $_name = [
        'chatBannedType' => 'chatBannedType',
        'managementType' => 'managementType',
        'mentionAllAuthority' => 'mentionAllAuthority',
        'searchable' => 'searchable',
        'showHistoryType' => 'showHistoryType',
        'validationType' => 'validationType',
    ];

    public function validate() {}

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
