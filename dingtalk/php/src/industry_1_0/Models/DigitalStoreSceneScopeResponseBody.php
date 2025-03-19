<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class DigitalStoreSceneScopeResponseBody extends Model
{
    /**
     * @example store
     *
     * @var string
     */
    public $groupConversationType;

    /**
     * @example 536239912
     *
     * @var int
     */
    public $scopeId;
    protected $_name = [
        'groupConversationType' => 'groupConversationType',
        'scopeId' => 'scopeId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->groupConversationType) {
            $res['groupConversationType'] = $this->groupConversationType;
        }
        if (null !== $this->scopeId) {
            $res['scopeId'] = $this->scopeId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DigitalStoreSceneScopeResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['groupConversationType'])) {
            $model->groupConversationType = $map['groupConversationType'];
        }
        if (isset($map['scopeId'])) {
            $model->scopeId = $map['scopeId'];
        }

        return $model;
    }
}
