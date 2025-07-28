<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class DigitalStoreSceneScopeRequest extends Model
{
    /**
     * @example cidxxa9122s733s1==
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @example achieveAllocate
     *
     * @var string
     */
    public $sceneCode;
    protected $_name = [
        'openConversationId' => 'openConversationId',
        'sceneCode' => 'sceneCode',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->sceneCode) {
            $res['sceneCode'] = $this->sceneCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DigitalStoreSceneScopeRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['sceneCode'])) {
            $model->sceneCode = $map['sceneCode'];
        }

        return $model;
    }
}
